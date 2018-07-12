using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    public partial struct uint2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint val) { x = y = val; }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(int2 val)
        {
            x = (uint)val.x;
            y = (uint)val.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(float2 val)
        {
            x = (uint)val.x;
            y = (uint)val.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(uint d) { return new uint2(d); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(float2 d) { return new uint2(d); }

        public static readonly uint2 zero = new uint2(0, 0);
    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(uint val) { return new uint2(val); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(int2 val) { return new uint2(val); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(float2 val) { return new uint2(val); }
    }
}

