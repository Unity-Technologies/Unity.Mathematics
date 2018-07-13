// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint4x4 : System.IEquatable<uint4x4>, IFormattable
    {
        public uint4 c0;
        public uint4 c1;
        public uint4 c2;
        public uint4 c3;

        public static readonly uint4x4 zero = new uint4x4(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x4(uint m00, uint m01, uint m02, uint m03,
                       uint m10, uint m11, uint m12, uint m13,
                       uint m20, uint m21, uint m22, uint m23,
                       uint m30, uint m31, uint m32, uint m33)
        { 
            this.c0 = new uint4(m00, m10, m20, m30);
            this.c1 = new uint4(m01, m11, m21, m31);
            this.c2 = new uint4(m02, m12, m22, m32);
            this.c3 = new uint4(m03, m13, m23, m33);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x4(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x4(int v)
        {
            this.c0 = (uint4)v;
            this.c1 = (uint4)v;
            this.c2 = (uint4)v;
            this.c3 = (uint4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x4(int4x4 v)
        {
            this.c0 = (uint4)v.c0;
            this.c1 = (uint4)v.c1;
            this.c2 = (uint4)v.c2;
            this.c3 = (uint4)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x4(float v)
        {
            this.c0 = (uint4)v;
            this.c1 = (uint4)v;
            this.c2 = (uint4)v;
            this.c3 = (uint4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x4(float4x4 v)
        {
            this.c0 = (uint4)v.c0;
            this.c1 = (uint4)v.c1;
            this.c2 = (uint4)v.c2;
            this.c3 = (uint4)v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint4x4(uint v) { return new uint4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x4(int v) { return new uint4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x4(int4x4 v) { return new uint4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x4(float v) { return new uint4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x4(float4x4 v) { return new uint4x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator * (uint4x4 lhs, uint4x4 rhs) { return new uint4x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator * (uint4x4 lhs, uint rhs) { return new uint4x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator * (uint lhs, uint4x4 rhs) { return new uint4x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator + (uint4x4 lhs, uint4x4 rhs) { return new uint4x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator + (uint4x4 lhs, uint rhs) { return new uint4x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator + (uint lhs, uint4x4 rhs) { return new uint4x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator - (uint4x4 lhs, uint4x4 rhs) { return new uint4x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator - (uint4x4 lhs, uint rhs) { return new uint4x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator - (uint lhs, uint4x4 rhs) { return new uint4x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator / (uint4x4 lhs, uint4x4 rhs) { return new uint4x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator / (uint4x4 lhs, uint rhs) { return new uint4x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator / (uint lhs, uint4x4 rhs) { return new uint4x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator % (uint4x4 lhs, uint4x4 rhs) { return new uint4x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator % (uint4x4 lhs, uint rhs) { return new uint4x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator % (uint lhs, uint4x4 rhs) { return new uint4x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator ++ (uint4x4 val) { return new uint4x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator -- (uint4x4 val) { return new uint4x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (uint4x4 lhs, uint4x4 rhs) { return new bool4x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (uint4x4 lhs, uint rhs) { return new bool4x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (uint lhs, uint4x4 rhs) { return new bool4x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (uint4x4 lhs, uint4x4 rhs) { return new bool4x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (uint4x4 lhs, uint rhs) { return new bool4x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (uint lhs, uint4x4 rhs) { return new bool4x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (uint4x4 lhs, uint4x4 rhs) { return new bool4x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (uint4x4 lhs, uint rhs) { return new bool4x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (uint lhs, uint4x4 rhs) { return new bool4x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (uint4x4 lhs, uint4x4 rhs) { return new bool4x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (uint4x4 lhs, uint rhs) { return new bool4x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (uint lhs, uint4x4 rhs) { return new bool4x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator - (uint4x4 val) { return new uint4x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator + (uint4x4 val) { return new uint4x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator << (uint4x4 lhs, int rhs) { return new uint4x4 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs, lhs.c3 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator >> (uint4x4 lhs, int rhs) { return new uint4x4 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs, lhs.c3 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (uint4x4 lhs, uint4x4 rhs) { return new bool4x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (uint4x4 lhs, uint rhs) { return new bool4x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (uint lhs, uint4x4 rhs) { return new bool4x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (uint4x4 lhs, uint4x4 rhs) { return new bool4x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (uint4x4 lhs, uint rhs) { return new bool4x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (uint lhs, uint4x4 rhs) { return new bool4x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator ~ (uint4x4 val) { return new uint4x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator & (uint4x4 lhs, uint4x4 rhs) { return new uint4x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator & (uint4x4 lhs, uint rhs) { return new uint4x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator & (uint lhs, uint4x4 rhs) { return new uint4x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator | (uint4x4 lhs, uint4x4 rhs) { return new uint4x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator | (uint4x4 lhs, uint rhs) { return new uint4x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator | (uint lhs, uint4x4 rhs) { return new uint4x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator ^ (uint4x4 lhs, uint4x4 rhs) { return new uint4x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator ^ (uint4x4 lhs, uint rhs) { return new uint4x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 operator ^ (uint lhs, uint4x4 rhs) { return new uint4x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }

        // [int index] 
        unsafe public uint4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (uint4x4* array = &this) { return ((uint4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (uint4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(uint4x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((uint4x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z, c0.w, c1.w, c2.w, c3.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider), c3.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 uint4x4(uint4 c0, uint4 c1, uint4 c2, uint4 c3) { return new uint4x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 uint4x4(uint m00, uint m01, uint m02, uint m03,
                                      uint m10, uint m11, uint m12, uint m13,
                                      uint m20, uint m21, uint m22, uint m23,
                                      uint m30, uint m31, uint m32, uint m33)
        {
            return new uint4x4(m00, m01, m02, m03,
                               m10, m11, m12, m13,
                               m20, m21, m22, m23,
                               m30, m31, m32, m33);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 uint4x4(uint v) { return new uint4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 uint4x4(int v) { return new uint4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 uint4x4(int4x4 v) { return new uint4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 uint4x4(float v) { return new uint4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x4 uint4x4(float4x4 v) { return new uint4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint4x4 v)
        {
            return csum(v.c0 * uint4(0xF62213C5u, 0x9CDAA959u, 0xAA269ABFu, 0xD54BA36Fu) + 
                        v.c1 * uint4(0xFD0847B9u, 0x8189A683u, 0xB139D651u, 0xE7579997u) + 
                        v.c2 * uint4(0xEF7D56C7u, 0x66F38F0Bu, 0x624256A3u, 0x5292ADE1u) + 
                        v.c3 * uint4(0xD2E590E5u, 0xF25BE857u, 0x9BC17CE7u, 0xC8B86851u)) + 0x64095221u;
        }

    }
}
