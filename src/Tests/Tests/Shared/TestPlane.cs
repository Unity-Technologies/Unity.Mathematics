using NUnit.Framework;
using Unity.Mathematics.Geometry;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestPlane
    {
        // An arbitrary tolerance.
        const float Tolerance = 0.0000025f;

        [TestCompiler]
        public static void Empty()
        {
            var p = new Plane();

            TestUtils.AreEqual(float4.zero, p.NormalAndDistance);
            TestUtils.AreEqual(float3.zero, p.Normal);
            TestUtils.AreEqual(0.0f, p.Distance);
        }

        [TestCompiler]
        public static void GetNormal()
        {
            var p = new Plane { NormalAndDistance = new float4(1.0f, 2.0f, 3.0f, 4.0f) };

            TestUtils.AreEqual(new float3(1.0f, 2.0f, 3.0f), p.Normal);
        }

        [TestCompiler]
        public static void GetDistance()
        {
            var p = new Plane { NormalAndDistance = new float4(1.0f, 2.0f, 3.0f, 4.0f) };

            TestUtils.AreEqual(4.0f, p.Distance);
        }

        [TestCompiler]
        public static void SetNormal()
        {
            var p = new Plane { NormalAndDistance = new float4(1.0f, 2.0f, 3.0f, 4.0f) };
            p.Normal = new float3(-1.0f, -2.0f, -3.0f);

            TestUtils.AreEqual(new float3(-1.0f, -2.0f, -3.0f), p.Normal);
        }

        [TestCompiler]
        public static void SetDistance()
        {
            var p = new Plane { NormalAndDistance = new float4(1.0f, 2.0f, 3.0f, 4.0f) };
            p.Distance = -4.0f;

            TestUtils.AreEqual(-4.0f, p.Distance);
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
            var expectedN = new float3(5.773502691896258e-01f);
            var expectedD = 3.464101615137755f;

            TestUtils.AreEqual(new float4(expectedN, expectedD), p.NormalAndDistance);
            TestUtils.AreEqual(expectedN, p.Normal);
            TestUtils.AreEqual(expectedD, p.Distance);
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
            var v1 = new float3(5.0f, 0.0f, 0.0f);
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

            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(pointInPlane), Tolerance);
            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(pointInPlane + vInPlane1), Tolerance);
            TestUtils.AreEqual(0.0f, p.SignedDistanceToPoint(pointInPlane + vInPlane2), Tolerance);
            TestUtils.AreEqual(1.0f, p.SignedDistanceToPoint(pointInPlane + n), Tolerance);
            TestUtils.AreEqual(-1.0f, p.SignedDistanceToPoint(pointInPlane - n), Tolerance);
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
            var expectedD = -5.773502691896258e-01f;
            var expectedN = new float3(-5.773502691896258e-01f);

            TestUtils.AreEqual(new float4(expectedN, expectedD), p.Flipped, Tolerance);
        }

        [TestCompiler]
        public static void ImplicitToFloat4()
        {
            var normal = new float3(1.1f, -20.0f, 15.182f);
            var d = 18.9281f;
            var p = new Plane(normal, d);
            var expectedN = new float3(4.376593115243121e-02f, -7.957442027714765e-01f, 6.040494243238278e-01f);
            var expectedD = 7.530962922239393e-01f;
            float4 p_as_float4 = p;

            TestUtils.AreEqual(new float4(expectedN, expectedD), p_as_float4, Tolerance);
        }

        [TestCompiler]
        public static void NormalizeFloat4()
        {
            var p = new float4(8.215876543024162e-01f, 2.786574280629829e-01f, 8.121669997361285e-01f, 9.352839276497152e-01f);
            var expected = new float4(6.913449765800294e-01f, 2.344830914500849e-01f, 6.834177369527146e-01f, 7.870174797181938e-01f);

            TestUtils.AreEqual(expected, Plane.Normalize(p), Tolerance);
        }

        [TestCompiler]
        public static void NormalizePlane()
        {
            var p = new Plane { NormalAndDistance = new float4(8.215876543024162e-01f, 2.786574280629829e-01f, 8.121669997361285e-01f, 9.352839276497152e-01f) };
            var normalized = Plane.Normalize(p);
            var expected = new float4(6.913449765800294e-01f, 2.344830914500849e-01f, 6.834177369527146e-01f, 7.870174797181938e-01f);

            TestUtils.AreEqual(expected, normalized.NormalAndDistance, Tolerance);
            TestUtils.AreEqual(expected.xyz, normalized.Normal, Tolerance);
            TestUtils.AreEqual(expected.w, normalized.Distance, Tolerance);
        }

        [TestCompiler]
        public static void CreateFromUnitNormalAndDistance()
        {
            var n = new float3(9.108767140247756e-02f, 3.966831912609620e-01f, 9.134251375397404e-01f);
            var d = 9.120230523544353e-01f;
            var expected = new float4(n, d);
            var p = Plane.CreateFromUnitNormalAndDistance(n, d);

            TestUtils.AreEqual(expected, p.NormalAndDistance);
        }

        [TestCompiler]
        public static void CreateFromUnitNormalAndPointInPlane()
        {
            var n = new float3(4.724920516359185e-01f, 1.444614284194820e-01f, 8.694148358751899e-01f);
            var pointInPlane = new float3(9.395666432987706f, 3.818578457438728f, 4.283295215216710f);
            var expected = new float4(n, -8.714975414445176f);
            var p = Plane.CreateFromUnitNormalAndPointInPlane(n, pointInPlane);

            TestUtils.AreEqual(expected, p.NormalAndDistance, Tolerance);
        }
    }
}
