// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public class Playground
    {
        public static void Main(ref float2 res, ref float3 a, ref float3 b)
        {
            res = shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftX);
        }
    }
}
