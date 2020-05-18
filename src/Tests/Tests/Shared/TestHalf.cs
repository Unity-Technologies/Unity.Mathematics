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
        public static void half_zero()
        {
            TestUtils.AreEqual(0x0000, half.zero.value);
        }

        [TestCompiler]
        public static void half2_zero()
        {
            TestUtils.AreEqual(0x0000, half2.zero.x.value);
            TestUtils.AreEqual(0x0000, half2.zero.y.value);
        }

        [TestCompiler]
        public static void half3_zero()
        {
            TestUtils.AreEqual(0x0000, half3.zero.x.value);
            TestUtils.AreEqual(0x0000, half3.zero.y.value);
            TestUtils.AreEqual(0x0000, half3.zero.z.value);
        }

        [TestCompiler]
        public static void half4_zero()
        {
            TestUtils.AreEqual(0x0000, half4.zero.x.value);
            TestUtils.AreEqual(0x0000, half4.zero.y.value);
            TestUtils.AreEqual(0x0000, half4.zero.z.value);
            TestUtils.AreEqual(0x0000, half4.zero.w.value);
        }

        [TestCompiler]
        public static void half_from_float_construction()
        {
            TestUtils.AreEqual(0x0000, half(0.0f).value);
            TestUtils.AreEqual(0x0000, half(2.98e-08f).value);
            TestUtils.AreEqual(0x0001, half(5.96046448e-08f).value);
            TestUtils.AreEqual(0x57B6, half(123.4f).value);
            TestUtils.AreEqual(0x7BFF, half(65504.0f).value);
            TestUtils.AreEqual(0x7C00, half(65520.0f).value);
            TestUtils.AreEqual(0x7C00, half(float.PositiveInfinity).value);
            TestUtils.AreEqual(0xFE00, half(TestUtils.SignedFloatQNaN()).value);

            TestUtils.AreEqual(0x8000, half(-2.98e-08f).value);
            TestUtils.AreEqual(0x8001, half(-5.96046448e-08f).value);
            TestUtils.AreEqual(0xD7B6, half(-123.4f).value);
            TestUtils.AreEqual(0xFBFF, half(-65504.0f).value);
            TestUtils.AreEqual(0xFC00, half(-65520.0f).value);
            TestUtils.AreEqual(0xFC00, half(float.NegativeInfinity).value);
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public static void half_from_float_construction_signed_zero()
        {
            TestUtils.AreEqual(0x8000, half(TestUtils.SignedFloatZero()).value);
        }

        [TestCompiler]
        public static void half2_from_float2_construction()
        {
            half2 h0 = half2(float2(0.0f, 2.98e-08f));
            half2 h1 = half2(float2(5.96046448e-08f, 123.4f));
            half2 h2 = half2(float2(65504.0f, 65520.0f));
            half2 h3 = half2(float2(float.PositiveInfinity, TestUtils.SignedFloatQNaN()));

            half2 h4 = half2(float2(-2.98e-08f, -5.96046448e-08f));
            half2 h5 = half2(float2(-123.4f, -65504.0f));
            half2 h6 = half2(float2(-65520.0f, float.NegativeInfinity));
            half2 h7 = half2(float2(float.NegativeInfinity, 0.0f));

            TestUtils.AreEqual(uint2(0x0000, 0x0000), uint2(h0.x.value, h0.y.value));
            TestUtils.AreEqual(uint2(0x0001, 0x57B6), uint2(h1.x.value, h1.y.value));
            TestUtils.AreEqual(uint2(0x7BFF, 0x7C00), uint2(h2.x.value, h2.y.value));
            TestUtils.AreEqual(uint2(0x7C00, 0xFE00), uint2(h3.x.value, h3.y.value));

            TestUtils.AreEqual(uint2(0x8000, 0x8001), uint2(h4.x.value, h4.y.value));
            TestUtils.AreEqual(uint2(0xD7B6, 0xFBFF), uint2(h5.x.value, h5.y.value));
            TestUtils.AreEqual(uint2(0xFC00, 0xFC00), uint2(h6.x.value, h6.y.value));
            TestUtils.AreEqual(uint2(0xFC00, 0x0000), uint2(h7.x.value, h7.y.value));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public static void half2_from_float2_construction_signed_zero()
        {
            half2 h0 = half2(float2(TestUtils.SignedFloatZero(), TestUtils.SignedFloatZero()));
            TestUtils.AreEqual(uint2(0x8000, 0x8000), uint2(h0.x.value, h0.y.value));
        }

        [TestCompiler]
        public static void half3_from_float3_construction()
        {
            half3 h0 = half3(float3(0.0f, 2.98e-08f, 5.96046448e-08f));
            half3 h1 = half3(float3(123.4f, 65504.0f, 65520.0f));
            half3 h2 = half3(float3(float.PositiveInfinity, TestUtils.SignedFloatQNaN(), -2.98e-08f));
            half3 h3 = half3(float3(-5.96046448e-08f, -123.4f, -65504.0f));
            half3 h4 = half3(float3(-65520.0f, float.NegativeInfinity, 0.0f));

            TestUtils.AreEqual(uint3(0x0000, 0x0000, 0x0001), uint3(h0.x.value, h0.y.value, h0.z.value));
            TestUtils.AreEqual(uint3(0x57B6, 0x7BFF, 0x7C00), uint3(h1.x.value, h1.y.value, h1.z.value));
            TestUtils.AreEqual(uint3(0x7C00, 0xFE00, 0x8000), uint3(h2.x.value, h2.y.value, h2.z.value));

            TestUtils.AreEqual(uint3(0x8001, 0xD7B6, 0xFBFF), uint3(h3.x.value, h3.y.value, h3.z.value));
            TestUtils.AreEqual(uint3(0xFC00, 0xFC00, 0x0000), uint3(h4.x.value, h4.y.value, h4.z.value));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public static void half3_from_float3_construction_signed_zero()
        {
            half3 h0 = half3(float3(TestUtils.SignedFloatZero(), TestUtils.SignedFloatZero(), TestUtils.SignedFloatZero()));
            TestUtils.AreEqual(uint3(0x8000, 0x8000, 0x8000), uint3(h0.x.value, h0.y.value, h0.z.value));
        }

        [TestCompiler]
        public static void half4_from_float4_construction()
        {
            half4 h0 = half4(float4(0.0f, 2.98e-08f, 5.96046448e-08f, 123.4f));
            half4 h1 = half4(float4(65504.0f, 65520.0f, float.PositiveInfinity, TestUtils.SignedFloatQNaN()));
            half4 h2 = half4(float4(-2.98e-08f, -5.96046448e-08f, -123.4f, -65504.0f));
            half4 h3 = half4(float4(-65520.0f, float.NegativeInfinity, float.NegativeInfinity, 0.0f));

            TestUtils.AreEqual(uint4(0x0000, 0x0000, 0x0001, 0x57B6), uint4(h0.x.value, h0.y.value, h0.z.value, h0.w.value));
            TestUtils.AreEqual(uint4(0x7BFF, 0x7C00, 0x7C00, 0xFE00), uint4(h1.x.value, h1.y.value, h1.z.value, h1.w.value));
            TestUtils.AreEqual(uint4(0x8000, 0x8001, 0xD7B6, 0xFBFF), uint4(h2.x.value, h2.y.value, h2.z.value, h2.w.value));
            TestUtils.AreEqual(uint4(0xFC00, 0xFC00, 0xFC00, 0x0000), uint4(h3.x.value, h3.y.value, h3.z.value, h3.w.value));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public static void half4_from_float4_construction_signed_zero()
        {
            half4 h0 = half4(float4(TestUtils.SignedFloatZero(), TestUtils.SignedFloatZero(), TestUtils.SignedFloatZero(), TestUtils.SignedFloatZero()));
            TestUtils.AreEqual(uint4(0x8000, 0x8000, 0x8000, 0x8000), uint4(h0.x.value, h0.y.value, h0.z.value, h0.w.value));
        }


        [TestCompiler]
        public static void half_from_double_construction()
        {
            TestUtils.AreEqual(0x0000, half(0.0).value);
            TestUtils.AreEqual(0x0000, half(2.98e-08).value);
            TestUtils.AreEqual(0x0001, half(5.96046448e-08).value);
            TestUtils.AreEqual(0x57B6, half(123.4).value);
            TestUtils.AreEqual(0x7BFF, half(65504.0).value);
            TestUtils.AreEqual(0x7C00, half(65520.0).value);
            TestUtils.AreEqual(0x7C00, half(double.PositiveInfinity).value);
            TestUtils.AreEqual(0xFE00, half(TestUtils.SignedDoubleQNaN()).value);

            TestUtils.AreEqual(0x8000, half(-2.98e-08).value);
            TestUtils.AreEqual(0x8001, half(-5.96046448e-08).value);
            TestUtils.AreEqual(0xD7B6, half(-123.4).value);
            TestUtils.AreEqual(0xFBFF, half(-65504.0).value);
            TestUtils.AreEqual(0xFC00, half(-65520.0).value);
            TestUtils.AreEqual(0xFC00, half(double.NegativeInfinity).value);
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public static void half_from_double_construction_signed_zero()
        {
            TestUtils.AreEqual(0x8000, half(TestUtils.SignedDoubleZero()).value);
        }

        [TestCompiler]
        public static void half2_from_double2_construction()
        {
            half2 h0 = half2(double2(0.0, 2.98e-08));
            half2 h1 = half2(double2(5.96046448e-08, 123.4));
            half2 h2 = half2(double2(65504.0, 65520.0));
            half2 h3 = half2(double2(double.PositiveInfinity, TestUtils.SignedDoubleQNaN()));

            half2 h4 = half2(double2(-2.98e-08, -5.96046448e-08));
            half2 h5 = half2(double2(-123.4, -65504.0));
            half2 h6 = half2(double2(-65520.0, double.NegativeInfinity));
            half2 h7 = half2(double2(double.NegativeInfinity, 0.0));

            TestUtils.AreEqual(uint2(0x0000, 0x0000), uint2(h0.x.value, h0.y.value));
            TestUtils.AreEqual(uint2(0x0001, 0x57B6), uint2(h1.x.value, h1.y.value));
            TestUtils.AreEqual(uint2(0x7BFF, 0x7C00), uint2(h2.x.value, h2.y.value));
            TestUtils.AreEqual(uint2(0x7C00, 0xFE00), uint2(h3.x.value, h3.y.value));

            TestUtils.AreEqual(uint2(0x8000, 0x8001), uint2(h4.x.value, h4.y.value));
            TestUtils.AreEqual(uint2(0xD7B6, 0xFBFF), uint2(h5.x.value, h5.y.value));
            TestUtils.AreEqual(uint2(0xFC00, 0xFC00), uint2(h6.x.value, h6.y.value));
            TestUtils.AreEqual(uint2(0xFC00, 0x0000), uint2(h7.x.value, h7.y.value));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public static void half2_from_double2_construction_signed_zero()
        {
            half2 h0 = half2(double2(TestUtils.SignedDoubleZero(), TestUtils.SignedDoubleZero()));
            TestUtils.AreEqual(uint2(0x8000, 0x8000), uint2(h0.x.value, h0.y.value));
        }

        [TestCompiler]
        public static void half3_from_double3_construction()
        {
            half3 h0 = half3(double3(0.0, 2.98e-08, 5.96046448e-08));
            half3 h1 = half3(double3(123.4, 65504.0, 65520.0));
            half3 h2 = half3(double3(double.PositiveInfinity, TestUtils.SignedDoubleQNaN(), -2.98e-08));
            half3 h3 = half3(double3(-5.96046448e-08, -123.4, -65504.0));
            half3 h4 = half3(double3(-65520.0, double.NegativeInfinity, 0.0));

            TestUtils.AreEqual(uint3(0x0000, 0x0000, 0x0001), uint3(h0.x.value, h0.y.value, h0.z.value));
            TestUtils.AreEqual(uint3(0x57B6, 0x7BFF, 0x7C00), uint3(h1.x.value, h1.y.value, h1.z.value));
            TestUtils.AreEqual(uint3(0x7C00, 0xFE00, 0x8000), uint3(h2.x.value, h2.y.value, h2.z.value));

            TestUtils.AreEqual(uint3(0x8001, 0xD7B6, 0xFBFF), uint3(h3.x.value, h3.y.value, h3.z.value));
            TestUtils.AreEqual(uint3(0xFC00, 0xFC00, 0x0000), uint3(h4.x.value, h4.y.value, h4.z.value));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public static void half3_from_double3_construction_signed_zero()
        {
            half3 h0 = half3(double3(TestUtils.SignedDoubleZero(), TestUtils.SignedDoubleZero(), TestUtils.SignedDoubleZero()));
            TestUtils.AreEqual(uint3(0x8000, 0x8000, 0x8000), uint3(h0.x.value, h0.y.value, h0.z.value));
        }

        [TestCompiler]
        public static void half4_from_double4_construction()
        {
            half4 h0 = half4(double4(0.0, 2.98e-08, 5.96046448e-08, 123.4));
            half4 h1 = half4(double4(65504.0, 65520.0, double.PositiveInfinity, TestUtils.SignedDoubleQNaN()));
            half4 h2 = half4(double4(-2.98e-08, -5.96046448e-08, -123.4, -65504.0));
            half4 h3 = half4(double4(-65520.0, double.NegativeInfinity, double.NegativeInfinity, 0.0));

            TestUtils.AreEqual(uint4(0x0000, 0x0000, 0x0001, 0x57B6), uint4(h0.x.value, h0.y.value, h0.z.value, h0.w.value));
            TestUtils.AreEqual(uint4(0x7BFF, 0x7C00, 0x7C00, 0xFE00), uint4(h1.x.value, h1.y.value, h1.z.value, h1.w.value));
            TestUtils.AreEqual(uint4(0x8000, 0x8001, 0xD7B6, 0xFBFF), uint4(h2.x.value, h2.y.value, h2.z.value, h2.w.value));
            TestUtils.AreEqual(uint4(0xFC00, 0xFC00, 0xFC00, 0x0000), uint4(h3.x.value, h3.y.value, h3.z.value, h3.w.value));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public static void half4_from_double4_construction_signed_zero()
        {
            half4 h0 = half4(double4(TestUtils.SignedDoubleZero(), TestUtils.SignedDoubleZero(), TestUtils.SignedDoubleZero(), TestUtils.SignedDoubleZero()));
            TestUtils.AreEqual(uint4(0x8000, 0x8000, 0x8000, 0x8000), uint4(h0.x.value, h0.y.value, h0.z.value, h0.w.value));
        }

        [TestCompiler]
        public static void half_to_float()
        {
            TestUtils.AreEqual(0x00000000, asuint(new half { value = 0x0000 }));
            TestUtils.AreEqual(0x3800C000, asuint(new half { value = 0x0203 }));
            TestUtils.AreEqual(0x40642000, asuint(new half { value = 0x4321 }));
            TestUtils.AreEqual(0x477FE000, asuint(new half { value = 0x7BFF }));
            TestUtils.AreEqual(0x7F800000, asuint(new half { value = 0x7C00 }));
            TestUtils.AreEqual(true, isnan(new half { value = 0x7C01 }));

            TestUtils.AreEqual(0x80000000, asuint(new half { value = 0x8000 }));
            TestUtils.AreEqual(0xB800C000, asuint(new half { value = 0x8203 }));
            TestUtils.AreEqual(0xC0642000, asuint(new half { value = 0xC321 }));
            TestUtils.AreEqual(0xC77FE000, asuint(new half { value = 0xFBFF }));
            TestUtils.AreEqual(0xFF800000, asuint(new half { value = 0xFC00 }));
            TestUtils.AreEqual(true, isnan(new half { value = 0xFC01 }));
        }

        [TestCompiler]
        public static void half2_to_float2()
        {
            half2 h0; h0.x.value = 0x0000; h0.y.value = 0x0203;
            half2 h1; h1.x.value = 0x4321; h1.y.value = 0x7BFF;
            half2 h2; h2.x.value = 0x7C00; h2.y.value = 0x7C00;
            half2 h3; h3.x.value = 0x7C01; h3.y.value = 0x7C01;

            half2 h4; h4.x.value = 0x8000; h4.y.value = 0x8203;
            half2 h5; h5.x.value = 0xC321; h5.y.value = 0xFBFF;
            half2 h6; h6.x.value = 0xFC00; h6.y.value = 0xFC00;
            half2 h7; h7.x.value = 0xFC01; h7.y.value = 0xFC01;

            TestUtils.AreEqual(uint2(0x00000000, 0x3800C000), asuint(h0));
            TestUtils.AreEqual(uint2(0x40642000, 0x477FE000), asuint(h1));
            TestUtils.AreEqual(uint2(0x7F800000, 0x7F800000), asuint(h2));
            TestUtils.AreEqual(true, all(isnan(h3)));

            TestUtils.AreEqual(uint2(0x80000000, 0xB800C000), asuint(h4));
            TestUtils.AreEqual(uint2(0xC0642000, 0xC77FE000), asuint(h5));
            TestUtils.AreEqual(uint2(0xFF800000, 0xFF800000), asuint(h6));
            TestUtils.AreEqual(true, all(isnan(h7)));
        }

        [TestCompiler]
        public static void half3_to_float3()
        {
            half3 h0; h0.x.value = 0x0000; h0.y.value = 0x0203; h0.z.value = 0x4321;
            half3 h1; h1.x.value = 0x7BFF; h1.y.value = 0x7C00; h1.z.value = 0x7C00;
            half3 h2; h2.x.value = 0x7C01; h2.y.value = 0x7C01; h2.z.value = 0x7C01;

            half3 h3; h3.x.value = 0x8000; h3.y.value = 0x8203; h3.z.value = 0xC321;
            half3 h4; h4.x.value = 0xFBFF; h4.y.value = 0xFC00; h4.z.value = 0xFC00;
            half3 h5; h5.x.value = 0xFC01; h5.y.value = 0xFC01; h5.z.value = 0xFC01;

            TestUtils.AreEqual(uint3(0x00000000, 0x3800C000, 0x40642000), asuint(h0));
            TestUtils.AreEqual(uint3(0x477FE000, 0x7F800000, 0x7F800000), asuint(h1));
            TestUtils.AreEqual(true, all(isnan(h2)));

            TestUtils.AreEqual(uint3(0x80000000, 0xB800C000, 0xC0642000), asuint(h3));
            TestUtils.AreEqual(uint3(0xC77FE000, 0xFF800000, 0xFF800000), asuint(h4));
            TestUtils.AreEqual(true, all(isnan(h5)));
        }

        [TestCompiler]
        public static void half4_to_float4()
        {
            half4 h0; h0.x.value = 0x0000; h0.y.value = 0x0203; h0.z.value = 0x4321; h0.w.value = 0x7BFF;
            half4 h1; h1.x.value = 0x7C00; h1.y.value = 0x7C00; h1.z.value = 0x7C00; h1.w.value = 0x7C00;
            half4 h2; h2.x.value = 0x7C01; h2.y.value = 0x7C01; h2.z.value = 0x7C01; h2.w.value = 0x7C01;

            half4 h3; h3.x.value = 0x8000; h3.y.value = 0x8203; h3.z.value = 0xC321; h3.w.value = 0xFBFF;
            half4 h4; h4.x.value = 0xFC00; h4.y.value = 0xFC00; h4.z.value = 0xFC00; h4.w.value = 0xFC00;
            half4 h5; h5.x.value = 0xFC01; h5.y.value = 0xFC01; h5.z.value = 0xFC01; h5.w.value = 0xFC01;

            TestUtils.AreEqual(uint4(0x00000000, 0x3800C000, 0x40642000, 0x477FE000), asuint(h0));
            TestUtils.AreEqual(uint4(0x7F800000, 0x7F800000, 0x7F800000, 0x7F800000), asuint(h1));
            TestUtils.AreEqual(true, all(isnan(h2)));

            TestUtils.AreEqual(uint4(0x80000000, 0xB800C000, 0xC0642000, 0xC77FE000), asuint(h3));
            TestUtils.AreEqual(uint4(0xFF800000, 0xFF800000, 0xFF800000, 0xFF800000), asuint(h4));
            TestUtils.AreEqual(true, all(isnan(h5)));
        }


        [TestCompiler]
        public static void half_to_double()
        {
            TestUtils.AreEqual(0x0000000000000000u, asulong((double)new half { value = 0x0000 }));
            TestUtils.AreEqual(0x3F00180000000000u, asulong((double)new half { value = 0x0203 }));
            TestUtils.AreEqual(0x400C840000000000u, asulong((double)new half { value = 0x4321 }));
            TestUtils.AreEqual(0x40eFFC0000000000u, asulong((double)new half { value = 0x7BFF }));
            TestUtils.AreEqual(0x7FF0000000000000u, asulong((double)new half { value = 0x7C00 }));
            TestUtils.AreEqual(true, isnan((double)new half { value = 0x7C01 }));

            TestUtils.AreEqual(0x8000000000000000u, asulong((double)new half { value = 0x8000 }));
            TestUtils.AreEqual(0xBF00180000000000u, asulong((double)new half { value = 0x8203 }));
            TestUtils.AreEqual(0xC00C840000000000u, asulong((double)new half { value = 0xC321 }));
            TestUtils.AreEqual(0xC0eFFC0000000000u, asulong((double)new half { value = 0xFBFF }));
            TestUtils.AreEqual(0xFFF0000000000000u, asulong((double)new half { value = 0xFC00 }));
            TestUtils.AreEqual(true, isnan((double)new half { value = 0xFC01 }));
        }


        [TestCompiler]
        public static void half_from_float_explicit_conversion()
        {
            half h = (half)123.4f;
            TestUtils.AreEqual(0x57B6, h.value);
        }

        [TestCompiler]
        public static void half2_from_float2_explicit_conversion()
        {
            half2 h = (half2)float2(123.4f, 5.96046448e-08f);
            TestUtils.AreEqual(0x57B6, h.x.value);
            TestUtils.AreEqual(0x0001, h.y.value);
        }

        [TestCompiler]
        public static void half3_from_float3_explicit_conversion()
        {
            half3 h = (half3)float3(123.4f, 5.96046448e-08f, -65504.0f);
            TestUtils.AreEqual(0x57B6, h.x.value);
            TestUtils.AreEqual(0x0001, h.y.value);
            TestUtils.AreEqual(0xFBFF, h.z.value);
        }

        [TestCompiler]
        public static void half4_from_float4_explicit_conversion()
        {
            half4 h = (half4)float4(123.4f, 5.96046448e-08f, -65504.0f, float.PositiveInfinity);
            TestUtils.AreEqual(0x57B6, h.x.value);
            TestUtils.AreEqual(0x0001, h.y.value);
            TestUtils.AreEqual(0xFBFF, h.z.value);
            TestUtils.AreEqual(0x7C00, h.w.value);
        }

        [TestCompiler]
        public static void half_from_double_explicit_conversion()
        {
            half h = (half)123.4;
            TestUtils.AreEqual(0x57B6, h.value);
        }


        [TestCompiler]
        public static void half_to_float_implicit_conversion()
        {
            half h; h.value = 0x0203;
            float f = h;
            TestUtils.AreEqual(0x3800C000, asuint(f));
        }

        [TestCompiler]
        public static void half2_to_float2_implicit_conversion()
        {
            half2 h; h.x.value = 0x0203;    h.y.value = 0x8203;
            float2 f = h;
            TestUtils.AreEqual(0x3800C000, asuint(f.x));
            TestUtils.AreEqual(0xB800C000, asuint(f.y));
        }

        [TestCompiler]
        public static void half3_to_float3_implicit_conversion()
        {
            half3 h; h.x.value = 0x0203; h.y.value = 0x8203; h.z.value = 0x7BFF;
            float3 f = h;
            TestUtils.AreEqual(0x3800C000, asuint(f.x));
            TestUtils.AreEqual(0xB800C000, asuint(f.y));
            TestUtils.AreEqual(0x477FE000, asuint(f.z));
        }

        [TestCompiler]
        public static void half4_to_float4_implicit_conversion()
        {
            half4 h; h.x.value = 0x0203; h.y.value = 0x8203; h.z.value = 0x7BFF; h.w.value = 0x7C00;
            float4 f = h;
            TestUtils.AreEqual(0x3800C000, asuint(f.x));
            TestUtils.AreEqual(0xB800C000, asuint(f.y));
            TestUtils.AreEqual(0x477FE000, asuint(f.z));
            TestUtils.AreEqual(0x7F800000, asuint(f.w));
        }

        [TestCompiler]
        public static void half_to_double_implicit_conversion()
        {
            half h; h.value = 0x0203;
            double f = h;

            TestUtils.AreEqual(0x3F00180000000000u, asulong(f));
        }

        [TestCompiler]
        public static void half_minvalue()
        {
            half min = new half(half.MinValue);
            TestUtils.AreEqual(0xfbff, min.value);
        }

        [TestCompiler]
        public static void half_maxvalue()
        {
            half max = new half(half.MaxValue);
            TestUtils.AreEqual(0x7bff, max.value);
        }

        [TestCompiler]
        public static void half_minvalueashalf()
        {
            TestUtils.AreEqual(0xfbff, half.MinValueAsHalf.value);
        }

        [TestCompiler]
        public static void half_maxvalueashalf()
        {
            TestUtils.AreEqual(0x7bff, half.MaxValueAsHalf.value);
        }

        [TestCompiler]
        public static void half2_minvalue()
        {
            half2 min = half.MinValueAsHalf;
            TestUtils.AreEqual(0xfbff, min.x.value);
            TestUtils.AreEqual(0xfbff, min.y.value);
        }

        [TestCompiler]
        public static void half2_maxvalue()
        {
            half2 max = half.MaxValueAsHalf;
            TestUtils.AreEqual(0x7bff, max.x.value);
            TestUtils.AreEqual(0x7bff, max.y.value);
        }

        [TestCompiler]
        public static void half3_minvalue()
        {
            half3 min = half.MinValueAsHalf;
            TestUtils.AreEqual(0xfbff, min.x.value);
            TestUtils.AreEqual(0xfbff, min.y.value);
            TestUtils.AreEqual(0xfbff, min.z.value);
        }

        [TestCompiler]
        public static void half3_maxvalue()
        {
            half3 max = half.MaxValueAsHalf;
            TestUtils.AreEqual(0x7bff, max.x.value);
            TestUtils.AreEqual(0x7bff, max.y.value);
            TestUtils.AreEqual(0x7bff, max.z.value);
        }

        [TestCompiler]
        public static void half4_minvalue()
        {
            half4 min = half.MinValueAsHalf;
            TestUtils.AreEqual(0xfbff, min.x.value);
            TestUtils.AreEqual(0xfbff, min.y.value);
            TestUtils.AreEqual(0xfbff, min.z.value);
            TestUtils.AreEqual(0xfbff, min.w.value);
        }

        [TestCompiler]
        public static void half4_maxvalue()
        {
            half4 max = half.MaxValueAsHalf;
            TestUtils.AreEqual(0x7bff, max.x.value);
            TestUtils.AreEqual(0x7bff, max.y.value);
            TestUtils.AreEqual(0x7bff, max.z.value);
            TestUtils.AreEqual(0x7bff, max.w.value);
        }
    }
}
