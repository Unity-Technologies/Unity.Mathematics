// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int3x3 : System.IEquatable<int3x3>, IFormattable
    {
        public int3 c0;
        public int3 c1;
        public int3 c2;

        public static readonly int3x3 identity = new int3x3(1, 0, 0,   0, 1, 0,   0, 0, 1);
        public static readonly int3x3 zero = new int3x3(0, 0, 0,   0, 0, 0,   0, 0, 0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(int3 c0, int3 c1, int3 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(int m00, int m01, int m02,
                      int m10, int m11, int m12,
                      int m20, int m21, int m22)
        { 
            this.c0 = new int3(m00, m10, m20);
            this.c1 = new int3(m01, m11, m21);
            this.c2 = new int3(m02, m12, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(bool v)
        {
            this.c0 = math.select(new int3(0), new int3(1), v);
            this.c1 = math.select(new int3(0), new int3(1), v);
            this.c2 = math.select(new int3(0), new int3(1), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(bool3x3 v)
        {
            this.c0 = math.select(new int3(0), new int3(1), v.c0);
            this.c1 = math.select(new int3(0), new int3(1), v.c1);
            this.c2 = math.select(new int3(0), new int3(1), v.c2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(uint v)
        {
            this.c0 = (int3)v;
            this.c1 = (int3)v;
            this.c2 = (int3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(uint3x3 v)
        {
            this.c0 = (int3)v.c0;
            this.c1 = (int3)v.c1;
            this.c2 = (int3)v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(float v)
        {
            this.c0 = (int3)v;
            this.c1 = (int3)v;
            this.c2 = (int3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(float3x3 v)
        {
            this.c0 = (int3)v.c0;
            this.c1 = (int3)v.c1;
            this.c2 = (int3)v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(double v)
        {
            this.c0 = (int3)v;
            this.c1 = (int3)v;
            this.c2 = (int3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x3(double3x3 v)
        {
            this.c0 = (int3)v.c0;
            this.c1 = (int3)v.c1;
            this.c2 = (int3)v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3x3(int v) { return new int3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x3(bool v) { return new int3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x3(bool3x3 v) { return new int3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x3(uint v) { return new int3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x3(uint3x3 v) { return new int3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x3(float v) { return new int3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x3(float3x3 v) { return new int3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x3(double v) { return new int3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x3(double3x3 v) { return new int3x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator * (int3x3 lhs, int3x3 rhs) { return new int3x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator * (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator * (int lhs, int3x3 rhs) { return new int3x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator + (int3x3 lhs, int3x3 rhs) { return new int3x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator + (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator + (int lhs, int3x3 rhs) { return new int3x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator - (int3x3 lhs, int3x3 rhs) { return new int3x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator - (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator - (int lhs, int3x3 rhs) { return new int3x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator / (int3x3 lhs, int3x3 rhs) { return new int3x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator / (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator / (int lhs, int3x3 rhs) { return new int3x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator % (int3x3 lhs, int3x3 rhs) { return new int3x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator % (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator % (int lhs, int3x3 rhs) { return new int3x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator ++ (int3x3 val) { return new int3x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator -- (int3x3 val) { return new int3x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (int3x3 lhs, int3x3 rhs) { return new bool3x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (int3x3 lhs, int rhs) { return new bool3x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (int lhs, int3x3 rhs) { return new bool3x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (int3x3 lhs, int3x3 rhs) { return new bool3x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (int3x3 lhs, int rhs) { return new bool3x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (int lhs, int3x3 rhs) { return new bool3x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (int3x3 lhs, int3x3 rhs) { return new bool3x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (int3x3 lhs, int rhs) { return new bool3x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (int lhs, int3x3 rhs) { return new bool3x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (int3x3 lhs, int3x3 rhs) { return new bool3x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (int3x3 lhs, int rhs) { return new bool3x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (int lhs, int3x3 rhs) { return new bool3x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator - (int3x3 val) { return new int3x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator + (int3x3 val) { return new int3x3 (+val.c0, +val.c1, +val.c2); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator << (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator >> (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (int3x3 lhs, int3x3 rhs) { return new bool3x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (int3x3 lhs, int rhs) { return new bool3x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (int lhs, int3x3 rhs) { return new bool3x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (int3x3 lhs, int3x3 rhs) { return new bool3x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (int3x3 lhs, int rhs) { return new bool3x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (int lhs, int3x3 rhs) { return new bool3x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator ~ (int3x3 val) { return new int3x3 (~val.c0, ~val.c1, ~val.c2); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator & (int3x3 lhs, int3x3 rhs) { return new int3x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator & (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator & (int lhs, int3x3 rhs) { return new int3x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator | (int3x3 lhs, int3x3 rhs) { return new int3x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator | (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator | (int lhs, int3x3 rhs) { return new int3x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator ^ (int3x3 lhs, int3x3 rhs) { return new int3x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator ^ (int3x3 lhs, int rhs) { return new int3x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 operator ^ (int lhs, int3x3 rhs) { return new int3x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }

        // [int index] 
        unsafe public int3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int3x3* array = &this) { return ((int3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(int3x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((int3x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(int3 c0, int3 c1, int3 c2) { return new int3x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(int m00, int m01, int m02,
                                    int m10, int m11, int m12,
                                    int m20, int m21, int m22)
        {
            return new int3x3(m00, m01, m02,
                              m10, m11, m12,
                              m20, m21, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(int v) { return new int3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(bool v) { return new int3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(bool3x3 v) { return new int3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(uint v) { return new int3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(uint3x3 v) { return new int3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(float v) { return new int3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(float3x3 v) { return new int3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(double v) { return new int3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 int3x3(double3x3 v) { return new int3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x3 transpose(int3x3 v)
        {
            return int3x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int determinant(int3x3 m)
        {
            int3 c0 = m.c0;
            int3 c1 = m.c1;
            int3 c2 = m.c2;

            int m00 = c1.y * c2.z - c1.z * c2.y;
            int m01 = c0.y * c2.z - c0.z * c2.y;
            int m02 = c0.y * c1.z - c0.z * c1.y;

            return c0.x * m00 - c1.x * m01 + c2.x * m02;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int3x3 v)
        {
            return csum(asuint(v.c0) * uint3(0x7AA2C2BDu, 0xE16BC89Du, 0x7AA07CD3u) + 
                        asuint(v.c1) * uint3(0xAF642BA9u, 0xA8F2213Bu, 0x9F3FDC37u) + 
                        asuint(v.c2) * uint3(0xAC60D0C3u, 0x9263662Fu, 0xE69626FFu)) + 0xBD010EEBu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(int3x3 v)
        {
            return (asuint(v.c0) * uint3(0x9CEDE1D1u, 0x43BE0B51u, 0xAF836EE1u) + 
                    asuint(v.c1) * uint3(0xB130C137u, 0x54834775u, 0x7C022221u) + 
                    asuint(v.c2) * uint3(0xA2D00EDFu, 0xA8977779u, 0x9F1C739Bu)) + 0x4B1BD187u;
        }

    }
}
