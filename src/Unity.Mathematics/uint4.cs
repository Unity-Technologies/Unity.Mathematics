using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(uint4.DebuggerProxy))]
    [System.Serializable]
    public partial struct uint4
    {
        internal sealed class DebuggerProxy
        {
            public uint x;
            public uint y;
            public uint z;
            public uint w;

            public DebuggerProxy(uint4 vec)
            {
                x = vec.x;
                y = vec.y;
                z = vec.z;
                w = vec.z;
            }
        }

        public uint x;
        public uint y;
        public uint z;
        public uint w;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(uint val) { x = y = z = w = val; }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(int4 val) { x = (uint)val.x; y = (uint)val.y; z = (uint)val.z; w = (uint)val.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4(float4 val) { x = (uint)val.x; y = (uint)val.y; z = (uint)val.z; w = (uint)val.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint4(uint d) { return new uint4(d); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4(float4 d) { return new uint4((uint)d.x, (uint)d.y, (uint)d.z, (uint)d.w); }

        public static readonly uint4 zero = new uint4(0, 0, 0, 0);
    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 uint4(uint val) { return new uint4(val); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 uint4(int4 val) { return new uint4(val); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 uint4(float4 val) { return new uint4(val); }
    }
}

