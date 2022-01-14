using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestAffineTransform
    {
        [TestCompiler]
        public static void affine_transform_inverse()
        {
            const float tolerance = 1e-6f;

            var tx = AffineTransform(float3(5, 6, 7), normalize(math.float4(1, 2, 3, 4)), float3(2, 3, 4));
            var invTx = inverse(tx);

            TestUtils.AreEqual(float4x4.identity, mul(tx, invTx), tolerance);
        }

        [TestCompiler]
        public static void affine_transform_inverse_zero_rs_returns_zero()
        {
            const float tolerance = 1e-30f;

            var tx = AffineTransform(float3(5, 6, 7), normalize(float4(1, 2, 3, 4)), float3.zero);
            var invTx = inverse(tx);

            TestUtils.AreEqual(float3x4.zero, invTx, tolerance);
        }

        [TestCompiler]
        public static void affine_transform_inverse_pico_scale()
        {
            // slightly larger tolerance (vs 1e-6f) for PS4
            const float tolerance = 2e-6f;

            var tx = AffineTransform(float3(5, 6, 7), normalize(float4(1, 2, 3, 4)), float3(1e-12f, 1e-12f, 1e-12f));
            var invTx = inverse(tx);

            TestUtils.AreEqual(float4x4.identity, mul(tx, invTx), tolerance);
        }

        [TestCompiler]
        public static void affine_transform_inverse_singular()
        {
            // it needs a bit larger tolerance for singular
            // since it uses the svd iterative solver
            const float tolerance = 1e-1f;

            var tx = AffineTransform(float3(5, 6, 7), normalize(float4(1, 2, 3, 4)), float3(0, 3, 4));
            var invTx = inverse(tx);

            // pseudo inverse penrose #1 test
            var testTx = mul(mul(tx, invTx), tx);
            TestUtils.AreEqual(float4x4(tx), float4x4(testTx), tolerance);
        }

        [TestCompiler]
        public static void affine_transform_decompose()
        {
            const float tolerance = 1e-6f;

            var tx = AffineTransform(float3(5, 6, 7), normalize(float4(1, 2, 3, 4)), float3(2, 3, 4));
            decompose(tx, out var t, out var r, out var s);

            // Recompose matrix
            var testTx = AffineTransform(t, r, s);
            TestUtils.AreEqual(float4x4(tx), float4x4(testTx), tolerance);
        }
    }
}