using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    public partial struct float2 : IFormattable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float val) { x = y = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(int val) { x = y = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(int2 val)
        {
            x = val.x;
            y = val.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(float d) { return new float2(d); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(int2 d) { return new float2(d.x, d.y); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(bool2 d) { return new float2(d.x ? 1.0f : 0.0f, d.y ? 1.0f : 0.0f); }

        public static readonly float2 zero = new float2(0.0f, 0.0f);
    }
}

