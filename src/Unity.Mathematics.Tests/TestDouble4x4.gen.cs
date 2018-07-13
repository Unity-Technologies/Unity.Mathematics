// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble4x4
    {
        [Test]
        public void double4x4_operator_equal_wide_wide()
        {
            double4x4 a0 = double4x4(492.15758275061728, -495.20632027797694, 227.45765195947968, -147.37405950733182);
            double4x4 b0 = double4x4(192.56880888369346, -235.61102472786376, -254.04311740307281, -412.62472052715009);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double4x4 a1 = double4x4(-222.68201909897942, 64.093720704360749, -23.890404473939157, -16.8197190839889);
            double4x4 b1 = double4x4(471.90480945627428, -6.4727852374654162, -339.10237447316865, 488.1875700839737);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double4x4 a2 = double4x4(163.23210890741655, -165.27101071424363, 470.87767980568003, -423.94255967808078);
            double4x4 b2 = double4x4(-379.5965842584132, -308.41700258311675, -82.333374300195544, -102.92108087563935);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double4x4 a3 = double4x4(109.63436918595539, 462.69031283943468, -335.38147727371262, 357.23446934168896);
            double4x4 b3 = double4x4(226.51573835430463, -356.90132896830391, -362.91277544708589, -427.89843746083716);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double4x4_operator_equal_wide_scalar()
        {
            double4x4 a0 = double4x4(-303.2300766926399, 451.52631327674089, -253.65587413201848, -105.20363502632995);
            double b0 = (123.5445759871717);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double4x4 a1 = double4x4(-500.6910920090466, 159.87609656149334, -59.558379439431405, -57.477391031327386);
            double b1 = (-426.19248338518315);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double4x4 a2 = double4x4(-182.0497396840014, 370.88599866017978, -172.03530629539642, 455.40001198993991);
            double b2 = (406.51375861024189);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double4x4 a3 = double4x4(-11.338988547836891, -27.150561106927, -325.97606507221985, -290.35904254129116);
            double b3 = (363.93823044557973);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double4x4_operator_equal_scalar_wide()
        {
            double a0 = (-253.39728534100453);
            double4x4 b0 = double4x4(19.952187785856495, -185.79199346610903, 407.8136052600172, -87.2766969610363);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (-206.27469382354741);
            double4x4 b1 = double4x4(160.503138855334, -274.77081478516141, -2.6315281403397535, 448.35453602688131);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (-410.03524251004461);
            double4x4 b2 = double4x4(247.32901465489022, 355.53915350303942, -298.06671180299793, 414.10151429385951);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (-481.30262707234482);
            double4x4 b3 = double4x4(196.55074438664633, 34.60100008668428, 113.76156645350227, -386.45337861890596);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double4x4_operator_not_equal_wide_wide()
        {
            double4x4 a0 = double4x4(430.8425316432689, 104.69001798736394, 225.80243478799355, -310.57017841496048);
            double4x4 b0 = double4x4(210.02470622305975, -55.203330304102678, -269.92533672504373, -234.54673372700194);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double4x4 a1 = double4x4(-418.61945815506363, 304.12820281839379, -509.32682561749908, -160.53807719076895);
            double4x4 b1 = double4x4(25.917412054686565, -63.726991444699024, -484.55371092471933, -425.333599050219);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double4x4 a2 = double4x4(-203.30197606016975, -505.76325368590807, 162.17220623892365, 1.1561973100324394);
            double4x4 b2 = double4x4(-53.274394775402925, 328.1944192984115, 15.963139303011417, 461.71412417931208);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double4x4 a3 = double4x4(65.662074358045174, 102.78780250567377, 172.93008120960099, 26.621009123800832);
            double4x4 b3 = double4x4(-113.36304455313973, -240.07297264787974, 495.11916970420589, 203.5583661550462);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double4x4_operator_not_equal_wide_scalar()
        {
            double4x4 a0 = double4x4(-16.914588697680529, 168.83411486858233, -462.71352145760949, 130.30776959765137);
            double b0 = (-145.37277109239847);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double4x4 a1 = double4x4(214.50161443208424, -197.12796053529155, -169.09985860115842, -386.61117595555783);
            double b1 = (-440.26328178879959);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double4x4 a2 = double4x4(-281.02101362916687, -403.96372313236992, -269.80570877241234, 299.65422763473089);
            double b2 = (-270.26885593601912);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double4x4 a3 = double4x4(-71.750904831919286, -457.36312100727258, -13.519590622521719, 273.87305773136814);
            double b3 = (-432.75573917513515);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double4x4_operator_not_equal_scalar_wide()
        {
            double a0 = (275.79582823244664);
            double4x4 b0 = double4x4(-57.196896341255353, -382.4325279586169, 97.820359990848374, -161.46364529499022);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (-458.39563367254829);
            double4x4 b1 = double4x4(-499.61786364932448, 327.92217818271467, 367.57121699283425, 59.7863667289663);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (-209.58068118318016);
            double4x4 b2 = double4x4(-62.580453186566217, -479.97497604786184, -49.494519495169868, -114.68521338081229);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (109.93924599044919);
            double4x4 b3 = double4x4(-176.28482755286842, -347.48529903380449, 85.540928165214609, -356.65954868712441);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }


    }
}
