// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt3x3
    {
        [Test]
        public void int3x3_operator_equal_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int3x3_operator_equal_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int3x3_operator_equal_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int3x3_operator_not_equal_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int3x3_operator_not_equal_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int3x3_operator_not_equal_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int3x3_operator_less_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            bool3x3 r0 = bool3x3(true, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            bool3x3 r2 = bool3x3(true, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int3x3_operator_less_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            bool3x3 r1 = bool3x3(true, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int3x3_operator_less_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            bool3x3 r2 = bool3x3(true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            bool3x3 r3 = bool3x3(true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int3x3_operator_greater_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            bool3x3 r0 = bool3x3(false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            bool3x3 r2 = bool3x3(false, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            bool3x3 r3 = bool3x3(true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int3x3_operator_greater_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            bool3x3 r1 = bool3x3(false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int3x3_operator_greater_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            bool3x3 r2 = bool3x3(false, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            bool3x3 r3 = bool3x3(false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int3x3_operator_less_equal_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            bool3x3 r0 = bool3x3(true, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            bool3x3 r2 = bool3x3(true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            bool3x3 r3 = bool3x3(false, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int3x3_operator_less_equal_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            bool3x3 r1 = bool3x3(true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int3x3_operator_less_equal_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            bool3x3 r1 = bool3x3(true, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            bool3x3 r2 = bool3x3(true, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            bool3x3 r3 = bool3x3(true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int3x3_operator_greater_equal_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            bool3x3 r0 = bool3x3(false, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            bool3x3 r2 = bool3x3(false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            bool3x3 r3 = bool3x3(true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int3x3_operator_greater_equal_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            bool3x3 r1 = bool3x3(false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int3x3_operator_greater_equal_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            bool3x3 r1 = bool3x3(false, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            bool3x3 r2 = bool3x3(false, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            bool3x3 r3 = bool3x3(false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int3x3_operator_add_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            int3x3 r0 = int3x3(1638549167, 1437503237, 1953846612);
            TestUtils.AreEqual(a0 + b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            int3x3 r1 = int3x3(1753603824, -1862196613, 173924783);
            TestUtils.AreEqual(a1 + b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            int3x3 r2 = int3x3(-110147541, 1395204592, 1675334536);
            TestUtils.AreEqual(a2 + b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            int3x3 r3 = int3x3(1767128423, 1517997481, -2105654402);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int3x3_operator_add_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(1638549167, -1886437556, 1751554611);
            TestUtils.AreEqual(a0 + b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(1953846612, 1679437663, -1066416913);
            TestUtils.AreEqual(a1 + b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(-1862196613, 1410241135, 1505374452);
            TestUtils.AreEqual(a2 + b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(-110147541, -1167652157, -1752305583);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int3x3_operator_add_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            int3x3 r0 = int3x3(1638549167, 1324497793, 667522664);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            int3x3 r1 = int3x3(1953846612, 478900053, 2028012773);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            int3x3 r2 = int3x3(-1862196613, 1101321014, 1196454331);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            int3x3 r3 = int3x3(-110147541, -1257604662, -1842258088);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int3x3_operator_sub_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            int3x3 r0 = int3x3(-1084031947, 656975129, -1200537610);
            TestUtils.AreEqual(a0 - b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            int3x3 r1 = int3x3(-1549112720, -308920121, -95133317);
            TestUtils.AreEqual(a1 - b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            int3x3 r2 = int3x3(-89952505, 584653426, -865247740);
            TestUtils.AreEqual(a2 - b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            int3x3 r3 = int3x3(1388036865, 110190991, -1366250370);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int3x3_operator_sub_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(-1084031947, -314051374, -971026503);
            TestUtils.AreEqual(a0 - b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(-1200537610, -1474946559, 74166161);
            TestUtils.AreEqual(a1 - b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(-308920121, -1331449669, -1236316352);
            TestUtils.AreEqual(a2 - b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(-89952505, -1147457121, -1732110547);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int3x3_operator_sub_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            int3x3 r0 = int3x3(-1084031947, -769980573, -113005444);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            int3x3 r1 = int3x3(-1200537610, 274408949, -1274703771);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            int3x3 r2 = int3x3(-308920121, 1022529548, 927396231);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            int3x3 r3 = int3x3(-89952505, 1057504616, 1642158042);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int3x3_operator_mul_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            int3x3 r0 = int3x3(-625413590, -1692772758, 84179147);
            TestUtils.AreEqual(a0 * b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            int3x3 r1 = int3x3(262212608, -1946111206, 1150363938);
            TestUtils.AreEqual(a1 * b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            int3x3 r2 = int3x3(1143228738, 1490557327, 1467064844);
            TestUtils.AreEqual(a2 * b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            int3x3 r3 = int3x3(-283873700, 1212685036, 737569024);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int3x3_operator_mul_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(-625413590, 150757523, 108588190);
            TestUtils.AreEqual(a0 * b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(84179147, 89125968, -2033659456);
            TestUtils.AreEqual(a1 * b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(-1946111206, -504313630, -193399260);
            TestUtils.AreEqual(a2 * b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(1143228738, -422747150, -442419474);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int3x3_operator_mul_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            int3x3 r0 = int3x3(-625413590, 195561902, 279169932);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            int3x3 r1 = int3x3(84179147, -2093316752, 1397721920);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            int3x3 r2 = int3x3(-1946111206, -1678957643, 23906906);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            int3x3 r3 = int3x3(1143228738, 320829001, -789175769);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int3x3_operator_div_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            int3x3 r0 = int3x3(0, 2, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            int3x3 r1 = int3x3(0, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            int3x3 r2 = int3x3(0, 2, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            int3x3 r3 = int3x3(8, 1, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int3x3_operator_div_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(0, 0, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(0, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int3x3_operator_div_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            int3x3 r0 = int3x3(0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            int3x3 r1 = int3x3(0, 3, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            int3x3 r2 = int3x3(0, 26, 7);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            int3x3 r3 = int3x3(0, 2, 5);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int3x3_operator_mod_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            int3x3 r0 = int3x3(277258610, 266711075, 376654501);
            TestUtils.AreEqual(a0 % b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            int3x3 r1 = int3x3(102245552, 1061925281, 39395733);
            TestUtils.AreEqual(a1 % b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            int3x3 r2 = int3x3(2047433625, 179377843, 405043398);
            TestUtils.AreEqual(a2 % b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            int3x3 r3 = int3x3(61216412, 110190991, 411531262);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int3x3_operator_mod_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(277258610, 1047239183, 390264054);
            TestUtils.AreEqual(a0 % b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(376654501, 102245552, 74166161);
            TestUtils.AreEqual(a1 % b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(1061925281, 39395733, 134529050);
            TestUtils.AreEqual(a2 % b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(2047433625, 989929009, 405275583);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int3x3_operator_mod_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            int3x3 r0 = int3x3(277258610, 277258610, 277258610);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            int3x3 r1 = int3x3(376654501, 69917845, 376654501);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            int3x3 r2 = int3x3(1061925281, 37636223, 120221931);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            int3x3 r3 = int3x3(2047433625, 67575607, 21055710);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int3x3_operator_plus()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int3x3 r0 = int3x3(277258610, 1047239183, 390264054);
            TestUtils.AreEqual(+a0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int3x3 r1 = int3x3(376654501, 102245552, 1651358272);
            TestUtils.AreEqual(+a1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int3x3 r2 = int3x3(1061925281, 39395733, 134529050);
            TestUtils.AreEqual(+a2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int3x3 r3 = int3x3(2047433625, 989929009, 405275583);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void int3x3_operator_neg()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int3x3 r0 = int3x3(-277258610, -1047239183, -390264054);
            TestUtils.AreEqual(-a0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int3x3 r1 = int3x3(-376654501, -102245552, -1651358272);
            TestUtils.AreEqual(-a1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int3x3 r2 = int3x3(-1061925281, -39395733, -134529050);
            TestUtils.AreEqual(-a2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int3x3 r3 = int3x3(-2047433625, -989929009, -405275583);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void int3x3_operator_prefix_inc()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int3x3 r0 = int3x3(277258611, 1047239184, 390264055);
            TestUtils.AreEqual(++a0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int3x3 r1 = int3x3(376654502, 102245553, 1651358273);
            TestUtils.AreEqual(++a1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int3x3 r2 = int3x3(1061925282, 39395734, 134529051);
            TestUtils.AreEqual(++a2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int3x3 r3 = int3x3(2047433626, 989929010, 405275584);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void int3x3_operator_postfix_inc()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int3x3 r0 = int3x3(277258610, 1047239183, 390264054);
            TestUtils.AreEqual(a0++, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int3x3 r1 = int3x3(376654501, 102245552, 1651358272);
            TestUtils.AreEqual(a1++, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int3x3 r2 = int3x3(1061925281, 39395733, 134529050);
            TestUtils.AreEqual(a2++, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int3x3 r3 = int3x3(2047433625, 989929009, 405275583);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void int3x3_operator_prefix_dec()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int3x3 r0 = int3x3(277258609, 1047239182, 390264053);
            TestUtils.AreEqual(--a0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int3x3 r1 = int3x3(376654500, 102245551, 1651358271);
            TestUtils.AreEqual(--a1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int3x3 r2 = int3x3(1061925280, 39395732, 134529049);
            TestUtils.AreEqual(--a2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int3x3 r3 = int3x3(2047433624, 989929008, 405275582);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void int3x3_operator_postfix_dec()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int3x3 r0 = int3x3(277258610, 1047239183, 390264054);
            TestUtils.AreEqual(a0--, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int3x3 r1 = int3x3(376654501, 102245552, 1651358272);
            TestUtils.AreEqual(a1--, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int3x3 r2 = int3x3(1061925281, 39395733, 134529050);
            TestUtils.AreEqual(a2--, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int3x3 r3 = int3x3(2047433625, 989929009, 405275583);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_and_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            int3x3 r0 = int3x3(268607792, 373460998, 369232549);
            TestUtils.AreEqual(a0 & b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            int3x3 r1 = int3x3(34086912, 285290624, 16);
            TestUtils.AreEqual(a1 & b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            int3x3 r2 = int3x3(2046904464, 402653745, 136583362);
            TestUtils.AreEqual(a2 & b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            int3x3 r3 = int3x3(168296496, 545527308, 143016832);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_and_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(268607792, 270761997, 285385780);
            TestUtils.AreEqual(a0 & b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(369232549, 100663456, 1107298816);
            TestUtils.AreEqual(a1 & b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(285290624, 1122448, 278554);
            TestUtils.AreEqual(a2 & b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(2046904464, 989924368, 404750482);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_and_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            int3x3 r0 = int3x3(268607792, 268599298, 268607602);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            int3x3 r1 = int3x3(369232549, 101712032, 39913984);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            int3x3 r2 = int3x3(285290624, 38347137, 134250496);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            int3x3 r3 = int3x3(2046904464, 973150737, 403178393);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_or_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            int3x3 r0 = int3x3(1369941375, 1064042239, 1584614063);
            TestUtils.AreEqual(a0 | b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            int3x3 r1 = int3x3(1719516912, 2147480059, 173924767);
            TestUtils.AreEqual(a1 | b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            int3x3 r2 = int3x3(2137915291, 992550847, 1538751174);
            TestUtils.AreEqual(a2 | b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            int3x3 r3 = int3x3(1598831927, 972470173, 2046296062);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_or_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(1369941375, 2137767743, 1466168831);
            TestUtils.AreEqual(a0 | b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(1584614063, 1578774207, 2121251567);
            TestUtils.AreEqual(a1 | b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(2147480059, 1409118687, 1505095898);
            TestUtils.AreEqual(a2 | b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(2137915291, 2137390771, 2137911231);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_or_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            int3x3 r0 = int3x3(1369941375, 1055898495, 398915062);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            int3x3 r1 = int3x3(1584614063, 377188021, 1988098789);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            int3x3 r2 = int3x3(2147480059, 1062973877, 1062203835);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            int3x3 r3 = int3x3(2137915291, 2064211897, 2049530815);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_xor_wide_wide()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 376654501);
            int3x3 b0 = int3x3(1361290557, 390264054, 1577192111);
            int3x3 r0 = int3x3(1101333583, 690581241, 1215381514);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int3x3 a1 = int3x3(102245552, 1061925281, 39395733);
            int3x3 b1 = int3x3(1651358272, 1370845402, 134529050);
            int3x3 r1 = int3x3(1685430000, 1862189435, 173924751);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int3x3 a2 = int3x3(2047433625, 989929009, 405043398);
            int3x3 b2 = int3x3(2137386130, 405275583, 1270291138);
            int3x3 r2 = int3x3(91010827, 589897102, 1402167812);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int3x3 a3 = int3x3(1577582644, 814094236, 411531262);
            int3x3 b3 = int3x3(189545779, 703903245, 1777781632);
            int3x3 r3 = int3x3(1430535431, 426942865, 1903279230);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_xor_wide_scalar()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(1101333583, 1867005746, 1180783051);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(1215381514, 1478110751, 1013952751);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(1862189435, 1407996239, 1504817344);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(91010827, 1147466403, 1733160749);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (277258610);
            int3x3 b0 = int3x3(1361290557, 1047239183, 390264054);
            int3x3 r0 = int3x3(1101333583, 787299197, 130307460);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (376654501);
            int3x3 b1 = int3x3(1577192111, 102245552, 1651358272);
            int3x3 r1 = int3x3(1215381514, 275475989, 1948184805);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1061925281);
            int3x3 b2 = int3x3(1370845402, 39395733, 134529050);
            int3x3 r2 = int3x3(1862189435, 1024626740, 927953339);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (2047433625);
            int3x3 b3 = int3x3(2137386130, 989929009, 405275583);
            int3x3 r3 = int3x3(91010827, 1091061160, 1646352422);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int3x3_operator_left_shift()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(1073741824, -536870912, -1073741824);
            TestUtils.AreEqual(a0 << b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(-1521319936, 307757056, -585105408);
            TestUtils.AreEqual(a1 << b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(-2080374784, 1409286144, 1744830464);
            TestUtils.AreEqual(a2 << b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(1852047360, 2026110976, 251396096);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void int3x3_operator_right_shift()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int b0 = (1361290557);
            int3x3 r0 = int3x3(0, 1, 0);
            TestUtils.AreEqual(a0 >> b0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int b1 = (1577192111);
            int3x3 r1 = int3x3(11494, 3120, 50395);
            TestUtils.AreEqual(a1 >> b1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int b2 = (1370845402);
            int3x3 r2 = int3x3(15, 0, 2);
            TestUtils.AreEqual(a2 >> b2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int b3 = (2137386130);
            int3x3 r3 = int3x3(7810, 3776, 1546);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void int3x3_operator_bitwise_not()
        {
            int3x3 a0 = int3x3(277258610, 1047239183, 390264054);
            int3x3 r0 = int3x3(-277258611, -1047239184, -390264055);
            TestUtils.AreEqual(~a0, r0);

            int3x3 a1 = int3x3(376654501, 102245552, 1651358272);
            int3x3 r1 = int3x3(-376654502, -102245553, -1651358273);
            TestUtils.AreEqual(~a1, r1);

            int3x3 a2 = int3x3(1061925281, 39395733, 134529050);
            int3x3 r2 = int3x3(-1061925282, -39395734, -134529051);
            TestUtils.AreEqual(~a2, r2);

            int3x3 a3 = int3x3(2047433625, 989929009, 405275583);
            int3x3 r3 = int3x3(-2047433626, -989929010, -405275584);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
