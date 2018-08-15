// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(uint2.DebuggerProxy))]
    [System.Serializable]
    public partial struct uint2 : System.IEquatable<uint2>, IFormattable
    {
        public uint x;
        public uint y;

        public static readonly uint2 zero = new uint2(0u,   0u);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint x, uint y)
        { 
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint v)
        {
            this.x = v;
            this.y = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(bool v)
        {
            this.x = v ? 1u : 0u;
            this.y = v ? 1u : 0u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(bool2 v)
        {
            this.x = v.x ? 1u : 0u;
            this.y = v.y ? 1u : 0u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(int v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(int2 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(float v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(float2 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(double v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(double2 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(uint v) { return new uint2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(bool v) { return new uint2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(bool2 v) { return new uint2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(int v) { return new uint2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(int2 v) { return new uint2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(float v) { return new uint2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(float2 v) { return new uint2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(double v) { return new uint2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(double2 v) { return new uint2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator * (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x * rhs.x, lhs.y * rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator * (uint2 lhs, uint rhs) { return new uint2 (lhs.x * rhs, lhs.y * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator * (uint lhs, uint2 rhs) { return new uint2 (lhs * rhs.x, lhs * rhs.y); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x + rhs.x, lhs.y + rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint2 lhs, uint rhs) { return new uint2 (lhs.x + rhs, lhs.y + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint lhs, uint2 rhs) { return new uint2 (lhs + rhs.x, lhs + rhs.y); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x - rhs.x, lhs.y - rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint2 lhs, uint rhs) { return new uint2 (lhs.x - rhs, lhs.y - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint lhs, uint2 rhs) { return new uint2 (lhs - rhs.x, lhs - rhs.y); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator / (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x / rhs.x, lhs.y / rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator / (uint2 lhs, uint rhs) { return new uint2 (lhs.x / rhs, lhs.y / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator / (uint lhs, uint2 rhs) { return new uint2 (lhs / rhs.x, lhs / rhs.y); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator % (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x % rhs.x, lhs.y % rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator % (uint2 lhs, uint rhs) { return new uint2 (lhs.x % rhs, lhs.y % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator % (uint lhs, uint2 rhs) { return new uint2 (lhs % rhs.x, lhs % rhs.y); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ++ (uint2 val) { return new uint2 (++val.x, ++val.y); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator -- (uint2 val) { return new uint2 (--val.x, --val.y); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (uint2 lhs, uint rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (uint lhs, uint2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (uint2 lhs, uint rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (uint lhs, uint2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (uint2 lhs, uint rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (uint lhs, uint2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (uint2 lhs, uint rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (uint lhs, uint2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint2 val) { return new uint2 ((uint)-val.x, (uint)-val.y); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint2 val) { return new uint2 (+val.x, +val.y); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator << (uint2 lhs, int rhs) { return new uint2 (lhs.x << rhs, lhs.y << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator >> (uint2 lhs, int rhs) { return new uint2 (lhs.x >> rhs, lhs.y >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (uint2 lhs, uint rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (uint lhs, uint2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (uint2 lhs, uint rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (uint lhs, uint2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ~ (uint2 val) { return new uint2 (~val.x, ~val.y); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator & (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x & rhs.x, lhs.y & rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator & (uint2 lhs, uint rhs) { return new uint2 (lhs.x & rhs, lhs.y & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator & (uint lhs, uint2 rhs) { return new uint2 (lhs & rhs.x, lhs & rhs.y); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator | (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x | rhs.x, lhs.y | rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator | (uint2 lhs, uint rhs) { return new uint2 (lhs.x | rhs, lhs.y | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator | (uint lhs, uint2 rhs) { return new uint2 (lhs | rhs.x, lhs | rhs.y); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ^ (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ^ (uint2 lhs, uint rhs) { return new uint2 (lhs.x ^ rhs, lhs.y ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ^ (uint lhs, uint2 rhs) { return new uint2 (lhs ^ rhs.x, lhs ^ rhs.y); }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(y, y); }
        }



        // [int index] 
        unsafe public uint this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint2* array = &this) { return ((uint*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint* array = &x) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(uint2 rhs) { return x == rhs.x && y == rhs.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((uint2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint2({0}, {1})", x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint2({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public uint x;
            public uint y;
            public DebuggerProxy(uint2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(uint x, uint y) { return new uint2(x, y); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(uint2 xy) { return new uint2(xy); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(uint v) { return new uint2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(bool v) { return new uint2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(bool2 v) { return new uint2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(int v) { return new uint2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(int2 v) { return new uint2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(float v) { return new uint2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(float2 v) { return new uint2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(double v) { return new uint2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(double2 v) { return new uint2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint2 v)
        {
            return csum(v * uint2(0x4C7F6DD1u, 0x4822A3E9u)) + 0xAAC3C25Du;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(uint2 v)
        {
            return (v * uint2(0xD21D0945u, 0x88FCAB2Du)) + 0x614DA60Du;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint select_shuffle_component(uint2 a, uint2 b, ShuffleComponent component)
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
        public static uint shuffle(uint2 a, uint2 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 shuffle(uint2 a, uint2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return uint2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 shuffle(uint2 a, uint2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return uint3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 shuffle(uint2 a, uint2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return uint4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

    }
}
