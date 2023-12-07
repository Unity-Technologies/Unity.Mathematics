using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestAffineTransform
    {
        [TestCompiler]
        public static void affine_transform_construct_from_float3x3()
        {
            const float tolerance = 1e-6f;

            float3x3 m3x3 = TestMatrix.test3x3_zyx;
            AffineTransform tx = AffineTransform(m3x3);

            float3x3 testM3x3 = float3x3(tx);

            TestUtils.AreEqual(m3x3, testM3x3, tolerance);
        }

        [TestCompiler]
        public static void affine_transform_construct_from_float3x4()
        {
            const float tolerance = 1e-6f;

            float3x4 m3x4 = float3x4(TestMatrix.test3x3_zyx.c0, TestMatrix.test3x3_zyx.c1, TestMatrix.test3x3_zyx.c2, float3(1f, 2f, 3f));
            AffineTransform tx = AffineTransform(m3x4);

            float3x4 testM3x4 = float3x4(tx);

            TestUtils.AreEqual(m3x4, testM3x4, tolerance);
        }

        [TestCompiler]
        public static void affine_transform_construct_from_float4x4()
        {
            const float tolerance = 1e-6f;

            float4x4 m4x4 = TestMatrix.test4x4_zyx;
            AffineTransform tx = AffineTransform(m4x4);

            float4x4 testM4x4 = float4x4(tx);

            TestUtils.AreEqual(m4x4, testM4x4, tolerance);
        }

        [TestCompiler]
        public static void affine_transform_construct_from_RigidTransform()
        {
            const float tolerance = 1e-6f;

            RigidTransform r = RigidTransform(TestMatrix.test4x4_xyz);
            AffineTransform tx = AffineTransform(r);

            TestUtils.AreEqual(math.float3x3(r.rot), tx.rs, tolerance);
            TestUtils.AreEqual(r.pos, tx.t, tolerance);
        }

        [TestCompiler]
        public static void affine_transform_inverse()
        {
            const float tolerance = 1e-6f;

            var tx = AffineTransform(float3(5f, 6f, 7f), normalize(math.float4(1f, 2f, 3f, 4f)), float3(2f, 3f, 4f));
            var invTx = inverse(tx);

            TestUtils.AreEqual(float4x4.identity, mul(tx, invTx), tolerance);
        }

        [TestCompiler]
        public static void affine_transform_inverse_zero_rs_returns_zero()
        {
            const float tolerance = 1e-30f;

            var tx = AffineTransform(float3(5f, 6f, 7f), normalize(float4(1f, 2f, 3f, 4f)), float3.zero);
            var invTx = inverse(tx);

            TestUtils.AreEqual(float3x4.zero, invTx, tolerance);
        }

        [TestCompiler]
        public static void affine_transform_inverse_pico_scale()
        {
            // slightly larger tolerance (vs 1e-6f) for PS4
            const float tolerance = 2e-6f;

            var tx = AffineTransform(float3(5f, 6f, 7f), normalize(float4(1f, 2f, 3f, 4f)), float3(1e-12f, 1e-12f, 1e-12f));
            var invTx = inverse(tx);

            TestUtils.AreEqual(float4x4.identity, mul(tx, invTx), tolerance);
        }

        [TestCompiler]
        public static void affine_transform_inverse_singular()
        {
            // it needs a bit larger tolerance for singular
            // since it uses the svd iterative solver
            const float tolerance = 1e-1f;

            var tx = AffineTransform(float3(5f, 6f, 7f), normalize(float4(1f, 2f, 3f, 4f)), float3(0f, 3f, 4f));
            var invTx = inverse(tx);

            // pseudo inverse penrose #1 test
            var testTx = mul(mul(tx, invTx), tx);
            TestUtils.AreEqual(float4x4(tx), float4x4(testTx), tolerance);
        }

        [TestCompiler]
        public static void affine_transform_decompose()
        {
            const float tolerance = 1e-6f;

            var tx = AffineTransform(float3(5f, 6f, 7f), normalize(float4(1f, 2f, 3f, 4f)), float3(2f, 3f, 4f));
            decompose(tx, out var t, out var r, out var s);

            // Recompose matrix
            var testTx = AffineTransform(t, r, s);
            TestUtils.AreEqual(float4x4(tx), float4x4(testTx), tolerance);
        }

        [TestCompiler]
        public static void affine_transform_mul_vector()
        {
            float4x4 m = TestMatrix.test4x4_xyz;
            AffineTransform tx = AffineTransform(m);

            float3 vector = float3(1.1f, -2.2f, 3.5f);

            float4 mvector0 = mul(m, float4(vector, 0f));
            float4 txvector0 = mul(tx, float4(vector, 0f));
            TestUtils.AreEqual(mvector0, txvector0, 0.0001f);

            float4 mvector1 = mul(m, float4(vector, 1f));
            float4 txvector1 = mul(tx, float4(vector, 1f));
            TestUtils.AreEqual(mvector1, txvector1, 0.0001f);
        }

        [TestCompiler]
        public static void affine_transform_rotate_vector()
        {
            float3x3 m = TestMatrix.test3x3_xyz;
            AffineTransform tx = AffineTransform(m);

            float3 vector = float3(1.1f, -2.2f, 3.5f);

            float3 mvector0 = mul(m, vector);
            float3 txvector0 = rotate(tx, vector);
            TestUtils.AreEqual(mvector0, txvector0, 0.0001f);
        }

        [TestCompiler]
        public static void affine_transform_transform_point()
        {
            float4x4 m = float4x4(TestMatrix.test3x3_zyx, float3(1f, 2f, 3f));
            AffineTransform tx = AffineTransform(m);

            float3 pt = float3(1.1f, -2.2f, 3.5f);

            float3 mPt0 = transform(m, pt);
            float3 txPt0 = transform(tx, pt);
            TestUtils.AreEqual(mPt0, txPt0, 0.0001f);
        }

        [TestCompiler]
        public static void affine_transform_zero()
        {
            TestUtils.AreEqual(float3x3.zero, AffineTransform.zero.rs);
            TestUtils.AreEqual(float3.zero, AffineTransform.zero.t);
        }
    }
}
