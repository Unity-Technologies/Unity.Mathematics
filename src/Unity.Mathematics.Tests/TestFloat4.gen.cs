// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat4
    {
        [Test]
        public void float4_constructor()
        {
            float4 a = new float4(1, 2, 3, 4);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
            Assert.AreEqual(a.w, 4);
        }

        [Test]
        public void float4_scalar_constructor()
        {
            float4 a = new float4(17.0f);
            Assert.AreEqual(a.x, 17.0f);
            Assert.AreEqual(a.y, 17.0f);
            Assert.AreEqual(a.z, 17.0f);
            Assert.AreEqual(a.w, 17.0f);
        }

        [Test]
        public void float4_static_constructor()
        {
            float4 a = float4(1, 2, 3, 4);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
            Assert.AreEqual(a.w, 4);
        }

        [Test]
        public void float4_static_scalar_constructor()
        {
            float4 a = float4(17.0f);
            Assert.AreEqual(a.x, 17.0f);
            Assert.AreEqual(a.y, 17.0f);
            Assert.AreEqual(a.z, 17.0f);
            Assert.AreEqual(a.w, 17.0f);
        }

        [Test]
        public void float4_operator_equal_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4_operator_equal_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4_operator_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4_operator_not_equal_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4_operator_not_equal_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4_operator_not_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4_operator_less_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            bool4 r0 = bool4(false, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            bool4 r1 = bool4(false, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            bool4 r2 = bool4(true, false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            bool4 r3 = bool4(false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4_operator_less_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            bool4 r0 = bool4(false, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            bool4 r2 = bool4(true, true, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4_operator_less_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            bool4 r1 = bool4(false, false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4_operator_greater_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            bool4 r0 = bool4(true, true, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            bool4 r1 = bool4(true, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            bool4 r3 = bool4(true, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4_operator_greater_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            bool4 r0 = bool4(true, true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            bool4 r2 = bool4(false, false, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            bool4 r3 = bool4(true, true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4_operator_greater_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            bool4 r1 = bool4(true, true, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4_operator_less_equal_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            bool4 r0 = bool4(false, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            bool4 r1 = bool4(false, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            bool4 r2 = bool4(true, false, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            bool4 r3 = bool4(false, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4_operator_less_equal_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            bool4 r0 = bool4(false, false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            bool4 r2 = bool4(true, true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4_operator_less_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            bool4 r1 = bool4(false, false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4_operator_greater_equal_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            bool4 r0 = bool4(true, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            bool4 r1 = bool4(true, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            bool4 r3 = bool4(true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4_operator_greater_equal_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            bool4 r0 = bool4(true, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            bool4 r2 = bool4(false, false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            bool4 r3 = bool4(true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4_operator_greater_equal_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            bool4 r1 = bool4(true, true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4_operator_add_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            float4 r0 = float4(483.171326f, 393.2478f, -181.308655f, -640.3981f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            float4 r1 = float4(-136.862335f, 41.1605835f, 522.047852f, 604.587158f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            float4 r2 = float4(-482.2752f, -20.1216431f, -17.9729f, 973.4151f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            float4 r3 = float4(-33.1558228f, 215.716614f, 15.1571045f, -362.7381f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4_operator_add_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            float4 r0 = float4(483.171326f, 365.521118f, 105.393311f, -289.527161f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            float4 r1 = float4(-203.305511f, -640.3981f, -187.254852f, -650.322144f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            float4 r2 = float4(41.1605835f, 514.9951f, 745.350952f, 637.277161f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            float4 r3 = float4(-14.27948f, -482.2752f, 54.1890869f, -775.7879f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4_operator_add_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(483.171326f, 771.0258f, 510.898f, 115.977539f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(-203.305511f, -142.988892f, 310.1543f, -152.913f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(41.1605835f, -182.142517f, 48.2133179f, -59.8604736f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(-14.27948f, 204.922485f, 741.3868f, -88.59021f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4_operator_sub_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            float4 r0 = float4(405.5047f, 260.1278f, -475.4123f, -60.31662f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            float4 r1 = float4(463.0673f, -697.137634f, -230.355835f, -68.3310547f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            float4 r2 = float4(-219.201965f, 829.977f, -473.331055f, -46.7383423f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            float4 r3 = float4(532.7016f, -89.5202f, -851.520752f, 144.913574f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4_operator_sub_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            float4 r0 = float4(405.5047f, 287.8545f, 27.7266846f, -367.1938f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            float4 r1 = float4(497.409149f, 60.31662f, 513.459839f, 50.3925171f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            float4 r2 = float4(-697.137634f, -223.3031f, 7.05273438f, -101.021057f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            float4 r3 = float4(687.1977f, 219.201965f, 755.66626f, -74.31073f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4_operator_sub_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(405.5047f, 117.650208f, 377.778f, 772.6985f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(497.409149f, 437.092529f, -16.05066f, 447.016632f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(-697.137634f, -473.834534f, -704.190369f, -596.1166f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(687.1977f, 467.995728f, -68.46857f, 761.5084f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4_operator_mul_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            float4 r0 = float4(17255.1172f, 21744.34f, -48286.0039f, 101617.891f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            float4 r1 = float4(-48925.0039f, -121076.672f, 54867.54f, 90214.125f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            float4 r2 = float4(46134.97f, -172114.234f, -55929.8164f, 236338.125f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            float4 r3 = float4(-70667.92f, 9629.947f, -181214.469f, 27644.7461f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4_operator_mul_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            float4 r0 = float4(17255.1172f, 12686.37f, 2584.745f, -12751.3252f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            float4 r1 = float4(-51520.6836f, 101617.891f, -57144.15f, 105094.875f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            float4 r2 = float4(-121076.672f, 53838.9258f, 138874.578f, 98979.2344f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            float4 r3 = float4(-118009.188f, 46134.97f, -142023.766f, 149081.2f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4_operator_mul_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(17255.1172f, 145159.813f, 29575.1367f, -145903.047f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(-51520.6836f, -42651.0156f, 23984.5156f, -44110.37f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(-121076.672f, -47835.8164f, -123389.891f, -87942.92f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(-118009.188f, -44256.6953f, 136241.609f, -143011.719f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4_operator_div_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            float4 r0 = float4(11.4421864f, 4.90817f, -2.2329576f, 1.20795918f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            float4 r1 = float4(-0.5437387f, -0.8884988f, 0.3876802f, 0.79691124f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            float4 r2 = float4(2.666471f, -0.952660441f, -1.07893968f, 0.908369958f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            float4 r3 = float4(-0.8828121f, 0.413437724f, -0.9650225f, 0.429082662f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4_operator_div_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            float4 r0 = float4(11.4421864f, 8.412566f, 1.71399224f, -8.455639f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            float4 r1 = float4(-0.419719547f, 0.8278426f, -0.4655318f, 0.8561682f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            float4 r2 = float4(-0.8884988f, 0.395086974f, 1.01910543f, 0.7263408f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            float4 r3 = float4(-0.9592874f, 0.3750275f, -1.15449989f, 1.21186924f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4_operator_div_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(11.4421864f, 1.36013043f, 6.67575169f, -1.35320187f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(-0.419719547f, -0.5070041f, 0.901591539f, -0.490230232f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(-0.8884988f, -2.2488687f, -0.8718419f, -1.22325325f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(-0.9592874f, -2.557912f, 0.830911636f, -0.7915766f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4_operator_mod_wide_wide()
        {
            float4 a0 = float4(444.338f, 326.6878f, -328.360474f, -350.35733f);
            float4 b0 = float4(38.833313f, 66.56f, 147.051819f, -290.0407f);
            float4 r0 = float4(17.17157f, 60.4478149f, -34.2568359f, -60.31662f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4 a1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            float4 b1 = float4(-299.9648f, 369.1491f, 376.201843f, 336.4591f);
            float4 r1 = float4(163.102478f, -327.988525f, 145.846008f, 268.128052f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4 a2 = float4(-350.7386f, 404.927673f, -245.651978f, 463.338379f);
            float4 b2 = float4(-131.536621f, -425.049316f, 227.679077f, 510.076721f);
            float4 r2 = float4(-87.6653442f, 404.927673f, -17.9729f, 463.338379f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4 a3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            float4 b3 = float4(-282.9287f, 152.618408f, 433.338928f, -253.825836f);
            float4 r3 = float4(249.772888f, 63.0982056f, -418.181824f, -108.912262f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4_operator_mod_wide_scalar()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float b0 = (38.833313f);
            float4 r0 = float4(17.17157f, 16.0213013f, 27.7266846f, -17.69397f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float b1 = (-350.35733f);
            float4 r1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float b2 = (369.1491f);
            float4 r2 = float4(-327.988525f, 145.846008f, 7.05273438f, 268.128052f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float b3 = (-350.7386f);
            float4 r3 = float4(336.4591f, -131.536621f, 54.1890869f, -74.31073f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4_operator_mod_scalar_wide()
        {
            float a0 = (444.338f);
            float4 b0 = float4(38.833313f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(17.17157f, 117.650208f, 44.9780273f, 115.977539f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (147.051819f);
            float4 b1 = float4(-350.35733f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(147.051819f, 147.051819f, 147.051819f, 147.051819f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (-327.988525f);
            float4 b2 = float4(369.1491f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(-327.988525f, -36.29651f, -327.988525f, -59.8604736f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (336.4591f);
            float4 b3 = float4(-350.7386f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(336.4591f, 73.3858643f, 336.4591f, 336.4591f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4_operator_plus()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            TestUtils.AreEqual(+a0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            TestUtils.AreEqual(+a1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            TestUtils.AreEqual(+a2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float4_operator_neg()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(-444.338f, -326.6878f, -66.56f, 328.360474f);
            TestUtils.AreEqual(-a0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(-147.051819f, 290.0407f, -163.102478f, 299.9648f);
            TestUtils.AreEqual(-a1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(327.988525f, -145.846008f, -376.201843f, -268.128052f);
            TestUtils.AreEqual(-a2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(-336.4591f, 131.536621f, -404.927673f, 425.049316f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float4_operator_prefix_inc()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(445.338f, 327.6878f, 67.56f, -327.360474f);
            TestUtils.AreEqual(++a0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(148.051819f, -289.0407f, 164.102478f, -298.9648f);
            TestUtils.AreEqual(++a1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(-326.988525f, 146.846008f, 377.201843f, 269.128052f);
            TestUtils.AreEqual(++a2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(337.4591f, -130.536621f, 405.927673f, -424.049316f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float4_operator_postfix_inc()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            TestUtils.AreEqual(a0++, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            TestUtils.AreEqual(a1++, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            TestUtils.AreEqual(a2++, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float4_operator_prefix_dec()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(443.338f, 325.6878f, 65.56f, -329.360474f);
            TestUtils.AreEqual(--a0, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(146.051819f, -291.0407f, 162.102478f, -300.9648f);
            TestUtils.AreEqual(--a1, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(-328.988525f, 144.846008f, 375.201843f, 267.128052f);
            TestUtils.AreEqual(--a2, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(335.4591f, -132.536621f, 403.927673f, -426.049316f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float4_operator_postfix_dec()
        {
            float4 a0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            float4 r0 = float4(444.338f, 326.6878f, 66.56f, -328.360474f);
            TestUtils.AreEqual(a0--, r0);

            float4 a1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            float4 r1 = float4(147.051819f, -290.0407f, 163.102478f, -299.9648f);
            TestUtils.AreEqual(a1--, r1);

            float4 a2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            float4 r2 = float4(-327.988525f, 145.846008f, 376.201843f, 268.128052f);
            TestUtils.AreEqual(a2--, r2);

            float4 a3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            float4 r3 = float4(336.4591f, -131.536621f, 404.927673f, -425.049316f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
