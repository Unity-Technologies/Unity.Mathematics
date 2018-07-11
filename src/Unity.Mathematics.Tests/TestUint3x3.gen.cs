// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint3x3
    {
        [Test]
        public void uint3x3_operator_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint3x3_operator_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint3x3_operator_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint3x3_operator_not_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint3x3_operator_not_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint3x3_operator_not_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            bool3x3 r2 = bool3x3(false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            bool3x3 r3 = bool3x3(false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            bool3x3 r0 = bool3x3(true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            bool3x3 r0 = bool3x3(true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            bool3x3 r2 = bool3x3(false, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            bool3x3 r2 = bool3x3(true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            bool3x3 r3 = bool3x3(true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            bool3x3 r0 = bool3x3(false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            bool3x3 r0 = bool3x3(false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            bool3x3 r2 = bool3x3(true, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            bool3x3 r3 = bool3x3(true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            bool3x3 r2 = bool3x3(false, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            bool3x3 r3 = bool3x3(false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            bool3x3 r0 = bool3x3(true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            bool3x3 r0 = bool3x3(true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            bool3x3 r2 = bool3x3(false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            bool3x3 r2 = bool3x3(true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            bool3x3 r3 = bool3x3(true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            bool3x3 r0 = bool3x3(false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            bool3x3 r0 = bool3x3(false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            bool3x3 r2 = bool3x3(true, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            bool3x3 r3 = bool3x3(true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint3x3_operator_add_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            uint3x3 r0 = uint3x3(2263814554, 2050306063, 2140441337);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            uint3x3 r1 = uint3x3(2702736003, 857595164, 2409013236);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            uint3x3 r2 = uint3x3(832374812, 1522498022, 2214589827);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            uint3x3 r3 = uint3x3(1428971327, 3073686838, 2337226371);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint3x3_operator_add_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            uint3x3 r0 = uint3x3(2263814554, 1903022505, 3282083372);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            uint3x3 r1 = uint3x3(2140441337, 3785237863, 2462002862);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            uint3x3 r2 = uint3x3(857595164, 1989912240, 718175296);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            uint3x3 r3 = uint3x3(832374812, 608405264, 1443281366);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint3x3_operator_add_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(2263814554, 1032037245, 2411098112);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(2140441337, 2381174478, 1057939477);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(857595164, 2548433104, 1276696160);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(832374812, 911591468, 1746467570);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint3x3_operator_sub_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            uint3x3 r0 = uint3x3(3423982036, 2915906429, 2890903911);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            uint3x3 r1 = uint3x3(1323235001, 558520864, 1271736944);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            uint3x3 r2 = uint3x3(303186204, 3460091194, 3024171641);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            uint3x3 r3 = uint3x3(1035485811, 3360512850, 3807967731);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint3x3_operator_sub_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            uint3x3 r0 = uint3x3(3423982036, 3063189987, 147283558);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            uint3x3 r1 = uint3x3(2890903911, 240733141, 3212465436);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            uint3x3 r2 = uint3x3(558520864, 1690837940, 419100996);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            uint3x3 r3 = uint3x3(303186204, 79216656, 914092758);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint3x3_operator_sub_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(3423982036, 360792049, 3276698478);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(2890903911, 2650170770, 3973405771);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(558520864, 3162650220, 139419868);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(303186204, 223969548, 3684060742);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint3x3_operator_mul_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            uint3x3 r0 = uint3x3(1199537733, 2989204854, 708178864);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            uint3x3 r1 = uint3x3(2577613654, 558216644, 4091413476);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            uint3x3 r2 = uint3x3(545694208, 2850181728, 289546486);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            uint3x3 r3 = uint3x3(2493650038, 460871752, 1741735576);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint3x3_operator_mul_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            uint3x3 r0 = uint3x3(1199537733, 1753291922, 3067466171);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            uint3x3 r1 = uint3x3(708178864, 142777358, 155900109);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            uint3x3 r2 = uint3x3(558216644, 1172013212, 703737212);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            uint3x3 r3 = uint3x3(545694208, 3567417344, 3745279232);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint3x3_operator_mul_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(1199537733, 3495885450, 3564830511);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(708178864, 2050040224, 664219888);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(558216644, 958380764, 3460676028);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(545694208, 3113610176, 1129952360);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint3x3_operator_div_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            uint3x3 r0 = uint3x3(0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            uint3x3 r1 = uint3x3(2, 4, 3);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            uint3x3 r2 = uint3x3(2, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            uint3x3 r3 = uint3x3(6, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint3x3_operator_div_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            uint3x3 r0 = uint3x3(0, 0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            uint3x3 r1 = uint3x3(0, 1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            uint3x3 r2 = uint3x3(4, 12, 3);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            uint3x3 r3 = uint3x3(2, 1, 4);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint3x3_operator_div_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(0, 2, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(4, 0, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(2, 1, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint3x3_operator_mod_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            uint3x3 r0 = uint3x3(696414647, 335622598, 368188976);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            uint3x3 r1 = uint3x3(633484500, 109909414, 134460652);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            uint3x3 r2 = uint3x3(38591900, 343810960, 471897086);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            uint3x3 r3 = uint3x3(51772021, 1069616196, 925113403);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint3x3_operator_mod_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            uint3x3 r0 = uint3x3(696414647, 335622598, 147283558);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            uint3x3 r1 = uint3x3(368188976, 240733141, 689750501);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            uint3x3 r2 = uint3x3(109909414, 45929290, 120026696);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            uint3x3 r3 = uint3x3(38591900, 79216656, 120309846);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint3x3_operator_mod_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(696414647, 25169451, 696414647);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(368188976, 368188976, 368188976);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(109909414, 708058014, 139419868);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(38591900, 223969548, 567780508);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint3x3_operator_plus()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(696414647, 335622598, 1714683465);
            TestUtils.AreEqual(+a0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(368188976, 2012985502, 689750501);
            TestUtils.AreEqual(+a1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(708058014, 1840375090, 568638146);
            TestUtils.AreEqual(+a2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(567780508, 343810960, 1178687062);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void uint3x3_operator_neg()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(3598552649, 3959344698, 2580283831);
            TestUtils.AreEqual(-a0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(3926778320, 2281981794, 3605216795);
            TestUtils.AreEqual(-a1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(3586909282, 2454592206, 3726329150);
            TestUtils.AreEqual(-a2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(3727186788, 3951156336, 3116280234);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void uint3x3_operator_prefix_inc()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(696414648, 335622599, 1714683466);
            TestUtils.AreEqual(++a0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(368188977, 2012985503, 689750502);
            TestUtils.AreEqual(++a1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(708058015, 1840375091, 568638147);
            TestUtils.AreEqual(++a2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(567780509, 343810961, 1178687063);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void uint3x3_operator_postfix_inc()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(696414647, 335622598, 1714683465);
            TestUtils.AreEqual(a0++, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(368188976, 2012985502, 689750501);
            TestUtils.AreEqual(a1++, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(708058014, 1840375090, 568638146);
            TestUtils.AreEqual(a2++, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(567780508, 343810960, 1178687062);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void uint3x3_operator_prefix_dec()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(696414646, 335622597, 1714683464);
            TestUtils.AreEqual(--a0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(368188975, 2012985501, 689750500);
            TestUtils.AreEqual(--a1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(708058013, 1840375089, 568638145);
            TestUtils.AreEqual(--a2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(567780507, 343810959, 1178687061);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void uint3x3_operator_postfix_dec()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(696414647, 335622598, 1714683465);
            TestUtils.AreEqual(a0--, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(368188976, 2012985502, 689750501);
            TestUtils.AreEqual(a1--, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(708058014, 1840375090, 568638146);
            TestUtils.AreEqual(a2--, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(567780508, 343810960, 1178687062);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_and_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            uint3x3 r0 = uint3x3(150999459, 67186752, 27397120);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            uint3x3 r1 = uint3x3(555253892, 136315166, 564174850);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            uint3x3 r2 = uint3x3(29696128, 71303696, 67109252);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            uint3x3 r3 = uint3x3(154271808, 927006784, 337641480);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_and_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            uint3x3 r0 = uint3x3(150999459, 335548866, 1142988353);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            uint3x3 r1 = uint3x3(27397120, 1638017160, 687882433);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            uint3x3 r2 = uint3x3(136315166, 144818482, 14712898);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            uint3x3 r3 = uint3x3(29696128, 71574400, 104940032);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(150999459, 12678, 537030657);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(27397120, 368187408, 17825824);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(136315166, 674234642, 539236994);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(29696128, 5644432, 4260884);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_or_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            uint3x3 r0 = uint3x3(2112815095, 1983119311, 2113044217);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            uint3x3 r1 = uint3x3(2147482111, 721279998, 1844838386);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            uint3x3 r2 = uint3x3(802678684, 1451194326, 2147480575);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            uint3x3 r3 = uint3x3(1274699519, 2146680054, 1999584891);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_or_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            uint3x3 r0 = uint3x3(2112815095, 1567473639, 2139095019);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            uint3x3 r1 = uint3x3(2113044217, 2147220703, 1774120429);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            uint3x3 r2 = uint3x3(721279998, 1845093758, 703462398);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            uint3x3 r3 = uint3x3(802678684, 536830864, 1338341334);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(2112815095, 1032024567, 1874067455);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(2113044217, 2012987070, 1040113653);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(721279998, 1874198462, 737459166);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(802678684, 905947036, 1742206686);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_xor_wide_wide()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 368188976);
            uint3x3 b0 = uint3x3(1567399907, 1714683465, 1772252361);
            uint3x3 r0 = uint3x3(1961815636, 1915932559, 2085647097);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x3 a1 = uint3x3(2012985502, 708058014, 1840375090);
            uint3x3 b1 = uint3x3(689750501, 149537150, 568638146);
            uint3x3 r1 = uint3x3(1592228219, 584964832, 1280663536);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x3 a2 = uint3x3(567780508, 343810960, 471897086);
            uint3x3 b2 = uint3x3(264594304, 1178687062, 1742692741);
            uint3x3 r2 = uint3x3(772982556, 1379890630, 2080371323);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x3 a3 = uint3x3(1232228569, 1069616196, 925113403);
            uint3x3 b3 = uint3x3(196742758, 2004070642, 1412112968);
            uint3x3 r3 = uint3x3(1120427711, 1219673270, 1661943411);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_xor_wide_scalar()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint b0 = (1567399907);
            uint3x3 r0 = uint3x3(1961815636, 1231924773, 996106666);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint b1 = (1772252361);
            uint3x3 r1 = uint3x3(2085647097, 509203543, 1086237996);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint b2 = (149537150);
            uint3x3 r2 = uint3x3(584964832, 1700275276, 688749500);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint b3 = (264594304);
            uint3x3 r3 = uint3x3(772982556, 465256464, 1233401302);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (696414647);
            uint3x3 b0 = uint3x3(1567399907, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(1961815636, 1032011889, 1337036798);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (368188976);
            uint3x3 b1 = uint3x3(1772252361, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(2085647097, 1644799662, 1022287829);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (708058014);
            uint3x3 b2 = uint3x3(149537150, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(584964832, 1199963820, 198222172);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (567780508);
            uint3x3 b3 = uint3x3(264594304, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(772982556, 900302604, 1737945802);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint3x3_operator_left_shift()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            int b0 = (1567399907);
            uint3x3 r0 = uint3x3(1276349880, 2684980784, 832565832);
            TestUtils.AreEqual(a0 << b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            int b1 = (1772252361);
            uint3x3 r1 = uint3x3(3829161984, 4151393280, 964938240);
            TestUtils.AreEqual(a1 << b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            int b2 = (149537150);
            uint3x3 r2 = uint3x3(2147483648, 2147483648, 2147483648);
            TestUtils.AreEqual(a2 << b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            int b3 = (264594304);
            uint3x3 r3 = uint3x3(567780508, 343810960, 1178687062);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void uint3x3_operator_right_shift()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            int b0 = (1567399907);
            uint3x3 r0 = uint3x3(87051830, 41952824, 214335433);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            int b1 = (1772252361);
            uint3x3 r1 = uint3x3(719119, 3931612, 1347168);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            int b2 = (149537150);
            uint3x3 r2 = uint3x3(0, 1, 0);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            int b3 = (264594304);
            uint3x3 r3 = uint3x3(567780508, 343810960, 1178687062);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_not()
        {
            uint3x3 a0 = uint3x3(696414647, 335622598, 1714683465);
            uint3x3 r0 = uint3x3(3598552648, 3959344697, 2580283830);
            TestUtils.AreEqual(~a0, r0);

            uint3x3 a1 = uint3x3(368188976, 2012985502, 689750501);
            uint3x3 r1 = uint3x3(3926778319, 2281981793, 3605216794);
            TestUtils.AreEqual(~a1, r1);

            uint3x3 a2 = uint3x3(708058014, 1840375090, 568638146);
            uint3x3 r2 = uint3x3(3586909281, 2454592205, 3726329149);
            TestUtils.AreEqual(~a2, r2);

            uint3x3 a3 = uint3x3(567780508, 343810960, 1178687062);
            uint3x3 r3 = uint3x3(3727186787, 3951156335, 3116280233);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
