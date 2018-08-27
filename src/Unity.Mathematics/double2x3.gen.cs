// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double2x3 : System.IEquatable<double2x3>, IFormattable
    {
        public double2 c0;
        public double2 c1;
        public double2 c2;

        /// <summary>double2x3 zero value.</summary>
        public static readonly double2x3 zero = new double2x3(0.0, 0.0, 0.0,   0.0, 0.0, 0.0);


        /// <summary>Constructs a double2x3 matrix from 3 double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(double2 c0, double2 c1, double2 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a double2x3 matrix from 6 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(double m00, double m01, double m02,
                         double m10, double m11, double m12)
        { 
            this.c0 = new double2(m00, m10);
            this.c1 = new double2(m01, m11);
            this.c2 = new double2(m02, m12);
        }

        /// <summary>Constructs a double2x3 matrix constructed from a single double value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(double v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a double2x3 matrix from a single bool value by converting it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(bool v)
        {
            this.c0 = math.select(new double2(0.0), new double2(1.0), v);
            this.c1 = math.select(new double2(0.0), new double2(1.0), v);
            this.c2 = math.select(new double2(0.0), new double2(1.0), v);
        }

        /// <summary>Constructs a double2x3 matrix from a bool2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(bool2x3 v)
        {
            this.c0 = math.select(new double2(0.0), new double2(1.0), v.c0);
            this.c1 = math.select(new double2(0.0), new double2(1.0), v.c1);
            this.c2 = math.select(new double2(0.0), new double2(1.0), v.c2);
        }

        /// <summary>Constructs a double2x3 matrix from a single int value by converting it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a double2x3 matrix from a int2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(int2x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        /// <summary>Constructs a double2x3 matrix from a single uint value by converting it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a double2x3 matrix from a uint2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(uint2x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        /// <summary>Constructs a double2x3 matrix from a single float value by converting it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        /// <summary>Constructs a double2x3 matrix from a float2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x3(float2x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x3(double v) { return new double2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2x3(bool v) { return new double2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2x3(bool2x3 v) { return new double2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x3(int v) { return new double2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x3(int2x3 v) { return new double2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x3(uint v) { return new double2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x3(uint2x3 v) { return new double2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x3(float v) { return new double2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x3(float2x3 v) { return new double2x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator * (double2x3 lhs, double2x3 rhs) { return new double2x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator * (double2x3 lhs, double rhs) { return new double2x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator * (double lhs, double2x3 rhs) { return new double2x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator + (double2x3 lhs, double2x3 rhs) { return new double2x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator + (double2x3 lhs, double rhs) { return new double2x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator + (double lhs, double2x3 rhs) { return new double2x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator - (double2x3 lhs, double2x3 rhs) { return new double2x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator - (double2x3 lhs, double rhs) { return new double2x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator - (double lhs, double2x3 rhs) { return new double2x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator / (double2x3 lhs, double2x3 rhs) { return new double2x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator / (double2x3 lhs, double rhs) { return new double2x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator / (double lhs, double2x3 rhs) { return new double2x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator % (double2x3 lhs, double2x3 rhs) { return new double2x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator % (double2x3 lhs, double rhs) { return new double2x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator % (double lhs, double2x3 rhs) { return new double2x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator ++ (double2x3 val) { return new double2x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator -- (double2x3 val) { return new double2x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (double2x3 lhs, double2x3 rhs) { return new bool2x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (double2x3 lhs, double rhs) { return new bool2x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (double lhs, double2x3 rhs) { return new bool2x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (double2x3 lhs, double2x3 rhs) { return new bool2x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (double2x3 lhs, double rhs) { return new bool2x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (double lhs, double2x3 rhs) { return new bool2x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (double2x3 lhs, double2x3 rhs) { return new bool2x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (double2x3 lhs, double rhs) { return new bool2x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (double lhs, double2x3 rhs) { return new bool2x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (double2x3 lhs, double2x3 rhs) { return new bool2x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (double2x3 lhs, double rhs) { return new bool2x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (double lhs, double2x3 rhs) { return new bool2x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator - (double2x3 val) { return new double2x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 operator + (double2x3 val) { return new double2x3 (+val.c0, +val.c1, +val.c2); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (double2x3 lhs, double2x3 rhs) { return new bool2x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (double2x3 lhs, double rhs) { return new bool2x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (double lhs, double2x3 rhs) { return new bool2x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (double2x3 lhs, double2x3 rhs) { return new bool2x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (double2x3 lhs, double rhs) { return new bool2x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (double lhs, double2x3 rhs) { return new bool2x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // [int index] 
        unsafe public double2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (double2x3* array = &this) { return ((double2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (double2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double2x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double2x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a double2x3 matrix constructed from 3 double2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(double2 c0, double2 c1, double2 c2) { return new double2x3(c0, c1, c2); }

        /// <summary>Returns a double2x3 matrix constructed from from 6 double values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(double m00, double m01, double m02,
                                          double m10, double m11, double m12)
        {
            return new double2x3(m00, m01, m02,
                                 m10, m11, m12);
        }

        /// <summary>Returns a double2x3 matrix constructed from a single double value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(double v) { return new double2x3(v); }

        /// <summary>Returns a double2x3 matrix constructed from a single bool value by convering it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(bool v) { return new double2x3(v); }

        /// <summary>Return a double2x3 matrix constructed from a bool2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(bool2x3 v) { return new double2x3(v); }

        /// <summary>Returns a double2x3 matrix constructed from a single int value by convering it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(int v) { return new double2x3(v); }

        /// <summary>Return a double2x3 matrix constructed from a int2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(int2x3 v) { return new double2x3(v); }

        /// <summary>Returns a double2x3 matrix constructed from a single uint value by convering it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(uint v) { return new double2x3(v); }

        /// <summary>Return a double2x3 matrix constructed from a uint2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(uint2x3 v) { return new double2x3(v); }

        /// <summary>Returns a double2x3 matrix constructed from a single float value by convering it to double and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(float v) { return new double2x3(v); }

        /// <summary>Return a double2x3 matrix constructed from a float2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x3 double2x3(float2x3 v) { return new double2x3(v); }

        /// <summary>Return the double3x2 transpose of a double2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x2 transpose(double2x3 v)
        {
            return double3x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y);
        }

        /// <summary>Returns a uint hash code of a double2x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double2x3 v)
        {
            return csum(fold_to_uint(v.c0) * uint2(0xE133B0B3u, 0xC3E0A3B9u) + 
                        fold_to_uint(v.c1) * uint2(0xFE31134Fu, 0x712A34D7u) + 
                        fold_to_uint(v.c2) * uint2(0x9D77A59Bu, 0x4942CA39u)) + 0xB40EC62Du;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a double2x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(double2x3 v)
        {
            return (fold_to_uint(v.c0) * uint2(0x565ED63Fu, 0x93C30C2Bu) + 
                    fold_to_uint(v.c1) * uint2(0xDCAF0351u, 0x6E050B01u) + 
                    fold_to_uint(v.c2) * uint2(0x750FDBF5u, 0x7F3DD499u)) + 0x52EAAEBBu;
        }

    }
}
