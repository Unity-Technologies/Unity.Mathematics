using Burst.Compiler.IL.Tests;
using NUnit.Framework;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public partial class TestFloat3
    {
        [TestCompiler]
        unsafe public static void quaternion_to_euler()
        {
            const float epsilon = 0.0045f;
            const float PI_div_6 = PI / 6f;
            const int testAngleCount = 13 * 13 * 13 * 20;

            float3* testAngles = stackalloc float3[testAngleCount];

            int idx = 0;
            for (int i = 0; i < 13; ++i)
            {
                float x = -PI + i * PI;
                for (int j = 0; j < 13; ++j)
                {
                    float y = -PI + j * PI_div_6;
                    for (int k = 0; k < 13; ++k)
                    {
                        float z = -PI + k * PI_div_6;
                        for (int l = 0; l < 20; ++l)
                        {
                            testAngles[idx++] = float3(x, y, z) * (0.99f + l * 0.001f);
                        }
                    }
                }
            }

            for (int order = 0; order < 6; ++order)
            {
                for (int i = 0; i < testAngleCount; ++i)
                {
                    // We cannot directly compare Euler angles, as different angles may represent the same rotation,
                    // so we have to transform them back to quats to test.
                    // We also need to create our initial test quaternion, as what we generated was euler angles.
                    quaternion expected = TestRefEulerToQuat(testAngles[i], math.RotationOrder.Default);

                    float3 actualEulers = float3.Euler(expected, (math.RotationOrder)order);
                    quaternion actualQuat = TestRefEulerToQuat(actualEulers, (math.RotationOrder)order);

                    float error = angle(expected, actualQuat);
                    TestUtils.AreEqual(0f, error, epsilon);
                }
            }
        }

        static quaternion TestRefEulerToQuat(float3 angle, math.RotationOrder order)
        {
            float3 halfRot = angle * 0.5f;
            sincos(halfRot, out float3 s, out float3 c);

            quaternion qX = quaternion(s.x, 0f, 0f, c.x);
            quaternion qY = quaternion(0f, s.y, 0f, c.y);
            quaternion qZ = quaternion(0f, 0f, s.z, c.z);

            switch (order)
            {
                case math.RotationOrder.XYZ:
                    return mul(mul(qZ, qY), qX);
                case math.RotationOrder.XZY:
                    return mul(mul(qY, qZ), qX);
                case math.RotationOrder.YXZ:
                    return mul(mul(qZ, qX), qY);
                case math.RotationOrder.YZX:
                    return mul(mul(qX, qZ), qY);
                case math.RotationOrder.ZXY:
                    return mul(mul(qY, qX), qZ);
                case math.RotationOrder.ZYX:
                    return mul(mul(qX, qY), qZ);
                default:
                    return quaternion(float4(1f));
            }
        }
    }
}