using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(uint3.DebuggerProxy))]
    [System.Serializable]
    public partial struct uint3
    {
        internal sealed class DebuggerProxy
        {
            public uint x;
            public uint y;
            public uint z;

            public DebuggerProxy(uint3 vec)
            {
                x = vec.x;
                y = vec.y;
                z = vec.z;
            }
        }

        public uint x;
        public uint y;
        public uint z;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(uint val) { x = y = z = val; }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3(float3 val)
        {
            x = (uint)val.x;
            y = (uint)val.y;
            z = (uint)val.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint3(uint d) { return new uint3(d); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3(float3 d) { return new uint3(d); }

        public static readonly uint3 zero = new uint3(0, 0, 0);
    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 uint3(uint val) { return new uint3(val); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 uint3(int3 val) { return new uint3(val); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 uint3(float3 val) { return new uint3(val); }
    }
}

