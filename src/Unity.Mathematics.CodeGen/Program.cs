using System;
using System.Globalization;
using System.IO;
using System.Threading;

namespace Unity.Mathematics.Mathematics.CodeGen
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

            var thisExeDir = Path.GetDirectoryName(typeof(MainClass).Assembly.Location);
            if (thisExeDir == null)
            {
                throw new InvalidOperationException($"Unable to get path of current assembly from `{typeof(MainClass).Assembly.Location}`");
            }
            var directory = new DirectoryInfo(thisExeDir);

            // go from `src/Unity.Mathematics.CodeGen/bin/Debug`

            // to `src/`, so 3 directories

            var parent = directory.Parent?.Parent?.Parent;
            if (parent == null)
            {
                throw new InvalidOperationException($"Unable to get path of current assembly from `{typeof(MainClass).Assembly.Location}`");
            }

            var implementationDirectory = new DirectoryInfo(Path.Combine(parent.FullName, "Unity.Mathematics"));
            if (!implementationDirectory.Exists)
            {
                throw new InvalidOperationException($"The directory `{implementationDirectory.FullName}` must exist");
            }

            var testDirectory = new DirectoryInfo(Path.Combine(parent.FullName, "Tests/Tests/Shared"));
            if (!testDirectory.Exists)
            {
                throw new InvalidOperationException($"The directory `{testDirectory.FullName}` must exist");
            }

            var performanceTestDirectory = new DirectoryInfo(Path.Combine(parent.FullName, "Unity.Mathematics.PerformanceTests"));
            if (!performanceTestDirectory.Exists)
            {
                throw new InvalidOperationException($"The directory `{performanceTestDirectory.FullName}` must exist");
            }

            Console.WriteLine("Generating swizzle and operators: " + directory);
            VectorGenerator.Write(implementationDirectory.FullName, testDirectory.FullName, performanceTestDirectory.FullName);
            Console.WriteLine("Done");
        }
    }
}
