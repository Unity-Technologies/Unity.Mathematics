// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt4
    {
        [Test]
        public void int4_constructor()
        {
            int4 a = new int4(1, 2, 3, 4);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
            Assert.AreEqual(a.w, 4);
        }

        [Test]
        public void int4_scalar_constructor()
        {
            int4 a = new int4(17);
            Assert.AreEqual(a.x, 17);
            Assert.AreEqual(a.y, 17);
            Assert.AreEqual(a.z, 17);
            Assert.AreEqual(a.w, 17);
        }

        [Test]
        public void int4_static_constructor()
        {
            int4 a = int4(1, 2, 3, 4);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
            Assert.AreEqual(a.w, 4);
        }

        [Test]
        public void int4_static_scalar_constructor()
        {
            int4 a = int4(17);
            Assert.AreEqual(a.x, 17);
            Assert.AreEqual(a.y, 17);
            Assert.AreEqual(a.z, 17);
            Assert.AreEqual(a.w, 17);
        }

        [Test]
        public void int4_operator_equal_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int4_operator_equal_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int4_operator_equal_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            bool4 r3 = bool4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int4_operator_not_equal_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int4_operator_not_equal_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int4_operator_not_equal_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            bool4 r3 = bool4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int4_operator_less_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            bool4 r0 = bool4(true, false, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            bool4 r1 = bool4(true, true, true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            bool4 r2 = bool4(true, false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            bool4 r3 = bool4(false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int4_operator_less_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            bool4 r2 = bool4(true, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int4_operator_less_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            bool4 r3 = bool4(false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int4_operator_greater_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            bool4 r0 = bool4(false, true, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            bool4 r1 = bool4(false, false, false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            bool4 r2 = bool4(false, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            bool4 r3 = bool4(true, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int4_operator_greater_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            bool4 r2 = bool4(false, true, true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            bool4 r3 = bool4(true, true, true, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int4_operator_greater_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            bool4 r1 = bool4(true, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            bool4 r3 = bool4(true, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int4_operator_less_equal_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            bool4 r0 = bool4(true, false, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            bool4 r1 = bool4(true, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            bool4 r2 = bool4(true, false, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            bool4 r3 = bool4(false, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int4_operator_less_equal_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            bool4 r1 = bool4(false, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            bool4 r2 = bool4(true, false, false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            bool4 r3 = bool4(false, false, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int4_operator_less_equal_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            bool4 r0 = bool4(true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            bool4 r1 = bool4(false, true, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            bool4 r2 = bool4(true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            bool4 r3 = bool4(false, true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int4_operator_greater_equal_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            bool4 r0 = bool4(false, true, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            bool4 r1 = bool4(false, false, false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            bool4 r2 = bool4(false, true, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            bool4 r3 = bool4(true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int4_operator_greater_equal_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            bool4 r1 = bool4(true, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            bool4 r2 = bool4(false, true, true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            bool4 r3 = bool4(true, true, true, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int4_operator_greater_equal_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            bool4 r0 = bool4(false, false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            bool4 r1 = bool4(true, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            bool4 r2 = bool4(false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            bool4 r3 = bool4(true, false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int4_operator_add_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            int4 r0 = int4(1638549167, 1437503237, 1953846612, 1753603824);
            TestUtils.AreEqual(a0 + b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            int4 r1 = int4(-1862196613, 173924783, -110147541, 1395204592);
            TestUtils.AreEqual(a1 + b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            int4 r2 = int4(1675334536, 1767128423, 1517997481, -2105654402);
            TestUtils.AreEqual(a2 + b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            int4 r3 = int4(2028237515, -1994536876, -980214544, -1597974661);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int4_operator_add_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(1638549167, -1886437556, 1751554611, 1737945058);
            TestUtils.AreEqual(a0 + b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(1679437663, 1753603824, 1164170833, 1473090954);
            TestUtils.AreEqual(a1 + b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(173924783, -2113004621, -2023052116, 1124458059);
            TestUtils.AreEqual(a2 + b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(810318981, 1675334536, 1982626042, 594589177);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int4_operator_add_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            int4 r0 = int4(1638549167, 1324497793, 667522664, 653913111);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(1679437663, -1066416913, -1655849904, -1346929783);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(173924783, 2086829358, -2118185433, 1029324742);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(810318981, 1675566721, 1982858227, 594821362);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int4_operator_sub_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            int4 r0 = int4(-1084031947, 656975129, -1200537610, -1549112720);
            TestUtils.AreEqual(a0 - b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            int4 r1 = int4(-308920121, -95133317, -89952505, 584653426);
            TestUtils.AreEqual(a1 - b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            int4 r2 = int4(-865247740, 1388036865, 110190991, -1366250370);
            TestUtils.AreEqual(a2 - b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            int4 r3 = int4(1330839041, -1379876314, -504889846, 902835801);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int4_operator_sub_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(-1084031947, -314051374, -971026503, -984636056);
            TestUtils.AreEqual(a0 - b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(1474946559, 1549112720, 959679729, 1268599850);
            TestUtils.AreEqual(a1 - b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(-95133317, 1912904575, 2002857080, 855399959);
            TestUtils.AreEqual(a2 - b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(232185, 865247740, 1172539246, -215497619);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int4_operator_sub_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            int4 r0 = int4(-1084031947, -769980573, -113005444, -99395891);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(1474946559, -74166161, 515266830, 206346709);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(-95133317, -2008037892, -2097990397, -950533276);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(232185, -865015555, -1172307061, 215729804);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int4_operator_mul_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            int4 r0 = int4(-625413590, -1692772758, 84179147, 262212608);
            TestUtils.AreEqual(a0 * b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            int4 r1 = int4(-1946111206, 1150363938, 1143228738, 1490557327);
            TestUtils.AreEqual(a1 * b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            int4 r2 = int4(1467064844, -283873700, 1212685036, 737569024);
            TestUtils.AreEqual(a2 * b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            int4 r3 = int4(-1432757186, 1877176187, 1714446887, 1589046922);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int4_operator_mul_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(-625413590, 150757523, 108588190, 304357969);
            TestUtils.AreEqual(a0 * b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(89125968, 262212608, -1776500048, 1628192224);
            TestUtils.AreEqual(a1 * b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(1150363938, -1609953910, -1542486316, -712650502);
            TestUtils.AreEqual(a2 * b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(-544182854, 1467064844, 1637386296, -590135950);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int4_operator_mul_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            int4 r0 = int4(-625413590, 195561902, 279169932, -475594118);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(89125968, -2033659456, -1158629617, -551245562);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(1150363938, 1181878541, -1399618822, 1569973125);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(-544182854, 20790462, 672711372, -1433320947);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int4_operator_div_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            int4 r0 = int4(0, 2, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            int4 r1 = int4(0, 0, 0, 2);
            TestUtils.AreEqual(a1 / b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            int4 r2 = int4(0, 8, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            int4 r3 = int4(4, 0, 0, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int4_operator_div_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(0, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(15, 16, 10, 13);
            TestUtils.AreEqual(a1 / b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(0, 15, 15, 7);
            TestUtils.AreEqual(a2 / b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(1, 3, 3, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int4_operator_div_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            int4 r0 = int4(0, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(15, 0, 1, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(0, 0, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(1, 0, 0, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int4_operator_mod_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            int4 r0 = int4(277258610, 266711075, 376654501, 102245552);
            TestUtils.AreEqual(a0 % b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            int4 r1 = int4(1061925281, 39395733, 2047433625, 179377843);
            TestUtils.AreEqual(a1 % b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            int4 r2 = int4(405043398, 61216412, 110190991, 411531262);
            TestUtils.AreEqual(a2 % b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            int4 r3 = int4(284741330, 460277053, 1404931453, 5757384);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int4_operator_mod_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(277258610, 1047239183, 390264054, 376654501);
            TestUtils.AreEqual(a0 % b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(43508831, 15429440, 39469761, 41653226);
            TestUtils.AreEqual(a1 % b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(39395733, 29497875, 119450380, 48225659);
            TestUtils.AreEqual(a2 % b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(232185, 55160944, 362452450, 189545779);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int4_operator_mod_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            int4 r0 = int4(277258610, 277258610, 277258610, 277258610);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(43508831, 1577192111, 515266830, 206346709);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(39395733, 39395733, 39395733, 39395733);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(232185, 405275583, 405275583, 26184025);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int4_operator_plus()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int4 r0 = int4(277258610, 1047239183, 390264054, 376654501);
            TestUtils.AreEqual(+a0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            TestUtils.AreEqual(+a1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(39395733, 2047433625, 2137386130, 989929009);
            TestUtils.AreEqual(+a2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(405275583, 1270291138, 1577582644, 189545779);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void int4_operator_neg()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int4 r0 = int4(-277258610, -1047239183, -390264054, -376654501);
            TestUtils.AreEqual(-a0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(-1577192111, -1651358272, -1061925281, -1370845402);
            TestUtils.AreEqual(-a1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(-39395733, -2047433625, -2137386130, -989929009);
            TestUtils.AreEqual(-a2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(-405275583, -1270291138, -1577582644, -189545779);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void int4_operator_prefix_inc()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int4 r0 = int4(277258611, 1047239184, 390264055, 376654502);
            TestUtils.AreEqual(++a0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(1577192112, 1651358273, 1061925282, 1370845403);
            TestUtils.AreEqual(++a1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(39395734, 2047433626, 2137386131, 989929010);
            TestUtils.AreEqual(++a2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(405275584, 1270291139, 1577582645, 189545780);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void int4_operator_postfix_inc()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int4 r0 = int4(277258610, 1047239183, 390264054, 376654501);
            TestUtils.AreEqual(a0++, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            TestUtils.AreEqual(a1++, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(39395733, 2047433625, 2137386130, 989929009);
            TestUtils.AreEqual(a2++, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(405275583, 1270291138, 1577582644, 189545779);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void int4_operator_prefix_dec()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int4 r0 = int4(277258609, 1047239182, 390264053, 376654500);
            TestUtils.AreEqual(--a0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(1577192110, 1651358271, 1061925280, 1370845401);
            TestUtils.AreEqual(--a1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(39395732, 2047433624, 2137386129, 989929008);
            TestUtils.AreEqual(--a2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(405275582, 1270291137, 1577582643, 189545778);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void int4_operator_postfix_dec()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int4 r0 = int4(277258610, 1047239183, 390264054, 376654501);
            TestUtils.AreEqual(a0--, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            TestUtils.AreEqual(a1--, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(39395733, 2047433625, 2137386130, 989929009);
            TestUtils.AreEqual(a2--, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(405275583, 1270291138, 1577582644, 189545779);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void int4_operator_bitwise_and_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            int4 r0 = int4(268607792, 373460998, 369232549, 34086912);
            TestUtils.AreEqual(a0 & b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            int4 r1 = int4(285290624, 16, 2046904464, 402653745);
            TestUtils.AreEqual(a1 & b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            int4 r2 = int4(136583362, 168296496, 545527308, 143016832);
            TestUtils.AreEqual(a2 & b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            int4 r3 = int4(67680356, 154009877, 1368755569, 558366848);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int4_operator_bitwise_and_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(268607792, 270761997, 285385780, 270729253);
            TestUtils.AreEqual(a0 & b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(100663456, 34086912, 101195936, 1056912);
            TestUtils.AreEqual(a1 & b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(16, 134234136, 134529042, 134217744);
            TestUtils.AreEqual(a2 & b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(404750470, 136583362, 402653188, 134494210);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int4_operator_bitwise_and_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            int4 r0 = int4(268607792, 268599298, 268607602, 268566560);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(100663456, 1107298816, 503447713, 1342177418);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(16, 34144657, 37822608, 33619985);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(404750470, 136315522, 403177524, 134742323);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int4_operator_bitwise_or_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            int4 r0 = int4(1369941375, 1064042239, 1584614063, 1719516912);
            TestUtils.AreEqual(a0 | b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            int4 r1 = int4(2147480059, 173924767, 2137915291, 992550847);
            TestUtils.AreEqual(a1 | b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            int4 r2 = int4(1538751174, 1598831927, 972470173, 2046296062);
            TestUtils.AreEqual(a2 | b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            int4 r3 = int4(1960557159, 2146420543, 1945997183, 2138625787);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int4_operator_bitwise_or_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(1369941375, 2137767743, 1466168831, 1467215805);
            TestUtils.AreEqual(a0 | b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(1578774207, 1719516912, 1062974897, 1472034042);
            TestUtils.AreEqual(a1 | b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(173924767, 2047728539, 2137386138, 990240315);
            TestUtils.AreEqual(a2 | b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(405568511, 1538751174, 1579972854, 460094967);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int4_operator_bitwise_or_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            int4 r0 = int4(1369941375, 1055898495, 398915062, 385346551);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(1578774207, 2121251567, 2135669679, 1605860095);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(173924767, 2052684701, 2138959255, 995704757);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(405568511, 1539251199, 1579680703, 460079039);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int4_operator_bitwise_xor_wide_wide()
        {
            int4 a0 = int4(277258610, 1047239183, 376654501, 102245552);
            int4 b0 = int4(1361290557, 390264054, 1577192111, 1651358272);
            int4 r0 = int4(1101333583, 690581241, 1215381514, 1685430000);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4 a1 = int4(1061925281, 39395733, 2047433625, 989929009);
            int4 b1 = int4(1370845402, 134529050, 2137386130, 405275583);
            int4 r1 = int4(1862189435, 173924751, 91010827, 589897102);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4 a2 = int4(405043398, 1577582644, 814094236, 411531262);
            int4 b2 = int4(1270291138, 189545779, 703903245, 1777781632);
            int4 r2 = int4(1402167812, 1430535431, 426942865, 1903279230);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4 a3 = int4(1679538278, 460277053, 1404931453, 1799914218);
            int4 b3 = int4(348699237, 1840153367, 1909821299, 897078417);
            int4 r3 = int4(1892876803, 1992410666, 577241614, 1580258939);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int4_operator_bitwise_xor_wide_scalar()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(1101333583, 1867005746, 1180783051, 1196486552);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(1478110751, 1685430000, 961778961, 1470977130);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(173924751, 1913494403, 2002857096, 856022571);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(818041, 1402167812, 1177319666, 325600757);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int4_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (277258610);
            int4 b0 = int4(1361290557, 1047239183, 390264054, 376654501);
            int4 r0 = int4(1101333583, 787299197, 130307460, 116779991);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (1577192111);
            int4 b1 = int4(102245552, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(1478110751, 1013952751, 1632221966, 263682677);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (39395733);
            int4 b2 = int4(134529050, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(173924751, 2018540044, 2101136647, 962084772);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (405275583);
            int4 b3 = int4(405043398, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(818041, 1402935677, 1176503179, 325336716);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int4_operator_left_shift()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(1073741824, -536870912, -1073741824, -1610612736);
            TestUtils.AreEqual(a0 << b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(179240960, -1170210816, -1314848768, 1893335040);
            TestUtils.AreEqual(a1 << b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(1409286144, 1677721600, 1207959552, -1006632960);
            TestUtils.AreEqual(a2 << b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(167833536, -305745792, -2113925888, -753972032);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void int4_operator_right_shift()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int b0 = (1361290557);
            int4 r0 = int4(0, 1, 0, 0);
            TestUtils.AreEqual(a0 >> b0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int b1 = (102245552);
            int4 r1 = int4(24066, 25197, 16203, 20917);
            TestUtils.AreEqual(a1 >> b1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int b2 = (134529050);
            int4 r2 = int4(0, 30, 31, 14);
            TestUtils.AreEqual(a2 >> b2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int b3 = (405043398);
            int4 r3 = int4(6332430, 19848299, 24649728, 2961652);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void int4_operator_bitwise_not()
        {
            int4 a0 = int4(277258610, 1047239183, 390264054, 376654501);
            int4 r0 = int4(-277258611, -1047239184, -390264055, -376654502);
            TestUtils.AreEqual(~a0, r0);

            int4 a1 = int4(1577192111, 1651358272, 1061925281, 1370845402);
            int4 r1 = int4(-1577192112, -1651358273, -1061925282, -1370845403);
            TestUtils.AreEqual(~a1, r1);

            int4 a2 = int4(39395733, 2047433625, 2137386130, 989929009);
            int4 r2 = int4(-39395734, -2047433626, -2137386131, -989929010);
            TestUtils.AreEqual(~a2, r2);

            int4 a3 = int4(405275583, 1270291138, 1577582644, 189545779);
            int4 r3 = int4(-405275584, -1270291139, -1577582645, -189545780);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
