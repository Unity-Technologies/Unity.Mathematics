using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(int4.DebuggerProxy))]
    [System.Serializable]
    public partial struct int4
    {
        internal sealed class DebuggerProxy
        {
            public int x;
            public int y;
            public int z;
            public int w;

            public DebuggerProxy(int4 vec)
            {
                x = vec.x;
                y = vec.y;
                z = vec.z;
                w = vec.z;
            }
        }

        public int x;
        public int y;
        public int z;
        public int w;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(int val) { x = y = z = w = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4(float4 val) { x = (int)val.x; y = (int)val.y; z = (int)val.z; w = (int)val.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4(int d) { return new int4(d); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4(float4 d) { return new int4((int)d.x, (int)d.y, (int)d.z, (int)d.w); }

        public override string ToString()
        {
            return string.Format("int4({0}, {1}, {2}, {3})", x, y, z, w);
        }
    }
}

