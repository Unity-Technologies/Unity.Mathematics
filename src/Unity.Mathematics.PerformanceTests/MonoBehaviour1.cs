using System;
using NUnit.Framework;
using Unity.PerformanceTesting;

namespace Unity.Mathematics.PerformanceTests
{
    public class TestMul
    {
        [Test, Performance]
        public void Float4x4_Float4()
        {
            var f4 = new float4(1.0f);
            var f4x4 = float4x4.identity;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        f4 = math.mul(f4x4, f4);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Float3x3_Float3()
        {
            var f3 = new float3(1.0f);
            var f3x3 = float3x3.identity;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        f3 = math.mul(f3x3, f3);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Quaternion_Quaternion()
        {
            var q1 = quaternion.identity;
            var q2 = quaternion.identity;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        q1 = math.mul(q1, q2);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Float4x4_Float4x4()
        {
            var m1 = float4x4.identity;
            var m2 = float4x4.identity;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        m1 = math.mul(m1, m2);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }
    }

    public class Conversions
    {
        [Test, Performance]
        public void QuaternionToFloat3x3()
        {
            var q1 = quaternion.identity;
            var f3x3 = new float3x3();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        f3x3 = new float3x3(q1);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void QuaternionToRigidTransform()
        {
            var q1 = quaternion.identity;
            var r = RigidTransform.identity;
            var position = new float3();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        r = new RigidTransform(q1, position);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Float3x3ToQuaternion()
        {
            var q1 = new quaternion();
            var f3x3 = float3x3.identity;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        q1 = new quaternion(f3x3);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Float4x4ToQuaternion()
        {
            var q1 = new quaternion();
            var f4x4 = float4x4.identity;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        q1 = new quaternion(f4x4);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void Float4ToUint4()
        {
            var f4 = new float4(1.0f, 2.0f, 3.0f, 4.0f);
            var u4 = new uint4();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        u4 = math.asuint(f4);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }
    }
}