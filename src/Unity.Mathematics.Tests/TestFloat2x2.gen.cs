// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat2x2
    {
        [Test]
        public void float2x2_operator_equal_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2x2_operator_equal_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2x2_operator_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2x2_operator_not_equal_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2x2_operator_not_equal_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2x2_operator_not_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2x2_operator_less_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            bool2x2 r2 = bool2x2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2x2_operator_less_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            bool2x2 r2 = bool2x2(true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2x2_operator_less_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            bool2x2 r3 = bool2x2(false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            bool2x2 r2 = bool2x2(true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            bool2x2 r2 = bool2x2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            bool2x2 r3 = bool2x2(true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2x2_operator_less_equal_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            bool2x2 r2 = bool2x2(false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2x2_operator_less_equal_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            bool2x2 r2 = bool2x2(true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2x2_operator_less_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            bool2x2 r3 = bool2x2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_equal_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            bool2x2 r2 = bool2x2(true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_equal_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            bool2x2 r2 = bool2x2(false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            bool2x2 r3 = bool2x2(true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2x2_operator_add_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            float2x2 r0 = float2x2(483.171326f, 393.2478f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            float2x2 r1 = float2x2(-181.308655f, -640.3981f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            float2x2 r2 = float2x2(-136.862335f, 41.1605835f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            float2x2 r3 = float2x2(522.047852f, 604.587158f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2x2_operator_add_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            float2x2 r0 = float2x2(483.171326f, 365.521118f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            float2x2 r1 = float2x2(-261.800476f, -181.308655f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            float2x2 r2 = float2x2(-640.3981f, -126.938232f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            float2x2 r3 = float2x2(-627.953369f, 41.1605835f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2x2_operator_add_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            float2x2 r0 = float2x2(483.171326f, 771.0258f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            float2x2 r1 = float2x2(-261.800476f, 213.611816f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            float2x2 r2 = float2x2(-640.3981f, -187.254852f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            float2x2 r3 = float2x2(-627.953369f, 69.1842957f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2x2_operator_sub_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            float2x2 r0 = float2x2(405.5047f, 260.1278f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            float2x2 r1 = float2x2(-475.4123f, -60.31662f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            float2x2 r2 = float2x2(463.0673f, -697.137634f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            float2x2 r3 = float2x2(-230.355835f, -68.3310547f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2x2_operator_sub_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            float2x2 r0 = float2x2(405.5047f, 287.8545f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            float2x2 r1 = float2x2(394.920471f, 475.4123f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            float2x2 r2 = float2x2(-60.31662f, 453.1432f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            float2x2 r3 = float2x2(28.0237122f, 697.137634f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2x2_operator_sub_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            float2x2 r0 = float2x2(405.5047f, 117.650208f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            float2x2 r1 = float2x2(394.920471f, -80.49182f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            float2x2 r2 = float2x2(-60.31662f, -513.459839f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            float2x2 r3 = float2x2(28.0237122f, -669.1139f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2x2_operator_mul_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            float2x2 r0 = float2x2(17255.1172f, 21744.34f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            float2x2 r1 = float2x2(-48286.0039f, 101617.891f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            float2x2 r2 = float2x2(-48925.0039f, -121076.672f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            float2x2 r3 = float2x2(54867.54f, 90214.125f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2x2_operator_mul_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            float2x2 r0 = float2x2(17255.1172f, 12686.37f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            float2x2 r1 = float2x2(-21855.6719f, -48286.0039f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            float2x2 r2 = float2x2(101617.891f, -47306.36f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            float2x2 r3 = float2x2(98385.0156f, -121076.672f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2x2_operator_mul_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            float2x2 r0 = float2x2(17255.1172f, 145159.813f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            float2x2 r1 = float2x2(-21855.6719f, 9787.769f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            float2x2 r2 = float2x2(101617.891f, -57144.15f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            float2x2 r3 = float2x2(98385.0156f, -110731.742f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2x2_operator_div_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            float2x2 r0 = float2x2(11.4421864f, 4.90817f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            float2x2 r1 = float2x2(-2.2329576f, 1.20795918f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            float2x2 r2 = float2x2(-0.5437387f, -0.8884988f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            float2x2 r3 = float2x2(0.3876802f, 0.79691124f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2x2_operator_div_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            float2x2 r0 = float2x2(11.4421864f, 8.412566f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            float2x2 r1 = float2x2(-0.202704042f, -0.447836548f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            float2x2 r2 = float2x2(1.20795918f, -0.5623434f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            float2x2 r3 = float2x2(0.9145589f, -1.125494f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2x2_operator_div_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            float2x2 r0 = float2x2(11.4421864f, 1.36013043f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            float2x2 r1 = float2x2(-0.202704042f, 0.452629536f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            float2x2 r2 = float2x2(1.20795918f, -2.148081f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            float2x2 r3 = float2x2(0.9145589f, -0.8125844f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2x2_operator_mod_wide_wide()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 b0 = float2x2(38.833313f, 66.56f);
            float2x2 r0 = float2x2(17.17157f, 60.4478149f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x2 a1 = float2x2(-328.360474f, -350.35733f);
            float2x2 b1 = float2x2(147.051819f, -290.0407f);
            float2x2 r1 = float2x2(-34.2568359f, -60.31662f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x2 a2 = float2x2(163.102478f, -327.988525f);
            float2x2 b2 = float2x2(-299.9648f, 369.1491f);
            float2x2 r2 = float2x2(163.102478f, -327.988525f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x2 a3 = float2x2(145.846008f, 268.128052f);
            float2x2 b3 = float2x2(376.201843f, 336.4591f);
            float2x2 r3 = float2x2(145.846008f, 268.128052f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2x2_operator_mod_wide_scalar()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float b0 = (38.833313f);
            float2x2 r0 = float2x2(17.17157f, 16.0213013f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float b1 = (-328.360474f);
            float2x2 r1 = float2x2(66.56f, 147.051819f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float b2 = (-290.0407f);
            float2x2 r2 = float2x2(-60.31662f, 163.102478f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float b3 = (-327.988525f);
            float2x2 r3 = float2x2(-299.9648f, 41.1605835f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2x2_operator_mod_scalar_wide()
        {
            float a0 = (444.338f);
            float2x2 b0 = float2x2(38.833313f, 326.6878f);
            float2x2 r0 = float2x2(17.17157f, 117.650208f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (66.56f);
            float2x2 b1 = float2x2(-328.360474f, 147.051819f);
            float2x2 r1 = float2x2(66.56f, 66.56f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (-350.35733f);
            float2x2 b2 = float2x2(-290.0407f, 163.102478f);
            float2x2 r2 = float2x2(-60.31662f, -24.1523743f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-299.9648f);
            float2x2 b3 = float2x2(-327.988525f, 369.1491f);
            float2x2 r3 = float2x2(-299.9648f, -299.9648f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2x2_operator_plus()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 r0 = float2x2(444.338f, 326.6878f);
            TestUtils.AreEqual(+a0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float2x2 r1 = float2x2(66.56f, 147.051819f);
            TestUtils.AreEqual(+a1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float2x2 r2 = float2x2(-350.35733f, 163.102478f);
            TestUtils.AreEqual(+a2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float2x2 r3 = float2x2(-299.9648f, 369.1491f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float2x2_operator_neg()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 r0 = float2x2(-444.338f, -326.6878f);
            TestUtils.AreEqual(-a0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float2x2 r1 = float2x2(-66.56f, -147.051819f);
            TestUtils.AreEqual(-a1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float2x2 r2 = float2x2(350.35733f, -163.102478f);
            TestUtils.AreEqual(-a2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float2x2 r3 = float2x2(299.9648f, -369.1491f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float2x2_operator_prefix_inc()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 r0 = float2x2(445.338f, 327.6878f);
            TestUtils.AreEqual(++a0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float2x2 r1 = float2x2(67.56f, 148.051819f);
            TestUtils.AreEqual(++a1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float2x2 r2 = float2x2(-349.35733f, 164.102478f);
            TestUtils.AreEqual(++a2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float2x2 r3 = float2x2(-298.9648f, 370.1491f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float2x2_operator_postfix_inc()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 r0 = float2x2(444.338f, 326.6878f);
            TestUtils.AreEqual(a0++, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float2x2 r1 = float2x2(66.56f, 147.051819f);
            TestUtils.AreEqual(a1++, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float2x2 r2 = float2x2(-350.35733f, 163.102478f);
            TestUtils.AreEqual(a2++, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float2x2 r3 = float2x2(-299.9648f, 369.1491f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float2x2_operator_prefix_dec()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 r0 = float2x2(443.338f, 325.6878f);
            TestUtils.AreEqual(--a0, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float2x2 r1 = float2x2(65.56f, 146.051819f);
            TestUtils.AreEqual(--a1, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float2x2 r2 = float2x2(-351.35733f, 162.102478f);
            TestUtils.AreEqual(--a2, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float2x2 r3 = float2x2(-300.9648f, 368.1491f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float2x2_operator_postfix_dec()
        {
            float2x2 a0 = float2x2(444.338f, 326.6878f);
            float2x2 r0 = float2x2(444.338f, 326.6878f);
            TestUtils.AreEqual(a0--, r0);

            float2x2 a1 = float2x2(66.56f, 147.051819f);
            float2x2 r1 = float2x2(66.56f, 147.051819f);
            TestUtils.AreEqual(a1--, r1);

            float2x2 a2 = float2x2(-350.35733f, 163.102478f);
            float2x2 r2 = float2x2(-350.35733f, 163.102478f);
            TestUtils.AreEqual(a2--, r2);

            float2x2 a3 = float2x2(-299.9648f, 369.1491f);
            float2x2 r3 = float2x2(-299.9648f, 369.1491f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
