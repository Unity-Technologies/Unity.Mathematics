// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct int3x2 : System.IEquatable<int3x2>, IFormattable
    {
        public int3 c0;
        public int3 c1;

        /// <summary>int3x2 zero value.</summary>
        public static readonly int3x2 zero = new int3x2(0, 0,   0, 0,   0, 0);


        /// <summary>Constructs a int3x2 matrix from 2 int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(int3 c0, int3 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a int3x2 matrix from 6 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(int m00, int m01,
                      int m10, int m11,
                      int m20, int m21)
        { 
            this.c0 = new int3(m00, m10, m20);
            this.c1 = new int3(m01, m11, m21);
        }

        /// <summary>Constructs a int3x2 matrix constructed from a single int value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a int3x2 matrix from a single bool value by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(bool v)
        {
            this.c0 = math.select(new int3(0), new int3(1), v);
            this.c1 = math.select(new int3(0), new int3(1), v);
        }

        /// <summary>Constructs a int3x2 matrix from a bool3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(bool3x2 v)
        {
            this.c0 = math.select(new int3(0), new int3(1), v.c0);
            this.c1 = math.select(new int3(0), new int3(1), v.c1);
        }

        /// <summary>Constructs a int3x2 matrix from a single uint value by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(uint v)
        {
            this.c0 = (int3)v;
            this.c1 = (int3)v;
        }

        /// <summary>Constructs a int3x2 matrix from a uint3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(uint3x2 v)
        {
            this.c0 = (int3)v.c0;
            this.c1 = (int3)v.c1;
        }

        /// <summary>Constructs a int3x2 matrix from a single float value by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(float v)
        {
            this.c0 = (int3)v;
            this.c1 = (int3)v;
        }

        /// <summary>Constructs a int3x2 matrix from a float3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(float3x2 v)
        {
            this.c0 = (int3)v.c0;
            this.c1 = (int3)v.c1;
        }

        /// <summary>Constructs a int3x2 matrix from a single double value by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(double v)
        {
            this.c0 = (int3)v;
            this.c1 = (int3)v;
        }

        /// <summary>Constructs a int3x2 matrix from a double3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3x2(double3x2 v)
        {
            this.c0 = (int3)v.c0;
            this.c1 = (int3)v.c1;
        }


        /// <summary>Implicitly converts a single int value to a int3x2 matrix by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator int3x2(int v) { return new int3x2(v); }

        /// <summary>Explicitly converts a single bool value to a int3x2 matrix by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x2(bool v) { return new int3x2(v); }

        /// <summary>Explicitly converts a bool3x2 matrix to a int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x2(bool3x2 v) { return new int3x2(v); }

        /// <summary>Explicitly converts a single uint value to a int3x2 matrix by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x2(uint v) { return new int3x2(v); }

        /// <summary>Explicitly converts a uint3x2 matrix to a int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x2(uint3x2 v) { return new int3x2(v); }

        /// <summary>Explicitly converts a single float value to a int3x2 matrix by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x2(float v) { return new int3x2(v); }

        /// <summary>Explicitly converts a float3x2 matrix to a int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x2(float3x2 v) { return new int3x2(v); }

        /// <summary>Explicitly converts a single double value to a int3x2 matrix by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x2(double v) { return new int3x2(v); }

        /// <summary>Explicitly converts a double3x2 matrix to a int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator int3x2(double3x2 v) { return new int3x2(v); }



        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator * (int3x2 lhs, int3x2 rhs) { return new int3x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator * (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator * (int lhs, int3x2 rhs) { return new int3x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator + (int3x2 lhs, int3x2 rhs) { return new int3x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator + (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator + (int lhs, int3x2 rhs) { return new int3x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator - (int3x2 lhs, int3x2 rhs) { return new int3x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator - (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator - (int lhs, int3x2 rhs) { return new int3x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator / (int3x2 lhs, int3x2 rhs) { return new int3x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator / (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator / (int lhs, int3x2 rhs) { return new int3x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator % (int3x2 lhs, int3x2 rhs) { return new int3x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator % (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator % (int lhs, int3x2 rhs) { return new int3x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator ++ (int3x2 val) { return new int3x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator -- (int3x2 val) { return new int3x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (int3x2 lhs, int3x2 rhs) { return new bool3x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (int3x2 lhs, int rhs) { return new bool3x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (int lhs, int3x2 rhs) { return new bool3x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (int3x2 lhs, int3x2 rhs) { return new bool3x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (int3x2 lhs, int rhs) { return new bool3x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (int lhs, int3x2 rhs) { return new bool3x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (int3x2 lhs, int3x2 rhs) { return new bool3x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (int3x2 lhs, int rhs) { return new bool3x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (int lhs, int3x2 rhs) { return new bool3x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (int3x2 lhs, int3x2 rhs) { return new bool3x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (int3x2 lhs, int rhs) { return new bool3x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (int lhs, int3x2 rhs) { return new bool3x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator - (int3x2 val) { return new int3x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator + (int3x2 val) { return new int3x2 (+val.c0, +val.c1); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator << (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 << rhs, lhs.c1 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator >> (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 >> rhs, lhs.c1 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (int3x2 lhs, int3x2 rhs) { return new bool3x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (int3x2 lhs, int rhs) { return new bool3x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (int lhs, int3x2 rhs) { return new bool3x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (int3x2 lhs, int3x2 rhs) { return new bool3x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (int3x2 lhs, int rhs) { return new bool3x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (int lhs, int3x2 rhs) { return new bool3x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator ~ (int3x2 val) { return new int3x2 (~val.c0, ~val.c1); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator & (int3x2 lhs, int3x2 rhs) { return new int3x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator & (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 & rhs, lhs.c1 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator & (int lhs, int3x2 rhs) { return new int3x2 (lhs & rhs.c0, lhs & rhs.c1); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator | (int3x2 lhs, int3x2 rhs) { return new int3x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator | (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 | rhs, lhs.c1 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator | (int lhs, int3x2 rhs) { return new int3x2 (lhs | rhs.c0, lhs | rhs.c1); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator ^ (int3x2 lhs, int3x2 rhs) { return new int3x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator ^ (int3x2 lhs, int rhs) { return new int3x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 operator ^ (int lhs, int3x2 rhs) { return new int3x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }

        // [int index] 
        unsafe public int3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int3x2* array = &this) { return ((int3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (int3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(int3x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((int3x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("int3x2({0}, {1},  {2}, {3},  {4}, {5})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("int3x2({0}, {1},  {2}, {3},  {4}, {5})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a int3x2 matrix constructed from 2 int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(int3 c0, int3 c1) { return new int3x2(c0, c1); }

        /// <summary>Returns a int3x2 matrix constructed from from 6 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(int m00, int m01,
                                    int m10, int m11,
                                    int m20, int m21)
        {
            return new int3x2(m00, m01,
                              m10, m11,
                              m20, m21);
        }

        /// <summary>Returns a int3x2 matrix constructed from a single int value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(int v) { return new int3x2(v); }

        /// <summary>Returns a int3x2 matrix constructed from a single bool value by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(bool v) { return new int3x2(v); }

        /// <summary>Return a int3x2 matrix constructed from a bool3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(bool3x2 v) { return new int3x2(v); }

        /// <summary>Returns a int3x2 matrix constructed from a single uint value by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(uint v) { return new int3x2(v); }

        /// <summary>Return a int3x2 matrix constructed from a uint3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(uint3x2 v) { return new int3x2(v); }

        /// <summary>Returns a int3x2 matrix constructed from a single float value by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(float v) { return new int3x2(v); }

        /// <summary>Return a int3x2 matrix constructed from a float3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(float3x2 v) { return new int3x2(v); }

        /// <summary>Returns a int3x2 matrix constructed from a single double value by converting it to int and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(double v) { return new int3x2(v); }

        /// <summary>Return a int3x2 matrix constructed from a double3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3x2 int3x2(double3x2 v) { return new int3x2(v); }

        /// <summary>Return the int2x3 transpose of a int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2x3 transpose(int3x2 v)
        {
            return int2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        /// <summary>Returns a uint hash code of a int3x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(int3x2 v)
        {
            return csum(asuint(v.c0) * uint3(0x515D90F5u, 0xEC9F68F3u, 0xF9EA92D5u) + 
                        asuint(v.c1) * uint3(0xC2FAFCB9u, 0x616E9CA1u, 0xC5C5394Bu)) + 0xCAE78587u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a int3x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(int3x2 v)
        {
            return (asuint(v.c0) * uint3(0x7A1541C9u, 0xF83BD927u, 0x6A243BCBu) + 
                    asuint(v.c1) * uint3(0x509B84C9u, 0x91D13847u, 0x52F7230Fu)) + 0xCF286E83u;
        }

    }
}
