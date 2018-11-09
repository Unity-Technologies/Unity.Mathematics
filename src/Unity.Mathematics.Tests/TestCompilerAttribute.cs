using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Burst.Compiler.IL.Tests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class WindowsOnlyAttribute : IgnoreAttribute, IApplyToTest
    {
#pragma warning disable CS0414
        public WindowsOnlyAttribute(string reason) : base(reason)
        {
        }
#pragma warning restore CS0414
    }

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class TestCompilerAttribute : TestCaseAttribute, ITestBuilder
    {
    }
}