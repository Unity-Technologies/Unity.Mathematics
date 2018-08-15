// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double2x4 : System.IEquatable<double2x4>, IFormattable
    {
        public double2 c0;
        public double2 c1;
        public double2 c2;
        public double2 c3;

        public static readonly double2x4 zero = new double2x4(0.0, 0.0, 0.0, 0.0,   0.0, 0.0, 0.0, 0.0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(double2 c0, double2 c1, double2 c2, double2 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(double m00, double m01, double m02, double m03,
                         double m10, double m11, double m12, double m13)
        { 
            this.c0 = new double2(m00, m10);
            this.c1 = new double2(m01, m11);
            this.c2 = new double2(m02, m12);
            this.c3 = new double2(m03, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(double v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(bool v)
        {
            this.c0 = math.select(new double2(0.0), new double2(1.0), v);
            this.c1 = math.select(new double2(0.0), new double2(1.0), v);
            this.c2 = math.select(new double2(0.0), new double2(1.0), v);
            this.c3 = math.select(new double2(0.0), new double2(1.0), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(bool2x4 v)
        {
            this.c0 = math.select(new double2(0.0), new double2(1.0), v.c0);
            this.c1 = math.select(new double2(0.0), new double2(1.0), v.c1);
            this.c2 = math.select(new double2(0.0), new double2(1.0), v.c2);
            this.c3 = math.select(new double2(0.0), new double2(1.0), v.c3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(int2x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(uint2x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2x4(float2x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x4(double v) { return new double2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2x4(bool v) { return new double2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double2x4(bool2x4 v) { return new double2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x4(int v) { return new double2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x4(int2x4 v) { return new double2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x4(uint v) { return new double2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x4(uint2x4 v) { return new double2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x4(float v) { return new double2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double2x4(float2x4 v) { return new double2x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator * (double2x4 lhs, double2x4 rhs) { return new double2x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator * (double2x4 lhs, double rhs) { return new double2x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator * (double lhs, double2x4 rhs) { return new double2x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator + (double2x4 lhs, double2x4 rhs) { return new double2x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator + (double2x4 lhs, double rhs) { return new double2x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator + (double lhs, double2x4 rhs) { return new double2x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator - (double2x4 lhs, double2x4 rhs) { return new double2x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator - (double2x4 lhs, double rhs) { return new double2x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator - (double lhs, double2x4 rhs) { return new double2x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator / (double2x4 lhs, double2x4 rhs) { return new double2x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator / (double2x4 lhs, double rhs) { return new double2x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator / (double lhs, double2x4 rhs) { return new double2x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator % (double2x4 lhs, double2x4 rhs) { return new double2x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator % (double2x4 lhs, double rhs) { return new double2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator % (double lhs, double2x4 rhs) { return new double2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator ++ (double2x4 val) { return new double2x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator -- (double2x4 val) { return new double2x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (double2x4 lhs, double2x4 rhs) { return new bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (double2x4 lhs, double rhs) { return new bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (double lhs, double2x4 rhs) { return new bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (double2x4 lhs, double2x4 rhs) { return new bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (double2x4 lhs, double rhs) { return new bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (double lhs, double2x4 rhs) { return new bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (double2x4 lhs, double2x4 rhs) { return new bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (double2x4 lhs, double rhs) { return new bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (double lhs, double2x4 rhs) { return new bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (double2x4 lhs, double2x4 rhs) { return new bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (double2x4 lhs, double rhs) { return new bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (double lhs, double2x4 rhs) { return new bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator - (double2x4 val) { return new double2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 operator + (double2x4 val) { return new double2x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (double2x4 lhs, double2x4 rhs) { return new bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (double2x4 lhs, double rhs) { return new bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (double lhs, double2x4 rhs) { return new bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (double2x4 lhs, double2x4 rhs) { return new bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (double2x4 lhs, double rhs) { return new bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (double lhs, double2x4 rhs) { return new bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // [int index] 
        unsafe public double2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double2x4* array = &this) { return ((double2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double2x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(double2 c0, double2 c1, double2 c2, double2 c3) { return new double2x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(double m00, double m01, double m02, double m03,
                                          double m10, double m11, double m12, double m13)
        {
            return new double2x4(m00, m01, m02, m03,
                                 m10, m11, m12, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(double v) { return new double2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(bool v) { return new double2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(bool2x4 v) { return new double2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(int v) { return new double2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(int2x4 v) { return new double2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(uint v) { return new double2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(uint2x4 v) { return new double2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(float v) { return new double2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 double2x4(float2x4 v) { return new double2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 transpose(double2x4 v)
        {
            return double4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double2x4 v)
        {
            return csum(fold_to_uint(v.c0) * uint2(0xFA3A3285u, 0xAD55999Du) + 
                        fold_to_uint(v.c1) * uint2(0xDCDD5341u, 0x94DDD769u) + 
                        fold_to_uint(v.c2) * uint2(0xA1E92D39u, 0x4583C801u) + 
                        fold_to_uint(v.c3) * uint2(0x9536A0F5u, 0xAF816615u)) + 0x9AF8D62Du;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(double2x4 v)
        {
            return (fold_to_uint(v.c0) * uint2(0xE3600729u, 0x5F17300Du) + 
                    fold_to_uint(v.c1) * uint2(0x670D6809u, 0x7AF32C49u) + 
                    fold_to_uint(v.c2) * uint2(0xAE131389u, 0x5D1B165Bu) + 
                    fold_to_uint(v.c3) * uint2(0x87096CD7u, 0x4C7F6DD1u)) + 0x4822A3E9u;
        }

    }
}
