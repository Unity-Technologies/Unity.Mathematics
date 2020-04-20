using NUnit.Framework;
using static Unity.Mathematics.math;
using Unity.Mathematics.Geometry;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestAABB
    {
        [TestCompiler]
        public static void Min_trivial()
        {
            var aabb = new AABB();

            TestUtils.AreEqual(float3.zero, aabb.Min);
        }

        [TestCompiler]
        public static void Min()
        {
            var aabb = new AABB { Center = new float3(1.0f, -1.0f, 1.0f), Extents = new float3(0.5f) };

            TestUtils.AreEqual(new float3(0.5f, -1.5f, 0.5f), aabb.Min);
        }

        [TestCompiler]
        public static void Max_trivial()
        {
            var aabb = new AABB();

            TestUtils.AreEqual(float3.zero, aabb.Max);
        }

        [TestCompiler]
        public static void Max()
        {
            var aabb = new AABB { Center = new float3(1.0f, -1.0f, 1.0f), Extents = new float3(0.5f) };

            TestUtils.AreEqual(new float3(1.5f, -0.5f, 1.5f), aabb.Max);
        }

        [TestCompiler]
        public static void Size_trivial()
        {
            var aabb = new AABB();

            TestUtils.AreEqual(float3.zero, aabb.Size);
        }

        [TestCompiler]
        public static void Size()
        {
            var aabb = new AABB { Center = new float3(1.0f, -1.0f, 1.0f), Extents = new float3(0.5f) };

            TestUtils.AreEqual(new float3(1.0f), aabb.Size);
        }

        [TestCompiler]
        public static void Contains_float3()
        {
            AABB aabb = new AABB();

            TestUtils.IsTrue(aabb.Contains(float3.zero));
            TestUtils.IsFalse(aabb.Contains(new float3(FLT_MIN_NORMAL, 0.0f, 0.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(-FLT_MIN_NORMAL, 0.0f, 0.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(0.0f, FLT_MIN_NORMAL, 0.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(0.0f, -FLT_MIN_NORMAL, 0.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(0.0f, 0.0f, FLT_MIN_NORMAL)));
            TestUtils.IsFalse(aabb.Contains(new float3(0.0f, 0.0f, -FLT_MIN_NORMAL)));
        }

        [TestCompiler]
        public static void Contains_float3_nonzero_center()
        {
            var center = new float3(1.0f, -1.0f, 1.0f);
            AABB aabb = new AABB { Center = center };

            TestUtils.IsFalse(aabb.Contains(float3.zero));
            TestUtils.IsFalse(aabb.Contains(-center));
            TestUtils.IsTrue(aabb.Contains(center));
        }

        [TestCompiler]
        public static void Contains_float3_nonzero_extents()
        {
            var extents = new float3(0.5f, 0.5f, 0.5f);
            AABB aabb = new AABB { Extents = extents };

            TestUtils.IsTrue(aabb.Contains(float3.zero));
            TestUtils.IsTrue(aabb.Contains(new float3(0.5f, 0.0f, 0.0f)));
            TestUtils.IsTrue(aabb.Contains(new float3(-0.5f, 0.0f, 0.0f)));
            TestUtils.IsTrue(aabb.Contains(new float3(0.0f, 0.5f, 0.0f)));
            TestUtils.IsTrue(aabb.Contains(new float3(0.0f, -0.5f, 0.0f)));
            TestUtils.IsTrue(aabb.Contains(new float3(0.0f, 0.0f, 0.5f)));
            TestUtils.IsTrue(aabb.Contains(new float3(0.0f, 0.0f, -0.5f)));

            TestUtils.IsFalse(aabb.Contains(new float3(0.6f, 0.0f, 0.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(-0.6f, 0.0f, 0.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(0.0f, 0.6f, 0.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(0.0f, -0.6f, 0.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(0.0f, 0.0f, 0.6f)));
            TestUtils.IsFalse(aabb.Contains(new float3(0.0f, 0.0f, -0.6f)));
        }

        [TestCompiler]
        public static void Contains_AABB_trivial()
        {
            var aabb1 = new AABB();
            var aabb2 = new AABB();

            TestUtils.IsTrue(aabb1.Contains(aabb2));
            TestUtils.IsTrue(aabb2.Contains(aabb1));
        }

        [TestCompiler]
        public static void Contains_AABB()
        {
            var aabb_outer = new AABB { Extents = new float3(0.5f, 0.5f, 0.5f) };
            var aabb_inner = new AABB();

            TestUtils.IsTrue(aabb_outer.Contains(aabb_inner));
            TestUtils.IsFalse(aabb_inner.Contains(aabb_outer));
        }

        [TestCompiler]
        public static void Contains_AABB_partial_overlap()
        {
            var aabb1 = new AABB { Extents = new float3(0.5f, 0.5f, 0.5f) };
            var aabb2 = new AABB { Center = new float3(0.5f, 0.5f, 0.5f), Extents = new float3(0.5f)};

            TestUtils.IsFalse(aabb1.Contains(aabb2));
            TestUtils.IsFalse(aabb2.Contains(aabb1));
        }

        [TestCompiler]
        public static void DistanceSq_trivial()
        {
            var aabb = new AABB();

            TestUtils.AreEqual(0.0f, aabb.DistanceSq(float3.zero));
        }

        [TestCompiler]
        public static void DistanceSq_point_inside()
        {
            var center = new float3(1.0f);
            var aabb = new AABB { Center = center, Extents = new float3(0.5f) };

            TestUtils.AreEqual(0.0f, aabb.DistanceSq(center), 0.0f);
            TestUtils.AreEqual(0.0f, aabb.DistanceSq(center + new float3(0.5f)));
                TestUtils.AreEqual(0.0f, aabb.DistanceSq(center + new float3(-0.5f)));
        }

        [TestCompiler]
        public static void DistanceSq_point_outside()
        {
            var center = new float3(1.0f);
            var aabb = new AABB { Center = center, Extents = new float3(0.5f) };

            TestUtils.AreEqual(0.25f, aabb.DistanceSq(center + new float3(1.0f, 0.0f, 0.0f)));
            TestUtils.AreEqual(0.25f, aabb.DistanceSq(center + new float3(-1.0f, 0.0f, 0.0f)));
            TestUtils.AreEqual(0.25f, aabb.DistanceSq(center + new float3(0.0f, 1.0f, 0.0f)));
            TestUtils.AreEqual(0.25f, aabb.DistanceSq(center + new float3(0.0f, -1.0f, 0.0f)));
            TestUtils.AreEqual(0.25f, aabb.DistanceSq(center + new float3(0.0f, 0.0f, 1.0f)));
            TestUtils.AreEqual(0.25f, aabb.DistanceSq(center + new float3(0.0f, 0.0f, -1.0f)));
        }

        [TestCompiler]
        public static void DistanceSq_point_outside_corner()
        {
            var center = new float3(1.0f);
            var aabb = new AABB { Center = center, Extents = new float3(0.5f) };

            TestUtils.AreEqual(0.75f, aabb.DistanceSq(center + new float3(1.0f)));
        }

        [TestCompiler]
        public static void Transform_trivial()
        {
            var localAabb = new AABB();
            var transform = float4x4.identity;
            var transformedAabb = AABB.Transform(transform, localAabb);

            TestUtils.AreEqual(float3.zero, transformedAabb.Center);
            TestUtils.AreEqual(float3.zero, transformedAabb.Extents);
        }

        [TestCompiler]
        public static void Transform_translation()
        {
            var localAabb = new AABB { Center = float3.zero, Extents = new float3(1.0f) };
            var transform = float4x4.Translate(new float3(1.0f));
            var transformedAabb = AABB.Transform(transform, localAabb);

            TestUtils.AreEqual(new float3(1.0f), transformedAabb.Center);
            TestUtils.AreEqual(localAabb.Extents, transformedAabb.Extents);
        }

        [TestCompiler]
        public static void Transform_rotation()
        {
            var localAabb = new AABB { Center = float3.zero, Extents = new float3(1.0f) };
            var transform = float4x4.EulerZXY(new float3(PI * 0.25f));
            var transformedAabb = AABB.Transform(transform, localAabb);

            TestUtils.AreEqual(float3.zero, transformedAabb.Center);
            TestUtils.AreEqual(new float3( 1.5f, 1.70710678118f, 1.5f), transformedAabb.Extents, 0.0001f);
        }

        [TestCompiler]
        public static void Transform_translation_rotation()
        {
            var localAabb = new AABB { Center = float3.zero, Extents = new float3(1.0f) };
            var transform = float4x4.TRS(new float3(1.0f), quaternion.EulerZXY(new float3(PI * 0.25f)), new float3(1.0f));
            var transformedAabb = AABB.Transform(transform, localAabb);

            TestUtils.AreEqual(new float3(1.0f), transformedAabb.Center);
            TestUtils.AreEqual(new float3( 1.5f, 1.70710678118f, 1.5f), transformedAabb.Extents, 0.0001f);
        }
    }
}
