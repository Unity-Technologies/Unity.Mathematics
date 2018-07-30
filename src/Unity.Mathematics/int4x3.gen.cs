// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int4x3 : System.IEquatable<int4x3>, IFormattable
    {
        public int4 c0;
        public int4 c1;
        public int4 c2;

        public static readonly int4x3 zero = new int4x3(0, 0, 0,   0, 0, 0,   0, 0, 0,   0, 0, 0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x3(int4 c0, int4 c1, int4 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x3(int m00, int m01, int m02,
                      int m10, int m11, int m12,
                      int m20, int m21, int m22,
                      int m30, int m31, int m32)
        { 
            this.c0 = new int4(m00, m10, m20, m30);
            this.c1 = new int4(m01, m11, m21, m31);
            this.c2 = new int4(m02, m12, m22, m32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x3(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x3(uint v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
            this.c2 = (int4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x3(uint4x3 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
            this.c2 = (int4)v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x3(float v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
            this.c2 = (int4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x3(float4x3 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
            this.c2 = (int4)v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4x3(int v) { return new int4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x3(uint v) { return new int4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x3(uint4x3 v) { return new int4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x3(float v) { return new int4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x3(float4x3 v) { return new int4x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator * (int4x3 lhs, int4x3 rhs) { return new int4x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator * (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator * (int lhs, int4x3 rhs) { return new int4x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator + (int4x3 lhs, int4x3 rhs) { return new int4x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator + (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator + (int lhs, int4x3 rhs) { return new int4x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator - (int4x3 lhs, int4x3 rhs) { return new int4x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator - (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator - (int lhs, int4x3 rhs) { return new int4x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator / (int4x3 lhs, int4x3 rhs) { return new int4x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator / (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator / (int lhs, int4x3 rhs) { return new int4x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator % (int4x3 lhs, int4x3 rhs) { return new int4x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator % (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator % (int lhs, int4x3 rhs) { return new int4x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator ++ (int4x3 val) { return new int4x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator -- (int4x3 val) { return new int4x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (int4x3 lhs, int4x3 rhs) { return new bool4x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (int4x3 lhs, int rhs) { return new bool4x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (int lhs, int4x3 rhs) { return new bool4x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (int4x3 lhs, int4x3 rhs) { return new bool4x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (int4x3 lhs, int rhs) { return new bool4x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (int lhs, int4x3 rhs) { return new bool4x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (int4x3 lhs, int4x3 rhs) { return new bool4x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (int4x3 lhs, int rhs) { return new bool4x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (int lhs, int4x3 rhs) { return new bool4x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (int4x3 lhs, int4x3 rhs) { return new bool4x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (int4x3 lhs, int rhs) { return new bool4x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (int lhs, int4x3 rhs) { return new bool4x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator - (int4x3 val) { return new int4x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator + (int4x3 val) { return new int4x3 (+val.c0, +val.c1, +val.c2); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator << (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator >> (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (int4x3 lhs, int4x3 rhs) { return new bool4x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (int4x3 lhs, int rhs) { return new bool4x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (int lhs, int4x3 rhs) { return new bool4x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (int4x3 lhs, int4x3 rhs) { return new bool4x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (int4x3 lhs, int rhs) { return new bool4x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (int lhs, int4x3 rhs) { return new bool4x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator ~ (int4x3 val) { return new int4x3 (~val.c0, ~val.c1, ~val.c2); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator & (int4x3 lhs, int4x3 rhs) { return new int4x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator & (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator & (int lhs, int4x3 rhs) { return new int4x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator | (int4x3 lhs, int4x3 rhs) { return new int4x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator | (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator | (int lhs, int4x3 rhs) { return new int4x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator ^ (int4x3 lhs, int4x3 rhs) { return new int4x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator ^ (int4x3 lhs, int rhs) { return new int4x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 operator ^ (int lhs, int4x3 rhs) { return new int4x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }

        // [int index] 
        unsafe public int4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int4x3* array = &this) { return ((int4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(int4x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((int4x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z, c0.w, c1.w, c2.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 int4x3(int4 c0, int4 c1, int4 c2) { return new int4x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 int4x3(int m00, int m01, int m02,
                                    int m10, int m11, int m12,
                                    int m20, int m21, int m22,
                                    int m30, int m31, int m32)
        {
            return new int4x3(m00, m01, m02,
                              m10, m11, m12,
                              m20, m21, m22,
                              m30, m31, m32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 int4x3(int v) { return new int4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 int4x3(uint v) { return new int4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 int4x3(uint4x3 v) { return new int4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 int4x3(float v) { return new int4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 int4x3(float4x3 v) { return new int4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int4x3 v)
        {
            return csum(asuint(v.c0) * uint4(0x7F3DD499u, 0x52EAAEBBu, 0x4599C793u, 0x83B5E729u) + 
                        asuint(v.c1) * uint4(0xC267163Fu, 0x67BC9149u, 0xAD7C5EC1u, 0x822A7D6Du) + 
                        asuint(v.c2) * uint4(0xB492BF15u, 0xD37220E3u, 0x7AA2C2BDu, 0xE16BC89Du)) + 0x7AA07CD3u;
        }

    }
}
