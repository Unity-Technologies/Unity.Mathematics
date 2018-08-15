// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint2x4 : System.IEquatable<uint2x4>, IFormattable
    {
        public uint2 c0;
        public uint2 c1;
        public uint2 c2;
        public uint2 c3;

        public static readonly uint2x4 zero = new uint2x4(0u, 0u, 0u, 0u,   0u, 0u, 0u, 0u);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(uint m00, uint m01, uint m02, uint m03,
                       uint m10, uint m11, uint m12, uint m13)
        { 
            this.c0 = new uint2(m00, m10);
            this.c1 = new uint2(m01, m11);
            this.c2 = new uint2(m02, m12);
            this.c3 = new uint2(m03, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(bool v)
        {
            this.c0 = math.select(new uint2(0u), new uint2(1u), v);
            this.c1 = math.select(new uint2(0u), new uint2(1u), v);
            this.c2 = math.select(new uint2(0u), new uint2(1u), v);
            this.c3 = math.select(new uint2(0u), new uint2(1u), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(bool2x4 v)
        {
            this.c0 = math.select(new uint2(0u), new uint2(1u), v.c0);
            this.c1 = math.select(new uint2(0u), new uint2(1u), v.c1);
            this.c2 = math.select(new uint2(0u), new uint2(1u), v.c2);
            this.c3 = math.select(new uint2(0u), new uint2(1u), v.c3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(int v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
            this.c2 = (uint2)v;
            this.c3 = (uint2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(int2x4 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
            this.c2 = (uint2)v.c2;
            this.c3 = (uint2)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(float v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
            this.c2 = (uint2)v;
            this.c3 = (uint2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(float2x4 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
            this.c2 = (uint2)v.c2;
            this.c3 = (uint2)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(double v)
        {
            this.c0 = (uint2)v;
            this.c1 = (uint2)v;
            this.c2 = (uint2)v;
            this.c3 = (uint2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2x4(double2x4 v)
        {
            this.c0 = (uint2)v.c0;
            this.c1 = (uint2)v.c1;
            this.c2 = (uint2)v.c2;
            this.c3 = (uint2)v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2x4(uint v) { return new uint2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x4(bool v) { return new uint2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x4(bool2x4 v) { return new uint2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x4(int v) { return new uint2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x4(int2x4 v) { return new uint2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x4(float v) { return new uint2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x4(float2x4 v) { return new uint2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x4(double v) { return new uint2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2x4(double2x4 v) { return new uint2x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator * (uint2x4 lhs, uint2x4 rhs) { return new uint2x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator * (uint2x4 lhs, uint rhs) { return new uint2x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator * (uint lhs, uint2x4 rhs) { return new uint2x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator + (uint2x4 lhs, uint2x4 rhs) { return new uint2x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator + (uint2x4 lhs, uint rhs) { return new uint2x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator + (uint lhs, uint2x4 rhs) { return new uint2x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator - (uint2x4 lhs, uint2x4 rhs) { return new uint2x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator - (uint2x4 lhs, uint rhs) { return new uint2x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator - (uint lhs, uint2x4 rhs) { return new uint2x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator / (uint2x4 lhs, uint2x4 rhs) { return new uint2x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator / (uint2x4 lhs, uint rhs) { return new uint2x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator / (uint lhs, uint2x4 rhs) { return new uint2x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator % (uint2x4 lhs, uint2x4 rhs) { return new uint2x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator % (uint2x4 lhs, uint rhs) { return new uint2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator % (uint lhs, uint2x4 rhs) { return new uint2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator ++ (uint2x4 val) { return new uint2x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator -- (uint2x4 val) { return new uint2x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (uint2x4 lhs, uint2x4 rhs) { return new bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (uint2x4 lhs, uint rhs) { return new bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (uint lhs, uint2x4 rhs) { return new bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (uint2x4 lhs, uint2x4 rhs) { return new bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (uint2x4 lhs, uint rhs) { return new bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (uint lhs, uint2x4 rhs) { return new bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (uint2x4 lhs, uint2x4 rhs) { return new bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (uint2x4 lhs, uint rhs) { return new bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (uint lhs, uint2x4 rhs) { return new bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (uint2x4 lhs, uint2x4 rhs) { return new bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (uint2x4 lhs, uint rhs) { return new bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (uint lhs, uint2x4 rhs) { return new bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator - (uint2x4 val) { return new uint2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator + (uint2x4 val) { return new uint2x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator << (uint2x4 lhs, int rhs) { return new uint2x4 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs, lhs.c3 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator >> (uint2x4 lhs, int rhs) { return new uint2x4 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs, lhs.c3 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (uint2x4 lhs, uint2x4 rhs) { return new bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (uint2x4 lhs, uint rhs) { return new bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (uint lhs, uint2x4 rhs) { return new bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (uint2x4 lhs, uint2x4 rhs) { return new bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (uint2x4 lhs, uint rhs) { return new bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (uint lhs, uint2x4 rhs) { return new bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator ~ (uint2x4 val) { return new uint2x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator & (uint2x4 lhs, uint2x4 rhs) { return new uint2x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator & (uint2x4 lhs, uint rhs) { return new uint2x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator & (uint lhs, uint2x4 rhs) { return new uint2x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator | (uint2x4 lhs, uint2x4 rhs) { return new uint2x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator | (uint2x4 lhs, uint rhs) { return new uint2x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator | (uint lhs, uint2x4 rhs) { return new uint2x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator ^ (uint2x4 lhs, uint2x4 rhs) { return new uint2x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator ^ (uint2x4 lhs, uint rhs) { return new uint2x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 operator ^ (uint lhs, uint2x4 rhs) { return new uint2x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }

        // [int index] 
        unsafe public uint2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (uint2x4* array = &this) { return ((uint2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (uint2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(uint2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((uint2x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(uint2 c0, uint2 c1, uint2 c2, uint2 c3) { return new uint2x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(uint m00, uint m01, uint m02, uint m03,
                                      uint m10, uint m11, uint m12, uint m13)
        {
            return new uint2x4(m00, m01, m02, m03,
                               m10, m11, m12, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(uint v) { return new uint2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(bool v) { return new uint2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(bool2x4 v) { return new uint2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(int v) { return new uint2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(int2x4 v) { return new uint2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(float v) { return new uint2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(float2x4 v) { return new uint2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(double v) { return new uint2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 uint2x4(double2x4 v) { return new uint2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 transpose(uint2x4 v)
        {
            return uint4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint2x4 v)
        {
            return csum(v.c0 * uint2(0x9F090439u, 0x5E9F85C9u) + 
                        v.c1 * uint2(0x8C4CA03Fu, 0xB8D969EDu) + 
                        v.c2 * uint2(0xAC5DB57Bu, 0xA91A02EDu) + 
                        v.c3 * uint2(0xB3C49313u, 0xF43A9ABBu)) + 0x84E7E01Bu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(uint2x4 v)
        {
            return (v.c0 * uint2(0x8E055BE5u, 0x6E624EB7u) + 
                    v.c1 * uint2(0x7383ED49u, 0xDD49C23Bu) + 
                    v.c2 * uint2(0xEBD0D005u, 0x91475DF7u) + 
                    v.c3 * uint2(0x55E84827u, 0x90A285BBu)) + 0x5D19E1D5u;
        }

    }
}
