// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat2
    {
        [Test]
        public void float2_constructor()
        {
            float2 a = new float2(1, 2);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
        }

        [Test]
        public void float2_scalar_constructor()
        {
            float2 a = new float2(17.0f);
            Assert.AreEqual(a.x, 17.0f);
            Assert.AreEqual(a.y, 17.0f);
        }

        [Test]
        public void float2_static_constructor()
        {
            float2 a = float2(1, 2);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
        }

        [Test]
        public void float2_static_scalar_constructor()
        {
            float2 a = float2(17.0f);
            Assert.AreEqual(a.x, 17.0f);
            Assert.AreEqual(a.y, 17.0f);
        }

        [Test]
        public void float2_operator_equal_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2_operator_equal_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2_operator_equal_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2_operator_not_equal_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2_operator_not_equal_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2_operator_not_equal_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2_operator_less_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2_operator_less_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2_operator_less_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2_operator_greater_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2_operator_greater_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2_operator_greater_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2_operator_less_equal_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2_operator_less_equal_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2_operator_less_equal_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2_operator_greater_equal_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2_operator_greater_equal_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2_operator_greater_equal_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2_operator_add_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            float2 r0 = float2(428.3844f, -220.020386f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            float2 r1 = float2(631.607361f, 183.043823f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            float2 r2 = float2(-13.4547424f, -244.657867f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            float2 r3 = float2(190.987427f, 408.097778f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2_operator_add_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            float2 r0 = float2(428.3844f, 489.931274f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            float2 r1 = float2(108.00824f, 631.607361f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            float2 r2 = float2(183.043823f, -133.509888f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            float2 r3 = float2(-308.1643f, -244.657867f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2_operator_add_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            float2 r0 = float2(428.3844f, 215.390259f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            float2 r1 = float2(108.00824f, -193.378784f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            float2 r2 = float2(183.043823f, 684.8098f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            float2 r3 = float2(-308.1643f, -331.659149f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2_operator_sub_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            float2 r0 = float2(-274.541016f, 496.95752f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            float2 r1 = float2(301.387024f, 818.3197f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            float2 r2 = float2(381.710846f, 23.4948425f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            float2 r3 = float2(102.30835f, -280.519775f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2_operator_sub_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            float2 r0 = float2(-274.541016f, -212.994141f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            float2 r1 = float2(-824.986145f, -301.387024f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            float2 r2 = float2(818.3197f, 501.766f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            float2 r3 = float2(-87.00128f, -23.4948425f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2_operator_sub_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            float2 r0 = float2(-274.541016f, -61.546875f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            float2 r1 = float2(-824.986145f, -523.5991f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            float2 r2 = float2(818.3197f, 316.5537f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            float2 r3 = float2(-87.00128f, -63.50644f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2_operator_mul_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            float2 r0 = float2(27035.1055f, -49639.4531f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            float2 r1 = float2(77023.43f, -159035.516f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            float2 r2 = float2(-36380.5352f, 14826.3662f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            float2 r3 = float2(6502.3f, 21963.1133f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2_operator_mul_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            float2 r0 = float2(27035.1055f, 48666.54f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            float2 r1 = float2(-167234.1f, 77023.43f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            float2 r2 = float2(-159035.516f, -58486.0547f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            float2 r3 = float2(21849.0039f, 14826.3662f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2_operator_mul_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            float2 r0 = float2(27035.1055f, 10651.2363f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            float2 r1 = float2(-167234.1f, -59190.17f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            float2 r2 = float2(-159035.516f, 92189.5547f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            float2 r3 = float2(21849.0039f, 26491.1816f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2_operator_div_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            float2 r0 = float2(0.21886161f, -0.386256158f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            float2 r1 = float2(2.82536936f, -1.57626557f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            float2 r2 = float2(-0.931903243f, 0.8247652f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            float2 r3 = float2(3.30738425f, 0.185266852f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2_operator_div_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            float2 r0 = float2(0.21886161f, 0.39397797f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            float2 r1 = float2(-0.7684697f, 0.353936046f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            float2 r2 = float2(-1.57626557f, -0.579679f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            float2 r3 = float2(1.78676152f, 1.21246624f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2_operator_div_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            float2 r0 = float2(0.21886161f, 0.5555174f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            float2 r1 = float2(-0.7684697f, -2.17121053f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            float2 r2 = float2(-1.57626557f, 2.71920419f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            float2 r3 = float2(1.78676152f, 1.4736588f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2_operator_mod_wide_wide()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 b0 = float2(351.4627f, -358.488953f);
            float2 r0 = float2(76.92169f, 138.468567f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2 a1 = float2(466.4972f, 500.681763f);
            float2 b1 = float2(165.110168f, -317.637939f);
            float2 r1 = float2(136.276855f, 183.043823f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2 a2 = float2(184.128052f, -110.581512f);
            float2 b2 = float2(-197.5828f, -134.076355f);
            float2 r2 = float2(184.128052f, -110.581512f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2 a3 = float2(146.647888f, 63.789f);
            float2 b3 = float2(44.33954f, 344.308777f);
            float2 r3 = float2(13.6292725f, 63.789f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2_operator_mod_wide_scalar()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float b0 = (351.4627f);
            float2 r0 = float2(76.92169f, 138.468567f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float b1 = (466.4972f);
            float2 r1 = float2(-358.488953f, 165.110168f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float b2 = (-317.637939f);
            float2 r2 = float2(183.043823f, 184.128052f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float b3 = (-110.581512f);
            float2 r3 = float2(-87.00128f, -23.4948425f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2_operator_mod_scalar_wide()
        {
            float a0 = (76.92169f);
            float2 b0 = float2(351.4627f, 138.468567f);
            float2 r0 = float2(76.92169f, 76.92169f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (-358.488953f);
            float2 b1 = float2(466.4972f, 165.110168f);
            float2 r1 = float2(-358.488953f, -28.2686157f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (500.681763f);
            float2 b2 = float2(-317.637939f, 184.128052f);
            float2 r2 = float2(183.043823f, 132.425659f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-197.5828f);
            float2 b3 = float2(-110.581512f, -134.076355f);
            float2 r3 = float2(-87.00128f, -63.50644f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2_operator_plus()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 r0 = float2(76.92169f, 138.468567f);
            TestUtils.AreEqual(+a0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float2 r1 = float2(-358.488953f, 165.110168f);
            TestUtils.AreEqual(+a1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float2 r2 = float2(500.681763f, 184.128052f);
            TestUtils.AreEqual(+a2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float2 r3 = float2(-197.5828f, -134.076355f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float2_operator_neg()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 r0 = float2(-76.92169f, -138.468567f);
            TestUtils.AreEqual(-a0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float2 r1 = float2(358.488953f, -165.110168f);
            TestUtils.AreEqual(-a1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float2 r2 = float2(-500.681763f, -184.128052f);
            TestUtils.AreEqual(-a2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float2 r3 = float2(197.5828f, 134.076355f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float2_operator_prefix_inc()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 r0 = float2(77.92169f, 139.468567f);
            TestUtils.AreEqual(++a0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float2 r1 = float2(-357.488953f, 166.110168f);
            TestUtils.AreEqual(++a1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float2 r2 = float2(501.681763f, 185.128052f);
            TestUtils.AreEqual(++a2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float2 r3 = float2(-196.5828f, -133.076355f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float2_operator_postfix_inc()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 r0 = float2(76.92169f, 138.468567f);
            TestUtils.AreEqual(a0++, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float2 r1 = float2(-358.488953f, 165.110168f);
            TestUtils.AreEqual(a1++, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float2 r2 = float2(500.681763f, 184.128052f);
            TestUtils.AreEqual(a2++, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float2 r3 = float2(-197.5828f, -134.076355f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float2_operator_prefix_dec()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 r0 = float2(75.92169f, 137.468567f);
            TestUtils.AreEqual(--a0, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float2 r1 = float2(-359.488953f, 164.110168f);
            TestUtils.AreEqual(--a1, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float2 r2 = float2(499.681763f, 183.128052f);
            TestUtils.AreEqual(--a2, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float2 r3 = float2(-198.5828f, -135.076355f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float2_operator_postfix_dec()
        {
            float2 a0 = float2(76.92169f, 138.468567f);
            float2 r0 = float2(76.92169f, 138.468567f);
            TestUtils.AreEqual(a0--, r0);

            float2 a1 = float2(-358.488953f, 165.110168f);
            float2 r1 = float2(-358.488953f, 165.110168f);
            TestUtils.AreEqual(a1--, r1);

            float2 a2 = float2(500.681763f, 184.128052f);
            float2 r2 = float2(500.681763f, 184.128052f);
            TestUtils.AreEqual(a2--, r2);

            float2 a3 = float2(-197.5828f, -134.076355f);
            float2 r3 = float2(-197.5828f, -134.076355f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
