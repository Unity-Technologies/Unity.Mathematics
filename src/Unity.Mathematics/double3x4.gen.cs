// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double3x4 : System.IEquatable<double3x4>, IFormattable
    {
        public double3 c0;
        public double3 c1;
        public double3 c2;
        public double3 c3;

        public static readonly double3x4 zero = new double3x4(0.0, 0.0, 0.0, 0.0,   0.0, 0.0, 0.0, 0.0,   0.0, 0.0, 0.0, 0.0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(double3 c0, double3 c1, double3 c2, double3 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(double m00, double m01, double m02, double m03,
                         double m10, double m11, double m12, double m13,
                         double m20, double m21, double m22, double m23)
        { 
            this.c0 = new double3(m00, m10, m20);
            this.c1 = new double3(m01, m11, m21);
            this.c2 = new double3(m02, m12, m22);
            this.c3 = new double3(m03, m13, m23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x4(double v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x4(double v) { return new double3x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator * (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator * (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator * (double lhs, double3x4 rhs) { return new double3x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator + (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator + (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator + (double lhs, double3x4 rhs) { return new double3x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator - (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator - (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator - (double lhs, double3x4 rhs) { return new double3x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator / (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator / (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator / (double lhs, double3x4 rhs) { return new double3x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator % (double3x4 lhs, double3x4 rhs) { return new double3x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator % (double3x4 lhs, double rhs) { return new double3x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator % (double lhs, double3x4 rhs) { return new double3x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator ++ (double3x4 val) { return new double3x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator -- (double3x4 val) { return new double3x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (double lhs, double3x4 rhs) { return new bool3x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (double lhs, double3x4 rhs) { return new bool3x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (double lhs, double3x4 rhs) { return new bool3x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (double lhs, double3x4 rhs) { return new bool3x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator - (double3x4 val) { return new double3x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 operator + (double3x4 val) { return new double3x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (double lhs, double3x4 rhs) { return new bool3x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (double3x4 lhs, double3x4 rhs) { return new bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (double3x4 lhs, double rhs) { return new bool3x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (double lhs, double3x4 rhs) { return new bool3x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // [int index] 
        unsafe public double3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double3x4* array = &this) { return ((double3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (double3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double3x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double3x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(double3 c0, double3 c1, double3 c2, double3 c3) { return new double3x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(double m00, double m01, double m02, double m03,
                                          double m10, double m11, double m12, double m13,
                                          double m20, double m21, double m22, double m23)
        {
            return new double3x4(m00, m01, m02, m03,
                                 m10, m11, m12, m13,
                                 m20, m21, m22, m23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 double3x4(double v) { return new double3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 transpose(double3x4 v)
        {
            return double4x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z,
                v.c3.x, v.c3.y, v.c3.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double3x4 v)
        {
            return csum(fold_to_uint(v.c0) * uint3(0xA88D187Du, 0xCF6EBA1Du, 0x9D88E5A1u) + 
                        fold_to_uint(v.c1) * uint3(0xEADF0775u, 0x747A9D7Bu, 0x4111F799u) + 
                        fold_to_uint(v.c2) * uint3(0xB5F05AF1u, 0xFD80290Bu, 0x8B65ADB7u) + 
                        fold_to_uint(v.c3) * uint3(0xDFF4F563u, 0x7069770Du, 0xD1224537u)) + 0xE99ED6F3u;
        }

    }
}
