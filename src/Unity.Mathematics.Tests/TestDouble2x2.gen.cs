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
            double2x2 a0 = double2x2(492.15758275061728, -495.20632027797694, 227.45765195947968, -147.37405950733182);
            double2x2 b0 = double2x2(192.56880888369346, -235.61102472786376, -254.04311740307281, -412.62472052715009);
            bool2x2 r0 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2x2 a1 = double2x2(-222.68201909897942, 64.093720704360749, -23.890404473939157, -16.8197190839889);
            double2x2 b1 = double2x2(471.90480945627428, -6.4727852374654162, -339.10237447316865, 488.1875700839737);
            bool2x2 r1 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2x2 a2 = double2x2(163.23210890741655, -165.27101071424363, 470.87767980568003, -423.94255967808078);
            double2x2 b2 = double2x2(-379.5965842584132, -308.41700258311675, -82.333374300195544, -102.92108087563935);
            bool2x2 r2 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2x2 a3 = double2x2(109.63436918595539, 462.69031283943468, -335.38147727371262, 357.23446934168896);
            double2x2 b3 = double2x2(226.51573835430463, -356.90132896830391, -362.91277544708589, -427.89843746083716);
            bool2x2 r3 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double2x2_operator_equal_wide_scalar()
        {
            double2x2 a0 = double2x2(-303.2300766926399, 451.52631327674089, -253.65587413201848, -105.20363502632995);
            double b0 = (123.5445759871717);
            bool2x2 r0 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2x2 a1 = double2x2(-500.6910920090466, 159.87609656149334, -59.558379439431405, -57.477391031327386);
            double b1 = (-426.19248338518315);
            bool2x2 r1 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2x2 a2 = double2x2(-182.0497396840014, 370.88599866017978, -172.03530629539642, 455.40001198993991);
            double b2 = (406.51375861024189);
            bool2x2 r2 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2x2 a3 = double2x2(-11.338988547836891, -27.150561106927, -325.97606507221985, -290.35904254129116);
            double b3 = (363.93823044557973);
            bool2x2 r3 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double2x2_operator_equal_scalar_wide()
        {
            double a0 = (-253.39728534100453);
            double2x2 b0 = double2x2(19.952187785856495, -185.79199346610903, 407.8136052600172, -87.2766969610363);
            bool2x2 r0 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (-206.27469382354741);
            double2x2 b1 = double2x2(160.503138855334, -274.77081478516141, -2.6315281403397535, 448.35453602688131);
            bool2x2 r1 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (-410.03524251004461);
            double2x2 b2 = double2x2(247.32901465489022, 355.53915350303942, -298.06671180299793, 414.10151429385951);
            bool2x2 r2 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (-481.30262707234482);
            double2x2 b3 = double2x2(196.55074438664633, 34.60100008668428, 113.76156645350227, -386.45337861890596);
            bool2x2 r3 = bool2x2(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double2x2_operator_not_equal_wide_wide()
        {
            double2x2 a0 = double2x2(430.8425316432689, 104.69001798736394, 225.80243478799355, -310.57017841496048);
            double2x2 b0 = double2x2(210.02470622305975, -55.203330304102678, -269.92533672504373, -234.54673372700194);
            bool2x2 r0 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2x2 a1 = double2x2(-418.61945815506363, 304.12820281839379, -509.32682561749908, -160.53807719076895);
            double2x2 b1 = double2x2(25.917412054686565, -63.726991444699024, -484.55371092471933, -425.333599050219);
            bool2x2 r1 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2x2 a2 = double2x2(-203.30197606016975, -505.76325368590807, 162.17220623892365, 1.1561973100324394);
            double2x2 b2 = double2x2(-53.274394775402925, 328.1944192984115, 15.963139303011417, 461.71412417931208);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2x2 a3 = double2x2(65.662074358045174, 102.78780250567377, 172.93008120960099, 26.621009123800832);
            double2x2 b3 = double2x2(-113.36304455313973, -240.07297264787974, 495.11916970420589, 203.5583661550462);
            bool2x2 r3 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double2x2_operator_not_equal_wide_scalar()
        {
            double2x2 a0 = double2x2(-16.914588697680529, 168.83411486858233, -462.71352145760949, 130.30776959765137);
            double b0 = (-145.37277109239847);
            bool2x2 r0 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2x2 a1 = double2x2(214.50161443208424, -197.12796053529155, -169.09985860115842, -386.61117595555783);
            double b1 = (-440.26328178879959);
            bool2x2 r1 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2x2 a2 = double2x2(-281.02101362916687, -403.96372313236992, -269.80570877241234, 299.65422763473089);
            double b2 = (-270.26885593601912);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2x2 a3 = double2x2(-71.750904831919286, -457.36312100727258, -13.519590622521719, 273.87305773136814);
            double b3 = (-432.75573917513515);
            bool2x2 r3 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double2x2_operator_not_equal_scalar_wide()
        {
            double a0 = (275.79582823244664);
            double2x2 b0 = double2x2(-57.196896341255353, -382.4325279586169, 97.820359990848374, -161.46364529499022);
            bool2x2 r0 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (-458.39563367254829);
            double2x2 b1 = double2x2(-499.61786364932448, 327.92217818271467, 367.57121699283425, 59.7863667289663);
            bool2x2 r1 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (-209.58068118318016);
            double2x2 b2 = double2x2(-62.580453186566217, -479.97497604786184, -49.494519495169868, -114.68521338081229);
            bool2x2 r2 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (109.93924599044919);
            double2x2 b3 = double2x2(-176.28482755286842, -347.48529903380449, 85.540928165214609, -356.65954868712441);
            bool2x2 r3 = bool2x2(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }


    }
}
