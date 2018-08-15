// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint2x3 : System.IEquatable<uint2x3>, IFormattable
    {
        public uint2 c0;
        public uint2 c1;
        public uint2 c2;

        public static readonly uint2x3 zero = new uint2x3(0u, 0u, 0u,   0u, 0u, 0u);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(uint2 c0, uint2 c1, uint2 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(uint m00, uint m01, uint m02,
                       uint m10, uint m11, uint m12)
        { 
            this.c0 = new uint2(m00, m10);
            this.c1 = new uint2(m01, m11);
            this.c2 = new uint2(m02, m12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(bool v)
        {
            this.c0 = math.select(new uint2(0u), new uint2(1u), v);
            this.c1 = math.select(new uint2(0u), new uint2(1u), v);
            this.c2 = math.select(new uint2(0u), new uint2(1u), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(bool2x3 v)
        {
            this.c0 = math.select(new uint2(0u), new uint2(1u), v.c0);
            this.c1 = math.select(new uint2(0u), new uint2(1u), v.c1);
            this.c2 = math.select(new uint2(0u), new uint2(1u), v.c2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(int v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
            this.c2 = (uint2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(int2x3 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
            this.c2 = (uint2)v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(float v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
            this.c2 = (uint2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(float2x3 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
            this.c2 = (uint2)v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(double v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
            this.c2 = (uint2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x3(double2x3 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
            this.c2 = (uint2)v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2x3(uint v) { return new uint2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x3(bool v) { return new uint2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x3(bool2x3 v) { return new uint2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x3(int v) { return new uint2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x3(int2x3 v) { return new uint2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x3(float v) { return new uint2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x3(float2x3 v) { return new uint2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x3(double v) { return new uint2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x3(double2x3 v) { return new uint2x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator * (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator * (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator * (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator + (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator + (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator + (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator - (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator - (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator - (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator / (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator / (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator / (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator % (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator % (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator % (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator ++ (uint2x3 val) { return new uint2x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator -- (uint2x3 val) { return new uint2x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (uint2x3 lhs, uint2x3 rhs) { return new bool2x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (uint2x3 lhs, uint rhs) { return new bool2x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (uint lhs, uint2x3 rhs) { return new bool2x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (uint2x3 lhs, uint2x3 rhs) { return new bool2x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (uint2x3 lhs, uint rhs) { return new bool2x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (uint lhs, uint2x3 rhs) { return new bool2x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (uint2x3 lhs, uint2x3 rhs) { return new bool2x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (uint2x3 lhs, uint rhs) { return new bool2x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (uint lhs, uint2x3 rhs) { return new bool2x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (uint2x3 lhs, uint2x3 rhs) { return new bool2x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (uint2x3 lhs, uint rhs) { return new bool2x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (uint lhs, uint2x3 rhs) { return new bool2x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator - (uint2x3 val) { return new uint2x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator + (uint2x3 val) { return new uint2x3 (+val.c0, +val.c1, +val.c2); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator << (uint2x3 lhs, int rhs) { return new uint2x3 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator >> (uint2x3 lhs, int rhs) { return new uint2x3 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (uint2x3 lhs, uint2x3 rhs) { return new bool2x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (uint2x3 lhs, uint rhs) { return new bool2x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (uint lhs, uint2x3 rhs) { return new bool2x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (uint2x3 lhs, uint2x3 rhs) { return new bool2x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (uint2x3 lhs, uint rhs) { return new bool2x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (uint lhs, uint2x3 rhs) { return new bool2x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator ~ (uint2x3 val) { return new uint2x3 (~val.c0, ~val.c1, ~val.c2); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator & (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator & (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator & (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator | (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator | (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator | (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator ^ (uint2x3 lhs, uint2x3 rhs) { return new uint2x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator ^ (uint2x3 lhs, uint rhs) { return new uint2x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 operator ^ (uint lhs, uint2x3 rhs) { return new uint2x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }

        // [int index] 
        unsafe public uint2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (uint2x3* array = &this) { return ((uint2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (uint2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(uint2x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((uint2x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(uint2 c0, uint2 c1, uint2 c2) { return new uint2x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(uint m00, uint m01, uint m02,
                                      uint m10, uint m11, uint m12)
        {
            return new uint2x3(m00, m01, m02,
                               m10, m11, m12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(uint v) { return new uint2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(bool v) { return new uint2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(bool2x3 v) { return new uint2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(int v) { return new uint2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(int2x3 v) { return new uint2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(float v) { return new uint2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(float2x3 v) { return new uint2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(double v) { return new uint2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x3 uint2x3(double2x3 v) { return new uint2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x2 transpose(uint2x3 v)
        {
            return uint3x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint2x3 v)
        {
            return csum(v.c0 * uint2(0xE7579997u, 0xEF7D56C7u) + 
                        v.c1 * uint2(0x66F38F0Bu, 0x624256A3u) + 
                        v.c2 * uint2(0x5292ADE1u, 0xD2E590E5u)) + 0xF25BE857u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(uint2x3 v)
        {
            return (v.c0 * uint2(0x9BC17CE7u, 0xC8B86851u) + 
                    v.c1 * uint2(0x64095221u, 0xADF428FFu) + 
                    v.c2 * uint2(0xA3977109u, 0x745ED837u)) + 0x9CDC88F5u;
        }

    }
}
