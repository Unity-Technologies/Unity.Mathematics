// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat3x3
    {
        [Test]
        public void float3x3_operator_equal_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float3x3_operator_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float3x3_operator_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float3x3_operator_not_equal_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float3x3_operator_not_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float3x3_operator_not_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float3x3_operator_less_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            bool3x3 r0 = bool3x3(false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            bool3x3 r3 = bool3x3(false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float3x3_operator_less_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            bool3x3 r2 = bool3x3(false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float3x3_operator_less_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            bool3x3 r2 = bool3x3(false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            bool3x3 r0 = bool3x3(true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            bool3x3 r3 = bool3x3(true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            bool3x3 r2 = bool3x3(true, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            bool3x3 r2 = bool3x3(true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float3x3_operator_less_equal_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            bool3x3 r0 = bool3x3(false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            bool3x3 r3 = bool3x3(false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float3x3_operator_less_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            bool3x3 r2 = bool3x3(false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float3x3_operator_less_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            bool3x3 r2 = bool3x3(false, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_equal_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            bool3x3 r0 = bool3x3(true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            bool3x3 r3 = bool3x3(true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_equal_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            bool3x3 r2 = bool3x3(true, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float3x3_operator_greater_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            bool3x3 r2 = bool3x3(true, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float3x3_operator_add_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            float3x3 r0 = float3x3(483.171326f, 393.2478f, -181.308655f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            float3x3 r1 = float3x3(-640.3981f, -136.862335f, 41.1605835f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            float3x3 r2 = float3x3(522.047852f, 604.587158f, -482.2752f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            float3x3 r3 = float3x3(-20.1216431f, -17.9729f, 973.4151f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float3x3_operator_add_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            float3x3 r0 = float3x3(483.171326f, 365.521118f, 105.393311f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            float3x3 r1 = float3x3(-181.308655f, -203.305511f, -142.988892f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            float3x3 r2 = float3x3(-136.862335f, -627.953369f, 69.1842957f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            float3x3 r3 = float3x3(522.047852f, 644.3299f, 712.66095f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float3x3_operator_add_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(483.171326f, 771.0258f, 510.898f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-181.308655f, -678.7178f, -618.4012f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(-136.862335f, -164.886047f, 532.2516f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(522.047852f, 413.97406f, 482.3051f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float3x3_operator_sub_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            float3x3 r0 = float3x3(405.5047f, 260.1278f, -475.4123f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            float3x3 r1 = float3x3(-60.31662f, 463.0673f, -697.137634f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            float3x3 r2 = float3x3(-230.355835f, -68.3310547f, -219.201965f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            float3x3 r3 = float3x3(829.977f, -473.331055f, -46.7383423f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float3x3_operator_sub_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            float3x3 r0 = float3x3(405.5047f, 287.8545f, 27.7266846f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            float3x3 r1 = float3x3(-475.4123f, -497.409149f, -437.092529f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            float3x3 r2 = float3x3(463.0673f, -28.0237122f, 669.1139f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            float3x3 r3 = float3x3(-230.355835f, -108.073792f, -39.7427368f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float3x3_operator_sub_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(405.5047f, 117.650208f, 377.778f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-475.4123f, 21.9968567f, -38.3197632f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(463.0673f, 491.091f, -206.046631f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(-230.355835f, -122.282043f, -190.6131f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float3x3_operator_mul_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            float3x3 r0 = float3x3(17255.1172f, 21744.34f, -48286.0039f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            float3x3 r1 = float3x3(101617.891f, -48925.0039f, -121076.672f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            float3x3 r2 = float3x3(54867.54f, 90214.125f, 46134.97f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            float3x3 r3 = float3x3(-172114.234f, -55929.8164f, 236338.125f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float3x3_operator_mul_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            float3x3 r0 = float3x3(17255.1172f, 12686.37f, 2584.745f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            float3x3 r1 = float3x3(-48286.0039f, -51520.6836f, -42651.0156f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            float3x3 r2 = float3x3(-48925.0039f, 98385.0156f, -110731.742f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            float3x3 r3 = float3x3(54867.54f, 100870.266f, 126576.539f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float3x3_operator_mul_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(17255.1172f, 145159.813f, 29575.1367f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-48286.0039f, 115043.5f, 95237.91f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(-48925.0039f, -53495.7422f, 60209.1328f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(54867.54f, 39105.4063f, 49071.22f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float3x3_operator_div_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            float3x3 r0 = float3x3(11.4421864f, 4.90817f, -2.2329576f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            float3x3 r1 = float3x3(1.20795918f, -0.5437387f, -0.8884988f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            float3x3 r2 = float3x3(0.3876802f, 0.79691124f, 2.666471f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            float3x3 r3 = float3x3(-0.952660441f, -1.07893968f, 0.908369958f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float3x3_operator_div_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            float3x3 r0 = float3x3(11.4421864f, 8.412566f, 1.71399224f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            float3x3 r1 = float3x3(-2.2329576f, -2.38254333f, -1.97237074f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            float3x3 r2 = float3x3(-0.5437387f, 1.09342337f, -1.23064137f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            float3x3 r3 = float3x3(0.3876802f, 0.7127239f, 0.8943579f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float3x3_operator_div_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(11.4421864f, 1.36013043f, 6.67575169f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-2.2329576f, 0.9372159f, 1.13211858f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(-0.5437387f, -0.497281045f, 0.4418336f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(0.3876802f, 0.5439416f, 0.4334732f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float3x3_operator_mod_wide_wide()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, -328.360474f);
            float3x3 b0 = float3x3(38.833313f, 66.56f, 147.051819f);
            float3x3 r0 = float3x3(17.17157f, 60.4478149f, -34.2568359f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3x3 a1 = float3x3(-350.35733f, 163.102478f, -327.988525f);
            float3x3 b1 = float3x3(-290.0407f, -299.9648f, 369.1491f);
            float3x3 r1 = float3x3(-60.31662f, 163.102478f, -327.988525f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3x3 a2 = float3x3(145.846008f, 268.128052f, -350.7386f);
            float3x3 b2 = float3x3(376.201843f, 336.4591f, -131.536621f);
            float3x3 r2 = float3x3(145.846008f, 268.128052f, -87.6653442f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3x3 a3 = float3x3(404.927673f, -245.651978f, 463.338379f);
            float3x3 b3 = float3x3(-425.049316f, 227.679077f, 510.076721f);
            float3x3 r3 = float3x3(404.927673f, -17.9729f, 463.338379f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float3x3_operator_mod_wide_scalar()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float b0 = (38.833313f);
            float3x3 r0 = float3x3(17.17157f, 16.0213013f, 27.7266846f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float b1 = (147.051819f);
            float3x3 r1 = float3x3(-34.2568359f, -56.2536926f, -142.988892f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float b2 = (-299.9648f);
            float3x3 r2 = float3x3(163.102478f, -28.0237122f, 69.1842957f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float b3 = (376.201843f);
            float3x3 r3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float3x3_operator_mod_scalar_wide()
        {
            float a0 = (444.338f);
            float3x3 b0 = float3x3(38.833313f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(17.17157f, 117.650208f, 44.9780273f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (-328.360474f);
            float3x3 b1 = float3x3(147.051819f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-34.2568359f, -328.360474f, -38.3197632f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (163.102478f);
            float3x3 b2 = float3x3(-299.9648f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(163.102478f, 163.102478f, 163.102478f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (145.846008f);
            float3x3 b3 = float3x3(376.201843f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(145.846008f, 145.846008f, 145.846008f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float3x3_operator_plus()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(444.338f, 326.6878f, 66.56f);
            TestUtils.AreEqual(+a0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            TestUtils.AreEqual(+a1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            TestUtils.AreEqual(+a2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float3x3_operator_neg()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(-444.338f, -326.6878f, -66.56f);
            TestUtils.AreEqual(-a0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(328.360474f, 350.35733f, 290.0407f);
            TestUtils.AreEqual(-a1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(-163.102478f, 327.988525f, -369.1491f);
            TestUtils.AreEqual(-a2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(-145.846008f, -268.128052f, -336.4591f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float3x3_operator_prefix_inc()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(445.338f, 327.6878f, 67.56f);
            TestUtils.AreEqual(++a0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-327.360474f, -349.35733f, -289.0407f);
            TestUtils.AreEqual(++a1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(164.102478f, -326.988525f, 370.1491f);
            TestUtils.AreEqual(++a2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(146.846008f, 269.128052f, 337.4591f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float3x3_operator_postfix_inc()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(444.338f, 326.6878f, 66.56f);
            TestUtils.AreEqual(a0++, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            TestUtils.AreEqual(a1++, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            TestUtils.AreEqual(a2++, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float3x3_operator_prefix_dec()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(443.338f, 325.6878f, 65.56f);
            TestUtils.AreEqual(--a0, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-329.360474f, -351.35733f, -291.0407f);
            TestUtils.AreEqual(--a1, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(162.102478f, -328.988525f, 368.1491f);
            TestUtils.AreEqual(--a2, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(144.846008f, 267.128052f, 335.4591f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float3x3_operator_postfix_dec()
        {
            float3x3 a0 = float3x3(444.338f, 326.6878f, 66.56f);
            float3x3 r0 = float3x3(444.338f, 326.6878f, 66.56f);
            TestUtils.AreEqual(a0--, r0);

            float3x3 a1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            float3x3 r1 = float3x3(-328.360474f, -350.35733f, -290.0407f);
            TestUtils.AreEqual(a1--, r1);

            float3x3 a2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            float3x3 r2 = float3x3(163.102478f, -327.988525f, 369.1491f);
            TestUtils.AreEqual(a2--, r2);

            float3x3 a3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            float3x3 r3 = float3x3(145.846008f, 268.128052f, 336.4591f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
