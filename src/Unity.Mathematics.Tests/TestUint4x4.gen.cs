// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint4x4
    {
        [Test]
        public void uint4x4_operator_equal_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint4x4_operator_equal_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint4x4_operator_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint4x4_operator_not_equal_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint4x4_operator_not_equal_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint4x4_operator_not_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint4x4_operator_less_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            bool4x4 r0 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            bool4x4 r1 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            bool4x4 r2 = bool4x4(true, false, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            bool4x4 r3 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint4x4_operator_less_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            bool4x4 r0 = bool4x4(true, true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            bool4x4 r2 = bool4x4(false, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            bool4x4 r3 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint4x4_operator_less_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            bool4x4 r0 = bool4x4(true, false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            bool4x4 r1 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            bool4x4 r3 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint4x4_operator_greater_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            bool4x4 r0 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            bool4x4 r1 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            bool4x4 r2 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            bool4x4 r3 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint4x4_operator_greater_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            bool4x4 r0 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            bool4x4 r2 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            bool4x4 r3 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint4x4_operator_greater_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            bool4x4 r0 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            bool4x4 r1 = bool4x4(false, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            bool4x4 r3 = bool4x4(true, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint4x4_operator_less_equal_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            bool4x4 r0 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            bool4x4 r1 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            bool4x4 r2 = bool4x4(true, false, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            bool4x4 r3 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint4x4_operator_less_equal_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            bool4x4 r0 = bool4x4(true, true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            bool4x4 r2 = bool4x4(false, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            bool4x4 r3 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint4x4_operator_less_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            bool4x4 r0 = bool4x4(true, false, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            bool4x4 r1 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            bool4x4 r3 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint4x4_operator_greater_equal_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            bool4x4 r0 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            bool4x4 r1 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            bool4x4 r2 = bool4x4(false, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            bool4x4 r3 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint4x4_operator_greater_equal_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            bool4x4 r0 = bool4x4(false, false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            bool4x4 r2 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            bool4x4 r3 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint4x4_operator_greater_equal_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            bool4x4 r0 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            bool4x4 r1 = bool4x4(false, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            bool4x4 r3 = bool4x4(true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint4x4_operator_add_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            uint4x4 r0 = uint4x4(2263814554, 2050306063, 2140441337, 2702736003);
            TestUtils.AreEqual(a0 + b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            uint4x4 r1 = uint4x4(857595164, 2409013236, 832374812, 1522498022);
            TestUtils.AreEqual(a1 + b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            uint4x4 r2 = uint4x4(2214589827, 1428971327, 3073686838, 2337226371);
            TestUtils.AreEqual(a2 + b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            uint4x4 r3 = uint4x4(1978524218, 2000986649, 2302751487, 1859734881);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint4x4_operator_add_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            uint4x4 r0 = uint4x4(2263814554, 1903022505, 3282083372, 1935588883);
            TestUtils.AreEqual(a0 + b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            uint4x4 r1 = uint4x4(3785237863, 2702736003, 2721043516, 2162522652);
            TestUtils.AreEqual(a1 + b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            uint4x4 r2 = uint4x4(2409013236, 1136418654, 833232450, 912449106);
            TestUtils.AreEqual(a2 + b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            uint4x4 r3 = uint4x4(1650584148, 2214589827, 1704125655, 668639844);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint4x4_operator_add_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(2263814554, 1032037245, 2411098112, 1064603623);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(3785237863, 2462002862, 2480310375, 1921789511);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(2409013236, 2408155598, 2104969394, 2184186050);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(1650584148, 2921379803, 2410915631, 1375429820);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint4x4_operator_sub_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            uint4x4 r0 = uint4x4(3423982036, 2915906429, 2890903911, 1323235001);
            TestUtils.AreEqual(a0 - b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            uint4x4 r1 = uint4x4(558520864, 1271736944, 303186204, 3460091194);
            TestUtils.AreEqual(a1 - b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            uint4x4 r2 = uint4x4(3024171641, 1035485811, 3360512850, 3807967731);
            TestUtils.AreEqual(a2 - b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            uint4x4 r3 = uint4x4(1544521810, 1722952213, 2923472373, 3649249429);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint4x4_operator_sub_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            uint4x4 r0 = uint4x4(3423982036, 3063189987, 147283558, 3095756365);
            TestUtils.AreEqual(a0 - b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            uint4x4 r1 = uint4x4(4054234155, 2971732295, 2990039808, 2431518944);
            TestUtils.AreEqual(a1 - b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            uint4x4 r2 = uint4x4(1271736944, 4294109658, 3990923454, 4070140110);
            TestUtils.AreEqual(a2 - b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            uint4x4 r3 = uint4x4(706789976, 1270795655, 760331483, 4019812968);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint4x4_operator_sub_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(3423982036, 360792049, 3276698478, 328225671);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(4054234155, 1082501860, 1064194347, 1622715211);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(1271736944, 1272594582, 1575780786, 1496564130);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(706789976, 3730961617, 4241425789, 981944304);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint4x4_operator_mul_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            uint4x4 r0 = uint4x4(1199537733, 2989204854, 708178864, 2577613654);
            TestUtils.AreEqual(a0 * b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            uint4x4 r1 = uint4x4(558216644, 4091413476, 545694208, 2850181728);
            TestUtils.AreEqual(a1 * b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            uint4x4 r2 = uint4x4(289546486, 2493650038, 460871752, 1741735576);
            TestUtils.AreEqual(a2 * b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            uint4x4 r3 = uint4x4(1581698744, 2658349102, 1524905826, 2865527298);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint4x4_operator_mul_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            uint4x4 r0 = uint4x4(1199537733, 1753291922, 3067466171, 45126800);
            TestUtils.AreEqual(a0 * b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            uint4x4 r1 = uint4x4(142777358, 2577613654, 99392388, 3420584900);
            TestUtils.AreEqual(a1 * b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            uint4x4 r2 = uint4x4(4091413476, 166991416, 2078304000, 1772983072);
            TestUtils.AreEqual(a2 * b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            uint4x4 r3 = uint4x4(1814498132, 289546486, 1526256206, 1839127348);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint4x4_operator_mul_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(1199537733, 3495885450, 3564830511, 2479277136);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(142777358, 155900109, 1720473358, 3169194990);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(4091413476, 3191452280, 4061064960, 3171074592);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(1814498132, 278032558, 4037611238, 4248640068);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint4x4_operator_div_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            uint4x4 r0 = uint4x4(0, 0, 0, 2);
            TestUtils.AreEqual(a0 / b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            uint4x4 r1 = uint4x4(4, 3, 2, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            uint4x4 r2 = uint4x4(0, 6, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            uint4x4 r3 = uint4x4(8, 13, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint4x4_operator_div_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            uint4x4 r0 = uint4x4(0, 0, 1, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            uint4x4 r1 = uint4x4(0, 0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            uint4x4 r2 = uint4x4(3, 0, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            uint4x4 r3 = uint4x4(2, 3, 2, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint4x4_operator_div_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(0, 2, 0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(0, 2, 2, 11);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(3, 3, 6, 5);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(2, 0, 0, 5);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint4x4_operator_mod_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            uint4x4 r0 = uint4x4(696414647, 335622598, 368188976, 633484500);
            TestUtils.AreEqual(a0 % b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            uint4x4 r1 = uint4x4(109909414, 134460652, 38591900, 343810960);
            TestUtils.AreEqual(a1 % b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            uint4x4 r2 = uint4x4(471897086, 51772021, 1069616196, 925113403);
            TestUtils.AreEqual(a2 % b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            uint4x4 r3 = uint4x4(25513382, 54745597, 465628282, 607008507);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint4x4_operator_mod_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            uint4x4 r0 = uint4x4(696414647, 335622598, 147283558, 368188976);
            TestUtils.AreEqual(a0 % b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            uint4x4 r1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            TestUtils.AreEqual(a1 % b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            uint4x4 r2 = uint4x4(134460652, 567780508, 264594304, 343810960);
            TestUtils.AreEqual(a2 % b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            uint4x4 r3 = uint4x4(234892890, 327001483, 288434397, 196742758);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint4x4_operator_mod_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(696414647, 25169451, 696414647, 328225671);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(1772252361, 392751359, 356136333, 127343711);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(134460652, 137033566, 252809266, 121320290);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(234892890, 1178687062, 1178687062, 194973272);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint4x4_operator_plus()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            TestUtils.AreEqual(+a0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            TestUtils.AreEqual(+a1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            TestUtils.AreEqual(+a2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void uint4x4_operator_neg()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(3598552649, 3959344698, 2580283831, 3926778320);
            TestUtils.AreEqual(-a0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(2522714935, 3605216795, 3586909282, 4145430146);
            TestUtils.AreEqual(-a1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(2454592206, 3727186788, 4030372992, 3951156336);
            TestUtils.AreEqual(-a2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(3116280234, 2552274555, 3062738727, 4098224538);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void uint4x4_operator_prefix_inc()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(696414648, 335622599, 1714683466, 368188977);
            TestUtils.AreEqual(++a0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(1772252362, 689750502, 708058015, 149537151);
            TestUtils.AreEqual(++a1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(1840375091, 567780509, 264594305, 343810961);
            TestUtils.AreEqual(++a2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(1178687063, 1742692742, 1232228570, 196742759);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void uint4x4_operator_postfix_inc()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            TestUtils.AreEqual(a0++, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            TestUtils.AreEqual(a1++, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            TestUtils.AreEqual(a2++, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void uint4x4_operator_prefix_dec()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(696414646, 335622597, 1714683464, 368188975);
            TestUtils.AreEqual(--a0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(1772252360, 689750500, 708058013, 149537149);
            TestUtils.AreEqual(--a1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(1840375089, 567780507, 264594303, 343810959);
            TestUtils.AreEqual(--a2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(1178687061, 1742692740, 1232228568, 196742757);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void uint4x4_operator_postfix_dec()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            TestUtils.AreEqual(a0--, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            TestUtils.AreEqual(a1--, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            TestUtils.AreEqual(a2--, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_and_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            uint4x4 r0 = uint4x4(150999459, 67186752, 27397120, 555253892);
            TestUtils.AreEqual(a0 & b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            uint4x4 r1 = uint4x4(136315166, 564174850, 29696128, 71303696);
            TestUtils.AreEqual(a1 & b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            uint4x4 r2 = uint4x4(67109252, 154271808, 927006784, 337641480);
            TestUtils.AreEqual(a2 & b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            uint4x4 r3 = uint4x4(149824580, 139011074, 159400960, 2758242);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_and_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            uint4x4 r0 = uint4x4(150999459, 335548866, 1142988353, 358620704);
            TestUtils.AreEqual(a0 & b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            uint4x4 r1 = uint4x4(1638017160, 555253892, 573577374, 15302686);
            TestUtils.AreEqual(a1 & b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            uint4x4 r2 = uint4x4(564174850, 566534272, 29631104, 6562432);
            TestUtils.AreEqual(a2 & b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            uint4x4 r3 = uint4x4(67113558, 67109252, 136319192, 136315494);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(150999459, 12678, 537030657, 25301040);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(1638017160, 687882433, 673187976, 144719944);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(564174850, 563192848, 226582784, 70263056);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(67113558, 1178681348, 1077956688, 33556038);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_or_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            uint4x4 r0 = uint4x4(2112815095, 1983119311, 2113044217, 2147482111);
            TestUtils.AreEqual(a0 | b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            uint4x4 r1 = uint4x4(721279998, 1844838386, 802678684, 1451194326);
            TestUtils.AreEqual(a1 | b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            uint4x4 r2 = uint4x4(2147480575, 1274699519, 2146680054, 1999584891);
            TestUtils.AreEqual(a2 | b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            uint4x4 r3 = uint4x4(1828699638, 1861975575, 2143350527, 1856976639);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_or_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            uint4x4 r0 = uint4x4(2112815095, 1567473639, 2139095019, 1576968179);
            TestUtils.AreEqual(a0 | b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            uint4x4 r1 = uint4x4(2147220703, 2147482111, 2147466142, 2147219966);
            TestUtils.AreEqual(a1 | b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            uint4x4 r2 = uint4x4(1844838386, 569884382, 803601346, 905886674);
            TestUtils.AreEqual(a2 | b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            uint4x4 r3 = uint4x4(1583470590, 2147480575, 1567806463, 532324350);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(2112815095, 1032024567, 1874067455, 1039302583);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(2147220703, 1774120429, 1807122399, 1777069567);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(1844838386, 1844962750, 1878386610, 2113922994);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(1583470590, 1742698455, 1332958943, 1341873782);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_xor_wide_wide()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 368188976, 2012985502);
            uint4x4 b0 = uint4x4(1567399907, 1714683465, 1772252361, 689750501);
            uint4x4 r0 = uint4x4(1961815636, 1915932559, 2085647097, 1592228219);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint4x4 a1 = uint4x4(708058014, 1840375090, 567780508, 343810960);
            uint4x4 b1 = uint4x4(149537150, 568638146, 264594304, 1178687062);
            uint4x4 r1 = uint4x4(584964832, 1280663536, 772982556, 1379890630);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint4x4 a2 = uint4x4(471897086, 1232228569, 1069616196, 925113403);
            uint4x4 b2 = uint4x4(1742692741, 196742758, 2004070642, 1412112968);
            uint4x4 r2 = uint4x4(2080371323, 1120427711, 1219673270, 1661943411);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint4x4 a3 = uint4x4(1761523014, 1861969431, 465628282, 607008507);
            uint4x4 b3 = uint4x4(217001204, 139017218, 1837123205, 1252726374);
            uint4x4 r3 = uint4x4(1678875058, 1722964501, 1983949567, 1854218397);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_xor_wide_scalar()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint b0 = (1567399907);
            uint4x4 r0 = uint4x4(1961815636, 1231924773, 996106666, 1218347475);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint b1 = (2012985502);
            uint4x4 r1 = uint4x4(509203543, 1592228219, 1573888768, 2131917280);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint b2 = (568638146);
            uint4x4 r2 = uint4x4(1280663536, 3350110, 773970242, 899324242);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint b3 = (471897086);
            uint4x4 r3 = uint4x4(1516357032, 2080371323, 1431487271, 396008856);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (696414647);
            uint4x4 b0 = uint4x4(1567399907, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(1961815636, 1032011889, 1337036798, 1014001543);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (1772252361);
            uint4x4 b1 = uint4x4(2012985502, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(509203543, 1086237996, 1133934423, 1632349623);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (1840375090);
            uint4x4 b2 = uint4x4(568638146, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(1280663536, 1281769902, 1651803826, 2043659938);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (1178687062);
            uint4x4 b3 = uint4x4(471897086, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(1516357032, 564017107, 255002255, 1308317744);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint4x4_operator_left_shift()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            int b0 = (1567399907);
            uint4x4 r0 = uint4x4(1276349880, 2684980784, 832565832, 2945511808);
            TestUtils.AreEqual(a0 << b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            int b1 = (2012985502);
            uint4x4 r1 = uint4x4(1073741824, 1073741824, 2147483648, 2147483648);
            TestUtils.AreEqual(a1 << b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            int b2 = (568638146);
            uint4x4 r2 = uint4x4(3066533064, 2271122032, 1058377216, 1375243840);
            TestUtils.AreEqual(a2 << b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            int b3 = (471897086);
            uint4x4 r3 = uint4x4(2147483648, 1073741824, 1073741824, 2147483648);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void uint4x4_operator_right_shift()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            int b0 = (1567399907);
            uint4x4 r0 = uint4x4(87051830, 41952824, 214335433, 46023622);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            int b1 = (2012985502);
            uint4x4 r1 = uint4x4(1, 0, 0, 0);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            int b2 = (568638146);
            uint4x4 r2 = uint4x4(460093772, 141945127, 66148576, 85952740);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            int b3 = (471897086);
            uint4x4 r3 = uint4x4(1, 1, 1, 0);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void uint4x4_operator_bitwise_not()
        {
            uint4x4 a0 = uint4x4(696414647, 335622598, 1714683465, 368188976);
            uint4x4 r0 = uint4x4(3598552648, 3959344697, 2580283830, 3926778319);
            TestUtils.AreEqual(~a0, r0);

            uint4x4 a1 = uint4x4(1772252361, 689750501, 708058014, 149537150);
            uint4x4 r1 = uint4x4(2522714934, 3605216794, 3586909281, 4145430145);
            TestUtils.AreEqual(~a1, r1);

            uint4x4 a2 = uint4x4(1840375090, 567780508, 264594304, 343810960);
            uint4x4 r2 = uint4x4(2454592205, 3727186787, 4030372991, 3951156335);
            TestUtils.AreEqual(~a2, r2);

            uint4x4 a3 = uint4x4(1178687062, 1742692741, 1232228569, 196742758);
            uint4x4 r3 = uint4x4(3116280233, 2552274554, 3062738726, 4098224537);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
