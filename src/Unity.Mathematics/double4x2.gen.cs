// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct double4x2 : System.IEquatable<double4x2>, IFormattable
    {
        public double4 c0;
        public double4 c1;

        public static readonly double4x2 zero = new double4x2(0.0, 0.0,   0.0, 0.0,   0.0, 0.0,   0.0, 0.0);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(double4 c0, double4 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(double m00, double m01,
                         double m10, double m11,
                         double m20, double m21,
                         double m30, double m31)
        { 
            this.c0 = new double4(m00, m10, m20, m30);
            this.c1 = new double4(m01, m11, m21, m31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(double v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(bool v)
        {
            this.c0 = math.select(new double4(0.0), new double4(1.0), v);
            this.c1 = math.select(new double4(0.0), new double4(1.0), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(bool4x2 v)
        {
            this.c0 = math.select(new double4(0.0), new double4(1.0), v.c0);
            this.c1 = math.select(new double4(0.0), new double4(1.0), v.c1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(int4x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(uint4x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(float v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4x2(float4x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x2(double v) { return new double4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double4x2(bool v) { return new double4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double4x2(bool4x2 v) { return new double4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x2(int v) { return new double4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x2(int4x2 v) { return new double4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x2(uint v) { return new double4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x2(uint4x2 v) { return new double4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x2(float v) { return new double4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double4x2(float4x2 v) { return new double4x2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator * (double4x2 lhs, double4x2 rhs) { return new double4x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator * (double4x2 lhs, double rhs) { return new double4x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator * (double lhs, double4x2 rhs) { return new double4x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator + (double4x2 lhs, double4x2 rhs) { return new double4x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator + (double4x2 lhs, double rhs) { return new double4x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator + (double lhs, double4x2 rhs) { return new double4x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator - (double4x2 lhs, double4x2 rhs) { return new double4x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator - (double4x2 lhs, double rhs) { return new double4x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator - (double lhs, double4x2 rhs) { return new double4x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator / (double4x2 lhs, double4x2 rhs) { return new double4x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator / (double4x2 lhs, double rhs) { return new double4x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator / (double lhs, double4x2 rhs) { return new double4x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator % (double4x2 lhs, double4x2 rhs) { return new double4x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator % (double4x2 lhs, double rhs) { return new double4x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator % (double lhs, double4x2 rhs) { return new double4x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator ++ (double4x2 val) { return new double4x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator -- (double4x2 val) { return new double4x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (double4x2 lhs, double4x2 rhs) { return new bool4x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (double4x2 lhs, double rhs) { return new bool4x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (double lhs, double4x2 rhs) { return new bool4x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (double4x2 lhs, double4x2 rhs) { return new bool4x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (double4x2 lhs, double rhs) { return new bool4x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (double lhs, double4x2 rhs) { return new bool4x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (double4x2 lhs, double4x2 rhs) { return new bool4x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (double4x2 lhs, double rhs) { return new bool4x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (double lhs, double4x2 rhs) { return new bool4x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (double4x2 lhs, double4x2 rhs) { return new bool4x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (double4x2 lhs, double rhs) { return new bool4x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (double lhs, double4x2 rhs) { return new bool4x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator - (double4x2 val) { return new double4x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 operator + (double4x2 val) { return new double4x2 (+val.c0, +val.c1); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (double4x2 lhs, double4x2 rhs) { return new bool4x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (double4x2 lhs, double rhs) { return new bool4x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (double lhs, double4x2 rhs) { return new bool4x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (double4x2 lhs, double4x2 rhs) { return new bool4x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (double4x2 lhs, double rhs) { return new bool4x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (double lhs, double4x2 rhs) { return new bool4x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // [int index] 
        unsafe public double4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (double4x2* array = &this) { return ((double4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (double4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(double4x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((double4x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("double4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z, c0.w, c1.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(double4 c0, double4 c1) { return new double4x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(double m00, double m01,
                                          double m10, double m11,
                                          double m20, double m21,
                                          double m30, double m31)
        {
            return new double4x2(m00, m01,
                                 m10, m11,
                                 m20, m21,
                                 m30, m31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(double v) { return new double4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(bool v) { return new double4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(bool4x2 v) { return new double4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(int v) { return new double4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(int4x2 v) { return new double4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(uint v) { return new double4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(uint4x2 v) { return new double4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(float v) { return new double4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4x2 double4x2(float4x2 v) { return new double4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2x4 transpose(double4x2 v)
        {
            return double2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double4x2 v)
        {
            return csum(fold_to_uint(v.c0) * uint4(0xAF0F3103u, 0xE4A056C7u, 0x841D8225u, 0xC9393C7Du) + 
                        fold_to_uint(v.c1) * uint4(0xD42EAFA3u, 0xD9AFD06Du, 0x97A65421u, 0x7809205Fu)) + 0x9C9F0823u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hash_wide(double4x2 v)
        {
            return (fold_to_uint(v.c0) * uint4(0x5A9CA13Bu, 0xAFCDD5EFu, 0xA88D187Du, 0xCF6EBA1Du) + 
                    fold_to_uint(v.c1) * uint4(0x9D88E5A1u, 0xEADF0775u, 0x747A9D7Bu, 0x4111F799u)) + 0xB5F05AF1u;
        }

    }
}
