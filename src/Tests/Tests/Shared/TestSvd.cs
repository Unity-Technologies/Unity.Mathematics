using System.Collections.Generic;
using NUnit.Framework;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestSvd
    {
        const float k_SVDTolerance = 1e-4f;

        static bool QuaternionEquals(quaternion expected, quaternion actual, float tolerance) =>
            (math.lengthsq(expected) == 0f && math.lengthsq(actual) == 0f) || math.abs(math.dot(expected, actual)) > (1f - tolerance);

        // Validate Penrose condition that [aba = a]
        static void ValidatePenrose1(in float3x3 a, in float3x3 b)
        {
            var testA = math.mul(math.mul(a, b), a);

            TestUtils.AreEqual(a.c0.x, testA.c0.x, k_SVDTolerance);
            TestUtils.AreEqual(a.c0.y, testA.c0.y, k_SVDTolerance);
            TestUtils.AreEqual(a.c0.z, testA.c0.z, k_SVDTolerance);
            TestUtils.AreEqual(a.c1.x, testA.c1.x, k_SVDTolerance);
            TestUtils.AreEqual(a.c1.y, testA.c1.y, k_SVDTolerance);
            TestUtils.AreEqual(a.c1.z, testA.c1.z, k_SVDTolerance);
            TestUtils.AreEqual(a.c2.x, testA.c2.x, k_SVDTolerance);
            TestUtils.AreEqual(a.c2.y, testA.c2.y, k_SVDTolerance);
            TestUtils.AreEqual(a.c2.z, testA.c2.z, k_SVDTolerance);
        }

        // Validate Penrose condition that [transpose(ab) = ab]
        static void ValidatePenrose2(in float3x3 a, in float3x3 b)
        {
            var ab = math.mul(a, b);
            var testAB = math.transpose(ab);

            TestUtils.AreEqual(ab.c0.x, testAB.c0.x, k_SVDTolerance);
            TestUtils.AreEqual(ab.c0.y, testAB.c0.y, k_SVDTolerance);
            TestUtils.AreEqual(ab.c0.z, testAB.c0.z, k_SVDTolerance);
            TestUtils.AreEqual(ab.c1.x, testAB.c1.x, k_SVDTolerance);
            TestUtils.AreEqual(ab.c1.y, testAB.c1.y, k_SVDTolerance);
            TestUtils.AreEqual(ab.c1.z, testAB.c1.z, k_SVDTolerance);
            TestUtils.AreEqual(ab.c2.x, testAB.c2.x, k_SVDTolerance);
            TestUtils.AreEqual(ab.c2.y, testAB.c2.y, k_SVDTolerance);
            TestUtils.AreEqual(ab.c2.z, testAB.c2.z, k_SVDTolerance);
        }

        static void ValidateSingular(in float3x3 a) =>
            TestUtils.AreEqual(0.0f, math.determinant(a), k_SVDTolerance);

        [TestCompiler]
        public static void CanSVDInverseNonSingularFloat3x3()
        {
            var mat = math.float3x3(
                math.float3(9f, 1f, 2f),
                math.float3(3f, 8f, 4f),
                math.float3(5f, 6f, 7f)
            );

            var inv = svd.svdInverse(mat);
            var testIdentity = math.mul(mat, inv);

            TestUtils.AreEqual(1f, testIdentity.c0.x, k_SVDTolerance);
            TestUtils.AreEqual(0f, testIdentity.c0.y, k_SVDTolerance);
            TestUtils.AreEqual(0f, testIdentity.c0.z, k_SVDTolerance);
            TestUtils.AreEqual(0f, testIdentity.c1.x, k_SVDTolerance);
            TestUtils.AreEqual(1f, testIdentity.c1.y, k_SVDTolerance);
            TestUtils.AreEqual(0f, testIdentity.c1.z, k_SVDTolerance);
            TestUtils.AreEqual(0f, testIdentity.c2.x, k_SVDTolerance);
            TestUtils.AreEqual(0f, testIdentity.c2.y, k_SVDTolerance);
            TestUtils.AreEqual(1f, testIdentity.c2.z, k_SVDTolerance);
        }

        [TestCompiler]
        public static void CanSVDInverseFloat3x3With_NullColumn()
        {
            var mat = math.float3x3(
                math.float3(9f, 1f, 0f),
                math.float3(3f, 8f, 0f),
                math.float3(5f, 6f, 0f)
            );

            ValidateSingular(mat);
            var inv = svd.svdInverse(mat);

            ValidatePenrose1(mat, inv);
            ValidatePenrose1(inv, mat);
            ValidatePenrose2(mat, inv);
            ValidatePenrose2(inv, mat);
        }

        [TestCompiler]
        public static void CanSVDInverseFloat3x3With_NullRow()
        {
            var mat = math.float3x3(
                math.float3(9f, 1f, 2f),
                math.float3(0f, 0f, 0f),
                math.float3(5f, 6f, 7f)
            );

            ValidateSingular(mat);
            var inv = svd.svdInverse(mat);

            ValidatePenrose1(mat, inv);
            ValidatePenrose1(inv, mat);
            ValidatePenrose2(mat, inv);
            ValidatePenrose2(inv, mat);
        }

        [TestCompiler]
        public static void CanSVDInverseFloat3x3With_LinearDependentColumn()
        {
            var mat = math.float3x3(
                math.float3(9f, 4f, 2f),
                math.float3(3f, 8f, 4f),
                math.float3(5f, 14f, 7f)
            );

            ValidateSingular(mat);
            var inv = svd.svdInverse(mat);

            ValidatePenrose1(mat, inv);
            ValidatePenrose1(inv, mat);
            ValidatePenrose2(mat, inv);
            ValidatePenrose2(inv, mat);
        }

        [TestCompiler]
        public static void CanSVDInverseFloat3x3With_LinearDependentRow()
        {
            var mat = math.float3x3(
                math.float3(9f, 1f, 2f),
                math.float3(10f, 12f, 14f),
                math.float3(5f, 6f, 7f)
            );

            ValidateSingular(mat);
            var inv = svd.svdInverse(mat);

            ValidatePenrose1(mat, inv);
            ValidatePenrose1(inv, mat);
            ValidatePenrose2(mat, inv);
            ValidatePenrose2(inv, mat);
        }

        [TestCompiler]
        public static void CanSVDInverseFloat3x3With_RotatedZeroScale()
        {
            var m102030 = math.float3x3(quaternion.Euler(math.radians(10f), math.radians(20f), math.radians(30f)));
            var parent  = math.mulScale(m102030, math.float3(1f, 1f, 0f));
            var mat     = math.mul(parent, m102030);

            ValidateSingular(mat);
            var inv = svd.svdInverse(mat);

            ValidatePenrose1(mat, inv);
            ValidatePenrose1(inv, mat);
            ValidatePenrose2(mat, inv);
            ValidatePenrose2(inv, mat);
        }

        // Case 928598: The errors appear, when GameObject has a child with ParticleSystem which is rotated along the y-axis to -180 and is moved
        [TestCompiler]
        public static void CanExtractSVDRotationFromFloat3x3With_X180_Y0_Z181()
        {
            var q = quaternion.Euler(math.radians(180f), math.radians(0f), math.radians(181f));
            var qSVD = svd.svdRotation(math.float3x3(q));

            TestUtils.IsTrue(QuaternionEquals(q, qSVD, k_SVDTolerance));
        }

        // Case 938548: Assertion failed on expression: 'CompareApproximately(det, 1.0F, .005f)' when scaling system to 0 on at least 2 axes
        [TestCompiler]
        public static void CanExtractSVDRotationFromFloat3x3With_ZeroScaleXY()
        {
            var q0 = quaternion.Euler(math.radians(10f), math.radians(20f), math.radians(30f));
            var m0 = math.float3x3(q0);
            var m0Scaled = math.mulScale(m0, math.float3(1f, 0f, 0f));
            var q1 = svd.svdRotation(m0Scaled);
            var m1 = math.float3x3(q1);

            TestUtils.AreEqual(0.0f, math.length(m0.c0 - m1.c0), k_SVDTolerance);
        }
    }
}
