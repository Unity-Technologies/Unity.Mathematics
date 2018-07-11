// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt3
    {
        [Test]
        public void int3_constructor()
        {
            int3 a = new int3(1, 2, 3);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
        }

        [Test]
        public void int3_scalar_constructor()
        {
            int3 a = new int3(17);
            Assert.AreEqual(a.x, 17);
            Assert.AreEqual(a.y, 17);
            Assert.AreEqual(a.z, 17);
        }

        [Test]
        public void int3_static_constructor()
        {
            int3 a = int3(1, 2, 3);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
            Assert.AreEqual(a.z, 3);
        }

        [Test]
        public void int3_static_scalar_constructor()
        {
            int3 a = int3(17);
            Assert.AreEqual(a.x, 17);
            Assert.AreEqual(a.y, 17);
            Assert.AreEqual(a.z, 17);
        }

        [Test]
        public void int3_operator_equal_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int3_operator_equal_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int3_operator_equal_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int3_operator_not_equal_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int3_operator_not_equal_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int3_operator_not_equal_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int3_operator_less_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            bool3 r1 = bool3(false, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            bool3 r2 = bool3(false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int3_operator_less_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            bool3 r3 = bool3(false, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int3_operator_less_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            bool3 r2 = bool3(true, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int3_operator_greater_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            bool3 r1 = bool3(true, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            bool3 r2 = bool3(true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int3_operator_greater_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int3_operator_greater_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            bool3 r2 = bool3(false, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int3_operator_less_equal_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            bool3 r0 = bool3(true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            bool3 r1 = bool3(false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            bool3 r2 = bool3(false, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            bool3 r3 = bool3(true, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int3_operator_less_equal_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            bool3 r0 = bool3(true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            bool3 r1 = bool3(false, false, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            bool3 r2 = bool3(true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            bool3 r3 = bool3(false, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int3_operator_less_equal_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            bool3 r0 = bool3(true, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            bool3 r1 = bool3(false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            bool3 r2 = bool3(true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            bool3 r3 = bool3(false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int3_operator_greater_equal_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            bool3 r0 = bool3(false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            bool3 r1 = bool3(true, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            bool3 r2 = bool3(true, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            bool3 r3 = bool3(false, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int3_operator_greater_equal_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            bool3 r0 = bool3(false, false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            bool3 r1 = bool3(true, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            bool3 r2 = bool3(false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            bool3 r3 = bool3(true, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int3_operator_greater_equal_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            bool3 r0 = bool3(false, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            bool3 r1 = bool3(true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            bool3 r2 = bool3(false, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            bool3 r3 = bool3(true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int3_operator_add_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            int3 r0 = int3(-623831103, -1996097060, -636312322);
            TestUtils.AreEqual(a0 + b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            int3 r1 = int3(-814480832, -1603392127, 1722003718);
            TestUtils.AreEqual(a1 + b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            int3 r2 = int3(-804431690, 983136427, -1858853089);
            TestUtils.AreEqual(a2 + b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            int3 r3 = int3(-1729843194, 1407797699, 1558781120);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int3_operator_add_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(-623831103, -1625530590, -631690038);
            TestUtils.AreEqual(a0 + b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(-636312322, -792900279, -1086421479);
            TestUtils.AreEqual(a1 + b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(-1603392127, 2080887371, -1482738849);
            TestUtils.AreEqual(a2 + b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(-804431690, 2002819344, 1863157839);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int3_operator_add_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            int3 r0 = int3(-623831103, -1988238125, -994397573);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            int3 r1 = int3(-636312322, -364371675, -657892875);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            int3 r2 = int3(-1603392127, 1601350440, -1962275780);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            int3 r3 = int3(-804431690, -1684453102, -1824114607);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int3_operator_sub_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            int3 r0 = int3(-362707535, -993840552, 428528604);
            TestUtils.AreEqual(a0 - b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            int3 r1 = int3(293521200, -479536931, -731341076);
            TestUtils.AreEqual(a1 - b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            int3 r2 = int3(607694850, 139661505, -448111697);
            TestUtils.AreEqual(a2 - b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            int3 r3 = int3(-1270221598, -320468495, 535247414);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int3_operator_sub_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(-362707535, -1364407022, -370566470);
            TestUtils.AreEqual(a0 - b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(428528604, 271940647, -21580553);
            TestUtils.AreEqual(a1 - b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(-479536931, -1090224729, -358883653);
            TestUtils.AreEqual(a2 - b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(607694850, -880021412, -1019682917);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int3_operator_sub_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            int3 r0 = int3(-362707535, 1001699487, 7858935);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            int3 r1 = int3(428528604, 156587957, 450109157);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            int3 r2 = int3(-479536931, 610687798, -120653278);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            int3 r3 = int3(607694850, 1487716262, 1627377767);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int3_operator_mul_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            int3 r0 = int3(358135496, 748670388, -1990032963);
            TestUtils.AreEqual(a0 * b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            int3 r1 = int3(519199168, -1987167474, -748074843);
            TestUtils.AreEqual(a1 * b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            int3 r2 = int3(-170543016, -1061026770, -1272699640);
            TestUtils.AreEqual(a2 * b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            int3 r3 = int3(1881483816, -441320086, 176325415);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int3_operator_mul_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(358135496, 546642640, -1492357104);
            TestUtils.AreEqual(a0 * b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(-1990032963, 338742328, 625900040);
            TestUtils.AreEqual(a1 * b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(-1987167474, 503130050, -570062806);
            TestUtils.AreEqual(a2 * b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(-170543016, -830742532, 979281954);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int3_operator_mul_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            int3 r0 = int3(358135496, 1786143946, -109563086);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            int3 r1 = int3(-1990032963, 230097496, -2016087320);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            int3 r2 = int3(-1987167474, 614580663, 780783715);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            int3 r3 = int3(-170543016, 7702888, 1911914508);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int3_operator_div_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            int3 r0 = int3(0, 0, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            int3 r1 = int3(1, 0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            int3 r2 = int3(1, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            int3 r3 = int3(0, 0, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int3_operator_div_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(1, 1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(0, 0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(1, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int3_operator_div_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            int3 r0 = int3(0, 2, 1);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            int3 r1 = int3(1, 1, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            int3 r2 = int3(0, 2, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            int3 r3 = int3(1, 3, 4);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int3_operator_mod_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            int3 r0 = int3(1654214329, 652514842, 428528604);
            TestUtils.AreEqual(a0 % b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            int3 r1 = int3(293521200, 1106019119, 495331321);
            TestUtils.AreEqual(a1 % b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            int3 r2 = int3(607694850, 139661505, 994001255);
            TestUtils.AreEqual(a2 % b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            int3 r3 = int3(647451252, 543664602, 23480561);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int3_operator_mod_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(1654214329, 652514842, 1646355394);
            TestUtils.AreEqual(a0 % b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(428528604, 271940647, 1593482632);
            TestUtils.AreEqual(a1 % b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(1106019119, 495331321, 1226672397);
            TestUtils.AreEqual(a2 % b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(607694850, 561398966, 421737461);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int3_operator_mod_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            int3 r0 = int3(1654214329, 349184645, 7858935);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            int3 r1 = int3(428528604, 156587957, 450109157);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            int3 r2 = int3(1106019119, 115356477, 1106019119);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            int3 r3 = int3(607694850, 364918330, 362165384);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int3_operator_plus()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int3 r0 = int3(1654214329, 652514842, 1646355394);
            TestUtils.AreEqual(+a0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int3 r1 = int3(2043591789, 1887003832, 1593482632);
            TestUtils.AreEqual(+a1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int3 r2 = int3(1106019119, 495331321, 1226672397);
            TestUtils.AreEqual(+a2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int3 r3 = int3(2049115228, 561398966, 421737461);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void int3_operator_neg()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int3 r0 = int3(-1654214329, -652514842, -1646355394);
            TestUtils.AreEqual(-a0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int3 r1 = int3(-2043591789, -1887003832, -1593482632);
            TestUtils.AreEqual(-a1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int3 r2 = int3(-1106019119, -495331321, -1226672397);
            TestUtils.AreEqual(-a2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int3 r3 = int3(-2049115228, -561398966, -421737461);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void int3_operator_prefix_inc()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int3 r0 = int3(1654214330, 652514843, 1646355395);
            TestUtils.AreEqual(++a0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int3 r1 = int3(2043591790, 1887003833, 1593482633);
            TestUtils.AreEqual(++a1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int3 r2 = int3(1106019120, 495331322, 1226672398);
            TestUtils.AreEqual(++a2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int3 r3 = int3(2049115229, 561398967, 421737462);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void int3_operator_postfix_inc()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int3 r0 = int3(1654214329, 652514842, 1646355394);
            TestUtils.AreEqual(a0++, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int3 r1 = int3(2043591789, 1887003832, 1593482632);
            TestUtils.AreEqual(a1++, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int3 r2 = int3(1106019119, 495331321, 1226672397);
            TestUtils.AreEqual(a2++, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int3 r3 = int3(2049115228, 561398966, 421737461);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void int3_operator_prefix_dec()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int3 r0 = int3(1654214328, 652514841, 1646355393);
            TestUtils.AreEqual(--a0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int3 r1 = int3(2043591788, 1887003831, 1593482631);
            TestUtils.AreEqual(--a1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int3 r2 = int3(1106019118, 495331320, 1226672396);
            TestUtils.AreEqual(--a2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int3 r3 = int3(2049115227, 561398965, 421737460);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void int3_operator_postfix_dec()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int3 r0 = int3(1654214329, 652514842, 1646355394);
            TestUtils.AreEqual(a0--, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int3 r1 = int3(2043591789, 1887003832, 1593482632);
            TestUtils.AreEqual(a1--, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int3 r2 = int3(1106019119, 495331321, 1226672397);
            TestUtils.AreEqual(a2--, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int3 r3 = int3(2049115228, 561398966, 421737461);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void int3_operator_bitwise_and_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            int3 r0 = int3(1611745288, 572523010, 1614981121);
            TestUtils.AreEqual(a0 & b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            int3 r1 = int3(1350042760, 1082163714, 151257353);
            TestUtils.AreEqual(a1 & b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            int3 r2 = int3(1344406616, 19005620, 288637216);
            TestUtils.AreEqual(a2 & b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            int3 r3 = int3(570773520, 536971720, 503324993);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int3_operator_bitwise_and_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(1611745288, 539262984, 1612792064);
            TestUtils.AreEqual(a0 & b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(1614981121, 1614897296, 1078102144);
            TestUtils.AreEqual(a1 & b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(1082163714, 478159440, 1208059904);
            TestUtils.AreEqual(a2 & b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(1344406616, 23217170, 287445072);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int3_operator_bitwise_and_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            int3 r0 = int3(1611745288, 578815512, 1644249728);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            int3 r1 = int3(1614981121, 1883776040, 1489673224);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            int3 r2 = int3(1082163714, 25428777, 1091338509);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            int3 r3 = int3(1344406616, 539100180, 404947028);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int3_operator_bitwise_or_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            int3 r0 = int3(2059390905, 1726347226, 2043673853);
            TestUtils.AreEqual(a0 | b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            int3 r1 = int3(2130443704, 1609411455, 1570746365);
            TestUtils.AreEqual(a1 | b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            int3 r2 = int3(2146128990, 964130807, 2147476991);
            TestUtils.AreEqual(a2 | b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            int3 r3 = int3(1994350582, 870825979, 1055456127);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int3_operator_bitwise_or_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(2059390905, 2130173722, 2050485194);
            TestUtils.AreEqual(a0 | b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(2043673853, 1887169721, 2130443673);
            TestUtils.AreEqual(a1 | b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(1609411455, 1602727931, 1604168543);
            TestUtils.AreEqual(a2 | b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(2146128990, 1979602174, 1575712767);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int3_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            int3 r0 = int3(2059390905, 1727913659, 1656319995);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            int3 r1 = int3(2043673853, 2046819581, 2147401197);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            int3 r2 = int3(1609411455, 1575921663, 1241353007);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            int3 r3 = int3(2146128990, 2071414014, 2065905661);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int3_operator_bitwise_xor_wide_wide()
        {
            int3 a0 = int3(1654214329, 652514842, 2043591789);
            int3 b0 = int3(2016921864, 1646355394, 1615063185);
            int3 r0 = int3(447645617, 1153824216, 428692732);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int3 a1 = int3(1887003832, 1106019119, 495331321);
            int3 b1 = int3(1593482632, 1585556050, 1226672397);
            int3 r1 = int3(780400944, 527247741, 1419489012);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int3 a2 = int3(2049115228, 561398966, 994001255);
            int3 b2 = int3(1441420378, 421737461, 1442112952);
            int3 r2 = int3(801722374, 945125187, 1858839775);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int3 a3 = int3(647451252, 543664602, 1047014267);
            int3 b3 = int3(1917672850, 864133097, 511766853);
            int3 r3 = int3(1423577062, 333854259, 552131134);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int3_operator_bitwise_xor_wide_scalar()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(447645617, 1590910738, 437693130);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(428692732, 272272425, 1052341529);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(527247741, 1124568491, 396108639);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(801722374, 1956385004, 1288267695);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int3_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1654214329);
            int3 b0 = int3(2016921864, 652514842, 1646355394);
            int3 r0 = int3(447645617, 1149098147, 12070267);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (2043591789);
            int3 b1 = int3(1615063185, 1887003832, 1593482632);
            int3 r1 = int3(428692732, 163043541, 657727973);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1106019119);
            int3 b2 = int3(1585556050, 495331321, 1226672397);
            int3 r2 = int3(527247741, 1550492886, 150014498);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (2049115228);
            int3 b3 = int3(1441420378, 561398966, 421737461);
            int3 r3 = int3(801722374, 1532313834, 1660958633);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int3_operator_left_shift()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(-1722894080, -459924992, 560185856);
            TestUtils.AreEqual(a0 << b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(2027552768, -915406848, 990904320);
            TestUtils.AreEqual(a1 << b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(213647360, -1612447744, 607387648);
            TestUtils.AreEqual(a2 << b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(1879048192, -671088640, -738197504);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void int3_operator_right_shift()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int b0 = (2016921864);
            int3 r0 = int3(6461774, 2548886, 6431075);
            TestUtils.AreEqual(a0 >> b0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int b1 = (1615063185);
            int3 r1 = int3(15591, 14396, 12157);
            TestUtils.AreEqual(a1 >> b1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int b2 = (1585556050);
            int3 r2 = int3(4219, 1889, 4679);
            TestUtils.AreEqual(a2 >> b2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int b3 = (1441420378);
            int3 r3 = int3(30, 8, 6);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void int3_operator_bitwise_not()
        {
            int3 a0 = int3(1654214329, 652514842, 1646355394);
            int3 r0 = int3(-1654214330, -652514843, -1646355395);
            TestUtils.AreEqual(~a0, r0);

            int3 a1 = int3(2043591789, 1887003832, 1593482632);
            int3 r1 = int3(-2043591790, -1887003833, -1593482633);
            TestUtils.AreEqual(~a1, r1);

            int3 a2 = int3(1106019119, 495331321, 1226672397);
            int3 r2 = int3(-1106019120, -495331322, -1226672398);
            TestUtils.AreEqual(~a2, r2);

            int3 a3 = int3(2049115228, 561398966, 421737461);
            int3 r3 = int3(-2049115229, -561398967, -421737462);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
