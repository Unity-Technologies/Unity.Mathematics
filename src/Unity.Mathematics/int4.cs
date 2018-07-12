using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    public partial struct int4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int val) { x = y = z = w = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(float4 val) { x = (int)val.x; y = (int)val.y; z = (int)val.z; w = (int)val.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(int d) { return new int4(d); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4(float4 d) { return new int4((int)d.x, (int)d.y, (int)d.z, (int)d.w); }

        public static readonly int4 zero = new int4(0, 0, 0, 0);
    }
}

