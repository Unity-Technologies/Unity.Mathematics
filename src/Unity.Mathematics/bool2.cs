using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Runtime.InteropServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(bool2.DebuggerProxy))]
    public partial struct bool2
    {
        internal sealed class DebuggerProxy
        {
            public bool x;
            public bool y;

            public DebuggerProxy(bool2 vec)
            {
                x = vec.x;
                y = vec.y;
            }
        }

        [MarshalAs(UnmanagedType.U1)] // Allow this struct to be passed to a dynamic delegate and marshal correctly
        public bool x;
        [MarshalAs(UnmanagedType.U1)]
        public bool y;

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public bool2(bool val)
        {
            x = y = val;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public bool2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator bool2(bool d)
        {
            return new bool2(d);
        }

        public override string ToString()
        {
            return string.Format("bool2({0}, {1})", x, y);
        }
    }
}

