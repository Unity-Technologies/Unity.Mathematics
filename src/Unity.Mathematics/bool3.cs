using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Runtime.InteropServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    public partial struct bool3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3(bool val) { x = y = z = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool3(bool d)
        {
            return new bool3(d);
        }
    }
}

