using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using  Unity.Mathematics;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestEuler
    {
        private const int testAngleCount = 13 * 13 * 13 * 20;
        private readonly float3[] testAngles = new float3[testAngleCount];

        void GenerateAllTheTestAngles(ref float3[] testAngles)
        {
            var idx = 0;
            for (var i = 0; i < 13; i++)
            {
                var x = -math.pi + i * math.pi_over_six;
                for (var j = 0; j < 13; j++)
                {
                    var y = -math.pi + j * math.pi_over_six;
                    for (var k = 0; k < 13; k++)
                    {
                        var z = -math.pi + k * math.pi_over_six;
                        for (var l = 0; l < 20; ++l)
                        {
                            testAngles[idx++] = new float3(x, y, z) * (0.99f + l * 0.001f);
                        }
                    }
                }
            }
        }

        public TestEuler()
        {
            GenerateAllTheTestAngles(ref testAngles);
        }

        quaternion testRefEulerToQuat(float3 angle, math.EulerOrder order)
        {
            var halfRot = angle * 0.5f;
            var s = math.sin(halfRot);
            var c = math.cos(halfRot);

            var qX = new quaternion(s.x, 0.0f, 0.0f, c.x);
            var qY = new quaternion(0.0f, s.y, 0.0f, c.y);
            var qZ = new quaternion(0.0f, 0.0f, s.z, c.z);

            switch (order)
            {
                case math.EulerOrder.XYZ: return math.mul(math.mul(qZ, qY), qX);
                case math.EulerOrder.XZY: return math.mul(math.mul(qY, qZ), qX);
                case math.EulerOrder.YZX: return math.mul(math.mul(qX, qZ), qY);
                case math.EulerOrder.YXZ: return math.mul(math.mul(qZ, qX), qY);
                case math.EulerOrder.ZXY: return math.mul(math.mul(qY, qX), qZ);
                case math.EulerOrder.ZYX: return math.mul(math.mul(qX, qY), qZ);
                default: return math.mul(math.mul(qZ, qY), qX);
            }
        }

        [Test]
        public void eulerToQuat_GivesSameResultAs_EquivalentQuatMultiply(
            [Values(math.EulerOrder.XYZ, math.EulerOrder.XZY, math.EulerOrder.YZX, math.EulerOrder.YXZ, math.EulerOrder.ZXY, math.EulerOrder.ZYX)]
            math.EulerOrder order)
        {
            for (var i = 0; i < testAngleCount; ++i)
            {
                var expected = testRefEulerToQuat(testAngles[i], order);
                var actual = math.eulerToQuat(testAngles[i], order);

                expected = math.normalize(expected);
                actual = math.normalize(actual);
                actual = math.align(actual, expected);
                Assert.Less(math.distance(actual.value, expected.value), 1e-6f);
            }
        }

        [Test]
        public void quatToEuler_GivesResultThatConvertsToConsistentQuat(
            [Values(math.EulerOrder.XYZ, math.EulerOrder.XZY, math.EulerOrder.YZX, math.EulerOrder.YXZ, math.EulerOrder.ZXY, math.EulerOrder.ZYX)]
                math.EulerOrder order)
        {
            for (var i = 0; i < testAngleCount; ++i)
            {
                var actualQuat = testRefEulerToQuat(testAngles[i], order);
                var euler = math.quatToEuler(actualQuat, order);

                var eulerReordered = math.eulerReorder(math.degrees(testAngles[i]), order);

                if (math.abs(eulerReordered.y) < 89.9f || math.abs(eulerReordered.y) > 90.1f)
                {
                    euler = math.closestEuler(euler, testAngles[i], order);
                    Assert.Less(math.distance(euler, testAngles[i]), math.pi / 18000.0f,
                        math.degrees(euler).ToString() + math.degrees(testAngles[i]).ToString());
                }
                else // gimbal lock
                {
                    var quat = testRefEulerToQuat(euler, order);

                    actualQuat = math.normalize(actualQuat);
                    quat = math.normalize(quat);
                    quat = math.align(quat, actualQuat);                  
                    Assert.Less(math.distance(quat.value, actualQuat.value), 2e-3f);
                }
            }
        }
    }
}