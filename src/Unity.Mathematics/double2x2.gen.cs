// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double2x2 : System.IEquatable<double2x2>, IFormattable
    {
        public double2 c0;
        public double2 c1;

        public static readonly double2x2 identity = new double2x2(1.0, 0.0,   0.0, 1.0);
        public static readonly double2x2 zero = new double2x2(0.0, 0.0,   0.0, 0.0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(double2 c0, double2 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(double m00, double m01,
                         double m10, double m11)
        { 
            this.c0 = new double2(m00, m10);
            this.c1 = new double2(m01, m11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(double v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(bool v)
        {
            this.c0 = math.select(new double2(0.0), new double2(1.0), v);
            this.c1 = math.select(new double2(0.0), new double2(1.0), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(bool2x2 v)
        {
            this.c0 = math.select(new double2(0.0), new double2(1.0), v.c0);
            this.c1 = math.select(new double2(0.0), new double2(1.0), v.c1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(int2x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(uint2x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(float v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x2(float2x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(double v) { return new double2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2x2(bool v) { return new double2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2x2(bool2x2 v) { return new double2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(int v) { return new double2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(int2x2 v) { return new double2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(uint v) { return new double2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(uint2x2 v) { return new double2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(float v) { return new double2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x2(float2x2 v) { return new double2x2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator * (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator * (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator * (double lhs, double2x2 rhs) { return new double2x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator + (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator + (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator + (double lhs, double2x2 rhs) { return new double2x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator - (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator - (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator - (double lhs, double2x2 rhs) { return new double2x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator / (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator / (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator / (double lhs, double2x2 rhs) { return new double2x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator % (double2x2 lhs, double2x2 rhs) { return new double2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator % (double2x2 lhs, double rhs) { return new double2x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator % (double lhs, double2x2 rhs) { return new double2x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator ++ (double2x2 val) { return new double2x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator -- (double2x2 val) { return new double2x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (double lhs, double2x2 rhs) { return new bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (double lhs, double2x2 rhs) { return new bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (double lhs, double2x2 rhs) { return new bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (double lhs, double2x2 rhs) { return new bool2x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator - (double2x2 val) { return new double2x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 operator + (double2x2 val) { return new double2x2 (+val.c0, +val.c1); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (double lhs, double2x2 rhs) { return new bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (double2x2 lhs, double2x2 rhs) { return new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (double2x2 lhs, double rhs) { return new bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (double lhs, double2x2 rhs) { return new bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // [int index] 
        unsafe public double2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (double2x2* array = &this) { return ((double2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (double2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double2x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double2x2({0}, {1},  {2}, {3})", c0.x, c1.x, c0.y, c1.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double2x2({0}, {1},  {2}, {3})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(double2 c0, double2 c1) { return new double2x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(double m00, double m01,
                                          double m10, double m11)
        {
            return new double2x2(m00, m01,
                                 m10, m11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(double v) { return new double2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(bool v) { return new double2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(bool2x2 v) { return new double2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(int v) { return new double2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(int2x2 v) { return new double2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(uint v) { return new double2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(uint2x2 v) { return new double2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(float v) { return new double2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 double2x2(float2x2 v) { return new double2x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 transpose(double2x2 v)
        {
            return double2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x2 inverse(double2x2 m)
        {
            double a = m.c0.x;
            double b = m.c1.x;
            double c = m.c0.y;
            double d = m.c1.y;

            double det = a * d - b * c;

            return double2x2(d, -b, -c, a) * (1.0 / det);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double determinant(double2x2 m)
        {
            double a = m.c0.x;
            double b = m.c1.x;
            double c = m.c0.y;
            double d = m.c1.y;

            return a * d - b * c;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double2x2 v)
        {
            return csum(fold_to_uint(v.c0) * uint2(0xA47EC335u, 0xA477DF57u) + 
                        fold_to_uint(v.c1) * uint2(0xC4B1493Fu, 0xBA0966D3u)) + 0xAFBEE253u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(double2x2 v)
        {
            return (fold_to_uint(v.c0) * uint2(0x5B419C01u, 0x515D90F5u) + 
                    fold_to_uint(v.c1) * uint2(0xEC9F68F3u, 0xF9EA92D5u)) + 0xC2FAFCB9u;
        }

    }
}
