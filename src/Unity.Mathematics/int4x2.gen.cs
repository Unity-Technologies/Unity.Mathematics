// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int4x2 : System.IEquatable<int4x2>, IFormattable
    {
        public int4 c0;
        public int4 c1;

        public static readonly int4x2 zero = new int4x2(0, 0,   0, 0,   0, 0,   0, 0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(int4 c0, int4 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(int m00, int m01,
                      int m10, int m11,
                      int m20, int m21,
                      int m30, int m31)
        { 
            this.c0 = new int4(m00, m10, m20, m30);
            this.c1 = new int4(m01, m11, m21, m31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(bool v)
        {
            this.c0 = math.select(new int4(0), new int4(1), v);
            this.c1 = math.select(new int4(0), new int4(1), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(bool4x2 v)
        {
            this.c0 = math.select(new int4(0), new int4(1), v.c0);
            this.c1 = math.select(new int4(0), new int4(1), v.c1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(uint v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(uint4x2 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(float v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(float4x2 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(double v)
        {
            this.c0 = (int4)v;
            this.c1 = (int4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4x2(double4x2 v)
        {
            this.c0 = (int4)v.c0;
            this.c1 = (int4)v.c1;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int4x2(int v) { return new int4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(bool v) { return new int4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(bool4x2 v) { return new int4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(uint v) { return new int4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(uint4x2 v) { return new int4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(float v) { return new int4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(float4x2 v) { return new int4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(double v) { return new int4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int4x2(double4x2 v) { return new int4x2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator * (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator * (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator * (int lhs, int4x2 rhs) { return new int4x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator + (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator + (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator + (int lhs, int4x2 rhs) { return new int4x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator - (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator - (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator - (int lhs, int4x2 rhs) { return new int4x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator / (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator / (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator / (int lhs, int4x2 rhs) { return new int4x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator % (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator % (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator % (int lhs, int4x2 rhs) { return new int4x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ++ (int4x2 val) { return new int4x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator -- (int4x2 val) { return new int4x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (int lhs, int4x2 rhs) { return new bool4x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (int lhs, int4x2 rhs) { return new bool4x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (int lhs, int4x2 rhs) { return new bool4x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (int lhs, int4x2 rhs) { return new bool4x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator - (int4x2 val) { return new int4x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator + (int4x2 val) { return new int4x2 (+val.c0, +val.c1); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator << (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 << rhs, lhs.c1 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator >> (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 >> rhs, lhs.c1 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (int lhs, int4x2 rhs) { return new bool4x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (int4x2 lhs, int4x2 rhs) { return new bool4x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (int4x2 lhs, int rhs) { return new bool4x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (int lhs, int4x2 rhs) { return new bool4x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ~ (int4x2 val) { return new int4x2 (~val.c0, ~val.c1); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator & (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator & (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 & rhs, lhs.c1 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator & (int lhs, int4x2 rhs) { return new int4x2 (lhs & rhs.c0, lhs & rhs.c1); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator | (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator | (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 | rhs, lhs.c1 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator | (int lhs, int4x2 rhs) { return new int4x2 (lhs | rhs.c0, lhs | rhs.c1); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ^ (int4x2 lhs, int4x2 rhs) { return new int4x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ^ (int4x2 lhs, int rhs) { return new int4x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 operator ^ (int lhs, int4x2 rhs) { return new int4x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }

        // [int index] 
        unsafe public int4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int4x2* array = &this) { return ((int4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(int4x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((int4x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z, c0.w, c1.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(int4 c0, int4 c1) { return new int4x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(int m00, int m01,
                                    int m10, int m11,
                                    int m20, int m21,
                                    int m30, int m31)
        {
            return new int4x2(m00, m01,
                              m10, m11,
                              m20, m21,
                              m30, m31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(int v) { return new int4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(bool v) { return new int4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(bool4x2 v) { return new int4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(uint v) { return new int4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(uint4x2 v) { return new int4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(float v) { return new int4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(float4x2 v) { return new int4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(double v) { return new int4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 int4x2(double4x2 v) { return new int4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 transpose(int4x2 v)
        {
            return int2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int4x2 v)
        {
            return csum(asuint(v.c0) * uint4(0x6E2BF6A9u, 0xCC74B3B7u, 0x83B58237u, 0x833E3E29u) + 
                        asuint(v.c1) * uint4(0xA9D919BFu, 0xC3EC1D97u, 0xB8B208C7u, 0x5D3ED947u)) + 0x4473BBB1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hash_wide(int4x2 v)
        {
            return (asuint(v.c0) * uint4(0xCBA11D5Fu, 0x685835CFu, 0xC3D32AE1u, 0xB966942Fu) + 
                    asuint(v.c1) * uint4(0xFE9856B3u, 0xFA3A3285u, 0xAD55999Du, 0xDCDD5341u)) + 0x94DDD769u;
        }

    }
}
