using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public partial class TestMath
    {
        [TestCompiler]
        public void asint_uint()
        {
            TestUtils.AreEqual(asint(0u), 0);
            TestUtils.AreEqual(asint(0x12345678u), 0x12345678);
            TestUtils.AreEqual(asint(0x7FFFFFFFu), 0x7FFFFFFF);
            TestUtils.AreEqual(asint(0x80000000u), -2147483648);
            TestUtils.AreEqual(asint(0x87654321u), -2023406815);
            TestUtils.AreEqual(asint(0xFFFFFFFFu), -1);
        }

        [TestCompiler]
        public void asint_uint2()
        {
            TestUtils.AreEqual(asint(uint2(0u, 0x12345678u)), int2(0, 0x12345678));
            TestUtils.AreEqual(asint(uint2(0x7FFFFFFFu, 0x80000000u)), int2(0x7FFFFFFF, -2147483648));
            TestUtils.AreEqual(asint(uint2(0x87654321u, 0xFFFFFFFFu)), int2(-2023406815, -1));
        }

        [TestCompiler]
        public void asint_uint3()
        {
            TestUtils.AreEqual(asint(uint3(0u, 0x12345678u, 0x7FFFFFFFu)), int3(0, 0x12345678, 0x7FFFFFFF));
            TestUtils.AreEqual(asint(uint3(0x80000000u, 0x87654321u, 0xFFFFFFFFu)), int3(-2147483648, -2023406815, -1));
        }

        [TestCompiler]
        public void asint_uint4()
        {
            TestUtils.AreEqual(asint(uint4(0u, 0x12345678u, 0x7FFFFFFFu, 0x80000000u)), int4(0, 0x12345678, 0x7FFFFFFF, -2147483648));
            TestUtils.AreEqual(asint(uint4(0x87654321u, 0xFFFFFFFFu, 0u, 0u)), int4(-2023406815, -1, 0, 0));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asint_float()
        {
            TestUtils.AreEqual(asint(0.0f), 0);
            TestUtils.AreEqual(asint(1.0f), 0x3F800000);
            TestUtils.AreEqual(asint(1234.56f), 0x449A51EC);
            TestUtils.AreEqual(asint(float.PositiveInfinity), 0x7F800000);
            TestUtils.AreEqual(asint(float.NaN), unchecked((int)0xFFC00000));

            TestUtils.AreEqual(asint(-0.0f), unchecked((int)0x80000000));
            TestUtils.AreEqual(asint(-1.0f), unchecked((int)0xBF800000));
            TestUtils.AreEqual(asint(-1234.56f), unchecked((int)0xC49A51EC));
            TestUtils.AreEqual(asint(float.NegativeInfinity), unchecked((int)0xFF800000));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asint_float2()
        {
            TestUtils.AreEqual(asint(float2(0.0f, 1.0f)), int2(0, 0x3F800000));
            TestUtils.AreEqual(asint(float2(1234.56f, float.PositiveInfinity)), int2(0x449A51EC, 0x7F800000));
            TestUtils.AreEqual(asint(float2(float.NaN, -0.0f)), int2(unchecked((int)0xFFC00000), unchecked((int)0x80000000)));

            TestUtils.AreEqual(asint(float2(-1.0f, -1234.56f)), int2(unchecked((int)0xBF800000), unchecked((int)0xC49A51EC)));
            TestUtils.AreEqual(asint(float2(float.NegativeInfinity, 0.0f)), int2(unchecked((int)0xFF800000), 0));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asint_float3()
        {
            TestUtils.AreEqual(asint(float3(0.0f, 1.0f, 1234.56f)), int3(0, 0x3F800000, 0x449A51EC));
            TestUtils.AreEqual(asint(float3(float.PositiveInfinity, float.NaN, -0.0f)), int3(0x7F800000, unchecked((int)0xFFC00000), unchecked((int)0x80000000)));
            TestUtils.AreEqual(asint(float3(-1.0f, -1234.56f, float.NegativeInfinity)), int3(unchecked((int)0xBF800000), unchecked((int)0xC49A51EC), unchecked((int)0xFF800000)));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asint_float4()
        {
            TestUtils.AreEqual(asint(float4(0.0f, 1.0f, 1234.56f, float.PositiveInfinity)), int4(0, 0x3F800000, 0x449A51EC, 0x7F800000));
            TestUtils.AreEqual(asint(float4(float.NaN, -0.0f, -1.0f, -1234.56f)), int4(unchecked((int)0xFFC00000), unchecked((int)0x80000000), unchecked((int)0xBF800000), unchecked((int)0xC49A51EC)));
            TestUtils.AreEqual(asint(float4(float.NegativeInfinity, 0.0f, 0.0f, 0.0f)), int4(unchecked((int)0xFF800000), 0, 0, 0));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asuint_int()
        {
            TestUtils.AreEqual(asuint(0), 0u);
            TestUtils.AreEqual(asuint(0x12345678), 0x12345678u);
            TestUtils.AreEqual(asuint(0x7FFFFFFF), 0x7FFFFFFFu);
            TestUtils.AreEqual(asuint(-2147483648), 0x80000000u);
            TestUtils.AreEqual(asuint(-2023406815), 0x87654321u);
            TestUtils.AreEqual(asuint(-1), 0xFFFFFFFFu);
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asuint_int2()
        {
            TestUtils.AreEqual(asuint(int2(0, 0x12345678)), uint2(0u, 0x12345678u));
            TestUtils.AreEqual(asuint(int2(0x7FFFFFFF, -2147483648)), uint2(0x7FFFFFFFu, 0x80000000u));
            TestUtils.AreEqual(asuint(int2(-2023406815, -1)), uint2(0x87654321u, 0xFFFFFFFFu));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asuint_int3()
        {
            TestUtils.AreEqual(asuint(int3(0, 0x12345678, 0x7FFFFFFF)), uint3(0u, 0x12345678u, 0x7FFFFFFFu));
            TestUtils.AreEqual(asuint(int3(-2147483648, -2023406815, -1)), uint3(0x80000000u, 0x87654321u, 0xFFFFFFFFu));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asuint_int4()
        {
            TestUtils.AreEqual(asuint(int4(0, 0x12345678, 0x7FFFFFFF, -2147483648)), uint4(0u, 0x12345678u, 0x7FFFFFFFu, 0x80000000u));
            TestUtils.AreEqual(asuint(int4(-2023406815, -1, 0, 0)), uint4(0x87654321u, 0xFFFFFFFFu, 0u, 0u));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asuint_float()
        {
            TestUtils.AreEqual(asuint(0.0f), 0u);
            TestUtils.AreEqual(asuint(1.0f), 0x3F800000u);
            TestUtils.AreEqual(asuint(1234.56f), 0x449A51ECu);
            TestUtils.AreEqual(asuint(float.PositiveInfinity), 0x7F800000u);
            TestUtils.AreEqual(asuint(float.NaN), 0xFFC00000u);

            TestUtils.AreEqual(asuint(-0.0f), 0x80000000u);
            TestUtils.AreEqual(asuint(-1.0f), 0xBF800000u);
            TestUtils.AreEqual(asuint(-1234.56f), 0xC49A51ECu);
            TestUtils.AreEqual(asuint(float.NegativeInfinity), 0xFF800000u);
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asuint_float2()
        {
            TestUtils.AreEqual(asuint(float2(0.0f, 1.0f)), uint2(0u, 0x3F800000u));
            TestUtils.AreEqual(asuint(float2(1234.56f, float.PositiveInfinity)), uint2(0x449A51Ecu, 0x7F800000u));
            TestUtils.AreEqual(asuint(float2(float.NaN, -0.0f)), uint2(0xFFC00000u, 0x80000000u));

            TestUtils.AreEqual(asuint(float2(-1.0f, -1234.56f)), uint2(0xBF800000u, 0xC49A51ECu));
            TestUtils.AreEqual(asuint(float2(float.NegativeInfinity, 0.0f)), uint2(0xFF800000u, 0u));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asuint_float3()
        {
            TestUtils.AreEqual(asuint(float3(0.0f, 1.0f, 1234.56f)), uint3(0u, 0x3F800000u, 0x449A51ECu));
            TestUtils.AreEqual(asuint(float3(float.PositiveInfinity, float.NaN, -0.0f)), uint3(0x7F800000u, 0xFFC00000u, 0x80000000u));
            TestUtils.AreEqual(asuint(float3(-1.0f, -1234.56f, float.NegativeInfinity)), uint3(0xBF800000u, 0xC49A51ECu, 0xff800000u));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asuint_float4()
        {
            TestUtils.AreEqual(asuint(float4(0.0f, 1.0f, 1234.56f, float.PositiveInfinity)), uint4(0u, 0x3F800000u, 0x449A51ECu, 0x7F800000u));
            TestUtils.AreEqual(asuint(float4(float.NaN, -0.0f, -1.0f, -1234.56f)), uint4(0xFFC00000u, 0x80000000u, 0xBF800000u, 0xC49A51ECu));
            TestUtils.AreEqual(asuint(float4(float.NegativeInfinity, 0.0f, 0.0f, 0.0f)), uint4(0xFF800000u, 0u, 0u, 0u));
        }

        [TestCompiler]
        public void aslong_ulong()
        {
            TestUtils.AreEqual(aslong(0ul), 0L);
            TestUtils.AreEqual(aslong(0x0123456789ABCDEFul), 0x0123456789ABCDEFL);
            TestUtils.AreEqual(aslong(0x7FFFFFFFFFFFFFFFul), 0x7FFFFFFFFFFFFFFFL);
            TestUtils.AreEqual(aslong(0x8000000000000000ul), -9223372036854775808L);
            TestUtils.AreEqual(aslong(0xFEDCBA9876543210ul), -81985529216486896L);
            TestUtils.AreEqual(aslong(0xFFFFFFFFFFFFFFFFul), -1L);
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void aslong_double()
        {
            TestUtils.AreEqual(aslong(0.0), 0L);
            TestUtils.AreEqual(aslong(1.0), 0x3FF0000000000000L);
            TestUtils.AreEqual(aslong(1234.56), 0x40934A3D70A3D70AL);
            TestUtils.AreEqual(aslong(double.PositiveInfinity), 0x7FF0000000000000L);
            TestUtils.AreEqual(aslong(double.NaN), unchecked((long)0xFFF8000000000000UL));

            TestUtils.AreEqual(aslong(-0.0), unchecked((long)0x8000000000000000UL));
            TestUtils.AreEqual(aslong(-1.0), unchecked((long)0xBFF0000000000000UL));
            TestUtils.AreEqual(aslong(-1234.56), unchecked((long)0xC0934A3D70A3D70AUL));
            TestUtils.AreEqual(aslong(double.NegativeInfinity), unchecked((long)0xFFF0000000000000UL));
        }

        [TestCompiler]
        public void asulong_long()
        {
            TestUtils.AreEqual(asulong(0L), 0ul);
            TestUtils.AreEqual(asulong(0x0123456789ABCDEFL), 0x0123456789ABCDEFul);
            TestUtils.AreEqual(asulong(0x7FFFFFFFFFFFFFFFL), 0x7FFFFFFFFFFFFFFFul);
            TestUtils.AreEqual(asulong(-9223372036854775808L), 0x8000000000000000ul);
            TestUtils.AreEqual(asulong(-81985529216486896L), 0xFEDCBA9876543210ul);
            TestUtils.AreEqual(asulong(-1L), 0xFFFFFFFFFFFFFFFFul);
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void asulong_double()
        {
            TestUtils.AreEqual(asulong(0.0), 0UL);
            TestUtils.AreEqual(asulong(1.0), 0x3FF0000000000000UL);
            TestUtils.AreEqual(asulong(1234.56), 0x40934A3D70A3D70AUL);
            TestUtils.AreEqual(asulong(double.PositiveInfinity), 0x7FF0000000000000UL);
            TestUtils.AreEqual(asulong(double.NaN), 0xFFF8000000000000UL);

            TestUtils.AreEqual(asulong(-0.0), 0x8000000000000000UL);
            TestUtils.AreEqual(asulong(-1.0), 0xBFF0000000000000UL);
            TestUtils.AreEqual(asulong(-1234.56), 0xC0934A3D70A3D70AUL);
            TestUtils.AreEqual(asulong(double.NegativeInfinity), 0xFFF0000000000000UL);
        }

        [TestCompiler]
        public void asfloat_int()
        {
            TestUtils.AreEqual(asfloat(0), 0.0f);
            TestUtils.AreEqual(asfloat(0x3F800000), 1.0f);
            TestUtils.AreEqual(asfloat(0x449A51EC), 1234.56f);
            TestUtils.AreEqual(asfloat(0x7F800000), float.PositiveInfinity);
            TestUtils.AreEqual(asfloat(unchecked((int)0x80000000)), -0.0f);
            TestUtils.AreEqual(asfloat(unchecked((int)0xBF800000)), -1.0f);
            TestUtils.AreEqual(asfloat(unchecked((int)0xC49A51EC)), -1234.56f);
            TestUtils.AreEqual(asfloat(unchecked((int)0xFF800000)), float.NegativeInfinity);

            TestUtils.AreEqual(asuint(asfloat(unchecked((int)0xFFC00000))), asuint(float.NaN));
        }

        [TestCompiler]
        public void asfloat_int2()
        {
            TestUtils.AreEqual(asfloat(int2(0, 0x3F800000)), float2(0.0f, 1.0f));
            TestUtils.AreEqual(asfloat(int2(0x449A51EC, 0x7F800000)), float2(1234.56f, float.PositiveInfinity));
            TestUtils.AreEqual(asfloat(int2(unchecked((int)0x80000000), unchecked((int)0xBF800000))), float2(-0.0f, -1.0f));

            TestUtils.AreEqual(asfloat(int2(unchecked((int)0xC49A51EC), unchecked((int)0xFF800000))), float2(-1234.56f, float.NegativeInfinity));
            TestUtils.AreEqual(asuint(asfloat(int2(unchecked((int)0xFFC00000), unchecked((int)0xFFC00000)))), asuint(float2(float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void asfloat_int3()
        {
            TestUtils.AreEqual(asfloat(int3(0, 0x3F800000, 0x449A51EC)), float3(0.0f, 1.0f, 1234.56f));
            TestUtils.AreEqual(asfloat(int3(0x7F800000, unchecked((int)0x80000000), unchecked((int)0xBF800000))), float3(float.PositiveInfinity, -0.0f, -1.0f));

            TestUtils.AreEqual(asfloat(int3(unchecked((int)0xC49A51EC), unchecked((int)0xFF800000), 0)), float3(-1234.56f, float.NegativeInfinity, 0.0f));
            TestUtils.AreEqual(asuint(asfloat(int3(unchecked((int)0xFFC00000), unchecked((int)0xFFC00000), unchecked((int)0xFFC00000)))), asuint(float3(float.NaN, float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void asfloat_int4()
        {
            TestUtils.AreEqual(asfloat(int4(0, 0x3F800000, 0x449A51EC, 0x7F800000)), float4(0.0f, 1.0f, 1234.56f, float.PositiveInfinity));
            TestUtils.AreEqual(asfloat(int4(unchecked((int)0x80000000), unchecked((int)0xBF800000), unchecked((int)0xC49A51EC), unchecked((int)0xFF800000))), float4(-0.0f, -1.0f, -1234.56f, float.NegativeInfinity));

            TestUtils.AreEqual(asuint(asfloat(int4(unchecked((int)0xFFC00000), unchecked((int)0xFFC00000), unchecked((int)0xFFC00000), unchecked((int)0xFFC00000)))), asuint(float4(float.NaN, float.NaN, float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void asfloat_uint()
        {
            TestUtils.AreEqual(asfloat(0u), 0.0f);
            TestUtils.AreEqual(asfloat(0x3F800000u), 1.0f);
            TestUtils.AreEqual(asfloat(0x449A51ECu), 1234.56f);
            TestUtils.AreEqual(asfloat(0x7F800000u), float.PositiveInfinity);
            TestUtils.AreEqual(asfloat(0x80000000u), -0.0f);
            TestUtils.AreEqual(asfloat(0xBF800000u), -1.0f);
            TestUtils.AreEqual(asfloat(0xC49A51ECu), -1234.56f);
            TestUtils.AreEqual(asfloat(0xFF800000u), float.NegativeInfinity);

            TestUtils.AreEqual(asuint(asfloat(0xFFC00000u)), asuint(float.NaN));
        }

        [TestCompiler]
        public void asfloat_uint2()
        {
            TestUtils.AreEqual(asfloat(uint2(0u, 0x3F800000u)), float2(0.0f, 1.0f));
            TestUtils.AreEqual(asfloat(uint2(0x449A51ECu, 0x7F800000u)), float2(1234.56f, float.PositiveInfinity));
            TestUtils.AreEqual(asfloat(uint2(0x80000000u, 0xBF800000u)), float2(-0.0f, -1.0f));

            TestUtils.AreEqual(asfloat(uint2(0xC49A51ECu, 0xFF800000u)), float2(-1234.56f, float.NegativeInfinity));
            TestUtils.AreEqual(asuint(asfloat(uint2(0xFFC00000u, 0xFFC00000u))), asuint(float2(float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void asfloat_uint3()
        {
            TestUtils.AreEqual(asfloat(uint3(0u, 0x3F800000u, 0x449A51ECu)), float3(0.0f, 1.0f, 1234.56f));
            TestUtils.AreEqual(asfloat(uint3(0x7F800000u, 0x80000000u, 0xBF800000u)), float3(float.PositiveInfinity, -0.0f, -1.0f));

            TestUtils.AreEqual(asfloat(uint3(0xC49A51ECu, 0xFF800000u, 0u)), float3(-1234.56f, float.NegativeInfinity, 0.0f));
            TestUtils.AreEqual(asuint(asfloat(uint3(0xFFC00000u, 0xFFC00000u, 0xFFC00000u))), asuint(float3(float.NaN, float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void asfloat_uint4()
        {
            TestUtils.AreEqual(asfloat(uint4(0u, 0x3F800000u, 0x449A51ECu, 0x7F800000u)), float4(0.0f, 1.0f, 1234.56f, float.PositiveInfinity));
            TestUtils.AreEqual(asfloat(uint4(0x80000000u, 0xBF800000u, 0xC49A51ECu, 0xFF800000u)), float4(-0.0f, -1.0f, -1234.56f, float.NegativeInfinity));

            TestUtils.AreEqual(asuint(asfloat(uint4(0xFFC00000u, 0xFFC00000u, 0xFFC00000u, 0xFFC00000u))), asuint(float4(float.NaN, float.NaN, float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void asdouble_long()
        {
            TestUtils.AreEqual(asdouble(0L), 0.0);
            TestUtils.AreEqual(asdouble(0x3FF0000000000000L), 1.0);
            TestUtils.AreEqual(asdouble(0x40934A3D70A3D70AL), 1234.56);
            TestUtils.AreEqual(asdouble(0x7FF0000000000000L), double.PositiveInfinity);
            TestUtils.AreEqual(asdouble(unchecked((long)0xFFF8000000000000UL)), double.NaN);

            TestUtils.AreEqual(asdouble(unchecked((long)0x8000000000000000UL)), -0.0);
            TestUtils.AreEqual(asdouble(unchecked((long)0xBFF0000000000000UL)), -1.0);
            TestUtils.AreEqual(asdouble(unchecked((long)0xC0934A3D70A3D70AUL)), -1234.56);
            TestUtils.AreEqual(asdouble(unchecked((long)0xFFF0000000000000UL)), double.NegativeInfinity);
        }

        [TestCompiler]
        public void asdouble_ulong()
        {
            TestUtils.AreEqual(asdouble(0UL), 0.0);
            TestUtils.AreEqual(asdouble(0x3FF0000000000000UL), 1.0);
            TestUtils.AreEqual(asdouble(0x40934A3D70A3D70AUL), 1234.56);
            TestUtils.AreEqual(asdouble(0x7FF0000000000000UL), double.PositiveInfinity);
            TestUtils.AreEqual(asdouble(0xFFF8000000000000UL), double.NaN);

            TestUtils.AreEqual(asdouble(0x8000000000000000UL), -0.0);
            TestUtils.AreEqual(asdouble(0xBFF0000000000000UL), -1.0);
            TestUtils.AreEqual(asdouble(0xC0934A3D70A3D70AUL), -1234.56);
            TestUtils.AreEqual(asdouble(0xFFF0000000000000UL), double.NegativeInfinity);
        }

        [TestCompiler]
        public void min_int()
        {
            TestUtils.AreEqual(min(5, 100), 5);
            TestUtils.AreEqual(min(7, -77), -77);
            TestUtils.AreEqual(min(int.MinValue, -100), int.MinValue);
            TestUtils.AreEqual(min(int.MaxValue, 88), 88);
        }

        [TestCompiler]
        public void min_int2()
        {
            TestUtils.AreEqual(min(int2(5, 7), int2(100, -77)), int2(5, -77));
            TestUtils.AreEqual(min(int2(int.MinValue, int.MaxValue), int2(-100, 88)), int2(int.MinValue, 88));
        }

        [TestCompiler]
        public void min_int3()
        {
            TestUtils.AreEqual(min(int3(5, 7, int.MinValue), int3(100, -77, int.MaxValue)), int3(5, -77, int.MinValue));
            TestUtils.AreEqual(min(int3(int.MaxValue, 0, 0), int3(88, 0, 0)), int3(88, 0, 0));
        }

        [TestCompiler]
        public void min_int4()
        {
            TestUtils.AreEqual(min(int4(5, 7, int.MinValue, int.MaxValue), int4(100, -77, -100, 88)), int4(5, -77, int.MinValue, 88));
        }

        [TestCompiler]
        public void min_uint()
        {
            TestUtils.AreEqual(min(5u, 100u), 5u);
            TestUtils.AreEqual(min(7u, 0xFFFFFF00u), 7u);
            TestUtils.AreEqual(min(0xFFFFFFFFu, 77u), 77u);
            TestUtils.AreEqual(min(0xFFFFFFFEu, 0xFFFFFFFFu), 0xFFFFFFFEu);
        }

        [TestCompiler]
        public void min_uint2()
        {
            TestUtils.AreEqual(min(uint2(5u, 7u), uint2(100u, 0xFFFFFF00u)), uint2(5u, 7u));
            TestUtils.AreEqual(min(uint2(0xFFFFFFFFu, 0xFFFFFFFEu), uint2(77u, 0xFFFFFFFFu)), uint2(77u, 0xFFFFFFFEu));
        }

        [TestCompiler]
        public void min_uint3()
        {
            TestUtils.AreEqual(min(uint3(5u, 7u, 0xFFFFFFFFu), uint3(100u, 0xFFFFFF00u, 77u)), uint3(5u, 7u, 77u));
            TestUtils.AreEqual(min(uint3(0xFFFFFFFEu, 0u, 0u), uint3(0xFFFFFFFFu, 0u, 0u)), uint3(0xFFFFFFFEu, 0u, 0u));
        }

        [TestCompiler]
        public void min_uint4()
        {
            TestUtils.AreEqual(min(uint4(5u, 7u, 0xFFFFFFFFu, 0xFFFFFFFEu), uint4(100u, 0xFFFFFF00u, 77u, 0xFFFFFFFFu)), uint4(5u, 7u, 77u, 0xFFFFFFFEu));
        }

        [TestCompiler]
        public void faceforward_float2()
        {
            TestUtils.AreEqual(faceforward(float2(3.5f, -4.5f), float2(1.0f, -2.0f), float2( 3.0f, -4.0f)), float2(-3.5f,  4.5f));
            TestUtils.AreEqual(faceforward(float2(3.5f, -4.5f), float2(1.0f, -2.0f), float2(-3.0f,  4.0f)), float2( 3.5f, -4.5f));
            TestUtils.AreEqual(faceforward(float2(3.5f, -4.5f), float2(1.0f, -2.0f), float2( 0.0f,  0.0f)), float2(-3.5f,  4.5f));
        }

        [TestCompiler]
        public void faceforward_float3()
        {
            TestUtils.AreEqual(faceforward(float3(3.5f, -4.5f, 5.5f), float3(1.0f, -2.0f, 3.0f), float3( 3.0f, -4.0f,  5.0f)), float3(-3.5f,  4.5f, -5.5f));
            TestUtils.AreEqual(faceforward(float3(3.5f, -4.5f, 5.5f), float3(1.0f, -2.0f, 3.0f), float3(-3.0f,  4.0f, -5.0f)), float3( 3.5f, -4.5f,  5.5f));
            TestUtils.AreEqual(faceforward(float3(3.5f, -4.5f, 5.5f), float3(1.0f, -2.0f, 3.0f), float3( 0.0f,  0.0f,  0.0f)), float3(-3.5f,  4.5f, -5.5f));
        }

        [TestCompiler]
        public void faceforward_float4()
        {
            TestUtils.AreEqual(faceforward(float4(3.5f, -4.5f, 5.5f, -6.5f), float4(1.0f, -2.0f, 3.0f, -4.0f), float4( 3.0f, -4.0f,  5.0f, -6.0f)), float4(-3.5f,  4.5f, -5.5f,  6.5f));
            TestUtils.AreEqual(faceforward(float4(3.5f, -4.5f, 5.5f, -6.5f), float4(1.0f, -2.0f, 3.0f, -4.0f), float4(-3.0f,  4.0f, -5.0f,  6.0f)), float4( 3.5f, -4.5f,  5.5f, -6.5f));
            TestUtils.AreEqual(faceforward(float4(3.5f, -4.5f, 5.5f, -6.5f), float4(1.0f, -2.0f, 3.0f, -4.0f), float4( 0.0f,  0.0f,  0.0f,  0.0f)), float4(-3.5f,  4.5f, -5.5f,  6.5f));
        }

        [TestCompiler]
        public void faceforward_double2()
        {
            TestUtils.AreEqual(faceforward(double2(3.5, -4.5), double2(1.0, -2.0), double2( 3.0, -4.0)), double2(-3.5,  4.5));
            TestUtils.AreEqual(faceforward(double2(3.5, -4.5), double2(1.0, -2.0), double2(-3.0,  4.0)), double2( 3.5, -4.5));
            TestUtils.AreEqual(faceforward(double2(3.5, -4.5), double2(1.0, -2.0), double2( 0.0,  0.0)), double2(-3.5,  4.5));
        }

        [TestCompiler]
        public void faceforward_double3()
        {
            TestUtils.AreEqual(faceforward(double3(3.5, -4.5, 5.5), double3(1.0, -2.0, 3.0), double3( 3.0, -4.0,  5.0)), double3(-3.5,  4.5, -5.5));
            TestUtils.AreEqual(faceforward(double3(3.5, -4.5, 5.5), double3(1.0, -2.0, 3.0), double3(-3.0,  4.0, -5.0)), double3( 3.5, -4.5,  5.5));
            TestUtils.AreEqual(faceforward(double3(3.5, -4.5, 5.5), double3(1.0, -2.0, 3.0), double3( 0.0,  0.0,  0.0)), double3(-3.5,  4.5, -5.5));
        }

        [TestCompiler]
        public void faceforward_double4()
        {
            TestUtils.AreEqual(faceforward(double4(3.5, -4.5, 5.5, -6.5), double4(1.0, -2.0, 3.0, -4.0), double4( 3.0, -4.0,  5.0, -6.0)), double4(-3.5,  4.5, -5.5,  6.5));
            TestUtils.AreEqual(faceforward(double4(3.5, -4.5, 5.5, -6.5), double4(1.0, -2.0, 3.0, -4.0), double4(-3.0,  4.0, -5.0,  6.0)), double4( 3.5, -4.5,  5.5, -6.5));
            TestUtils.AreEqual(faceforward(double4(3.5, -4.5, 5.5, -6.5), double4(1.0, -2.0, 3.0, -4.0), double4( 0.0,  0.0,  0.0,  0.0)), double4(-3.5,  4.5, -5.5,  6.5));
        }

        [TestCompiler]
        public void modf_float()
        {
            float f, i;
            f = modf(313.75f, out i);
            TestUtils.AreEqual(i, 313.0f);
            TestUtils.AreEqual(f, 0.75f);

            f = modf(-313.25f, out i);
            TestUtils.AreEqual(i, -313.0f);
            TestUtils.AreEqual(f, -0.25f);

            f = modf(-314.0f, out i);
            TestUtils.AreEqual(i, -314.0f);
            TestUtils.AreEqual(f, 0.0f);
        }

        [TestCompiler]
        public void modf_float2()
        {
            float2 f, i;
            f = modf(float2(313.75f, -313.25f), out i);
            TestUtils.AreEqual(i, float2(313.0f, -313.0f));
            TestUtils.AreEqual(f, float2(0.75f, -0.25f));

            f = modf(float2(-314.0f, 7.5f), out i);
            TestUtils.AreEqual(i, float2(-314.0f, 7.0f));
            TestUtils.AreEqual(f, float2(0.0f, 0.5f));
        }

        [TestCompiler]
        public void modf_float3()
        {
            float3 f, i;
            f = modf(float3(313.75f, -313.25f, -314.0f), out i);
            TestUtils.AreEqual(i, float3(313.0f, -313.0f, -314.0f));
            TestUtils.AreEqual(f, float3(0.75f, -0.25f, 0.0f));
        }

        [TestCompiler]
        public void modf_float4()
        {
            float4 f, i;
            f = modf(float4(313.75f, -313.25f, -314.0f, 7.5f), out i);
            TestUtils.AreEqual(i, float4(313.0f, -313.0f, -314.0f, 7.0f));
            TestUtils.AreEqual(f, float4(0.75f, -0.25f, 0.0f, 0.5f));
        }

        [TestCompiler]
        public void modf_double()
        {
            double f, i;
            f = modf(313.75, out i);
            TestUtils.AreEqual(i, 313.0);
            TestUtils.AreEqual(f, 0.75);

            f = modf(-313.25, out i);
            TestUtils.AreEqual(i, -313.0);
            TestUtils.AreEqual(f, -0.25);

            f = modf(-314.0, out i);
            TestUtils.AreEqual(i, -314.0);
            TestUtils.AreEqual(f, 0.0);
        }

        [TestCompiler]
        public void modf_double2()
        {
            double2 f, i;
            f = modf(double2(313.75, -313.25), out i);
            TestUtils.AreEqual(i, double2(313.0, -313.0));
            TestUtils.AreEqual(f, double2(0.75, -0.25));

            f = modf(double2(-314.0, 7.5), out i);
            TestUtils.AreEqual(i, double2(-314.0, 7.0));
            TestUtils.AreEqual(f, double2(0.0, 0.5));
        }

        [TestCompiler]
        public void modf_double3()
        {
            double3 f, i;
            f = modf(double3(313.75, -313.25, -314.0), out i);
            TestUtils.AreEqual(i, double3(313.0, -313.0, -314.0));
            TestUtils.AreEqual(f, double3(0.75, -0.25, 0.0));
        }

        [TestCompiler]
        public void modf_double4()
        {
            double4 f, i;
            f = modf(double4(313.75, -313.25, -314.0, 7.5), out i);
            TestUtils.AreEqual(i, double4(313.0, -313.0, -314.0, 7.0));
            TestUtils.AreEqual(f, double4(0.75, -0.25, 0.0, 0.5f));
        }

        [TestCompiler]
        public void unlerp_float()
        {
            TestUtils.AreEqual(unlerp(-1.5f, 2.5f, 0.5f), 0.5f);
            TestUtils.AreEqual(unlerp(-100.5f, 22.5f, lerp(-100.5f, 22.5f, 0.25f)), 0.25f);
        }

        [TestCompiler]
        public void unlerp_double()
        {
            TestUtils.AreEqual(unlerp(-1.5, 2.5, 0.5), 0.5);
            TestUtils.AreEqual(unlerp(-100.5, 22.5, lerp(-100.5, 22.5, 0.25)), 0.25);
        }

        [TestCompiler]
        public void remap_float()
        {
            TestUtils.AreEqual(remap(-1.0f, 3.0f, -75.0f, 25.0f, 0.5f), -37.5f);
        }

        [TestCompiler]
        public void remap_double()
        {
            TestUtils.AreEqual(remap(-1.0, 3.0, -75.0, 25.0, 0.5), -37.5);
        }


        [TestCompiler]
        public void normalize_float2()
        {
            TestUtils.AreEqual(normalize(float2(3.1f, -5.3f)), float2(0.504883f, -0.863188f), 0.0001f);
            Assert.AreEqual(all(isnan(normalize(float2(0.0f, 0.0f)))), true);
        }

        [TestCompiler]
        public void normalize_float3()
        {
            TestUtils.AreEqual(normalizesafe(float3(3.1f, -5.3f, 2.6f)), float3(0.464916f, -0.794861f, 0.389932f), 0.0001f);
            Assert.AreEqual(all(isnan(normalize(float3(0.0f, 0.0f, 0.0f)))), true);
        }

        [TestCompiler]
        public void normalize_float4()
        {
            TestUtils.AreEqual(normalizesafe(float4(3.1f, -5.3f, 2.6f, 11.4f)), float4(0.234727f, -0.401308f, 0.196868f, 0.863191f), 0.0001f);
            Assert.AreEqual(all(isnan(normalize(float4(0.0f, 0.0f, 0.0f, 0.0f)))), true);
        }


        [TestCompiler]
        public void normalize_double2()
        {
            TestUtils.AreEqual(normalize(double2(3.1, -5.3)), double2(0.504883, -0.863188), 0.0001);
            Assert.AreEqual(all(isnan(normalize(double2(0.0, 0.0)))), true);
        }

        [TestCompiler]
        public void normalize_double3()
        {
            TestUtils.AreEqual(normalizesafe(double3(3.1, -5.3, 2.6)), double3(0.464916, -0.794861, 0.389932), 0.0001);
            Assert.AreEqual(all(isnan(normalize(double3(0.0, 0.0, 0.0)))), true);
        }

        [TestCompiler]
        public void normalize_double4()
        {
            TestUtils.AreEqual(normalizesafe(double4(3.1, -5.3, 2.6, 11.4)), double4(0.234727, -0.401308, 0.196868, 0.863191), 0.0001);
            Assert.AreEqual(all(isnan(normalize(double4(0.0, 0.0, 0.0, 0.0f)))), true);
        }

        [TestCompiler]
        public void normalize_quaternion()
        {
            TestUtils.AreEqual(normalizesafe(quaternion(3.1f, -5.3f, 2.6f, 11.4f)), quaternion(0.234727f, -0.401308f, 0.196868f, 0.863191f), 0.0001f);
            Assert.AreEqual(all(isnan(normalize(quaternion(0.0f, 0.0f, 0.0f, 0.0f)).value)), true);
        }


        [TestCompiler]
        public void normalizesafe_float2()
        {
            TestUtils.AreEqual(normalizesafe(float2(3.1f, -5.3f)), float2(0.504883f, -0.863188f), 0.0001f);
            TestUtils.AreEqual(normalizesafe(float2(0.0f, 0.0f)), float2(0.0f, 0.0f));
            TestUtils.AreEqual(normalizesafe(float2(0.0f, 0.0f), float2(1.0f,2.0f)), float2(1.0f, 2.0f));
            TestUtils.AreEqual(normalizesafe(float2(1e-18f, 2e-18f)), float2(0.447214f, 0.894427f), 0.0001f);
            TestUtils.AreEqual(normalizesafe(float2(7.66e-20f, 7.66e-20f), float2(1.0f, 2.0f)), float2(1.0f, 2.0f));
        }

        [TestCompiler]
        public void normalizesafe_float3()
        {
            TestUtils.AreEqual(normalizesafe(float3(3.1f, -5.3f, 2.6f)), float3(0.464916f, -0.794861f, 0.389932f), 0.0001f);
            TestUtils.AreEqual(normalizesafe(float3(0.0f, 0.0f, 0.0f)), float3(0.0f, 0.0f, 0.0f));
            TestUtils.AreEqual(normalizesafe(float3(0.0f, 0.0f, 0.0f), float3(1.0f, 2.0f, 3.0f)), float3(1.0f, 2.0f, 3.0f));
            TestUtils.AreEqual(normalizesafe(float3(1e-19f, 2e-19f, 3e-19f)), float3(0.267261f, 0.534523f, 0.801784f), 0.0001f);
            TestUtils.AreEqual(normalizesafe(float3(6.25e-20f, 6.25e-20f, 6.25e-20f), float3(1.0f, 2.0f, 3.0f)), float3(1.0f, 2.0f, 3.0f));
        }

        [TestCompiler]
        public void normalizesafe_float4()
        {
            TestUtils.AreEqual(normalizesafe(float4(3.1f, -5.3f, 2.6f, 11.4f)), float4(0.234727f, -0.401308f, 0.196868f, 0.863191f), 0.0001f);
            TestUtils.AreEqual(normalizesafe(float4(0.0f, 0.0f, 0.0f, 0.0f)), float4(0.0f, 0.0f, 0.0f, 0.0f));
            TestUtils.AreEqual(normalizesafe(float4(0.0f, 0.0f, 0.0f, 0.0f), float4(1.0f, 2.0f, 3.0f, 4.0f)), float4(1.0f, 2.0f, 3.0f, 4.0f));
            TestUtils.AreEqual(normalizesafe(float4(1e-19f, 2e-19f, 3e-19f, 4e-19f)), float4(0.182574f, 0.3651484f, 0.547723f, 0.730297f), 0.0001f);
            TestUtils.AreEqual(normalizesafe(float4(5.42e-20f, 5.42e-20f, 5.42e-20f, 5.42e-20f), float4(1.0f, 2.0f, 3.0f, 4.0f)), float4(1.0f, 2.0f, 3.0f, 4.0f));
        }


        [TestCompiler]
        public void normalizesafe_double2()
        {
            TestUtils.AreEqual(normalizesafe(double2(3.1, -5.3)), double2(0.504883, -0.863188), 0.0001);
            TestUtils.AreEqual(normalizesafe(double2(0.0, 0.0)), double2(0.0, 0.0));
            TestUtils.AreEqual(normalizesafe(double2(0.0, 0.0), double2(1.0, 2.0)), double2(1.0, 2.0));
            TestUtils.AreEqual(normalizesafe(double2(1e-18, 2e-18)), double2(0.447214, 0.894427), 0.0001);
            TestUtils.AreEqual(normalizesafe(double2(1.05e-154, 1.05e-154), double2(1.0, 2.0)), double2(1.0, 2.0));
        }

        [TestCompiler]
        public void normalizesafe_double3()
        {
            TestUtils.AreEqual(normalizesafe(double3(3.1, -5.3, 2.6)), double3(0.464916, -0.794861, 0.389932), 0.0001);
            TestUtils.AreEqual(normalizesafe(double3(0.0, 0.0, 0.0)), double3(0.0, 0.0, 0.0));
            TestUtils.AreEqual(normalizesafe(double3(0.0, 0.0, 0.0), double3(1.0, 2.0, 3.0)), double3(1.0, 2.0, 3.0));
            TestUtils.AreEqual(normalizesafe(double3(1e-19, 2e-19, 3e-19)), double3(0.267261, 0.534523, 0.801784), 0.0001);
            TestUtils.AreEqual(normalizesafe(double3(8.61e-155, 8.61e-155, 8.61e-155), double3(1.0, 2.0, 3.0)), double3(1.0, 2.0, 3.0));
        }

        [TestCompiler]
        public void normalizesafe_double4()
        {
            TestUtils.AreEqual(normalizesafe(double4(3.1, -5.3, 2.6, 11.4)), double4(0.234727, -0.401308, 0.196868, 0.863191), 0.0001);
            TestUtils.AreEqual(normalizesafe(double4(0.0, 0.0, 0.0, 0.0)), double4(0.0, 0.0, 0.0, 0.0));
            TestUtils.AreEqual(normalizesafe(double4(0.0, 0.0, 0.0, 0.0), double4(1.0, 2.0, 3.0, 4.0)), double4(1.0, 2.0, 3.0, 4.0));
            TestUtils.AreEqual(normalizesafe(double4(1e-19, 2e-19, 3e-19, 4e-19)), double4(0.182574, 0.3651484, 0.547723, 0.730297), 0.0001);
            TestUtils.AreEqual(normalizesafe(double4(7.45e-155, 7.45e-155, 7.45e-155, 7.45e-155), double4(1.0, 2.0, 3.0, 4.0)), double4(1.0, 2.0, 3.0, 4.0));
        }

        [TestCompiler]
        public void normalizesafe_quaternion()
        {
            TestUtils.AreEqual(normalizesafe(quaternion(3.1f, -5.3f, 2.6f, 11.4f)), quaternion(0.234727f, -0.401308f, 0.196868f, 0.863191f), 0.0001f);
            TestUtils.AreEqual(normalizesafe(quaternion(0.0f, 0.0f, 0.0f, 0.0f)), quaternion(0.0f, 0.0f, 0.0f, 1.0f));
            TestUtils.AreEqual(normalizesafe(quaternion(0.0f, 0.0f, 0.0f, 0.0f), quaternion(1.0f, 2.0f, 3.0f, 4.0f)), quaternion(1.0f, 2.0f, 3.0f, 4.0f));
            TestUtils.AreEqual(normalizesafe(quaternion(1e-19f, 2e-19f, 3e-19f, 4e-19f)), quaternion(0.182574f, 0.3651484f, 0.547723f, 0.730297f), 0.0001f);
            TestUtils.AreEqual(normalizesafe(quaternion(5.42e-20f, 5.42e-20f, 5.42e-20f, 5.42e-20f), quaternion(1.0f, 2.0f, 3.0f, 4.0f)), quaternion(1.0f, 2.0f, 3.0f, 4.0f));
        }

        [TestCompiler]
        public void f16tof32_float()
        {
            TestUtils.AreEqual(asuint(f16tof32(0x0000)), 0x00000000);
            TestUtils.AreEqual(asuint(f16tof32(0x0203)), 0x3800C000);
            TestUtils.AreEqual(asuint(f16tof32(0x4321)), 0x40642000);
            TestUtils.AreEqual(asuint(f16tof32(0x7BFF)), 0x477FE000);
            TestUtils.AreEqual(asuint(f16tof32(0x7C00)), 0x7F800000);
            Assert.AreEqual(isnan(f16tof32(0x7C01)), true);

            TestUtils.AreEqual(asuint(f16tof32(0x8000)), 0x80000000);
            TestUtils.AreEqual(asuint(f16tof32(0x8203)), 0xB800C000);
            TestUtils.AreEqual(asuint(f16tof32(0xC321)), 0xC0642000);
            TestUtils.AreEqual(asuint(f16tof32(0xFBFF)), 0xC77FE000);
            TestUtils.AreEqual(asuint(f16tof32(0xFC00)), 0xFF800000);
            Assert.AreEqual(isnan(f16tof32(0xFC01)), true);
        }

        [TestCompiler]
        public void f16tof32_float2()
        {
            TestUtils.AreEqual(asuint(f16tof32(uint2(0x0000, 0x0203))), uint2(0x00000000, 0x3800C000));
            TestUtils.AreEqual(asuint(f16tof32(uint2(0x4321, 0x7BFF))), uint2(0x40642000, 0x477FE000));
            TestUtils.AreEqual(asuint(f16tof32(uint2(0x7C00, 0x7C00))), uint2(0x7F800000, 0x7F800000));
            Assert.AreEqual(all(isnan(f16tof32(uint2(0x7C01, 0x7C01)))), true);

            TestUtils.AreEqual(asuint(f16tof32(uint2(0x8000, 0x8203))), uint2(0x80000000, 0xB800C000));
            TestUtils.AreEqual(asuint(f16tof32(uint2(0xC321, 0xFBFF))), uint2(0xC0642000, 0xC77FE000));
            TestUtils.AreEqual(asuint(f16tof32(uint2(0xFC00, 0xFC00))), uint2(0xFF800000, 0xFF800000));
            Assert.AreEqual(all(isnan(f16tof32(uint2(0xFC01, 0xFC01)))), true);
        }

        [TestCompiler]
        public void f16tof32_float3()
        {
            TestUtils.AreEqual(asuint(f16tof32(uint3(0x0000, 0x0203, 0x4321))), uint3(0x00000000, 0x3800C000, 0x40642000));
            TestUtils.AreEqual(asuint(f16tof32(uint3(0x7BFF, 0x7C00, 0x7C00))), uint3(0x477FE000, 0x7F800000, 0x7F800000));
            Assert.AreEqual(all(isnan(f16tof32(uint3(0x7C01, 0x7C01, 0x7C01)))), true);

            TestUtils.AreEqual(asuint(f16tof32(uint3(0x8000, 0x8203, 0xC321))), uint3(0x80000000, 0xB800C000, 0xC0642000));
            TestUtils.AreEqual(asuint(f16tof32(uint3(0xFBFF, 0xFC00, 0xFC00))), uint3(0xC77FE000, 0xFF800000, 0xFF800000));
            Assert.AreEqual(all(isnan(f16tof32(uint3(0xFC01, 0xFC01, 0xFC01)))), true);
        }

        [TestCompiler]
        public void f16tof32_float4()
        {
            TestUtils.AreEqual(asuint(f16tof32(uint4(0x0000, 0x0203, 0x4321, 0x7BFF))), uint4(0x00000000, 0x3800C000, 0x40642000, 0x477FE000));
            TestUtils.AreEqual(asuint(f16tof32(uint4(0x7C00, 0x7C00, 0x7C00, 0x7C00))), uint4(0x7F800000, 0x7F800000, 0x7F800000, 0x7F800000));
            Assert.AreEqual(all(isnan(f16tof32(uint4(0x7C01, 0x7C01, 0x7C01, 0x7C01)))), true);

            TestUtils.AreEqual(asuint(f16tof32(uint4(0x8000, 0x8203, 0xC321, 0xFBFF))), uint4(0x80000000, 0xB800C000, 0xC0642000, 0xC77FE000));
            TestUtils.AreEqual(asuint(f16tof32(uint4(0xFC00, 0xFC00, 0xFC00, 0xFC00))), uint4(0xFF800000, 0xFF800000, 0xFF800000, 0xFF800000));
            Assert.AreEqual(all(isnan(f16tof32(uint4(0xFC01, 0xFC01, 0xFC01, 0xFC01)))), true);
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void f32tof16_float()
        {
            TestUtils.AreEqual(f32tof16(0.0f), 0x0000);
            TestUtils.AreEqual(f32tof16(2.98e-08f), 0x0000);
            TestUtils.AreEqual(f32tof16(5.96046448e-08f), 0x0001);
            TestUtils.AreEqual(f32tof16(123.4f), 0x57B6);
            TestUtils.AreEqual(f32tof16(65504.0f), 0x7BFF);
            TestUtils.AreEqual(f32tof16(65520.0f), 0x7C00);
            TestUtils.AreEqual(f32tof16(float.PositiveInfinity), 0x7C00);
            TestUtils.AreEqual(f32tof16(float.NaN), 0xFE00);

            TestUtils.AreEqual(f32tof16(-0.0f), 0x8000);
            TestUtils.AreEqual(f32tof16(-2.98e-08f), 0x8000);
            TestUtils.AreEqual(f32tof16(-5.96046448e-08f), 0x8001);
            TestUtils.AreEqual(f32tof16(-123.4f), 0xD7B6);
            TestUtils.AreEqual(f32tof16(-65504.0f), 0xFBFF);
            TestUtils.AreEqual(f32tof16(-65520.0f), 0xFC00);
            TestUtils.AreEqual(f32tof16(float.NegativeInfinity), 0xFC00);
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void f32tof16_float2()
        {
            TestUtils.AreEqual(f32tof16(float2(0.0f, 2.98e-08f)), uint2(0x0000, 0x0000));
            TestUtils.AreEqual(f32tof16(float2(5.96046448e-08f, 123.4f)), uint2(0x0001, 0x57B6));
            TestUtils.AreEqual(f32tof16(float2(65504.0f, 65520.0f)), uint2(0x7BFF, 0x7C00));
            TestUtils.AreEqual(f32tof16(float2(float.PositiveInfinity, float.NaN)), uint2(0x7C00, 0xFE00));

            TestUtils.AreEqual(f32tof16(float2(-0.0f, -2.98e-08f)), uint2(0x8000, 0x8000));
            TestUtils.AreEqual(f32tof16(float2(-5.96046448e-08f, -123.4f)), uint2(0x8001, 0xD7B6));
            TestUtils.AreEqual(f32tof16(float2(-65504.0f, -65520.0f)), uint2(0xFBFF, 0xFC00));
            TestUtils.AreEqual(f32tof16(float2(float.NegativeInfinity, float.NegativeInfinity)), uint2(0xFC00, 0xFC00));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void f32tof16_float3()
        {
            TestUtils.AreEqual(f32tof16(float3(0.0f, 2.98e-08f, 5.96046448e-08f)), uint3(0x0000, 0x0000, 0x0001));
            TestUtils.AreEqual(f32tof16(float3(123.4f, 65504.0f, 65520.0f)), uint3(0x57B6, 0x7BFF, 0x7C00));
            TestUtils.AreEqual(f32tof16(float3(float.PositiveInfinity, float.NaN, -0.0f)), uint3(0x7C00, 0xFE00, 0x8000));

            TestUtils.AreEqual(f32tof16(float3(-2.98e-08f, -5.96046448e-08f, -123.4f)), uint3(0x8000, 0x8001, 0xD7B6));
            TestUtils.AreEqual(f32tof16(float3(-65504.0f, -65520.0f, float.NegativeInfinity)), uint3(0xFBFF, 0xFC00, 0xFC00));
        }

        [TestCompiler]
        [WindowsOnly("Mono on linux ignores signed zero.")]
        public void f32tof16_float4()
        {
            TestUtils.AreEqual(f32tof16(float4(0.0f, 2.98e-08f, 5.96046448e-08f, 123.4f)), uint4(0x0000, 0x0000, 0x0001, 0x57B6));
            TestUtils.AreEqual(f32tof16(float4(65504.0f, 65520.0f, float.PositiveInfinity, float.NaN)), uint4(0x7BFF, 0x7C00, 0x7C00, 0xFE00));
            TestUtils.AreEqual(f32tof16(float4(-0.0f, -2.98e-08f, -5.96046448e-08f, -123.4f)), uint4(0x8000, 0x8000, 0x8001, 0xD7B6));
            TestUtils.AreEqual(f32tof16(float4(-65504.0f, -65520.0f, float.NegativeInfinity, float.NegativeInfinity)), uint4(0xFBFF, 0xFC00, 0xFC00, 0xFC00));
        }

        [TestCompiler]
        public void sin_float()
        {
            TestUtils.AreEqual(sin(-1000000.0f), 0.349994f, 0.000001f);
            TestUtils.AreEqual(sin(-1.2f), -0.932039f, 0.000001f);
            TestUtils.AreEqual(sin(0.0f), 0.0f, 0.000001f);
            TestUtils.AreEqual(sin(1.2f), 0.932039f, 0.000001f);
            TestUtils.AreEqual(sin(1000000.0f), -0.349994f, 0.000001f);
            TestUtils.AreEqual(asint(sin(float.NegativeInfinity)), asint(float.NaN));
            TestUtils.AreEqual(asint(sin(float.NaN)), asint(float.NaN));
            TestUtils.AreEqual(asint(sin(float.PositiveInfinity)), asint(float.NaN));
        }

        [TestCompiler]
        public void sin_float2()
        {
            TestUtils.AreEqual(sin(float2(-1000000.0f, -1.2f)), float2(0.349994f, -0.932039f), 0.000001f);
            TestUtils.AreEqual(sin(float2(0.0f, 1.2f)), float2(0.0f, 0.932039f), 0.000001f);
            TestUtils.AreEqual(sin(float2(1000000.0f, 0.0f)), float2(-0.349994f, 0.0f), 0.000001f);

            TestUtils.AreEqual(asint(sin(float2(float.NegativeInfinity, float.NaN))), asint(float2(float.NaN, float.NaN)));
            TestUtils.AreEqual(asint(sin(float2(float.PositiveInfinity, float.NaN))), asint(float2(float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void sin_float3()
        {
            TestUtils.AreEqual(sin(float3(-1000000.0f, -1.2f, 0.0f)), float3(0.349994f, -0.932039f, 0.0f), 0.000001f);
            TestUtils.AreEqual(sin(float3(1.2f, 1000000.0f, 0.0f)), float3(0.932039f, -0.349994f, 0.0f), 0.000001f);
            TestUtils.AreEqual(asint(sin(float3(float.NegativeInfinity, float.NaN, float.PositiveInfinity))), asint(float3(float.NaN, float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void sin_float4()
        {
            TestUtils.AreEqual(sin(float4(-1000000.0f, -1.2f, 0.0f, 1.2f)), float4(0.349994f, -0.932039f, 0.0f, 0.932039f), 0.000001f);
            TestUtils.AreEqual(sin(float4(1000000.0f, 0.0f, 0.0f, 0.0f)), float4(-0.349994f, 0.0f, 0.0f, 0.0f), 0.000001f);
            TestUtils.AreEqual(asint(sin(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, 0.0f))), asint(float4(float.NaN, float.NaN, float.NaN, 0.0f)));
        }

        [TestCompiler]
        public void sin_double()
        {
            TestUtils.AreEqual(sin(-1000000.0), 0.349993502171293, 1e-14);
            TestUtils.AreEqual(sin(-1.2), -0.932039085967226, 1e-14);
            TestUtils.AreEqual(sin(0.0), 0.0, 1e-14);
            TestUtils.AreEqual(sin(1.2), 0.932039085967226, 1e-14);
            TestUtils.AreEqual(sin(1000000.0), -0.34999350217129295, 1e-14);
            TestUtils.AreEqual(aslong(sin(double.NegativeInfinity)), aslong(double.NaN));
            TestUtils.AreEqual(aslong(sin(double.NaN)), aslong(double.NaN));
            TestUtils.AreEqual(aslong(sin(double.PositiveInfinity)), aslong(double.NaN));
        }

        [TestCompiler]
        public void sin_double2()
        {
            TestUtils.AreEqual(sin(double2(-1000000.0, -1.2)), double2(0.349993502171293, -0.932039085967226), 1e-14);
            TestUtils.AreEqual(sin(double2(0.0, 1.2)), double2(0.0, 0.932039085967226), 1e-14);
            TestUtils.AreEqual(sin(double2(1000000.0, 0.0)), double2(-0.34999350217129295, 0.0), 1e-14);

            double2 t0 = sin(double2(double.NegativeInfinity, double.NaN));
            double2 t1 = sin(double2(double.PositiveInfinity, double.NaN));

            TestUtils.AreEqual(aslong(t0.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t0.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t1.x), aslong(double.NaN));
        }

        [TestCompiler]
        public void sin_double3()
        {
            TestUtils.AreEqual(sin(double3(-1000000.0, -1.2, 0.0)), double3(0.349993502171293, -0.932039085967226, 0.0), 1e-14);
            TestUtils.AreEqual(sin(double3(1.2, 1000000.0, 0.0)), double3(0.932039085967226, -0.34999350217129295, 0.0), 1e-14);

            double3 t = sin(double3(double.NegativeInfinity, double.NaN, double.PositiveInfinity));
            TestUtils.AreEqual(aslong(t.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.z), aslong(double.NaN));
        }

        [TestCompiler]
        public void sin_double4()
        {
            TestUtils.AreEqual(sin(double4(-1000000.0, -1.2, 0.0, 1.2)), double4(0.349993502171293, -0.932039085967226, 0.0, 0.932039085967226), 1e-14);
            TestUtils.AreEqual(sin(double4(1000000.0, 0.0, 0.0, 0.0)), double4(-0.349993502171293, 0.0, 0.0, 0.0), 0.000001);

            double4 t = sin(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.NaN));
            TestUtils.AreEqual(aslong(t.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.z), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.w), aslong(double.NaN));
        }

        [TestCompiler]
        public void cos_float()
        {
            float t = cos(-1000000.0f);
            TestUtils.AreEqual(cos(-1000000.0f), 0.936752f, 0.000001f);
            TestUtils.AreEqual(cos(-1.2f), 0.362358f, 0.000001f);
            TestUtils.AreEqual(cos(0.0f), 1.0f, 0.000001f);
            TestUtils.AreEqual(cos(1.2f), 0.362358f, 0.000001f);
            TestUtils.AreEqual(cos(1000000.0f), 0.936752f, 0.000001f);
            TestUtils.AreEqual(asint(cos(float.NegativeInfinity)), asint(float.NaN));
            TestUtils.AreEqual(asint(cos(float.NaN)), asint(float.NaN));
            TestUtils.AreEqual(asint(cos(float.PositiveInfinity)), asint(float.NaN));
        }

        [TestCompiler]
        public void cos_float2()
        {
            TestUtils.AreEqual(cos(float2(-1000000.0f, -1.2f)), float2(0.936752f, 0.362358f), 0.000001f);
            TestUtils.AreEqual(cos(float2(0.0f, 1.2f)), float2(1.0f, 0.362358f), 0.000001f);
            TestUtils.AreEqual(cos(float2(1000000.0f, 0.0f)), float2(0.936752f, 1.0f), 0.000001f);

            TestUtils.AreEqual(asint(cos(float2(float.NegativeInfinity, float.NaN))), asint(float2(float.NaN, float.NaN)));
            TestUtils.AreEqual(asint(cos(float2(float.PositiveInfinity, float.NaN))), asint(float2(float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void cos_float3()
        {
            TestUtils.AreEqual(cos(float3(-1000000.0f, -1.2f, 0.0f)), float3(0.936752f, 0.362358f, 1.0f), 0.000001f);
            TestUtils.AreEqual(cos(float3(1.2f, 1000000.0f, 0.0f)), float3(0.362358f, 0.936752f, 1.0f), 0.000001f);
            TestUtils.AreEqual(asint(cos(float3(float.NegativeInfinity, float.NaN, float.PositiveInfinity))), asint(float3(float.NaN, float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void cos_float4()
        {
            TestUtils.AreEqual(cos(float4(-1000000.0f, -1.2f, 0.0f, 1.2f)), float4(0.936752f, 0.362358f, 1.0f, 0.362358f), 0.000001f);
            TestUtils.AreEqual(cos(float4(1000000.0f, 0.0f, 0.0f, 0.0f)), float4(0.936752f, 1.0f, 1.0f, 1.0f), 0.000001f);
            TestUtils.AreEqual(asint(cos(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.NaN))), asint(float4(float.NaN, float.NaN, float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void cos_double()
        {
            TestUtils.AreEqual(cos(-1000000.0), 0.936752127533145, 1e-14);
            TestUtils.AreEqual(cos(-1.2), 0.362357754476674, 1e-14);
            TestUtils.AreEqual(cos(0.0), 1.0, 1e-14);
            TestUtils.AreEqual(cos(1.2), 0.362357754476674, 1e-14);
            TestUtils.AreEqual(cos(1000000.0), 0.936752127533145, 1e-14);
            TestUtils.AreEqual(aslong(cos(double.NegativeInfinity)), aslong(double.NaN));
            TestUtils.AreEqual(aslong(cos(double.NaN)), aslong(double.NaN));
            TestUtils.AreEqual(aslong(cos(double.PositiveInfinity)), aslong(double.NaN));
        }

        [TestCompiler]
        public void cos_double2()
        {
            TestUtils.AreEqual(cos(double2(-1000000.0, -1.2)), double2(0.936752127533145, 0.362357754476674), 1e-14);
            TestUtils.AreEqual(cos(double2(0.0, 1.2)), double2(1.0, 0.362357754476674), 1e-14);
            TestUtils.AreEqual(cos(double2(1000000.0, 0.0)), double2(0.936752127533145, 1.0), 1e-14);

            double2 t0 = cos(double2(double.NegativeInfinity, double.NaN));
            double2 t1 = cos(double2(double.PositiveInfinity, double.NaN));

            TestUtils.AreEqual(aslong(t0.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t0.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t1.x), aslong(double.NaN));
        }

        [TestCompiler]
        public void cos_double3()
        {
            TestUtils.AreEqual(cos(double3(-1000000.0, -1.2, 0.0)), double3(0.936752127533145, 0.362357754476674, 1.0), 1e-14);
            TestUtils.AreEqual(cos(double3(1.2, 1000000.0, 0.0)), double3(0.362357754476674, 0.936752127533145, 1.0), 1e-14);

            double3 t = cos(double3(double.NegativeInfinity, double.NaN, double.PositiveInfinity));
            TestUtils.AreEqual(aslong(t.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.z), aslong(double.NaN));
        }

        [TestCompiler]
        public void cos_double4()
        {
            TestUtils.AreEqual(cos(double4(-1000000.0, -1.2, 0.0, 1.2)), double4(0.936752127533145, 0.362357754476674, 1.0, 0.362357754476674), 1e-14);
            TestUtils.AreEqual(cos(double4(1000000.0, 0.0, 0.0, 0.0)), double4(0.936752127533145, 1.0, 1.0, 1.0), 1e-14);

            double4 t = cos(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.NaN));
            TestUtils.AreEqual(aslong(t.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.z), aslong(double.NaN));
            TestUtils.AreEqual(aslong(t.w), aslong(double.NaN));
        }


        [TestCompiler]
        public void sincos_float()
        {
            float s, c;
            sincos(-1000000.0f, out s, out c);
            TestUtils.AreEqual(s, 0.349994f, 0.000001f);
            TestUtils.AreEqual(c, 0.936752f, 0.000001f);

            sincos(-1.2f, out s, out c);
            TestUtils.AreEqual(s, -0.932039f, 0.000001f);
            TestUtils.AreEqual(c,  0.362358f, 0.000001f);

            sincos(0.0f, out s, out c);
            TestUtils.AreEqual(s, 0.0f, 0.000001f);
            TestUtils.AreEqual(c, 1.0f, 0.000001f);

            sincos(1.2f, out s, out c);
            TestUtils.AreEqual(s, 0.932039f, 0.000001f);
            TestUtils.AreEqual(c, 0.362358f, 0.000001f);

            sincos(1000000.0f, out s, out c);
            TestUtils.AreEqual(s, -0.349994f, 0.000001f);
            TestUtils.AreEqual(c,  0.936752f, 0.000001f);

            sincos(float.NegativeInfinity, out s, out c);
            TestUtils.AreEqual(asint(s), asint(float.NaN));
            TestUtils.AreEqual(asint(c), asint(float.NaN));

            sincos(float.NaN, out s, out c);
            TestUtils.AreEqual(asint(s), asint(float.NaN));
            TestUtils.AreEqual(asint(c), asint(float.NaN));


            sincos(float.PositiveInfinity, out s, out c);
            TestUtils.AreEqual(asint(s), asint(float.NaN));
            TestUtils.AreEqual(asint(c), asint(float.NaN));
        }

        [TestCompiler]
        public void sincos_float2()
        {
            float2 s, c;
            sincos(float2(-1000000.0f, -1.2f), out s, out c);
            TestUtils.AreEqual(s, float2(0.349994f, -0.932039f), 0.000001f);
            TestUtils.AreEqual(c, float2(0.936752f, 0.362358f), 0.000001f);

            sincos(float2(0.0f, 1.2f), out s, out c);
            TestUtils.AreEqual(s, float2(0.0f, 0.932039f), 0.000001f);
            TestUtils.AreEqual(c, float2(1.0f, 0.362358f), 0.000001f);

            sincos(float2(1000000.0f, 0.0f), out s, out c);
            TestUtils.AreEqual(s, float2(-0.349994f, 0.0f), 0.000001f);
            TestUtils.AreEqual(c, float2(0.936752f, 1.0f), 0.000001f);

            sincos(float2(float.NegativeInfinity, float.NaN), out s, out c);
            TestUtils.AreEqual(asint(s), asint(float2(float.NaN, float.NaN)));
            TestUtils.AreEqual(asint(c), asint(float2(float.NaN, float.NaN)));

            sincos(float2(float.PositiveInfinity, float.NaN), out s, out c);
            TestUtils.AreEqual(asint(s), asint(float2(float.NaN, float.NaN)));
            TestUtils.AreEqual(asint(c), asint(float2(float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void sincos_float3()
        {
            float3 s, c;
            sincos(float3(-1000000.0f, -1.2f, 0.0f), out s, out c);
            TestUtils.AreEqual(s, float3(0.349994f, -0.932039f, 0.0f), 0.000001f);
            TestUtils.AreEqual(c, float3(0.936752f, 0.362358f, 1.0f), 0.000001f);


            sincos(float3(1.2f, 1000000.0f, 0.0f), out s, out c);
            TestUtils.AreEqual(s, float3(0.932039f, -0.349994f, 0.0f), 0.000001f);
            TestUtils.AreEqual(c, float3(0.362358f, 0.936752f, 1.0f), 0.000001f);

            sincos(float3(float.NegativeInfinity, float.NaN, float.PositiveInfinity), out s, out c);
            TestUtils.AreEqual(asint(s), asint(float3(float.NaN, float.NaN, float.NaN)));
            TestUtils.AreEqual(asint(c), asint(float3(float.NaN, float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void sincos_float4()
        {
            float4 s, c;
            sincos(float4(-1000000.0f, -1.2f, 0.0f, 1.2f), out s, out c);
            TestUtils.AreEqual(s, float4(0.349994f, -0.932039f, 0.0f, 0.932039f), 0.000001f);
            TestUtils.AreEqual(c, float4(0.936752f, 0.362358f, 1.0f, 0.362358f), 0.000001f);

            sincos(float4(1000000.0f, 0.0f, 0.0f, 0.0f), out s, out c);
            TestUtils.AreEqual(s, float4(-0.349994f, 0.0f, 0.0f, 0.0f), 0.000001f);
            TestUtils.AreEqual(c, float4(0.936752f, 1.0f, 1.0f, 1.0f), 0.000001f);

            sincos(float4(float.NegativeInfinity, float.NaN, float.PositiveInfinity, float.NaN), out s, out c);
            TestUtils.AreEqual(asint(s), asint(float4(float.NaN, float.NaN, float.NaN, float.NaN)));
            TestUtils.AreEqual(asint(c), asint(float4(float.NaN, float.NaN, float.NaN, float.NaN)));
        }

        [TestCompiler]
        public void sincos_double()
        {
            double s, c;
            sincos(-1000000.0, out s, out c);
            TestUtils.AreEqual(s, 0.349993502171293, 1e-14);
            TestUtils.AreEqual(c, 0.936752127533145, 1e-14);

            sincos(-1.2, out s, out c);
            TestUtils.AreEqual(s, -0.932039085967226, 1e-14);
            TestUtils.AreEqual(c, 0.362357754476674, 1e-14);

            sincos(0.0, out s, out c);
            TestUtils.AreEqual(s, 0.0, 1e-14);
            TestUtils.AreEqual(c, 1.0, 1e-14);

            sincos(1.2, out s, out c);
            TestUtils.AreEqual(s, 0.932039085967226, 1e-14);
            TestUtils.AreEqual(c, 0.362357754476674, 1e-14);

            sincos(1000000.0, out s, out c);
            TestUtils.AreEqual(s, -0.34999350217129295, 1e-14);
            TestUtils.AreEqual(c, 0.936752127533145, 1e-14);

            sincos(double.NegativeInfinity, out s, out c);
            TestUtils.AreEqual(aslong(s), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c), aslong(double.NaN));

            sincos(double.NaN, out s, out c);
            TestUtils.AreEqual(aslong(s), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c), aslong(double.NaN));

            sincos(double.PositiveInfinity, out s, out c);
            TestUtils.AreEqual(aslong(s), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c), aslong(double.NaN));
        }

        [TestCompiler]
        public void sincos_double2()
        {
            double2 s, c;
            sincos(double2(-1000000.0, -1.2), out s, out c);
            TestUtils.AreEqual(s, double2(0.349993502171293, -0.932039085967226), 1e-14);
            TestUtils.AreEqual(c, double2(0.936752127533145, 0.362357754476674), 1e-14);

            sincos(double2(0.0, 1.2), out s, out c);
            TestUtils.AreEqual(s, double2(0.0, 0.932039085967226), 1e-14);
            TestUtils.AreEqual(c, double2(1.0, 0.362357754476674), 1e-14);

            sincos(double2(1000000.0, 0.0), out s, out c);
            TestUtils.AreEqual(s, double2(-0.34999350217129295, 0.0), 1e-14);
            TestUtils.AreEqual(c, double2(0.936752127533145, 1.0), 1e-14);

            sincos(double2(double.NegativeInfinity, double.NaN), out s, out c);
            TestUtils.AreEqual(aslong(s.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(s.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.y), aslong(double.NaN));

            sincos(double2(double.PositiveInfinity, double.NaN), out s, out c);
            TestUtils.AreEqual(aslong(s.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(s.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.y), aslong(double.NaN));
        }

        [TestCompiler]
        public void sincos_double3()
        {
            double3 s, c;
            sincos(double3(-1000000.0, -1.2, 0.0), out s, out c);
            TestUtils.AreEqual(s, double3(0.349993502171293, -0.932039085967226, 0.0), 1e-14);
            TestUtils.AreEqual(c, double3(0.936752127533145, 0.362357754476674, 1.0), 1e-14);

            sincos(double3(1.2, 1000000.0, 0.0), out s, out c);
            TestUtils.AreEqual(s, double3(0.932039085967226, -0.34999350217129295, 0.0), 1e-14);
            TestUtils.AreEqual(c, double3(0.362357754476674, 0.936752127533145, 1.0), 1e-14);

            sincos(double3(double.NegativeInfinity, double.NaN, double.PositiveInfinity), out s, out c);
            TestUtils.AreEqual(aslong(s.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(s.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(s.z), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.z), aslong(double.NaN));
        }

        [TestCompiler]
        public void sincos_double4()
        {
            double4 s, c;
            sincos(double4(-1000000.0, -1.2, 0.0, 1.2), out s, out c);
            TestUtils.AreEqual(s, double4(0.349993502171293, -0.932039085967226, 0.0, 0.932039085967226), 1e-14);
            TestUtils.AreEqual(c, double4(0.936752127533145, 0.362357754476674, 1.0, 0.362357754476674), 1e-14);

            sincos(double4(1000000.0, 0.0, 0.0, 0.0), out s, out c);
            TestUtils.AreEqual(s, double4(-0.349993502171293, 0.0, 0.0, 0.0), 0.000001);
            TestUtils.AreEqual(c, double4(0.936752127533145, 1.0, 1.0, 1.0), 1e-14);

            sincos(double4(double.NegativeInfinity, double.NaN, double.PositiveInfinity, double.NaN), out s, out c);
            TestUtils.AreEqual(aslong(s.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(s.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(s.z), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.x), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.y), aslong(double.NaN));
            TestUtils.AreEqual(aslong(c.z), aslong(double.NaN));
        }
    }
}
