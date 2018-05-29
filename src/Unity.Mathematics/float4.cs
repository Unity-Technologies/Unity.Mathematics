using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(float4.DebuggerProxy))]
    [System.Serializable]
    public partial struct float4 : IFormattable
    {
        internal sealed class DebuggerProxy
        {
            public float x;
            public float y;
            public float z;
            public float w;

            public DebuggerProxy(float4 vec)
            {
                x = vec.x;
                y = vec.y;
                z = vec.z;
                w = vec.z;
            }
        }

        public float x;
        public float y;
        public float z;
        public float w;
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(float val) { x = y = z = w = val; }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(int val) { x = y = z = w = val; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(int4 val)
        {
            x = val.x;
            y = val.y;
            z = val.z;
            w = val.w;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4(bool4 val)
        {
            x = val.x ? 1.0f : 0.0f;
            y = val.y ? 1.0f : 0.0f;
            z = val.z ? 1.0f : 0.0f;
            w = val.w ? 1.0f : 0.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(float d) { return new float4(d); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(int4 d) { return new float4(d.x, d.y, d.z, d.w); }

        public override string ToString()
        {
            return string.Format("float4({0}f, {1}f, {2}f, {3}f)", x, y, z, w);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float4({0}f, {1}f, {2}f, {3}f)", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }
    }
}

