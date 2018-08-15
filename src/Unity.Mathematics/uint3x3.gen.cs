// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint3x3 : System.IEquatable<uint3x3>, IFormattable
    {
        public uint3 c0;
        public uint3 c1;
        public uint3 c2;

        public static readonly uint3x3 identity = new uint3x3(1u, 0u, 0u,   0u, 1u, 0u,   0u, 0u, 1u);
        public static readonly uint3x3 zero = new uint3x3(0u, 0u, 0u,   0u, 0u, 0u,   0u, 0u, 0u);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(uint3 c0, uint3 c1, uint3 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(uint m00, uint m01, uint m02,
                       uint m10, uint m11, uint m12,
                       uint m20, uint m21, uint m22)
        { 
            this.c0 = new uint3(m00, m10, m20);
            this.c1 = new uint3(m01, m11, m21);
            this.c2 = new uint3(m02, m12, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(bool v)
        {
            this.c0 = math.select(new uint3(0u), new uint3(1u), v);
            this.c1 = math.select(new uint3(0u), new uint3(1u), v);
            this.c2 = math.select(new uint3(0u), new uint3(1u), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(bool3x3 v)
        {
            this.c0 = math.select(new uint3(0u), new uint3(1u), v.c0);
            this.c1 = math.select(new uint3(0u), new uint3(1u), v.c1);
            this.c2 = math.select(new uint3(0u), new uint3(1u), v.c2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(int v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
            this.c2 = (uint3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(int3x3 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
            this.c2 = (uint3)v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(float v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
            this.c2 = (uint3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(float3x3 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
            this.c2 = (uint3)v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(double v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
            this.c2 = (uint3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(double3x3 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
            this.c2 = (uint3)v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint3x3(uint v) { return new uint3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(bool v) { return new uint3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(bool3x3 v) { return new uint3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(int v) { return new uint3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(int3x3 v) { return new uint3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(float v) { return new uint3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(float3x3 v) { return new uint3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(double v) { return new uint3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x3(double3x3 v) { return new uint3x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator * (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator * (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator * (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator / (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator / (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator / (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator % (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator % (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator % (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ++ (uint3x3 val) { return new uint3x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator -- (uint3x3 val) { return new uint3x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (uint3x3 val) { return new uint3x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (uint3x3 val) { return new uint3x3 (+val.c0, +val.c1, +val.c2); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator << (uint3x3 lhs, int rhs) { return new uint3x3 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator >> (uint3x3 lhs, int rhs) { return new uint3x3 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ~ (uint3x3 val) { return new uint3x3 (~val.c0, ~val.c1, ~val.c2); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator & (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator & (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator & (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator | (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator | (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator | (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ^ (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ^ (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ^ (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }

        // [int index] 
        unsafe public uint3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (uint3x3* array = &this) { return ((uint3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (uint3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(uint3x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((uint3x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(uint3 c0, uint3 c1, uint3 c2) { return new uint3x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(uint m00, uint m01, uint m02,
                                      uint m10, uint m11, uint m12,
                                      uint m20, uint m21, uint m22)
        {
            return new uint3x3(m00, m01, m02,
                               m10, m11, m12,
                               m20, m21, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(uint v) { return new uint3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(bool v) { return new uint3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(bool3x3 v) { return new uint3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(int v) { return new uint3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(int3x3 v) { return new uint3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(float v) { return new uint3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(float3x3 v) { return new uint3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(double v) { return new uint3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(double3x3 v) { return new uint3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 transpose(uint3x3 v)
        {
            return uint3x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint3x3 v)
        {
            return csum(v.c0 * uint3(0x9DF50593u, 0xF18EEB85u, 0x9E19BFC3u) + 
                        v.c1 * uint3(0x8196B06Fu, 0xD24EFA19u, 0x7D8048BBu) + 
                        v.c2 * uint3(0x713BD06Fu, 0x753AD6ADu, 0xD19764C7u)) + 0xB5D0BF63u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(uint3x3 v)
        {
            return (v.c0 * uint3(0xF9102C5Fu, 0x9881FB9Fu, 0x56A1530Du) + 
                    v.c1 * uint3(0x804B722Du, 0x738E50E5u, 0x4FC93C25u) + 
                    v.c2 * uint3(0xCD0445A5u, 0xD2B90D9Bu, 0xD35C9B2Du)) + 0xA10D9E27u;
        }

    }
}
