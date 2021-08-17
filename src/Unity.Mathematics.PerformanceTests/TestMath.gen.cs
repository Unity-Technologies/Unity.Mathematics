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
    partial class TestMath
    {
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class orthonormal_basis_float
        {
            public struct Arguments : IDisposable
            {
                public Random* rng;
                public float3* v1;
                public float3* v2;
                public float3* v3;

                public void Init()
                {
                    rng = (Random*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<Random>() * 1000000, UnsafeUtility.AlignOf<Random>(), Allocator.Persistent);
                    for (int i = 0; i < 1000000; ++i)
                    {
                        rng[i] = new Random(1234u);
                    }

                    v1 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 1000000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 1000000; ++i)
                    {
                        v1[i] = rng[0].NextFloat3Direction();
                    }

                    v2 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 1000000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 1000000; ++i)
                    {
                        v2[i] = new float3();
                    }

                    v3 = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * 1000000, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < 1000000; ++i)
                    {
                        v3[i] = new float3();
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(rng, Allocator.Persistent);
                    UnsafeUtility.Free(v1, Allocator.Persistent);
                    UnsafeUtility.Free(v2, Allocator.Persistent);
                    UnsafeUtility.Free(v3, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 1000000; ++i)
                {
                    math.orthonormal_basis(args.v1[i], out args.v2[i], out args.v3[i]);
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
        public void orthonormal_basis_float_mono()
        {
            orthonormal_basis_float.TestFunction testFunction = orthonormal_basis_float.MonoTestFunction;
            var args = new orthonormal_basis_float.Arguments();
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
        public void orthonormal_basis_float_burst()
        {
            FunctionPointer<orthonormal_basis_float.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<orthonormal_basis_float.TestFunction>(orthonormal_basis_float.BurstTestFunction);
            var args = new orthonormal_basis_float.Arguments();
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
        public unsafe class orthonormal_basis_double
        {
            public struct Arguments : IDisposable
            {
                public Random* rng;
                public double3* v1;
                public double3* v2;
                public double3* v3;

                public void Init()
                {
                    rng = (Random*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<Random>() * 1000000, UnsafeUtility.AlignOf<Random>(), Allocator.Persistent);
                    for (int i = 0; i < 1000000; ++i)
                    {
                        rng[i] = new Random(1234u);
                    }

                    v1 = (double3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<double3>() * 1000000, UnsafeUtility.AlignOf<double3>(), Allocator.Persistent);
                    for (int i = 0; i < 1000000; ++i)
                    {
                        v1[i] = rng[0].NextDouble3Direction();
                    }

                    v2 = (double3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<double3>() * 1000000, UnsafeUtility.AlignOf<double3>(), Allocator.Persistent);
                    for (int i = 0; i < 1000000; ++i)
                    {
                        v2[i] = new double();
                    }

                    v3 = (double3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<double3>() * 1000000, UnsafeUtility.AlignOf<double3>(), Allocator.Persistent);
                    for (int i = 0; i < 1000000; ++i)
                    {
                        v3[i] = new double();
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(rng, Allocator.Persistent);
                    UnsafeUtility.Free(v1, Allocator.Persistent);
                    UnsafeUtility.Free(v2, Allocator.Persistent);
                    UnsafeUtility.Free(v3, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < 1000000; ++i)
                {
                    math.orthonormal_basis(args.v1[i], out args.v2[i], out args.v3[i]);
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
        public void orthonormal_basis_double_mono()
        {
            orthonormal_basis_double.TestFunction testFunction = orthonormal_basis_double.MonoTestFunction;
            var args = new orthonormal_basis_double.Arguments();
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
        public void orthonormal_basis_double_burst()
        {
            FunctionPointer<orthonormal_basis_double.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<orthonormal_basis_double.TestFunction>(orthonormal_basis_double.BurstTestFunction);
            var args = new orthonormal_basis_double.Arguments();
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