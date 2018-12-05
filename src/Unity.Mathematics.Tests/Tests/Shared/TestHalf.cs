using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;
using System;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public partial class TestHalf
    {
        [TestCompiler]
        public void half_zero()
        {
            TestUtils.AreEqual(half.zero.value, 0x0000);
        }

        [TestCompiler]
        public void half2_zero()
        {
            TestUtils.AreEqual(half2.zero.x.value, 0x0000);
            TestUtils.AreEqual(half2.zero.y.value, 0x0000);
        }

        [TestCompiler]
        public void half3_zero()
        {
            TestUtils.AreEqual(half3.zero.x.value, 0x0000);
            TestUtils.AreEqual(half3.zero.y.value, 0x0000);
            TestUtils.AreEqual(half3.zero.z.value, 0x0000);
        }

        [TestCompiler]
        public void half4_zero()
        {
            TestUtils.AreEqual(half4.zero.x.value, 0x0000);
            TestUtils.AreEqual(half4.zero.y.value, 0x0000);
            TestUtils.AreEqual(half4.zero.z.value, 0x0000);
            TestUtils.AreEqual(half4.zero.w.value, 0x0000);
        }

        [TestCompiler]
        public void half_from_float_conversion()
        {
            TestUtils.AreEqual(half(0.0f).value, 0x0000);
            TestUtils.AreEqual(half(2.98e-08f).value, 0x0000);
            TestUtils.AreEqual(half(5.96046448e-08f).value, 0x0001);
            TestUtils.AreEqual(half(123.4f).value, 0x57B6);
            TestUtils.AreEqual(half(65504.0f).value, 0x7BFF);
            TestUtils.AreEqual(half(65520.0f).value, 0x7C00);
            TestUtils.AreEqual(half(float.PositiveInfinity).value, 0x7C00);
            TestUtils.AreEqual(half(float.NaN).value, 0xFE00);

            TestUtils.AreEqual(half(-2.98e-08f).value, 0x8000);
            TestUtils.AreEqual(half(-5.96046448e-08f).value, 0x8001);
            TestUtils.AreEqual(half(-123.4f).value, 0xD7B6);
            TestUtils.AreEqual(half(-65504.0f).value, 0xFBFF);
            TestUtils.AreEqual(half(-65520.0f).value, 0xFC00);
            TestUtils.AreEqual(half(float.NegativeInfinity).value, 0xFC00);
        }
        
        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void half_from_float_conversion_signed_zero()
        {
            TestUtils.AreEqual(half(-0.0f).value, 0x8000);
        }

        [TestCompiler]
        public void half2_from_float2_conversion()
        {
            half2 h0 = half2(float2(0.0f, 2.98e-08f));
            half2 h1 = half2(float2(5.96046448e-08f, 123.4f));
            half2 h2 = half2(float2(65504.0f, 65520.0f));
            half2 h3 = half2(float2(float.PositiveInfinity, float.NaN));

            half2 h4 = half2(float2(-2.98e-08f, -5.96046448e-08f));
            half2 h5 = half2(float2(-123.4f, -65504.0f));
            half2 h6 = half2(float2(-65520.0f, float.NegativeInfinity));
            half2 h7 = half2(float2(float.NegativeInfinity, 0.0f));

            TestUtils.AreEqual(uint2(h0.x.value, h0.y.value), uint2(0x0000, 0x0000));
            TestUtils.AreEqual(uint2(h1.x.value, h1.y.value), uint2(0x0001, 0x57B6));
            TestUtils.AreEqual(uint2(h2.x.value, h2.y.value), uint2(0x7BFF, 0x7C00));
            TestUtils.AreEqual(uint2(h3.x.value, h3.y.value), uint2(0x7C00, 0xFE00));

            TestUtils.AreEqual(uint2(h4.x.value, h4.y.value), uint2(0x8000, 0x8001));
            TestUtils.AreEqual(uint2(h5.x.value, h5.y.value), uint2(0xD7B6, 0xFBFF));
            TestUtils.AreEqual(uint2(h6.x.value, h6.y.value), uint2(0xFC00, 0xFC00));
            TestUtils.AreEqual(uint2(h7.x.value, h7.y.value), uint2(0xFC00, 0x0000));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void half2_from_float2_conversion_signed_zero()
        {
            half2 h0 = half2(float2(-0.0f, -0.0f));
            TestUtils.AreEqual(uint2(h0.x.value, h0.y.value), uint2(0x8000, 0x8000));
        }

        [TestCompiler]
        public void half3_from_float3_conversion()
        {
            half3 h0 = half3(float3(0.0f, 2.98e-08f, 5.96046448e-08f));
            half3 h1 = half3(float3(123.4f, 65504.0f, 65520.0f));
            half3 h2 = half3(float3(float.PositiveInfinity, float.NaN, -2.98e-08f));
            half3 h3 = half3(float3(-5.96046448e-08f, -123.4f, -65504.0f));
            half3 h4 = half3(float3(-65520.0f, float.NegativeInfinity, 0.0f));

            TestUtils.AreEqual(uint3(h0.x.value, h0.y.value, h0.z.value), uint3(0x0000, 0x0000, 0x0001));
            TestUtils.AreEqual(uint3(h1.x.value, h1.y.value, h1.z.value), uint3(0x57B6, 0x7BFF, 0x7C00));
            TestUtils.AreEqual(uint3(h2.x.value, h2.y.value, h2.z.value), uint3(0x7C00, 0xFE00, 0x8000));

            TestUtils.AreEqual(uint3(h3.x.value, h3.y.value, h3.z.value), uint3(0x8001, 0xD7B6, 0xFBFF));
            TestUtils.AreEqual(uint3(h4.x.value, h4.y.value, h4.z.value), uint3(0xFC00, 0xFC00, 0x0000));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void half3_from_float3_conversion_signed_zero()
        {
            half3 h0 = half3(float3(-0.0f, -0.0f, -0.0f));
            TestUtils.AreEqual(uint3(h0.x.value, h0.y.value, h0.z.value), uint3(0x8000, 0x8000, 0x8000));
        }

        [TestCompiler]
        public void half4_from_float4_conversion()
        {
            half4 h0 = half4(float4(0.0f, 2.98e-08f, 5.96046448e-08f, 123.4f));
            half4 h1 = half4(float4(65504.0f, 65520.0f, float.PositiveInfinity, float.NaN));
            half4 h2 = half4(float4(-2.98e-08f, -5.96046448e-08f, -123.4f, -65504.0f));
            half4 h3 = half4(float4(-65520.0f, float.NegativeInfinity, float.NegativeInfinity, 0.0f));

            TestUtils.AreEqual(uint4(h0.x.value, h0.y.value, h0.z.value, h0.w.value), uint4(0x0000, 0x0000, 0x0001, 0x57B6));
            TestUtils.AreEqual(uint4(h1.x.value, h1.y.value, h1.z.value, h1.w.value), uint4(0x7BFF, 0x7C00, 0x7C00, 0xFE00));
            TestUtils.AreEqual(uint4(h2.x.value, h2.y.value, h2.z.value, h2.w.value), uint4(0x8000, 0x8001, 0xD7B6, 0xFBFF));
            TestUtils.AreEqual(uint4(h3.x.value, h3.y.value, h3.z.value, h3.w.value), uint4(0xFC00, 0xFC00, 0xFC00, 0x0000));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void half4_from_float4_conversion_signed_zero()
        {
            half4 h0 = half4(float4(-0.0f, -0.0f, -0.0f, -0.0f));
            TestUtils.AreEqual(uint4(h0.x.value, h0.y.value, h0.z.value, h0.w.value), uint4(0x8000, 0x8000, 0x8000, 0x8000));
        }


        [TestCompiler]
        public void half_from_double_conversion()
        {
            TestUtils.AreEqual(half(0.0).value, 0x0000);
            TestUtils.AreEqual(half(2.98e-08).value, 0x0000);
            TestUtils.AreEqual(half(5.96046448e-08).value, 0x0001);
            TestUtils.AreEqual(half(123.4).value, 0x57B6);
            TestUtils.AreEqual(half(65504.0).value, 0x7BFF);
            TestUtils.AreEqual(half(65520.0).value, 0x7C00);
            TestUtils.AreEqual(half(double.PositiveInfinity).value, 0x7C00);
            TestUtils.AreEqual(half(double.NaN).value, 0xFE00);

            TestUtils.AreEqual(half(-2.98e-08).value, 0x8000);
            TestUtils.AreEqual(half(-5.96046448e-08).value, 0x8001);
            TestUtils.AreEqual(half(-123.4).value, 0xD7B6);
            TestUtils.AreEqual(half(-65504.0).value, 0xFBFF);
            TestUtils.AreEqual(half(-65520.0).value, 0xFC00);
            TestUtils.AreEqual(half(double.NegativeInfinity).value, 0xFC00);
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void half_from_double_conversion_signed_zero()
        {
            TestUtils.AreEqual(half(-0.0).value, 0x8000);
        }

        [TestCompiler]
        public void half2_from_double2_conversion()
        {
            half2 h0 = half2(double2(0.0, 2.98e-08));
            half2 h1 = half2(double2(5.96046448e-08, 123.4));
            half2 h2 = half2(double2(65504.0, 65520.0));
            half2 h3 = half2(double2(double.PositiveInfinity, double.NaN));

            half2 h4 = half2(double2(-2.98e-08, -5.96046448e-08));
            half2 h5 = half2(double2(-123.4, -65504.0));
            half2 h6 = half2(double2(-65520.0, double.NegativeInfinity));
            half2 h7 = half2(double2(double.NegativeInfinity, 0.0));

            TestUtils.AreEqual(uint2(h0.x.value, h0.y.value), uint2(0x0000, 0x0000));
            TestUtils.AreEqual(uint2(h1.x.value, h1.y.value), uint2(0x0001, 0x57B6));
            TestUtils.AreEqual(uint2(h2.x.value, h2.y.value), uint2(0x7BFF, 0x7C00));
            TestUtils.AreEqual(uint2(h3.x.value, h3.y.value), uint2(0x7C00, 0xFE00));

            TestUtils.AreEqual(uint2(h4.x.value, h4.y.value), uint2(0x8000, 0x8001));
            TestUtils.AreEqual(uint2(h5.x.value, h5.y.value), uint2(0xD7B6, 0xFBFF));
            TestUtils.AreEqual(uint2(h6.x.value, h6.y.value), uint2(0xFC00, 0xFC00));
            TestUtils.AreEqual(uint2(h7.x.value, h7.y.value), uint2(0xFC00, 0x0000));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void half2_from_double2_conversion_signed_zero()
        {
            half2 h0 = half2(double2(-0.0, -0.0));
            TestUtils.AreEqual(uint2(h0.x.value, h0.y.value), uint2(0x8000, 0x8000));
        }

        [TestCompiler]
        public void half3_from_double3_conversion()
        {
            half3 h0 = half3(double3(0.0, 2.98e-08, 5.96046448e-08));
            half3 h1 = half3(double3(123.4, 65504.0, 65520.0));
            half3 h2 = half3(double3(double.PositiveInfinity, double.NaN, -2.98e-08));
            half3 h3 = half3(double3(-5.96046448e-08, -123.4, -65504.0));
            half3 h4 = half3(double3(-65520.0, double.NegativeInfinity, 0.0));

            TestUtils.AreEqual(uint3(h0.x.value, h0.y.value, h0.z.value), uint3(0x0000, 0x0000, 0x0001));
            TestUtils.AreEqual(uint3(h1.x.value, h1.y.value, h1.z.value), uint3(0x57B6, 0x7BFF, 0x7C00));
            TestUtils.AreEqual(uint3(h2.x.value, h2.y.value, h2.z.value), uint3(0x7C00, 0xFE00, 0x8000));

            TestUtils.AreEqual(uint3(h3.x.value, h3.y.value, h3.z.value), uint3(0x8001, 0xD7B6, 0xFBFF));
            TestUtils.AreEqual(uint3(h4.x.value, h4.y.value, h4.z.value), uint3(0xFC00, 0xFC00, 0x0000));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void half3_from_double3_conversion_signed_zero()
        {
            half3 h0 = half3(double3(-0.0, -0.0, -0.0));
            TestUtils.AreEqual(uint3(h0.x.value, h0.y.value, h0.z.value), uint3(0x8000, 0x8000, 0x8000));
        }

        [TestCompiler]
        public void half4_from_double4_conversion()
        {
            half4 h0 = half4(double4(0.0, 2.98e-08, 5.96046448e-08, 123.4));
            half4 h1 = half4(double4(65504.0, 65520.0, double.PositiveInfinity, double.NaN));
            half4 h2 = half4(double4(-2.98e-08, -5.96046448e-08, -123.4, -65504.0));
            half4 h3 = half4(double4(-65520.0, double.NegativeInfinity, double.NegativeInfinity, 0.0));

            TestUtils.AreEqual(uint4(h0.x.value, h0.y.value, h0.z.value, h0.w.value), uint4(0x0000, 0x0000, 0x0001, 0x57B6));
            TestUtils.AreEqual(uint4(h1.x.value, h1.y.value, h1.z.value, h1.w.value), uint4(0x7BFF, 0x7C00, 0x7C00, 0xFE00));
            TestUtils.AreEqual(uint4(h2.x.value, h2.y.value, h2.z.value, h2.w.value), uint4(0x8000, 0x8001, 0xD7B6, 0xFBFF));
            TestUtils.AreEqual(uint4(h3.x.value, h3.y.value, h3.z.value, h3.w.value), uint4(0xFC00, 0xFC00, 0xFC00, 0x0000));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void half4_from_double4_conversion_signed_zero()
        {
            half4 h0 = half4(double4(-0.0, -0.0, -0.0, -0.0));
            TestUtils.AreEqual(uint4(h0.x.value, h0.y.value, h0.z.value, h0.w.value), uint4(0x8000, 0x8000, 0x8000, 0x8000));
        }
    }
}
