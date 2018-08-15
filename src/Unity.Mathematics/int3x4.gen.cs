// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int3x4 : System.IEquatable<int3x4>, IFormattable
    {
        public int3 c0;
        public int3 c1;
        public int3 c2;
        public int3 c3;

        public static readonly int3x4 zero = new int3x4(0, 0, 0, 0,   0, 0, 0, 0,   0, 0, 0, 0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(int3 c0, int3 c1, int3 c2, int3 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(int m00, int m01, int m02, int m03,
                      int m10, int m11, int m12, int m13,
                      int m20, int m21, int m22, int m23)
        { 
            this.c0 = new int3(m00, m10, m20);
            this.c1 = new int3(m01, m11, m21);
            this.c2 = new int3(m02, m12, m22);
            this.c3 = new int3(m03, m13, m23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(bool v)
        {
            this.c0 = math.select(new int3(0), new int3(1), v);
            this.c1 = math.select(new int3(0), new int3(1), v);
            this.c2 = math.select(new int3(0), new int3(1), v);
            this.c3 = math.select(new int3(0), new int3(1), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(bool3x4 v)
        {
            this.c0 = math.select(new int3(0), new int3(1), v.c0);
            this.c1 = math.select(new int3(0), new int3(1), v.c1);
            this.c2 = math.select(new int3(0), new int3(1), v.c2);
            this.c3 = math.select(new int3(0), new int3(1), v.c3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(uint v)
        {
            this.c0 = (int3)v;
            this.c1 = (int3)v;
            this.c2 = (int3)v;
            this.c3 = (int3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(uint3x4 v)
        {
            this.c0 = (int3)v.c0;
            this.c1 = (int3)v.c1;
            this.c2 = (int3)v.c2;
            this.c3 = (int3)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(float v)
        {
            this.c0 = (int3)v;
            this.c1 = (int3)v;
            this.c2 = (int3)v;
            this.c3 = (int3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(float3x4 v)
        {
            this.c0 = (int3)v.c0;
            this.c1 = (int3)v.c1;
            this.c2 = (int3)v.c2;
            this.c3 = (int3)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(double v)
        {
            this.c0 = (int3)v;
            this.c1 = (int3)v;
            this.c2 = (int3)v;
            this.c3 = (int3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x4(double3x4 v)
        {
            this.c0 = (int3)v.c0;
            this.c1 = (int3)v.c1;
            this.c2 = (int3)v.c2;
            this.c3 = (int3)v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3x4(int v) { return new int3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x4(bool v) { return new int3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x4(bool3x4 v) { return new int3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x4(uint v) { return new int3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x4(uint3x4 v) { return new int3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x4(float v) { return new int3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x4(float3x4 v) { return new int3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x4(double v) { return new int3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x4(double3x4 v) { return new int3x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator * (int3x4 lhs, int3x4 rhs) { return new int3x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator * (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator * (int lhs, int3x4 rhs) { return new int3x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator + (int3x4 lhs, int3x4 rhs) { return new int3x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator + (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator + (int lhs, int3x4 rhs) { return new int3x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator - (int3x4 lhs, int3x4 rhs) { return new int3x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator - (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator - (int lhs, int3x4 rhs) { return new int3x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator / (int3x4 lhs, int3x4 rhs) { return new int3x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator / (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator / (int lhs, int3x4 rhs) { return new int3x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator % (int3x4 lhs, int3x4 rhs) { return new int3x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator % (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator % (int lhs, int3x4 rhs) { return new int3x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator ++ (int3x4 val) { return new int3x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator -- (int3x4 val) { return new int3x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (int3x4 lhs, int3x4 rhs) { return new bool3x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (int3x4 lhs, int rhs) { return new bool3x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (int lhs, int3x4 rhs) { return new bool3x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (int3x4 lhs, int3x4 rhs) { return new bool3x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (int3x4 lhs, int rhs) { return new bool3x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (int lhs, int3x4 rhs) { return new bool3x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (int3x4 lhs, int3x4 rhs) { return new bool3x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (int3x4 lhs, int rhs) { return new bool3x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (int lhs, int3x4 rhs) { return new bool3x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (int3x4 lhs, int3x4 rhs) { return new bool3x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (int3x4 lhs, int rhs) { return new bool3x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (int lhs, int3x4 rhs) { return new bool3x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator - (int3x4 val) { return new int3x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator + (int3x4 val) { return new int3x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator << (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs, lhs.c3 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator >> (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs, lhs.c3 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (int3x4 lhs, int3x4 rhs) { return new bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (int3x4 lhs, int rhs) { return new bool3x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (int lhs, int3x4 rhs) { return new bool3x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (int3x4 lhs, int3x4 rhs) { return new bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (int3x4 lhs, int rhs) { return new bool3x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (int lhs, int3x4 rhs) { return new bool3x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator ~ (int3x4 val) { return new int3x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator & (int3x4 lhs, int3x4 rhs) { return new int3x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator & (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator & (int lhs, int3x4 rhs) { return new int3x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator | (int3x4 lhs, int3x4 rhs) { return new int3x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator | (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator | (int lhs, int3x4 rhs) { return new int3x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator ^ (int3x4 lhs, int3x4 rhs) { return new int3x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator ^ (int3x4 lhs, int rhs) { return new int3x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 operator ^ (int lhs, int3x4 rhs) { return new int3x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }

        // [int index] 
        unsafe public int3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (int3x4* array = &this) { return ((int3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (int3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(int3x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((int3x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(int3 c0, int3 c1, int3 c2, int3 c3) { return new int3x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(int m00, int m01, int m02, int m03,
                                    int m10, int m11, int m12, int m13,
                                    int m20, int m21, int m22, int m23)
        {
            return new int3x4(m00, m01, m02, m03,
                              m10, m11, m12, m13,
                              m20, m21, m22, m23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(int v) { return new int3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(bool v) { return new int3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(bool3x4 v) { return new int3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(uint v) { return new int3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(uint3x4 v) { return new int3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(float v) { return new int3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(float3x4 v) { return new int3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(double v) { return new int3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x4 int3x4(double3x4 v) { return new int3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x3 transpose(int3x4 v)
        {
            return int4x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z,
                v.c3.x, v.c3.y, v.c3.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int3x4 v)
        {
            return csum(asuint(v.c0) * uint3(0xAFCDD5EFu, 0xA88D187Du, 0xCF6EBA1Du) + 
                        asuint(v.c1) * uint3(0x9D88E5A1u, 0xEADF0775u, 0x747A9D7Bu) + 
                        asuint(v.c2) * uint3(0x4111F799u, 0xB5F05AF1u, 0xFD80290Bu) + 
                        asuint(v.c3) * uint3(0x8B65ADB7u, 0xDFF4F563u, 0x7069770Du)) + 0xD1224537u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(int3x4 v)
        {
            return (asuint(v.c0) * uint3(0xE99ED6F3u, 0x48125549u, 0xEEE2123Bu) + 
                    asuint(v.c1) * uint3(0xE3AD9FE5u, 0xCE1CF8BFu, 0x7BE39F3Bu) + 
                    asuint(v.c2) * uint3(0xFAB9913Fu, 0xB4501269u, 0xE04B89FDu) + 
                    asuint(v.c3) * uint3(0xDB3DE101u, 0x7B6D1B4Bu, 0x58399E77u)) + 0x5EAC29C9u;
        }

    }
}
