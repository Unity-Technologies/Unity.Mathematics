// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint2x2
    {
        [Test]
        public void uint2x2_operator_equal_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint2x2_operator_equal_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint2x2_operator_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint2x2_operator_not_equal_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint2x2_operator_not_equal_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint2x2_operator_not_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint2x2_operator_less_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            bool2x2 r3 = bool2x2(false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint2x2_operator_less_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint2x2_operator_less_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            bool2x2 r0 = bool2x2(true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint2x2_operator_greater_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            bool2x2 r3 = bool2x2(true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint2x2_operator_greater_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint2x2_operator_greater_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            bool2x2 r0 = bool2x2(false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint2x2_operator_less_equal_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            bool2x2 r3 = bool2x2(false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint2x2_operator_less_equal_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint2x2_operator_less_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            bool2x2 r0 = bool2x2(true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint2x2_operator_greater_equal_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            bool2x2 r3 = bool2x2(true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint2x2_operator_greater_equal_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint2x2_operator_greater_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            bool2x2 r0 = bool2x2(false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint2x2_operator_add_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            uint2x2 r0 = uint2x2(2263814554, 2050306063);
            TestUtils.AreEqual(a0 + b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            uint2x2 r1 = uint2x2(2140441337, 2702736003);
            TestUtils.AreEqual(a1 + b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            uint2x2 r2 = uint2x2(857595164, 2409013236);
            TestUtils.AreEqual(a2 + b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            uint2x2 r3 = uint2x2(832374812, 1522498022);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint2x2_operator_add_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            uint2x2 r0 = uint2x2(2263814554, 1903022505);
            TestUtils.AreEqual(a0 + b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            uint2x2 r1 = uint2x2(2082872441, 2140441337);
            TestUtils.AreEqual(a1 + b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            uint2x2 r2 = uint2x2(2702736003, 1397808515);
            TestUtils.AreEqual(a2 + b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            uint2x2 r3 = uint2x2(1989912240, 2409013236);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint2x2_operator_add_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            uint2x2 r0 = uint2x2(2263814554, 1032037245);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            uint2x2 r1 = uint2x2(2082872441, 3486935826);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            uint2x2 r2 = uint2x2(2702736003, 2721043516);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            uint2x2 r3 = uint2x2(1989912240, 718175296);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint2x2_operator_sub_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            uint2x2 r0 = uint2x2(3423982036, 2915906429);
            TestUtils.AreEqual(a0 - b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            uint2x2 r1 = uint2x2(2890903911, 1323235001);
            TestUtils.AreEqual(a1 - b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            uint2x2 r2 = uint2x2(558520864, 1271736944);
            TestUtils.AreEqual(a2 - b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            uint2x2 r3 = uint2x2(303186204, 3460091194);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint2x2_operator_sub_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            uint2x2 r0 = uint2x2(3423982036, 3063189987);
            TestUtils.AreEqual(a0 - b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            uint2x2 r1 = uint2x2(1346494489, 1404063385);
            TestUtils.AreEqual(a1 - b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            uint2x2 r2 = uint2x2(1323235001, 18307513);
            TestUtils.AreEqual(a2 - b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            uint2x2 r3 = uint2x2(2604129356, 3023230352);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint2x2_operator_sub_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            uint2x2 r0 = uint2x2(3423982036, 360792049);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            uint2x2 r1 = uint2x2(1346494489, 4237398400);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            uint2x2 r2 = uint2x2(1323235001, 1304927488);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            uint2x2 r3 = uint2x2(2604129356, 3875866300);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint2x2_operator_mul_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            uint2x2 r0 = uint2x2(1199537733, 2989204854);
            TestUtils.AreEqual(a0 * b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            uint2x2 r1 = uint2x2(708178864, 2577613654);
            TestUtils.AreEqual(a1 * b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            uint2x2 r2 = uint2x2(558216644, 4091413476);
            TestUtils.AreEqual(a2 * b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            uint2x2 r3 = uint2x2(545694208, 2850181728);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint2x2_operator_mul_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            uint2x2 r0 = uint2x2(1199537733, 1753291922);
            TestUtils.AreEqual(a0 * b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            uint2x2 r1 = uint2x2(2676898736, 708178864);
            TestUtils.AreEqual(a1 * b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            uint2x2 r2 = uint2x2(2577613654, 1555485270);
            TestUtils.AreEqual(a2 * b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            uint2x2 r3 = uint2x2(1172013212, 4091413476);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint2x2_operator_mul_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            uint2x2 r0 = uint2x2(1199537733, 3495885450);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            uint2x2 r1 = uint2x2(2676898736, 155939665);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            uint2x2 r2 = uint2x2(2577613654, 99392388);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            uint2x2 r3 = uint2x2(1172013212, 703737212);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint2x2_operator_div_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            uint2x2 r0 = uint2x2(0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            uint2x2 r1 = uint2x2(0, 2);
            TestUtils.AreEqual(a1 / b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            uint2x2 r2 = uint2x2(4, 3);
            TestUtils.AreEqual(a2 / b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            uint2x2 r3 = uint2x2(2, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint2x2_operator_div_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            uint2x2 r0 = uint2x2(0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            uint2x2 r1 = uint2x2(4, 4);
            TestUtils.AreEqual(a1 / b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            uint2x2 r2 = uint2x2(2, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            uint2x2 r3 = uint2x2(0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint2x2_operator_div_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            uint2x2 r0 = uint2x2(0, 2);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            uint2x2 r1 = uint2x2(4, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            uint2x2 r2 = uint2x2(2, 2);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            uint2x2 r3 = uint2x2(0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint2x2_operator_mod_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            uint2x2 r0 = uint2x2(696414647, 335622598);
            TestUtils.AreEqual(a0 % b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            uint2x2 r1 = uint2x2(368188976, 633484500);
            TestUtils.AreEqual(a1 % b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            uint2x2 r2 = uint2x2(109909414, 134460652);
            TestUtils.AreEqual(a2 % b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            uint2x2 r3 = uint2x2(38591900, 343810960);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint2x2_operator_mod_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            uint2x2 r0 = uint2x2(696414647, 335622598);
            TestUtils.AreEqual(a0 % b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            uint2x2 r1 = uint2x2(241927561, 299496457);
            TestUtils.AreEqual(a1 % b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            uint2x2 r2 = uint2x2(633484500, 18307513);
            TestUtils.AreEqual(a2 % b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            uint2x2 r3 = uint2x2(149537150, 568638146);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint2x2_operator_mod_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            uint2x2 r0 = uint2x2(696414647, 25169451);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            uint2x2 r1 = uint2x2(241927561, 1714683465);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            uint2x2 r2 = uint2x2(633484500, 596869474);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            uint2x2 r3 = uint2x2(149537150, 149537150);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint2x2_operator_plus()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 r0 = uint2x2(696414647, 335622598);
            TestUtils.AreEqual(+a0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint2x2 r1 = uint2x2(1714683465, 1772252361);
            TestUtils.AreEqual(+a1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint2x2 r2 = uint2x2(2012985502, 708058014);
            TestUtils.AreEqual(+a2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint2x2 r3 = uint2x2(149537150, 568638146);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void uint2x2_operator_neg()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 r0 = uint2x2(3598552649, 3959344698);
            TestUtils.AreEqual(-a0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint2x2 r1 = uint2x2(2580283831, 2522714935);
            TestUtils.AreEqual(-a1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint2x2 r2 = uint2x2(2281981794, 3586909282);
            TestUtils.AreEqual(-a2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint2x2 r3 = uint2x2(4145430146, 3726329150);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void uint2x2_operator_prefix_inc()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 r0 = uint2x2(696414648, 335622599);
            TestUtils.AreEqual(++a0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint2x2 r1 = uint2x2(1714683466, 1772252362);
            TestUtils.AreEqual(++a1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint2x2 r2 = uint2x2(2012985503, 708058015);
            TestUtils.AreEqual(++a2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint2x2 r3 = uint2x2(149537151, 568638147);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void uint2x2_operator_postfix_inc()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 r0 = uint2x2(696414647, 335622598);
            TestUtils.AreEqual(a0++, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint2x2 r1 = uint2x2(1714683465, 1772252361);
            TestUtils.AreEqual(a1++, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint2x2 r2 = uint2x2(2012985502, 708058014);
            TestUtils.AreEqual(a2++, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint2x2 r3 = uint2x2(149537150, 568638146);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void uint2x2_operator_prefix_dec()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 r0 = uint2x2(696414646, 335622597);
            TestUtils.AreEqual(--a0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint2x2 r1 = uint2x2(1714683464, 1772252360);
            TestUtils.AreEqual(--a1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint2x2 r2 = uint2x2(2012985501, 708058013);
            TestUtils.AreEqual(--a2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint2x2 r3 = uint2x2(149537149, 568638145);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void uint2x2_operator_postfix_dec()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 r0 = uint2x2(696414647, 335622598);
            TestUtils.AreEqual(a0--, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint2x2 r1 = uint2x2(1714683465, 1772252361);
            TestUtils.AreEqual(a1--, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint2x2 r2 = uint2x2(2012985502, 708058014);
            TestUtils.AreEqual(a2--, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint2x2 r3 = uint2x2(149537150, 568638146);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_and_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            uint2x2 r0 = uint2x2(150999459, 67186752);
            TestUtils.AreEqual(a0 & b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            uint2x2 r1 = uint2x2(27397120, 555253892);
            TestUtils.AreEqual(a1 & b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            uint2x2 r2 = uint2x2(136315166, 564174850);
            TestUtils.AreEqual(a2 & b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            uint2x2 r3 = uint2x2(29696128, 71303696);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_and_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            uint2x2 r0 = uint2x2(150999459, 335548866);
            TestUtils.AreEqual(a0 & b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            uint2x2 r1 = uint2x2(70393344, 27397120);
            TestUtils.AreEqual(a1 & b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            uint2x2 r2 = uint2x2(555253892, 672399748);
            TestUtils.AreEqual(a2 & b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            uint2x2 r3 = uint2x2(144818482, 564174850);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            uint2x2 r0 = uint2x2(150999459, 12678);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            uint2x2 r1 = uint2x2(70393344, 1612868681);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            uint2x2 r2 = uint2x2(555253892, 573577374);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            uint2x2 r3 = uint2x2(144818482, 14712898);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_or_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            uint2x2 r0 = uint2x2(2112815095, 1983119311);
            TestUtils.AreEqual(a0 | b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            uint2x2 r1 = uint2x2(2113044217, 2147482111);
            TestUtils.AreEqual(a1 | b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            uint2x2 r2 = uint2x2(721279998, 1844838386);
            TestUtils.AreEqual(a2 | b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            uint2x2 r3 = uint2x2(802678684, 1451194326);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_or_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            uint2x2 r0 = uint2x2(2112815095, 1567473639);
            TestUtils.AreEqual(a0 | b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            uint2x2 r1 = uint2x2(2012479097, 2113044217);
            TestUtils.AreEqual(a1 | b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            uint2x2 r2 = uint2x2(2147482111, 725408767);
            TestUtils.AreEqual(a2 | b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            uint2x2 r3 = uint2x2(1845093758, 1844838386);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            uint2x2 r0 = uint2x2(2112815095, 1032024567);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            uint2x2 r1 = uint2x2(2012479097, 1874067145);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            uint2x2 r2 = uint2x2(2147482111, 2147466142);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            uint2x2 r3 = uint2x2(1845093758, 703462398);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_xor_wide_wide()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 b0 = uint2x2(1567399907, 1714683465);
            uint2x2 r0 = uint2x2(1961815636, 1915932559);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint2x2 a1 = uint2x2(368188976, 2012985502);
            uint2x2 b1 = uint2x2(1772252361, 689750501);
            uint2x2 r1 = uint2x2(2085647097, 1592228219);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint2x2 a2 = uint2x2(708058014, 1840375090);
            uint2x2 b2 = uint2x2(149537150, 568638146);
            uint2x2 r2 = uint2x2(584964832, 1280663536);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint2x2 a3 = uint2x2(567780508, 343810960);
            uint2x2 b3 = uint2x2(264594304, 1178687062);
            uint2x2 r3 = uint2x2(772982556, 1379890630);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_xor_wide_scalar()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint b0 = (1567399907);
            uint2x2 r0 = uint2x2(1961815636, 1231924773);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint b1 = (368188976);
            uint2x2 r1 = uint2x2(1942085753, 2085647097);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint b2 = (689750501);
            uint2x2 r2 = uint2x2(1592228219, 53009019);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint b3 = (1840375090);
            uint2x2 r3 = uint2x2(1700275276, 1280663536);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (696414647);
            uint2x2 b0 = uint2x2(1567399907, 335622598);
            uint2x2 r0 = uint2x2(1961815636, 1032011889);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (1714683465);
            uint2x2 b1 = uint2x2(368188976, 1772252361);
            uint2x2 r1 = uint2x2(1942085753, 261198464);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (2012985502);
            uint2x2 b2 = uint2x2(689750501, 708058014);
            uint2x2 r2 = uint2x2(1592228219, 1573888768);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (149537150);
            uint2x2 b3 = uint2x2(1840375090, 568638146);
            uint2x2 r3 = uint2x2(1700275276, 688749500);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint2x2_operator_left_shift()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            int b0 = (1567399907);
            uint2x2 r0 = uint2x2(1276349880, 2684980784);
            TestUtils.AreEqual(a0 << b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            int b1 = (368188976);
            uint2x2 r1 = uint2x2(4266196992, 1825112064);
            TestUtils.AreEqual(a1 << b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            int b2 = (689750501);
            uint2x2 r2 = uint2x2(4285993920, 1183019968);
            TestUtils.AreEqual(a2 << b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            int b3 = (1840375090);
            uint2x2 r3 = uint2x2(100139008, 3943170048);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void uint2x2_operator_right_shift()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            int b0 = (1567399907);
            uint2x2 r0 = uint2x2(87051830, 41952824);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            int b1 = (368188976);
            uint2x2 r1 = uint2x2(26163, 27042);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            int b2 = (689750501);
            uint2x2 r2 = uint2x2(62905796, 22126812);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            int b3 = (1840375090);
            uint2x2 r3 = uint2x2(570, 2169);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void uint2x2_operator_bitwise_not()
        {
            uint2x2 a0 = uint2x2(696414647, 335622598);
            uint2x2 r0 = uint2x2(3598552648, 3959344697);
            TestUtils.AreEqual(~a0, r0);

            uint2x2 a1 = uint2x2(1714683465, 1772252361);
            uint2x2 r1 = uint2x2(2580283830, 2522714934);
            TestUtils.AreEqual(~a1, r1);

            uint2x2 a2 = uint2x2(2012985502, 708058014);
            uint2x2 r2 = uint2x2(2281981793, 3586909281);
            TestUtils.AreEqual(~a2, r2);

            uint2x2 a3 = uint2x2(149537150, 568638146);
            uint2x2 r3 = uint2x2(4145430145, 3726329149);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
