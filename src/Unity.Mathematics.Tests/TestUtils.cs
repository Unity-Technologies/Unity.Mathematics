using NUnit.Framework;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.Tests
{
    class TestUtils
    {
        // bool
        public static void AreEqual(bool a, bool b)
        {
            Assert.AreEqual(a, b);
        }

        public static void AreEqual(bool2 a, bool2 b)
        {
            Assert.AreEqual(a.x, b.x);
            Assert.AreEqual(a.y, b.y);
        }

        public static void AreEqual(bool3 a, bool3 b)
        {
            Assert.AreEqual(a.x, b.x);
            Assert.AreEqual(a.y, b.y);
            Assert.AreEqual(a.z, b.z);
        }

        public static void AreEqual(bool4 a, bool4 b)
        {
            Assert.AreEqual(a.x, b.x);
            Assert.AreEqual(a.y, b.y);
            Assert.AreEqual(a.z, b.z);
            Assert.AreEqual(a.w, b.w);
        }


        public static void AreEqual(bool2x2 a, bool2x2 b)
        {
            Assert.AreEqual(a.c0, b.c0);
            Assert.AreEqual(a.c1, b.c1);
        }

        public static void AreEqual(bool3x2 a, bool3x2 b)
        {
            Assert.AreEqual(a.c0, b.c0);
            Assert.AreEqual(a.c1, b.c1);
        }

        public static void AreEqual(bool4x2 a, bool4x2 b)
        {
            Assert.AreEqual(a.c0, b.c0);
            Assert.AreEqual(a.c1, b.c1);
        }


        public static void AreEqual(bool2x3 a, bool2x3 b)
        {
            Assert.AreEqual(a.c0, b.c0);
            Assert.AreEqual(a.c1, b.c1);
            Assert.AreEqual(a.c2, b.c2);
        }

        public static void AreEqual(bool3x3 a, bool3x3 b)
        {
            Assert.AreEqual(a.c0, b.c0);
            Assert.AreEqual(a.c1, b.c1);
            Assert.AreEqual(a.c2, b.c2);
        }

        public static void AreEqual(bool4x3 a, bool4x3 b)
        {
            Assert.AreEqual(a.c0, b.c0);
            Assert.AreEqual(a.c1, b.c1);
            Assert.AreEqual(a.c2, b.c2);
        }


        public static void AreEqual(bool2x4 a, bool2x4 b)
        {
            Assert.AreEqual(a.c0, b.c0);
            Assert.AreEqual(a.c1, b.c1);
            Assert.AreEqual(a.c2, b.c2);
            Assert.AreEqual(a.c3, b.c3);
        }

        public static void AreEqual(bool3x4 a, bool3x4 b)
        {
            Assert.AreEqual(a.c0, b.c0);
            Assert.AreEqual(a.c1, b.c1);
            Assert.AreEqual(a.c2, b.c2);
            Assert.AreEqual(a.c3, b.c3);
        }

        public static void AreEqual(bool4x4 a, bool4x4 b)
        {
            Assert.AreEqual(a.c0, b.c0);
            Assert.AreEqual(a.c1, b.c1);
            Assert.AreEqual(a.c2, b.c2);
            Assert.AreEqual(a.c3, b.c3);
        }

        // int
        public static void AreEqual(int a, int b)
        {
            Assert.AreEqual(a, b);
        }

        public static void AreEqual(int2 a, int2 b)
        {
            Assert.AreEqual(a.x, b.x);
            Assert.AreEqual(a.y, b.y);
        }

        public static void AreEqual(int3 a, int3 b)
        {
            Assert.AreEqual(a.x, b.x);
            Assert.AreEqual(a.y, b.y);
            Assert.AreEqual(a.z, b.z);
        }

        public static void AreEqual(int4 a, int4 b)
        {
            Assert.AreEqual(a.x, b.x);
            Assert.AreEqual(a.y, b.y);
            Assert.AreEqual(a.z, b.z);
            Assert.AreEqual(a.w, b.w);
        }


        public static void AreEqual(int2x2 a, int2x2 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
        }

        public static void AreEqual(int3x2 a, int3x2 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
        }

        public static void AreEqual(int4x2 a, int4x2 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
        }


        public static void AreEqual(int2x3 a, int2x3 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
        }

        public static void AreEqual(int3x3 a, int3x3 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
        }

        public static void AreEqual(int4x3 a, int4x3 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
        }



        public static void AreEqual(int2x4 a, int2x4 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
            AreEqual(a.c3, b.c3);
        }

        public static void AreEqual(int3x4 a, int3x4 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
            AreEqual(a.c3, b.c3);
        }

        public static void AreEqual(int4x4 a, int4x4 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
            AreEqual(a.c3, b.c3);
        }


        // uint
        public static void AreEqual(uint a, uint b)
        {
            Assert.AreEqual(a, b);
        }

        public static void AreEqual(uint2 a, uint2 b)
        {
            Assert.AreEqual(a.x, b.x);
            Assert.AreEqual(a.y, b.y);
        }

        public static void AreEqual(uint3 a, uint3 b)
        {
            Assert.AreEqual(a.x, b.x);
            Assert.AreEqual(a.y, b.y);
            Assert.AreEqual(a.z, b.z);
        }

        public static void AreEqual(uint4 a, uint4 b)
        {
            Assert.AreEqual(a.x, b.x);
            Assert.AreEqual(a.y, b.y);
            Assert.AreEqual(a.z, b.z);
            Assert.AreEqual(a.w, b.w);
        }


        public static void AreEqual(uint2x2 a, uint2x2 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
        }

        public static void AreEqual(uint3x2 a, uint3x2 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
        }

        public static void AreEqual(uint4x2 a, uint4x2 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
        }


        public static void AreEqual(uint2x3 a, uint2x3 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
        }

        public static void AreEqual(uint3x3 a, uint3x3 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
        }

        public static void AreEqual(uint4x3 a, uint4x3 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
        }


        public static void AreEqual(uint2x4 a, uint2x4 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
            AreEqual(a.c3, b.c3);
        }

        public static void AreEqual(uint3x4 a, uint3x4 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
            AreEqual(a.c3, b.c3);
        }

        public static void AreEqual(uint4x4 a, uint4x4 b)
        {
            AreEqual(a.c0, b.c0);
            AreEqual(a.c1, b.c1);
            AreEqual(a.c2, b.c2);
            AreEqual(a.c3, b.c3);
        }

        // float
        public static void AreEqual(float a, float b, float delta = 0.0f)
        {
            Assert.AreEqual(a, b, delta);
        }

        public static void AreEqual(float2 a, float2 b, float delta = 0.0f)
        {
            Assert.AreEqual(a.x, b.x, delta);
            Assert.AreEqual(a.y, b.y, delta);
        }

        public static void AreEqual(float3 a, float3 b, float delta = 0.0f)
        {
            Assert.AreEqual(a.x, b.x, delta);
            Assert.AreEqual(a.y, b.y, delta);
            Assert.AreEqual(a.z, b.z, delta);
        }

        public static void AreEqual(float4 a, float4 b, float delta = 0.0f)
        {
            Assert.AreEqual(a.x, b.x, delta);
            Assert.AreEqual(a.y, b.y, delta);
            Assert.AreEqual(a.z, b.z, delta);
            Assert.AreEqual(a.w, b.w, delta);
        }


        public static void AreEqual(float2x2 a, float2x2 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
        }

        public static void AreEqual(float3x2 a, float3x2 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
        }

        public static void AreEqual(float4x2 a, float4x2 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
        }


        public static void AreEqual(float2x3 a, float2x3 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }

        public static void AreEqual(float3x3 a, float3x3 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }

        public static void AreEqual(float4x3 a, float4x3 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }


        public static void AreEqual(float2x4 a, float2x4 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
            AreEqual(a.c3, b.c3, delta);
        }

        public static void AreEqual(float3x4 a, float3x4 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
            AreEqual(a.c3, b.c3, delta);
        }

        public static void AreEqual(float4x4 a, float4x4 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
            AreEqual(a.c3, b.c3, delta);
        }

        // double
        public static void AreEqual(double a, double b, double delta = 0.0)
        {
            Assert.AreEqual(a, b, delta);
        }

        public static void AreEqual(double2 a, double2 b, double delta = 0.0)
        {
            Assert.AreEqual(a.x, b.x, delta);
            Assert.AreEqual(a.y, b.y, delta);
        }

        public static void AreEqual(double3 a, double3 b, double delta = 0.0)
        {
            Assert.AreEqual(a.x, b.x, delta);
            Assert.AreEqual(a.y, b.y, delta);
            Assert.AreEqual(a.z, b.z, delta);
        }

        public static void AreEqual(double4 a, double4 b, double delta = 0.0)
        {
            Assert.AreEqual(a.x, b.x, delta);
            Assert.AreEqual(a.y, b.y, delta);
            Assert.AreEqual(a.z, b.z, delta);
            Assert.AreEqual(a.w, b.w, delta);
        }


        public static void AreEqual(double2x2 a, double2x2 b, double delta = 0.0)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
        }

        public static void AreEqual(double3x2 a, double3x2 b, double delta = 0.0)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
        }

        public static void AreEqual(double4x2 a, double4x2 b, double delta = 0.0)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
        }


        public static void AreEqual(double2x3 a, double2x3 b, double delta = 0.0)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }

        public static void AreEqual(double3x3 a, double3x3 b, double delta = 0.0)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }

        public static void AreEqual(double4x3 a, double4x3 b, double delta = 0.0)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }


        public static void AreEqual(double2x4 a, double2x4 b, double delta = 0.0)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
            AreEqual(a.c3, b.c3, delta);
        }

        public static void AreEqual(double3x4 a, double3x4 b, double delta = 0.0)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
            AreEqual(a.c3, b.c3, delta);
        }

        public static void AreEqual(double4x4 a, double4x4 b, double delta = 0.0)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
            AreEqual(a.c3, b.c3, delta);
        }
        public static void AreEqual(quaternion a, quaternion b, float delta = 0.0f)
        {
            AreEqual(a.value, b.value, delta);
        }

        public static void AreEqual(RigidTransform a, RigidTransform b, float delta = 0.0f)
        {
            AreEqual(a.rot, b.rot, delta);
            AreEqual(a.pos, b.pos, delta);
        }
    }
}
