// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int4x4 : System.IEquatable<int4x4>, IFormattable
    {
        public int4 c0;
        public int4 c1;
        public int4 c2;
        public int4 c3;

        public static readonly int4x4 zero = new int4x4(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(int4 c0, int4 c1, int4 c2, int4 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(int m00, int m01, int m02, int m03,
                      int m10, int m11, int m12, int m13,
                      int m20, int m21, int m22, int m23,
                      int m30, int m31, int m32, int m33)
        { 
            this.c0 = new int4(m00, m10, m20, m30);
            this.c1 = new int4(m01, m11, m21, m31);
            this.c2 = new int4(m02, m12, m22, m32);
            this.c3 = new int4(m03, m13, m23, m33);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(uint v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
            this.c2 = (int4)v;
            this.c3 = (int4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(uint4x4 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
            this.c2 = (int4)v.c2;
            this.c3 = (int4)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(float v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
            this.c2 = (int4)v;
            this.c3 = (int4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x4(float4x4 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
            this.c2 = (int4)v.c2;
            this.c3 = (int4)v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4x4(int v) { return new int4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(uint v) { return new int4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(uint4x4 v) { return new int4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(float v) { return new int4x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x4(float4x4 v) { return new int4x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator * (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator * (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator * (int lhs, int4x4 rhs) { return new int4x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator + (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator + (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator + (int lhs, int4x4 rhs) { return new int4x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator - (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator - (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator - (int lhs, int4x4 rhs) { return new int4x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator / (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator / (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator / (int lhs, int4x4 rhs) { return new int4x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator % (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator % (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator % (int lhs, int4x4 rhs) { return new int4x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ++ (int4x4 val) { return new int4x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator -- (int4x4 val) { return new int4x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator < (int lhs, int4x4 rhs) { return new bool4x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator <= (int lhs, int4x4 rhs) { return new bool4x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator > (int lhs, int4x4 rhs) { return new bool4x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator >= (int lhs, int4x4 rhs) { return new bool4x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator - (int4x4 val) { return new int4x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator + (int4x4 val) { return new int4x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator << (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs, lhs.c3 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator >> (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs, lhs.c3 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator == (int lhs, int4x4 rhs) { return new bool4x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (int4x4 lhs, int4x4 rhs) { return new bool4x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (int4x4 lhs, int rhs) { return new bool4x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x4 operator != (int lhs, int4x4 rhs) { return new bool4x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ~ (int4x4 val) { return new int4x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator & (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator & (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator & (int lhs, int4x4 rhs) { return new int4x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator | (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator | (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator | (int lhs, int4x4 rhs) { return new int4x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ^ (int4x4 lhs, int4x4 rhs) { return new int4x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ^ (int4x4 lhs, int rhs) { return new int4x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 operator ^ (int lhs, int4x4 rhs) { return new int4x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }

        // [int index] 
        unsafe public int4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (int4x4* array = &this) { return ((int4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (int4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(int4x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((int4x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z, c0.w, c1.w, c2.w, c3.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider), c3.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(int4 c0, int4 c1, int4 c2, int4 c3) { return new int4x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(int m00, int m01, int m02, int m03,
                                    int m10, int m11, int m12, int m13,
                                    int m20, int m21, int m22, int m23,
                                    int m30, int m31, int m32, int m33)
        {
            return new int4x4(m00, m01, m02, m03,
                              m10, m11, m12, m13,
                              m20, m21, m22, m23,
                              m30, m31, m32, m33);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(int v) { return new int4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(uint v) { return new int4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(uint4x4 v) { return new int4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(float v) { return new int4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x4 int4x4(float4x4 v) { return new int4x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int4x4 v)
        {
            return csum(asuint(v.c0) * uint4(0x9C9F0823u, 0x5A9CA13Bu, 0xAFCDD5EFu, 0xA88D187Du) + 
                        asuint(v.c1) * uint4(0xCF6EBA1Du, 0x9D88E5A1u, 0xEADF0775u, 0x747A9D7Bu) + 
                        asuint(v.c2) * uint4(0x4111F799u, 0xB5F05AF1u, 0xFD80290Bu, 0x8B65ADB7u) + 
                        asuint(v.c3) * uint4(0xDFF4F563u, 0x7069770Du, 0xD1224537u, 0xE99ED6F3u)) + 0x48125549u;
        }

    }
}
