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
        static readonly long kBytesToHash = kBufferBytes - 1;
        static readonly uint kExpectedHash = 1781740882;

        [Test, Performance]
        public static unsafe void HashAligned()
        {
            Assert.AreEqual(kExpectedHash, Hash(false));
        }

        [Test, Performance]
        public static unsafe void HashUnaligned()
        {
            Assert.AreEqual(kExpectedHash, Hash(true));
        }

        [BurstCompile(CompileSynchronously = true)]
        static unsafe uint Hash(bool useUnalignedBuffer)
        {
            var ptr = (ulong)(UIntPtr)UnsafeUtility.Malloc(kBufferBytes, 16, Collections.Allocator.Persistent);
            var ulongptr = (ulong)ptr;
            uint seed = 0;

            if (useUnalignedBuffer && ((ulongptr & 1) == 0))
            {
                ++ulongptr;
            }

            var buffer = (void*)ulongptr;

            for (int i = 0; i < kBytesToHash; ++i)
            {
                ((byte*)buffer)[i] = 123;
            }

            for (int i = 0; i < 100; ++i)
            {
                seed = math.hash(buffer, (int)kBytesToHash, seed);
            }

            UnsafeUtility.Free((void*)ptr, Collections.Allocator.Persistent);

            return seed;
        }
    }
}