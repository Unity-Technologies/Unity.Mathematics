// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble3x3
    {
        [Test]
        public void double3x3_operator_equal_wide_wide()
        {
            double3x3 a0 = double3x3(492.15758275061728, -495.20632027797694, 227.45765195947968);
            double3x3 b0 = double3x3(192.56880888369346, -235.61102472786376, -254.04311740307281);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double3x3 a1 = double3x3(-147.37405950733182, -222.68201909897942, 64.093720704360749);
            double3x3 b1 = double3x3(-412.62472052715009, 471.90480945627428, -6.4727852374654162);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double3x3 a2 = double3x3(-23.890404473939157, -16.8197190839889, 163.23210890741655);
            double3x3 b2 = double3x3(-339.10237447316865, 488.1875700839737, -379.5965842584132);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double3x3 a3 = double3x3(-165.27101071424363, 470.87767980568003, -423.94255967808078);
            double3x3 b3 = double3x3(-308.41700258311675, -82.333374300195544, -102.92108087563935);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double3x3_operator_equal_wide_scalar()
        {
            double3x3 a0 = double3x3(-303.2300766926399, 451.52631327674089, -253.65587413201848);
            double b0 = (123.5445759871717);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double3x3 a1 = double3x3(-105.20363502632995, -426.19248338518315, 159.87609656149334);
            double b1 = (-500.6910920090466);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double3x3 a2 = double3x3(-59.558379439431405, -182.0497396840014, 406.51375861024189);
            double b2 = (-57.477391031327386);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double3x3 a3 = double3x3(370.88599866017978, 455.40001198993991, -11.338988547836891);
            double b3 = (-172.03530629539642);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double3x3_operator_equal_scalar_wide()
        {
            double a0 = (-253.39728534100453);
            double3x3 b0 = double3x3(19.952187785856495, -185.79199346610903, 407.8136052600172);
            bool3x3 r0 = bool3x3(false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (-87.2766969610363);
            double3x3 b1 = double3x3(-206.27469382354741, 160.503138855334, -274.77081478516141);
            bool3x3 r1 = bool3x3(false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (-2.6315281403397535);
            double3x3 b2 = double3x3(448.35453602688131, -410.03524251004461, 247.32901465489022);
            bool3x3 r2 = bool3x3(false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (355.53915350303942);
            double3x3 b3 = double3x3(-298.06671180299793, 414.10151429385951, -481.30262707234482);
            bool3x3 r3 = bool3x3(false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double3x3_operator_not_equal_wide_wide()
        {
            double3x3 a0 = double3x3(430.8425316432689, 104.69001798736394, 225.80243478799355);
            double3x3 b0 = double3x3(210.02470622305975, -55.203330304102678, -269.92533672504373);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double3x3 a1 = double3x3(-310.57017841496048, -418.61945815506363, 304.12820281839379);
            double3x3 b1 = double3x3(-234.54673372700194, 25.917412054686565, -63.726991444699024);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double3x3 a2 = double3x3(-509.32682561749908, -160.53807719076895, -203.30197606016975);
            double3x3 b2 = double3x3(-484.55371092471933, -425.333599050219, -53.274394775402925);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double3x3 a3 = double3x3(-505.76325368590807, 162.17220623892365, 1.1561973100324394);
            double3x3 b3 = double3x3(328.1944192984115, 15.963139303011417, 461.71412417931208);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double3x3_operator_not_equal_wide_scalar()
        {
            double3x3 a0 = double3x3(-16.914588697680529, 168.83411486858233, -462.71352145760949);
            double b0 = (-145.37277109239847);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double3x3 a1 = double3x3(130.30776959765137, -440.26328178879959, -197.12796053529155);
            double b1 = (214.50161443208424);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double3x3 a2 = double3x3(-169.09985860115842, -281.02101362916687, -270.26885593601912);
            double b2 = (-386.61117595555783);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double3x3 a3 = double3x3(-403.96372313236992, 299.65422763473089, -71.750904831919286);
            double b3 = (-269.80570877241234);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double3x3_operator_not_equal_scalar_wide()
        {
            double a0 = (275.79582823244664);
            double3x3 b0 = double3x3(-57.196896341255353, -382.4325279586169, 97.820359990848374);
            bool3x3 r0 = bool3x3(true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (-161.46364529499022);
            double3x3 b1 = double3x3(-458.39563367254829, -499.61786364932448, 327.92217818271467);
            bool3x3 r1 = bool3x3(true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (367.57121699283425);
            double3x3 b2 = double3x3(59.7863667289663, -209.58068118318016, -62.580453186566217);
            bool3x3 r2 = bool3x3(true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (-479.97497604786184);
            double3x3 b3 = double3x3(-49.494519495169868, -114.68521338081229, 109.93924599044919);
            bool3x3 r3 = bool3x3(true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }


    }
}
