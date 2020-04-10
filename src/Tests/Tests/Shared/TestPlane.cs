using NUnit.Framework;
using Unity.Mathematics.Extras;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestPlane
    {
        static float Tolerance = 0.0000025f;

        [TestCompiler]
        public static void Empty()
        {
            var p = new Plane();

            TestUtils.AreEqual(float4.zero, p.NormalAndDistance);
            TestUtils.AreEqual(float3.zero, p.Normal);
            TestUtils.AreEqual(0.0f, p.Distance);
        }

        [TestCompiler]
        public static void Normal()
        {
            var p = new Plane { NormalAndDistance = new float4(1.0f, 2.0f, 3.0f, 4.0f) };

            TestUtils.AreEqual(new float3(1.0f, 2.0f, 3.0f), p.Normal);
        }

        [TestCompiler]
        public static void Distance()
        {
            var p = new Plane { NormalAndDistance = new float4(1.0f, 2.0f, 3.0f, 4.0f) };

            TestUtils.AreEqual(4.0f, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithNormalAndDistance()
        {
            var n = math.normalize(new float3(4.0f, -5.0f, 6.0f));
            var d = 123.0f;
            var p = new Plane(n, d);

            TestUtils.AreEqual(new float4(n, d), p.NormalAndDistance);
            TestUtils.AreEqual(n, p.Normal);
            TestUtils.AreEqual(d, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithCoefficients_NonUnitLengthNormal()
        {
            var abcd = new float4(4.0f, -5.0f, 6.0f, 123.0f);
            var p = new Plane(abcd.x, abcd.y, abcd.z, abcd.w);
            var expected = abcd * math.rsqrt(math.lengthsq(abcd.xyz));

            TestUtils.AreEqual(expected, p.NormalAndDistance, Tolerance);
            TestUtils.AreEqual(expected.xyz, p.Normal);
            TestUtils.AreEqual(expected.w, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithNormalAndPointInPlane_NegativeDistance()
        {
            var n = math.up();
            var pointInPlane = math.up();
            var p = new Plane(n, pointInPlane);

            TestUtils.AreEqual(new float4(math.up(), -1.0f), p.NormalAndDistance);
            TestUtils.AreEqual(n, p.Normal);
            TestUtils.AreEqual(-1.0f, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithNormalAndPointInPlane_PositiveDistance()
        {
            var n = math.down();
            var pointInPlane = math.up();
            var p = new Plane(n, pointInPlane);

            TestUtils.AreEqual(new float4(math.down(), 1.0f), p.NormalAndDistance);
            TestUtils.AreEqual(n, p.Normal);
            TestUtils.AreEqual(1.0f, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithNormalAndPointInPlane()
        {
            var normal = new float3(2.0f, 2.0f, 2.0f);
            var pointInPlane = new float3(-2.0f, -2.0f, -2.0f);
            var p = new Plane(normal, pointInPlane);
            var d = 12.0f;

            TestUtils.AreEqual(new float4(normal, d), p.NormalAndDistance);
            TestUtils.AreEqual(normal, p.Normal);
            TestUtils.AreEqual(d, p.Distance);
        }

        [TestCompiler]
        public static void ConstructWithTwoVectorsAndOrigin_Trivial()
        {
            var v1 = new float3(1.0f, 0.0f, 0.0f);
            var v2 = new float3(0.0f, 1.0f, 0.0f);
            var p = new Plane(v1, v2, float3.zero);

            TestUtils.AreEqual(new float4(0.0f, 0.0f, 1.0f, 0.0f), p);
        }

        [TestCompiler]
        public static void ConstructWithTwoVectorsAndOrigin_NonZeroOrigin()
        {
            var v1 = new float3(1.0f, 0.0f, 0.0f);
            var v2 = new float3(0.0f, 1.0f, 0.0f);
            var p = new Plane(v2, v1, new float3(0.0f, 0.0f, 1.0f));

            TestUtils.AreEqual(new float4(0.0f, 0.0f, -1.0f, 1.0f), p);
        }

        [TestCompiler]
        public static void SignedDistanceToPoint()
        {
            var vInPlane1 = new float3(2.0f, 1.0f, -0.18f);
            var vInPlane2 = new float3(-0.9928f, 10.0f, 3.125f);
            var n = math.normalize(math.cross(vInPlane1, vInPlane2));
            var pointInPlane = new float3(10.0f, -25.8918f, 1.0f);
            var p = new Plane(vInPlane1, vInPlane2, pointInPlane);

            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(pointInPlane));
            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(pointInPlane + vInPlane1));
            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(pointInPlane + vInPlane2));
            TestUtils.AreEqual(1.0f, p.SignedDistanceToPoint(pointInPlane + n));
            TestUtils.AreEqual(-1.0f, p.SignedDistanceToPoint(pointInPlane - n));
        }

        [TestCompiler]
        public static void SignedDistanceToPointTrivial()
        {
            var p = new Plane(math.up(), 0.0f);

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
            var p = new Plane(math.up(), 0.0f);
            var expected = math.left() + math.forward();

            TestUtils.AreEqual(expected, p.Projection(math.up() + expected));
        }

        [TestCompiler]
        public static void Projection()
        {
            var normal = new float3(1.0f);
            var n = math.normalize(normal);
            var d = -1.0f;
            var p = new Plane(n, d);
            var expected = new float3(math.sqrt(3.0f), 0.0f, 0.0f);

            TestUtils.AreEqual(expected, p.Projection(expected), math.EPSILON);
        }

        [TestCompiler]
        public static void Flipped()
        {
            var normal = new float3(1.0f);
            var d = 1.0f;
            var p = new Plane(normal, d);

            TestUtils.AreEqual(new float4(-normal, -d), p.Flipped, Tolerance);
        }

        [TestCompiler]
        public static void ImplicitToFloat4()
        {
            var normal = new float3(1.1f, -20.0f, 15.182f);
            var d = 18.9281f;
            var p = new Plane(normal, d);
            float4 p_as_float4 = p;

            TestUtils.AreEqual(new float4(normal, d), p_as_float4, Tolerance);
        }
    }
}