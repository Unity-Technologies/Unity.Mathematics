// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int2x3 : System.IEquatable<int2x3>, IFormattable
    {
        public int2 c0;
        public int2 c1;
        public int2 c2;

        public static readonly int2x3 zero = new int2x3(0, 0, 0,   0, 0, 0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(int2 c0, int2 c1, int2 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(int m00, int m01, int m02,
                      int m10, int m11, int m12)
        { 
            this.c0 = new int2(m00, m10);
            this.c1 = new int2(m01, m11);
            this.c2 = new int2(m02, m12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(bool v)
        {
            this.c0 = math.select(new int2(0), new int2(1), v);
            this.c1 = math.select(new int2(0), new int2(1), v);
            this.c2 = math.select(new int2(0), new int2(1), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(bool2x3 v)
        {
            this.c0 = math.select(new int2(0), new int2(1), v.c0);
            this.c1 = math.select(new int2(0), new int2(1), v.c1);
            this.c2 = math.select(new int2(0), new int2(1), v.c2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(uint v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
            this.c2 = (int2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(uint2x3 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
            this.c2 = (int2)v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(float v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
            this.c2 = (int2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(float2x3 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
            this.c2 = (int2)v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(double v)
        {
            this.c0 = (int2)v;
            this.c1 = (int2)v;
            this.c2 = (int2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2x3(double2x3 v)
        {
            this.c0 = (int2)v.c0;
            this.c1 = (int2)v.c1;
            this.c2 = (int2)v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int2x3(int v) { return new int2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x3(bool v) { return new int2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x3(bool2x3 v) { return new int2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x3(uint v) { return new int2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x3(uint2x3 v) { return new int2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x3(float v) { return new int2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x3(float2x3 v) { return new int2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x3(double v) { return new int2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int2x3(double2x3 v) { return new int2x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator * (int2x3 lhs, int2x3 rhs) { return new int2x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator * (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator * (int lhs, int2x3 rhs) { return new int2x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator + (int2x3 lhs, int2x3 rhs) { return new int2x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator + (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator + (int lhs, int2x3 rhs) { return new int2x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator - (int2x3 lhs, int2x3 rhs) { return new int2x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator - (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator - (int lhs, int2x3 rhs) { return new int2x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator / (int2x3 lhs, int2x3 rhs) { return new int2x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator / (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator / (int lhs, int2x3 rhs) { return new int2x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator % (int2x3 lhs, int2x3 rhs) { return new int2x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator % (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator % (int lhs, int2x3 rhs) { return new int2x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator ++ (int2x3 val) { return new int2x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator -- (int2x3 val) { return new int2x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (int2x3 lhs, int2x3 rhs) { return new bool2x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (int2x3 lhs, int rhs) { return new bool2x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (int lhs, int2x3 rhs) { return new bool2x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (int2x3 lhs, int2x3 rhs) { return new bool2x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (int2x3 lhs, int rhs) { return new bool2x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (int lhs, int2x3 rhs) { return new bool2x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (int2x3 lhs, int2x3 rhs) { return new bool2x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (int2x3 lhs, int rhs) { return new bool2x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (int lhs, int2x3 rhs) { return new bool2x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (int2x3 lhs, int2x3 rhs) { return new bool2x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (int2x3 lhs, int rhs) { return new bool2x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (int lhs, int2x3 rhs) { return new bool2x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator - (int2x3 val) { return new int2x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator + (int2x3 val) { return new int2x3 (+val.c0, +val.c1, +val.c2); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator << (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator >> (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (int2x3 lhs, int2x3 rhs) { return new bool2x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (int2x3 lhs, int rhs) { return new bool2x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (int lhs, int2x3 rhs) { return new bool2x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (int2x3 lhs, int2x3 rhs) { return new bool2x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (int2x3 lhs, int rhs) { return new bool2x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (int lhs, int2x3 rhs) { return new bool2x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator ~ (int2x3 val) { return new int2x3 (~val.c0, ~val.c1, ~val.c2); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator & (int2x3 lhs, int2x3 rhs) { return new int2x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator & (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator & (int lhs, int2x3 rhs) { return new int2x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator | (int2x3 lhs, int2x3 rhs) { return new int2x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator | (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator | (int lhs, int2x3 rhs) { return new int2x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator ^ (int2x3 lhs, int2x3 rhs) { return new int2x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator ^ (int2x3 lhs, int rhs) { return new int2x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 operator ^ (int lhs, int2x3 rhs) { return new int2x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }

        // [int index] 
        unsafe public int2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int2x3* array = &this) { return ((int2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (int2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(int2x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((int2x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(int2 c0, int2 c1, int2 c2) { return new int2x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(int m00, int m01, int m02,
                                    int m10, int m11, int m12)
        {
            return new int2x3(m00, m01, m02,
                              m10, m11, m12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(int v) { return new int2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(bool v) { return new int2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(bool2x3 v) { return new int2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(uint v) { return new int2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(uint2x3 v) { return new int2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(float v) { return new int2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(float2x3 v) { return new int2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(double v) { return new int2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 int2x3(double2x3 v) { return new int2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 transpose(int2x3 v)
        {
            return int3x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int2x3 v)
        {
            return csum(asuint(v.c0) * uint2(0xEE390C97u, 0x9C8A2F05u) + 
                        asuint(v.c1) * uint2(0x4DDC6509u, 0x7CF083CBu) + 
                        asuint(v.c2) * uint2(0x5C4D6CEDu, 0xF9137117u)) + 0xE857DCE1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(int2x3 v)
        {
            return (asuint(v.c0) * uint2(0xF62213C5u, 0x9CDAA959u) + 
                    asuint(v.c1) * uint2(0xAA269ABFu, 0xD54BA36Fu) + 
                    asuint(v.c2) * uint2(0xFD0847B9u, 0x8189A683u)) + 0xB139D651u;
        }

    }
}
