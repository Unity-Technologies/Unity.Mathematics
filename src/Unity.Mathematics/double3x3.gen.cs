// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double3x3 : System.IEquatable<double3x3>, IFormattable
    {
        public double3 c0;
        public double3 c1;
        public double3 c2;


        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(double3 c0, double3 c1, double3 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(double m00, double m01, double m02,
                         double m10, double m11, double m12,
                         double m20, double m21, double m22)
        { 
            this.c0 = new double3(m00, m10, m20);
            this.c1 = new double3(m01, m11, m21);
            this.c2 = new double3(m02, m12, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(double v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x3(double v) { return new double3x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator * (double3x3 lhs, double3x3 rhs) { return new double3x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator * (double3x3 lhs, double rhs) { return new double3x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator * (double lhs, double3x3 rhs) { return new double3x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator + (double3x3 lhs, double3x3 rhs) { return new double3x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator + (double3x3 lhs, double rhs) { return new double3x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator + (double lhs, double3x3 rhs) { return new double3x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator - (double3x3 lhs, double3x3 rhs) { return new double3x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator - (double3x3 lhs, double rhs) { return new double3x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator - (double lhs, double3x3 rhs) { return new double3x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator / (double3x3 lhs, double3x3 rhs) { return new double3x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator / (double3x3 lhs, double rhs) { return new double3x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator / (double lhs, double3x3 rhs) { return new double3x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator % (double3x3 lhs, double3x3 rhs) { return new double3x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator % (double3x3 lhs, double rhs) { return new double3x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator % (double lhs, double3x3 rhs) { return new double3x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator ++ (double3x3 val) { return new double3x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator -- (double3x3 val) { return new double3x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (double3x3 lhs, double3x3 rhs) { return new bool3x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (double3x3 lhs, double rhs) { return new bool3x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (double lhs, double3x3 rhs) { return new bool3x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (double3x3 lhs, double3x3 rhs) { return new bool3x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (double3x3 lhs, double rhs) { return new bool3x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (double lhs, double3x3 rhs) { return new bool3x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (double3x3 lhs, double3x3 rhs) { return new bool3x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (double3x3 lhs, double rhs) { return new bool3x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (double lhs, double3x3 rhs) { return new bool3x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (double3x3 lhs, double3x3 rhs) { return new bool3x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (double3x3 lhs, double rhs) { return new bool3x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (double lhs, double3x3 rhs) { return new bool3x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator - (double3x3 val) { return new double3x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 operator + (double3x3 val) { return new double3x3 (+val.c0, +val.c1, +val.c2); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (double3x3 lhs, double3x3 rhs) { return new bool3x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (double3x3 lhs, double rhs) { return new bool3x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (double lhs, double3x3 rhs) { return new bool3x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (double3x3 lhs, double3x3 rhs) { return new bool3x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (double3x3 lhs, double rhs) { return new bool3x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (double lhs, double3x3 rhs) { return new bool3x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // [int index] 
        unsafe public double3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (double3x3* array = &this) { return ((double3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (double3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double3x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double3x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(double3 c0, double3 c1, double3 c2) { return new double3x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(double m00, double m01, double m02,
                                          double m10, double m11, double m12,
                                          double m20, double m21, double m22)
        {
            return new double3x3(m00, m01, m02,
                                 m10, m11, m12,
                                 m20, m21, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(double v) { return new double3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double3x3 v)
        {
            return csum(fold_to_uint(v.c0) * uint3(0xF18EEB85u, 0x9E19BFC3u, 0x8196B06Fu) + 
                        fold_to_uint(v.c1) * uint3(0xD24EFA19u, 0x7D8048BBu, 0x713BD06Fu) + 
                        fold_to_uint(v.c2) * uint3(0x753AD6ADu, 0xD19764C7u, 0xB5D0BF63u)) + 0xF9102C5Fu;
        }

    }
}
