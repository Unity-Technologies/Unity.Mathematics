using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Burst;
using System;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;

[BurstCompile]
public class HashAligned : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hash(true);
    }

    static readonly long kBufferBytes = 1024 * 1024;

    [BurstCompile(CompileSynchronously = true)]
    static unsafe uint Hash(bool useUnalignedBuffer)
    {
        var ulongptr = (ulong)(UIntPtr)UnsafeUtility.Malloc(kBufferBytes, 16, Unity.Collections.Allocator.Persistent);
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

        UnsafeUtility.Free((void*)ulongptr, Unity.Collections.Allocator.Persistent);

        return seed;
    }
}
