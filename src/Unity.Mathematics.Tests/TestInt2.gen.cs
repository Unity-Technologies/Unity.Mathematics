// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestInt2
    {
        [Test]
        public void int2_constructor()
        {
            int2 a = new int2(1, 2);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
        }

        [Test]
        public void int2_scalar_constructor()
        {
            int2 a = new int2(17);
            Assert.AreEqual(a.x, 17);
            Assert.AreEqual(a.y, 17);
        }

        [Test]
        public void int2_static_constructor()
        {
            int2 a = int2(1, 2);
            Assert.AreEqual(a.x, 1);
            Assert.AreEqual(a.y, 2);
        }

        [Test]
        public void int2_static_scalar_constructor()
        {
            int2 a = int2(17);
            Assert.AreEqual(a.x, 17);
            Assert.AreEqual(a.y, 17);
        }

        [Test]
        public void int2_operator_equal_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int2_operator_equal_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int2_operator_equal_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void int2_operator_not_equal_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int2_operator_not_equal_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int2_operator_not_equal_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void int2_operator_less_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int2_operator_less_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int2_operator_less_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 < b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void int2_operator_greater_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int2_operator_greater_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int2_operator_greater_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 > b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 > b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void int2_operator_less_equal_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int2_operator_less_equal_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int2_operator_less_equal_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void int2_operator_greater_equal_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int2_operator_greater_equal_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            bool2 r2 = bool2(true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int2_operator_greater_equal_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void int2_operator_add_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            int2 r0 = int2(-623831103, -1996097060);
            TestUtils.AreEqual(a0 + b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            int2 r1 = int2(-636312322, -814480832);
            TestUtils.AreEqual(a1 + b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            int2 r2 = int2(-1603392127, 1722003718);
            TestUtils.AreEqual(a2 + b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            int2 r3 = int2(-804431690, 983136427);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int2_operator_add_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(-623831103, -1625530590);
            TestUtils.AreEqual(a0 + b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(-605020113, -636312322);
            TestUtils.AreEqual(a1 + b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(-814480832, -1595465545);
            TestUtils.AreEqual(a2 + b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(2080887371, 1722003718);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int2_operator_add_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            int2 r0 = int2(-623831103, -1988238125);
            TestUtils.AreEqual(a0 + b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            int2 r1 = int2(-605020113, -1033548717);
            TestUtils.AreEqual(a1 + b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            int2 r2 = int2(-814480832, -1301944345);
            TestUtils.AreEqual(a2 + b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            int2 r3 = int2(2080887371, -1482738849);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void int2_operator_sub_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            int2 r0 = int2(-362707535, -993840552);
            TestUtils.AreEqual(a0 - b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            int2 r1 = int2(428528604, 293521200);
            TestUtils.AreEqual(a1 - b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            int2 r2 = int2(-479536931, -731341076);
            TestUtils.AreEqual(a2 - b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            int2 r3 = int2(607694850, 139661505);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int2_operator_sub_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(-362707535, -1364407022);
            TestUtils.AreEqual(a0 - b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(-397236395, -428528604);
            TestUtils.AreEqual(a1 - b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(293521200, -487463513);
            TestUtils.AreEqual(a2 - b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(1090224729, 731341076);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int2_operator_sub_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            int2 r0 = int2(-362707535, 1001699487);
            TestUtils.AreEqual(a0 - b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            int2 r1 = int2(-397236395, 31292209);
            TestUtils.AreEqual(a1 - b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            int2 r2 = int2(293521200, 780984713);
            TestUtils.AreEqual(a2 - b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            int2 r3 = int2(1090224729, 358883653);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void int2_operator_mul_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            int2 r0 = int2(358135496, 748670388);
            TestUtils.AreEqual(a0 * b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            int2 r1 = int2(-1990032963, 519199168);
            TestUtils.AreEqual(a1 * b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            int2 r2 = int2(-1987167474, -748074843);
            TestUtils.AreEqual(a2 * b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            int2 r3 = int2(-170543016, -1061026770);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int2_operator_mul_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(358135496, 546642640);
            TestUtils.AreEqual(a0 * b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(1167454618, -1990032963);
            TestUtils.AreEqual(a1 * b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(519199168, 1879016440);
            TestUtils.AreEqual(a2 * b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(503130050, -748074843);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int2_operator_mul_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            int2 r0 = int2(358135496, 1786143946);
            TestUtils.AreEqual(a0 * b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            int2 r1 = int2(1167454618, -1290317598);
            TestUtils.AreEqual(a1 * b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            int2 r2 = int2(519199168, 1450419656);
            TestUtils.AreEqual(a2 * b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            int2 r3 = int2(503130050, -570062806);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void int2_operator_div_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            int2 r0 = int2(0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            int2 r1 = int2(1, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            int2 r2 = int2(0, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            int2 r3 = int2(1, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int2_operator_div_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(0, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(3, 2);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int2_operator_div_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            int2 r0 = int2(0, 2);
            TestUtils.AreEqual(a0 / b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            int2 r1 = int2(0, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            int2 r2 = int2(1, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            int2 r3 = int2(3, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void int2_operator_mod_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            int2 r0 = int2(1654214329, 652514842);
            TestUtils.AreEqual(a0 % b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            int2 r1 = int2(428528604, 293521200);
            TestUtils.AreEqual(a1 % b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            int2 r2 = int2(1106019119, 495331321);
            TestUtils.AreEqual(a2 % b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            int2 r3 = int2(607694850, 139661505);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int2_operator_mod_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(1654214329, 652514842);
            TestUtils.AreEqual(a0 % b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(1646355394, 1615063185);
            TestUtils.AreEqual(a1 % b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(293521200, 1106019119);
            TestUtils.AreEqual(a2 % b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(99562087, 236009755);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int2_operator_mod_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            int2 r0 = int2(1654214329, 349184645);
            TestUtils.AreEqual(a0 % b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            int2 r1 = int2(1646355394, 31292209);
            TestUtils.AreEqual(a1 % b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            int2 r2 = int2(293521200, 780984713);
            TestUtils.AreEqual(a2 % b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            int2 r3 = int2(99562087, 358883653);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void int2_operator_plus()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 r0 = int2(1654214329, 652514842);
            TestUtils.AreEqual(+a0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int2 r1 = int2(1646355394, 1615063185);
            TestUtils.AreEqual(+a1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int2 r2 = int2(1887003832, 1106019119);
            TestUtils.AreEqual(+a2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int2 r3 = int2(1585556050, 1226672397);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void int2_operator_neg()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 r0 = int2(-1654214329, -652514842);
            TestUtils.AreEqual(-a0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int2 r1 = int2(-1646355394, -1615063185);
            TestUtils.AreEqual(-a1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int2 r2 = int2(-1887003832, -1106019119);
            TestUtils.AreEqual(-a2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int2 r3 = int2(-1585556050, -1226672397);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void int2_operator_prefix_inc()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 r0 = int2(1654214330, 652514843);
            TestUtils.AreEqual(++a0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int2 r1 = int2(1646355395, 1615063186);
            TestUtils.AreEqual(++a1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int2 r2 = int2(1887003833, 1106019120);
            TestUtils.AreEqual(++a2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int2 r3 = int2(1585556051, 1226672398);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void int2_operator_postfix_inc()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 r0 = int2(1654214329, 652514842);
            TestUtils.AreEqual(a0++, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int2 r1 = int2(1646355394, 1615063185);
            TestUtils.AreEqual(a1++, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int2 r2 = int2(1887003832, 1106019119);
            TestUtils.AreEqual(a2++, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int2 r3 = int2(1585556050, 1226672397);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void int2_operator_prefix_dec()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 r0 = int2(1654214328, 652514841);
            TestUtils.AreEqual(--a0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int2 r1 = int2(1646355393, 1615063184);
            TestUtils.AreEqual(--a1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int2 r2 = int2(1887003831, 1106019118);
            TestUtils.AreEqual(--a2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int2 r3 = int2(1585556049, 1226672396);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void int2_operator_postfix_dec()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 r0 = int2(1654214329, 652514842);
            TestUtils.AreEqual(a0--, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int2 r1 = int2(1646355394, 1615063185);
            TestUtils.AreEqual(a1--, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int2 r2 = int2(1887003832, 1106019119);
            TestUtils.AreEqual(a2--, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int2 r3 = int2(1585556050, 1226672397);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void int2_operator_bitwise_and_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            int2 r0 = int2(1611745288, 572523010);
            TestUtils.AreEqual(a0 & b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            int2 r1 = int2(1614981121, 1350042760);
            TestUtils.AreEqual(a1 & b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            int2 r2 = int2(1082163714, 151257353);
            TestUtils.AreEqual(a2 & b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            int2 r3 = int2(1344406616, 19005620);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int2_operator_bitwise_and_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(1611745288, 539262984);
            TestUtils.AreEqual(a0 & b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(1610620992, 1614981121);
            TestUtils.AreEqual(a1 & b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(1350042760, 1088979208);
            TestUtils.AreEqual(a2 & b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(478159440, 151257353);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int2_operator_bitwise_and_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            int2 r0 = int2(1611745288, 578815512);
            TestUtils.AreEqual(a0 & b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            int2 r1 = int2(1610620992, 1610702976);
            TestUtils.AreEqual(a1 & b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            int2 r2 = int2(1350042760, 1080557608);
            TestUtils.AreEqual(a2 & b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            int2 r3 = int2(478159440, 1208059904);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void int2_operator_bitwise_or_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            int2 r0 = int2(2059390905, 1726347226);
            TestUtils.AreEqual(a0 | b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            int2 r1 = int2(2043673853, 2130443704);
            TestUtils.AreEqual(a1 | b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            int2 r2 = int2(1609411455, 1570746365);
            TestUtils.AreEqual(a2 | b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            int2 r3 = int2(2146128990, 964130807);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int2_operator_bitwise_or_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(2059390905, 2130173722);
            TestUtils.AreEqual(a0 | b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(2079326191, 2043673853);
            TestUtils.AreEqual(a1 | b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(2130443704, 1610522543);
            TestUtils.AreEqual(a2 | b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(1602727931, 1570746365);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int2_operator_bitwise_or_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            int2 r0 = int2(2059390905, 1727913659);
            TestUtils.AreEqual(a0 | b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            int2 r1 = int2(2079326191, 1650715603);
            TestUtils.AreEqual(a1 | b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            int2 r2 = int2(2130443704, 1912465343);
            TestUtils.AreEqual(a2 | b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            int2 r3 = int2(1602727931, 1604168543);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void int2_operator_bitwise_xor_wide_wide()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 b0 = int2(2016921864, 1646355394);
            int2 r0 = int2(447645617, 1153824216);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2 a1 = int2(2043591789, 1887003832);
            int2 b1 = int2(1615063185, 1593482632);
            int2 r1 = int2(428692732, 780400944);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2 a2 = int2(1106019119, 495331321);
            int2 b2 = int2(1585556050, 1226672397);
            int2 r2 = int2(527247741, 1419489012);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2 a3 = int2(2049115228, 561398966);
            int2 b3 = int2(1441420378, 421737461);
            int2 r3 = int2(801722374, 945125187);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int2_operator_bitwise_xor_wide_scalar()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(447645617, 1590910738);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(468705199, 428692732);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(780400944, 521543335);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(1124568491, 1419489012);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int2_operator_bitwise_xor_scalar_wide()
        {
            int a0 = (1654214329);
            int2 b0 = int2(2016921864, 652514842);
            int2 r0 = int2(447645617, 1149098147);
            TestUtils.AreEqual(a0 ^ b0, r0);

            int a1 = (1646355394);
            int2 b1 = int2(2043591789, 1615063185);
            int2 r1 = int2(468705199, 40012627);
            TestUtils.AreEqual(a1 ^ b1, r1);

            int a2 = (1887003832);
            int2 b2 = int2(1593482632, 1106019119);
            int2 r2 = int2(780400944, 831907735);
            TestUtils.AreEqual(a2 ^ b2, r2);

            int a3 = (1585556050);
            int2 b3 = int2(495331321, 1226672397);
            int2 r3 = int2(1124568491, 396108639);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void int2_operator_left_shift()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(-1722894080, -459924992);
            TestUtils.AreEqual(a0 << b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(746078208, 2098339840);
            TestUtils.AreEqual(a1 << b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(2036643840, -326947072);
            TestUtils.AreEqual(a2 << b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(-1543503872, 436207616);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void int2_operator_right_shift()
        {
            int2 a0 = int2(1654214329, 652514842);
            int b0 = (2016921864);
            int2 r0 = int2(6461774, 2548886);
            TestUtils.AreEqual(a0 >> b0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int b1 = (2043591789);
            int2 r1 = int2(200971, 197151);
            TestUtils.AreEqual(a1 >> b1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int b2 = (1593482632);
            int2 r2 = int2(7371108, 4320387);
            TestUtils.AreEqual(a2 >> b2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int b3 = (495331321);
            int2 r3 = int2(47, 36);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void int2_operator_bitwise_not()
        {
            int2 a0 = int2(1654214329, 652514842);
            int2 r0 = int2(-1654214330, -652514843);
            TestUtils.AreEqual(~a0, r0);

            int2 a1 = int2(1646355394, 1615063185);
            int2 r1 = int2(-1646355395, -1615063186);
            TestUtils.AreEqual(~a1, r1);

            int2 a2 = int2(1887003832, 1106019119);
            int2 r2 = int2(-1887003833, -1106019120);
            TestUtils.AreEqual(~a2, r2);

            int2 a3 = int2(1585556050, 1226672397);
            int2 r3 = int2(-1585556051, -1226672398);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
