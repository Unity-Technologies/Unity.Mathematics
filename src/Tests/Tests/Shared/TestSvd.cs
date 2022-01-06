using System.Collections.Generic;
using NUnit.Framework;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    class FloatAbsoluteEqualityComparer : IEqualityComparer<float>
    {
        readonly float m_AllowedError;

        public FloatAbsoluteEqualityComparer(float allowedError) =>
            m_AllowedError = allowedError;

        public bool Equals(float expected, float actual) =>
            math.abs(expected - actual) < m_AllowedError;

        public int GetHashCode(float value) => 0;
    }

    class QuaternionAbsoluteEqualityComparer : IEqualityComparer<quaternion>
    {
        readonly float m_AllowedError;

        public QuaternionAbsoluteEqualityComparer(float allowedError) =>
            m_AllowedError = allowedError;

        public bool Equals(quaternion expected, quaternion actual) =>
            (math.lengthsq(expected) == 0f && math.lengthsq(actual) == 0f) || math.abs(math.dot(expected, actual)) > (1f - m_AllowedError);

        public int GetHashCode(quaternion value) => 0;
    }

    [TestFixture]
    public class TestSvd
    {
        const float k_SVDTolerance = 1e-4f;
        static readonly FloatAbsoluteEqualityComparer k_FloatComparer = new FloatAbsoluteEqualityComparer(k_SVDTolerance);
        static readonly QuaternionAbsoluteEqualityComparer k_QuaternionComparer = new QuaternionAbsoluteEqualityComparer(k_SVDTolerance);

        // Validate Penrose condition that [aba = a]
        static void ValidatePenrose1(in float3x3 a, in float3x3 b)
        {
            var testA = math.mul(math.mul(a, b), a);

            Assert.That(testA.c0.x, Is.EqualTo(a.c0.x).Using(k_FloatComparer));
            Assert.That(testA.c0.y, Is.EqualTo(a.c0.y).Using(k_FloatComparer));
            Assert.That(testA.c0.z, Is.EqualTo(a.c0.z).Using(k_FloatComparer));
            Assert.That(testA.c1.x, Is.EqualTo(a.c1.x).Using(k_FloatComparer));
            Assert.That(testA.c1.y, Is.EqualTo(a.c1.y).Using(k_FloatComparer));
            Assert.That(testA.c1.z, Is.EqualTo(a.c1.z).Using(k_FloatComparer));
            Assert.That(testA.c2.x, Is.EqualTo(a.c2.x).Using(k_FloatComparer));
            Assert.That(testA.c2.y, Is.EqualTo(a.c2.y).Using(k_FloatComparer));
            Assert.That(testA.c2.z, Is.EqualTo(a.c2.z).Using(k_FloatComparer));
        }

        // Validate Penrose condition that [transpose(ab) = ab]
        static void ValidatePenrose2(in float3x3 a, in float3x3 b)
        {
            var ab = math.mul(a, b);
            var testAB = math.transpose(ab);

            Assert.That(testAB.c0.x, Is.EqualTo(ab.c0.x).Using(k_FloatComparer));
            Assert.That(testAB.c0.y, Is.EqualTo(ab.c0.y).Using(k_FloatComparer));
            Assert.That(testAB.c0.z, Is.EqualTo(ab.c0.z).Using(k_FloatComparer));
            Assert.That(testAB.c1.x, Is.EqualTo(ab.c1.x).Using(k_FloatComparer));
            Assert.That(testAB.c1.y, Is.EqualTo(ab.c1.y).Using(k_FloatComparer));
            Assert.That(testAB.c1.z, Is.EqualTo(ab.c1.z).Using(k_FloatComparer));
            Assert.That(testAB.c2.x, Is.EqualTo(ab.c2.x).Using(k_FloatComparer));
            Assert.That(testAB.c2.y, Is.EqualTo(ab.c2.y).Using(k_FloatComparer));
            Assert.That(testAB.c2.z, Is.EqualTo(ab.c2.z).Using(k_FloatComparer));
        }

        static void ValidateSingular(in float3x3 a) =>
            Assert.That(math.determinant(a), Is.EqualTo(0f).Using(k_FloatComparer));

        [TestCompiler]
        public void CanSVDInverseNonSingularFloat3x3()
        {
            var mat = math.float3x3(
                math.float3(9f, 1f, 2f),
                math.float3(3f, 8f, 4f),
                math.float3(5f, 6f, 7f)
            );

            var inv = svd.svdInverse(mat);
            var testIdentity = math.mul(mat, inv);

            Assert.That(testIdentity.c0.x, Is.EqualTo(1f).Using(k_FloatComparer));
            Assert.That(testIdentity.c0.y, Is.EqualTo(0f).Using(k_FloatComparer));
            Assert.That(testIdentity.c0.z, Is.EqualTo(0f).Using(k_FloatComparer));
            Assert.That(testIdentity.c1.x, Is.EqualTo(0f).Using(k_FloatComparer));
            Assert.That(testIdentity.c1.y, Is.EqualTo(1f).Using(k_FloatComparer));
            Assert.That(testIdentity.c1.z, Is.EqualTo(0f).Using(k_FloatComparer));
            Assert.That(testIdentity.c2.x, Is.EqualTo(0f).Using(k_FloatComparer));
            Assert.That(testIdentity.c2.y, Is.EqualTo(0f).Using(k_FloatComparer));
            Assert.That(testIdentity.c2.z, Is.EqualTo(1f).Using(k_FloatComparer));
        }

        [TestCompiler]
        public void CanSVDInverseFloat3x3With_NullColumn()
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
        public void CanSVDInverseFloat3x3With_NullRow()
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
        public void CanSVDInverseFloat3x3With_LinearDependentColumn()
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
        public void CanSVDInverseFloat3x3With_LinearDependentRow()
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
        public void CanSVDInverseFloat3x3With_RotatedZeroScale()
        {
            var m102030 = math.float3x3(quaternion.Euler(math.radians(10f), math.radians(20f), math.radians(30f)));
            var parent  = svd.mulScale(m102030, math.float3(1f, 1f, 0f));
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
        public void CanExtractSVDRotationFromFloat3x3With_X180_Y0_Z181()
        {
            var q = quaternion.Euler(math.radians(180f), math.radians(0f), math.radians(181f));
            var qSVD = svd.svdRotation(math.float3x3(q));

            Assert.That(qSVD, Is.EqualTo(q).Using(k_QuaternionComparer));
        }

        // Case 938548: Assertion failed on expression: 'CompareApproximately(det, 1.0F, .005f)' when scaling system to 0 on at least 2 axes
        [TestCompiler]
        public void CanExtractSVDRotationFromFloat3x3With_ZeroScaleXY()
        {
            var q0 = quaternion.Euler(math.radians(10f), math.radians(20f), math.radians(30f));
            var m0 = math.float3x3(q0);
            var m0Scaled = svd.mulScale(m0, math.float3(1f, 0f, 0f));
            var q1 = svd.svdRotation(m0Scaled);
            var m1 = math.float3x3(q1);

            Assert.That(math.length(m0.c0 - m1.c0), Is.EqualTo(0f).Using(k_FloatComparer));
        }
    }
}