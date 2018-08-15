// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint3x2 : System.IEquatable<uint3x2>, IFormattable
    {
        public uint3 c0;
        public uint3 c1;

        public static readonly uint3x2 zero = new uint3x2(0u, 0u,   0u, 0u,   0u, 0u);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(uint3 c0, uint3 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(uint m00, uint m01,
                       uint m10, uint m11,
                       uint m20, uint m21)
        { 
            this.c0 = new uint3(m00, m10, m20);
            this.c1 = new uint3(m01, m11, m21);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(bool v)
        {
            this.c0 = math.select(new uint3(0u), new uint3(1u), v);
            this.c1 = math.select(new uint3(0u), new uint3(1u), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(bool3x2 v)
        {
            this.c0 = math.select(new uint3(0u), new uint3(1u), v.c0);
            this.c1 = math.select(new uint3(0u), new uint3(1u), v.c1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(int v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(int3x2 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(float v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(float3x2 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(double v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x2(double3x2 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint3x2(uint v) { return new uint3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x2(bool v) { return new uint3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x2(bool3x2 v) { return new uint3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x2(int v) { return new uint3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x2(int3x2 v) { return new uint3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x2(float v) { return new uint3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x2(float3x2 v) { return new uint3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x2(double v) { return new uint3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x2(double3x2 v) { return new uint3x2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator * (uint3x2 lhs, uint3x2 rhs) { return new uint3x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator * (uint3x2 lhs, uint rhs) { return new uint3x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator * (uint lhs, uint3x2 rhs) { return new uint3x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator + (uint3x2 lhs, uint3x2 rhs) { return new uint3x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator + (uint3x2 lhs, uint rhs) { return new uint3x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator + (uint lhs, uint3x2 rhs) { return new uint3x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator - (uint3x2 lhs, uint3x2 rhs) { return new uint3x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator - (uint3x2 lhs, uint rhs) { return new uint3x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator - (uint lhs, uint3x2 rhs) { return new uint3x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator / (uint3x2 lhs, uint3x2 rhs) { return new uint3x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator / (uint3x2 lhs, uint rhs) { return new uint3x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator / (uint lhs, uint3x2 rhs) { return new uint3x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator % (uint3x2 lhs, uint3x2 rhs) { return new uint3x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator % (uint3x2 lhs, uint rhs) { return new uint3x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator % (uint lhs, uint3x2 rhs) { return new uint3x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator ++ (uint3x2 val) { return new uint3x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator -- (uint3x2 val) { return new uint3x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (uint3x2 lhs, uint3x2 rhs) { return new bool3x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (uint3x2 lhs, uint rhs) { return new bool3x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (uint lhs, uint3x2 rhs) { return new bool3x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (uint3x2 lhs, uint3x2 rhs) { return new bool3x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (uint3x2 lhs, uint rhs) { return new bool3x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (uint lhs, uint3x2 rhs) { return new bool3x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (uint3x2 lhs, uint3x2 rhs) { return new bool3x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (uint3x2 lhs, uint rhs) { return new bool3x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (uint lhs, uint3x2 rhs) { return new bool3x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (uint3x2 lhs, uint3x2 rhs) { return new bool3x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (uint3x2 lhs, uint rhs) { return new bool3x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (uint lhs, uint3x2 rhs) { return new bool3x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator - (uint3x2 val) { return new uint3x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator + (uint3x2 val) { return new uint3x2 (+val.c0, +val.c1); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator << (uint3x2 lhs, int rhs) { return new uint3x2 (lhs.c0 << rhs, lhs.c1 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator >> (uint3x2 lhs, int rhs) { return new uint3x2 (lhs.c0 >> rhs, lhs.c1 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (uint3x2 lhs, uint3x2 rhs) { return new bool3x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (uint3x2 lhs, uint rhs) { return new bool3x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (uint lhs, uint3x2 rhs) { return new bool3x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (uint3x2 lhs, uint3x2 rhs) { return new bool3x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (uint3x2 lhs, uint rhs) { return new bool3x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (uint lhs, uint3x2 rhs) { return new bool3x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator ~ (uint3x2 val) { return new uint3x2 (~val.c0, ~val.c1); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator & (uint3x2 lhs, uint3x2 rhs) { return new uint3x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator & (uint3x2 lhs, uint rhs) { return new uint3x2 (lhs.c0 & rhs, lhs.c1 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator & (uint lhs, uint3x2 rhs) { return new uint3x2 (lhs & rhs.c0, lhs & rhs.c1); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator | (uint3x2 lhs, uint3x2 rhs) { return new uint3x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator | (uint3x2 lhs, uint rhs) { return new uint3x2 (lhs.c0 | rhs, lhs.c1 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator | (uint lhs, uint3x2 rhs) { return new uint3x2 (lhs | rhs.c0, lhs | rhs.c1); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator ^ (uint3x2 lhs, uint3x2 rhs) { return new uint3x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator ^ (uint3x2 lhs, uint rhs) { return new uint3x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 operator ^ (uint lhs, uint3x2 rhs) { return new uint3x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }

        // [int index] 
        unsafe public uint3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint3x2* array = &this) { return ((uint3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(uint3x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((uint3x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint3x2({0}, {1},  {2}, {3},  {4}, {5})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint3x2({0}, {1},  {2}, {3},  {4}, {5})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(uint3 c0, uint3 c1) { return new uint3x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(uint m00, uint m01,
                                      uint m10, uint m11,
                                      uint m20, uint m21)
        {
            return new uint3x2(m00, m01,
                               m10, m11,
                               m20, m21);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(uint v) { return new uint3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(bool v) { return new uint3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(bool3x2 v) { return new uint3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(int v) { return new uint3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(int3x2 v) { return new uint3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(float v) { return new uint3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(float3x2 v) { return new uint3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(double v) { return new uint3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 uint3x2(double3x2 v) { return new uint3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 transpose(uint3x2 v)
        {
            return uint2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint3x2 v)
        {
            return csum(v.c0 * uint3(0xE121E6ADu, 0xC9CA1249u, 0x69B60C81u) + 
                        v.c1 * uint3(0xE0EB6C25u, 0xF648BEABu, 0x6BDB2B07u)) + 0xEF63C699u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(uint3x2 v)
        {
            return (v.c0 * uint3(0x9001903Fu, 0xA895B9CDu, 0x9D23B201u) + 
                    v.c1 * uint3(0x4B01D3E1u, 0x7461CA0Du, 0x79725379u)) + 0xD6258E5Bu;
        }

    }
}
