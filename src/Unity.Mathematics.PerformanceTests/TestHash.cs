using Unity.Burst;
using Unity.PerformanceTesting;
using NUnit.Framework;
using Unity.Collections.LowLevel.Unsafe;
using System;
using UnityEngine;

namespace Unity.Mathematics.PerformanceTests
{
    [BurstCompile]
    partial class TestHash
    {
        static readonly long kBufferBytes = 1024 * 1024;

        [Test, Performance]
        public static unsafe void HashAligned()
        {
            Debug.Log(Hash(false));
        }

        [Test, Performance]
        public static unsafe void HashUnaligned()
        {
            Debug.Log(Hash(true));
        }

        [BurstCompile(CompileSynchronously = true)]
        static unsafe uint Hash(bool useUnalignedBuffer)
        {
            var ulongptr = (ulong)(UIntPtr)UnsafeUtility.Malloc(kBufferBytes, 16, Collections.Allocator.Persistent);
            var unaligned = ulongptr;
            uint seed = 0;

            if (useUnalignedBuffer && ((unaligned & 1) == 0))
            {
                ++unaligned;
            }

            for (int i = 0; i < 100; ++i)
            {
                seed = math.hash((void*)unaligned, (int)kBufferBytes - 1, seed);
            }

            UnsafeUtility.Free((void*)ulongptr, Collections.Allocator.Persistent);

            return seed;
        }
    }
}