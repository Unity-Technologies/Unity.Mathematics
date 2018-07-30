// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestDouble2x3
    {
        [Test]
        public void double2x3_operator_equal_wide_wide()
        {
            double2x3 a0 = double2x3(492.15758275061728, -495.20632027797694, 227.45765195947968, -147.37405950733182, -222.68201909897942, 64.093720704360749);
            double2x3 b0 = double2x3(192.56880888369346, -235.61102472786376, -254.04311740307281, -412.62472052715009, 471.90480945627428, -6.4727852374654162);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2x3 a1 = double2x3(-23.890404473939157, -16.8197190839889, 163.23210890741655, -165.27101071424363, 470.87767980568003, -423.94255967808078);
            double2x3 b1 = double2x3(-339.10237447316865, 488.1875700839737, -379.5965842584132, -308.41700258311675, -82.333374300195544, -102.92108087563935);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2x3 a2 = double2x3(109.63436918595539, 462.69031283943468, -335.38147727371262, 357.23446934168896, 1.5455777652308598, -347.38824741327585);
            double2x3 b2 = double2x3(226.51573835430463, -356.90132896830391, -362.91277544708589, -427.89843746083716, 466.65013978753711, -102.79904680270658);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2x3 a3 = double2x3(-114.47217302884542, 435.84865804940864, 194.23808607563285, 138.76554710174241, -467.34914205379278, 370.43337767684523);
            double2x3 b3 = double2x3(-43.355954428834821, 85.045664111639212, -91.127054972167628, 422.19208856215334, -477.43130873024057, 1.8770024785198984);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double2x3_operator_equal_wide_scalar()
        {
            double2x3 a0 = double2x3(-303.2300766926399, 451.52631327674089, -253.65587413201848, -105.20363502632995, -500.6910920090466, -426.19248338518315);
            double b0 = (123.5445759871717);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double2x3 a1 = double2x3(159.87609656149334, -57.477391031327386, -182.0497396840014, 406.51375861024189, 370.88599866017978, -172.03530629539642);
            double b1 = (-59.558379439431405);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double2x3 a2 = double2x3(455.40001198993991, 363.93823044557973, -27.150561106927, -325.97606507221985, -290.35904254129116, 180.19686635779067);
            double b2 = (-11.338988547836891);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double2x3 a3 = double2x3(-374.12832015293105, -126.54608899287234, -197.2617896521752, -227.15933357326281, -479.8991937487848, -439.77767750237962);
            double b3 = (-439.35894295170851);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double2x3_operator_equal_scalar_wide()
        {
            double a0 = (-253.39728534100453);
            double2x3 b0 = double2x3(19.952187785856495, -185.79199346610903, 407.8136052600172, -87.2766969610363, -206.27469382354741, 160.503138855334);
            bool2x3 r0 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            double a1 = (-274.77081478516141);
            double2x3 b1 = double2x3(-2.6315281403397535, 448.35453602688131, -410.03524251004461, 247.32901465489022, 355.53915350303942, -298.06671180299793);
            bool2x3 r1 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            double a2 = (414.10151429385951);
            double2x3 b2 = double2x3(-481.30262707234482, 196.55074438664633, 34.60100008668428, 113.76156645350227, -386.45337861890596, -124.49174672201821);
            bool2x3 r2 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            double a3 = (243.8866447153905);
            double2x3 b3 = double2x3(-492.6181826501238, 145.424413033493, 421.55070968230757, -95.409988209330493, 336.80928746648567, 209.58380589707929);
            bool2x3 r3 = bool2x3(false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void double2x3_operator_not_equal_wide_wide()
        {
            double2x3 a0 = double2x3(430.8425316432689, 104.69001798736394, 225.80243478799355, -310.57017841496048, -418.61945815506363, 304.12820281839379);
            double2x3 b0 = double2x3(210.02470622305975, -55.203330304102678, -269.92533672504373, -234.54673372700194, 25.917412054686565, -63.726991444699024);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2x3 a1 = double2x3(-509.32682561749908, -160.53807719076895, -203.30197606016975, -505.76325368590807, 162.17220623892365, 1.1561973100324394);
            double2x3 b1 = double2x3(-484.55371092471933, -425.333599050219, -53.274394775402925, 328.1944192984115, 15.963139303011417, 461.71412417931208);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2x3 a2 = double2x3(65.662074358045174, 102.78780250567377, 172.93008120960099, 26.621009123800832, 235.12595259171258, 128.54198533321824);
            double2x3 b2 = double2x3(-113.36304455313973, -240.07297264787974, 495.11916970420589, 203.5583661550462, 340.49345103860526, -241.90719448863865);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2x3 a3 = double2x3(-354.99697630246959, 334.35948220564023, -495.83200692377613, 468.30740163675853, 458.37094733601941, 299.93733300824522);
            double2x3 b3 = double2x3(459.56982896270688, 213.0737384357833, -384.7828506831, -255.07233846144396, 477.66343115161328, -248.03662621604121);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double2x3_operator_not_equal_wide_scalar()
        {
            double2x3 a0 = double2x3(-16.914588697680529, 168.83411486858233, -462.71352145760949, 130.30776959765137, 214.50161443208424, -440.26328178879959);
            double b0 = (-145.37277109239847);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double2x3 a1 = double2x3(-197.12796053529155, -386.61117595555783, -281.02101362916687, -270.26885593601912, -403.96372313236992, -269.80570877241234);
            double b1 = (-169.09985860115842);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double2x3 a2 = double2x3(299.65422763473089, -432.75573917513515, -457.36312100727258, -13.519590622521719, 273.87305773136814, 185.042454567292);
            double b2 = (-71.750904831919286);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double2x3 a3 = double2x3(-482.53069351731364, 511.73495578753523, 230.50753628020527, 100.27476768394683, 129.68240863163135, 321.17879048044733);
            double b3 = (116.39514427836764);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void double2x3_operator_not_equal_scalar_wide()
        {
            double a0 = (275.79582823244664);
            double2x3 b0 = double2x3(-57.196896341255353, -382.4325279586169, 97.820359990848374, -161.46364529499022, -458.39563367254829, -499.61786364932448);
            bool2x3 r0 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            double a1 = (327.92217818271467);
            double2x3 b1 = double2x3(367.57121699283425, 59.7863667289663, -209.58068118318016, -62.580453186566217, -479.97497604786184, -49.494519495169868);
            bool2x3 r1 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            double a2 = (-114.68521338081229);
            double2x3 b2 = double2x3(109.93924599044919, -176.28482755286842, -347.48529903380449, 85.540928165214609, -356.65954868712441, -104.24357490625397);
            bool2x3 r2 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            double a3 = (-133.54918605347592);
            double2x3 b3 = double2x3(243.53971135036079, 13.141311890045813, -379.98594754747393, -41.281226892620907, 87.911684792447659, -339.07727996403224);
            bool2x3 r3 = bool2x3(true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }


    }
}
