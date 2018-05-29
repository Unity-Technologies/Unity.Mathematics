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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3(bool val) { x = y = z = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

