using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Runtime.InteropServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    public partial struct bool2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2(bool val)
        {
            x = y = val;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool2(bool d)
        {
            return new bool2(d);
        }
    }
}

