using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    public partial struct int3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(int val) { x = y = z = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3(float3 val)
        {
            x = (int)val.x;
            y = (int)val.y;
            z = (int)val.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3(int d) { return new int3(d); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3(float3 d) { return new int3((int)d.x, (int)d.y, (int)d.z); }

        public static readonly int3 zero = new int3(0, 0, 0);
    }
}

