using NUnit.Framework;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestQuaternion
    {
        [Test]
        public void quaternion_basic_constructors()
        {
            Quaternion q = Quaternion(1.0f, 2.0f, 3.0f, 4.0f);
            Quaternion q2 = Quaternion(float4(1.0f, 2.0f, 3.0f, 4.0f));

            Assert.AreEqual(q.value.x, 1.0f);
            Assert.AreEqual(q.value.y, 2.0f);
            Assert.AreEqual(q.value.z, 3.0f);
            Assert.AreEqual(q.value.w, 4.0f);
            Assert.AreEqual(q2.value.x, 1.0f);
            Assert.AreEqual(q2.value.y, 2.0f);
            Assert.AreEqual(q2.value.z, 3.0f);
            Assert.AreEqual(q2.value.w, 4.0f);
        }

        [Test]
        public void quaternion_construct_from_matrix()
        {
            float3x3 m3x3 = TestMatrix.test3x3_xyz;
            float4x4 m4x4 = TestMatrix.test4x4_zyx;

            Quaternion q3x3 = Quaternion(m3x3);
            Quaternion q4x4 = Quaternion(m4x4);

            float3x3 mq3x3 = float3x3(q3x3);
            float4x4 mq4x4 = float4x4(q4x4, float3(0.0f));

            TestUtils.AreEqual(mq3x3, m3x3, 0.0001f);
            TestUtils.AreEqual(mq4x4, m4x4, 0.0001f);
        }

        [Test]
        public void quaternion_axisAngle()
        {
            Quaternion q = Quaternion.axisAngle(normalize(float3(1.0f, 2.0f, 3.0f)), 10.0f);

            Quaternion r = Quaternion(-0.2562833f, -0.5125666f, -0.76885f, 0.2836622f);
            TestUtils.AreEqual(q, r, 0.0001f);
        }

        [Test]
        public void quaternion_euler()
        {
            float3 test_angles = TestMatrix.test_angles;
            Quaternion q0 = Quaternion.euler(test_angles);
            Quaternion q0_xyz = Quaternion.euler(test_angles, RotationOrder.XYZ);
            Quaternion q0_xzy = Quaternion.euler(test_angles, RotationOrder.XZY);
            Quaternion q0_yxz = Quaternion.euler(test_angles, RotationOrder.YXZ);
            Quaternion q0_yzx = Quaternion.euler(test_angles, RotationOrder.YZX);
            Quaternion q0_zxy = Quaternion.euler(test_angles, RotationOrder.ZXY);
            Quaternion q0_zyx = Quaternion.euler(test_angles, RotationOrder.ZYX);

            Quaternion q1 = Quaternion.euler(test_angles.x, test_angles.y, test_angles.z);
            Quaternion q1_xyz = Quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XYZ);
            Quaternion q1_xzy = Quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XZY);
            Quaternion q1_yxz = Quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YXZ);
            Quaternion q1_yzx = Quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YZX);
            Quaternion q1_zxy = Quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZXY);
            Quaternion q1_zyx = Quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZYX);

            float epsilon = 0.0001f;
            TestUtils.AreEqual(q0, Quaternion(-0.3133549f, 0.3435619f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q0_xyz, Quaternion(-0.4597331f, 0.06979711f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q0_xzy, Quaternion(-0.3133549f, 0.06979711f, 0.3899215f, 0.8630749f), epsilon);
            TestUtils.AreEqual(q0_yxz, Quaternion(-0.4597331f, 0.06979711f, 0.1971690f, 0.8630748f), epsilon);
            TestUtils.AreEqual(q0_yzx, Quaternion(-0.4597331f, 0.34356190f, 0.1971690f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q0_zxy, Quaternion(-0.3133549f, 0.34356190f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q0_zyx, Quaternion(-0.3133549f, 0.34356190f, 0.1971690f, 0.8630749f), epsilon);

            TestUtils.AreEqual(q1, Quaternion(-0.3133549f, 0.3435619f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q1_xyz, Quaternion(-0.4597331f, 0.06979711f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q1_xzy, Quaternion(-0.3133549f, 0.06979711f, 0.3899215f, 0.8630749f), epsilon);
            TestUtils.AreEqual(q1_yxz, Quaternion(-0.4597331f, 0.06979711f, 0.1971690f, 0.8630748f), epsilon);
            TestUtils.AreEqual(q1_yzx, Quaternion(-0.4597331f, 0.34356190f, 0.1971690f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q1_zxy, Quaternion(-0.3133549f, 0.34356190f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q1_zyx, Quaternion(-0.3133549f, 0.34356190f, 0.1971690f, 0.8630749f), epsilon);

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

            TestUtils.AreEqual(m0, TestMatrix.test3x3_zxy, epsilon);
            TestUtils.AreEqual(m0_xyz, TestMatrix.test3x3_xyz, epsilon);
            TestUtils.AreEqual(m0_yzx, TestMatrix.test3x3_yzx, epsilon);
            TestUtils.AreEqual(m0_zxy, TestMatrix.test3x3_zxy, epsilon);
            TestUtils.AreEqual(m0_xzy, TestMatrix.test3x3_xzy, epsilon);
            TestUtils.AreEqual(m0_yxz, TestMatrix.test3x3_yxz, epsilon);
            TestUtils.AreEqual(m0_zyx, TestMatrix.test3x3_zyx, 0.0001f);

            TestUtils.AreEqual(m1, TestMatrix.test3x3_zxy, epsilon);
            TestUtils.AreEqual(m1_xyz, TestMatrix.test3x3_xyz, epsilon);
            TestUtils.AreEqual(m1_yzx, TestMatrix.test3x3_yzx, epsilon);
            TestUtils.AreEqual(m1_zxy, TestMatrix.test3x3_zxy, epsilon);
            TestUtils.AreEqual(m1_xzy, TestMatrix.test3x3_xzy, epsilon);
            TestUtils.AreEqual(m1_yxz, TestMatrix.test3x3_yxz, epsilon);
            TestUtils.AreEqual(m1_zyx, TestMatrix.test3x3_zyx, epsilon);
        }

        [Test]
        public void quaternion_rotateX()
        {
            float angle = 2.3f;
            Quaternion q = Quaternion.rotateX(angle);

            Quaternion r = Quaternion(0.91276394f, 0.0f, 0.0f, 0.40848744f);
            TestUtils.AreEqual(q, r, 0.0001f);
        }

        [Test]
        public void quaternion_rotateY()
        {
            float angle = 2.3f;
            Quaternion q = Quaternion.rotateY(angle);

            Quaternion r = Quaternion(0.0f, 0.91276394f, 0.0f, 0.40848744f);
            TestUtils.AreEqual(q, r, 0.0001f);
        }

        [Test]
        public void quaternion_rotateZ()
        {
            float angle = 2.3f;
            Quaternion q = Quaternion.rotateZ(angle);

            Quaternion r = Quaternion(0.0f, 0.0f, 0.91276394f, 0.40848744f);
            TestUtils.AreEqual(q, r, 0.0001f);
        }

        static internal Quaternion test_q0 = Quaternion(0.3270836f, 0.8449658f, -0.1090279f, 0.4088545f);
        static internal Quaternion test_q1 = Quaternion(-0.05623216f, 0.731018f, -0.6747859f, -0.08434824f);
        static internal Quaternion test_q2 = Quaternion(-0.2316205f, -0.6022133f, -0.7411857f, -0.1852964f);
        static internal Quaternion test_q3 = Quaternion(0.3619499f, 0.8352691f, -0.1392115f, 0.3897922f);

        [Test]
        public void quaternion_conjugate()
        {
            Quaternion q = Quaternion(1.0f, -2.0f, 3.0f, -4.0f);
            Quaternion cq = conjugate(q);
            Quaternion r = Quaternion(-1.0f, 2.0f, -3.0f, -4.0f);

            TestUtils.AreEqual(cq, r);
        }

        [Test]
        public void quaternion_inverse()
        {
            Quaternion q = Quaternion(1.0f, -2.0f, 3.0f, -4.0f);
            Quaternion iq = inverse(q);
            Quaternion r = Quaternion(-0.1825742f, 0.3651484f, -0.5477226f, -0.7302967f);

            TestUtils.AreEqual(iq, r, 0.00001f);
        }

        [Test]
        public void quaternion_dot()
        {
            float dot01 = dot(test_q0, test_q1);
            float dot02 = dot(test_q0, test_q2);

            Assert.AreEqual(dot01,  0.6383769f, 0.00001f);
            Assert.AreEqual(dot02, -0.5795583f, 0.00001f);
        }

        [Test]
        public void quaternion_nlerp()
        {
            Quaternion r0 = nlerp(test_q0, test_q1, 0.3f);
            Quaternion r1 = nlerp(test_q0, test_q1, -4.3f);
            Quaternion r2 = nlerp(test_q0, test_q1, 5.1f);

            TestUtils.AreEqual(r0, Quaternion(0.2302977f, 0.8803911f, -0.3026878f, 0.2832927f), 0.0001f);
            TestUtils.AreEqual(r1, Quaternion(0.4724294f, 0.3192692f, 0.5557517f, 0.604994f), 0.0001f);
            TestUtils.AreEqual(r2, Quaternion(-0.4054004f, 0.06570576f, -0.7457358f, -0.5246059f), 0.0001f);
        }

        [Test]
        public void quaternion_slerp()
        {
            Quaternion r0 = slerp(test_q0, test_q1, 0.3f);
            Quaternion r1 = slerp(test_q0, test_q1, -4.3f);
            Quaternion r2 = slerp(test_q0, test_q1, 5.1f);

            TestUtils.AreEqual(r0, Quaternion(0.2261014f, 0.8806396f, -0.3100654f, 0.2778693f), 0.0001f);
            TestUtils.AreEqual(r1, Quaternion(-0.4676181f, -0.5321988f, -0.3789966f, -0.5953646f), 0.0001f);
            TestUtils.AreEqual(r2, Quaternion(0.2596942f, -0.4369303f, 0.7902023f, 0.34239f), 0.0001f);
        }

        [Test]
        public void quaternion_mul_vector()
        {
            float3x3 m = TestMatrix.test3x3_xyz;
            Quaternion q = Quaternion(m);

            float3 vector = float3(1.1f, -2.2f, 3.5f);

            float3 mvector = mul(m, vector);
            float3 qvector = mul(q, vector);

            TestUtils.AreEqual(qvector, mvector, 0.0001f);
        }
    }
}
