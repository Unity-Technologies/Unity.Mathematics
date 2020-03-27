using NUnit.Framework;
using Unity.Mathematics.Extras;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestNormalizedPlane
    {
        [TestCompiler]
        public static void Empty()
        {
            var p = new NormalizedPlane();

            TestUtils.AreEqual(float4.zero, p.NormalAndDistance);
            TestUtils.AreEqual(float3.zero, p.Normal);
            TestUtils.AreEqual(0.0f, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithNormalAndDistance()
        {
            var n = math.normalize(new float3(4.0f, -5.0f, 6.0f));
            var d = 123.0f;
            var p = new NormalizedPlane(n, d);

            TestUtils.AreEqual(new float4(n, d), p.NormalAndDistance);
            TestUtils.AreEqual(n, p.Normal);
            TestUtils.AreEqual(d, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithNormalAndOrigin_NegativeDistance()
        {
            var n = math.up();
            var origin = math.up();
            var p = new NormalizedPlane(n, origin);

            TestUtils.AreEqual(new float4(math.up(), -1.0f), p.NormalAndDistance);
            TestUtils.AreEqual(n, p.Normal);
            TestUtils.AreEqual(-1.0f, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithNormalAndOrigin_PositiveDistance()
        {
            var n = math.down();
            var origin = math.up();
            var p = new NormalizedPlane(n, origin);

            TestUtils.AreEqual(new float4(math.down(), 1.0f), p.NormalAndDistance);
            TestUtils.AreEqual(n, p.Normal);
            TestUtils.AreEqual(1.0f, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithTwoVectorsAndOrigin_Trivial()
        {
            var v1 = new float3(1.0f, 0.0f, 0.0f);
            var v2 = new float3(0.0f, 1.0f, 0.0f);
            var p = new NormalizedPlane(v1, v2, float3.zero);

            TestUtils.AreEqual(new float4(0.0f, 0.0f, 1.0f, 0.0f), p);
        }

        [TestCompiler]
        public static void ConstructWithTwoVectorsAndOrigin_NonZeroOrigin()
        {
            var v1 = new float3(1.0f, 0.0f, 0.0f);
            var v2 = new float3(0.0f, 1.0f, 0.0f);
            var p = new NormalizedPlane(v2, v1, new float3(0.0f, 0.0f, 1.0f));

            TestUtils.AreEqual(new float4(0.0f, 0.0f, -1.0f, 1.0f), p);
        }

        [TestCompiler]
        public static void SignedDistanceToPointTrivial()
        {
            var p = new NormalizedPlane(math.up(), 0.0f);

            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(float3.zero));
            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(math.left()));
            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(math.right()));
            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(math.forward()));
            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(math.back()));
            TestUtils.AreEqual(1.0f, p.SignedDistanceToPoint(math.up()));
            TestUtils.AreEqual(1.0f, p.SignedDistanceToPoint(math.up() + math.left()));
            TestUtils.AreEqual(1.0f, p.SignedDistanceToPoint(math.up() + math.right()));
            TestUtils.AreEqual(1.0f, p.SignedDistanceToPoint(math.up() + math.back()));
            TestUtils.AreEqual(1.0f, p.SignedDistanceToPoint(math.up() + math.forward()));
            TestUtils.AreEqual(-1.0f, p.SignedDistanceToPoint(math.down()));
            TestUtils.AreEqual(-1.0f, p.SignedDistanceToPoint(math.down() + math.left()));
            TestUtils.AreEqual(-1.0f, p.SignedDistanceToPoint(math.down() + math.right()));
            TestUtils.AreEqual(-1.0f, p.SignedDistanceToPoint(math.down() + math.back()));
            TestUtils.AreEqual(-1.0f, p.SignedDistanceToPoint(math.down() + math.forward()));
        }

        [TestCompiler]
        public static void ProjectionTrivial()
        {
            var p = new NormalizedPlane(math.up(), 0.0f);
            var expected = math.left() + math.forward();

            TestUtils.AreEqual(expected, p.Projection(math.up() + expected));
        }

        [TestCompiler]
        public static void Projection()
        {
            var normal = new float3(1.0f);
            var n = math.normalize(normal);
            var d = -1.0f;
            var p = new NormalizedPlane(n, d);
            var expected = new float3(math.sqrt(3.0f), 0.0f, 0.0f);

            TestUtils.AreEqual(expected, p.Projection(expected), math.EPSILON);
        }

        [TestCompiler]
        public static void Flipped()
        {
            var normal = new float3(1.0f);
            var n = math.normalize(normal);
            var d = -1.0f;
            var p = new NormalizedPlane(normal, d);

            TestUtils.AreEqual(new float4(-n, -d), p.Flipped);
        }

        [TestCompiler]
        public static void ImplicitToFloat4()
        {
            var normal = new float3(1.1f, -20.0f, 15.182f);
            var n = math.normalize(normal);
            var d = 18.9281f;
            var p = new NormalizedPlane(normal, d);
            float4 p_as_float4 = p;

            TestUtils.AreEqual(new float4(n, d), p_as_float4);
        }
    }
}