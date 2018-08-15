// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(float2.DebuggerProxy))]
    [System.Serializable]
    public partial struct float2 : System.IEquatable<float2>, IFormattable
    {
        public float x;
        public float y;

        public static readonly float2 zero = new float2(0.0f,   0.0f);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float x, float y)
        { 
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(float v)
        {
            this.x = v;
            this.y = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(bool v)
        {
            this.x = v ? 1.0f : 0.0f;
            this.y = v ? 1.0f : 0.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(bool2 v)
        {
            this.x = v.x ? 1.0f : 0.0f;
            this.y = v.y ? 1.0f : 0.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(int v)
        {
            this.x = v;
            this.y = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(int2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(uint v)
        {
            this.x = v;
            this.y = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(uint2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(double v)
        {
            this.x = (float)v;
            this.y = (float)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2(double2 v)
        {
            this.x = (float)v.x;
            this.y = (float)v.y;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(float v) { return new float2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2(bool v) { return new float2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2(bool2 v) { return new float2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(int v) { return new float2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(int2 v) { return new float2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(uint v) { return new float2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2(uint2 v) { return new float2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2(double v) { return new float2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2(double2 v) { return new float2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator * (float2 lhs, float2 rhs) { return new float2 (lhs.x * rhs.x, lhs.y * rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator * (float2 lhs, float rhs) { return new float2 (lhs.x * rhs, lhs.y * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator * (float lhs, float2 rhs) { return new float2 (lhs * rhs.x, lhs * rhs.y); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator + (float2 lhs, float2 rhs) { return new float2 (lhs.x + rhs.x, lhs.y + rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator + (float2 lhs, float rhs) { return new float2 (lhs.x + rhs, lhs.y + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator + (float lhs, float2 rhs) { return new float2 (lhs + rhs.x, lhs + rhs.y); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator - (float2 lhs, float2 rhs) { return new float2 (lhs.x - rhs.x, lhs.y - rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator - (float2 lhs, float rhs) { return new float2 (lhs.x - rhs, lhs.y - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator - (float lhs, float2 rhs) { return new float2 (lhs - rhs.x, lhs - rhs.y); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator / (float2 lhs, float2 rhs) { return new float2 (lhs.x / rhs.x, lhs.y / rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator / (float2 lhs, float rhs) { return new float2 (lhs.x / rhs, lhs.y / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator / (float lhs, float2 rhs) { return new float2 (lhs / rhs.x, lhs / rhs.y); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator % (float2 lhs, float2 rhs) { return new float2 (lhs.x % rhs.x, lhs.y % rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator % (float2 lhs, float rhs) { return new float2 (lhs.x % rhs, lhs.y % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator % (float lhs, float2 rhs) { return new float2 (lhs % rhs.x, lhs % rhs.y); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator ++ (float2 val) { return new float2 (++val.x, ++val.y); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator -- (float2 val) { return new float2 (--val.x, --val.y); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (float2 lhs, float2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (float2 lhs, float rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (float lhs, float2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (float2 lhs, float2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (float2 lhs, float rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (float lhs, float2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (float2 lhs, float2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (float2 lhs, float rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (float lhs, float2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (float2 lhs, float2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (float2 lhs, float rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (float lhs, float2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator - (float2 val) { return new float2 (-val.x, -val.y); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 operator + (float2 val) { return new float2 (+val.x, +val.y); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (float2 lhs, float2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (float2 lhs, float rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (float lhs, float2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (float2 lhs, float2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (float2 lhs, float rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (float lhs, float2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public float2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new float2(y, y); }
        }



        // [int index] 
        unsafe public float this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float2* array = &this) { return ((float*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float* array = &x) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(float2 rhs) { return x == rhs.x && y == rhs.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((float2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float2({0}f, {1}f)", x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float2({0}f, {1}f)", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public float x;
            public float y;
            public DebuggerProxy(float2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(float x, float y) { return new float2(x, y); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(float2 xy) { return new float2(xy); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(float v) { return new float2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(bool v) { return new float2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(bool2 v) { return new float2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(int v) { return new float2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(int2 v) { return new float2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(uint v) { return new float2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(uint2 v) { return new float2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(double v) { return new float2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 float2(double2 v) { return new float2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float2 v)
        {
            return csum(asuint(v) * uint2(0x5BA2C50Bu, 0x8C455ACBu)) + 0xCD266C89u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(float2 v)
        {
            return (asuint(v) * uint2(0xF1852A33u, 0x77E35E77u)) + 0x863E3729u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static float select_shuffle_component(float2 a, float2 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float shuffle(float2 a, float2 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 shuffle(float2 a, float2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return float2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 shuffle(float2 a, float2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return float3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 shuffle(float2 a, float2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return float4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

    }
}
