// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat3
    {
        [Test]
        public void float3_constructor()
        {
            float3 a = new float3(1, 2, 3);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
        }

        [Test]
        public void float3_scalar_constructor()
        {
            float3 a = new float3(17.0f);
            Assert.AreEqual(a.x, 17.0f);
            Assert.AreEqual(a.y, 17.0f);
            Assert.AreEqual(a.z, 17.0f);
        }

        [Test]
        public void float3_static_constructor()
        {
            float3 a = float3(1, 2, 3);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
        }

        [Test]
        public void float3_static_scalar_constructor()
        {
            float3 a = float3(17.0f);
            Assert.AreEqual(a.x, 17.0f);
            Assert.AreEqual(a.y, 17.0f);
            Assert.AreEqual(a.z, 17.0f);
        }

        [Test]
        public void float3_operator_equal_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float3_operator_equal_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float3_operator_equal_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float3_operator_not_equal_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float3_operator_not_equal_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float3_operator_not_equal_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float3_operator_less_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float3_operator_less_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float3_operator_less_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            bool3 r1 = bool3(false, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float3_operator_greater_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            bool3 r2 = bool3(true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float3_operator_greater_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float3_operator_greater_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float3_operator_less_equal_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float3_operator_less_equal_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float3_operator_less_equal_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            bool3 r1 = bool3(false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float3_operator_greater_equal_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            bool3 r2 = bool3(true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float3_operator_greater_equal_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float3_operator_greater_equal_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float3_operator_add_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            float3 r0 = float3(428.3844f, -220.020386f, 631.607361f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            float3 r1 = float3(183.043823f, -13.4547424f, -244.657867f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            float3 r2 = float3(190.987427f, 408.097778f, -119.507172f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            float3 r3 = float3(360.392365f, -70.52023f, -351.24588f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float3_operator_add_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            float3 r0 = float3(428.3844f, 489.931274f, -7.026245f);
            TestUtils.AreEqual(a0 + b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            float3 r1 = float3(631.607361f, 665.791931f, -152.527771f);
            TestUtils.AreEqual(a1 + b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            float3 r2 = float3(-13.4547424f, -308.1643f, -331.659149f);
            TestUtils.AreEqual(a2 + b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            float3 r3 = float3(190.987427f, 108.12854f, 388.648315f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float3_operator_add_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            float3 r0 = float3(428.3844f, 215.390259f, -281.567261f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            float3 r1 = float3(631.607361f, 967.178955f, 148.859253f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            float3 r2 = float3(-13.4547424f, 73.54654f, 50.0516968f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            float3 r3 = float3(190.987427f, 210.43689f, 490.956665f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float3_operator_sub_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            float3 r0 = float3(-274.541016f, 496.95752f, 301.387024f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            float3 r1 = float3(818.3197f, 381.710846f, 23.4948425f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            float3 r2 = float3(102.30835f, -280.519775f, -20.29599f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            float3 r3 = float3(-437.579437f, -678.685547f, -164.0336f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float3_operator_sub_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            float3 r0 = float3(-274.541016f, -212.994141f, -709.95166f);
            TestUtils.AreEqual(a0 - b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            float3 r1 = float3(301.387024f, 335.5716f, -482.7481f);
            TestUtils.AreEqual(a1 - b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            float3 r2 = float3(381.710846f, 87.00128f, 63.50644f);
            TestUtils.AreEqual(a2 - b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            float3 r3 = float3(102.30835f, 19.4494629f, 299.969238f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float3_operator_sub_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            float3 r0 = float3(-274.541016f, -61.546875f, 435.410645f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            float3 r1 = float3(301.387024f, -34.18457f, 784.135132f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            float3 r2 = float3(381.710846f, 294.709564f, 318.2044f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            float3 r3 = float3(102.30835f, 82.85889f, -197.660889f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float3_operator_mul_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            float3 r0 = float3(27035.1055f, -49639.4531f, 77023.43f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            float3 r1 = float3(-159035.516f, -36380.5352f, 14826.3662f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            float3 r2 = float3(6502.3f, 21963.1133f, 3467.50928f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            float3 r3 = float3(-15398.2773f, -113910.234f, 24116.6621f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float3_operator_mul_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            float3 r0 = float3(27035.1055f, 48666.54f, -125995.5f);
            TestUtils.AreEqual(a0 * b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            float3 r1 = float3(77023.43f, 82667.65f, -52445.2539f);
            TestUtils.AreEqual(a1 * b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            float3 r2 = float3(-36380.5352f, 21849.0039f, 26491.1816f);
            TestUtils.AreEqual(a2 * b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            float3 r3 = float3(6502.3f, 2828.375f, 15266.4922f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float3_operator_mul_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            float3 r0 = float3(27035.1055f, 10651.2363f, -27575.5762f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            float3 r1 = float3(77023.43f, 233566.641f, -148177.2f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            float3 r2 = float3(-36380.5352f, -20361.1582f, -24687.2188f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            float3 r3 = float3(6502.3f, 9354.522f, 50492.1563f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float3_operator_div_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            float3 r0 = float3(0.21886161f, -0.386256158f, 2.82536936f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            float3 r1 = float3(-1.57626557f, -0.931903243f, 0.8247652f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            float3 r2 = float3(3.30738425f, 0.185266852f, 1.40914726f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            float3 r3 = float3(-0.09672907f, -1.23191142f, 2.75238085f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float3_operator_div_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            float3 r0 = float3(0.21886161f, 0.39397797f, -1.0199914f);
            TestUtils.AreEqual(a0 / b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            float3 r1 = float3(2.82536936f, 3.03241014f, -1.92379391f);
            TestUtils.AreEqual(a1 / b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            float3 r2 = float3(-0.931903243f, 0.55967176f, 0.678583145f);
            TestUtils.AreEqual(a2 / b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            float3 r3 = float3(3.30738425f, 1.43864834f, 7.76527643f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float3_operator_div_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            float3 r0 = float3(0.21886161f, 0.5555174f, -0.214572f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            float3 r1 = float3(2.82536936f, 0.931723952f, -1.46864438f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            float3 r2 = float3(-0.931903243f, -1.66508889f, -1.37330747f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            float3 r3 = float3(3.30738425f, 2.29895258f, 0.425919682f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float3_operator_mod_wide_wide()
        {
            float3 a0 = float3(76.92169f, 138.468567f, 466.4972f);
            float3 b0 = float3(351.4627f, -358.488953f, 165.110168f);
            float3 r0 = float3(76.92169f, 138.468567f, 136.276855f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3 a1 = float3(500.681763f, 184.128052f, -110.581512f);
            float3 b1 = float3(-317.637939f, -197.5828f, -134.076355f);
            float3 r1 = float3(183.043823f, 184.128052f, -110.581512f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3 a2 = float3(146.647888f, 63.789f, -69.90158f);
            float3 b2 = float3(44.33954f, 344.308777f, -49.60559f);
            float3 r2 = float3(13.6292725f, 63.789f, -20.29599f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3 a3 = float3(-38.5935364f, -374.602875f, -257.63974f);
            float3 b3 = float3(398.9859f, 304.082642f, -93.60614f);
            float3 r3 = float3(-38.5935364f, -70.52023f, -70.42746f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float3_operator_mod_wide_scalar()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float b0 = (351.4627f);
            float3 r0 = float3(76.92169f, 138.468567f, -7.026245f);
            TestUtils.AreEqual(a0 % b0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float b1 = (165.110168f);
            float3 r1 = float3(136.276855f, 5.35125732f, -152.527771f);
            TestUtils.AreEqual(a1 % b1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float b2 = (-197.5828f);
            float3 r2 = float3(184.128052f, -110.581512f, -134.076355f);
            TestUtils.AreEqual(a2 % b2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float b3 = (44.33954f);
            float3 r3 = float3(13.6292725f, 19.4494629f, 33.9320068f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float3_operator_mod_scalar_wide()
        {
            float a0 = (76.92169f);
            float3 b0 = float3(351.4627f, 138.468567f, -358.488953f);
            float3 r0 = float3(76.92169f, 76.92169f, 76.92169f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (466.4972f);
            float3 b1 = float3(165.110168f, 500.681763f, -317.637939f);
            float3 r1 = float3(136.276855f, 466.4972f, 148.859253f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (184.128052f);
            float3 b2 = float3(-197.5828f, -110.581512f, -134.076355f);
            float3 r2 = float3(184.128052f, 73.54654f, 50.0516968f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (146.647888f);
            float3 b3 = float3(44.33954f, 63.789f, 344.308777f);
            float3 r3 = float3(13.6292725f, 19.0698853f, 146.647888f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float3_operator_plus()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float3 r0 = float3(76.92169f, 138.468567f, -358.488953f);
            TestUtils.AreEqual(+a0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float3 r1 = float3(466.4972f, 500.681763f, -317.637939f);
            TestUtils.AreEqual(+a1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float3 r2 = float3(184.128052f, -110.581512f, -134.076355f);
            TestUtils.AreEqual(+a2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float3 r3 = float3(146.647888f, 63.789f, 344.308777f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float3_operator_neg()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float3 r0 = float3(-76.92169f, -138.468567f, 358.488953f);
            TestUtils.AreEqual(-a0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float3 r1 = float3(-466.4972f, -500.681763f, 317.637939f);
            TestUtils.AreEqual(-a1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float3 r2 = float3(-184.128052f, 110.581512f, 134.076355f);
            TestUtils.AreEqual(-a2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float3 r3 = float3(-146.647888f, -63.789f, -344.308777f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float3_operator_prefix_inc()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float3 r0 = float3(77.92169f, 139.468567f, -357.488953f);
            TestUtils.AreEqual(++a0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float3 r1 = float3(467.4972f, 501.681763f, -316.637939f);
            TestUtils.AreEqual(++a1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float3 r2 = float3(185.128052f, -109.581512f, -133.076355f);
            TestUtils.AreEqual(++a2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float3 r3 = float3(147.647888f, 64.789f, 345.308777f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float3_operator_postfix_inc()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float3 r0 = float3(76.92169f, 138.468567f, -358.488953f);
            TestUtils.AreEqual(a0++, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float3 r1 = float3(466.4972f, 500.681763f, -317.637939f);
            TestUtils.AreEqual(a1++, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float3 r2 = float3(184.128052f, -110.581512f, -134.076355f);
            TestUtils.AreEqual(a2++, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float3 r3 = float3(146.647888f, 63.789f, 344.308777f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float3_operator_prefix_dec()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float3 r0 = float3(75.92169f, 137.468567f, -359.488953f);
            TestUtils.AreEqual(--a0, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float3 r1 = float3(465.4972f, 499.681763f, -318.637939f);
            TestUtils.AreEqual(--a1, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float3 r2 = float3(183.128052f, -111.581512f, -135.076355f);
            TestUtils.AreEqual(--a2, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float3 r3 = float3(145.647888f, 62.789f, 343.308777f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float3_operator_postfix_dec()
        {
            float3 a0 = float3(76.92169f, 138.468567f, -358.488953f);
            float3 r0 = float3(76.92169f, 138.468567f, -358.488953f);
            TestUtils.AreEqual(a0--, r0);

            float3 a1 = float3(466.4972f, 500.681763f, -317.637939f);
            float3 r1 = float3(466.4972f, 500.681763f, -317.637939f);
            TestUtils.AreEqual(a1--, r1);

            float3 a2 = float3(184.128052f, -110.581512f, -134.076355f);
            float3 r2 = float3(184.128052f, -110.581512f, -134.076355f);
            TestUtils.AreEqual(a2--, r2);

            float3 a3 = float3(146.647888f, 63.789f, 344.308777f);
            float3 r3 = float3(146.647888f, 63.789f, 344.308777f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
