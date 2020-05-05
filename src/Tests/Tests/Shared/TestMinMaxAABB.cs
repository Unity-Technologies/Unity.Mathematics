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

        [TestCompiler]
        public static void SurfaceArea()
        {
            var min = new float3(-47.989063262939453125f, 28.037994384765625f, -9.756519317626953125f);
            var max = new float3(43.84253692626953125f, 101.54019927978515625f, -7.03227138519287109375f);
            var aabb = new MinMaxAABB { Min = min, Max = max };

            TestUtils.AreEqual(14400.470703125f, aabb.SurfaceArea, 1, true);
        }

        [TestCompiler]
        public static void Extents()
        {
            var min = new float3(48.152984619140625f, -33.58978271484375f, -37.498805999755859375f);
            var max = new float3(111.2894439697265625f, -9.473724365234375f, 25.39115142822265625f);
            var aabb = new MinMaxAABB { Min = min, Max = max };
            var expected = new float3(63.1364593505859375f, 24.116058349609375f, 62.889957427978515625f);

            TestUtils.AreEqual(expected, aabb.Extents);
        }

        [TestCompiler]
        public static void Center()
        {
            var min = new float3(47.902675628662109375f, -34.302494049072265625f, 22.7147884368896484375f);
            var max = new float3(84.1039886474609375f, 23.274578094482421875f, 58.204532623291015625f);
            var aabb = new MinMaxAABB { Min = min, Max = max };
            var expected = new float3(66.00333404541015625f, -5.513957977294921875f, 40.459659576416015625f);

            TestUtils.AreEqual(expected, aabb.Center);
        }

        [TestCompiler]
        public static void HalfExtents()
        {
            var min = new float3(-14.3485383987426757813f, 28.68161773681640625f, -40.28060150146484375f);
            var max = new float3(4.26444864273071289063f, 99.3212738037109375f, 27.9023494720458984375f);
            var aabb = new MinMaxAABB { Min = min, Max = max };
            var expected = new float3(9.3064937591552734375f, 35.319828033447265625f, 34.0914764404296875f);

            TestUtils.AreEqual(expected, aabb.HalfExtents);
        }

        [TestCompiler]
        public static void Constructor()
        {
            var min = new float3(38.95940399169921875f, -24.644245147705078125f, 27.7903194427490234375f);
            var max = new float3(71.30234527587890625f, 52.2211151123046875f, 99.07735443115234375f);
            var aabb = new MinMaxAABB(min, max);

            TestUtils.AreEqual(min, aabb.Min);
            TestUtils.AreEqual(max, aabb.Max);
        }

        [TestCompiler]
        public static void ContainsPoint()
        {
            var aabb = new MinMaxAABB(new float3(-1), new float3(1));

            TestUtils.IsTrue(aabb.Contains(float3.zero));
            TestUtils.IsTrue(aabb.Contains(aabb.Min));
            TestUtils.IsTrue(aabb.Contains(aabb.Max));
            TestUtils.IsTrue(aabb.Contains(new float3(0.5f)));
            TestUtils.IsTrue(aabb.Contains(new float3(-0.5f)));
            TestUtils.IsTrue(aabb.Contains(new float3(-1.0f, 1.0f, 1.0f)));
            TestUtils.IsTrue(aabb.Contains(new float3(1.0f, -1.0f, 1.0f)));
            TestUtils.IsTrue(aabb.Contains(new float3(1.0f, 1.0f, -1.0f)));

            TestUtils.IsFalse(aabb.Contains(new float3(1.0f + EPSILON, 1.0f, 1.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(1.0f, 1.0f + EPSILON, 1.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(1.0f, 1.0f, 1.0f + EPSILON)));
            TestUtils.IsFalse(aabb.Contains(new float3(-1.0f - EPSILON, -1.0f, -1.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(-1.0f, -1.0f - EPSILON, -1.0f)));
            TestUtils.IsFalse(aabb.Contains(new float3(-1.0f, -1.0f, -1.0f - EPSILON)));
        }

        [TestCompiler]
        public static void ContainsAabb_Trivial()
        {
            var aabb1 = new MinMaxAABB();
            var aabb2 = new MinMaxAABB();

            TestUtils.IsTrue(aabb1.Contains(aabb2));
            TestUtils.IsTrue(aabb2.Contains(aabb1));
        }

        [TestCompiler]
        public static void ContainsAabb()
        {
            var aabb1 = new MinMaxAABB(new float3(-1.0f), new float3(1.0f));
            var aabb2 = new MinMaxAABB(new float3(-0.5f), new float3(0.5f));

            TestUtils.IsTrue(aabb1.Contains(aabb2));
            TestUtils.IsFalse(aabb2.Contains(aabb1));
        }

        [TestCompiler]
        public static void ContainsAabb_BarelyNotContained()
        {
            var aabb1 = new MinMaxAABB(new float3(-1.0f), new float3(1.0f));
            var aabb2 = new MinMaxAABB(new float3(-1.0f), new float3(1.0f + EPSILON, 1.0f          , 1.0f          ));
            var aabb3 = new MinMaxAABB(new float3(-1.0f), new float3(1.0f          , 1.0f + EPSILON, 1.0f          ));
            var aabb4 = new MinMaxAABB(new float3(-1.0f), new float3(1.0f          , 1.0f          , 1.0f + EPSILON));
            var aabb5 = new MinMaxAABB(new float3(-1.0f - EPSILON, -1.0f          , -1.0f          ), new float3(1.0f));
            var aabb6 = new MinMaxAABB(new float3(-1.0f          , -1.0f - EPSILON, -1.0f          ), new float3(1.0f));
            var aabb7 = new MinMaxAABB(new float3(-1.0f          , -1.0f          , -1.0f - EPSILON), new float3(1.0f));

            TestUtils.IsFalse(aabb1.Contains(aabb2));
            TestUtils.IsFalse(aabb1.Contains(aabb3));
            TestUtils.IsFalse(aabb1.Contains(aabb4));
            TestUtils.IsFalse(aabb1.Contains(aabb5));
            TestUtils.IsFalse(aabb1.Contains(aabb6));
            TestUtils.IsFalse(aabb1.Contains(aabb7));
        }

        [TestCompiler]
        public static void Overlap_Trivial()
        {
            var aabb = new MinMaxAABB();

            TestUtils.IsTrue(aabb.Overlaps(aabb));
        }

        [TestCompiler]
        public static void Overlap_Corner()
        {
            var aabb = new MinMaxAABB(new float3(-1.0f), new float3(1.0f));

            var corner1 = new float3(-1.0f, -1.0f, -1.0f);
            var corner2 = new float3(-1.0f, -1.0f,  1.0f);
            var corner3 = new float3(-1.0f,  1.0f, -1.0f);
            var corner4 = new float3(-1.0f,  1.0f,  1.0f);
            var corner5 = new float3( 1.0f, -1.0f, -1.0f);
            var corner6 = new float3( 1.0f, -1.0f,  1.0f);
            var corner7 = new float3( 1.0f,  1.0f, -1.0f);
            var corner8 = new float3( 1.0f,  1.0f,  1.0f);

            var cornerAabb1 = new MinMaxAABB(corner1, corner1);
            var cornerAabb2 = new MinMaxAABB(corner2, corner2);
            var cornerAabb3 = new MinMaxAABB(corner3, corner3);
            var cornerAabb4 = new MinMaxAABB(corner4, corner4);
            var cornerAabb5 = new MinMaxAABB(corner5, corner5);
            var cornerAabb6 = new MinMaxAABB(corner6, corner6);
            var cornerAabb7 = new MinMaxAABB(corner7, corner7);
            var cornerAabb8 = new MinMaxAABB(corner8, corner8);

            TestUtils.IsTrue(aabb.Overlaps(cornerAabb1));
            TestUtils.IsTrue(cornerAabb1.Overlaps(aabb));
            TestUtils.IsTrue(aabb.Overlaps(cornerAabb2));
            TestUtils.IsTrue(cornerAabb2.Overlaps(aabb));
            TestUtils.IsTrue(aabb.Overlaps(cornerAabb3));
            TestUtils.IsTrue(cornerAabb3.Overlaps(aabb));
            TestUtils.IsTrue(aabb.Overlaps(cornerAabb4));
            TestUtils.IsTrue(cornerAabb4.Overlaps(aabb));
            TestUtils.IsTrue(aabb.Overlaps(cornerAabb5));
            TestUtils.IsTrue(cornerAabb5.Overlaps(aabb));
            TestUtils.IsTrue(aabb.Overlaps(cornerAabb6));
            TestUtils.IsTrue(cornerAabb6.Overlaps(aabb));
            TestUtils.IsTrue(aabb.Overlaps(cornerAabb7));
            TestUtils.IsTrue(cornerAabb7.Overlaps(aabb));
            TestUtils.IsTrue(aabb.Overlaps(cornerAabb8));
            TestUtils.IsTrue(cornerAabb8.Overlaps(aabb));
        }

        [TestCompiler]
        public static void NoOverlap_Corner()
        {
            var aabb = new MinMaxAABB(new float3(-1.0f), new float3(1.0f));

            var corner1 = new float3(-1.0f - EPSILON, -1.0f - EPSILON, -1.0f - EPSILON);
            var corner2 = new float3(-1.0f - EPSILON, -1.0f - EPSILON,  1.0f + EPSILON);
            var corner3 = new float3(-1.0f - EPSILON,  1.0f + EPSILON, -1.0f - EPSILON);
            var corner4 = new float3(-1.0f - EPSILON,  1.0f + EPSILON,  1.0f + EPSILON);
            var corner5 = new float3( 1.0f + EPSILON, -1.0f - EPSILON, -1.0f - EPSILON);
            var corner6 = new float3( 1.0f + EPSILON, -1.0f - EPSILON,  1.0f + EPSILON);
            var corner7 = new float3( 1.0f + EPSILON,  1.0f + EPSILON, -1.0f - EPSILON);
            var corner8 = new float3( 1.0f + EPSILON,  1.0f + EPSILON,  1.0f + EPSILON);

            var cornerAabb1 = new MinMaxAABB(corner1, corner1);
            var cornerAabb2 = new MinMaxAABB(corner2, corner2);
            var cornerAabb3 = new MinMaxAABB(corner3, corner3);
            var cornerAabb4 = new MinMaxAABB(corner4, corner4);
            var cornerAabb5 = new MinMaxAABB(corner5, corner5);
            var cornerAabb6 = new MinMaxAABB(corner6, corner6);
            var cornerAabb7 = new MinMaxAABB(corner7, corner7);
            var cornerAabb8 = new MinMaxAABB(corner8, corner8);

            TestUtils.IsFalse(aabb.Overlaps(cornerAabb1));
            TestUtils.IsFalse(cornerAabb1.Overlaps(aabb));
            TestUtils.IsFalse(aabb.Overlaps(cornerAabb2));
            TestUtils.IsFalse(cornerAabb2.Overlaps(aabb));
            TestUtils.IsFalse(aabb.Overlaps(cornerAabb3));
            TestUtils.IsFalse(cornerAabb3.Overlaps(aabb));
            TestUtils.IsFalse(aabb.Overlaps(cornerAabb4));
            TestUtils.IsFalse(cornerAabb4.Overlaps(aabb));
            TestUtils.IsFalse(aabb.Overlaps(cornerAabb5));
            TestUtils.IsFalse(cornerAabb5.Overlaps(aabb));
            TestUtils.IsFalse(aabb.Overlaps(cornerAabb6));
            TestUtils.IsFalse(cornerAabb6.Overlaps(aabb));
            TestUtils.IsFalse(aabb.Overlaps(cornerAabb7));
            TestUtils.IsFalse(cornerAabb7.Overlaps(aabb));
            TestUtils.IsFalse(aabb.Overlaps(cornerAabb8));
            TestUtils.IsFalse(cornerAabb8.Overlaps(aabb));
        }

        [TestCompiler]
        public static void Expand_PositiveDistance()
        {
            var aabb = new MinMaxAABB(new float3(-0.5f), new float3(0.5f));
            aabb.Expand(1.0f);

            TestUtils.AreEqual(new float3(-1.5f), aabb.Min);
            TestUtils.AreEqual(new float3(1.5f), aabb.Max);
        }

        [TestCompiler]
        public static void Expand_NegativeDistance()
        {
            var aabb = new MinMaxAABB(new float3(-0.5f), new float3(0.5f));
            aabb.Expand(-1.0f);

            TestUtils.AreEqual(new float3(0.5f), aabb.Min);
            TestUtils.AreEqual(new float3(-0.5f), aabb.Max);
        }

        [TestCompiler]
        public static void CreateFromCenterAndExtents()
        {
            var center = new float3(-29.2458133697509765625f, 1.21094369888305664063f, 34.281322479248046875f);
            var extents = new float3(71.5140533447265625f, 33.691967010498046875f, 29.8891429901123046875f);
            var expectedMin = new float3(-65.002838134765625f, -15.635040283203125f, 19.336750030517578125f);
            var expectedMax = new float3(6.5112133026123046875f, 18.056926727294921875f, 49.225894927978515625f);
            var aabb = MinMaxAABB.CreateFromCenterAndExtents(center, extents);

            TestUtils.AreEqual(expectedMin, aabb.Min);
            TestUtils.AreEqual(expectedMax, aabb.Max);
        }

        [TestCompiler]
        public static void CreateFromCenterAndHalfExtents()
        {
            var center = new float3(-29.2458133697509765625f, 1.21094369888305664063f, 34.281322479248046875f);
            var halfExtents = new float3(8.8238582611083984375f, 72.26158905029296875f, 47.658290863037109375f);
            var expectedMin = new float3(-38.069671630859375f, -71.0506439208984375f, -13.3769683837890625f);
            var expectedMax = new float3(-20.421955108642578125f, 73.4725341796875f, 81.93961334228515625f);
            var aabb = MinMaxAABB.CreateFromCenterAndHalfExtents(center, halfExtents);

            TestUtils.AreEqual(expectedMin, aabb.Min);
            TestUtils.AreEqual(expectedMax, aabb.Max);
        }

        [TestCompiler]
        public static void IsValid_Trivial()
        {
            TestUtils.IsTrue(new MinMaxAABB().IsValid);
            TestUtils.IsFalse(new MinMaxAABB(new float3(1.0f), new float3(-1.0f)).IsValid);
        }

        [TestCompiler]
        public static void IsValid_OneComponentInvalid()
        {
            TestUtils.IsFalse(new MinMaxAABB(float3.zero, new float3(-1.0f, 0.0f, 0.0f)).IsValid);
            TestUtils.IsFalse(new MinMaxAABB(float3.zero, new float3(0.0f, -1.0f, 0.0f)).IsValid);
            TestUtils.IsFalse(new MinMaxAABB(float3.zero, new float3(0.0f, 0.0f, -1.0f)).IsValid);
            TestUtils.IsFalse(new MinMaxAABB(new float3(1.0f, 0.0f, 0.0f), float3.zero).IsValid);
            TestUtils.IsFalse(new MinMaxAABB(new float3(0.0f, 1.0f, 0.0f), float3.zero).IsValid);
            TestUtils.IsFalse(new MinMaxAABB(new float3(0.0f, 0.0f, 1.0f), float3.zero).IsValid);
        }

        [TestCompiler]
        public static void Transform_RigidTransform()
        {
            var t = new RigidTransform(quaternion.EulerXYZ(PI * 0.25f), new float3(1.0f, 1.0f, 1.0f));
            var aabb = Unity.Mathematics.Geometry.Math.Transform(t, new MinMaxAABB(new float3(1.0f), new float3(3.0f)));
            var expectedMin = new float3(1.914213562373095e+00f, 1.914213562373095e+00f, -1.213203435596422e-01f);
            var expectedMax = new float3(4.914213562373095f, 4.914213562373095f, 3.292893218813453f);

            float tolerance = 1e-6f;
            TestUtils.AreEqual(expectedMin, aabb.Min, tolerance);
            TestUtils.AreEqual(expectedMax, aabb.Max, tolerance);
        }

        [TestCompiler]
        public static void Transform_float4x4()
        {
            var t = new float4x4(float3x3.EulerXYZ(PI * 0.25f), new float3(1.0f, 1.0f, 1.0f));
            var aabb = Unity.Mathematics.Geometry.Math.Transform(t, new MinMaxAABB(new float3(1.0f), new float3(3.0f)));
            var expectedMin = new float3(1.914213562373095e+00f, 1.914213562373095e+00f, -1.213203435596422e-01f);
            var expectedMax = new float3(4.914213562373095f, 4.914213562373095f, 3.292893218813453f);

            float tolerance = 1e-6f;
            TestUtils.AreEqual(expectedMin, aabb.Min, tolerance);
            TestUtils.AreEqual(expectedMax, aabb.Max, tolerance);
        }

        [TestCompiler]
        public static void Transform_float3x3()
        {
            var t = float3x3.EulerXYZ(PI * 0.25f);
            var aabb = Unity.Mathematics.Geometry.Math.Transform(t, new MinMaxAABB(new float3(1.0f), new float3(3.0f)));
            var expectedMin = new float3(9.142135623730949e-01f, 9.142135623730949e-01f, -1.121320343559642e+00f);
            var expectedMax = new float3(3.914213562373095f, 3.914213562373095f, 2.292893218813453f);

            float tolerance = 1e-6f;
            TestUtils.AreEqual(expectedMin, aabb.Min, tolerance);
            TestUtils.AreEqual(expectedMax, aabb.Max, tolerance);
        }
    }
}
