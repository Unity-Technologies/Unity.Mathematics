// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint4
    {
        [Test]
        public void uint4_constructor()
        {
            uint4 a = new uint4(1, 2, 3, 4);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
            Assert.AreEqual(a.w, 4);
        }

        [Test]
        public void uint4_scalar_constructor()
        {
            uint4 a = new uint4(17u);
            Assert.AreEqual(a.x, 17u);
            Assert.AreEqual(a.y, 17u);
            Assert.AreEqual(a.z, 17u);
            Assert.AreEqual(a.w, 17u);
        }

        [Test]
        public void uint4_static_constructor()
        {
            uint4 a = uint4(1, 2, 3, 4);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
            Assert.AreEqual(a.w, 4);
        }

        [Test]
        public void uint4_static_scalar_constructor()
        {
            uint4 a = uint4(17u);
            Assert.AreEqual(a.x, 17u);
            Assert.AreEqual(a.y, 17u);
            Assert.AreEqual(a.z, 17u);
            Assert.AreEqual(a.w, 17u);
        }

        [Test]
        public void uint4_operator_equal_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint4_operator_equal_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint4_operator_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint4_operator_not_equal_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint4_operator_not_equal_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint4_operator_not_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint4_operator_less_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            bool4 r0 = bool4(false, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            bool4 r1 = bool4(true, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            bool4 r3 = bool4(true, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint4_operator_less_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            bool4 r2 = bool4(false, false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint4_operator_less_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            bool4 r0 = bool4(false, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint4_operator_greater_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            bool4 r0 = bool4(true, true, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            bool4 r1 = bool4(false, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            bool4 r2 = bool4(true, false, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            bool4 r3 = bool4(false, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint4_operator_greater_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            bool4 r2 = bool4(true, true, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint4_operator_greater_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            bool4 r0 = bool4(true, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            bool4 r1 = bool4(true, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            bool4 r2 = bool4(true, false, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint4_operator_less_equal_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            bool4 r0 = bool4(false, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            bool4 r1 = bool4(true, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            bool4 r3 = bool4(true, false, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint4_operator_less_equal_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            bool4 r2 = bool4(false, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint4_operator_less_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            bool4 r0 = bool4(false, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            bool4 r2 = bool4(false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            bool4 r3 = bool4(true, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint4_operator_greater_equal_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            bool4 r0 = bool4(true, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            bool4 r1 = bool4(false, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            bool4 r2 = bool4(true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            bool4 r3 = bool4(false, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint4_operator_greater_equal_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            bool4 r2 = bool4(true, true, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint4_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            bool4 r0 = bool4(true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            bool4 r1 = bool4(true, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            bool4 r2 = bool4(true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            bool4 r3 = bool4(false, false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint4_operator_add_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            uint4 r0 = uint4(1753445788, 2723619897, 2396521897, 2174204831);
            TestUtils.AreEqual(a0 + b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            uint4 r1 = uint4(2173966193, 2920813142, 2731620253, 1807272757);
            TestUtils.AreEqual(a1 + b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            uint4 r2 = uint4(3062038496, 969132724, 1628197263, 2819844656);
            TestUtils.AreEqual(a2 + b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            uint4 r3 = uint4(1725484375, 3739173103, 1822598194, 2957596261);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint4_operator_add_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            uint4 r0 = uint4(1753445788, 2147622786, 1987315611, 1562860110);
            TestUtils.AreEqual(a0 + b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            uint4 r1 = uint4(2004291956, 2174204831, 1482802362, 1621105669);
            TestUtils.AreEqual(a1 + b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            uint4 r2 = uint4(2920813142, 3235621368, 1875737585, 2608328402);
            TestUtils.AreEqual(a2 + b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            uint4 r3 = uint4(2352382877, 3062038496, 2323799561, 2572471507);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint4_operator_add_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(1753445788, 2489750074, 2329442899, 1904987398);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(2004291956, 3248554949, 2557152480, 2695455787);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(2920813142, 3776695810, 2416812027, 3149402844);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(2352382877, 1487283029, 749044094, 997716040);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint4_operator_sub_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            uint4 r0 = uint4(342127288, 160307175, 3612847119, 3050704303);
            TestUtils.AreEqual(a0 - b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            uint4 r1 = uint4(4156663989, 541074442, 1359883783, 1029645347);
            TestUtils.AreEqual(a1 - b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            uint4 r2 = uint4(865099848, 4046295350, 540850477, 1027219152);
            TestUtils.AreEqual(a2 - b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            uint4 r3 = uint4(4073526233, 429404557, 2788608082, 242129627);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint4_operator_sub_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            uint4 r0 = uint4(342127288, 736304286, 575997111, 151541610);
            TestUtils.AreEqual(a0 - b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            uint4 r1 = uint4(1074350118, 1244262993, 552860524, 691163831);
            TestUtils.AreEqual(a1 - b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            uint4 r2 = uint4(541074442, 855882668, 3790966181, 228589702);
            TestUtils.AreEqual(a2 - b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            uint4 r3 = uint4(2720211829, 3429867448, 2691628513, 2940300459);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint4_operator_sub_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(342127288, 3900790298, 4061097473, 190585678);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(1074350118, 4125054421, 521489594, 383186287);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(541074442, 3980159070, 1045075557, 312484740);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(2720211829, 3585311677, 28583316, 4074878666);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint4_operator_mul_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            uint4 r0 = uint4(1881269428, 1087877264, 3697178668, 2976979912);
            TestUtils.AreEqual(a0 * b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            uint4 r1 = uint4(4197276666, 4090976544, 1138300038, 2711244556);
            TestUtils.AreEqual(a1 * b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            uint4 r2 = uint4(2390916080, 2732037579, 3801509630, 3041761280);
            TestUtils.AreEqual(a2 * b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            uint4 r3 = uint4(3676053864, 309642718, 3159357408, 4147671840);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint4_operator_mul_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            uint4 r0 = uint4(1881269428, 1788900128, 1120233282, 2445897208);
            TestUtils.AreEqual(a0 * b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            uint4 r1 = uint4(2063715771, 2976979912, 294328421, 4031174226);
            TestUtils.AreEqual(a1 * b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            uint4 r2 = uint4(4090976544, 4058196268, 284332834, 4221679496);
            TestUtils.AreEqual(a2 * b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            uint4 r3 = uint4(2915022516, 2390916080, 3148023588, 3344469740);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint4_operator_mul_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(1881269428, 967126688, 2328368826, 3480175640);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(2063715771, 2617164952, 3264787255, 885358150);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(4090976544, 1592110432, 4079898384, 1659737152);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(2915022516, 297850924, 3725723421, 1857539895);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint4_operator_div_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            uint4 r0 = uint4(1, 1, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            uint4 r1 = uint4(0, 1, 2, 3);
            TestUtils.AreEqual(a1 / b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            uint4 r2 = uint4(1, 0, 1, 2);
            TestUtils.AreEqual(a2 / b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            uint4 r3 = uint4(0, 1, 0, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint4_operator_div_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            uint4 r0 = uint4(1, 2, 1, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            uint4 r1 = uint4(3, 3, 2, 2);
            TestUtils.AreEqual(a1 / b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            uint4 r2 = uint4(1, 1, 0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            uint4 r3 = uint4(0, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint4_operator_div_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(1, 0, 0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(3, 0, 1, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(1, 0, 2, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(0, 0, 1, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint4_operator_mod_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            uint4 r0 = uint4(342127288, 160307175, 857200860, 464970919);
            TestUtils.AreEqual(a0 % b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            uint4 r1 = uint4(1017831443, 541074442, 674015548, 252017937);
            TestUtils.AreEqual(a1 % b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            uint4 r2 = uint4(865099848, 360230389, 540850477, 130906400);
            TestUtils.AreEqual(a2 % b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            uint4 r3 = uint4(752021656, 429404557, 158119490, 242129627);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint4_operator_mod_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            uint4 r0 = uint4(342127288, 30645036, 575997111, 151541610);
            TestUtils.AreEqual(a0 % b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            uint4 r1 = uint4(144408280, 314321155, 87889605, 226192912);
            TestUtils.AreEqual(a1 % b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            uint4 r2 = uint4(541074442, 855882668, 685868235, 228589702);
            TestUtils.AreEqual(a2 % b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            uint4 r3 = uint4(388813705, 1098469324, 360230389, 608902335);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint4_operator_mod_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(342127288, 1047786538, 1047786538, 190585678);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(144408280, 1539321037, 521489594, 383186287);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(541074442, 1730943792, 359207322, 312484740);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(388813705, 388813705, 28583316, 388813705);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint4_operator_plus()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            TestUtils.AreEqual(+a0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            TestUtils.AreEqual(+a1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            TestUtils.AreEqual(+a2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(388813705, 1098469324, 360230389, 608902335);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void uint4_operator_neg()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(3247180758, 2853003760, 3013310935, 3437766436);
            TestUtils.AreEqual(-a0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(2755646259, 2585733384, 3277135853, 3138832546);
            TestUtils.AreEqual(-a1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(2564023504, 2249215278, 3609099061, 2876508244);
            TestUtils.AreEqual(-a2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(3906153591, 3196497972, 3934736907, 3686064961);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void uint4_operator_prefix_inc()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(1047786539, 1441963537, 1281656362, 857200861);
            TestUtils.AreEqual(++a0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(1539321038, 1709233913, 1017831444, 1156134751);
            TestUtils.AreEqual(++a1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(1730943793, 2045752019, 685868236, 1418459053);
            TestUtils.AreEqual(++a2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(388813706, 1098469325, 360230390, 608902336);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void uint4_operator_postfix_inc()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            TestUtils.AreEqual(a0++, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            TestUtils.AreEqual(a1++, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            TestUtils.AreEqual(a2++, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(388813705, 1098469324, 360230389, 608902335);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void uint4_operator_prefix_dec()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(1047786537, 1441963535, 1281656360, 857200859);
            TestUtils.AreEqual(--a0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(1539321036, 1709233911, 1017831442, 1156134749);
            TestUtils.AreEqual(--a1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(1730943791, 2045752017, 685868234, 1418459051);
            TestUtils.AreEqual(--a2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(388813704, 1098469323, 360230388, 608902334);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void uint4_operator_postfix_dec()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            TestUtils.AreEqual(a0--, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            TestUtils.AreEqual(a1--, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            TestUtils.AreEqual(a2--, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(388813705, 1098469324, 360230389, 608902335);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void uint4_operator_bitwise_and_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            uint4 r0 = uint4(704872482, 1147176448, 318769356, 27313312);
            TestUtils.AreEqual(a0 & b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            uint4 r1 = uint4(78127122, 1177031456, 685867202, 336122760);
            TestUtils.AreEqual(a1 & b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            uint4 r2 = uint4(1091108868, 71830709, 2393104, 807699584);
            TestUtils.AreEqual(a2 & b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            uint4 r3 = uint4(671142040, 1612939568, 19178560, 1346984064);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_and_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            uint4 r0 = uint4(704872482, 163856, 134512672, 570916944);
            TestUtils.AreEqual(a0 & b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            uint4 r1 = uint4(461382789, 27313312, 413327363, 10494982);
            TestUtils.AreEqual(a1 & b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            uint4 r2 = uint4(1177031456, 1089188354, 14779394, 1150023460);
            TestUtils.AreEqual(a2 & b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            uint4 r3 = uint4(352882688, 1091108868, 352886804, 604573716);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(704872482, 343053312, 207651880, 840159240);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(461382789, 1103103176, 411049985, 1086334028);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(1177031456, 1630278160, 538968064, 1141379872);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(352882688, 19415944, 354976129, 67637385);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_or_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            uint4 r0 = uint4(1048573306, 1576443449, 2077752541, 2146891519);
            TestUtils.AreEqual(a0 | b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            uint4 r1 = uint4(2095839071, 1743781686, 2045753051, 1471149997);
            TestUtils.AreEqual(a1 | b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            uint4 r2 = uint4(1970929628, 897302015, 1625804159, 2012145072);
            TestUtils.AreEqual(a2 | b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            uint4 r3 = uint4(1054342335, 2126233535, 1803419634, 1610612197);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_or_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            uint4 r0 = uint4(1048573306, 2147458930, 1852802939, 991943166);
            TestUtils.AreEqual(a0 | b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            uint4 r1 = uint4(1542909167, 2146891519, 1069474999, 1610610687);
            TestUtils.AreEqual(a1 | b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            uint4 r2 = uint4(1743781686, 2146433014, 1860958191, 1458304942);
            TestUtils.AreEqual(a2 | b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            uint4 r3 = uint4(1999500189, 1970929628, 1970912757, 1967897791);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(1048573306, 2146696762, 2121791019, 1064828158);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(1542909167, 2145451773, 2146102495, 1609121759);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(1743781686, 2146417650, 1877843963, 2008022972);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(1999500189, 1467867085, 394067965, 930078655);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_xor_wide_wide()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 857200860, 464970919);
            uint4 b0 = uint4(705659250, 1281656361, 1539321037, 1709233912);
            uint4 r0 = uint4(343700824, 429267001, 1758983185, 2119578207);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint4 a1 = uint4(1017831443, 1730943792, 2045752018, 1418459052);
            uint4 b1 = uint4(1156134750, 1189869350, 685868235, 388813705);
            uint4 r1 = uint4(2017711949, 566750230, 1359885849, 1135027237);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint4 a2 = uint4(1963569172, 360230389, 1084523870, 1923531904);
            uint4 b2 = uint4(1098469324, 608902335, 543673393, 896312752);
            uint4 r2 = uint4(879820760, 825471306, 1623411055, 1204445488);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint4 a3 = uint4(752021656, 2084288830, 158119490, 1599862944);
            uint4 b3 = uint4(973462719, 1654884273, 1664478704, 1357733317);
            uint4 r3 = uint4(383200295, 513293967, 1784241074, 263628133);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_xor_wide_scalar()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint b0 = (705659250);
            uint4 r0 = uint4(343700824, 2147295074, 1718290267, 421026222);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint b1 = (464970919);
            uint4 r1 = uint4(1081526378, 2119578207, 656147636, 1600115705);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint b2 = (1189869350);
            uint4 r2 = uint4(566750230, 1057244660, 1846178797, 308281482);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint b3 = (1963569172);
            uint4 r3 = uint4(1646617501, 879820760, 1618025953, 1363324075);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1047786538);
            uint4 b0 = uint4(705659250, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(343700824, 1803643450, 1914139139, 224668918);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (1539321037);
            uint4 b1 = uint4(464970919, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(1081526378, 1042348597, 1735052510, 522787731);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (1730943792);
            uint4 b2 = uint4(1189869350, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(566750230, 516139490, 1338875899, 866643100);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (388813705);
            uint4 b3 = uint4(1963569172, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(1646617501, 1448451141, 39091836, 862441270);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint4_operator_left_shift()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            uint4 r0 = uint4(3500670976, 2017460224, 413401088, 1668284416);
            TestUtils.AreEqual(a0 << b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            uint4 r1 = uint4(3759564416, 4033575936, 1433405824, 1956359936);
            TestUtils.AreEqual(a1 << b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            uint4 r2 = uint4(3406220288, 2079110272, 945894080, 587066112);
            TestUtils.AreEqual(a2 << b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            uint4 r3 = uint4(948961280, 4240441344, 3746562048, 3421503488);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void uint4_operator_right_shift()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            uint4 r0 = uint4(3996, 5500, 4889, 3269);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            uint4 r1 = uint4(12025945, 13353389, 7951808, 9032302);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            uint4 r2 = uint4(27045996, 31964875, 10716691, 22163422);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            uint4 r3 = uint4(370, 1047, 343, 580);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void uint4_operator_bitwise_not()
        {
            uint4 a0 = uint4(1047786538, 1441963536, 1281656361, 857200860);
            uint4 r0 = uint4(3247180757, 2853003759, 3013310934, 3437766435);
            TestUtils.AreEqual(~a0, r0);

            uint4 a1 = uint4(1539321037, 1709233912, 1017831443, 1156134750);
            uint4 r1 = uint4(2755646258, 2585733383, 3277135852, 3138832545);
            TestUtils.AreEqual(~a1, r1);

            uint4 a2 = uint4(1730943792, 2045752018, 685868235, 1418459052);
            uint4 r2 = uint4(2564023503, 2249215277, 3609099060, 2876508243);
            TestUtils.AreEqual(~a2, r2);

            uint4 a3 = uint4(388813705, 1098469324, 360230389, 608902335);
            uint4 r3 = uint4(3906153590, 3196497971, 3934736906, 3686064960);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
