// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public partial class TestMath
    {
        [TestCompiler]
        public void abs_int()
        {
            TestUtils.AreEqual(abs(0), 0);
            TestUtils.AreEqual(abs(-7), 7);
            TestUtils.AreEqual(abs(11), 11);
            TestUtils.AreEqual(abs(-2147483647), 2147483647);
            TestUtils.AreEqual(abs(-2147483648), -2147483648);
        }

        [TestCompiler]
        public void abs_int2()
        {
            TestUtils.AreEqual(abs(int2(0, -7)), int2(0, 7));
            TestUtils.AreEqual(abs(int2(11, -2147483647)), int2(11, 2147483647));
            TestUtils.AreEqual(abs(int2(-2147483648, -2147483648)), int2(-2147483648, -2147483648));
        }

        [TestCompiler]
        public void abs_int3()
        {
            TestUtils.AreEqual(abs(int3(0, -7, 11)), int3(0, 7, 11));
            TestUtils.AreEqual(abs(int3(-2147483647, -2147483648, -2147483648)), int3(2147483647, -2147483648, -2147483648));
        }

        [TestCompiler]
        public void abs_int4()
        {
            TestUtils.AreEqual(abs(int4(0, -7, 11, -2147483647)), int4(0, 7, 11, 2147483647));
            TestUtils.AreEqual(abs(int4(-2147483648, -2147483648, -2147483648, -2147483648)), int4(-2147483648, -2147483648, -2147483648, -2147483648));
        }

        [TestCompiler]
        public void abs_float()
        {
            TestUtils.AreEqual(abs(0f), 0f);
            TestUtils.AreEqual(abs(-1.1f), 1.1f);
            TestUtils.AreEqual(abs(2.2f), 2.2f);
            TestUtils.AreEqual(abs(float.NegativeInfinity), float.PositiveInfinity);
            TestUtils.AreEqual(abs(float.PositiveInfinity), float.PositiveInfinity);
        }

        [TestCompiler]
        public void abs_float2()
        {
            TestUtils.AreEqual(abs(float2(0f, -1.1f)), float2(0f, 1.1f));
            TestUtils.AreEqual(abs(float2(2.2f, float.NegativeInfinity)), float2(2.2f, float.PositiveInfinity));
            TestUtils.AreEqual(abs(float2(float.PositiveInfinity, float.PositiveInfinity)), float2(float.PositiveInfinity, float.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_float3()
        {
            TestUtils.AreEqual(abs(float3(0f, -1.1f, 2.2f)), float3(0f, 1.1f, 2.2f));
            TestUtils.AreEqual(abs(float3(float.NegativeInfinity, float.PositiveInfinity, float.PositiveInfinity)), float3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_float4()
        {
            TestUtils.AreEqual(abs(float4(0f, -1.1f, 2.2f, float.NegativeInfinity)), float4(0f, 1.1f, 2.2f, float.PositiveInfinity));
            TestUtils.AreEqual(abs(float4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity)), float4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_double()
        {
            TestUtils.AreEqual(abs(0), 0);
            TestUtils.AreEqual(abs(-1.1), 1.1);
            TestUtils.AreEqual(abs(2.2), 2.2);
            TestUtils.AreEqual(abs(double.NegativeInfinity), double.PositiveInfinity);
            TestUtils.AreEqual(abs(double.PositiveInfinity), double.PositiveInfinity);
        }

        [TestCompiler]
        public void abs_double2()
        {
            TestUtils.AreEqual(abs(double2(0, -1.1)), double2(0, 1.1));
            TestUtils.AreEqual(abs(double2(2.2, double.NegativeInfinity)), double2(2.2, double.PositiveInfinity));
            TestUtils.AreEqual(abs(double2(double.PositiveInfinity, double.PositiveInfinity)), double2(double.PositiveInfinity, double.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_double3()
        {
            TestUtils.AreEqual(abs(double3(0, -1.1, 2.2)), double3(0, 1.1, 2.2));
            TestUtils.AreEqual(abs(double3(double.NegativeInfinity, double.PositiveInfinity, double.PositiveInfinity)), double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity));
        }

        [TestCompiler]
        public void abs_double4()
        {
            TestUtils.AreEqual(abs(double4(0, -1.1, 2.2, double.NegativeInfinity)), double4(0, 1.1, 2.2, double.PositiveInfinity));
            TestUtils.AreEqual(abs(double4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity)), double4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity));
        }

        [TestCompiler]
        public void isfinite_float()
        {
            TestUtils.AreEqual(isfinite(float.NegativeInfinity), false);
            TestUtils.AreEqual(isfinite(float.MinValue), true);
            TestUtils.AreEqual(isfinite(-1f), true);
            TestUtils.AreEqual(isfinite(0f), true);
            TestUtils.AreEqual(isfinite(1f), true);
            TestUtils.AreEqual(isfinite(float.MaxValue), true);
            TestUtils.AreEqual(isfinite(float.PositiveInfinity), false);
            TestUtils.AreEqual(isfinite(float.NaN), false);
        }

        [TestCompiler]
        public void isfinite_float2()
        {
            TestUtils.AreEqual(isfinite(float2(float.NegativeInfinity, float.MinValue)), bool2(false, true));
            TestUtils.AreEqual(isfinite(float2(-1f, 0f)), bool2(true, true));
            TestUtils.AreEqual(isfinite(float2(1f, float.MaxValue)), bool2(true, true));
            TestUtils.AreEqual(isfinite(float2(float.PositiveInfinity, float.NaN)), bool2(false, false));
        }

        [TestCompiler]
        public void isfinite_float3()
        {
            TestUtils.AreEqual(isfinite(float3(float.NegativeInfinity, float.MinValue, -1f)), bool3(false, true, true));
            TestUtils.AreEqual(isfinite(float3(0f, 1f, float.MaxValue)), bool3(true, true, true));
            TestUtils.AreEqual(isfinite(float3(float.PositiveInfinity, float.NaN, float.NaN)), bool3(false, false, false));
        }

        [TestCompiler]
        public void isfinite_float4()
        {
            TestUtils.AreEqual(isfinite(float4(float.NegativeInfinity, float.MinValue, -1f, 0f)), bool4(false, true, true, true));
            TestUtils.AreEqual(isfinite(float4(1f, float.MaxValue, float.PositiveInfinity, float.NaN)), bool4(true, true, false, false));
        }

        [TestCompiler]
        public void isfinite_double()
        {
            TestUtils.AreEqual(isfinite(double.NegativeInfinity), false);
            TestUtils.AreEqual(isfinite(double.MinValue), true);
            TestUtils.AreEqual(isfinite(-1), true);
            TestUtils.AreEqual(isfinite(0), true);
            TestUtils.AreEqual(isfinite(1), true);
            TestUtils.AreEqual(isfinite(double.MaxValue), true);
            TestUtils.AreEqual(isfinite(double.PositiveInfinity), false);
            TestUtils.AreEqual(isfinite(double.NaN), false);
        }

        [TestCompiler]
        public void isfinite_double2()
        {
            TestUtils.AreEqual(isfinite(double2(double.NegativeInfinity, double.MinValue)), bool2(false, true));
            TestUtils.AreEqual(isfinite(double2(-1, 0)), bool2(true, true));
            TestUtils.AreEqual(isfinite(double2(1, double.MaxValue)), bool2(true, true));
            TestUtils.AreEqual(isfinite(double2(double.PositiveInfinity, double.NaN)), bool2(false, false));
        }

        [TestCompiler]
        public void isfinite_double3()
        {
            TestUtils.AreEqual(isfinite(double3(double.NegativeInfinity, double.MinValue, -1)), bool3(false, true, true));
            TestUtils.AreEqual(isfinite(double3(0, 1, double.MaxValue)), bool3(true, true, true));
            TestUtils.AreEqual(isfinite(double3(double.PositiveInfinity, double.NaN, double.NaN)), bool3(false, false, false));
        }

        [TestCompiler]
        public void isfinite_double4()
        {
            TestUtils.AreEqual(isfinite(double4(double.NegativeInfinity, double.MinValue, -1, 0)), bool4(false, true, true, true));
            TestUtils.AreEqual(isfinite(double4(1, double.MaxValue, double.PositiveInfinity, double.NaN)), bool4(true, true, false, false));
        }

        [TestCompiler]
        public void isinf_float()
        {
            TestUtils.AreEqual(isinf(float.NegativeInfinity), true);
            TestUtils.AreEqual(isinf(float.MinValue), false);
            TestUtils.AreEqual(isinf(-1f), false);
            TestUtils.AreEqual(isinf(0f), false);
            TestUtils.AreEqual(isinf(1f), false);
            TestUtils.AreEqual(isinf(float.MaxValue), false);
            TestUtils.AreEqual(isinf(float.PositiveInfinity), true);
            TestUtils.AreEqual(isinf(float.NaN), false);
        }

        [TestCompiler]
        public void isinf_float2()
        {
            TestUtils.AreEqual(isinf(float2(float.NegativeInfinity, float.MinValue)), bool2(true, false));
            TestUtils.AreEqual(isinf(float2(-1f, 0f)), bool2(false, false));
            TestUtils.AreEqual(isinf(float2(1f, float.MaxValue)), bool2(false, false));
            TestUtils.AreEqual(isinf(float2(float.PositiveInfinity, float.NaN)), bool2(true, false));
        }

        [TestCompiler]
        public void isinf_float3()
        {
            TestUtils.AreEqual(isinf(float3(float.NegativeInfinity, float.MinValue, -1f)), bool3(true, false, false));
            TestUtils.AreEqual(isinf(float3(0f, 1f, float.MaxValue)), bool3(false, false, false));
            TestUtils.AreEqual(isinf(float3(float.PositiveInfinity, float.NaN, float.NaN)), bool3(true, false, false));
        }

        [TestCompiler]
        public void isinf_float4()
        {
            TestUtils.AreEqual(isinf(float4(float.NegativeInfinity, float.MinValue, -1f, 0f)), bool4(true, false, false, false));
            TestUtils.AreEqual(isinf(float4(1f, float.MaxValue, float.PositiveInfinity, float.NaN)), bool4(false, false, true, false));
        }

        [TestCompiler]
        public void isinf_double()
        {
            TestUtils.AreEqual(isinf(double.NegativeInfinity), true);
            TestUtils.AreEqual(isinf(double.MinValue), false);
            TestUtils.AreEqual(isinf(-1), false);
            TestUtils.AreEqual(isinf(0), false);
            TestUtils.AreEqual(isinf(1), false);
            TestUtils.AreEqual(isinf(double.MaxValue), false);
            TestUtils.AreEqual(isinf(double.PositiveInfinity), true);
            TestUtils.AreEqual(isinf(double.NaN), false);
        }

        [TestCompiler]
        public void isinf_double2()
        {
            TestUtils.AreEqual(isinf(double2(double.NegativeInfinity, double.MinValue)), bool2(true, false));
            TestUtils.AreEqual(isinf(double2(-1, 0)), bool2(false, false));
            TestUtils.AreEqual(isinf(double2(1, double.MaxValue)), bool2(false, false));
            TestUtils.AreEqual(isinf(double2(double.PositiveInfinity, double.NaN)), bool2(true, false));
        }

        [TestCompiler]
        public void isinf_double3()
        {
            TestUtils.AreEqual(isinf(double3(double.NegativeInfinity, double.MinValue, -1)), bool3(true, false, false));
            TestUtils.AreEqual(isinf(double3(0, 1, double.MaxValue)), bool3(false, false, false));
            TestUtils.AreEqual(isinf(double3(double.PositiveInfinity, double.NaN, double.NaN)), bool3(true, false, false));
        }

        [TestCompiler]
        public void isinf_double4()
        {
            TestUtils.AreEqual(isinf(double4(double.NegativeInfinity, double.MinValue, -1, 0)), bool4(true, false, false, false));
            TestUtils.AreEqual(isinf(double4(1, double.MaxValue, double.PositiveInfinity, double.NaN)), bool4(false, false, true, false));
        }

        [TestCompiler]
        public void isnan_float()
        {
            TestUtils.AreEqual(isnan(float.NegativeInfinity), false);
            TestUtils.AreEqual(isnan(float.MinValue), false);
            TestUtils.AreEqual(isnan(-1f), false);
            TestUtils.AreEqual(isnan(0f), false);
            TestUtils.AreEqual(isnan(1f), false);
            TestUtils.AreEqual(isnan(float.MaxValue), false);
            TestUtils.AreEqual(isnan(float.PositiveInfinity), false);
            TestUtils.AreEqual(isnan(float.NaN), true);
        }

        [TestCompiler]
        public void isnan_float2()
        {
            TestUtils.AreEqual(isnan(float2(float.NegativeInfinity, float.MinValue)), bool2(false, false));
            TestUtils.AreEqual(isnan(float2(-1f, 0f)), bool2(false, false));
            TestUtils.AreEqual(isnan(float2(1f, float.MaxValue)), bool2(false, false));
            TestUtils.AreEqual(isnan(float2(float.PositiveInfinity, float.NaN)), bool2(false, true));
        }

        [TestCompiler]
        public void isnan_float3()
        {
            TestUtils.AreEqual(isnan(float3(float.NegativeInfinity, float.MinValue, -1f)), bool3(false, false, false));
            TestUtils.AreEqual(isnan(float3(0f, 1f, float.MaxValue)), bool3(false, false, false));
            TestUtils.AreEqual(isnan(float3(float.PositiveInfinity, float.NaN, float.NaN)), bool3(false, true, true));
        }

        [TestCompiler]
        public void isnan_float4()
        {
            TestUtils.AreEqual(isnan(float4(float.NegativeInfinity, float.MinValue, -1f, 0f)), bool4(false, false, false, false));
            TestUtils.AreEqual(isnan(float4(1f, float.MaxValue, float.PositiveInfinity, float.NaN)), bool4(false, false, false, true));
        }

        [TestCompiler]
        public void isnan_double()
        {
            TestUtils.AreEqual(isnan(double.NegativeInfinity), false);
            TestUtils.AreEqual(isnan(double.MinValue), false);
            TestUtils.AreEqual(isnan(-1), false);
            TestUtils.AreEqual(isnan(0), false);
            TestUtils.AreEqual(isnan(1), false);
            TestUtils.AreEqual(isnan(double.MaxValue), false);
            TestUtils.AreEqual(isnan(double.PositiveInfinity), false);
            TestUtils.AreEqual(isnan(double.NaN), true);
        }

        [TestCompiler]
        public void isnan_double2()
        {
            TestUtils.AreEqual(isnan(double2(double.NegativeInfinity, double.MinValue)), bool2(false, false));
            TestUtils.AreEqual(isnan(double2(-1, 0)), bool2(false, false));
            TestUtils.AreEqual(isnan(double2(1, double.MaxValue)), bool2(false, false));
            TestUtils.AreEqual(isnan(double2(double.PositiveInfinity, double.NaN)), bool2(false, true));
        }

        [TestCompiler]
        public void isnan_double3()
        {
            TestUtils.AreEqual(isnan(double3(double.NegativeInfinity, double.MinValue, -1)), bool3(false, false, false));
            TestUtils.AreEqual(isnan(double3(0, 1, double.MaxValue)), bool3(false, false, false));
            TestUtils.AreEqual(isnan(double3(double.PositiveInfinity, double.NaN, double.NaN)), bool3(false, true, true));
        }

        [TestCompiler]
        public void isnan_double4()
        {
            TestUtils.AreEqual(isnan(double4(double.NegativeInfinity, double.MinValue, -1, 0)), bool4(false, false, false, false));
            TestUtils.AreEqual(isnan(double4(1, double.MaxValue, double.PositiveInfinity, double.NaN)), bool4(false, false, false, true));
        }


    }
}
