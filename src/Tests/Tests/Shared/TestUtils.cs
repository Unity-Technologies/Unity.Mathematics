using NUnit.Framework;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.Tests
{
    class TestUtils
    {

        public static void AreEqual(bool expected, bool actual)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void AreEqual(int expected, int actual)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void AreEqual(uint expected, uint actual)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void AreEqual(long expected, long actual)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void AreEqual(ulong expected, ulong actual)
        {
            Assert.AreEqual(expected, actual);
        }

        public static void AreEqual(float expected, float actual, float delta = 0.0f)
        {
            Assert.AreEqual(expected, actual, delta);
        }

        public static void AreEqual(float expected, float actual, int maxUlp, bool signedZeroEqual)
        {
            if (signedZeroEqual && expected == actual)
                return;

            if(isfinite(expected) && isfinite(actual))
            {
                int ia = asint(expected);
                int ib = asint(actual);
                if ((ia ^ ib) < 0)
                    Assert.AreEqual(true, false);
                int ulps = abs(ia - ib);
                Assert.AreEqual(true, ulps <= maxUlp);
            }
            else
            {
                if (expected != actual && (!isnan(expected) || !isnan(actual)))
                    Assert.AreEqual(true, false);
            }
        }

        public static void AreEqual(double expected, double actual, double delta = 0.0)
        {
            Assert.AreEqual(expected, actual, delta);
        }

        public static void AreEqual(double expected, double actual, int maxUlp, bool signedZeroEqual)
        {
            if (signedZeroEqual && expected == actual)
                return;

            if (isfinite(expected) && isfinite(actual))
            {
                long la = aslong(expected);
                long lb = aslong(actual);
                if ((la ^ lb) < 0)
                    Assert.AreEqual(true, false);
                long ulps = abs(la - lb);
                Assert.AreEqual(true, ulps <= maxUlp);
            }
            else
            {
                if (expected != actual && (!isnan(expected) || !isnan(actual)))
                    Assert.AreEqual(true, false);
            }
        }


        // bool
        public static void AreEqual(bool2 expected, bool2 actual)
        {
            AreEqual(expected.x, actual.x);
            AreEqual(expected.y, actual.y);
        }

        public static void AreEqual(bool3 expected, bool3 actual)
        {
            AreEqual(expected.x, actual.x);
            AreEqual(expected.y, actual.y);
            AreEqual(expected.z, actual.z);
        }

        public static void AreEqual(bool4 expected, bool4 actual)
        {
            AreEqual(expected.x, actual.x);
            AreEqual(expected.y, actual.y);
            AreEqual(expected.z, actual.z);
            AreEqual(expected.w, actual.w);
        }


        public static void AreEqual(bool2x2 expected, bool2x2 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
        }

        public static void AreEqual(bool3x2 expected, bool3x2 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
        }

        public static void AreEqual(bool4x2 expected, bool4x2 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
        }


        public static void AreEqual(bool2x3 expected, bool2x3 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
        }

        public static void AreEqual(bool3x3 expected, bool3x3 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
        }

        public static void AreEqual(bool4x3 expected, bool4x3 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
        }


        public static void AreEqual(bool2x4 expected, bool2x4 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
            AreEqual(expected.c3, actual.c3);
        }

        public static void AreEqual(bool3x4 expected, bool3x4 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
            AreEqual(expected.c3, actual.c3);
        }

        public static void AreEqual(bool4x4 expected, bool4x4 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
            AreEqual(expected.c3, actual.c3);
        }

        // int
        public static void AreEqual(int2 expected, int2 actual)
        {
            AreEqual(expected.x, actual.x);
            AreEqual(expected.y, actual.y);
        }

        public static void AreEqual(int3 expected, int3 actual)
        {
            AreEqual(expected.x, actual.x);
            AreEqual(expected.y, actual.y);
            AreEqual(expected.z, actual.z);
        }

        public static void AreEqual(int4 expected, int4 actual)
        {
            AreEqual(expected.x, actual.x);
            AreEqual(expected.y, actual.y);
            AreEqual(expected.z, actual.z);
            AreEqual(expected.w, actual.w);
        }


        public static void AreEqual(int2x2 expected, int2x2 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
        }

        public static void AreEqual(int3x2 expected, int3x2 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
        }

        public static void AreEqual(int4x2 expected, int4x2 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
        }


        public static void AreEqual(int2x3 expected, int2x3 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
        }

        public static void AreEqual(int3x3 expected, int3x3 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
        }

        public static void AreEqual(int4x3 expected, int4x3 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
        }



        public static void AreEqual(int2x4 expected, int2x4 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
            AreEqual(expected.c3, actual.c3);
        }

        public static void AreEqual(int3x4 expected, int3x4 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
            AreEqual(expected.c3, actual.c3);
        }

        public static void AreEqual(int4x4 expected, int4x4 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
            AreEqual(expected.c3, actual.c3);
        }


        // uint
        public static void AreEqual(uint2 expected, uint2 actual)
        {
            AreEqual(expected.x, actual.x);
            AreEqual(expected.y, actual.y);
        }

        public static void AreEqual(uint3 expected, uint3 actual)
        {
            AreEqual(expected.x, actual.x);
            AreEqual(expected.y, actual.y);
            AreEqual(expected.z, actual.z);
        }

        public static void AreEqual(uint4 expected, uint4 actual)
        {
            AreEqual(expected.x, actual.x);
            AreEqual(expected.y, actual.y);
            AreEqual(expected.z, actual.z);
            AreEqual(expected.w, actual.w);
        }


        public static void AreEqual(uint2x2 expected, uint2x2 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
        }

        public static void AreEqual(uint3x2 expected, uint3x2 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
        }

        public static void AreEqual(uint4x2 expected, uint4x2 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
        }


        public static void AreEqual(uint2x3 expected, uint2x3 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
        }

        public static void AreEqual(uint3x3 expected, uint3x3 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
        }

        public static void AreEqual(uint4x3 expected, uint4x3 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
        }


        public static void AreEqual(uint2x4 expected, uint2x4 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
            AreEqual(expected.c3, actual.c3);
        }

        public static void AreEqual(uint3x4 expected, uint3x4 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
            AreEqual(expected.c3, actual.c3);
        }

        public static void AreEqual(uint4x4 expected, uint4x4 actual)
        {
            AreEqual(expected.c0, actual.c0);
            AreEqual(expected.c1, actual.c1);
            AreEqual(expected.c2, actual.c2);
            AreEqual(expected.c3, actual.c3);
        }

        // float
        public static void AreEqual(float2 expected, float2 actual, float delta = 0.0f)
        {
            AreEqual(expected.x, actual.x, delta);
            AreEqual(expected.y, actual.y, delta);
        }

        public static void AreEqual(float2 expected, float2 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.x, actual.x, maxUlp, signedZeroEqual);
            AreEqual(expected.y, actual.y, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(float3 expected, float3 actual, float delta = 0.0f)
        {
            AreEqual(expected.x, actual.x, delta);
            AreEqual(expected.y, actual.y, delta);
            AreEqual(expected.z, actual.z, delta);
        }

        public static void AreEqual(float3 expected, float3 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.x, actual.x, maxUlp, signedZeroEqual);
            AreEqual(expected.y, actual.y, maxUlp, signedZeroEqual);
            AreEqual(expected.z, actual.z, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(float4 expected, float4 actual, float delta = 0.0f)
        {
            AreEqual(expected.x, actual.x, delta);
            AreEqual(expected.y, actual.y, delta);
            AreEqual(expected.z, actual.z, delta);
            AreEqual(expected.w, actual.w, delta);
        }

        public static void AreEqual(float4 expected, float4 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.x, actual.x, maxUlp, signedZeroEqual);
            AreEqual(expected.y, actual.y, maxUlp, signedZeroEqual);
            AreEqual(expected.z, actual.z, maxUlp, signedZeroEqual);
            AreEqual(expected.w, actual.w, maxUlp, signedZeroEqual);
        }


        public static void AreEqual(float2x2 expected, float2x2 actual, float delta = 0.0f)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
        }

        public static void AreEqual(float2x2 expected, float2x2 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(float3x2 expected, float3x2 actual, float delta = 0.0f)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
        }

        public static void AreEqual(float3x2 expected, float3x2 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(float4x2 expected, float4x2 actual, float delta = 0.0f)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
        }

        public static void AreEqual(float4x2 expected, float4x2 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
        }


        public static void AreEqual(float2x3 expected, float2x3 actual, float delta = 0.0f)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
        }

        public static void AreEqual(float2x3 expected, float2x3 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(float3x3 expected, float3x3 actual, float delta = 0.0f)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
        }

        public static void AreEqual(float3x3 expected, float3x3 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(float4x3 expected, float4x3 actual, float delta = 0.0f)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
        }

        public static void AreEqual(float4x3 expected, float4x3 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
        }


        public static void AreEqual(float2x4 expected, float2x4 actual, float delta = 0.0f)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
            AreEqual(expected.c3, actual.c3, delta);
        }

        public static void AreEqual(float2x4 expected, float2x4 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
            AreEqual(expected.c3, actual.c3, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(float3x4 expected, float3x4 actual, float delta = 0.0f)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
            AreEqual(expected.c3, actual.c3, delta);
        }

        public static void AreEqual(float3x4 expected, float3x4 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
            AreEqual(expected.c3, actual.c3, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(float4x4 expected, float4x4 actual, float delta = 0.0f)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
            AreEqual(expected.c3, actual.c3, delta);
        }

        public static void AreEqual(float4x4 expected, float4x4 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
            AreEqual(expected.c3, actual.c3, maxUlp, signedZeroEqual);
        }

        // double
        public static void AreEqual(double2 expected, double2 actual, double delta = 0.0)
        {
            AreEqual(expected.x, actual.x, delta);
            AreEqual(expected.y, actual.y, delta);
        }

        public static void AreEqual(double2 expected, double2 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.x, actual.x, maxUlp, signedZeroEqual);
            AreEqual(expected.y, actual.y, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(double3 expected, double3 actual, double delta = 0.0)
        {
            AreEqual(expected.x, actual.x, delta);
            AreEqual(expected.y, actual.y, delta);
            AreEqual(expected.z, actual.z, delta);
        }

        public static void AreEqual(double3 expected, double3 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.x, actual.x, maxUlp, signedZeroEqual);
            AreEqual(expected.y, actual.y, maxUlp, signedZeroEqual);
            AreEqual(expected.z, actual.z, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(double4 expected, double4 actual, double delta = 0.0)
        {
            AreEqual(expected.x, actual.x, delta);
            AreEqual(expected.y, actual.y, delta);
            AreEqual(expected.z, actual.z, delta);
            AreEqual(expected.w, actual.w, delta);
        }

        public static void AreEqual(double4 expected, double4 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.x, actual.x, maxUlp, signedZeroEqual);
            AreEqual(expected.y, actual.y, maxUlp, signedZeroEqual);
            AreEqual(expected.z, actual.z, maxUlp, signedZeroEqual);
            AreEqual(expected.w, actual.w, maxUlp, signedZeroEqual);
        }


        public static void AreEqual(double2x2 expected, double2x2 actual, double delta = 0.0)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
        }

        public static void AreEqual(double2x2 expected, double2x2 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(double3x2 expected, double3x2 actual, double delta = 0.0)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
        }

        public static void AreEqual(double3x2 expected, double3x2 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(double4x2 expected, double4x2 actual, double delta = 0.0)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
        }

        public static void AreEqual(double4x2 expected, double4x2 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(double2x3 expected, double2x3 actual, double delta = 0.0)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
        }

        public static void AreEqual(double2x3 expected, double2x3 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(double3x3 expected, double3x3 actual, double delta = 0.0)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
        }

        public static void AreEqual(double3x3 expected, double3x3 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(double4x3 expected, double4x3 actual, double delta = 0.0)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
        }

        public static void AreEqual(double4x3 expected, double4x3 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
        }


        public static void AreEqual(double2x4 expected, double2x4 actual, double delta = 0.0)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
            AreEqual(expected.c3, actual.c3, delta);
        }

        public static void AreEqual(double2x4 expected, double2x4 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
            AreEqual(expected.c3, actual.c3, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(double3x4 expected, double3x4 actual, double delta = 0.0)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
            AreEqual(expected.c3, actual.c3, delta);
        }

        public static void AreEqual(double3x4 expected, double3x4 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
            AreEqual(expected.c3, actual.c3, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(double4x4 expected, double4x4 actual, double delta = 0.0)
        {
            AreEqual(expected.c0, actual.c0, delta);
            AreEqual(expected.c1, actual.c1, delta);
            AreEqual(expected.c2, actual.c2, delta);
            AreEqual(expected.c3, actual.c3, delta);
        }

        public static void AreEqual(double4x4 expected, double4x4 actual, int maxUlp, bool signedZeroEqual)
        {
            AreEqual(expected.c0, actual.c0, maxUlp, signedZeroEqual);
            AreEqual(expected.c1, actual.c1, maxUlp, signedZeroEqual);
            AreEqual(expected.c2, actual.c2, maxUlp, signedZeroEqual);
            AreEqual(expected.c3, actual.c3, maxUlp, signedZeroEqual);
        }

        public static void AreEqual(quaternion expected, quaternion actual, float delta = 0.0f)
        {
            AreEqual(expected.value, actual.value, delta);
        }

        public static void AreEqual(RigidTransform expected, RigidTransform actual, float delta = 0.0f)
        {
            AreEqual(expected.rot, actual.rot, delta);
            AreEqual(expected.pos, actual.pos, delta);
        }

        public static void IsTrue(bool condition)
        {
            AreEqual(true, condition);
        }

        public static void IsFalse(bool condition)
        {
            AreEqual(false, condition);
        }

        public static float UnsignedFloatQNaN()
        {
            return asfloat(0x7fc0_0000u);
        }

        public static double UnsignedDoubleQNaN()
        {
            return asdouble(0x7ff8_0000_0000_0000ul);
        }

        public static float SignedFloatQNaN()
        {
            return asfloat(0xffc0_0000u);
        }

        public static double SignedDoubleQNaN()
        {
            return asdouble(0xfff8_0000_0000_0000ul);
        }

        public static float SignedFloatZero()
        {
            return asfloat(0x8000_0000u);
        }

        public static double SignedDoubleZero()
        {
            return asdouble(0x8000_0000_0000_0000ul);
        }
    }
}
