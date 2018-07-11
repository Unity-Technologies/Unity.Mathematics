// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint3
    {
        [Test]
        public void uint3_constructor()
        {
            uint3 a = new uint3(1, 2, 3);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
        }

        [Test]
        public void uint3_scalar_constructor()
        {
            uint3 a = new uint3(17u);
            Assert.AreEqual(a.x, 17u);
            Assert.AreEqual(a.y, 17u);
            Assert.AreEqual(a.z, 17u);
        }

        [Test]
        public void uint3_static_constructor()
        {
            uint3 a = uint3(1, 2, 3);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
        }

        [Test]
        public void uint3_static_scalar_constructor()
        {
            uint3 a = uint3(17u);
            Assert.AreEqual(a.x, 17u);
            Assert.AreEqual(a.y, 17u);
            Assert.AreEqual(a.z, 17u);
        }

        [Test]
        public void uint3_operator_equal_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint3_operator_equal_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint3_operator_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint3_operator_not_equal_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint3_operator_not_equal_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint3_operator_not_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint3_operator_less_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint3_operator_less_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            bool3 r2 = bool3(true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint3_operator_less_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint3_operator_greater_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            bool3 r3 = bool3(false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint3_operator_greater_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint3_operator_greater_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            bool3 r1 = bool3(false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint3_operator_less_equal_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint3_operator_less_equal_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            bool3 r2 = bool3(true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint3_operator_less_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            bool3 r1 = bool3(true, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint3_operator_greater_equal_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            bool3 r3 = bool3(false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint3_operator_greater_equal_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            bool3 r2 = bool3(false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint3_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            bool3 r1 = bool3(false, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint3_operator_add_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            uint3 r0 = uint3(1753445788, 2723619897, 2396521897);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            uint3 r1 = uint3(2174204831, 2173966193, 2920813142);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            uint3 r2 = uint3(2731620253, 1807272757, 3062038496);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            uint3 r3 = uint3(969132724, 1628197263, 2819844656);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint3_operator_add_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            uint3 r0 = uint3(1753445788, 2147622786, 1987315611);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            uint3 r1 = uint3(2396521897, 2004291956, 3248554949);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            uint3 r2 = uint3(2173966193, 2887078542, 2346004100);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            uint3 r3 = uint3(2731620253, 2104327287, 1074681940);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint3_operator_add_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            uint3 r0 = uint3(1753445788, 2489750074, 2329442899);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            uint3 r1 = uint3(2396521897, 1322171779, 2566434772);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            uint3 r2 = uint3(2173966193, 2748775235, 2207700793);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            uint3 r3 = uint3(2731620253, 3464211070, 2434565723);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint3_operator_sub_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            uint3 r0 = uint3(342127288, 160307175, 3612847119);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            uint3 r1 = uint3(3050704303, 4156663989, 541074442);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            uint3 r2 = uint3(1359883783, 1029645347, 865099848);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            uint3 r3 = uint3(4046295350, 540850477, 1027219152);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint3_operator_sub_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            uint3 r0 = uint3(342127288, 736304286, 575997111);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            uint3 r1 = uint3(3612847119, 3220617178, 169912875);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            uint3 r2 = uint3(4156663989, 574809042, 33734600);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            uint3 r3 = uint3(1359883783, 732590817, 3997912766);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint3_operator_sub_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            uint3 r0 = uint3(342127288, 3900790298, 4061097473);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            uint3 r1 = uint3(3612847119, 392229941, 3442934244);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            uint3 r2 = uint3(4156663989, 3581854947, 4122929389);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            uint3 r3 = uint3(1359883783, 627292966, 1656938313);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint3_operator_mul_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            uint3 r0 = uint3(1881269428, 1087877264, 3697178668);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            uint3 r1 = uint3(2976979912, 4197276666, 4090976544);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            uint3 r2 = uint3(1138300038, 2711244556, 2390916080);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            uint3 r3 = uint3(2732037579, 3801509630, 3041761280);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint3_operator_mul_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            uint3 r0 = uint3(1881269428, 1788900128, 1120233282);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            uint3 r1 = uint3(3697178668, 2063715771, 2617164952);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            uint3 r2 = uint3(4197276666, 3669576608, 3327388148);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            uint3 r3 = uint3(1138300038, 3302888804, 3506921891);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint3_operator_mul_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            uint3 r0 = uint3(1881269428, 967126688, 2328368826);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            uint3 r1 = uint3(3697178668, 4061816708, 4209114400);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            uint3 r2 = uint3(4197276666, 2381317264, 3271595986);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            uint3 r3 = uint3(1138300038, 849003288, 1807861858);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint3_operator_div_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            uint3 r0 = uint3(1, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            uint3 r1 = uint3(0, 0, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            uint3 r2 = uint3(2, 3, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            uint3 r3 = uint3(0, 1, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint3_operator_div_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            uint3 r0 = uint3(1, 2, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            uint3 r1 = uint3(0, 0, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            uint3 r2 = uint3(0, 1, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            uint3 r3 = uint3(2, 2, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint3_operator_div_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            uint3 r0 = uint3(1, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            uint3 r1 = uint3(0, 1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            uint3 r2 = uint3(0, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            uint3 r3 = uint3(2, 1, 5);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint3_operator_mod_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            uint3 r0 = uint3(342127288, 160307175, 857200860);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            uint3 r1 = uint3(464970919, 1017831443, 541074442);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            uint3 r2 = uint3(674015548, 252017937, 865099848);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            uint3 r3 = uint3(360230389, 540850477, 130906400);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint3_operator_mod_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            uint3 r0 = uint3(342127288, 30645036, 575997111);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            uint3 r1 = uint3(857200860, 464970919, 169912875);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            uint3 r2 = uint3(1017831443, 574809042, 33734600);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            uint3 r3 = uint3(674015548, 46722582, 388813705);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint3_operator_mod_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            uint3 r0 = uint3(342127288, 1047786538, 1047786538);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            uint3 r1 = uint3(857200860, 392229941, 857200860);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            uint3 r2 = uint3(1017831443, 1017831443, 1017831443);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            uint3 r3 = uint3(674015548, 627292966, 101683493);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint3_operator_plus()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint3 r0 = uint3(1047786538, 1441963536, 1281656361);
            TestUtils.AreEqual(+a0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint3 r1 = uint3(857200860, 464970919, 1709233912);
            TestUtils.AreEqual(+a1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint3 r2 = uint3(1017831443, 1730943792, 1189869350);
            TestUtils.AreEqual(+a2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint3 r3 = uint3(2045752018, 1418459052, 388813705);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void uint3_operator_neg()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint3 r0 = uint3(3247180758, 2853003760, 3013310935);
            TestUtils.AreEqual(-a0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint3 r1 = uint3(3437766436, 3829996377, 2585733384);
            TestUtils.AreEqual(-a1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint3 r2 = uint3(3277135853, 2564023504, 3105097946);
            TestUtils.AreEqual(-a2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint3 r3 = uint3(2249215278, 2876508244, 3906153591);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void uint3_operator_prefix_inc()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint3 r0 = uint3(1047786539, 1441963537, 1281656362);
            TestUtils.AreEqual(++a0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint3 r1 = uint3(857200861, 464970920, 1709233913);
            TestUtils.AreEqual(++a1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint3 r2 = uint3(1017831444, 1730943793, 1189869351);
            TestUtils.AreEqual(++a2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint3 r3 = uint3(2045752019, 1418459053, 388813706);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void uint3_operator_postfix_inc()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint3 r0 = uint3(1047786538, 1441963536, 1281656361);
            TestUtils.AreEqual(a0++, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint3 r1 = uint3(857200860, 464970919, 1709233912);
            TestUtils.AreEqual(a1++, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint3 r2 = uint3(1017831443, 1730943792, 1189869350);
            TestUtils.AreEqual(a2++, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint3 r3 = uint3(2045752018, 1418459052, 388813705);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void uint3_operator_prefix_dec()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint3 r0 = uint3(1047786537, 1441963535, 1281656360);
            TestUtils.AreEqual(--a0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint3 r1 = uint3(857200859, 464970918, 1709233911);
            TestUtils.AreEqual(--a1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint3 r2 = uint3(1017831442, 1730943791, 1189869349);
            TestUtils.AreEqual(--a2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint3 r3 = uint3(2045752017, 1418459051, 388813704);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void uint3_operator_postfix_dec()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint3 r0 = uint3(1047786538, 1441963536, 1281656361);
            TestUtils.AreEqual(a0--, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint3 r1 = uint3(857200860, 464970919, 1709233912);
            TestUtils.AreEqual(a1--, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint3 r2 = uint3(1017831443, 1730943792, 1189869350);
            TestUtils.AreEqual(a2--, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint3 r3 = uint3(2045752018, 1418459052, 388813705);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void uint3_operator_bitwise_and_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            uint3 r0 = uint3(704872482, 1147176448, 318769356);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            uint3 r1 = uint3(27313312, 78127122, 1177031456);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            uint3 r2 = uint3(685867202, 336122760, 1091108868);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            uint3 r3 = uint3(71830709, 2393104, 807699584);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint3_operator_bitwise_and_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            uint3 r0 = uint3(704872482, 163856, 134512672);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            uint3 r1 = uint3(318769356, 461382789, 1103103176);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            uint3 r2 = uint3(78127122, 1143477008, 1156134662);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            uint3 r3 = uint3(685867202, 8488072, 2130057);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint3_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            uint3 r0 = uint3(704872482, 343053312, 207651880);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            uint3 r1 = uint3(318769356, 320258180, 553701592);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            uint3 r2 = uint3(78127122, 606601232, 78307330);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            uint3 r3 = uint3(685867202, 1351332480, 288133760);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint3_operator_bitwise_or_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            uint3 r0 = uint3(1048573306, 1576443449, 2077752541);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            uint3 r1 = uint3(2146891519, 2095839071, 1743781686);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            uint3 r2 = uint3(2045753051, 1471149997, 1970929628);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            uint3 r3 = uint3(897302015, 1625804159, 2012145072);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint3_operator_bitwise_or_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            uint3 r0 = uint3(1048573306, 2147458930, 1852802939);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            uint3 r1 = uint3(2077752541, 1542909167, 2145451773);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            uint3 r2 = uint3(2095839071, 1743601534, 1189869438);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            uint3 r3 = uint3(2045753051, 2095839215, 1072551883);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint3_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            uint3 r0 = uint3(1048573306, 2146696762, 2121791019);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            uint3 r1 = uint3(2077752541, 1001913599, 2012733180);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            uint3 r2 = uint3(2095839071, 2142174003, 2129393463);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            uint3 r3 = uint3(2045753051, 2112878590, 2146431963);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint3_operator_bitwise_xor_wide_wide()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 857200860);
            uint3 b0 = uint3(705659250, 1281656361, 1539321037);
            uint3 r0 = uint3(343700824, 429267001, 1758983185);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3 a1 = uint3(464970919, 1017831443, 1730943792);
            uint3 b1 = uint3(1709233912, 1156134750, 1189869350);
            uint3 r1 = uint3(2119578207, 2017711949, 566750230);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3 a2 = uint3(2045752018, 1418459052, 1963569172);
            uint3 b2 = uint3(685868235, 388813705, 1098469324);
            uint3 r2 = uint3(1359885849, 1135027237, 879820760);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3 a3 = uint3(360230389, 1084523870, 1923531904);
            uint3 b3 = uint3(608902335, 543673393, 896312752);
            uint3 r3 = uint3(825471306, 1623411055, 1204445488);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint3_operator_bitwise_xor_wide_scalar()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint b0 = (705659250);
            uint3 r0 = uint3(343700824, 2147295074, 1718290267);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint b1 = (1539321037);
            uint3 r1 = uint3(1758983185, 1081526378, 1042348597);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint b2 = (1156134750);
            uint3 r2 = uint3(2017711949, 600124526, 33734776);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint b3 = (685868235);
            uint3 r3 = uint3(1359885849, 2087351143, 1070421826);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint3_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1047786538);
            uint3 b0 = uint3(705659250, 1441963536, 1281656361);
            uint3 r0 = uint3(343700824, 1803643450, 1914139139);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (857200860);
            uint3 b1 = uint3(1539321037, 464970919, 1709233912);
            uint3 r1 = uint3(1758983185, 681655419, 1459031588);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (1017831443);
            uint3 b2 = uint3(1156134750, 1730943792, 1189869350);
            uint3 r2 = uint3(2017711949, 1535572771, 2051086133);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (2045752018);
            uint3 b3 = uint3(685868235, 1418459052, 388813705);
            uint3 r3 = uint3(1359885849, 761546110, 1858298203);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint3_operator_left_shift()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            int b0 = (705659250);
            uint3 r0 = uint3(3500670976, 2017460224, 413401088);
            TestUtils.AreEqual(a0 << b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            int b1 = (1539321037);
            uint3 r1 = uint3(4212883456, 3700744192, 450822144);
            TestUtils.AreEqual(a1 << b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            int b2 = (1156134750);
            uint3 r2 = uint3(3221225472, 0, 2147483648);
            TestUtils.AreEqual(a2 << b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            int b3 = (685868235);
            uint3 r3 = uint3(2107019264, 1606246400, 1721518080);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void uint3_operator_right_shift()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            int b0 = (705659250);
            uint3 r0 = uint3(3996, 5500, 4889);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            int b1 = (1539321037);
            uint3 r1 = uint3(104638, 56759, 208646);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            int b2 = (1156134750);
            uint3 r2 = uint3(0, 1, 1);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            int b3 = (685868235);
            uint3 r3 = uint3(998902, 692606, 189850);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void uint3_operator_bitwise_not()
        {
            uint3 a0 = uint3(1047786538, 1441963536, 1281656361);
            uint3 r0 = uint3(3247180757, 2853003759, 3013310934);
            TestUtils.AreEqual(~a0, r0);

            uint3 a1 = uint3(857200860, 464970919, 1709233912);
            uint3 r1 = uint3(3437766435, 3829996376, 2585733383);
            TestUtils.AreEqual(~a1, r1);

            uint3 a2 = uint3(1017831443, 1730943792, 1189869350);
            uint3 r2 = uint3(3277135852, 2564023503, 3105097945);
            TestUtils.AreEqual(~a2, r2);

            uint3 a3 = uint3(2045752018, 1418459052, 388813705);
            uint3 r3 = uint3(2249215277, 2876508243, 3906153590);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
