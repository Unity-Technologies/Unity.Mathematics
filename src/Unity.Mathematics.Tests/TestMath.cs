// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestMath
    {
        [Test]
        public void abs_int()
        {
            Assert.AreEqual(abs(0), 0);
            Assert.AreEqual(abs(-7), 7);
            Assert.AreEqual(abs(11), 11);
            Assert.AreEqual(abs(-2147483647), 2147483647);
            Assert.AreEqual(abs(-2147483648), -2147483648);
        }

        [Test]
        public void abs_int2()
        {
            Assert.AreEqual(abs(int2(0, -7)), int2(0, 7));
            Assert.AreEqual(abs(int2(11, -2147483647)), int2(11, 2147483647));
            Assert.AreEqual(abs(int2(-2147483648, -123412)), int2(-2147483648, 123412));
        }

        [Test]
        public void abs_int3()
        {
            Assert.AreEqual(abs(int3(0, -7, 11)), int3(0, 7, 11));
            Assert.AreEqual(abs(int3(-2147483647, -2147483648, -123412)), int3(2147483647, -2147483648, 123412));
        }

        [Test]
        public void abs_int4()
        {
            Assert.AreEqual(abs(int4(0, -7, 11, -2147483647)), int4(0, 7, 11, 2147483647));
            Assert.AreEqual(abs(int4(-2147483648, -123412, 17, -34)), int4(-2147483648, 123412, 17, 34));
        }

        [Test]
        public void abs_float()
        {
            Assert.AreEqual(abs(0.0f), 0.0f);
            Assert.AreEqual(abs(-1.1f), 1.1f);
            Assert.AreEqual(abs(2.2f), 2.2f);
            Assert.AreEqual(abs(float.NegativeInfinity), float.PositiveInfinity);
            Assert.AreEqual(abs(float.PositiveInfinity), float.PositiveInfinity);
        }

        [Test]
        public void abs_float2()
        {
            Assert.AreEqual(abs(float2(0.0f, -1.1f)), float2(0.0f, 1.1f));
            Assert.AreEqual(abs(float2(2.2f, float.NegativeInfinity)), float2(2.2f, float.PositiveInfinity));
            Assert.AreEqual(abs(float2(float.PositiveInfinity, -3.3f)), float2(float.PositiveInfinity, 3.3f));
        }

        [Test]
        public void abs_float3()
        {
            Assert.AreEqual(abs(float3(0.0f, -1.1f, 2.2f)), float3(0.0f, 1.1f, 2.2f));
            Assert.AreEqual(abs(float3(float.NegativeInfinity, float.PositiveInfinity, -3.3f)), float3(float.PositiveInfinity, float.PositiveInfinity, 3.3f));
        }

        [Test]
        public void abs_float4()
        {
            Assert.AreEqual(abs(float4(0.0f, -1.1f, 2.2f, float.NegativeInfinity)), float4(0.0f, 1.1f, 2.2f, float.PositiveInfinity));
            Assert.AreEqual(abs(float4(float.PositiveInfinity, -3.3f, 5.5f, -6.6f)), float4(float.PositiveInfinity, 3.3f, 5.5f, 6.6f));
        }

        [Test]
        public void abs_double()
        {
            Assert.AreEqual(abs(0.0), 0.0);
            Assert.AreEqual(abs(-1.1), 1.1);
            Assert.AreEqual(abs(2.2), 2.2);
            Assert.AreEqual(abs(double.NegativeInfinity), double.PositiveInfinity);
            Assert.AreEqual(abs(double.PositiveInfinity), double.PositiveInfinity);
        }

        [Test]
        public void abs_double2()
        {
            Assert.AreEqual(abs(double2(0.0, -1.1)), double2(0.0, 1.1));
            Assert.AreEqual(abs(double2(2.2, double.NegativeInfinity)), double2(2.2, double.PositiveInfinity));
            Assert.AreEqual(abs(double2(double.PositiveInfinity, -3.3)), double2(double.PositiveInfinity, 3.3));
        }

        [Test]
        public void abs_double3()
        {
            Assert.AreEqual(abs(double3(0.0, -1.1, 2.2)), double3(0.0, 1.1, 2.2));
            Assert.AreEqual(abs(double3(double.NegativeInfinity, double.PositiveInfinity, -3.3)), double3(double.PositiveInfinity, double.PositiveInfinity, 3.3));
        }

        [Test]
        public void abs_double4()
        {
            Assert.AreEqual(abs(double4(0.0, -1.1, 2.2, double.NegativeInfinity)), double4(0.0, 1.1, 2.2, double.PositiveInfinity));
            Assert.AreEqual(abs(double4(double.PositiveInfinity, -3.3, 5.5, -6.6)), double4(double.PositiveInfinity, 3.3, 5.5, 6.6));
        }

        [Test]
        public void asint_uint()
        {
            Assert.AreEqual(asint(0u), 0);
            Assert.AreEqual(asint(0x12345678u), 0x12345678);
            Assert.AreEqual(asint(0x7FFFFFFFu), 0x7FFFFFFF);
            Assert.AreEqual(asint(0x80000000u), -2147483648);
            Assert.AreEqual(asint(0x87654321u), -2023406815);
            Assert.AreEqual(asint(0xFFFFFFFFu), -1);
        }

        [Test]
        public void asint_uint2()
        {
            Assert.AreEqual(asint(uint2(0u, 0x12345678u)), int2(0, 0x12345678));
            Assert.AreEqual(asint(uint2(0x7FFFFFFFu, 0x80000000u)), int2(0x7FFFFFFF, -2147483648));
            Assert.AreEqual(asint(uint2(0x87654321u, 0xFFFFFFFFu)), int2(-2023406815, -1));
        }

        [Test]
        public void asint_uint3()
        {
            Assert.AreEqual(asint(uint3(0u, 0x12345678u, 0x7FFFFFFFu)), int3(0, 0x12345678, 0x7FFFFFFF));
            Assert.AreEqual(asint(uint3(0x80000000u, 0x87654321u, 0xFFFFFFFFu)), int3(-2147483648, -2023406815, -1));
        }

        [Test]
        public void asint_uint4()
        {
            Assert.AreEqual(asint(uint4(0u, 0x12345678u, 0x7FFFFFFFu, 0x80000000u)), int4(0, 0x12345678, 0x7FFFFFFF, -2147483648));
            Assert.AreEqual(asint(uint4(0x87654321u, 0xFFFFFFFFu, 0u, 0u)), int4(-2023406815, -1, 0, 0));
        }

        [Test]
        public void asint_float()
        {
            Assert.AreEqual(asint(0.0f), 0);
            Assert.AreEqual(asint(1.0f), 0x3F800000);
            Assert.AreEqual(asint(1234.56f), 0x449A51EC);
            Assert.AreEqual(asint(float.PositiveInfinity), 0x7F800000);
            Assert.AreEqual(asint(float.NaN), unchecked((int)0xFFC00000));

            Assert.AreEqual(asint(-0.0f), unchecked((int)0x80000000));
            Assert.AreEqual(asint(-1.0f), unchecked((int)0xBF800000));
            Assert.AreEqual(asint(-1234.56f), unchecked((int)0xC49A51EC));
            Assert.AreEqual(asint(float.NegativeInfinity), unchecked((int)0xFF800000));
        }

        [Test]
        public void asint_float2()
        {
            Assert.AreEqual(asint(float2(0.0f, 1.0f)), int2(0, 0x3F800000));
            Assert.AreEqual(asint(float2(1234.56f, float.PositiveInfinity)), int2(0x449A51EC, 0x7F800000));
            Assert.AreEqual(asint(float2(float.NaN, -0.0f)), int2(unchecked((int)0xFFC00000), unchecked((int)0x80000000)));

            Assert.AreEqual(asint(float2(-1.0f, -1234.56f)), int2(unchecked((int)0xBF800000), unchecked((int)0xC49A51EC)));
            Assert.AreEqual(asint(float2(float.NegativeInfinity, 0.0f)), int2(unchecked((int)0xFF800000), 0));
        }

        [Test]
        public void asint_float3()
        {
            Assert.AreEqual(asint(float3(0.0f, 1.0f, 1234.56f)), int3(0, 0x3F800000, 0x449A51EC));
            Assert.AreEqual(asint(float3(float.PositiveInfinity, float.NaN, -0.0f)), int3(0x7F800000, unchecked((int)0xFFC00000), unchecked((int)0x80000000)));
            Assert.AreEqual(asint(float3(-1.0f, -1234.56f, float.NegativeInfinity)), int3(unchecked((int)0xBF800000), unchecked((int)0xC49A51EC), unchecked((int)0xFF800000)));
        }

        [Test]
        public void asint_float4()
        {
            Assert.AreEqual(asint(float4(0.0f, 1.0f, 1234.56f, float.PositiveInfinity)), int4(0, 0x3F800000, 0x449A51EC, 0x7F800000));
            Assert.AreEqual(asint(float4(float.NaN, -0.0f, -1.0f, -1234.56f)), int4(unchecked((int)0xFFC00000), unchecked((int)0x80000000), unchecked((int)0xBF800000), unchecked((int)0xC49A51EC)));
            Assert.AreEqual(asint(float4(float.NegativeInfinity, 0.0f, 0.0f, 0.0f)), int4(unchecked((int)0xFF800000), 0, 0, 0));
        }

        [Test]
        public void asuint_int()
        {
            Assert.AreEqual(asuint(0), 0u);
            Assert.AreEqual(asuint(0x12345678), 0x12345678u);
            Assert.AreEqual(asuint(0x7FFFFFFF), 0x7FFFFFFFu);
            Assert.AreEqual(asuint(-2147483648), 0x80000000u);
            Assert.AreEqual(asuint(-2023406815), 0x87654321u);
            Assert.AreEqual(asuint(-1), 0xFFFFFFFFu);
        }

        [Test]
        public void asuint_int2()
        {
            Assert.AreEqual(asuint(int2(0, 0x12345678)), uint2(0u, 0x12345678u));
            Assert.AreEqual(asuint(int2(0x7FFFFFFF, -2147483648)), uint2(0x7FFFFFFFu, 0x80000000u));
            Assert.AreEqual(asuint(int2(-2023406815, -1)), uint2(0x87654321u, 0xFFFFFFFFu));
        }

        [Test]
        public void asuint_int3()
        {
            Assert.AreEqual(asuint(int3(0, 0x12345678, 0x7FFFFFFF)), uint3(0u, 0x12345678u, 0x7FFFFFFFu));
            Assert.AreEqual(asuint(int3(-2147483648, -2023406815, -1)), uint3(0x80000000u, 0x87654321u, 0xFFFFFFFFu));
        }

        [Test]
        public void asuint_int4()
        {
            Assert.AreEqual(asuint(int4(0, 0x12345678, 0x7FFFFFFF, -2147483648)), uint4(0u, 0x12345678u, 0x7FFFFFFFu, 0x80000000u));
            Assert.AreEqual(asuint(int4(-2023406815, -1, 0, 0)), uint4(0x87654321u, 0xFFFFFFFFu, 0u, 0u));
        }

        [Test]
        public void asuint_float()
        {
            Assert.AreEqual(asuint(0.0f), 0u);
            Assert.AreEqual(asuint(1.0f), 0x3F800000u);
            Assert.AreEqual(asuint(1234.56f), 0x449A51ECu);
            Assert.AreEqual(asuint(float.PositiveInfinity), 0x7F800000u);
            Assert.AreEqual(asuint(float.NaN), 0xFFC00000u);

            Assert.AreEqual(asuint(-0.0f), 0x80000000u);
            Assert.AreEqual(asuint(-1.0f), 0xBF800000u);
            Assert.AreEqual(asuint(-1234.56f), 0xC49A51ECu);
            Assert.AreEqual(asuint(float.NegativeInfinity), 0xFF800000u);
        }

        [Test]
        public void asuint_float2()
        {
            Assert.AreEqual(asuint(float2(0.0f, 1.0f)), uint2(0u, 0x3F800000u));
            Assert.AreEqual(asuint(float2(1234.56f, float.PositiveInfinity)), uint2(0x449A51Ecu, 0x7F800000u));
            Assert.AreEqual(asuint(float2(float.NaN, -0.0f)), uint2(0xFFC00000u, 0x80000000u));

            Assert.AreEqual(asuint(float2(-1.0f, -1234.56f)), uint2(0xBF800000u, 0xC49A51ECu));
            Assert.AreEqual(asuint(float2(float.NegativeInfinity, 0.0f)), uint2(0xFF800000u, 0u));
        }

        [Test]
        public void asuint_float3()
        {
            Assert.AreEqual(asuint(float3(0.0f, 1.0f, 1234.56f)), uint3(0u, 0x3F800000u, 0x449A51ECu));
            Assert.AreEqual(asuint(float3(float.PositiveInfinity, float.NaN, -0.0f)), uint3(0x7F800000u, 0xFFC00000u, 0x80000000u));
            Assert.AreEqual(asuint(float3(-1.0f, -1234.56f, float.NegativeInfinity)), uint3(0xBF800000u, 0xC49A51ECu, 0xff800000u));
        }

        [Test]
        public void asuint_float4()
        {
            Assert.AreEqual(asuint(float4(0.0f, 1.0f, 1234.56f, float.PositiveInfinity)), uint4(0u, 0x3F800000u, 0x449A51ECu, 0x7F800000u));
            Assert.AreEqual(asuint(float4(float.NaN, -0.0f, -1.0f, -1234.56f)), uint4(0xFFC00000u, 0x80000000u, 0xBF800000u, 0xC49A51ECu));
            Assert.AreEqual(asuint(float4(float.NegativeInfinity, 0.0f, 0.0f, 0.0f)), uint4(0xFF800000u, 0u, 0u, 0u));
        }

        [Test]
        public void aslong_ulong()
        {
            Assert.AreEqual(aslong(0ul), 0L);
            Assert.AreEqual(aslong(0x0123456789ABCDEFul), 0x0123456789ABCDEFL);
            Assert.AreEqual(aslong(0x7FFFFFFFFFFFFFFFul), 0x7FFFFFFFFFFFFFFFL);
            Assert.AreEqual(aslong(0x8000000000000000ul), -9223372036854775808L);
            Assert.AreEqual(aslong(0xFEDCBA9876543210ul), -81985529216486896L);
            Assert.AreEqual(aslong(0xFFFFFFFFFFFFFFFFul), -1L);
        }

        [Test]
        public void aslong_double()
        {
            Assert.AreEqual(aslong(0.0), 0L);
            Assert.AreEqual(aslong(1.0), 0x3FF0000000000000L);
            Assert.AreEqual(aslong(1234.56), 0x40934A3D70A3D70AL);
            Assert.AreEqual(aslong(double.PositiveInfinity), 0x7FF0000000000000L);
            Assert.AreEqual(aslong(double.NaN), unchecked((long)0xFFF8000000000000UL));

            Assert.AreEqual(aslong(-0.0), unchecked((long)0x8000000000000000UL));
            Assert.AreEqual(aslong(-1.0), unchecked((long)0xBFF0000000000000UL));
            Assert.AreEqual(aslong(-1234.56), unchecked((long)0xC0934A3D70A3D70AUL));
            Assert.AreEqual(aslong(double.NegativeInfinity), unchecked((long)0xFFF0000000000000UL));
        }


        [Test]
        public void asulong_long()
        {
            Assert.AreEqual(asulong(0L), 0ul);
            Assert.AreEqual(asulong(0x0123456789ABCDEFL), 0x0123456789ABCDEFul);
            Assert.AreEqual(asulong(0x7FFFFFFFFFFFFFFFL), 0x7FFFFFFFFFFFFFFFul);
            Assert.AreEqual(asulong(-9223372036854775808L), 0x8000000000000000ul);
            Assert.AreEqual(asulong(-81985529216486896L), 0xFEDCBA9876543210ul);
            Assert.AreEqual(asulong(-1L), 0xFFFFFFFFFFFFFFFFul);
        }

        [Test]
        public void asulong_double()
        {
            Assert.AreEqual(asulong(0.0), 0UL);
            Assert.AreEqual(asulong(1.0), 0x3FF0000000000000UL);
            Assert.AreEqual(asulong(1234.56), 0x40934A3D70A3D70AUL);
            Assert.AreEqual(asulong(double.PositiveInfinity), 0x7FF0000000000000UL);
            Assert.AreEqual(asulong(double.NaN), 0xFFF8000000000000UL);

            Assert.AreEqual(asulong(-0.0), 0x8000000000000000UL);
            Assert.AreEqual(asulong(-1.0), 0xBFF0000000000000UL);
            Assert.AreEqual(asulong(-1234.56), 0xC0934A3D70A3D70AUL);
            Assert.AreEqual(asulong(double.NegativeInfinity), 0xFFF0000000000000UL);
        }

        [Test]
        public void asfloat_int()
        {
            Assert.AreEqual(asfloat(0), 0.0f);
            Assert.AreEqual(asfloat(0x3F800000), 1.0f);
            Assert.AreEqual(asfloat(0x449A51EC), 1234.56f);
            Assert.AreEqual(asfloat(0x7F800000), float.PositiveInfinity);
            Assert.AreEqual(asfloat(unchecked((int)0x80000000)), -0.0f);
            Assert.AreEqual(asfloat(unchecked((int)0xBF800000)), -1.0f);
            Assert.AreEqual(asfloat(unchecked((int)0xC49A51EC)), -1234.56f);
            Assert.AreEqual(asfloat(unchecked((int)0xFF800000)), float.NegativeInfinity);

            Assert.AreEqual(asuint(asfloat(unchecked((int)0xFFC00000))), asuint(float.NaN));
        }

        [Test]
        public void asfloat_int2()
        {
            Assert.AreEqual(asfloat(int2(0, 0x3F800000)), float2(0.0f, 1.0f));
            Assert.AreEqual(asfloat(int2(0x449A51EC, 0x7F800000)), float2(1234.56f, float.PositiveInfinity));
            Assert.AreEqual(asfloat(int2(unchecked((int)0x80000000), unchecked((int)0xBF800000))), float2(-0.0f, -1.0f));

            Assert.AreEqual(asfloat(int2(unchecked((int)0xC49A51EC), unchecked((int)0xFF800000))), float2(-1234.56f, float.NegativeInfinity));
            Assert.AreEqual(asuint(asfloat(int2(unchecked((int)0xFFC00000), unchecked((int)0xFFC00000)))), asuint(float2(float.NaN, float.NaN)));
        }

        [Test]
        public void asfloat_int3()
        {
            Assert.AreEqual(asfloat(int3(0, 0x3F800000, 0x449A51EC)), float3(0.0f, 1.0f, 1234.56f));
            Assert.AreEqual(asfloat(int3(0x7F800000, unchecked((int)0x80000000), unchecked((int)0xBF800000))), float3(float.PositiveInfinity, -0.0f, -1.0f));

            Assert.AreEqual(asfloat(int3(unchecked((int)0xC49A51EC), unchecked((int)0xFF800000), 0)), float3(-1234.56f, float.NegativeInfinity, 0.0f));
            Assert.AreEqual(asuint(asfloat(int3(unchecked((int)0xFFC00000), unchecked((int)0xFFC00000), unchecked((int)0xFFC00000)))), asuint(float3(float.NaN, float.NaN, float.NaN)));
        }

        [Test]
        public void asfloat_int4()
        {
            Assert.AreEqual(asfloat(int4(0, 0x3F800000, 0x449A51EC, 0x7F800000)), float4(0.0f, 1.0f, 1234.56f, float.PositiveInfinity));
            Assert.AreEqual(asfloat(int4(unchecked((int)0x80000000), unchecked((int)0xBF800000), unchecked((int)0xC49A51EC), unchecked((int)0xFF800000))), float4(-0.0f, -1.0f, -1234.56f, float.NegativeInfinity));

            Assert.AreEqual(asuint(asfloat(int4(unchecked((int)0xFFC00000), unchecked((int)0xFFC00000), unchecked((int)0xFFC00000), unchecked((int)0xFFC00000)))), asuint(float4(float.NaN, float.NaN, float.NaN, float.NaN)));
        }

        [Test]
        public void asfloat_uint()
        {
            Assert.AreEqual(asfloat(0u), 0.0f);
            Assert.AreEqual(asfloat(0x3F800000u), 1.0f);
            Assert.AreEqual(asfloat(0x449A51ECu), 1234.56f);
            Assert.AreEqual(asfloat(0x7F800000u), float.PositiveInfinity);
            Assert.AreEqual(asfloat(0x80000000u), -0.0f);
            Assert.AreEqual(asfloat(0xBF800000u), -1.0f);
            Assert.AreEqual(asfloat(0xC49A51ECu), -1234.56f);
            Assert.AreEqual(asfloat(0xFF800000u), float.NegativeInfinity);

            Assert.AreEqual(asuint(asfloat(0xFFC00000u)), asuint(float.NaN));
        }

        [Test]
        public void asfloat_uint2()
        {
            Assert.AreEqual(asfloat(uint2(0u, 0x3F800000u)), float2(0.0f, 1.0f));
            Assert.AreEqual(asfloat(uint2(0x449A51ECu, 0x7F800000u)), float2(1234.56f, float.PositiveInfinity));
            Assert.AreEqual(asfloat(uint2(0x80000000u, 0xBF800000u)), float2(-0.0f, -1.0f));

            Assert.AreEqual(asfloat(uint2(0xC49A51ECu, 0xFF800000u)), float2(-1234.56f, float.NegativeInfinity));
            Assert.AreEqual(asuint(asfloat(uint2(0xFFC00000u, 0xFFC00000u))), asuint(float2(float.NaN, float.NaN)));
        }

        [Test]
        public void asfloat_uint3()
        {
            Assert.AreEqual(asfloat(uint3(0u, 0x3F800000u, 0x449A51ECu)), float3(0.0f, 1.0f, 1234.56f));
            Assert.AreEqual(asfloat(uint3(0x7F800000u, 0x80000000u, 0xBF800000u)), float3(float.PositiveInfinity, -0.0f, -1.0f));

            Assert.AreEqual(asfloat(uint3(0xC49A51ECu, 0xFF800000u, 0u)), float3(-1234.56f, float.NegativeInfinity, 0.0f));
            Assert.AreEqual(asuint(asfloat(uint3(0xFFC00000u, 0xFFC00000u, 0xFFC00000u))), asuint(float3(float.NaN, float.NaN, float.NaN)));
        }

        [Test]
        public void asfloat_uint4()
        {
            Assert.AreEqual(asfloat(uint4(0u, 0x3F800000u, 0x449A51ECu, 0x7F800000u)), float4(0.0f, 1.0f, 1234.56f, float.PositiveInfinity));
            Assert.AreEqual(asfloat(uint4(0x80000000u, 0xBF800000u, 0xC49A51ECu, 0xFF800000u)), float4(-0.0f, -1.0f, -1234.56f, float.NegativeInfinity));

            Assert.AreEqual(asuint(asfloat(uint4(0xFFC00000u, 0xFFC00000u, 0xFFC00000u, 0xFFC00000u))), asuint(float4(float.NaN, float.NaN, float.NaN, float.NaN)));
        }

        [Test]
        public void asdouble_long()
        {
            Assert.AreEqual(asdouble(0L), 0.0);
            Assert.AreEqual(asdouble(0x3FF0000000000000L), 1.0);
            Assert.AreEqual(asdouble(0x40934A3D70A3D70AL), 1234.56);
            Assert.AreEqual(asdouble(0x7FF0000000000000L), double.PositiveInfinity);
            Assert.AreEqual(asdouble(unchecked((long)0xFFF8000000000000UL)), double.NaN);

            Assert.AreEqual(asdouble(unchecked((long)0x8000000000000000UL)), -0.0);
            Assert.AreEqual(asdouble(unchecked((long)0xBFF0000000000000UL)), -1.0);
            Assert.AreEqual(asdouble(unchecked((long)0xC0934A3D70A3D70AUL)), -1234.56);
            Assert.AreEqual(asdouble(unchecked((long)0xFFF0000000000000UL)), double.NegativeInfinity);
        }

        [Test]
        public void asdouble_ulong()
        {
            Assert.AreEqual(asdouble(0UL), 0.0);
            Assert.AreEqual(asdouble(0x3FF0000000000000UL), 1.0);
            Assert.AreEqual(asdouble(0x40934A3D70A3D70AUL), 1234.56);
            Assert.AreEqual(asdouble(0x7FF0000000000000UL), double.PositiveInfinity);
            Assert.AreEqual(asdouble(0xFFF8000000000000UL), double.NaN);

            Assert.AreEqual(asdouble(0x8000000000000000UL), -0.0);
            Assert.AreEqual(asdouble(0xBFF0000000000000UL), -1.0);
            Assert.AreEqual(asdouble(0xC0934A3D70A3D70AUL), -1234.56);
            Assert.AreEqual(asdouble(0xFFF0000000000000UL), double.NegativeInfinity);
        }

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

        [Test]
        public void faceforward_float2()
        {
            Assert.AreEqual(faceforward(float2(3.5f, -4.5f), float2(1.0f, -2.0f), float2( 3.0f, -4.0f)), float2(-3.5f,  4.5f));
            Assert.AreEqual(faceforward(float2(3.5f, -4.5f), float2(1.0f, -2.0f), float2(-3.0f,  4.0f)), float2( 3.5f, -4.5f));
            Assert.AreEqual(faceforward(float2(3.5f, -4.5f), float2(1.0f, -2.0f), float2( 0.0f,  0.0f)), float2(-3.5f,  4.5f));
        }

        [Test]
        public void faceforward_float3()
        {
            Assert.AreEqual(faceforward(float3(3.5f, -4.5f, 5.5f), float3(1.0f, -2.0f, 3.0f), float3( 3.0f, -4.0f,  5.0f)), float3(-3.5f,  4.5f, -5.5f));
            Assert.AreEqual(faceforward(float3(3.5f, -4.5f, 5.5f), float3(1.0f, -2.0f, 3.0f), float3(-3.0f,  4.0f, -5.0f)), float3( 3.5f, -4.5f,  5.5f));
            Assert.AreEqual(faceforward(float3(3.5f, -4.5f, 5.5f), float3(1.0f, -2.0f, 3.0f), float3( 0.0f,  0.0f,  0.0f)), float3(-3.5f,  4.5f, -5.5f));
        }

        [Test]
        public void faceforward_float4()
        {
            Assert.AreEqual(faceforward(float4(3.5f, -4.5f, 5.5f, -6.5f), float4(1.0f, -2.0f, 3.0f, -4.0f), float4( 3.0f, -4.0f,  5.0f, -6.0f)), float4(-3.5f,  4.5f, -5.5f,  6.5f));
            Assert.AreEqual(faceforward(float4(3.5f, -4.5f, 5.5f, -6.5f), float4(1.0f, -2.0f, 3.0f, -4.0f), float4(-3.0f,  4.0f, -5.0f,  6.0f)), float4( 3.5f, -4.5f,  5.5f, -6.5f));
            Assert.AreEqual(faceforward(float4(3.5f, -4.5f, 5.5f, -6.5f), float4(1.0f, -2.0f, 3.0f, -4.0f), float4( 0.0f,  0.0f,  0.0f,  0.0f)), float4(-3.5f,  4.5f, -5.5f,  6.5f));
        }

        [Test]
        public void faceforward_double2()
        {
            Assert.AreEqual(faceforward(double2(3.5, -4.5), double2(1.0, -2.0), double2( 3.0, -4.0)), double2(-3.5,  4.5));
            Assert.AreEqual(faceforward(double2(3.5, -4.5), double2(1.0, -2.0), double2(-3.0,  4.0)), double2( 3.5, -4.5));
            Assert.AreEqual(faceforward(double2(3.5, -4.5), double2(1.0, -2.0), double2( 0.0,  0.0)), double2(-3.5,  4.5));
        }

        [Test]
        public void faceforward_double3()
        {
            Assert.AreEqual(faceforward(double3(3.5, -4.5, 5.5), double3(1.0, -2.0, 3.0), double3( 3.0, -4.0,  5.0)), double3(-3.5,  4.5, -5.5));
            Assert.AreEqual(faceforward(double3(3.5, -4.5, 5.5), double3(1.0, -2.0, 3.0), double3(-3.0,  4.0, -5.0)), double3( 3.5, -4.5,  5.5));
            Assert.AreEqual(faceforward(double3(3.5, -4.5, 5.5), double3(1.0, -2.0, 3.0), double3( 0.0,  0.0,  0.0)), double3(-3.5,  4.5, -5.5));
        }

        [Test]
        public void faceforward_double4()
        {
            Assert.AreEqual(faceforward(double4(3.5, -4.5, 5.5, -6.5), double4(1.0, -2.0, 3.0, -4.0), double4( 3.0, -4.0,  5.0, -6.0)), double4(-3.5,  4.5, -5.5,  6.5));
            Assert.AreEqual(faceforward(double4(3.5, -4.5, 5.5, -6.5), double4(1.0, -2.0, 3.0, -4.0), double4(-3.0,  4.0, -5.0,  6.0)), double4( 3.5, -4.5,  5.5, -6.5));
            Assert.AreEqual(faceforward(double4(3.5, -4.5, 5.5, -6.5), double4(1.0, -2.0, 3.0, -4.0), double4( 0.0,  0.0,  0.0,  0.0)), double4(-3.5,  4.5, -5.5,  6.5));
        }

        [Test]
        public void modf_float()
        {
            float f, i;
            f = modf(313.75f, out i);
            Assert.AreEqual(i, 313.0f);
            Assert.AreEqual(f, 0.75f);

            f = modf(-313.25f, out i);
            Assert.AreEqual(i, -313.0f);
            Assert.AreEqual(f, -0.25f);

            f = modf(-314.0f, out i);
            Assert.AreEqual(i, -314.0f);
            Assert.AreEqual(f, 0.0f);
        }

        [Test]
        public void modf_float2()
        {
            float2 f, i;
            f = modf(float2(313.75f, -313.25f), out i);
            Assert.AreEqual(i, float2(313.0f, -313.0f));
            Assert.AreEqual(f, float2(0.75f, -0.25f));

            f = modf(float2(-314.0f, 7.5f), out i);
            Assert.AreEqual(i, float2(-314.0f, 7.0f));
            Assert.AreEqual(f, float2(0.0f, 0.5f));
        }

        [Test]
        public void modf_float3()
        {
            float3 f, i;
            f = modf(float3(313.75f, -313.25f, -314.0f), out i);
            Assert.AreEqual(i, float3(313.0f, -313.0f, -314.0f));
            Assert.AreEqual(f, float3(0.75f, -0.25f, 0.0f));
        }

        [Test]
        public void modf_float4()
        {
            float4 f, i;
            f = modf(float4(313.75f, -313.25f, -314.0f, 7.5f), out i);
            Assert.AreEqual(i, float4(313.0f, -313.0f, -314.0f, 7.0f));
            Assert.AreEqual(f, float4(0.75f, -0.25f, 0.0f, 0.5f));
        }

        [Test]
        public void modf_double()
        {
            double f, i;
            f = modf(313.75, out i);
            Assert.AreEqual(i, 313.0);
            Assert.AreEqual(f, 0.75);

            f = modf(-313.25, out i);
            Assert.AreEqual(i, -313.0);
            Assert.AreEqual(f, -0.25);

            f = modf(-314.0, out i);
            Assert.AreEqual(i, -314.0);
            Assert.AreEqual(f, 0.0);
        }

        [Test]
        public void modf_double2()
        {
            double2 f, i;
            f = modf(double2(313.75, -313.25), out i);
            Assert.AreEqual(i, double2(313.0, -313.0));
            Assert.AreEqual(f, double2(0.75, -0.25));

            f = modf(double2(-314.0, 7.5), out i);
            Assert.AreEqual(i, double2(-314.0, 7.0));
            Assert.AreEqual(f, double2(0.0, 0.5));
        }

        [Test]
        public void modf_double3()
        {
            double3 f, i;
            f = modf(double3(313.75, -313.25, -314.0), out i);
            Assert.AreEqual(i, double3(313.0, -313.0, -314.0));
            Assert.AreEqual(f, double3(0.75, -0.25, 0.0));
        }

        [Test]
        public void modf_double4()
        {
            double4 f, i;
            f = modf(double4(313.75, -313.25, -314.0, 7.5), out i);
            Assert.AreEqual(i, double4(313.0, -313.0, -314.0, 7.0));
            Assert.AreEqual(f, double4(0.75, -0.25, 0.0, 0.5f));
        }

        [Test]
        public void unlerp_float()
        {
            Assert.AreEqual(unlerp(-1.5f, 2.5f, 0.5f), 0.5f);
            Assert.AreEqual(unlerp(-100.5f, 22.5f, lerp(-100.5f, 22.5f, 0.25f)), 0.25f);
        }

        [Test]
        public void unlerp_double()
        {
            Assert.AreEqual(unlerp(-1.5, 2.5, 0.5), 0.5);
            Assert.AreEqual(unlerp(-100.5, 22.5, lerp(-100.5, 22.5, 0.25)), 0.25);
        }

        [Test]
        public void remap_float()
        {
            Assert.AreEqual(remap(-1.0f, 3.0f, -75.0f, 25.0f, 0.5f), -37.5f);
        }

        [Test]
        public void remap_double()
        {
            Assert.AreEqual(remap(-1.0, 3.0, -75.0, 25.0, 0.5), -37.5);
        }


        [Test]
        public void normalize_float2()
        {
            TestUtils.AreEqual(normalize(float2(3.1f, -5.3f)), float2(0.504883f, -0.863188f), 0.0001f);
            Assert.IsTrue(all(isnan(normalize(float2(0.0f, 0.0f)))));
        }

        [Test]
        public void normalize_float3()
        {
            TestUtils.AreEqual(normalizesafe(float3(3.1f, -5.3f, 2.6f)), float3(0.464916f, -0.794861f, 0.389932f), 0.0001f);
            Assert.IsTrue(all(isnan(normalize(float3(0.0f, 0.0f, 0.0f)))));
        }

        [Test]
        public void normalize_float4()
        {
            TestUtils.AreEqual(normalizesafe(float4(3.1f, -5.3f, 2.6f, 11.4f)), float4(0.234727f, -0.401308f, 0.196868f, 0.863191f), 0.0001f);
            Assert.IsTrue(all(isnan(normalize(float4(0.0f, 0.0f, 0.0f, 0.0f)))));
        }


        [Test]
        public void normalize_double2()
        {
            TestUtils.AreEqual(normalize(double2(3.1, -5.3)), double2(0.504883, -0.863188), 0.0001);
            Assert.IsTrue(all(isnan(normalize(double2(0.0, 0.0)))));
        }

        [Test]
        public void normalize_double3()
        {
            TestUtils.AreEqual(normalizesafe(double3(3.1, -5.3, 2.6)), double3(0.464916, -0.794861, 0.389932), 0.0001);
            Assert.IsTrue(all(isnan(normalize(double3(0.0, 0.0, 0.0)))));
        }

        [Test]
        public void normalize_double4()
        {
            TestUtils.AreEqual(normalizesafe(double4(3.1, -5.3, 2.6, 11.4)), double4(0.234727, -0.401308, 0.196868, 0.863191), 0.0001);
            Assert.IsTrue(all(isnan(normalize(double4(0.0, 0.0, 0.0, 0.0f)))));
        }

        [Test]
        public void normalize_quaternion()
        {
            TestUtils.AreEqual(normalizesafe(quaternion(3.1f, -5.3f, 2.6f, 11.4f)), quaternion(0.234727f, -0.401308f, 0.196868f, 0.863191f), 0.0001f);
            Assert.IsTrue(all(isnan(normalize(quaternion(0.0f, 0.0f, 0.0f, 0.0f)).value)));
        }


        [Test]
        public void normalizesafe_float2()
        {
            TestUtils.AreEqual(normalizesafe(float2(3.1f, -5.3f)), float2(0.504883f, -0.863188f), 0.0001f);
            Assert.AreEqual(normalizesafe(float2(0.0f, 0.0f)), float2(0.0f, 0.0f));
            Assert.AreEqual(normalizesafe(float2(0.0f, 0.0f), float2(1.0f,2.0f)), float2(1.0f, 2.0f));
            TestUtils.AreEqual(normalizesafe(float2(1e-18f, 2e-18f)), float2(0.447214f, 0.894427f), 0.0001f);
            Assert.AreEqual(normalizesafe(float2(7.66e-20f, 7.66e-20f), float2(1.0f, 2.0f)), float2(1.0f, 2.0f));
        }

        [Test]
        public void normalizesafe_float3()
        {
            TestUtils.AreEqual(normalizesafe(float3(3.1f, -5.3f, 2.6f)), float3(0.464916f, -0.794861f, 0.389932f), 0.0001f);
            Assert.AreEqual(normalizesafe(float3(0.0f, 0.0f, 0.0f)), float3(0.0f, 0.0f, 0.0f));
            Assert.AreEqual(normalizesafe(float3(0.0f, 0.0f, 0.0f), float3(1.0f, 2.0f, 3.0f)), float3(1.0f, 2.0f, 3.0f));
            TestUtils.AreEqual(normalizesafe(float3(1e-19f, 2e-19f, 3e-19f)), float3(0.267261f, 0.534523f, 0.801784f), 0.0001f);
            Assert.AreEqual(normalizesafe(float3(6.25e-20f, 6.25e-20f, 6.25e-20f), float3(1.0f, 2.0f, 3.0f)), float3(1.0f, 2.0f, 3.0f));
        }

        [Test]
        public void normalizesafe_float4()
        {
            TestUtils.AreEqual(normalizesafe(float4(3.1f, -5.3f, 2.6f, 11.4f)), float4(0.234727f, -0.401308f, 0.196868f, 0.863191f), 0.0001f);
            Assert.AreEqual(normalizesafe(float4(0.0f, 0.0f, 0.0f, 0.0f)), float4(0.0f, 0.0f, 0.0f, 0.0f));
            Assert.AreEqual(normalizesafe(float4(0.0f, 0.0f, 0.0f, 0.0f), float4(1.0f, 2.0f, 3.0f, 4.0f)), float4(1.0f, 2.0f, 3.0f, 4.0f));
            TestUtils.AreEqual(normalizesafe(float4(1e-19f, 2e-19f, 3e-19f, 4e-19f)), float4(0.182574f, 0.3651484f, 0.547723f, 0.730297f), 0.0001f);
            Assert.AreEqual(normalizesafe(float4(5.42e-20f, 5.42e-20f, 5.42e-20f, 5.42e-20f), float4(1.0f, 2.0f, 3.0f, 4.0f)), float4(1.0f, 2.0f, 3.0f, 4.0f));
        }


        [Test]
        public void normalizesafe_double2()
        {
            TestUtils.AreEqual(normalizesafe(double2(3.1, -5.3)), double2(0.504883, -0.863188), 0.0001);
            Assert.AreEqual(normalizesafe(double2(0.0, 0.0)), double2(0.0, 0.0));
            Assert.AreEqual(normalizesafe(double2(0.0, 0.0), double2(1.0, 2.0)), double2(1.0, 2.0));
            TestUtils.AreEqual(normalizesafe(double2(1e-18, 2e-18)), double2(0.447214, 0.894427), 0.0001);
            Assert.AreEqual(normalizesafe(double2(1.05e-154, 1.05e-154), double2(1.0, 2.0)), double2(1.0, 2.0));
        }

        [Test]
        public void normalizesafe_double3()
        {
            TestUtils.AreEqual(normalizesafe(double3(3.1, -5.3, 2.6)), double3(0.464916, -0.794861, 0.389932), 0.0001);
            Assert.AreEqual(normalizesafe(double3(0.0, 0.0, 0.0)), double3(0.0, 0.0, 0.0));
            Assert.AreEqual(normalizesafe(double3(0.0, 0.0, 0.0), double3(1.0, 2.0, 3.0)), double3(1.0, 2.0, 3.0));
            TestUtils.AreEqual(normalizesafe(double3(1e-19, 2e-19, 3e-19)), double3(0.267261, 0.534523, 0.801784), 0.0001);
            Assert.AreEqual(normalizesafe(double3(8.61e-155, 8.61e-155, 8.61e-155), double3(1.0, 2.0, 3.0)), double3(1.0, 2.0, 3.0));
        }

        [Test]
        public void normalizesafe_double4()
        {
            TestUtils.AreEqual(normalizesafe(double4(3.1, -5.3, 2.6, 11.4)), double4(0.234727, -0.401308, 0.196868, 0.863191), 0.0001);
            Assert.AreEqual(normalizesafe(double4(0.0, 0.0, 0.0, 0.0)), double4(0.0, 0.0, 0.0, 0.0));
            Assert.AreEqual(normalizesafe(double4(0.0, 0.0, 0.0, 0.0), double4(1.0, 2.0, 3.0, 4.0)), double4(1.0, 2.0, 3.0, 4.0));
            TestUtils.AreEqual(normalizesafe(double4(1e-19, 2e-19, 3e-19, 4e-19)), double4(0.182574, 0.3651484, 0.547723, 0.730297), 0.0001);
            Assert.AreEqual(normalizesafe(double4(7.45e-155, 7.45e-155, 7.45e-155, 7.45e-155), double4(1.0, 2.0, 3.0, 4.0)), double4(1.0, 2.0, 3.0, 4.0));
        }

        [Test]
        public void normalizesafe_quaternion()
        {
            TestUtils.AreEqual(normalizesafe(quaternion(3.1f, -5.3f, 2.6f, 11.4f)), quaternion(0.234727f, -0.401308f, 0.196868f, 0.863191f), 0.0001f);
            Assert.AreEqual(normalizesafe(quaternion(0.0f, 0.0f, 0.0f, 0.0f)), quaternion(0.0f, 0.0f, 0.0f, 1.0f));
            Assert.AreEqual(normalizesafe(quaternion(0.0f, 0.0f, 0.0f, 0.0f), quaternion(1.0f, 2.0f, 3.0f, 4.0f)), quaternion(1.0f, 2.0f, 3.0f, 4.0f));
            TestUtils.AreEqual(normalizesafe(quaternion(1e-19f, 2e-19f, 3e-19f, 4e-19f)), quaternion(0.182574f, 0.3651484f, 0.547723f, 0.730297f), 0.0001f);
            Assert.AreEqual(normalizesafe(quaternion(5.42e-20f, 5.42e-20f, 5.42e-20f, 5.42e-20f), quaternion(1.0f, 2.0f, 3.0f, 4.0f)), quaternion(1.0f, 2.0f, 3.0f, 4.0f));
        }

        [Test]
        public void f16tof32_float()
        {
            Assert.AreEqual(asuint(f16tof32(0x0000)), 0x00000000);
            Assert.AreEqual(asuint(f16tof32(0x0203)), 0x3800C000);
            Assert.AreEqual(asuint(f16tof32(0x4321)), 0x40642000);
            Assert.AreEqual(asuint(f16tof32(0x7BFF)), 0x477FE000);
            Assert.AreEqual(asuint(f16tof32(0x7C00)), 0x7F800000);
            Assert.IsTrue(isnan(f16tof32(0x7C01)));

            Assert.AreEqual(asuint(f16tof32(0x8000)), 0x80000000);
            Assert.AreEqual(asuint(f16tof32(0x8203)), 0xB800C000);
            Assert.AreEqual(asuint(f16tof32(0xC321)), 0xC0642000);
            Assert.AreEqual(asuint(f16tof32(0xFBFF)), 0xC77FE000);
            Assert.AreEqual(asuint(f16tof32(0xFC00)), 0xFF800000);
            Assert.IsTrue(isnan(f16tof32(0xFC01)));
        }

        [Test]
        public void f16tof32_float2()
        {
            Assert.AreEqual(asuint(f16tof32(uint2(0x0000, 0x0203))), uint2(0x00000000, 0x3800C000));
            Assert.AreEqual(asuint(f16tof32(uint2(0x4321, 0x7BFF))), uint2(0x40642000, 0x477FE000));
            Assert.AreEqual(asuint(f16tof32(uint2(0x7C00, 0x7C00))), uint2(0x7F800000, 0x7F800000));
            Assert.IsTrue(all(isnan(f16tof32(uint2(0x7C01, 0x7C01)))));

            Assert.AreEqual(asuint(f16tof32(uint2(0x8000, 0x8203))), uint2(0x80000000, 0xB800C000));
            Assert.AreEqual(asuint(f16tof32(uint2(0xC321, 0xFBFF))), uint2(0xC0642000, 0xC77FE000));
            Assert.AreEqual(asuint(f16tof32(uint2(0xFC00, 0xFC00))), uint2(0xFF800000, 0xFF800000));
            Assert.IsTrue(all(isnan(f16tof32(uint2(0xFC01, 0xFC01)))));
        }

        [Test]
        public void f16tof32_float3()
        {
            Assert.AreEqual(asuint(f16tof32(uint3(0x0000, 0x0203, 0x4321))), uint3(0x00000000, 0x3800C000, 0x40642000));
            Assert.AreEqual(asuint(f16tof32(uint3(0x7BFF, 0x7C00, 0x7C00))), uint3(0x477FE000, 0x7F800000, 0x7F800000));
            Assert.IsTrue(all(isnan(f16tof32(uint3(0x7C01, 0x7C01, 0x7C01)))));

            Assert.AreEqual(asuint(f16tof32(uint3(0x8000, 0x8203, 0xC321))), uint3(0x80000000, 0xB800C000, 0xC0642000));
            Assert.AreEqual(asuint(f16tof32(uint3(0xFBFF, 0xFC00, 0xFC00))), uint3(0xC77FE000, 0xFF800000, 0xFF800000));
            Assert.IsTrue(all(isnan(f16tof32(uint3(0xFC01, 0xFC01, 0xFC01)))));
        }

        [Test]
        public void f16tof32_float4()
        {
            Assert.AreEqual(asuint(f16tof32(uint4(0x0000, 0x0203, 0x4321, 0x7BFF))), uint4(0x00000000, 0x3800C000, 0x40642000, 0x477FE000));
            Assert.AreEqual(asuint(f16tof32(uint4(0x7C00, 0x7C00, 0x7C00, 0x7C00))), uint4(0x7F800000, 0x7F800000, 0x7F800000, 0x7F800000));
            Assert.IsTrue(all(isnan(f16tof32(uint4(0x7C01, 0x7C01, 0x7C01, 0x7C01)))));

            Assert.AreEqual(asuint(f16tof32(uint4(0x8000, 0x8203, 0xC321, 0xFBFF))), uint4(0x80000000, 0xB800C000, 0xC0642000, 0xC77FE000));
            Assert.AreEqual(asuint(f16tof32(uint4(0xFC00, 0xFC00, 0xFC00, 0xFC00))), uint4(0xFF800000, 0xFF800000, 0xFF800000, 0xFF800000));
            Assert.IsTrue(all(isnan(f16tof32(uint4(0xFC01, 0xFC01, 0xFC01, 0xFC01)))));
        }

        [Test]
        public void f32tof16_float()
        {
            Assert.AreEqual(f32tof16(0.0f), 0x0000);
            Assert.AreEqual(f32tof16(2.98e-08f), 0x0000);
            Assert.AreEqual(f32tof16(5.96046448e-08f), 0x0001);
            Assert.AreEqual(f32tof16(123.4f), 0x57B6);
            Assert.AreEqual(f32tof16(65504.0f), 0x7BFF);
            Assert.AreEqual(f32tof16(65520.0f), 0x7C00);
            Assert.AreEqual(f32tof16(float.PositiveInfinity), 0x7C00);
            Assert.AreEqual(f32tof16(float.NaN), 0xFE00);

            Assert.AreEqual(f32tof16(-0.0f), 0x8000);
            Assert.AreEqual(f32tof16(-2.98e-08f), 0x8000);
            Assert.AreEqual(f32tof16(-5.96046448e-08f), 0x8001);
            Assert.AreEqual(f32tof16(-123.4f), 0xD7B6);
            Assert.AreEqual(f32tof16(-65504.0f), 0xFBFF);
            Assert.AreEqual(f32tof16(-65520.0f), 0xFC00);
            Assert.AreEqual(f32tof16(float.NegativeInfinity), 0xFC00);
        }

        [Test]
        public void f32tof16_float2()
        {
            Assert.AreEqual(f32tof16(float2(0.0f, 2.98e-08f)), uint2(0x0000, 0x0000));
            Assert.AreEqual(f32tof16(float2(5.96046448e-08f, 123.4f)), uint2(0x0001, 0x57B6));
            Assert.AreEqual(f32tof16(float2(65504.0f, 65520.0f)), uint2(0x7BFF, 0x7C00));
            Assert.AreEqual(f32tof16(float2(float.PositiveInfinity, float.NaN)), uint2(0x7C00, 0xFE00));

            Assert.AreEqual(f32tof16(float2(-0.0f, -2.98e-08f)), uint2(0x8000, 0x8000));
            Assert.AreEqual(f32tof16(float2(-5.96046448e-08f, -123.4f)), uint2(0x8001, 0xD7B6));
            Assert.AreEqual(f32tof16(float2(-65504.0f, -65520.0f)), uint2(0xFBFF, 0xFC00));
            Assert.AreEqual(f32tof16(float2(float.NegativeInfinity, float.NegativeInfinity)), uint2(0xFC00, 0xFC00));
        }

        [Test]
        public void f32tof16_float3()
        {
            Assert.AreEqual(f32tof16(float3(0.0f, 2.98e-08f, 5.96046448e-08f)), uint3(0x0000, 0x0000, 0x0001));
            Assert.AreEqual(f32tof16(float3(123.4f, 65504.0f, 65520.0f)), uint3(0x57B6, 0x7BFF, 0x7C00));
            Assert.AreEqual(f32tof16(float3(float.PositiveInfinity, float.NaN, -0.0f)), uint3(0x7C00, 0xFE00, 0x8000));

            Assert.AreEqual(f32tof16(float3(-2.98e-08f, -5.96046448e-08f, -123.4f)), uint3(0x8000, 0x8001, 0xD7B6));
            Assert.AreEqual(f32tof16(float3(-65504.0f, -65520.0f, float.NegativeInfinity)), uint3(0xFBFF, 0xFC00, 0xFC00));
        }

        [Test]
        public void f32tof16_float4()
        {
            Assert.AreEqual(f32tof16(float4(0.0f, 2.98e-08f, 5.96046448e-08f, 123.4f)), uint4(0x0000, 0x0000, 0x0001, 0x57B6));
            Assert.AreEqual(f32tof16(float4(65504.0f, 65520.0f, float.PositiveInfinity, float.NaN)), uint4(0x7BFF, 0x7C00, 0x7C00, 0xFE00));
            Assert.AreEqual(f32tof16(float4(-0.0f, -2.98e-08f, -5.96046448e-08f, -123.4f)), uint4(0x8000, 0x8000, 0x8001, 0xD7B6));
            Assert.AreEqual(f32tof16(float4(-65504.0f, -65520.0f, float.NegativeInfinity, float.NegativeInfinity)), uint4(0xFBFF, 0xFC00, 0xFC00, 0xFC00));
        }

        [Test]
        public unsafe void hash_blob()
        {
            byte[] testData = {
                0x0d, 0x26, 0x1c, 0xeb, 0x56, 0x3a, 0x9c, 0x18, 0x93, 0xb6,
                0xc1, 0x99, 0x5e, 0x04, 0x92, 0x4f, 0x6e, 0xb7, 0x42, 0x53,
                0x23, 0xcf, 0xe3, 0xbf, 0x16, 0x64, 0x79, 0x08, 0xc1, 0x01,
                0x43, 0x89, 0x73, 0x8f, 0x76, 0x22, 0x0c, 0xee, 0x9b, 0x80,
                0x31, 0x83, 0xce, 0x33, 0x8b, 0xc7, 0x3f, 0x94, 0x33
            };

            uint[] resultsWithZeroSeed =
            {
                0x02cc5d05, 0x376a5b3f, 0x8ae13198, 0xf5b14d72, 0xcc7ddc84,
                0x763e5905, 0x58759392, 0x6bccbd00, 0x7d0f80c8, 0xef01ae48,
                0xe40aa3ad, 0x805e04ad, 0xf98a471c, 0xdd960ac1, 0x76a71750,
                0xd35e2baa, 0x0219f7da, 0xd5bd1fbd, 0x5f28c87e, 0xfe6f7995,
                0x69a43ac5, 0xec1a1a15, 0x7ae9f103, 0x8d04a688, 0xce3b35be,
                0x6b3f040c, 0xd5ea2e8c, 0x6989e79c, 0x8772f1fb, 0x0d7b7bf6,
                0x0796214b, 0x98ea65c4, 0x3884dd82, 0x59632484, 0x91c92822,
                0x72d28404, 0x167061b0, 0x32adc2ef, 0xbac3e672, 0xd39936b7,
                0x94e2c154, 0x8b4ff46c, 0x68976fd4, 0x04bee59a, 0x2ed62c69,
                0xabee69fd, 0xda11e266, 0xcebd9d38, 0x28eea5fd, 0x0210d6ee
            };


            uint[] resultsWith_0xeb69cf40_seed =
            {
                0x12c3b280, 0x9bc1f68d, 0x2f900b51, 0xdb77e20e, 0xf6e8f561,
                0x3f3f72f6, 0x15f9700f, 0x28beb671, 0xceece5e1, 0x7a9b5c81,
                0x62a84642, 0xf75666af, 0x8939f8ca, 0x6b84792b, 0x527ee836,
                0xa0782090, 0xce6b9926, 0xa608c73b, 0xa08ee6a3, 0xab77a6b2,
                0x4e174e68, 0x596f10d5, 0xa14c4d85, 0x509ab88d, 0xd14698a4,
                0xbaad2308, 0xbd04c3df, 0x5715fed1, 0x5cf23a74, 0xd4e844f9,
                0x166dcfba, 0xe3495e37, 0x1b18b2b3, 0x2e8c2aab, 0x40993321,
                0x4b84998a, 0xd062937d, 0x1b2c9f7b, 0x8a613ed3, 0x70d71291,
                0x1af38ea4, 0x460cb7e9, 0xf806e3a9, 0xec9b6b2e, 0x9972a843,
                0x1ff06d2a, 0xe8c5007b, 0x37d8fc40, 0x0dc4f639, 0x36edff4f
            };
            fixed (byte* p = testData)
            {
                for (int i = 0; i < 50; ++i)
                {
                    Assert.AreEqual(resultsWithZeroSeed[i], hash(p, i, 0));
                }

                for (int i = 0; i < 50; ++i)
                {
                    Assert.AreEqual(resultsWith_0xeb69cf40_seed[i], hash(p, i, 0xeb69cf40));
                }
            }
        }
    }
}
