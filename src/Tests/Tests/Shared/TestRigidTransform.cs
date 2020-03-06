using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestRigidTransform
    {
        [TestCompiler]
        public static void rigid_transform_construct_from_matrix()
        {
            float4x4 m4x4 = TestMatrix.test4x4_zyx;

            RigidTransform q4x4 = RigidTransform(m4x4);

            float4x4 mq4x4 = float4x4(q4x4);

            TestUtils.AreEqual(m4x4, mq4x4, 0.0001f);
        }

        [TestCompiler]
        public static void rigid_transform_axisAngle()
        {
            RigidTransform q = RigidTransform.AxisAngle(normalize(float3(1.0f, 2.0f, 3.0f)), 10.0f);

            RigidTransform r = RigidTransform(quaternion(-0.2562833f, -0.5125666f, -0.76885f, 0.2836622f), float3.zero);
            TestUtils.AreEqual(r, q, 0.0001f);
        }

        [TestCompiler]
        public static void rigid_transform_euler()
        {
            float3 test_angles = TestMatrix.test_angles;
            RigidTransform q0 = RigidTransform.Euler(test_angles);
            RigidTransform q0_xyz = RigidTransform.Euler(test_angles, RotationOrder.XYZ);
            RigidTransform q0_xzy = RigidTransform.Euler(test_angles, RotationOrder.XZY);
            RigidTransform q0_yxz = RigidTransform.Euler(test_angles, RotationOrder.YXZ);
            RigidTransform q0_yzx = RigidTransform.Euler(test_angles, RotationOrder.YZX);
            RigidTransform q0_zxy = RigidTransform.Euler(test_angles, RotationOrder.ZXY);
            RigidTransform q0_zyx = RigidTransform.Euler(test_angles, RotationOrder.ZYX);

            RigidTransform q1 = RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z);
            RigidTransform q1_xyz = RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XYZ);
            RigidTransform q1_xzy = RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XZY);
            RigidTransform q1_yxz = RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YXZ);
            RigidTransform q1_yzx = RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YZX);
            RigidTransform q1_zxy = RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZXY);
            RigidTransform q1_zyx = RigidTransform.Euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZYX);

            float epsilon = 0.0001f;
            TestUtils.AreEqual(RigidTransform(quaternion(-0.3133549f, 0.3435619f, 0.3899215f, 0.7948176f), float3.zero), q0, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.4597331f, 0.06979711f, 0.3899215f, 0.7948176f), float3.zero), q0_xyz, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.3133549f, 0.06979711f, 0.3899215f, 0.8630749f), float3.zero), q0_xzy, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.4597331f, 0.06979711f, 0.1971690f, 0.8630748f), float3.zero), q0_yxz, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.4597331f, 0.34356190f, 0.1971690f, 0.7948176f), float3.zero), q0_yzx, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.3133549f, 0.34356190f, 0.3899215f, 0.7948176f), float3.zero), q0_zxy, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.3133549f, 0.34356190f, 0.1971690f, 0.8630749f), float3.zero), q0_zyx, epsilon);

            TestUtils.AreEqual(RigidTransform(quaternion(-0.3133549f, 0.3435619f, 0.3899215f, 0.7948176f), float3.zero), q1, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.4597331f, 0.06979711f, 0.3899215f, 0.7948176f), float3.zero), q1_xyz, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.3133549f, 0.06979711f, 0.3899215f, 0.8630749f), float3.zero), q1_xzy, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.4597331f, 0.06979711f, 0.1971690f, 0.8630748f), float3.zero), q1_yxz, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.4597331f, 0.34356190f, 0.1971690f, 0.7948176f), float3.zero), q1_yzx, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.3133549f, 0.34356190f, 0.3899215f, 0.7948176f), float3.zero), q1_zxy, epsilon);
            TestUtils.AreEqual(RigidTransform(quaternion(-0.3133549f, 0.34356190f, 0.1971690f, 0.8630749f), float3.zero), q1_zyx, epsilon);

            float3x3 m0 = float3x3(q0.rot);
            float3x3 m0_xyz = float3x3(q0_xyz.rot);
            float3x3 m0_xzy = float3x3(q0_xzy.rot);
            float3x3 m0_yxz = float3x3(q0_yxz.rot);
            float3x3 m0_yzx = float3x3(q0_yzx.rot);
            float3x3 m0_zxy = float3x3(q0_zxy.rot);
            float3x3 m0_zyx = float3x3(q0_zyx.rot);

            float3x3 m1 = float3x3(q1.rot);
            float3x3 m1_xyz = float3x3(q1_xyz.rot);
            float3x3 m1_xzy = float3x3(q1_xzy.rot);
            float3x3 m1_yxz = float3x3(q1_yxz.rot);
            float3x3 m1_yzx = float3x3(q1_yzx.rot);
            float3x3 m1_zxy = float3x3(q1_zxy.rot);
            float3x3 m1_zyx = float3x3(q1_zyx.rot);

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
        public static void rigid_transform_rotateX()
        {
            float angle = 2.3f;
            RigidTransform q = RigidTransform.RotateX(angle);

            RigidTransform r = RigidTransform(quaternion(0.91276394f, 0.0f, 0.0f, 0.40848744f), float3.zero);
            TestUtils.AreEqual(r, q, 0.0001f);
        }

        [TestCompiler]
        public static void rigid_transform_rotateY()
        {
            float angle = 2.3f;
            RigidTransform q = RigidTransform.RotateY(angle);

            RigidTransform r = RigidTransform(quaternion(0.0f, 0.91276394f, 0.0f, 0.40848744f), float3.zero);
            TestUtils.AreEqual(r, q, 0.0001f);
        }

        [TestCompiler]
        public static void rigid_transform_rotateZ()
        {
            float angle = 2.3f;
            RigidTransform q = RigidTransform.RotateZ(angle);

            RigidTransform r = RigidTransform(quaternion(0.0f, 0.0f, 0.91276394f, 0.40848744f), float3.zero);
            TestUtils.AreEqual(r, q, 0.0001f);
        }

        static internal readonly quaternion test_q0 = new quaternion(0.3270836f, 0.8449658f, -0.1090279f, 0.4088545f);
        static internal readonly quaternion test_q1 = new quaternion(-0.05623216f, 0.731018f, -0.6747859f, -0.08434824f);
        static internal readonly quaternion test_q2 = new quaternion(-0.2316205f, -0.6022133f, -0.7411857f, -0.1852964f);
        static internal readonly quaternion test_q3 = new quaternion(0.3619499f, 0.8352691f, -0.1392115f, 0.3897922f);

        [TestCompiler]
        public static void rigid_transform_inverse()
        {
            RigidTransform q = RigidTransform(quaternion(1.0f, -2.0f, 3.0f, -4.0f), float3(1,2,3));
            RigidTransform iq = inverse(q);
            RigidTransform qiq = mul(iq, q);

            TestUtils.AreEqual(RigidTransform.identity, qiq, 0.00001f);
        }

        [TestCompiler]
        public static void rigid_transform_mul_vector()
        {
            float4x4 m = TestMatrix.test4x4_xyz;
            RigidTransform q = RigidTransform(m);

            float3 vector = float3(1.1f, -2.2f, 3.5f);

            float4 mvector0 = mul(m, float4(vector, 0));
            float4 qvector0 = mul(q, float4(vector, 0));
            TestUtils.AreEqual(mvector0, qvector0, 0.0001f);

            float4 mvector1 = mul(m, float4(vector, 1));
            float4 qvector1 = mul(q, float4(vector, 1));
            TestUtils.AreEqual(mvector1, qvector1, 0.0001f);
        }
    }
}
