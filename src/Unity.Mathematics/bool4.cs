using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Runtime.InteropServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    public partial struct bool4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4(bool val)
        {
            x = y = z = w = val;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool4(bool d)
        {
            return new bool4(d);
        }
    }
}

