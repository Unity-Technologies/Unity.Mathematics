using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace Burst.Compiler.IL.Tests
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
    public sealed class TestCompilerAttribute : TestCaseAttribute, ITestBuilder
    {
    }
}