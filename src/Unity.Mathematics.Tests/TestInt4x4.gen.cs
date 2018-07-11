// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt4x4
    {
        [Test]
        public void int4x4_operator_equal_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int4x4_operator_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int4x4_operator_equal_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int4x4_operator_not_equal_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int4x4_operator_not_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int4x4_operator_not_equal_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int4x4_operator_less_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            bool4x4 r0 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            bool4x4 r1 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            bool4x4 r2 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            bool4x4 r3 = bool4x4(true, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int4x4_operator_less_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            bool4x4 r2 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int4x4_operator_less_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            bool4x4 r0 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            bool4x4 r1 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            bool4x4 r2 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            bool4x4 r3 = bool4x4(true, true, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int4x4_operator_greater_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            bool4x4 r0 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            bool4x4 r1 = bool4x4(false, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            bool4x4 r2 = bool4x4(true, false, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            bool4x4 r3 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int4x4_operator_greater_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            bool4x4 r2 = bool4x4(true, true, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int4x4_operator_greater_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            bool4x4 r0 = bool4x4(true, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            bool4x4 r1 = bool4x4(true, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            bool4x4 r2 = bool4x4(true, false, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            bool4x4 r3 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int4x4_operator_less_equal_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            bool4x4 r0 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            bool4x4 r1 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            bool4x4 r2 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            bool4x4 r3 = bool4x4(true, false, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int4x4_operator_less_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            bool4x4 r2 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int4x4_operator_less_equal_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            bool4x4 r0 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            bool4x4 r1 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            bool4x4 r2 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            bool4x4 r3 = bool4x4(true, true, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int4x4_operator_greater_equal_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            bool4x4 r0 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            bool4x4 r1 = bool4x4(false, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            bool4x4 r2 = bool4x4(true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            bool4x4 r3 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int4x4_operator_greater_equal_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            bool4x4 r2 = bool4x4(true, true, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int4x4_operator_greater_equal_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            bool4x4 r0 = bool4x4(true, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            bool4x4 r1 = bool4x4(true, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            bool4x4 r2 = bool4x4(true, false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            bool4x4 r3 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int4x4_operator_add_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            int4x4 r0 = int4x4(1753445788, -1571347399, -1898445399, -2120762465);
            TestUtils.AreEqual(a0 + b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            int4x4 r1 = int4x4(-2121001103, -1374154154, -1563347043, 1807272757);
            TestUtils.AreEqual(a1 + b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            int4x4 r2 = int4x4(-1232928800, 969132724, 1628197263, -1475122640);
            TestUtils.AreEqual(a2 + b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            int4x4 r3 = int4x4(1725484375, -555794193, 1822598194, -1337371035);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int4x4_operator_add_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(1753445788, -2147344510, 1987315611, 1562860110);
            TestUtils.AreEqual(a0 + b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(2004291956, -2120762465, 1482802362, 1621105669);
            TestUtils.AreEqual(a1 + b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(-1374154154, -1059345928, 1875737585, -1686638894);
            TestUtils.AreEqual(a2 + b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(-1942584419, -1232928800, -1971167735, -1722495789);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int4x4_operator_add_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(1753445788, -1805217222, -1965524397, 1904987398);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(2004291956, -1046412347, -1737814816, -1599511509);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(-1374154154, -518271486, -1878155269, -1145564452);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(-1942584419, 1487283029, 749044094, 997716040);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int4x4_operator_sub_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            int4x4 r0 = int4x4(342127288, 160307175, -682120177, -1244262993);
            TestUtils.AreEqual(a0 - b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            int4x4 r1 = int4x4(-138303307, 541074442, 1359883783, 1029645347);
            TestUtils.AreEqual(a1 - b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            int4x4 r2 = int4x4(865099848, -248671946, 540850477, 1027219152);
            TestUtils.AreEqual(a2 - b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            int4x4 r3 = int4x4(-221441063, 429404557, -1506359214, 242129627);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int4x4_operator_sub_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(342127288, 736304286, 575997111, 151541610);
            TestUtils.AreEqual(a0 - b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(1074350118, 1244262993, 552860524, 691163831);
            TestUtils.AreEqual(a1 - b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(541074442, 855882668, -504001115, 228589702);
            TestUtils.AreEqual(a2 - b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(-1574755467, -865099848, -1603338783, -1354666837);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int4x4_operator_sub_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(342127288, -394176998, -233869823, 190585678);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(1074350118, -169912875, 521489594, 383186287);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(541074442, -314808226, 1045075557, 312484740);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(-1574755467, -709655619, 28583316, -220088630);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int4x4_operator_mul_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            int4x4 r0 = int4x4(1881269428, 1087877264, -597788628, -1317987384);
            TestUtils.AreEqual(a0 * b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            int4x4 r1 = int4x4(-97690630, -203990752, 1138300038, -1583722740);
            TestUtils.AreEqual(a1 * b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            int4x4 r2 = int4x4(-1904051216, -1562929717, -493457666, -1253206016);
            TestUtils.AreEqual(a2 * b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            int4x4 r3 = int4x4(-618913432, 309642718, -1135609888, -147295456);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int4x4_operator_mul_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(1881269428, 1788900128, 1120233282, -1849070088);
            TestUtils.AreEqual(a0 * b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(2063715771, -1317987384, 294328421, -263793070);
            TestUtils.AreEqual(a1 * b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(-203990752, -236771028, 284332834, -73287800);
            TestUtils.AreEqual(a2 * b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(-1379944780, -1904051216, -1146943708, -950497556);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int4x4_operator_mul_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(1881269428, 967126688, -1966598470, -814791656);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(2063715771, -1677802344, -1030180041, 885358150);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(-203990752, 1592110432, -215068912, 1659737152);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(-1379944780, 297850924, -569243875, 1857539895);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int4x4_operator_div_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            int4x4 r0 = int4x4(1, 1, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            int4x4 r1 = int4x4(0, 1, 2, 3);
            TestUtils.AreEqual(a1 / b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            int4x4 r2 = int4x4(1, 0, 1, 2);
            TestUtils.AreEqual(a2 / b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            int4x4 r3 = int4x4(0, 1, 0, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int4x4_operator_div_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(1, 2, 1, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(3, 3, 2, 2);
            TestUtils.AreEqual(a1 / b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(1, 1, 0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(0, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int4x4_operator_div_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(1, 0, 0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(3, 0, 1, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(1, 0, 2, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(0, 0, 1, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int4x4_operator_mod_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            int4x4 r0 = int4x4(342127288, 160307175, 857200860, 464970919);
            TestUtils.AreEqual(a0 % b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            int4x4 r1 = int4x4(1017831443, 541074442, 674015548, 252017937);
            TestUtils.AreEqual(a1 % b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            int4x4 r2 = int4x4(865099848, 360230389, 540850477, 130906400);
            TestUtils.AreEqual(a2 % b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            int4x4 r3 = int4x4(752021656, 429404557, 158119490, 242129627);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int4x4_operator_mod_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(342127288, 30645036, 575997111, 151541610);
            TestUtils.AreEqual(a0 % b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(144408280, 314321155, 87889605, 226192912);
            TestUtils.AreEqual(a1 % b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(541074442, 855882668, 685868235, 228589702);
            TestUtils.AreEqual(a2 % b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int4x4_operator_mod_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(342127288, 1047786538, 1047786538, 190585678);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(144408280, 1539321037, 521489594, 383186287);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(541074442, 1730943792, 359207322, 312484740);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(388813705, 388813705, 28583316, 388813705);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int4x4_operator_plus()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            TestUtils.AreEqual(+a0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            TestUtils.AreEqual(+a1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            TestUtils.AreEqual(+a2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void int4x4_operator_neg()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(-1047786538, -1441963536, -1281656361, -857200860);
            TestUtils.AreEqual(-a0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(-1539321037, -1709233912, -1017831443, -1156134750);
            TestUtils.AreEqual(-a1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(-1730943792, -2045752018, -685868235, -1418459052);
            TestUtils.AreEqual(-a2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(-388813705, -1098469324, -360230389, -608902335);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void int4x4_operator_prefix_inc()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(1047786539, 1441963537, 1281656362, 857200861);
            TestUtils.AreEqual(++a0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(1539321038, 1709233913, 1017831444, 1156134751);
            TestUtils.AreEqual(++a1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(1730943793, 2045752019, 685868236, 1418459053);
            TestUtils.AreEqual(++a2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(388813706, 1098469325, 360230390, 608902336);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void int4x4_operator_postfix_inc()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            TestUtils.AreEqual(a0++, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            TestUtils.AreEqual(a1++, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            TestUtils.AreEqual(a2++, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void int4x4_operator_prefix_dec()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(1047786537, 1441963535, 1281656360, 857200859);
            TestUtils.AreEqual(--a0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(1539321036, 1709233911, 1017831442, 1156134749);
            TestUtils.AreEqual(--a1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(1730943791, 2045752017, 685868234, 1418459051);
            TestUtils.AreEqual(--a2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(388813704, 1098469323, 360230388, 608902334);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void int4x4_operator_postfix_dec()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            TestUtils.AreEqual(a0--, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            TestUtils.AreEqual(a1--, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            TestUtils.AreEqual(a2--, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_and_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            int4x4 r0 = int4x4(704872482, 1147176448, 318769356, 27313312);
            TestUtils.AreEqual(a0 & b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            int4x4 r1 = int4x4(78127122, 1177031456, 685867202, 336122760);
            TestUtils.AreEqual(a1 & b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            int4x4 r2 = int4x4(1091108868, 71830709, 2393104, 807699584);
            TestUtils.AreEqual(a2 & b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            int4x4 r3 = int4x4(671142040, 1612939568, 19178560, 1346984064);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_and_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(704872482, 163856, 134512672, 570916944);
            TestUtils.AreEqual(a0 & b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(461382789, 27313312, 413327363, 10494982);
            TestUtils.AreEqual(a1 & b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(1177031456, 1089188354, 14779394, 1150023460);
            TestUtils.AreEqual(a2 & b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(352882688, 1091108868, 352886804, 604573716);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_and_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(704872482, 343053312, 207651880, 840159240);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(461382789, 1103103176, 411049985, 1086334028);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(1177031456, 1630278160, 538968064, 1141379872);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(352882688, 19415944, 354976129, 67637385);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_or_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            int4x4 r0 = int4x4(1048573306, 1576443449, 2077752541, 2146891519);
            TestUtils.AreEqual(a0 | b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            int4x4 r1 = int4x4(2095839071, 1743781686, 2045753051, 1471149997);
            TestUtils.AreEqual(a1 | b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            int4x4 r2 = int4x4(1970929628, 897302015, 1625804159, 2012145072);
            TestUtils.AreEqual(a2 | b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            int4x4 r3 = int4x4(1054342335, 2126233535, 1803419634, 1610612197);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_or_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(1048573306, 2147458930, 1852802939, 991943166);
            TestUtils.AreEqual(a0 | b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(1542909167, 2146891519, 1069474999, 1610610687);
            TestUtils.AreEqual(a1 | b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(1743781686, 2146433014, 1860958191, 1458304942);
            TestUtils.AreEqual(a2 | b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(1999500189, 1970929628, 1970912757, 1967897791);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(1048573306, 2146696762, 2121791019, 1064828158);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(1542909167, 2145451773, 2146102495, 1609121759);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(1743781686, 2146417650, 1877843963, 2008022972);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(1999500189, 1467867085, 394067965, 930078655);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_xor_wide_wide()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 857200860, 464970919);
            int4x4 b0 = int4x4(705659250, 1281656361, 1539321037, 1709233912);
            int4x4 r0 = int4x4(343700824, 429267001, 1758983185, 2119578207);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4x4 a1 = int4x4(1017831443, 1730943792, 2045752018, 1418459052);
            int4x4 b1 = int4x4(1156134750, 1189869350, 685868235, 388813705);
            int4x4 r1 = int4x4(2017711949, 566750230, 1359885849, 1135027237);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4x4 a2 = int4x4(1963569172, 360230389, 1084523870, 1923531904);
            int4x4 b2 = int4x4(1098469324, 608902335, 543673393, 896312752);
            int4x4 r2 = int4x4(879820760, 825471306, 1623411055, 1204445488);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4x4 a3 = int4x4(752021656, 2084288830, 158119490, 1599862944);
            int4x4 b3 = int4x4(973462719, 1654884273, 1664478704, 1357733317);
            int4x4 r3 = int4x4(383200295, 513293967, 1784241074, 263628133);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_xor_wide_scalar()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(343700824, 2147295074, 1718290267, 421026222);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(1081526378, 2119578207, 656147636, 1600115705);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(566750230, 1057244660, 1846178797, 308281482);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(1646617501, 879820760, 1618025953, 1363324075);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1047786538);
            int4x4 b0 = int4x4(705659250, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(343700824, 1803643450, 1914139139, 224668918);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (1539321037);
            int4x4 b1 = int4x4(464970919, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(1081526378, 1042348597, 1735052510, 522787731);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1730943792);
            int4x4 b2 = int4x4(1189869350, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(566750230, 516139490, 1338875899, 866643100);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (388813705);
            int4x4 b3 = int4x4(1963569172, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(1646617501, 1448451141, 39091836, 862441270);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int4x4_operator_left_shift()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(-794296320, 2017460224, 413401088, 1668284416);
            TestUtils.AreEqual(a0 << b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(-535402880, -261391360, 1433405824, 1956359936);
            TestUtils.AreEqual(a1 << b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(-888747008, 2079110272, 945894080, 587066112);
            TestUtils.AreEqual(a2 << b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(948961280, -54525952, -548405248, -873463808);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void int4x4_operator_right_shift()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int b0 = (705659250);
            int4x4 r0 = int4x4(3996, 5500, 4889, 3269);
            TestUtils.AreEqual(a0 >> b0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int b1 = (464970919);
            int4x4 r1 = int4x4(12025945, 13353389, 7951808, 9032302);
            TestUtils.AreEqual(a1 >> b1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int b2 = (1189869350);
            int4x4 r2 = int4x4(27045996, 31964875, 10716691, 22163422);
            TestUtils.AreEqual(a2 >> b2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int b3 = (1963569172);
            int4x4 r3 = int4x4(370, 1047, 343, 580);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void int4x4_operator_bitwise_not()
        {
            int4x4 a0 = int4x4(1047786538, 1441963536, 1281656361, 857200860);
            int4x4 r0 = int4x4(-1047786539, -1441963537, -1281656362, -857200861);
            TestUtils.AreEqual(~a0, r0);

            int4x4 a1 = int4x4(1539321037, 1709233912, 1017831443, 1156134750);
            int4x4 r1 = int4x4(-1539321038, -1709233913, -1017831444, -1156134751);
            TestUtils.AreEqual(~a1, r1);

            int4x4 a2 = int4x4(1730943792, 2045752018, 685868235, 1418459052);
            int4x4 r2 = int4x4(-1730943793, -2045752019, -685868236, -1418459053);
            TestUtils.AreEqual(~a2, r2);

            int4x4 a3 = int4x4(388813705, 1098469324, 360230389, 608902335);
            int4x4 r3 = int4x4(-388813706, -1098469325, -360230390, -608902336);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
