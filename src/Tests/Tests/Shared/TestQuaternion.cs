using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestQuaternion
    {
        [TestCompiler]
        public static void quaternion_basic_constructors()
        {
            quaternion q = quaternion(1.0f, 2.0f, 3.0f, 4.0f);
            quaternion q2 = quaternion(float4(1.0f, 2.0f, 3.0f, 4.0f));

            TestUtils.AreEqual(1.0f, q.value.x);
            TestUtils.AreEqual(2.0f, q.value.y);
            TestUtils.AreEqual(3.0f, q.value.z);
            TestUtils.AreEqual(4.0f, q.value.w);
            TestUtils.AreEqual(1.0f, q2.value.x);
            TestUtils.AreEqual(2.0f, q2.value.y);
            TestUtils.AreEqual(3.0f, q2.value.z);
            TestUtils.AreEqual(4.0f, q2.value.w);
        }

        [TestCompiler]
        public static void quaternion_construct_from_matrix()
        {
            TestUtils.AreEqual(float3x3(quaternion(TestMatrix.test3x3_xyz)), TestMatrix.test3x3_xyz, 0.0001f);
            TestUtils.AreEqual(float4x4(quaternion(TestMatrix.test4x4_xyz), float3.zero), TestMatrix.test4x4_xyz, 0.0001f);

            // Make sure to hit all 4 cases
            float3x3 m0 = float3x3.AxisAngle(normalize(float3(1, 2, 3)), 1.0f);
            float3x3 m1 = float3x3.AxisAngle(normalize(float3(3, 2, 1)), 3.0f);
            float3x3 m2 = float3x3.AxisAngle(normalize(float3(1, 3, 2)), 3.0f);
            float3x3 m3 = float3x3.AxisAngle(normalize(float3(1, 2, 3)), 3.0f);
            quaternion q0 = quaternion(m0);
            quaternion q1 = quaternion(m1);
            quaternion q2 = quaternion(m2);
            quaternion q3 = quaternion(m3);
            TestUtils.AreEqual(quaternion(0.1281319f, 0.2562638f, 0.3843956f, 0.8775827f), q0, 0.0001f);
            TestUtils.AreEqual(quaternion(0.7997754f, 0.5331835f, 0.2665918f, 0.0707372f), q1, 0.0001f);
            TestUtils.AreEqual(quaternion(0.2665918f, 0.7997754f, 0.5331835f, 0.0707372f), q2, 0.0001f);
            TestUtils.AreEqual(quaternion(0.2665918f, 0.5331835f, 0.7997754f, 0.0707372f), q3, 0.0001f);
        }


        [TestCompiler]
        public static void quaternion_construct_from_matrix3x3_torture()
        {
            Random rnd = new Random(0x12345678);
            for(int i = 0; i < 1000; i++)
            {
                float3x3 r = float3x3(rnd.NextQuaternionRotation());
                quaternion q = quaternion(r);
                float3x3 t = float3x3(q);
                TestUtils.AreEqual(r, t, 0.001f);
            }
        }

        [TestCompiler]
        public static void quaternion_construct_from_matrix4x4_torture()
        {
            Random rnd = new Random(0x12345678);
            for (int i = 0; i < 1000; i++)
            {
                float4x4 r = float4x4(rnd.NextQuaternionRotation(), float3.zero);
                quaternion q = quaternion(r);
                float4x4 t = float4x4(q, float3.zero);
                TestUtils.AreEqual(r, t, 0.001f);
            }
        }

        [TestCompiler]
        public static void quaternion_axis_angle()
        {
            quaternion q = quaternion.AxisAngle(normalize(float3(1.0f, 2.0f, 3.0f)), 10.0f);

            quaternion r = quaternion(-0.2562833f, -0.5125666f, -0.76885f, 0.2836622f);
            TestUtils.AreEqual(r, q, 0.0001f);
        }

        [TestCompiler]
        public static void quaternion_axis_angle_consistency()
        {
            TestUtils.AreEqual(quaternion.RotateX(1.0f), quaternion.AxisAngle(float3(1, 0, 0), 1.0f), 0.001f);
            TestUtils.AreEqual(quaternion.RotateY(1.0f), quaternion.AxisAngle(float3(0, 1, 0), 1.0f), 0.001f);
            TestUtils.AreEqual(quaternion.RotateZ(1.0f), quaternion.AxisAngle(float3(0, 0, 1), 1.0f), 0.001f);
        }

        [TestCompiler]
        public static void quaternion_euler()
        {
            float3 test_angles = TestMatrix.test_angles;
            quaternion q0 = quaternion.Euler(test_angles);
            quaternion q0_xyz = quaternion.Euler(test_angles, RotationOrder.XYZ);
            quaternion q0_xzy = quaternion.Euler(test_angles, RotationOrder.XZY);
            quaternion q0_yxz = quaternion.Euler(test_angles, RotationOrder.YXZ);
            quaternion q0_yzx = quaternion.Euler(test_angles, RotationOrder.YZX);
            quaternion q0_zxy = quaternion.Euler(test_angles, RotationOrder.ZXY);
            quaternion q0_zyx = quaternion.Euler(test_angles, RotationOrder.ZYX);

            quaternion q1 = quaternion.Euler(test_angles.x, test_angles.y, test_angles.z);
            quaternion q1_xyz = quaternion.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XYZ);
            quaternion q1_xzy = quaternion.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XZY);
            quaternion q1_yxz = quaternion.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YXZ);
            quaternion q1_yzx = quaternion.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YZX);
            quaternion q1_zxy = quaternion.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZXY);
            quaternion q1_zyx = quaternion.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZYX);

            float epsilon = 0.0001f;
            TestUtils.AreEqual(quaternion(-0.3133549f, 0.3435619f, 0.3899215f, 0.7948176f), q0, epsilon);
            TestUtils.AreEqual(quaternion(-0.4597331f, 0.06979711f, 0.3899215f, 0.7948176f), q0_xyz, epsilon);
            TestUtils.AreEqual(quaternion(-0.3133549f, 0.06979711f, 0.3899215f, 0.8630749f), q0_xzy, epsilon);
            TestUtils.AreEqual(quaternion(-0.4597331f, 0.06979711f, 0.1971690f, 0.8630748f), q0_yxz, epsilon);
            TestUtils.AreEqual(quaternion(-0.4597331f, 0.34356190f, 0.1971690f, 0.7948176f), q0_yzx, epsilon);
            TestUtils.AreEqual(quaternion(-0.3133549f, 0.34356190f, 0.3899215f, 0.7948176f), q0_zxy, epsilon);
            TestUtils.AreEqual(quaternion(-0.3133549f, 0.34356190f, 0.1971690f, 0.8630749f), q0_zyx, epsilon);

            TestUtils.AreEqual(quaternion(-0.3133549f, 0.3435619f, 0.3899215f, 0.7948176f), q1, epsilon);
            TestUtils.AreEqual(quaternion(-0.4597331f, 0.06979711f, 0.3899215f, 0.7948176f), q1_xyz, epsilon);
            TestUtils.AreEqual(quaternion(-0.3133549f, 0.06979711f, 0.3899215f, 0.8630749f), q1_xzy, epsilon);
            TestUtils.AreEqual(quaternion(-0.4597331f, 0.06979711f, 0.1971690f, 0.8630748f), q1_yxz, epsilon);
            TestUtils.AreEqual(quaternion(-0.4597331f, 0.34356190f, 0.1971690f, 0.7948176f), q1_yzx, epsilon);
            TestUtils.AreEqual(quaternion(-0.3133549f, 0.34356190f, 0.3899215f, 0.7948176f), q1_zxy, epsilon);
            TestUtils.AreEqual(quaternion(-0.3133549f, 0.34356190f, 0.1971690f, 0.8630749f), q1_zyx, epsilon);

            float3x3 m0 = float3x3(q0);
            float3x3 m0_xyz = float3x3(q0_xyz);
            float3x3 m0_xzy = float3x3(q0_xzy);
            float3x3 m0_yxz = float3x3(q0_yxz);
            float3x3 m0_yzx = float3x3(q0_yzx);
            float3x3 m0_zxy = float3x3(q0_zxy);
            float3x3 m0_zyx = float3x3(q0_zyx);

            float3x3 m1 = float3x3(q1);
            float3x3 m1_xyz = float3x3(q1_xyz);
            float3x3 m1_xzy = float3x3(q1_xzy);
            float3x3 m1_yxz = float3x3(q1_yxz);
            float3x3 m1_yzx = float3x3(q1_yzx);
            float3x3 m1_zxy = float3x3(q1_zxy);
            float3x3 m1_zyx = float3x3(q1_zyx);

            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m0, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xyz, m0_xyz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yzx, m0_yzx, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m0_zxy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xzy, m0_xzy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yxz, m0_yxz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zyx, m0_zyx, 0.0001f);

            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m1, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xyz, m1_xyz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yzx, m1_yzx, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zxy, m1_zxy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_xzy, m1_xzy, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_yxz, m1_yxz, epsilon);
            TestUtils.AreEqual(TestMatrix.test3x3_zyx, m1_zyx, epsilon);
        }

        [TestCompiler]
        public static void quaternion_rotateX()
        {
            float angle = 2.3f;
            quaternion q = quaternion.RotateX(angle);

            quaternion r = quaternion(0.91276394f, 0.0f, 0.0f, 0.40848744f);
            TestUtils.AreEqual(r, q, 0.0001f);
        }

        [TestCompiler]
        public static void quaternion_rotateY()
        {
            float angle = 2.3f;
            quaternion q = quaternion.RotateY(angle);

            quaternion r = quaternion(0.0f, 0.91276394f, 0.0f, 0.40848744f);
            TestUtils.AreEqual(r, q, 0.0001f);
        }

        [TestCompiler]
        public static void quaternion_rotateZ()
        {
            float angle = 2.3f;
            quaternion q = quaternion.RotateZ(angle);

            quaternion r = quaternion(0.0f, 0.0f, 0.91276394f, 0.40848744f);
            TestUtils.AreEqual(r, q, 0.0001f);
        }

        static internal readonly quaternion test_q0 = new quaternion(0.3270836f, 0.8449658f, -0.1090279f, 0.4088545f);
        static internal readonly quaternion test_q1 = new quaternion(-0.05623216f, 0.731018f, -0.6747859f, -0.08434824f);
        static internal readonly quaternion test_q2 = new quaternion(-0.2316205f, -0.6022133f, -0.7411857f, -0.1852964f);
        static internal readonly quaternion test_q3 = new quaternion(0.3619499f, 0.8352691f, -0.1392115f, 0.3897922f);

        [TestCompiler]
        public static void quaternion_conjugate()
        {
            quaternion q = quaternion(1.0f, -2.0f, 3.0f, -4.0f);
            quaternion cq = conjugate(q);
            quaternion r = quaternion(-1.0f, 2.0f, -3.0f, -4.0f);

            TestUtils.AreEqual(r, cq);
        }

        [TestCompiler]
        public static void quaternion_inverse()
        {
            quaternion q = quaternion(1.0f, -2.0f, 3.0f, -4.0f);
            quaternion iq = inverse(q);
            quaternion qiq = mul(iq, q);

            TestUtils.AreEqual(quaternion.identity, qiq, 0.00001f);
        }

        [TestCompiler]
        public static void quaternion_dot()
        {
            float dot01 = dot(test_q0, test_q1);
            float dot02 = dot(test_q0, test_q2);

            TestUtils.AreEqual(0.6383769f, dot01, 0.00001f);
            TestUtils.AreEqual(-0.5795583f, dot02, 0.00001f);
        }

        [TestCompiler]
        public static void quaternion_nlerp()
        {
            quaternion r0 = nlerp(test_q0, test_q1, 0.3f);
            quaternion r1 = nlerp(test_q0, test_q1, -4.3f);
            quaternion r2 = nlerp(test_q0, test_q1, 5.1f);

            TestUtils.AreEqual(quaternion(0.2302977f, 0.8803911f, -0.3026878f, 0.2832927f), r0, 0.0001f);
            TestUtils.AreEqual(quaternion(0.4724294f, 0.3192692f, 0.5557517f, 0.604994f), r1, 0.0001f);
            TestUtils.AreEqual(quaternion(-0.4054004f, 0.06570576f, -0.7457358f, -0.5246059f), r2, 0.0001f);
        }

        [TestCompiler]
        public static void quaternion_slerp()
        {
            quaternion r0 = slerp(test_q0, test_q1, 0.3f);
            quaternion r1 = slerp(test_q0, test_q1, -4.3f);
            quaternion r2 = slerp(test_q0, test_q1, 5.1f);

            TestUtils.AreEqual(quaternion(0.2261014f, 0.8806396f, -0.3100654f, 0.2778693f), r0, 0.0001f);
            TestUtils.AreEqual(quaternion(-0.4676181f, -0.5321988f, -0.3789966f, -0.5953646f), r1, 0.0001f);
            TestUtils.AreEqual(quaternion(0.2596942f, -0.4369303f, 0.7902023f, 0.34239f), r2, 0.0001f);
        }

        [TestCompiler]
        public static void quaternion_mul_vector()
        {
            float3x3 m = TestMatrix.test3x3_xyz;
            quaternion q = quaternion(m);

            float3 vector = float3(1.1f, -2.2f, 3.5f);

            float3 mvector = mul(m, vector);
            float3 qvector = mul(q, vector);

            TestUtils.AreEqual(mvector, qvector, 0.0001f);
        }

        [TestCompiler]
        public static void quaternion_log_exp_identity()
        {
            quaternion q = quaternion(1.2f, -2.6f, 3.1f, 6.0f);
            quaternion log_q = log(q);
            quaternion exp_log_q = exp(log_q);
            TestUtils.AreEqual(q, exp_log_q, 0.0001f);
        }

        [TestCompiler]
        public static void quaternion_log_exp_rotation()
        {
            quaternion q = quaternion(TestMatrix.test3x3_xyz);
            quaternion q3 = mul(q, mul(q, q));
            quaternion log_q = log(q);
            quaternion t = exp(quaternion(log_q.value * 3.0f));
            TestUtils.AreEqual(q3, t, 0.0001f);
        }

        [TestCompiler]
        public static void quaternion_unitlog_unitexp_rotation()
        {
            quaternion q = quaternion(TestMatrix.test3x3_xyz);
            quaternion q3 = mul(q, mul(q, q));
            quaternion log_q = unitlog(q);
            quaternion t = unitexp(quaternion(log_q.value * 3.0f));
            TestUtils.AreEqual(q3, t, 0.0001f);
        }

        [TestCompiler]
        public static void quaternion_look_rotation()
        {
            // Exercise the 4 cases
            float3 forward0 = normalize(float3(1.0f, 2.0f, 3.0f));
            float3 up0 = float3(0.0f, 1.0f, 0.0f);
            quaternion q0 = quaternion.LookRotation(forward0, up0);
            TestUtils.AreEqual(quaternion(-0.274657f, 0.153857f, 0.044571f, 0.948106f), q0, 0.001f);
            TestUtils.AreEqual(float3x3.LookRotation(forward0, up0), float3x3(q0), 0.001f);

            float3 forward1 = normalize(float3(-3.2f, 2.3f, -1.3f));
            float3 up1 = normalize(float3(1.0f, -3.2f, -1.5f));
            quaternion q1 = quaternion.LookRotation(forward1, up1);
            TestUtils.AreEqual(quaternion(0.805418f, 0.089103f, -0.435327f, -0.392240f), q1, 0.001f);
            TestUtils.AreEqual(float3x3.LookRotation(forward1, up1), float3x3(q1), 0.001f);

            float3 forward2 = normalize(float3(-2.6f, -5.2f, -1.1f));
            float3 up2 = normalize(float3(-4.2f, -1.2f, -4.5f));
            quaternion q2 = quaternion.LookRotation(forward2, up2);
            TestUtils.AreEqual(quaternion(-0.088343f, 0.764951f, -0.534144f, -0.348907f), q2, 0.001f);
            TestUtils.AreEqual(float3x3.LookRotation(forward2, up2), float3x3(q2), 0.001f);

            float3 forward3 = normalize(float3(1.3f, 2.1f, 3.4f));
            float3 up3 = normalize(float3(0.2f, -1.0f, 0.3f));
            quaternion q3 = quaternion.LookRotation(forward3, up3);
            TestUtils.AreEqual(quaternion(0.184984f, 0.247484f, 0.947425f, -0.083173f), q3, 0.001f);
            TestUtils.AreEqual(float3x3.LookRotation(forward3, up3), float3x3(q3), 0.001f);
        }

        [TestCompiler]
        public static void quaternion_look_rotation_safe()
        {
            float3 forward0 = float3(-3.2f, 2.3f, -1.3f) * 1e-10f;
            float3 up0 = float3(1.0f, -3.2f, -1.5f) * 1e10f;
            quaternion q0 = quaternion.LookRotationSafe(forward0, up0);
            TestUtils.AreEqual(quaternion(0.805418f, 0.089103f, -0.435327f, -0.392240f), q0, 0.001f);

            float3 forward1 = float3(-3.2f, 2.3f, -1.3f) * 1e-30f;
            float3 up1 = float3(1.0f, -3.2f, -1.5f);
            quaternion q1 = quaternion.LookRotationSafe(forward1, up1);
            TestUtils.AreEqual(quaternion.identity, q1, 0.001f);

            float3 forward2 = float3(-3.2f, 2.3f, -1.3f);
            float3 up2 = forward2;
            quaternion q2 = quaternion.LookRotationSafe(forward2, up2);
            TestUtils.AreEqual(quaternion.identity, q2, 0.001f);
        }

        [TestCase]
        public static void quaternion_EqualsObjectOverride()
        {
            TestUtils.IsFalse(new quaternion().Equals((object) new int()));
            TestUtils.IsTrue(new quaternion().Equals((object) new quaternion()));
        }
    }
}
