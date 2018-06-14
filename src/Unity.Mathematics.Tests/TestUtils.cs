using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.Tests
{
    class TestUtils
    {
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

        public static void AreEqual(float3x3 a, float3x3 b, float delta = 0.0f)
        {
            AreEqual(a.c0, b.c0, delta);
            AreEqual(a.c1, b.c1, delta);
            AreEqual(a.c2, b.c2, delta);
        }

        public static void AreEqual(float4x4 a, float4x4 b, float delta = 0.0f)
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
    }
}
