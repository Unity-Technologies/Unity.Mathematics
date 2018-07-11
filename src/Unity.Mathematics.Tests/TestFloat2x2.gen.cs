// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat2x2
    {
        [Test]
        public void float2x2_operator_equal_wide_wide()
        {
            float2x2 a0 = float2x2(492.1576f, -495.206329f);
            float2x2 b0 = float2x2(192.568787f, -235.611023f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x2 a1 = float2x2(227.457642f, -147.374054f);
            float2x2 b1 = float2x2(-254.043121f, -412.624725f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x2 a2 = float2x2(-222.682f, 64.09375f);
            float2x2 b2 = float2x2(471.9048f, -6.47277832f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x2 a3 = float2x2(-23.8904114f, -16.8197327f);
            float2x2 b3 = float2x2(-339.102356f, 488.187561f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2x2_operator_equal_wide_scalar()
        {
            float2x2 a0 = float2x2(-303.230072f, 451.5263f);
            float b0 = (123.544556f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float2x2 a1 = float2x2(-253.655884f, -500.6911f);
            float b1 = (-105.203644f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float2x2 a2 = float2x2(-426.192474f, -59.55838f);
            float b2 = (159.8761f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float2x2 a3 = float2x2(-57.4773865f, 406.513733f);
            float b3 = (-182.049744f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2x2_operator_equal_scalar_wide()
        {
            float a0 = (-253.397278f);
            float2x2 b0 = float2x2(19.95221f, -185.791992f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (407.8136f);
            float2x2 b1 = float2x2(-87.2767f, -206.274689f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (160.503113f);
            float2x2 b2 = float2x2(-274.7708f, -2.63153076f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (448.354553f);
            float2x2 b3 = float2x2(-410.035248f, 247.329041f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float2x2_operator_not_equal_wide_wide()
        {
            float2x2 a0 = float2x2(430.842529f, 104.69f);
            float2x2 b0 = float2x2(210.024719f, -55.20334f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x2 a1 = float2x2(225.802429f, -310.5702f);
            float2x2 b1 = float2x2(-269.925354f, -234.546722f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x2 a2 = float2x2(-418.619446f, 304.128174f);
            float2x2 b2 = float2x2(25.91742f, -63.72699f);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x2 a3 = float2x2(-509.3268f, -160.538086f);
            float2x2 b3 = float2x2(-484.5537f, -425.3336f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2x2_operator_not_equal_wide_scalar()
        {
            float2x2 a0 = float2x2(-16.9145813f, 168.8341f);
            float b0 = (-145.372772f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float2x2 a1 = float2x2(-462.713531f, 214.501587f);
            float b1 = (130.307739f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float2x2 a2 = float2x2(-440.263275f, -169.099854f);
            float b2 = (-197.12796f);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float2x2 a3 = float2x2(-386.611176f, -270.26886f);
            float b3 = (-281.021f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2x2_operator_not_equal_scalar_wide()
        {
            float a0 = (275.795837f);
            float2x2 b0 = float2x2(-57.1969f, -382.432526f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (97.82037f);
            float2x2 b1 = float2x2(-161.463654f, -458.39563f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-499.617859f);
            float2x2 b2 = float2x2(327.92218f, 367.571228f);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (59.786377f);
            float2x2 b3 = float2x2(-209.580688f, -62.5804443f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float2x2_operator_less_wide_wide()
        {
            float2x2 a0 = float2x2(196.84259f, 336.4098f);
            float2x2 b0 = float2x2(-465.345032f, -256.1524f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x2 a1 = float2x2(251.963745f, 257.655945f);
            float2x2 b1 = float2x2(-314.814026f, 364.5667f);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x2 a2 = float2x2(430.0459f, -62.4196472f);
            float2x2 b2 = float2x2(100.21051f, 182.560974f);
            bool2x2 r2 = bool2x2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x2 a3 = float2x2(8.839233f, -333.8167f);
            float2x2 b3 = float2x2(3.11700439f, -259.430481f);
            bool2x2 r3 = bool2x2(false, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2x2_operator_less_wide_scalar()
        {
            float2x2 a0 = float2x2(-132.057312f, -192.465f);
            float b0 = (-156.010223f);
            bool2x2 r0 = bool2x2(false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float2x2 a1 = float2x2(-66.8345947f, -360.2824f);
            float b1 = (-379.017517f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float2x2 a2 = float2x2(20.9278564f, 437.3459f);
            float b2 = (-158.240753f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float2x2 a3 = float2x2(-20.4526062f, 307.4842f);
            float b3 = (225.2915f);
            bool2x2 r3 = bool2x2(true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2x2_operator_less_scalar_wide()
        {
            float a0 = (-423.1174f);
            float2x2 b0 = float2x2(385.094849f, -123.933472f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (86.37659f);
            float2x2 b1 = float2x2(133.4422f, 161.457947f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (229.754272f);
            float2x2 b2 = float2x2(222.5716f, 315.5312f);
            bool2x2 r2 = bool2x2(false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-447.203522f);
            float2x2 b3 = float2x2(271.833862f, -393.605316f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_wide_wide()
        {
            float2x2 a0 = float2x2(483.5014f, 310.8156f);
            float2x2 b0 = float2x2(-471.398f, -371.9853f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x2 a1 = float2x2(106.966187f, 295.7353f);
            float2x2 b1 = float2x2(36.9006958f, -316.7636f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x2 a2 = float2x2(116.957581f, -478.299774f);
            float2x2 b2 = float2x2(19.6830444f, 207.309143f);
            bool2x2 r2 = bool2x2(true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x2 a3 = float2x2(-14.8974f, -33.8174438f);
            float2x2 b3 = float2x2(362.7975f, 324.95343f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_wide_scalar()
        {
            float2x2 a0 = float2x2(64.31793f, -397.703461f);
            float b0 = (305.859924f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float2x2 a1 = float2x2(431.8769f, 246.263062f);
            float b1 = (85.703f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float2x2 a2 = float2x2(197.491577f, 280.813354f);
            float b2 = (286.199463f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float2x2 a3 = float2x2(-405.7846f, -241.807281f);
            float b3 = (171.565369f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_scalar_wide()
        {
            float a0 = (-282.6705f);
            float2x2 b0 = float2x2(358.099976f, -72.596405f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (-232.163788f);
            float2x2 b1 = float2x2(-60.7067261f, 75.15662f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (150.883484f);
            float2x2 b2 = float2x2(339.539185f, -498.196045f);
            bool2x2 r2 = bool2x2(false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (459.7461f);
            float2x2 b3 = float2x2(-227.968719f, 335.862122f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float2x2_operator_less_equal_wide_wide()
        {
            float2x2 a0 = float2x2(-438.523132f, 210.489441f);
            float2x2 b0 = float2x2(-474.814148f, 304.371033f);
            bool2x2 r0 = bool2x2(false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x2 a1 = float2x2(4.87731934f, -137.297943f);
            float2x2 b1 = float2x2(234.824158f, -390.485443f);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x2 a2 = float2x2(156.094116f, -363.924133f);
            float2x2 b2 = float2x2(-297.175354f, -326.2924f);
            bool2x2 r2 = bool2x2(false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x2 a3 = float2x2(-97.94849f, 437.2954f);
            float2x2 b3 = float2x2(107.253906f, -413.131073f);
            bool2x2 r3 = bool2x2(true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2x2_operator_less_equal_wide_scalar()
        {
            float2x2 a0 = float2x2(193.49585f, 168.915527f);
            float b0 = (443.850525f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float2x2 a1 = float2x2(-313.993073f, 18.5036011f);
            float b1 = (81.8269653f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float2x2 a2 = float2x2(-0.3581848f, -463.8164f);
            float b2 = (241.361145f);
            bool2x2 r2 = bool2x2(true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float2x2 a3 = float2x2(-1.35775757f, 398.991943f);
            float b3 = (-268.899475f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2x2_operator_less_equal_scalar_wide()
        {
            float a0 = (393.606262f);
            float2x2 b0 = float2x2(-75.6883545f, -44.2638855f);
            bool2x2 r0 = bool2x2(false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (125.864929f);
            float2x2 b1 = float2x2(191.9649f, 13.54303f);
            bool2x2 r1 = bool2x2(true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-197.051941f);
            float2x2 b2 = float2x2(-423.9451f, -330.0486f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (420.165527f);
            float2x2 b3 = float2x2(105.5473f, 174.821289f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_equal_wide_wide()
        {
            float2x2 a0 = float2x2(-507.9286f, 504.4975f);
            float2x2 b0 = float2x2(-81.3465f, 297.666138f);
            bool2x2 r0 = bool2x2(false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x2 a1 = float2x2(-385.4345f, -262.323425f);
            float2x2 b1 = float2x2(171.06543f, -431.038055f);
            bool2x2 r1 = bool2x2(false, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x2 a2 = float2x2(-37.5509338f, -111.595276f);
            float2x2 b2 = float2x2(-6.85907f, 319.7257f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x2 a3 = float2x2(-463.702026f, 387.448853f);
            float2x2 b3 = float2x2(254.079163f, 396.5724f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_equal_wide_scalar()
        {
            float2x2 a0 = float2x2(465.152161f, -424.886078f);
            float b0 = (-5.599884f);
            bool2x2 r0 = bool2x2(true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float2x2 a1 = float2x2(-209.2211f, -302.2691f);
            float b1 = (58.7798462f);
            bool2x2 r1 = bool2x2(false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float2x2 a2 = float2x2(140.12561f, -344.559967f);
            float b2 = (16.3533936f);
            bool2x2 r2 = bool2x2(true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float2x2 a3 = float2x2(393.278076f, 441.011536f);
            float b3 = (-315.701538f);
            bool2x2 r3 = bool2x2(true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2x2_operator_greater_equal_scalar_wide()
        {
            float a0 = (374.827026f);
            float2x2 b0 = float2x2(-1.60977173f, 338.615234f);
            bool2x2 r0 = bool2x2(true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (-116.1814f);
            float2x2 b1 = float2x2(-332.157318f, -355.97937f);
            bool2x2 r1 = bool2x2(true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-468.901428f);
            float2x2 b2 = float2x2(38.579895f, -332.347534f);
            bool2x2 r2 = bool2x2(false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (2.89013672f);
            float2x2 b3 = float2x2(467.777771f, 121.406372f);
            bool2x2 r3 = bool2x2(false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float2x2_operator_add_wide_wide()
        {
            float2x2 a0 = float2x2(506.129028f, -501.779816f);
            float2x2 b0 = float2x2(-28.7579956f, -337.135132f);
            float2x2 r0 = float2x2(477.371033f, -838.9149f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x2 a1 = float2x2(420.084778f, -186.032074f);
            float2x2 b1 = float2x2(-340.676819f, 152.312012f);
            float2x2 r1 = float2x2(79.40796f, -33.7200623f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x2 a2 = float2x2(-9.312408f, 328.51178f);
            float2x2 b2 = float2x2(423.66748f, 90.3740845f);
            float2x2 r2 = float2x2(414.355072f, 418.885864f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x2 a3 = float2x2(424.344055f, 87.79108f);
            float2x2 b3 = float2x2(376.18866f, 1.76721191f);
            float2x2 r3 = float2x2(800.5327f, 89.55829f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2x2_operator_add_wide_scalar()
        {
            float2x2 a0 = float2x2(-194.514191f, 338.5484f);
            float b0 = (124.121704f);
            float2x2 r0 = float2x2(-70.39249f, 462.6701f);
            TestUtils.AreEqual(a0 + b0, r0);

            float2x2 a1 = float2x2(246.971375f, -45.72467f);
            float b1 = (100.510925f);
            float2x2 r1 = float2x2(347.4823f, 54.7862549f);
            TestUtils.AreEqual(a1 + b1, r1);

            float2x2 a2 = float2x2(-478.1113f, 60.37433f);
            float b2 = (30.9161377f);
            float2x2 r2 = float2x2(-447.19516f, 91.29047f);
            TestUtils.AreEqual(a2 + b2, r2);

            float2x2 a3 = float2x2(-242.118744f, 6.79937744f);
            float b3 = (82.50134f);
            float2x2 r3 = float2x2(-159.6174f, 89.30072f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2x2_operator_add_scalar_wide()
        {
            float a0 = (-340.354675f);
            float2x2 b0 = float2x2(511.362244f, -146.216644f);
            float2x2 r0 = float2x2(171.007568f, -486.57132f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (-106.210419f);
            float2x2 b1 = float2x2(-363.450256f, 199.0896f);
            float2x2 r1 = float2x2(-469.660675f, 92.87918f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-27.1083984f);
            float2x2 b2 = float2x2(419.849f, 284.955017f);
            float2x2 r2 = float2x2(392.7406f, 257.846619f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (-164.9242f);
            float2x2 b3 = float2x2(-249.190338f, 150.928162f);
            float2x2 r3 = float2x2(-414.114532f, -13.9960327f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float2x2_operator_sub_wide_wide()
        {
            float2x2 a0 = float2x2(160.492249f, 11.223938f);
            float2x2 b0 = float2x2(115.46875f, -130.9823f);
            float2x2 r0 = float2x2(45.0235f, 142.206238f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x2 a1 = float2x2(359.200134f, -498.2283f);
            float2x2 b1 = float2x2(241.540833f, 9.987061f);
            float2x2 r1 = float2x2(117.6593f, -508.215363f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x2 a2 = float2x2(-355.253632f, -94.53485f);
            float2x2 b2 = float2x2(419.895142f, 59.12445f);
            float2x2 r2 = float2x2(-775.1488f, -153.6593f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x2 a3 = float2x2(-410.46405f, -401.384644f);
            float2x2 b3 = float2x2(-402.381653f, -75.37015f);
            float2x2 r3 = float2x2(-8.082397f, -326.0145f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2x2_operator_sub_wide_scalar()
        {
            float2x2 a0 = float2x2(207.389587f, 248.457764f);
            float b0 = (-36.1124878f);
            float2x2 r0 = float2x2(243.502075f, 284.570251f);
            TestUtils.AreEqual(a0 - b0, r0);

            float2x2 a1 = float2x2(-384.8239f, -374.811554f);
            float b1 = (-205.344757f);
            float2x2 r1 = float2x2(-179.479156f, -169.4668f);
            TestUtils.AreEqual(a1 - b1, r1);

            float2x2 a2 = float2x2(191.642029f, -44.96161f);
            float b2 = (18.8562622f);
            float2x2 r2 = float2x2(172.785767f, -63.81787f);
            TestUtils.AreEqual(a2 - b2, r2);

            float2x2 a3 = float2x2(480.857971f, -366.865448f);
            float b3 = (16.3381958f);
            float2x2 r3 = float2x2(464.519775f, -383.203644f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2x2_operator_sub_scalar_wide()
        {
            float a0 = (-86.00824f);
            float2x2 b0 = float2x2(466.4251f, 298.486938f);
            float2x2 r0 = float2x2(-552.43335f, -384.495178f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (-300.9501f);
            float2x2 b1 = float2x2(315.38f, -381.092163f);
            float2x2 r1 = float2x2(-616.3301f, 80.14206f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-125.008362f);
            float2x2 b2 = float2x2(58.4661865f, 214.7461f);
            float2x2 r2 = float2x2(-183.474548f, -339.754456f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (-257.549438f);
            float2x2 b3 = float2x2(480.2246f, -443.355072f);
            float2x2 r3 = float2x2(-737.774048f, 185.805634f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float2x2_operator_mul_wide_wide()
        {
            float2x2 a0 = float2x2(-482.7138f, -407.2935f);
            float2x2 b0 = float2x2(-236.367889f, 260.7276f);
            float2x2 r0 = float2x2(114098.047f, -106192.656f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x2 a1 = float2x2(137.700562f, 208.541138f);
            float2x2 b1 = float2x2(-416.3863f, -364.4956f);
            float2x2 r1 = float2x2(-57336.625f, -76012.33f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x2 a2 = float2x2(194.29657f, -484.242432f);
            float2x2 b2 = float2x2(-253.147522f, -369.202881f);
            float2x2 r2 = float2x2(-49185.6953f, 178783.7f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x2 a3 = float2x2(183.9873f, -241.33548f);
            float2x2 b3 = float2x2(193.547913f, 169.0849f);
            float2x2 r3 = float2x2(35610.36f, -40806.1836f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2x2_operator_mul_wide_scalar()
        {
            float2x2 a0 = float2x2(-96.31882f, -277.142273f);
            float b0 = (-301.2072f);
            float2x2 r0 = float2x2(29011.9219f, 83477.25f);
            TestUtils.AreEqual(a0 * b0, r0);

            float2x2 a1 = float2x2(-239.93689f, 255.8581f);
            float b1 = (509.531433f);
            float2x2 r1 = float2x2(-122255.391f, 130367.742f);
            TestUtils.AreEqual(a1 * b1, r1);

            float2x2 a2 = float2x2(215.7315f, -389.2433f);
            float b2 = (-455.50827f);
            float2x2 r2 = float2x2(-98267.4844f, 177303.531f);
            TestUtils.AreEqual(a2 * b2, r2);

            float2x2 a3 = float2x2(-338.29248f, 243.757324f);
            float b3 = (53.7962646f);
            float2x2 r3 = float2x2(-18198.8711f, 13113.2334f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2x2_operator_mul_scalar_wide()
        {
            float a0 = (37.43219f);
            float2x2 b0 = float2x2(96.74756f, 492.185364f);
            float2x2 r0 = float2x2(3621.473f, 18423.5762f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (-274.054565f);
            float2x2 b1 = float2x2(-452.870972f, 420.853333f);
            float2x2 r1 = float2x2(124111.359f, -115336.773f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (102.182922f);
            float2x2 b2 = float2x2(-114.948883f, -351.120056f);
            float2x2 r2 = float2x2(-11745.8125f, -35878.4727f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-464.664978f);
            float2x2 b3 = float2x2(444.084839f, 447.1053f);
            float2x2 r3 = float2x2(-206350.672f, -207754.172f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float2x2_operator_div_wide_wide()
        {
            float2x2 a0 = float2x2(-353.131439f, -102.799866f);
            float2x2 b0 = float2x2(-178.739563f, -302.096283f);
            float2x2 r0 = float2x2(1.97567582f, 0.34028843f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x2 a1 = float2x2(51.3191528f, -191.871674f);
            float2x2 b1 = float2x2(-199.405823f, 278.850769f);
            float2x2 r1 = float2x2(-0.257360339f, -0.688080132f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x2 a2 = float2x2(8.041809f, -128.73764f);
            float2x2 b2 = float2x2(502.3376f, -361.484833f);
            float2x2 r2 = float2x2(0.0160087738f, 0.356135666f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x2 a3 = float2x2(-136.0596f, -370.471f);
            float2x2 b3 = float2x2(353.121033f, -38.894928f);
            float2x2 r3 = float2x2(-0.385305852f, 9.524919f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2x2_operator_div_wide_scalar()
        {
            float2x2 a0 = float2x2(171.3424f, 0.103393555f);
            float b0 = (171.796814f);
            float2x2 r0 = float2x2(0.997355f, 0.000601836247f);
            TestUtils.AreEqual(a0 / b0, r0);

            float2x2 a1 = float2x2(57.8882446f, 95.66968f);
            float b1 = (-256.130737f);
            float2x2 r1 = float2x2(-0.226010531f, -0.3735189f);
            TestUtils.AreEqual(a1 / b1, r1);

            float2x2 a2 = float2x2(-290.3869f, -79.7449f);
            float b2 = (-127.4487f);
            float2x2 r2 = float2x2(2.278461f, 0.625701964f);
            TestUtils.AreEqual(a2 / b2, r2);

            float2x2 a3 = float2x2(146.466858f, 58.68634f);
            float b3 = (-499.843567f);
            float2x2 r3 = float2x2(-0.2930254f, -0.117409416f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2x2_operator_div_scalar_wide()
        {
            float a0 = (-264.4425f);
            float2x2 b0 = float2x2(105.589111f, -142.349091f);
            float2x2 r0 = float2x2(-2.50444865f, 1.85770416f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (-288.9489f);
            float2x2 b1 = float2x2(39.644104f, -363.9914f);
            float2x2 r1 = float2x2(-7.28857231f, 0.793834448f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (-149.718231f);
            float2x2 b2 = float2x2(-395.729126f, 258.7187f);
            float2x2 r2 = float2x2(0.378335118f, -0.5786912f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-9.66626f);
            float2x2 b3 = float2x2(117.725525f, -331.386536f);
            float2x2 r3 = float2x2(-0.0821084455f, 0.0291691385f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float2x2_operator_mod_wide_wide()
        {
            float2x2 a0 = float2x2(-388.8125f, 181.681213f);
            float2x2 b0 = float2x2(436.944153f, 58.9400635f);
            float2x2 r0 = float2x2(-388.8125f, 4.861023f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x2 a1 = float2x2(-167.078735f, 432.820129f);
            float2x2 b1 = float2x2(-201.116241f, 279.289368f);
            float2x2 r1 = float2x2(-167.078735f, 153.530762f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x2 a2 = float2x2(-258.438965f, -170.110809f);
            float2x2 b2 = float2x2(-397.079773f, 377.899963f);
            float2x2 r2 = float2x2(-258.438965f, -170.110809f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x2 a3 = float2x2(283.3183f, 122.716492f);
            float2x2 b3 = float2x2(174.693848f, -228.176514f);
            float2x2 r3 = float2x2(108.624451f, 122.716492f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2x2_operator_mod_wide_scalar()
        {
            float2x2 a0 = float2x2(-244.499634f, -211.8193f);
            float b0 = (39.63495f);
            float2x2 r0 = float2x2(-6.68994141f, -13.6445618f);
            TestUtils.AreEqual(a0 % b0, r0);

            float2x2 a1 = float2x2(-145.926788f, 155.479492f);
            float b1 = (-304.9182f);
            float2x2 r1 = float2x2(-145.926788f, 155.479492f);
            TestUtils.AreEqual(a1 % b1, r1);

            float2x2 a2 = float2x2(-133.907776f, -226.535767f);
            float b2 = (281.309631f);
            float2x2 r2 = float2x2(-133.907776f, -226.535767f);
            TestUtils.AreEqual(a2 % b2, r2);

            float2x2 a3 = float2x2(335.166138f, 319.4715f);
            float b3 = (101.706482f);
            float2x2 r3 = float2x2(30.0466919f, 14.3520508f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2x2_operator_mod_scalar_wide()
        {
            float a0 = (-66.94504f);
            float2x2 b0 = float2x2(-249.7761f, -396.073761f);
            float2x2 r0 = float2x2(-66.94504f, -66.94504f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (386.492065f);
            float2x2 b1 = float2x2(168.939453f, -199.418243f);
            float2x2 r1 = float2x2(48.61316f, 187.073822f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (261.7517f);
            float2x2 b2 = float2x2(16.1274414f, 257.668152f);
            float2x2 r2 = float2x2(3.71264648f, 4.083557f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-75.78845f);
            float2x2 b3 = float2x2(170.9563f, -242.858276f);
            float2x2 r3 = float2x2(-75.78845f, -75.78845f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float2x2_operator_plus()
        {
            float2x2 a0 = float2x2(-418.829559f, -405.79895f);
            float2x2 r0 = float2x2(-418.829559f, -405.79895f);
            TestUtils.AreEqual(+a0, r0);

            float2x2 a1 = float2x2(-34.04178f, -459.8391f);
            float2x2 r1 = float2x2(-34.04178f, -459.8391f);
            TestUtils.AreEqual(+a1, r1);

            float2x2 a2 = float2x2(210.86145f, -373.015442f);
            float2x2 r2 = float2x2(210.86145f, -373.015442f);
            TestUtils.AreEqual(+a2, r2);

            float2x2 a3 = float2x2(-386.059845f, -418.645264f);
            float2x2 r3 = float2x2(-386.059845f, -418.645264f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float2x2_operator_neg()
        {
            float2x2 a0 = float2x2(148.461731f, -467.122681f);
            float2x2 r0 = float2x2(-148.461731f, 467.122681f);
            TestUtils.AreEqual(-a0, r0);

            float2x2 a1 = float2x2(132.04718f, 473.701f);
            float2x2 r1 = float2x2(-132.04718f, -473.701f);
            TestUtils.AreEqual(-a1, r1);

            float2x2 a2 = float2x2(-407.9911f, -382.9898f);
            float2x2 r2 = float2x2(407.9911f, 382.9898f);
            TestUtils.AreEqual(-a2, r2);

            float2x2 a3 = float2x2(-299.093384f, 407.709778f);
            float2x2 r3 = float2x2(299.093384f, -407.709778f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float2x2_operator_prefix_inc()
        {
            float2x2 a0 = float2x2(-139.842072f, -56.7436523f);
            float2x2 r0 = float2x2(-138.842072f, -55.7436523f);
            TestUtils.AreEqual(++a0, r0);

            float2x2 a1 = float2x2(-381.955322f, -222.896332f);
            float2x2 r1 = float2x2(-380.955322f, -221.896332f);
            TestUtils.AreEqual(++a1, r1);

            float2x2 a2 = float2x2(210.319885f, -300.1941f);
            float2x2 r2 = float2x2(211.319885f, -299.1941f);
            TestUtils.AreEqual(++a2, r2);

            float2x2 a3 = float2x2(362.212769f, 130.90918f);
            float2x2 r3 = float2x2(363.212769f, 131.90918f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float2x2_operator_postfix_inc()
        {
            float2x2 a0 = float2x2(-396.669739f, 511.20752f);
            float2x2 r0 = float2x2(-396.669739f, 511.20752f);
            TestUtils.AreEqual(a0++, r0);

            float2x2 a1 = float2x2(249.111267f, -259.4903f);
            float2x2 r1 = float2x2(249.111267f, -259.4903f);
            TestUtils.AreEqual(a1++, r1);

            float2x2 a2 = float2x2(278.008179f, 66.71973f);
            float2x2 r2 = float2x2(278.008179f, 66.71973f);
            TestUtils.AreEqual(a2++, r2);

            float2x2 a3 = float2x2(167.852112f, -326.1076f);
            float2x2 r3 = float2x2(167.852112f, -326.1076f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float2x2_operator_prefix_dec()
        {
            float2x2 a0 = float2x2(123.128723f, 256.84375f);
            float2x2 r0 = float2x2(122.128723f, 255.84375f);
            TestUtils.AreEqual(--a0, r0);

            float2x2 a1 = float2x2(156.330811f, 325.867981f);
            float2x2 r1 = float2x2(155.330811f, 324.867981f);
            TestUtils.AreEqual(--a1, r1);

            float2x2 a2 = float2x2(392.015625f, -236.225189f);
            float2x2 r2 = float2x2(391.015625f, -237.225189f);
            TestUtils.AreEqual(--a2, r2);

            float2x2 a3 = float2x2(125.109619f, 45.5366821f);
            float2x2 r3 = float2x2(124.109619f, 44.5366821f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float2x2_operator_postfix_dec()
        {
            float2x2 a0 = float2x2(379.6883f, 302.692871f);
            float2x2 r0 = float2x2(379.6883f, 302.692871f);
            TestUtils.AreEqual(a0--, r0);

            float2x2 a1 = float2x2(-176.07135f, 470.567566f);
            float2x2 r1 = float2x2(-176.07135f, 470.567566f);
            TestUtils.AreEqual(a1--, r1);

            float2x2 a2 = float2x2(-402.925964f, 355.2611f);
            float2x2 r2 = float2x2(-402.925964f, 355.2611f);
            TestUtils.AreEqual(a2--, r2);

            float2x2 a3 = float2x2(-27.8892212f, 156.14032f);
            float2x2 r3 = float2x2(-27.8892212f, 156.14032f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
