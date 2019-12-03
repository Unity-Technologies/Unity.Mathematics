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
    }
}