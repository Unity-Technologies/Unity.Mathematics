using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    public partial struct int2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int val) { x = y = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(float2 val)
        {
            x = (int)val.x;
            y = (int)val.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(int d) { return new int2(d); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(float2 d) { return new int2((int)d.x, (int)d.y); }

        public static readonly int2 zero = new int2(0, 0);
    }
}

