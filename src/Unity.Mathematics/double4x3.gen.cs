// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double4x3 : System.IEquatable<double4x3>, IFormattable
    {
        public double4 c0;
        public double4 c1;
        public double4 c2;

        public static readonly double4x3 zero = new double4x3(0.0, 0.0, 0.0,   0.0, 0.0, 0.0,   0.0, 0.0, 0.0,   0.0, 0.0, 0.0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(double4 c0, double4 c1, double4 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(double m00, double m01, double m02,
                         double m10, double m11, double m12,
                         double m20, double m21, double m22,
                         double m30, double m31, double m32)
        { 
            this.c0 = new double4(m00, m10, m20, m30);
            this.c1 = new double4(m01, m11, m21, m31);
            this.c2 = new double4(m02, m12, m22, m32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(double v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(bool v)
        {
            this.c0 = math.select(new double4(0.0), new double4(1.0), v);
            this.c1 = math.select(new double4(0.0), new double4(1.0), v);
            this.c2 = math.select(new double4(0.0), new double4(1.0), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(bool4x3 v)
        {
            this.c0 = math.select(new double4(0.0), new double4(1.0), v.c0);
            this.c1 = math.select(new double4(0.0), new double4(1.0), v.c1);
            this.c2 = math.select(new double4(0.0), new double4(1.0), v.c2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(int4x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(uint4x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x3(float4x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(double v) { return new double4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double4x3(bool v) { return new double4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double4x3(bool4x3 v) { return new double4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(int v) { return new double4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(int4x3 v) { return new double4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(uint v) { return new double4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(uint4x3 v) { return new double4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(float v) { return new double4x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x3(float4x3 v) { return new double4x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator * (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator * (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator * (double lhs, double4x3 rhs) { return new double4x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator + (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator + (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator + (double lhs, double4x3 rhs) { return new double4x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator - (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator - (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator - (double lhs, double4x3 rhs) { return new double4x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator / (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator / (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator / (double lhs, double4x3 rhs) { return new double4x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator % (double4x3 lhs, double4x3 rhs) { return new double4x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator % (double4x3 lhs, double rhs) { return new double4x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator % (double lhs, double4x3 rhs) { return new double4x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator ++ (double4x3 val) { return new double4x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator -- (double4x3 val) { return new double4x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator < (double lhs, double4x3 rhs) { return new bool4x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator <= (double lhs, double4x3 rhs) { return new bool4x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator > (double lhs, double4x3 rhs) { return new bool4x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator >= (double lhs, double4x3 rhs) { return new bool4x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator - (double4x3 val) { return new double4x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 operator + (double4x3 val) { return new double4x3 (+val.c0, +val.c1, +val.c2); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (double lhs, double4x3 rhs) { return new bool4x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (double4x3 lhs, double4x3 rhs) { return new bool4x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (double4x3 lhs, double rhs) { return new bool4x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (double lhs, double4x3 rhs) { return new bool4x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // [int index] 
        unsafe public double4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (double4x3* array = &this) { return ((double4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (double4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double4x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double4x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z, c0.w, c1.w, c2.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(double4 c0, double4 c1, double4 c2) { return new double4x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(double m00, double m01, double m02,
                                          double m10, double m11, double m12,
                                          double m20, double m21, double m22,
                                          double m30, double m31, double m32)
        {
            return new double4x3(m00, m01, m02,
                                 m10, m11, m12,
                                 m20, m21, m22,
                                 m30, m31, m32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(double v) { return new double4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(bool v) { return new double4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(bool4x3 v) { return new double4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(int v) { return new double4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(int4x3 v) { return new double4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(uint v) { return new double4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(uint4x3 v) { return new double4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(float v) { return new double4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x3 double4x3(float4x3 v) { return new double4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x4 transpose(double4x3 v)
        {
            return double3x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double4x3 v)
        {
            return csum(fold_to_uint(v.c0) * uint4(0xAC60D0C3u, 0x9263662Fu, 0xE69626FFu, 0xBD010EEBu) + 
                        fold_to_uint(v.c1) * uint4(0x9CEDE1D1u, 0x43BE0B51u, 0xAF836EE1u, 0xB130C137u) + 
                        fold_to_uint(v.c2) * uint4(0x54834775u, 0x7C022221u, 0xA2D00EDFu, 0xA8977779u)) + 0x9F1C739Bu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hash_wide(double4x3 v)
        {
            return (fold_to_uint(v.c0) * uint4(0x4B1BD187u, 0x9DF50593u, 0xF18EEB85u, 0x9E19BFC3u) + 
                    fold_to_uint(v.c1) * uint4(0x8196B06Fu, 0xD24EFA19u, 0x7D8048BBu, 0x713BD06Fu) + 
                    fold_to_uint(v.c2) * uint4(0x753AD6ADu, 0xD19764C7u, 0xB5D0BF63u, 0xF9102C5Fu)) + 0x9881FB9Fu;
        }

    }
}
