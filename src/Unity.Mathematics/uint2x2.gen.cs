// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint2x2 : System.IEquatable<uint2x2>, IFormattable
    {
        public uint2 c0;
        public uint2 c1;

        public static readonly uint2x2 zero = new uint2x2(0, 0, 0, 0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(uint2 c0, uint2 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(uint m00, uint m01,
                       uint m10, uint m11)
        { 
            this.c0 = new uint2(m00, m10);
            this.c1 = new uint2(m01, m11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(int v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(int2x2 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(float v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x2(float2x2 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2x2(uint v) { return new uint2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(int v) { return new uint2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(int2x2 v) { return new uint2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(float v) { return new uint2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x2(float2x2 v) { return new uint2x2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator * (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator * (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator * (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator + (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator + (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator + (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator - (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator - (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator - (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator / (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator / (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator / (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator % (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator % (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator % (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ++ (uint2x2 val) { return new uint2x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator -- (uint2x2 val) { return new uint2x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator - (uint2x2 val) { return new uint2x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator + (uint2x2 val) { return new uint2x2 (+val.c0, +val.c1); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator << (uint2x2 lhs, int rhs) { return new uint2x2 (lhs.c0 << rhs, lhs.c1 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator >> (uint2x2 lhs, int rhs) { return new uint2x2 (lhs.c0 >> rhs, lhs.c1 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (uint2x2 lhs, uint2x2 rhs) { return new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (uint2x2 lhs, uint rhs) { return new bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (uint lhs, uint2x2 rhs) { return new bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ~ (uint2x2 val) { return new uint2x2 (~val.c0, ~val.c1); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator & (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator & (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 & rhs, lhs.c1 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator & (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs & rhs.c0, lhs & rhs.c1); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator | (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator | (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 | rhs, lhs.c1 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator | (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs | rhs.c0, lhs | rhs.c1); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ^ (uint2x2 lhs, uint2x2 rhs) { return new uint2x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ^ (uint2x2 lhs, uint rhs) { return new uint2x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 operator ^ (uint lhs, uint2x2 rhs) { return new uint2x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }

        // [int index] 
        unsafe public uint2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint2x2* array = &this) { return ((uint2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(uint2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((uint2x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint2x2({0}, {1},  {2}, {3})", c0.x, c1.x, c0.y, c1.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint2x2({0}, {1},  {2}, {3})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(uint2 c0, uint2 c1) { return new uint2x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(uint m00, uint m01,
                                      uint m10, uint m11)
        {
            return new uint2x2(m00, m01,
                               m10, m11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(uint v) { return new uint2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(int v) { return new uint2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(int2x2 v) { return new uint2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(float v) { return new uint2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x2 uint2x2(float2x2 v) { return new uint2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint2x2 v)
        {
            return csum(v.c0 * uint2(0x6BF6693Fu, 0x9D1B1D9Bu) + 
                        v.c1 * uint2(0xF842F5C1u, 0xA47EC335u)) + 0xA477DF57u;
        }

    }
}
