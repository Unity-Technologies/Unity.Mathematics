// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestMath
    {
        [Test]
        public void isfinite_float()
        {
            Assert.AreEqual(isfinite(-float.NaN), false);
            Assert.AreEqual(isfinite(float.NegativeInfinity), false);
            Assert.AreEqual(isfinite(float.MinValue), true);
            Assert.AreEqual(isfinite(-1.0f), true);
            Assert.AreEqual(isfinite(0.0f), true);
            Assert.AreEqual(isfinite(1.0f), true);
            Assert.AreEqual(isfinite(float.MaxValue), true);
            Assert.AreEqual(isfinite(float.PositiveInfinity), false);
            Assert.AreEqual(isfinite(float.NaN), false);
        }

        [Test]
        public void isfinite_float2()
        {
            Assert.AreEqual(isfinite(float2(-float.NaN, float.MinValue)), bool2(false, true));
            Assert.AreEqual(isfinite(float2(float.NegativeInfinity, -1.0f)), bool2(false, true));
            Assert.AreEqual(isfinite(float2(0.0f, 1.0f)), bool2(true, true));
            Assert.AreEqual(isfinite(float2(float.MaxValue, float.PositiveInfinity)), bool2(true, false));
            Assert.AreEqual(isfinite(float2(float.NaN)), bool2(false));
        }

        [Test]
        public void isfinite_float3()
        {
            Assert.AreEqual(isfinite(float3(-float.NaN, float.NegativeInfinity, float.MinValue)), bool3(false, false, true));
            Assert.AreEqual(isfinite(float3(-1.0f, 0.0f, 1.0f)), bool3(true, true, true));
            Assert.AreEqual(isfinite(float3(float.MaxValue, float.PositiveInfinity, float.NaN)), bool3(true, false, false));
        }

        [Test]
        public void isfinite_float4()
        {
            Assert.AreEqual(isfinite(float4(-float.NaN, float.NegativeInfinity, float.MinValue, -1.0f)), bool4(false, false, true, true));
            Assert.AreEqual(isfinite(float4(0.0f, 1.0f, float.MaxValue, float.PositiveInfinity)), bool4(true, true, true, false));
            Assert.AreEqual(isfinite(float4(float.NaN)), bool4(false));
        }

        [Test]
        public void isfinite_double()
        {
            Assert.AreEqual(isfinite(-double.NaN), false);
            Assert.AreEqual(isfinite(double.NegativeInfinity), false);
            Assert.AreEqual(isfinite(double.MinValue), true);
            Assert.AreEqual(isfinite(-1.0), true);
            Assert.AreEqual(isfinite(0.0), true);
            Assert.AreEqual(isfinite(1.0), true);
            Assert.AreEqual(isfinite(double.MaxValue), true);
            Assert.AreEqual(isfinite(double.PositiveInfinity), false);
            Assert.AreEqual(isfinite(double.NaN), false);
        }

        [Test]
        public void isfinite_double2()
        {
            Assert.AreEqual(isfinite(double2(-double.NaN, double.MinValue)), bool2(false, true));
            Assert.AreEqual(isfinite(double2(double.NegativeInfinity, -1.0)), bool2(false, true));
            Assert.AreEqual(isfinite(double2(0.0, 1.0)), bool2(true, true));
            Assert.AreEqual(isfinite(double2(double.MaxValue, double.PositiveInfinity)), bool2(true, false));
            Assert.AreEqual(isfinite(double2(double.NaN)), bool2(false));
        }

        [Test]
        public void isfinite_double3()
        {
            Assert.AreEqual(isfinite(double3(-double.NaN, double.NegativeInfinity, double.MinValue)), bool3(false, false, true));
            Assert.AreEqual(isfinite(double3(-1.0, 0.0, 1.0)), bool3(true, true, true));
            Assert.AreEqual(isfinite(double3(double.MaxValue, double.PositiveInfinity, double.NaN)), bool3(true, false, false));
        }

        [Test]
        public void isfinite_double4()
        {
            Assert.AreEqual(isfinite(double4(-double.NaN, double.NegativeInfinity, double.MinValue, -1.0)), bool4(false, false, true, true));
            Assert.AreEqual(isfinite(double4(0.0, 1.0, double.MaxValue, double.PositiveInfinity)), bool4(true, true, true, false));
            Assert.AreEqual(isfinite(double4(double.NaN)), bool4(false));
        }

        [Test]
        public void isinf_float()
        {
            Assert.AreEqual(isinf(-float.NaN), false);
            Assert.AreEqual(isinf(float.NegativeInfinity), true);
            Assert.AreEqual(isinf(float.MinValue), false);
            Assert.AreEqual(isinf(-1.0f), false);
            Assert.AreEqual(isinf(0.0f), false);
            Assert.AreEqual(isinf(1.0f), false);
            Assert.AreEqual(isinf(float.MaxValue), false);
            Assert.AreEqual(isinf(float.PositiveInfinity), true);
            Assert.AreEqual(isinf(float.NaN), false);
        }

        [Test]
        public void isinf_float2()
        {
            Assert.AreEqual(isinf(float2(-float.NaN, float.NegativeInfinity)), bool2(false, true));
            Assert.AreEqual(isinf(float2(float.MinValue, -1.0f)), bool2(false, false));
            Assert.AreEqual(isinf(float2(0.0f, 1.0f)), bool2(false, false));
            Assert.AreEqual(isinf(float2(float.MaxValue, float.PositiveInfinity)), bool2(false, true));
            Assert.AreEqual(isinf(float2(float.NaN)), bool2(false));
        }

        [Test]
        public void isinf_float3()
        {
            Assert.AreEqual(isinf(float3(-float.NaN, float.NegativeInfinity, float.MinValue)), bool3(false, true, false));
            Assert.AreEqual(isinf(float3(-1.0f, 0.0f, 1.0f)), bool3(false, false, false));
            Assert.AreEqual(isinf(float3(float.MaxValue, float.PositiveInfinity, float.NaN)), bool3(false, true, false));
        }

        [Test]
        public void isinf_float4()
        {
            Assert.AreEqual(isinf(float4(-float.NaN, float.NegativeInfinity, float.MinValue, -1.0f)), bool4(false, true, false, false));
            Assert.AreEqual(isinf(float4(0.0f, 1.0f, float.MaxValue, float.PositiveInfinity)), bool4(false, false, false, true));
            Assert.AreEqual(isinf(float4(float.NaN)), bool4(false));
        }

        [Test]
        public void isinf_double()
        {
            Assert.AreEqual(isinf(-double.NaN), false);
            Assert.AreEqual(isinf(double.NegativeInfinity), true);
            Assert.AreEqual(isinf(double.MinValue), false);
            Assert.AreEqual(isinf(-1.0), false);
            Assert.AreEqual(isinf(0.0), false);
            Assert.AreEqual(isinf(1.0), false);
            Assert.AreEqual(isinf(double.MaxValue), false);
            Assert.AreEqual(isinf(double.PositiveInfinity), true);
            Assert.AreEqual(isinf(double.NaN), false);
        }

        [Test]
        public void isinf_double2()
        {
            Assert.AreEqual(isinf(double2(-double.NaN, double.NegativeInfinity)), bool2(false, true));
            Assert.AreEqual(isinf(double2(double.MinValue, -1.0)), bool2(false, false));
            Assert.AreEqual(isinf(double2(0.0, 1.0)), bool2(false, false));
            Assert.AreEqual(isinf(double2(double.MaxValue, double.PositiveInfinity)), bool2(false, true));
            Assert.AreEqual(isinf(double2(double.NaN)), bool2(false));
        }

        [Test]
        public void isinf_double3()
        {
            Assert.AreEqual(isinf(double3(-double.NaN, double.NegativeInfinity, double.MinValue)), bool3(false, true, false));
            Assert.AreEqual(isinf(double3(-1.0, 0.0, 1.0)), bool3(false, false, false));
            Assert.AreEqual(isinf(double3(double.MaxValue, double.PositiveInfinity, double.NaN)), bool3(false, true, false));
        }

        [Test]
        public void isinf_double4()
        {
            Assert.AreEqual(isinf(double4(-double.NaN, double.NegativeInfinity, double.MinValue, -1.0)), bool4(false, true, false, false));
            Assert.AreEqual(isinf(double4(0.0, 1.0, double.MaxValue, double.PositiveInfinity)), bool4(false, false, false, true));
            Assert.AreEqual(isinf(double4(double.NaN)), bool4(false));
        }

        [Test]
        public void isnan_float()
        {
            Assert.AreEqual(isnan(-float.NaN), true);
            Assert.AreEqual(isnan(float.NegativeInfinity), false);
            Assert.AreEqual(isnan(float.MinValue), false);
            Assert.AreEqual(isnan(-1.0f), false);
            Assert.AreEqual(isnan(0.0f), false);
            Assert.AreEqual(isnan(1.0f), false);
            Assert.AreEqual(isnan(float.MaxValue), false);
            Assert.AreEqual(isnan(float.PositiveInfinity), false);
            Assert.AreEqual(isnan(float.NaN), true);
        }

        [Test]
        public void isnan_float2()
        {
            Assert.AreEqual(isnan(float2(-float.NaN, float.NegativeInfinity)), bool2(true, false));
            Assert.AreEqual(isnan(float2(float.MinValue, -1.0f)), bool2(false, false));
            Assert.AreEqual(isnan(float2(0.0f, 1.0f)), bool2(false, false));
            Assert.AreEqual(isnan(float2(float.MaxValue, float.PositiveInfinity)), bool2(false, false));
            Assert.AreEqual(isnan(float2(float.NaN)), bool2(true));
        }

        [Test]
        public void isnan_float3()
        {
            Assert.AreEqual(isnan(float3(-float.NaN, float.NegativeInfinity, float.MinValue)), bool3(true, false, false));
            Assert.AreEqual(isnan(float3(-1.0f, 0.0f, 1.0f)), bool3(false, false, false));
            Assert.AreEqual(isnan(float3(float.MaxValue, float.PositiveInfinity, float.NaN)), bool3(false, false, true));
        }

        [Test]
        public void isnan_float4()
        {
            Assert.AreEqual(isnan(float4(-float.NaN, float.NegativeInfinity, float.MinValue, -1.0f)), bool4(true, false, false, false));
            Assert.AreEqual(isnan(float4(0.0f, 1.0f, float.MaxValue, float.PositiveInfinity)), bool4(false, false, false, false));
            Assert.AreEqual(isnan(float4(float.NaN)), bool4(true));
        }

        [Test]
        public void isnan_double()
        {
            Assert.AreEqual(isnan(-double.NaN), true);
            Assert.AreEqual(isnan(double.NegativeInfinity), false);
            Assert.AreEqual(isnan(double.MinValue), false);
            Assert.AreEqual(isnan(-1.0), false);
            Assert.AreEqual(isnan(0.0), false);
            Assert.AreEqual(isnan(1.0), false);
            Assert.AreEqual(isnan(double.MaxValue), false);
            Assert.AreEqual(isnan(double.PositiveInfinity), false);
            Assert.AreEqual(isnan(double.NaN), true);
        }

        [Test]
        public void isnan_double2()
        {
            Assert.AreEqual(isnan(double2(-double.NaN, double.NegativeInfinity)), bool2(true, false));
            Assert.AreEqual(isnan(double2(double.MinValue, -1.0)), bool2(false, false));
            Assert.AreEqual(isnan(double2(0.0, 1.0)), bool2(false, false));
            Assert.AreEqual(isnan(double2(double.MaxValue, double.PositiveInfinity)), bool2(false, false));
            Assert.AreEqual(isnan(double2(double.NaN)), bool2(true));
        }

        [Test]
        public void isnan_double3()
        {
            Assert.AreEqual(isnan(double3(-double.NaN, double.NegativeInfinity, double.MinValue)), bool3(true, false, false));
            Assert.AreEqual(isnan(double3(-1.0, 0.0, 1.0)), bool3(false, false, false));
            Assert.AreEqual(isnan(double3(double.MaxValue, double.PositiveInfinity, double.NaN)), bool3(false, false, true));
        }

        [Test]
        public void isnan_double4()
        {
            Assert.AreEqual(isnan(double4(-double.NaN, double.NegativeInfinity, double.MinValue, -1.0)), bool4(true, false, false, false));
            Assert.AreEqual(isnan(double4(0.0, 1.0, double.MaxValue, double.PositiveInfinity)), bool4(false, false, false, false));
            Assert.AreEqual(isnan(double4(double.NaN)), bool4(true));
        }
    }
}
