// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint2
    {
        [Test]
        public void uint2_constructor()
        {
            uint2 a = new uint2(1, 2);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
        }

        [Test]
        public void uint2_scalar_constructor()
        {
            uint2 a = new uint2(17u);
            Assert.AreEqual(a.x, 17u);
            Assert.AreEqual(a.y, 17u);
        }

        [Test]
        public void uint2_static_constructor()
        {
            uint2 a = uint2(1, 2);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
        }

        [Test]
        public void uint2_static_scalar_constructor()
        {
            uint2 a = uint2(17u);
            Assert.AreEqual(a.x, 17u);
            Assert.AreEqual(a.y, 17u);
        }

        [Test]
        public void uint2_operator_equal_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint2_operator_equal_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint2_operator_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint2_operator_not_equal_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint2_operator_not_equal_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint2_operator_not_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint2_operator_less_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint2_operator_less_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint2_operator_less_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint2_operator_greater_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint2_operator_greater_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint2_operator_greater_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint2_operator_less_equal_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint2_operator_less_equal_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint2_operator_less_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint2_operator_greater_equal_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint2_operator_greater_equal_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint2_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint2_operator_add_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            uint2 r0 = uint2(1753445788, 2723619897);
            TestUtils.AreEqual(a0 + b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            uint2 r1 = uint2(2396521897, 2174204831);
            TestUtils.AreEqual(a1 + b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            uint2 r2 = uint2(2173966193, 2920813142);
            TestUtils.AreEqual(a2 + b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            uint2 r3 = uint2(2731620253, 1807272757);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint2_operator_add_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            uint2 r0 = uint2(1753445788, 2147622786);
            TestUtils.AreEqual(a0 + b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            uint2 r1 = uint2(2138857221, 2396521897);
            TestUtils.AreEqual(a1 + b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            uint2 r2 = uint2(2174204831, 2727065355);
            TestUtils.AreEqual(a2 + b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            uint2 r3 = uint2(2887078542, 2920813142);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint2_operator_add_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            uint2 r0 = uint2(1753445788, 2489750074);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            uint2 r1 = uint2(2138857221, 2820977398);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            uint2 r2 = uint2(2174204831, 1482802362);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            uint2 r3 = uint2(2887078542, 2346004100);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint2_operator_sub_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            uint2 r0 = uint2(342127288, 160307175);
            TestUtils.AreEqual(a0 - b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            uint2 r1 = uint2(3612847119, 3050704303);
            TestUtils.AreEqual(a1 - b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            uint2 r2 = uint2(4156663989, 541074442);
            TestUtils.AreEqual(a2 - b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            uint2 r3 = uint2(1359883783, 1029645347);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint2_operator_sub_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            uint2 r0 = uint2(342127288, 736304286);
            TestUtils.AreEqual(a0 - b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            uint2 r1 = uint2(424455501, 682120177);
            TestUtils.AreEqual(a1 - b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            uint2 r2 = uint2(3050704303, 3603564827);
            TestUtils.AreEqual(a2 - b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            uint2 r3 = uint2(3720158254, 3753892854);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint2_operator_sub_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            uint2 r0 = uint2(342127288, 3900790298);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            uint2 r1 = uint2(424455501, 4037302620);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            uint2 r2 = uint2(3050704303, 3742106772);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            uint2 r3 = uint2(3720158254, 4261232696);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint2_operator_mul_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            uint2 r0 = uint2(1881269428, 1087877264);
            TestUtils.AreEqual(a0 * b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            uint2 r1 = uint2(3697178668, 2976979912);
            TestUtils.AreEqual(a1 * b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            uint2 r2 = uint2(4197276666, 4090976544);
            TestUtils.AreEqual(a2 * b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            uint2 r3 = uint2(1138300038, 2711244556);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint2_operator_mul_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            uint2 r0 = uint2(1881269428, 1788900128);
            TestUtils.AreEqual(a0 * b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            uint2 r1 = uint2(2957304636, 3697178668);
            TestUtils.AreEqual(a1 * b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            uint2 r2 = uint2(2976979912, 746124392);
            TestUtils.AreEqual(a2 * b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            uint2 r3 = uint2(3669576608, 4090976544);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint2_operator_mul_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            uint2 r0 = uint2(1881269428, 967126688);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            uint2 r1 = uint2(2957304636, 2773383893);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            uint2 r2 = uint2(2976979912, 294328421);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            uint2 r3 = uint2(3669576608, 3327388148);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint2_operator_div_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            uint2 r0 = uint2(1, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            uint2 r1 = uint2(0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            uint2 r2 = uint2(0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            uint2 r3 = uint2(2, 3);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint2_operator_div_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            uint2 r0 = uint2(1, 2);
            TestUtils.AreEqual(a0 / b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            uint2 r1 = uint2(1, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            uint2 r2 = uint2(0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            uint2 r3 = uint2(0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint2_operator_div_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            uint2 r0 = uint2(1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            uint2 r1 = uint2(1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            uint2 r2 = uint2(0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            uint2 r3 = uint2(0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint2_operator_mod_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            uint2 r0 = uint2(342127288, 160307175);
            TestUtils.AreEqual(a0 % b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            uint2 r1 = uint2(857200860, 464970919);
            TestUtils.AreEqual(a1 % b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            uint2 r2 = uint2(1017831443, 541074442);
            TestUtils.AreEqual(a2 % b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            uint2 r3 = uint2(674015548, 252017937);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint2_operator_mod_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            uint2 r0 = uint2(342127288, 30645036);
            TestUtils.AreEqual(a0 % b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            uint2 r1 = uint2(424455501, 682120177);
            TestUtils.AreEqual(a1 % b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            uint2 r2 = uint2(464970919, 1017831443);
            TestUtils.AreEqual(a2 % b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            uint2 r3 = uint2(1156134750, 1189869350);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint2_operator_mod_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            uint2 r0 = uint2(342127288, 1047786538);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            uint2 r1 = uint2(424455501, 1281656361);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            uint2 r2 = uint2(464970919, 464970919);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            uint2 r3 = uint2(1156134750, 1156134750);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint2_operator_plus()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 r0 = uint2(1047786538, 1441963536);
            TestUtils.AreEqual(+a0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint2 r1 = uint2(1281656361, 1539321037);
            TestUtils.AreEqual(+a1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint2 r2 = uint2(464970919, 1017831443);
            TestUtils.AreEqual(+a2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint2 r3 = uint2(1156134750, 1189869350);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void uint2_operator_neg()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 r0 = uint2(3247180758, 2853003760);
            TestUtils.AreEqual(-a0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint2 r1 = uint2(3013310935, 2755646259);
            TestUtils.AreEqual(-a1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint2 r2 = uint2(3829996377, 3277135853);
            TestUtils.AreEqual(-a2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint2 r3 = uint2(3138832546, 3105097946);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void uint2_operator_prefix_inc()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 r0 = uint2(1047786539, 1441963537);
            TestUtils.AreEqual(++a0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint2 r1 = uint2(1281656362, 1539321038);
            TestUtils.AreEqual(++a1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint2 r2 = uint2(464970920, 1017831444);
            TestUtils.AreEqual(++a2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint2 r3 = uint2(1156134751, 1189869351);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void uint2_operator_postfix_inc()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 r0 = uint2(1047786538, 1441963536);
            TestUtils.AreEqual(a0++, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint2 r1 = uint2(1281656361, 1539321037);
            TestUtils.AreEqual(a1++, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint2 r2 = uint2(464970919, 1017831443);
            TestUtils.AreEqual(a2++, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint2 r3 = uint2(1156134750, 1189869350);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void uint2_operator_prefix_dec()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 r0 = uint2(1047786537, 1441963535);
            TestUtils.AreEqual(--a0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint2 r1 = uint2(1281656360, 1539321036);
            TestUtils.AreEqual(--a1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint2 r2 = uint2(464970918, 1017831442);
            TestUtils.AreEqual(--a2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint2 r3 = uint2(1156134749, 1189869349);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void uint2_operator_postfix_dec()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 r0 = uint2(1047786538, 1441963536);
            TestUtils.AreEqual(a0--, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint2 r1 = uint2(1281656361, 1539321037);
            TestUtils.AreEqual(a1--, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint2 r2 = uint2(464970919, 1017831443);
            TestUtils.AreEqual(a2--, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint2 r3 = uint2(1156134750, 1189869350);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void uint2_operator_bitwise_and_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            uint2 r0 = uint2(704872482, 1147176448);
            TestUtils.AreEqual(a0 & b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            uint2 r1 = uint2(318769356, 27313312);
            TestUtils.AreEqual(a1 & b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            uint2 r2 = uint2(78127122, 1177031456);
            TestUtils.AreEqual(a2 & b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            uint2 r3 = uint2(685867202, 336122760);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint2_operator_bitwise_and_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            uint2 r0 = uint2(704872482, 163856);
            TestUtils.AreEqual(a0 & b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            uint2 r1 = uint2(294920, 318769356);
            TestUtils.AreEqual(a1 & b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            uint2 r2 = uint2(27313312, 614514704);
            TestUtils.AreEqual(a2 & b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            uint2 r3 = uint2(1143477008, 1177031456);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint2_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            uint2 r0 = uint2(704872482, 343053312);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            uint2 r1 = uint2(294920, 1212154889);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            uint2 r2 = uint2(27313312, 413327363);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            uint2 r3 = uint2(1143477008, 1156134662);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint2_operator_bitwise_or_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            uint2 r0 = uint2(1048573306, 1576443449);
            TestUtils.AreEqual(a0 | b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            uint2 r1 = uint2(2077752541, 2146891519);
            TestUtils.AreEqual(a1 | b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            uint2 r2 = uint2(2095839071, 1743781686);
            TestUtils.AreEqual(a2 | b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            uint2 r3 = uint2(2045753051, 1471149997);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint2_operator_bitwise_or_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            uint2 r0 = uint2(1048573306, 2147458930);
            TestUtils.AreEqual(a0 | b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            uint2 r1 = uint2(2138562301, 2077752541);
            TestUtils.AreEqual(a1 | b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            uint2 r2 = uint2(2146891519, 2112550651);
            TestUtils.AreEqual(a2 | b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            uint2 r3 = uint2(1743601534, 1743781686);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint2_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            uint2 r0 = uint2(1048573306, 2146696762);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            uint2 r1 = uint2(2138562301, 1608822509);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            uint2 r2 = uint2(2146891519, 1069474999);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            uint2 r3 = uint2(1743601534, 1189869438);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint2_operator_bitwise_xor_wide_wide()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 b0 = uint2(705659250, 1281656361);
            uint2 r0 = uint2(343700824, 429267001);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint2 a1 = uint2(857200860, 464970919);
            uint2 b1 = uint2(1539321037, 1709233912);
            uint2 r1 = uint2(1758983185, 2119578207);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint2 a2 = uint2(1017831443, 1730943792);
            uint2 b2 = uint2(1156134750, 1189869350);
            uint2 r2 = uint2(2017711949, 566750230);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint2 a3 = uint2(2045752018, 1418459052);
            uint2 b3 = uint2(685868235, 388813705);
            uint2 r3 = uint2(1359885849, 1135027237);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint2_operator_bitwise_xor_wide_scalar()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint b0 = (705659250);
            uint2 r0 = uint2(343700824, 2147295074);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint b1 = (857200860);
            uint2 r1 = uint2(2138267381, 1758983185);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint b2 = (1709233912);
            uint2 r2 = uint2(2119578207, 1498035947);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint b3 = (1730943792);
            uint2 r3 = uint2(600124526, 566750230);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint2_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1047786538);
            uint2 b0 = uint2(705659250, 1441963536);
            uint2 r0 = uint2(343700824, 1803643450);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (1281656361);
            uint2 b1 = uint2(857200860, 1539321037);
            uint2 r1 = uint2(2138267381, 396667620);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (464970919);
            uint2 b2 = uint2(1709233912, 1017831443);
            uint2 r2 = uint2(2119578207, 656147636);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (1156134750);
            uint2 b3 = uint2(1730943792, 1189869350);
            uint2 r3 = uint2(600124526, 33734776);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint2_operator_left_shift()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            int b0 = (705659250);
            uint2 r0 = uint2(3500670976, 2017460224);
            TestUtils.AreEqual(a0 << b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            int b1 = (857200860);
            uint2 r1 = uint2(2415919104, 3489660928);
            TestUtils.AreEqual(a1 << b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            int b2 = (1709233912);
            uint2 r2 = uint2(2801795072, 318767104);
            TestUtils.AreEqual(a2 << b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            int b3 = (1730943792);
            uint2 r3 = uint2(928907264, 4146462720);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void uint2_operator_right_shift()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            int b0 = (705659250);
            uint2 r0 = uint2(3996, 5500);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            int b1 = (857200860);
            uint2 r1 = uint2(4, 5);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            int b2 = (1709233912);
            uint2 r2 = uint2(27, 60);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            int b3 = (1730943792);
            uint2 r3 = uint2(17641, 18155);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void uint2_operator_bitwise_not()
        {
            uint2 a0 = uint2(1047786538, 1441963536);
            uint2 r0 = uint2(3247180757, 2853003759);
            TestUtils.AreEqual(~a0, r0);

            uint2 a1 = uint2(1281656361, 1539321037);
            uint2 r1 = uint2(3013310934, 2755646258);
            TestUtils.AreEqual(~a1, r1);

            uint2 a2 = uint2(464970919, 1017831443);
            uint2 r2 = uint2(3829996376, 3277135852);
            TestUtils.AreEqual(~a2, r2);

            uint2 a3 = uint2(1156134750, 1189869350);
            uint2 r3 = uint2(3138832545, 3105097945);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
