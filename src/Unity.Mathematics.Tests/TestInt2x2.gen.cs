// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt2x2
    {
        [Test]
        public void int2x2_operator_equal_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int2x2_operator_equal_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int2x2_operator_equal_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int2x2_operator_not_equal_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int2x2_operator_not_equal_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int2x2_operator_not_equal_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int2x2_operator_less_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            bool2x2 r0 = bool2x2(true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            bool2x2 r3 = bool2x2(true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int2x2_operator_less_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int2x2_operator_less_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int2x2_operator_greater_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            bool2x2 r0 = bool2x2(false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            bool2x2 r3 = bool2x2(false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int2x2_operator_greater_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int2x2_operator_greater_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int2x2_operator_less_equal_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            bool2x2 r0 = bool2x2(true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            bool2x2 r3 = bool2x2(true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int2x2_operator_less_equal_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int2x2_operator_less_equal_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int2x2_operator_greater_equal_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            bool2x2 r0 = bool2x2(false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            bool2x2 r3 = bool2x2(false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int2x2_operator_greater_equal_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int2x2_operator_greater_equal_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int2x2_operator_add_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            int2x2 r0 = int2x2(1638549167, 1437503237);
            TestUtils.AreEqual(a0 + b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            int2x2 r1 = int2x2(1953846612, 1753603824);
            TestUtils.AreEqual(a1 + b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            int2x2 r2 = int2x2(-1862196613, 173924783);
            TestUtils.AreEqual(a2 + b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            int2x2 r3 = int2x2(-110147541, 1395204592);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int2x2_operator_add_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(1638549167, -1886437556);
            TestUtils.AreEqual(a0 + b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(766918555, 1953846612);
            TestUtils.AreEqual(a1 + b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(1753603824, -1581683743);
            TestUtils.AreEqual(a2 + b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(1410241135, 173924783);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int2x2_operator_add_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            int2x2 r0 = int2x2(1638549167, 1324497793);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            int2x2 r1 = int2x2(766918555, 1967456165);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            int2x2 r2 = int2x2(1753603824, 1164170833);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            int2x2 r3 = int2x2(1410241135, 1505374452);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int2x2_operator_sub_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            int2x2 r0 = int2x2(-1084031947, 656975129);
            TestUtils.AreEqual(a0 - b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            int2x2 r1 = int2x2(-1200537610, -1549112720);
            TestUtils.AreEqual(a1 - b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            int2x2 r2 = int2x2(-308920121, -95133317);
            TestUtils.AreEqual(a2 - b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            int2x2 r3 = int2x2(-89952505, 584653426);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int2x2_operator_sub_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(-1084031947, -314051374);
            TestUtils.AreEqual(a0 - b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(13609553, 1200537610);
            TestUtils.AreEqual(a1 - b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(-1549112720, -589432991);
            TestUtils.AreEqual(a2 - b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(1331449669, 95133317);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int2x2_operator_sub_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            int2x2 r0 = int2x2(-1084031947, -769980573);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            int2x2 r1 = int2x2(13609553, -1186928057);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            int2x2 r2 = int2x2(-1549112720, -959679729);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            int2x2 r3 = int2x2(1331449669, 1236316352);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int2x2_operator_mul_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            int2x2 r0 = int2x2(-625413590, -1692772758);
            TestUtils.AreEqual(a0 * b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            int2x2 r1 = int2x2(84179147, 262212608);
            TestUtils.AreEqual(a1 * b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            int2x2 r2 = int2x2(-1946111206, 1150363938);
            TestUtils.AreEqual(a2 * b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            int2x2 r3 = int2x2(1143228738, 1490557327);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int2x2_operator_mul_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(-625413590, 150757523);
            TestUtils.AreEqual(a0 * b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(-2022113650, 84179147);
            TestUtils.AreEqual(a1 * b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(262212608, 361259584);
            TestUtils.AreEqual(a2 * b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(-504313630, 1150363938);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int2x2_operator_mul_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            int2x2 r0 = int2x2(-625413590, 195561902);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            int2x2 r1 = int2x2(-2022113650, -1035792342);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            int2x2 r2 = int2x2(262212608, -1776500048);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            int2x2 r3 = int2x2(-504313630, -193399260);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int2x2_operator_div_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            int2x2 r0 = int2x2(0, 2);
            TestUtils.AreEqual(a0 / b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            int2x2 r1 = int2x2(0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            int2x2 r2 = int2x2(0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            int2x2 r3 = int2x2(0, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int2x2_operator_div_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(1, 4);
            TestUtils.AreEqual(a1 / b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(34, 3);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int2x2_operator_div_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            int2x2 r0 = int2x2(0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            int2x2 r1 = int2x2(1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            int2x2 r2 = int2x2(0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            int2x2 r3 = int2x2(34, 10);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int2x2_operator_mod_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            int2x2 r0 = int2x2(277258610, 266711075);
            TestUtils.AreEqual(a0 % b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            int2x2 r1 = int2x2(376654501, 102245552);
            TestUtils.AreEqual(a1 % b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            int2x2 r2 = int2x2(1061925281, 39395733);
            TestUtils.AreEqual(a2 % b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            int2x2 r3 = int2x2(2047433625, 179377843);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int2x2_operator_mod_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(277258610, 1047239183);
            TestUtils.AreEqual(a0 % b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(13609553, 70574107);
            TestUtils.AreEqual(a1 % b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(102245552, 1061925281);
            TestUtils.AreEqual(a2 % b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(31390480, 16341851);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int2x2_operator_mod_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            int2x2 r0 = int2x2(277258610, 277258610);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            int2x2 r1 = int2x2(13609553, 390264054);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            int2x2 r2 = int2x2(102245552, 102245552);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            int2x2 r3 = int2x2(31390480, 25554902);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int2x2_operator_plus()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 r0 = int2x2(277258610, 1047239183);
            TestUtils.AreEqual(+a0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int2x2 r1 = int2x2(390264054, 1577192111);
            TestUtils.AreEqual(+a1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int2x2 r2 = int2x2(102245552, 1061925281);
            TestUtils.AreEqual(+a2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int2x2 r3 = int2x2(1370845402, 134529050);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void int2x2_operator_neg()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 r0 = int2x2(-277258610, -1047239183);
            TestUtils.AreEqual(-a0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int2x2 r1 = int2x2(-390264054, -1577192111);
            TestUtils.AreEqual(-a1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int2x2 r2 = int2x2(-102245552, -1061925281);
            TestUtils.AreEqual(-a2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int2x2 r3 = int2x2(-1370845402, -134529050);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void int2x2_operator_prefix_inc()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 r0 = int2x2(277258611, 1047239184);
            TestUtils.AreEqual(++a0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int2x2 r1 = int2x2(390264055, 1577192112);
            TestUtils.AreEqual(++a1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int2x2 r2 = int2x2(102245553, 1061925282);
            TestUtils.AreEqual(++a2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int2x2 r3 = int2x2(1370845403, 134529051);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void int2x2_operator_postfix_inc()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 r0 = int2x2(277258610, 1047239183);
            TestUtils.AreEqual(a0++, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int2x2 r1 = int2x2(390264054, 1577192111);
            TestUtils.AreEqual(a1++, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int2x2 r2 = int2x2(102245552, 1061925281);
            TestUtils.AreEqual(a2++, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int2x2 r3 = int2x2(1370845402, 134529050);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void int2x2_operator_prefix_dec()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 r0 = int2x2(277258609, 1047239182);
            TestUtils.AreEqual(--a0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int2x2 r1 = int2x2(390264053, 1577192110);
            TestUtils.AreEqual(--a1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int2x2 r2 = int2x2(102245551, 1061925280);
            TestUtils.AreEqual(--a2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int2x2 r3 = int2x2(1370845401, 134529049);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void int2x2_operator_postfix_dec()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 r0 = int2x2(277258610, 1047239183);
            TestUtils.AreEqual(a0--, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int2x2 r1 = int2x2(390264054, 1577192111);
            TestUtils.AreEqual(a1--, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int2x2 r2 = int2x2(102245552, 1061925281);
            TestUtils.AreEqual(a2--, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int2x2 r3 = int2x2(1370845402, 134529050);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_and_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            int2x2 r0 = int2x2(268607792, 373460998);
            TestUtils.AreEqual(a0 & b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            int2x2 r1 = int2x2(369232549, 34086912);
            TestUtils.AreEqual(a1 & b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            int2x2 r2 = int2x2(285290624, 16);
            TestUtils.AreEqual(a2 & b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            int2x2 r3 = int2x2(2046904464, 402653745);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_and_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(268607792, 270761997);
            TestUtils.AreEqual(a0 & b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(373440676, 369232549);
            TestUtils.AreEqual(a1 & b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(34086912, 575254528);
            TestUtils.AreEqual(a2 & b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(1122448, 16);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_and_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            int2x2 r0 = int2x2(268607792, 268599298);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            int2x2 r1 = int2x2(373440676, 369229990);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            int2x2 r2 = int2x2(34086912, 101195936);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            int2x2 r3 = int2x2(1122448, 278554);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_or_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            int2x2 r0 = int2x2(1369941375, 1064042239);
            TestUtils.AreEqual(a0 | b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            int2x2 r1 = int2x2(1584614063, 1719516912);
            TestUtils.AreEqual(a1 | b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            int2x2 r2 = int2x2(2147480059, 173924767);
            TestUtils.AreEqual(a2 | b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            int2x2 r3 = int2x2(2137915291, 992550847);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_or_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(1369941375, 2137767743);
            TestUtils.AreEqual(a0 | b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(393477879, 1584614063);
            TestUtils.AreEqual(a1 | b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(1719516912, 2138029025);
            TestUtils.AreEqual(a2 | b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(1409118687, 173924767);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_or_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            int2x2 r0 = int2x2(1369941375, 1055898495);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            int2x2 r1 = int2x2(393477879, 1598226175);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            int2x2 r2 = int2x2(1719516912, 1062974897);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            int2x2 r3 = int2x2(1409118687, 1505095898);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_xor_wide_wide()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 b0 = int2x2(1361290557, 390264054);
            int2x2 r0 = int2x2(1101333583, 690581241);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2x2 a1 = int2x2(376654501, 102245552);
            int2x2 b1 = int2x2(1577192111, 1651358272);
            int2x2 r1 = int2x2(1215381514, 1685430000);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2x2 a2 = int2x2(1061925281, 39395733);
            int2x2 b2 = int2x2(1370845402, 134529050);
            int2x2 r2 = int2x2(1862189435, 173924751);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2x2 a3 = int2x2(2047433625, 989929009);
            int2x2 b3 = int2x2(2137386130, 405275583);
            int2x2 r3 = int2x2(91010827, 589897102);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_xor_wide_scalar()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(1101333583, 1867005746);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(20037203, 1215381514);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(1685430000, 1562774497);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(1407996239, 173924751);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (277258610);
            int2x2 b0 = int2x2(1361290557, 1047239183);
            int2x2 r0 = int2x2(1101333583, 787299197);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (390264054);
            int2x2 b1 = int2x2(376654501, 1577192111);
            int2x2 r1 = int2x2(20037203, 1228996185);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (102245552);
            int2x2 b2 = int2x2(1651358272, 1061925281);
            int2x2 r2 = int2x2(1685430000, 961778961);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (1370845402);
            int2x2 b3 = int2x2(39395733, 134529050);
            int2x2 r3 = int2x2(1407996239, 1504817344);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int2x2_operator_left_shift()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(1073741824, -536870912);
            TestUtils.AreEqual(a0 << b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(-396452160, -1069460000);
            TestUtils.AreEqual(a1 << b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(102245552, 1061925281);
            TestUtils.AreEqual(a2 << b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(457179136, 54525952);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void int2x2_operator_right_shift()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int b0 = (1361290557);
            int2x2 r0 = int2x2(0, 1);
            TestUtils.AreEqual(a0 >> b0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int b1 = (376654501);
            int2x2 r1 = int2x2(12195751, 49287253);
            TestUtils.AreEqual(a1 >> b1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int b2 = (1651358272);
            int2x2 r2 = int2x2(102245552, 1061925281);
            TestUtils.AreEqual(a2 >> b2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int b3 = (39395733);
            int2x2 r3 = int2x2(653, 64);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void int2x2_operator_bitwise_not()
        {
            int2x2 a0 = int2x2(277258610, 1047239183);
            int2x2 r0 = int2x2(-277258611, -1047239184);
            TestUtils.AreEqual(~a0, r0);

            int2x2 a1 = int2x2(390264054, 1577192111);
            int2x2 r1 = int2x2(-390264055, -1577192112);
            TestUtils.AreEqual(~a1, r1);

            int2x2 a2 = int2x2(102245552, 1061925281);
            int2x2 r2 = int2x2(-102245553, -1061925282);
            TestUtils.AreEqual(~a2, r2);

            int2x2 a3 = int2x2(1370845402, 134529050);
            int2x2 r3 = int2x2(-1370845403, -134529051);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
