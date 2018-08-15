// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint3x4 : System.IEquatable<uint3x4>, IFormattable
    {
        public uint3 c0;
        public uint3 c1;
        public uint3 c2;
        public uint3 c3;

        public static readonly uint3x4 zero = new uint3x4(0u, 0u, 0u, 0u,   0u, 0u, 0u, 0u,   0u, 0u, 0u, 0u);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(uint m00, uint m01, uint m02, uint m03,
                       uint m10, uint m11, uint m12, uint m13,
                       uint m20, uint m21, uint m22, uint m23)
        { 
            this.c0 = new uint3(m00, m10, m20);
            this.c1 = new uint3(m01, m11, m21);
            this.c2 = new uint3(m02, m12, m22);
            this.c3 = new uint3(m03, m13, m23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(bool v)
        {
            this.c0 = math.select(new uint3(0u), new uint3(1u), v);
            this.c1 = math.select(new uint3(0u), new uint3(1u), v);
            this.c2 = math.select(new uint3(0u), new uint3(1u), v);
            this.c3 = math.select(new uint3(0u), new uint3(1u), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(bool3x4 v)
        {
            this.c0 = math.select(new uint3(0u), new uint3(1u), v.c0);
            this.c1 = math.select(new uint3(0u), new uint3(1u), v.c1);
            this.c2 = math.select(new uint3(0u), new uint3(1u), v.c2);
            this.c3 = math.select(new uint3(0u), new uint3(1u), v.c3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(int v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
            this.c2 = (uint3)v;
            this.c3 = (uint3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(int3x4 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
            this.c2 = (uint3)v.c2;
            this.c3 = (uint3)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(float v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
            this.c2 = (uint3)v;
            this.c3 = (uint3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(float3x4 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
            this.c2 = (uint3)v.c2;
            this.c3 = (uint3)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(double v)
        {
            this.c0 = (uint3)v;
            this.c1 = (uint3)v;
            this.c2 = (uint3)v;
            this.c3 = (uint3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x4(double3x4 v)
        {
            this.c0 = (uint3)v.c0;
            this.c1 = (uint3)v.c1;
            this.c2 = (uint3)v.c2;
            this.c3 = (uint3)v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint3x4(uint v) { return new uint3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x4(bool v) { return new uint3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x4(bool3x4 v) { return new uint3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x4(int v) { return new uint3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x4(int3x4 v) { return new uint3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x4(float v) { return new uint3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x4(float3x4 v) { return new uint3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x4(double v) { return new uint3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint3x4(double3x4 v) { return new uint3x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator * (uint3x4 lhs, uint3x4 rhs) { return new uint3x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator * (uint3x4 lhs, uint rhs) { return new uint3x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator * (uint lhs, uint3x4 rhs) { return new uint3x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator + (uint3x4 lhs, uint3x4 rhs) { return new uint3x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator + (uint3x4 lhs, uint rhs) { return new uint3x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator + (uint lhs, uint3x4 rhs) { return new uint3x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator - (uint3x4 lhs, uint3x4 rhs) { return new uint3x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator - (uint3x4 lhs, uint rhs) { return new uint3x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator - (uint lhs, uint3x4 rhs) { return new uint3x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator / (uint3x4 lhs, uint3x4 rhs) { return new uint3x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator / (uint3x4 lhs, uint rhs) { return new uint3x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator / (uint lhs, uint3x4 rhs) { return new uint3x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator % (uint3x4 lhs, uint3x4 rhs) { return new uint3x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator % (uint3x4 lhs, uint rhs) { return new uint3x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator % (uint lhs, uint3x4 rhs) { return new uint3x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator ++ (uint3x4 val) { return new uint3x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator -- (uint3x4 val) { return new uint3x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (uint3x4 lhs, uint3x4 rhs) { return new bool3x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (uint3x4 lhs, uint rhs) { return new bool3x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (uint lhs, uint3x4 rhs) { return new bool3x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (uint3x4 lhs, uint3x4 rhs) { return new bool3x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (uint3x4 lhs, uint rhs) { return new bool3x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (uint lhs, uint3x4 rhs) { return new bool3x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (uint3x4 lhs, uint3x4 rhs) { return new bool3x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (uint3x4 lhs, uint rhs) { return new bool3x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (uint lhs, uint3x4 rhs) { return new bool3x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (uint3x4 lhs, uint3x4 rhs) { return new bool3x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (uint3x4 lhs, uint rhs) { return new bool3x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (uint lhs, uint3x4 rhs) { return new bool3x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator - (uint3x4 val) { return new uint3x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator + (uint3x4 val) { return new uint3x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator << (uint3x4 lhs, int rhs) { return new uint3x4 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs, lhs.c3 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator >> (uint3x4 lhs, int rhs) { return new uint3x4 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs, lhs.c3 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (uint3x4 lhs, uint3x4 rhs) { return new bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (uint3x4 lhs, uint rhs) { return new bool3x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (uint lhs, uint3x4 rhs) { return new bool3x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (uint3x4 lhs, uint3x4 rhs) { return new bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (uint3x4 lhs, uint rhs) { return new bool3x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (uint lhs, uint3x4 rhs) { return new bool3x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator ~ (uint3x4 val) { return new uint3x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator & (uint3x4 lhs, uint3x4 rhs) { return new uint3x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator & (uint3x4 lhs, uint rhs) { return new uint3x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator & (uint lhs, uint3x4 rhs) { return new uint3x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator | (uint3x4 lhs, uint3x4 rhs) { return new uint3x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator | (uint3x4 lhs, uint rhs) { return new uint3x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator | (uint lhs, uint3x4 rhs) { return new uint3x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator ^ (uint3x4 lhs, uint3x4 rhs) { return new uint3x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator ^ (uint3x4 lhs, uint rhs) { return new uint3x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 operator ^ (uint lhs, uint3x4 rhs) { return new uint3x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }

        // [int index] 
        unsafe public uint3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (uint3x4* array = &this) { return ((uint3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (uint3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(uint3x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((uint3x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(uint3 c0, uint3 c1, uint3 c2, uint3 c3) { return new uint3x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(uint m00, uint m01, uint m02, uint m03,
                                      uint m10, uint m11, uint m12, uint m13,
                                      uint m20, uint m21, uint m22, uint m23)
        {
            return new uint3x4(m00, m01, m02, m03,
                               m10, m11, m12, m13,
                               m20, m21, m22, m23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(uint v) { return new uint3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(bool v) { return new uint3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(bool3x4 v) { return new uint3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(int v) { return new uint3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(int3x4 v) { return new uint3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(float v) { return new uint3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(float3x4 v) { return new uint3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(double v) { return new uint3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x4 uint3x4(double3x4 v) { return new uint3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x3 transpose(uint3x4 v)
        {
            return uint4x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z,
                v.c3.x, v.c3.y, v.c3.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint3x4 v)
        {
            return csum(v.c0 * uint3(0xFC6014F9u, 0x6BF6693Fu, 0x9D1B1D9Bu) + 
                        v.c1 * uint3(0xF842F5C1u, 0xA47EC335u, 0xA477DF57u) + 
                        v.c2 * uint3(0xC4B1493Fu, 0xBA0966D3u, 0xAFBEE253u) + 
                        v.c3 * uint3(0x5B419C01u, 0x515D90F5u, 0xEC9F68F3u)) + 0xF9EA92D5u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(uint3x4 v)
        {
            return (v.c0 * uint3(0xC2FAFCB9u, 0x616E9CA1u, 0xC5C5394Bu) + 
                    v.c1 * uint3(0xCAE78587u, 0x7A1541C9u, 0xF83BD927u) + 
                    v.c2 * uint3(0x6A243BCBu, 0x509B84C9u, 0x91D13847u) + 
                    v.c3 * uint3(0x52F7230Fu, 0xCF286E83u, 0xE121E6ADu)) + 0xC9CA1249u;
        }

    }
}
