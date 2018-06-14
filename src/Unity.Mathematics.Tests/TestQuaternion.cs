using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestQuaternion
    {
        [Test]
        public void quaternion_constructor()
        {
            quaternion q = quaternion(1.0f, 2.0f, 3.0f, 4.0f);

            Assert.AreEqual(q.value.x, 1.0f);
            Assert.AreEqual(q.value.y, 2.0f);
            Assert.AreEqual(q.value.z, 3.0f);
            Assert.AreEqual(q.value.w, 4.0f);
        }

        [Test]
        public void quaternion_axisAngle()
        {
            quaternion q = quaternion.axisAngle(normalize(float3(1.0f, 2.0f, 3.0f)), 10.0f);

            quaternion r = quaternion(-0.2562833f, -0.5125666f, -0.76885f, 0.2836622f);
            TestUtils.AreEqual(q, r, 0.0001f);
        }

        [Test]
        public void quaternion_euler()
        {
            float3 test_angles = TestMatrix.test_angles;
            quaternion q0 = quaternion.euler(test_angles);
            quaternion q0_xyz = quaternion.euler(test_angles, RotationOrder.XYZ);
            quaternion q0_xzy = quaternion.euler(test_angles, RotationOrder.XZY);
            quaternion q0_yxz = quaternion.euler(test_angles, RotationOrder.YXZ);
            quaternion q0_yzx = quaternion.euler(test_angles, RotationOrder.YZX);
            quaternion q0_zxy = quaternion.euler(test_angles, RotationOrder.ZXY);
            quaternion q0_zyx = quaternion.euler(test_angles, RotationOrder.ZYX);

            quaternion q1 = quaternion.euler(test_angles.x, test_angles.y, test_angles.z);
            quaternion q1_xyz = quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XYZ);
            quaternion q1_xzy = quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XZY);
            quaternion q1_yxz = quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YXZ);
            quaternion q1_yzx = quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YZX);
            quaternion q1_zxy = quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZXY);
            quaternion q1_zyx = quaternion.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZYX);

            float epsilon = 0.0001f;
            TestUtils.AreEqual(q0, quaternion(-0.3133549f, 0.3435619f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q0_xyz, quaternion(-0.4597331f, 0.06979711f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q0_xzy, quaternion(-0.3133549f, 0.06979711f, 0.3899215f, 0.8630749f), epsilon);
            TestUtils.AreEqual(q0_yxz, quaternion(-0.4597331f, 0.06979711f, 0.1971690f, 0.8630748f), epsilon);
            TestUtils.AreEqual(q0_yzx, quaternion(-0.4597331f, 0.34356190f, 0.1971690f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q0_zxy, quaternion(-0.3133549f, 0.34356190f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q0_zyx, quaternion(-0.3133549f, 0.34356190f, 0.1971690f, 0.8630749f), epsilon);

            TestUtils.AreEqual(q1, quaternion(-0.3133549f, 0.3435619f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q1_xyz, quaternion(-0.4597331f, 0.06979711f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q1_xzy, quaternion(-0.3133549f, 0.06979711f, 0.3899215f, 0.8630749f), epsilon);
            TestUtils.AreEqual(q1_yxz, quaternion(-0.4597331f, 0.06979711f, 0.1971690f, 0.8630748f), epsilon);
            TestUtils.AreEqual(q1_yzx, quaternion(-0.4597331f, 0.34356190f, 0.1971690f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q1_zxy, quaternion(-0.3133549f, 0.34356190f, 0.3899215f, 0.7948176f), epsilon);
            TestUtils.AreEqual(q1_zyx, quaternion(-0.3133549f, 0.34356190f, 0.1971690f, 0.8630749f), epsilon);

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
            quaternion q = quaternion.rotateX(angle);

            quaternion r = quaternion(0.91276394f, 0.0f, 0.0f, 0.40848744f);
            TestUtils.AreEqual(q, r, 0.0001f);
        }

        [Test]
        public void quaternion_rotateY()
        {
            float angle = 2.3f;
            quaternion q = quaternion.rotateY(angle);

            quaternion r = quaternion(0.0f, 0.91276394f, 0.0f, 0.40848744f);
            TestUtils.AreEqual(q, r, 0.0001f);
        }

        [Test]
        public void quaternion_rotateZ()
        {
            float angle = 2.3f;
            quaternion q = quaternion.rotateZ(angle);

            quaternion r = quaternion(0.0f, 0.0f, 0.91276394f, 0.40848744f);
            TestUtils.AreEqual(q, r, 0.0001f);
        }
    }
}
