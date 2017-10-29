using System;
using System.IO;

namespace Unity.Mathematics.Mathematics.CodeGen
{
    class MainClass
    {
        public static void Main (string[] args)
        {
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

            directory = new DirectoryInfo(Path.Combine(parent.FullName, "Unity.Mathematics"));
            if (!directory.Exists)
            {
                throw new InvalidOperationException($"The directory `{directory.FullName}` must exist");
            }

            Console.WriteLine("Generating swizzle and operators: " + directory);
            VectorGenerator.Write(directory.FullName);
            Console.WriteLine("Done");
        }
    }
}
