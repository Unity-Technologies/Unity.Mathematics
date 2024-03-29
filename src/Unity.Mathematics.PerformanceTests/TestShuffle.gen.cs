//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. To update the generation of this file, modify and re-run Unity.Mathematics.CodeGen.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using NUnit.Framework;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.PerformanceTesting;
using Unity.Mathematics.Geometry;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    partial class TestShuffle
    {
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float2_shuffle
        {
            public const int iterations = 100000;

            public struct Arguments : IDisposable
            {
                public Random rng;
                public float2* v1;
                public float2* v2;
                public float2* result;

                public void Init()
                {
                    rng = new Random(1);
                    v1 = (float2*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float2>() * iterations, UnsafeUtility.AlignOf<float2>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        v1[i] = new float2(1.0f);
                    }

                    v2 = (float2*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float2>() * iterations, UnsafeUtility.AlignOf<float2>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        v2[i] = new float2(2.0f);
                    }

                    result = (float2*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float2>() * iterations, UnsafeUtility.AlignOf<float2>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        result[i] = new float2(1.0f);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(v1, Allocator.Persistent);
                    UnsafeUtility.Free(v2, Allocator.Persistent);
                    UnsafeUtility.Free(result, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < iterations; ++i)
                {
                    args.result[i] = math.shuffle(args.v1[i], args.v2[i], math.ShuffleComponent.RightX, math.ShuffleComponent.LeftY);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float2_shuffle_mono()
        {
            float2_shuffle.TestFunction testFunction = float2_shuffle.MonoTestFunction;
            var args = new float2_shuffle.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float2_shuffle_burst()
        {
            FunctionPointer<float2_shuffle.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float2_shuffle.TestFunction>(float2_shuffle.BurstTestFunction);
            var args = new float2_shuffle.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float3_shuffle
        {
            public const int iterations = 100000;

            public struct Arguments : IDisposable
            {
                public Random rng;
                public float3* v1;
                public float3* v2;
                public float3* result;

                public void Init()
                {
                    rng = new Random(1);
                    v1 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * iterations, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        v1[i] = new float3(1.0f);
                    }

                    v2 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * iterations, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        v2[i] = new float3(2.0f);
                    }

                    result = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * iterations, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        result[i] = new float3(1.0f);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(v1, Allocator.Persistent);
                    UnsafeUtility.Free(v2, Allocator.Persistent);
                    UnsafeUtility.Free(result, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < iterations; ++i)
                {
                    args.result[i] = math.shuffle(args.v1[i], args.v2[i], math.ShuffleComponent.RightX, math.ShuffleComponent.LeftZ, math.ShuffleComponent.LeftX);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float3_shuffle_mono()
        {
            float3_shuffle.TestFunction testFunction = float3_shuffle.MonoTestFunction;
            var args = new float3_shuffle.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float3_shuffle_burst()
        {
            FunctionPointer<float3_shuffle.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float3_shuffle.TestFunction>(float3_shuffle.BurstTestFunction);
            var args = new float3_shuffle.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float4_shuffle
        {
            public const int iterations = 100000;

            public struct Arguments : IDisposable
            {
                public Random rng;
                public float4* v1;
                public float4* v2;
                public float4* result;

                public void Init()
                {
                    rng = new Random(1);
                    v1 = (float4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4>() * iterations, UnsafeUtility.AlignOf<float4>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        v1[i] = new float4(1.0f);
                    }

                    v2 = (float4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4>() * iterations, UnsafeUtility.AlignOf<float4>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        v2[i] = new float4(2.0f);
                    }

                    result = (float4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4>() * iterations, UnsafeUtility.AlignOf<float4>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        result[i] = new float4(1.0f);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(v1, Allocator.Persistent);
                    UnsafeUtility.Free(v2, Allocator.Persistent);
                    UnsafeUtility.Free(result, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < iterations; ++i)
                {
                    args.result[i] = math.shuffle(args.v1[i], args.v2[i], math.ShuffleComponent.RightX, math.ShuffleComponent.LeftZ, math.ShuffleComponent.LeftX, math.ShuffleComponent.RightY);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float4_shuffle_mono()
        {
            float4_shuffle.TestFunction testFunction = float4_shuffle.MonoTestFunction;
            var args = new float4_shuffle.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float4_shuffle_burst()
        {
            FunctionPointer<float4_shuffle.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float4_shuffle.TestFunction>(float4_shuffle.BurstTestFunction);
            var args = new float4_shuffle.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
    }
}
