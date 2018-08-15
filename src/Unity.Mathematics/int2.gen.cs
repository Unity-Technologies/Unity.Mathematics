// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(int2.DebuggerProxy))]
    [System.Serializable]
    public partial struct int2 : System.IEquatable<int2>, IFormattable
    {
        public int x;
        public int y;

        public static readonly int2 zero = new int2(0,   0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int x, int y)
        { 
            this.x = x;
            this.y = y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(int v)
        {
            this.x = v;
            this.y = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(bool v)
        {
            this.x = v ? 1 : 0;
            this.y = v ? 1 : 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(bool2 v)
        {
            this.x = v.x ? 1 : 0;
            this.y = v.y ? 1 : 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(uint v)
        {
            this.x = (int)v;
            this.y = (int)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(uint2 v)
        {
            this.x = (int)v.x;
            this.y = (int)v.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(float v)
        {
            this.x = (int)v;
            this.y = (int)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(float2 v)
        {
            this.x = (int)v.x;
            this.y = (int)v.y;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(double v)
        {
            this.x = (int)v;
            this.y = (int)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2(double2 v)
        {
            this.x = (int)v.x;
            this.y = (int)v.y;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2(int v) { return new int2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(bool v) { return new int2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(bool2 v) { return new int2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(uint v) { return new int2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(uint2 v) { return new int2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(float v) { return new int2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(float2 v) { return new int2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(double v) { return new int2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2(double2 v) { return new int2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator * (int2 lhs, int2 rhs) { return new int2 (lhs.x * rhs.x, lhs.y * rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator * (int2 lhs, int rhs) { return new int2 (lhs.x * rhs, lhs.y * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator * (int lhs, int2 rhs) { return new int2 (lhs * rhs.x, lhs * rhs.y); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int2 lhs, int2 rhs) { return new int2 (lhs.x + rhs.x, lhs.y + rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int2 lhs, int rhs) { return new int2 (lhs.x + rhs, lhs.y + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int lhs, int2 rhs) { return new int2 (lhs + rhs.x, lhs + rhs.y); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int2 lhs, int2 rhs) { return new int2 (lhs.x - rhs.x, lhs.y - rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int2 lhs, int rhs) { return new int2 (lhs.x - rhs, lhs.y - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int lhs, int2 rhs) { return new int2 (lhs - rhs.x, lhs - rhs.y); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator / (int2 lhs, int2 rhs) { return new int2 (lhs.x / rhs.x, lhs.y / rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator / (int2 lhs, int rhs) { return new int2 (lhs.x / rhs, lhs.y / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator / (int lhs, int2 rhs) { return new int2 (lhs / rhs.x, lhs / rhs.y); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator % (int2 lhs, int2 rhs) { return new int2 (lhs.x % rhs.x, lhs.y % rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator % (int2 lhs, int rhs) { return new int2 (lhs.x % rhs, lhs.y % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator % (int lhs, int2 rhs) { return new int2 (lhs % rhs.x, lhs % rhs.y); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ++ (int2 val) { return new int2 (++val.x, ++val.y); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator -- (int2 val) { return new int2 (--val.x, --val.y); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (int2 lhs, int2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (int2 lhs, int rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (int lhs, int2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (int2 lhs, int2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (int2 lhs, int rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (int lhs, int2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (int2 lhs, int2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (int2 lhs, int rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (int lhs, int2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (int2 lhs, int2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (int2 lhs, int rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (int lhs, int2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator - (int2 val) { return new int2 (-val.x, -val.y); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator + (int2 val) { return new int2 (+val.x, +val.y); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator << (int2 lhs, int rhs) { return new int2 (lhs.x << rhs, lhs.y << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator >> (int2 lhs, int rhs) { return new int2 (lhs.x >> rhs, lhs.y >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (int2 lhs, int2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (int2 lhs, int rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (int lhs, int2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (int2 lhs, int2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (int2 lhs, int rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (int lhs, int2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ~ (int2 val) { return new int2 (~val.x, ~val.y); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator & (int2 lhs, int2 rhs) { return new int2 (lhs.x & rhs.x, lhs.y & rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator & (int2 lhs, int rhs) { return new int2 (lhs.x & rhs, lhs.y & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator & (int lhs, int2 rhs) { return new int2 (lhs & rhs.x, lhs & rhs.y); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator | (int2 lhs, int2 rhs) { return new int2 (lhs.x | rhs.x, lhs.y | rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator | (int2 lhs, int rhs) { return new int2 (lhs.x | rhs, lhs.y | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator | (int lhs, int2 rhs) { return new int2 (lhs | rhs.x, lhs | rhs.y); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^ (int2 lhs, int2 rhs) { return new int2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^ (int2 lhs, int rhs) { return new int2 (lhs.x ^ rhs, lhs.y ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 operator ^ (int lhs, int2 rhs) { return new int2 (lhs ^ rhs.x, lhs ^ rhs.y); }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public int2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new int2(y, y); }
        }



        // [int index] 
        unsafe public int this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int2* array = &this) { return ((int*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int* array = &x) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(int2 rhs) { return x == rhs.x && y == rhs.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((int2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int2({0}, {1})", x, y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int2({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public int x;
            public int y;
            public DebuggerProxy(int2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(int x, int y) { return new int2(x, y); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(int2 xy) { return new int2(xy); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(int v) { return new int2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(bool v) { return new int2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(bool2 v) { return new int2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(uint v) { return new int2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(uint2 v) { return new int2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(float v) { return new int2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(float2 v) { return new int2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(double v) { return new int2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 int2(double2 v) { return new int2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int2 v)
        {
            return csum(asuint(v) * uint2(0x5F17300Du, 0x670D6809u)) + 0x7AF32C49u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(int2 v)
        {
            return (asuint(v) * uint2(0xAE131389u, 0x5D1B165Bu)) + 0x87096CD7u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int select_shuffle_component(int2 a, int2 b, ShuffleComponent component)
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
        public static int shuffle(int2 a, int2 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 shuffle(int2 a, int2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return int2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 shuffle(int2 a, int2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return int3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 shuffle(int2 a, int2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return int4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

    }
}
