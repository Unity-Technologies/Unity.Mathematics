// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int2x4 : System.IEquatable<int2x4>, IFormattable
    {
        public int2 c0;
        public int2 c1;
        public int2 c2;
        public int2 c3;

        public static readonly int2x4 zero = new int2x4(0, 0, 0, 0,   0, 0, 0, 0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(int2 c0, int2 c1, int2 c2, int2 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(int m00, int m01, int m02, int m03,
                      int m10, int m11, int m12, int m13)
        { 
            this.c0 = new int2(m00, m10);
            this.c1 = new int2(m01, m11);
            this.c2 = new int2(m02, m12);
            this.c3 = new int2(m03, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(bool v)
        {
            this.c0 = math.select(new int2(0), new int2(1), v);
            this.c1 = math.select(new int2(0), new int2(1), v);
            this.c2 = math.select(new int2(0), new int2(1), v);
            this.c3 = math.select(new int2(0), new int2(1), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(bool2x4 v)
        {
            this.c0 = math.select(new int2(0), new int2(1), v.c0);
            this.c1 = math.select(new int2(0), new int2(1), v.c1);
            this.c2 = math.select(new int2(0), new int2(1), v.c2);
            this.c3 = math.select(new int2(0), new int2(1), v.c3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(uint v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
            this.c2 = (int2)v;
            this.c3 = (int2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(uint2x4 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
            this.c2 = (int2)v.c2;
            this.c3 = (int2)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(float v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
            this.c2 = (int2)v;
            this.c3 = (int2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(float2x4 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
            this.c2 = (int2)v.c2;
            this.c3 = (int2)v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(double v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
            this.c2 = (int2)v;
            this.c3 = (int2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x4(double2x4 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
            this.c2 = (int2)v.c2;
            this.c3 = (int2)v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2x4(int v) { return new int2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(bool v) { return new int2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(bool2x4 v) { return new int2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(uint v) { return new int2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(uint2x4 v) { return new int2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(float v) { return new int2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(float2x4 v) { return new int2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(double v) { return new int2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x4(double2x4 v) { return new int2x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator * (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator * (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator * (int lhs, int2x4 rhs) { return new int2x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator + (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator + (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator + (int lhs, int2x4 rhs) { return new int2x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator - (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator - (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator - (int lhs, int2x4 rhs) { return new int2x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator / (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator / (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator / (int lhs, int2x4 rhs) { return new int2x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator % (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator % (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator % (int lhs, int2x4 rhs) { return new int2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ++ (int2x4 val) { return new int2x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator -- (int2x4 val) { return new int2x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (int lhs, int2x4 rhs) { return new bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (int lhs, int2x4 rhs) { return new bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (int lhs, int2x4 rhs) { return new bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (int lhs, int2x4 rhs) { return new bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator - (int2x4 val) { return new int2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator + (int2x4 val) { return new int2x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator << (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs, lhs.c3 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator >> (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs, lhs.c3 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (int lhs, int2x4 rhs) { return new bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (int2x4 lhs, int2x4 rhs) { return new bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (int2x4 lhs, int rhs) { return new bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (int lhs, int2x4 rhs) { return new bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ~ (int2x4 val) { return new int2x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator & (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator & (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator & (int lhs, int2x4 rhs) { return new int2x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator | (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator | (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator | (int lhs, int2x4 rhs) { return new int2x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ^ (int2x4 lhs, int2x4 rhs) { return new int2x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ^ (int2x4 lhs, int rhs) { return new int2x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 operator ^ (int lhs, int2x4 rhs) { return new int2x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }

        // [int index] 
        unsafe public int2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (int2x4* array = &this) { return ((int2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (int2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(int2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((int2x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(int2 c0, int2 c1, int2 c2, int2 c3) { return new int2x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(int m00, int m01, int m02, int m03,
                                    int m10, int m11, int m12, int m13)
        {
            return new int2x4(m00, m01, m02, m03,
                              m10, m11, m12, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(int v) { return new int2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(bool v) { return new int2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(bool2x4 v) { return new int2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(uint v) { return new int2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(uint2x4 v) { return new int2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(float v) { return new int2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(float2x4 v) { return new int2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(double v) { return new int2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x4 int2x4(double2x4 v) { return new int2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4x2 transpose(int2x4 v)
        {
            return int4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int2x4 v)
        {
            return csum(asuint(v.c0) * uint2(0xD24EFA19u, 0x7D8048BBu) + 
                        asuint(v.c1) * uint2(0x713BD06Fu, 0x753AD6ADu) + 
                        asuint(v.c2) * uint2(0xD19764C7u, 0xB5D0BF63u) + 
                        asuint(v.c3) * uint2(0xF9102C5Fu, 0x9881FB9Fu)) + 0x56A1530Du;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(int2x4 v)
        {
            return (asuint(v.c0) * uint2(0x804B722Du, 0x738E50E5u) + 
                    asuint(v.c1) * uint2(0x4FC93C25u, 0xCD0445A5u) + 
                    asuint(v.c2) * uint2(0xD2B90D9Bu, 0xD35C9B2Du) + 
                    asuint(v.c3) * uint2(0xA10D9E27u, 0x568DAAA9u)) + 0x7530254Fu;
        }

    }
}
