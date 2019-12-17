using System;
using NUnit.Framework;
using Unity.PerformanceTesting;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    public class TestTrig
    {
        [Test, Performance]
        public void sincos4()
        {
            var f4 = new float4(1.0f, 2.0f, 3.0f, 4.0f);
            var sin = new float4();
            var cos = new float4();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        math.sincos(f4, out sin, out cos);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void sincos3()
        {
            var f3 = new float3(1.0f, 2.0f, 3.0f);
            var sin = new float3();
            var cos = new float3();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        math.sincos(f3, out sin, out cos);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void sincos2()
        {
            var f2 = new float2(1.0f, 2.0f);
            var sin = new float2();
            var cos = new float2();

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        math.sincos(f2, out sin, out cos);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void sincos()
        {
            var f = 1.0f;
            var sin = 0.0f;
            var cos = 0.0f;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        math.sincos(f, out sin, out cos);
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }
    }

    public class TestRandom
    {
        [Test, Performance]
        public void NextUInt()
        {
            var rng = new Unity.Mathematics.Random(1);
            uint u;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        u = rng.NextUInt();
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void NextUInt2()
        {
            var rng = new Unity.Mathematics.Random(1);
            uint2 u;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        u = rng.NextUInt2();
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }

        [Test, Performance]
        public void NextUInt3()
        {
            var rng = new Unity.Mathematics.Random(1);
            uint3 u;

            Measure.Method(() =>
                {
                    for (int i = 0; i < 10000; ++i)
                    {
                        u = rng.NextUInt3();
                    }
                })
                .WarmupCount(1)
                .MeasurementCount(10)
                .Run();
        }
    }
}