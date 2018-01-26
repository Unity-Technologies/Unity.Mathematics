using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Runtime.InteropServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(bool3.DebuggerProxy))]
    public partial struct bool3
    {
        internal sealed class DebuggerProxy
        {
            public bool x;
            public bool y;
            public bool z;

            public DebuggerProxy(bool3 vec)
            {
                x = vec.x;
                y = vec.y;
                z = vec.z;
            }
        }

        [MarshalAs(UnmanagedType.U1)] // Allow this struct to be passed to a dynamic delegate and marshal correctly
        public bool x;
        [MarshalAs(UnmanagedType.U1)]
        public bool y;
        [MarshalAs(UnmanagedType.U1)]
        public bool z;

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public bool3(bool val) { x = y = z = val; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public bool3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public bool3(bool2 xy, bool z)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator bool3(bool d)
        {
            return new bool3(d);
        }

        public override string ToString()
        {
            return string.Format("bool3({0}, {1}, {2})", x, y, z);
        }

    }
}

