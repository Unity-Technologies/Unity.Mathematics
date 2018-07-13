// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble2x2
    {
        [Test]
        public void double2x2_operator_equal_wide_wide()
        {
            double2x2 a0 = double2x2(492.15758275061728, -495.20632027797694);
            double2x2 b0 = double2x2(192.56880888369346, -235.61102472786376);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2x2 a1 = double2x2(227.45765195947968, -147.37405950733182);
            double2x2 b1 = double2x2(-254.04311740307281, -412.62472052715009);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2x2 a2 = double2x2(-222.68201909897942, 64.093720704360749);
            double2x2 b2 = double2x2(471.90480945627428, -6.4727852374654162);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2x2 a3 = double2x2(-23.890404473939157, -16.8197190839889);
            double2x2 b3 = double2x2(-339.10237447316865, 488.1875700839737);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double2x2_operator_equal_wide_scalar()
        {
            double2x2 a0 = double2x2(-303.2300766926399, 451.52631327674089);
            double b0 = (123.5445759871717);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2x2 a1 = double2x2(-253.65587413201848, -500.6910920090466);
            double b1 = (-105.20363502632995);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2x2 a2 = double2x2(-426.19248338518315, -59.558379439431405);
            double b2 = (159.87609656149334);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2x2 a3 = double2x2(-57.477391031327386, 406.51375861024189);
            double b3 = (-182.0497396840014);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double2x2_operator_equal_scalar_wide()
        {
            double a0 = (-253.39728534100453);
            double2x2 b0 = double2x2(19.952187785856495, -185.79199346610903);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (407.8136052600172);
            double2x2 b1 = double2x2(-87.2766969610363, -206.27469382354741);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (160.503138855334);
            double2x2 b2 = double2x2(-274.77081478516141, -2.6315281403397535);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (448.35453602688131);
            double2x2 b3 = double2x2(-410.03524251004461, 247.32901465489022);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double2x2_operator_not_equal_wide_wide()
        {
            double2x2 a0 = double2x2(430.8425316432689, 104.69001798736394);
            double2x2 b0 = double2x2(210.02470622305975, -55.203330304102678);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2x2 a1 = double2x2(225.80243478799355, -310.57017841496048);
            double2x2 b1 = double2x2(-269.92533672504373, -234.54673372700194);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2x2 a2 = double2x2(-418.61945815506363, 304.12820281839379);
            double2x2 b2 = double2x2(25.917412054686565, -63.726991444699024);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2x2 a3 = double2x2(-509.32682561749908, -160.53807719076895);
            double2x2 b3 = double2x2(-484.55371092471933, -425.333599050219);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double2x2_operator_not_equal_wide_scalar()
        {
            double2x2 a0 = double2x2(-16.914588697680529, 168.83411486858233);
            double b0 = (-145.37277109239847);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2x2 a1 = double2x2(-462.71352145760949, 214.50161443208424);
            double b1 = (130.30776959765137);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2x2 a2 = double2x2(-440.26328178879959, -169.09985860115842);
            double b2 = (-197.12796053529155);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2x2 a3 = double2x2(-386.61117595555783, -270.26885593601912);
            double b3 = (-281.02101362916687);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double2x2_operator_not_equal_scalar_wide()
        {
            double a0 = (275.79582823244664);
            double2x2 b0 = double2x2(-57.196896341255353, -382.4325279586169);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (97.820359990848374);
            double2x2 b1 = double2x2(-161.46364529499022, -458.39563367254829);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (-499.61786364932448);
            double2x2 b2 = double2x2(327.92217818271467, 367.57121699283425);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (59.7863667289663);
            double2x2 b3 = double2x2(-209.58068118318016, -62.580453186566217);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }


    }
}
