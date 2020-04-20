using System;
using NUnit.Framework;
using static Unity.Mathematics.math;
using Unity.Mathematics.Geometry;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestMinMaxAABB
    {
        [TestCompiler]
        public static void IsEmpty_trivial()
        {
            var aabb = new MinMaxAABB();
            TestUtils.IsFalse(aabb.IsEmpty);
        }

        [TestCompiler]
        public static void IsEmpty_empty()
        {
            var aabb = MinMaxAABB.Empty;
            TestUtils.IsTrue(aabb.IsEmpty);

            aabb.Min = new float3(1.0f);
            aabb.Max = new float3(-1.0f);
            TestUtils.IsFalse(aabb.IsEmpty);
        }

        [TestCompiler]
        public static void IsEmpty_min_gt_max()
        {
            var aabb = new MinMaxAABB { Min = new float3(1.0f), Max = new float3(-1.0f) };
            TestUtils.IsFalse(aabb.IsEmpty);
        }

        [TestCompiler]
        public static void Encapsulate_float3_trivial()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(float3.zero);
            TestUtils.AreEqual(float3.zero, aabb.Min);
            TestUtils.AreEqual(float3.zero, aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_float3_new_max()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new float3(1.0f));
            TestUtils.AreEqual(float3.zero, aabb.Min);
            TestUtils.AreEqual(new float3(1.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_float3_new_min()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new float3(-1.0f));
            TestUtils.AreEqual(float3.zero, aabb.Max);
            TestUtils.AreEqual(new float3(-1.0f), aabb.Min);
        }

        [TestCompiler]
        public static void Encapsulate_float3_new_minx_maxyz()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new float3(-1.0f, 1.0f, 1.0f));
            TestUtils.AreEqual(new float3(-1.0f, 0.0f, 0.0f), aabb.Min);
            TestUtils.AreEqual(new float3(0.0f, 1.0f, 1.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_float3_new_minxy_maxz()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new float3(-1.0f, -1.0f, 1.0f));
            TestUtils.AreEqual(new float3(-1.0f, -1.0f, 0.0f), aabb.Min);
            TestUtils.AreEqual(new float3(0.0f, 0.0f, 1.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_float3_new_minxz_maxy()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new float3(-1.0f, 1.0f, -1.0f));
            TestUtils.AreEqual(new float3(-1.0f, 0.0f, -1.0f), aabb.Min);
            TestUtils.AreEqual(new float3(0.0f, 1.0f, 0.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_float3_new_minz_maxxy()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new float3(1.0f, 1.0f, -1.0f));
            TestUtils.AreEqual(new float3(0.0f, 0.0f, -1.0f), aabb.Min);
            TestUtils.AreEqual(new float3(1.0f, 1.0f, 0.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_float3_new_miny_maxxz()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new float3(1.0f, -1.0f, 1.0f));
            TestUtils.AreEqual(new float3(0.0f, -1.0f, 0.0f), aabb.Min);
            TestUtils.AreEqual(new float3(1.0f, 0.0f, 1.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_MinMaxAABB_trivial()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new MinMaxAABB());
            TestUtils.AreEqual(float3.zero, aabb.Min);
            TestUtils.AreEqual(float3.zero, aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_MinMaxAABB_new_max()
        {
            var aabb = new MinMaxAABB();
            var p = new float3(1.0f);
            aabb.Encapsulate(new MinMaxAABB { Max = p });
            TestUtils.AreEqual(float3.zero, aabb.Min);
            TestUtils.AreEqual(p, aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_MinMaxAABB_new_min()
        {
            var aabb = new MinMaxAABB();
            var p = new float3(-1.0f);
            aabb.Encapsulate(new MinMaxAABB { Min = p });
            TestUtils.AreEqual(float3.zero, aabb.Max);
            TestUtils.AreEqual(p, aabb.Min);
        }

        [TestCompiler]
        public static void Encapsulate_MinMaxAABB_new_minx_maxyz()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new MinMaxAABB { Min = new float3(-1.0f, 0.0f, 0.0f), Max = new float3(0.0f, 1.0f, 1.0f) });
            TestUtils.AreEqual(new float3(-1.0f, 0.0f, 0.0f), aabb.Min);
            TestUtils.AreEqual(new float3(0.0f, 1.0f, 1.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_MinMaxAABB_new_minxy_maxz()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new MinMaxAABB { Min = new float3(-1.0f, -1.0f, 0.0f), Max = new float3(0.0f, 0.0f, 1.0f) });
            TestUtils.AreEqual(new float3(-1.0f, -1.0f, 0.0f), aabb.Min);
            TestUtils.AreEqual(new float3(0.0f, 0.0f, 1.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_MinMaxAABB_new_minxz_maxy()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new MinMaxAABB { Min = new float3(-1.0f, 0.0f, -1.0f), Max = new float3(0.0f, 1.0f, 0.0f) });
            TestUtils.AreEqual(new float3(-1.0f, 0.0f, -1.0f), aabb.Min);
            TestUtils.AreEqual(new float3(0.0f, 1.0f, 0.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_MinMaxAABB_new_minz_maxxy()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new MinMaxAABB { Min = new float3(0.0f, 0.0f, -1.0f), Max = new float3(1.0f, 1.0f, 0.0f) });
            TestUtils.AreEqual(new float3(0.0f, 0.0f, -1.0f), aabb.Min);
            TestUtils.AreEqual(new float3(1.0f, 1.0f, 0.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Encapsulate_MinMaxAABB_new_miny_maxxz()
        {
            var aabb = new MinMaxAABB();
            aabb.Encapsulate(new MinMaxAABB { Min = new float3(0.0f, -1.0f, 0.0f), Max = new float3(1.0f, 0.0f, 1.0f) });
            TestUtils.AreEqual(new float3(0.0f, -1.0f, 0.0f), aabb.Min);
            TestUtils.AreEqual(new float3(1.0f, 0.0f, 1.0f), aabb.Max);
        }

        [TestCompiler]
        public static void Convert_MinMaxAABB_to_AABB()
        {
            var minmax = new MinMaxAABB { Min = new float3(1.0f), Max = new float3(2.0f) };
            AABB aabb = minmax;
            TestUtils.AreEqual(new float3(1.5f), aabb.Center);
            TestUtils.AreEqual(new float3(0.5f), aabb.Extents);
        }

        [TestCompiler]
        public static void Convert_AABB_to_MinMaxAABB()
        {
            AABB aabb = new AABB { Center = new float3(1.5f), Extents = new float3(0.5f) };
            MinMaxAABB minmax = aabb;
            TestUtils.AreEqual(new float3(1.0f), minmax.Min);
            TestUtils.AreEqual(new float3(2.0f), minmax.Max);
        }

        [TestCompiler]
        public static void Equals_trivial()
        {
            MinMaxAABB aabb = new MinMaxAABB();
            TestUtils.IsTrue(aabb.Equals(aabb));
        }

        [TestCompiler]
        public static void Equals()
        {
            MinMaxAABB aabb1 = new MinMaxAABB { Min = new float3(-123.0f, 0.5182f, 20.0f), Max = new float3(1.0f, -1.0f, 0.99191f) };
            MinMaxAABB aabb2 = aabb1;
            TestUtils.IsTrue(aabb1.Equals(aabb2));
            TestUtils.IsTrue(aabb2.Equals(aabb1));
        }

        [TestCompiler]
        public static void Equals_diff_minx()
        {
            MinMaxAABB aabb1 = new MinMaxAABB();
            MinMaxAABB aabb2 = new MinMaxAABB { Min = new float3(1.0f, 0.0f, 0.0f) };
            TestUtils.IsFalse(aabb1.Equals(aabb2));
            TestUtils.IsFalse(aabb2.Equals(aabb1));
        }

        [TestCompiler]
        public static void Equals_diff_miny()
        {
            MinMaxAABB aabb1 = new MinMaxAABB();
            MinMaxAABB aabb2 = new MinMaxAABB { Min = new float3(0.0f, 1.0f, 0.0f) };
            TestUtils.IsFalse(aabb1.Equals(aabb2));
            TestUtils.IsFalse(aabb2.Equals(aabb1));
        }

        [TestCompiler]
        public static void Equals_diff_minz()
        {
            MinMaxAABB aabb1 = new MinMaxAABB();
            MinMaxAABB aabb2 = new MinMaxAABB { Min = new float3(0.0f, 0.0f, 1.0f) };
            TestUtils.IsFalse(aabb1.Equals(aabb2));
            TestUtils.IsFalse(aabb2.Equals(aabb1));
        }

        [TestCompiler]
        public static void Equals_diff_maxx()
        {
            MinMaxAABB aabb1 = new MinMaxAABB();
            MinMaxAABB aabb2 = new MinMaxAABB { Max = new float3(1.0f, 0.0f, 0.0f) };
            TestUtils.IsFalse(aabb1.Equals(aabb2));
            TestUtils.IsFalse(aabb2.Equals(aabb1));
        }

        [TestCompiler]
        public static void Equals_diff_maxy()
        {
            MinMaxAABB aabb1 = new MinMaxAABB();
            MinMaxAABB aabb2 = new MinMaxAABB { Max = new float3(0.0f, 1.0f, 0.0f) };
            TestUtils.IsFalse(aabb1.Equals(aabb2));
            TestUtils.IsFalse(aabb2.Equals(aabb1));
        }

        [TestCompiler]
        public static void Equals_diff_maxz()
        {
            MinMaxAABB aabb1 = new MinMaxAABB();
            MinMaxAABB aabb2 = new MinMaxAABB { Max = new float3(0.0f, 0.0f, 1.0f) };
            TestUtils.IsFalse(aabb1.Equals(aabb2));
            TestUtils.IsFalse(aabb2.Equals(aabb1));
        }
    }
}
