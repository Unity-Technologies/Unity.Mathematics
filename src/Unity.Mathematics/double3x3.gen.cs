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

        public static readonly double3x3 identity = new double3x3(1.0, 0.0, 0.0,   0.0, 1.0, 0.0,   0.0, 0.0, 1.0);
        public static readonly double3x3 zero = new double3x3(0.0, 0.0, 0.0,   0.0, 0.0, 0.0,   0.0, 0.0, 0.0);

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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(bool v)
        {
            this.c0 = math.select(new double3(0.0), new double3(1.0), v);
            this.c1 = math.select(new double3(0.0), new double3(1.0), v);
            this.c2 = math.select(new double3(0.0), new double3(1.0), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(bool3x3 v)
        {
            this.c0 = math.select(new double3(0.0), new double3(1.0), v.c0);
            this.c1 = math.select(new double3(0.0), new double3(1.0), v.c1);
            this.c2 = math.select(new double3(0.0), new double3(1.0), v.c2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(int3x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(uint3x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3x3(float3x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x3(double v) { return new double3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double3x3(bool v) { return new double3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator double3x3(bool3x3 v) { return new double3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x3(int v) { return new double3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x3(int3x3 v) { return new double3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x3(uint v) { return new double3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x3(uint3x3 v) { return new double3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x3(float v) { return new double3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator double3x3(float3x3 v) { return new double3x3(v); }


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
        public static double3x3 double3x3(bool v) { return new double3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(bool3x3 v) { return new double3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(int v) { return new double3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(int3x3 v) { return new double3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(uint v) { return new double3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(uint3x3 v) { return new double3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(float v) { return new double3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 double3x3(float3x3 v) { return new double3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3x3 transpose(double3x3 v)
        {
            return double3x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z);
        }

public static double3x3 inverse(double3x3 m)
        {
            // naive scalar implementation using direct calculation by cofactors
            double3 c0 = m.c0;
            double3 c1 = m.c1;
            double3 c2 = m.c2;

            // calculate minors
            double m00 = c1.y * c2.z - c1.z * c2.y;
            double m01 = c0.y * c2.z - c0.z * c2.y;
            double m02 = c0.y * c1.z - c0.z * c1.y;

            double m10 = c1.x * c2.z - c1.z * c2.x;
            double m11 = c0.x * c2.z - c0.z * c2.x;
            double m12 = c0.x * c1.z - c0.z * c1.x;

            double m20 = c1.x * c2.y - c1.y * c2.x;
            double m21 = c0.x * c2.y - c0.y * c2.x;
            double m22 = c0.x * c1.y - c0.y * c1.x;

            double det = c0.x * m00 - c1.x * m01 + c2.x * m02;

            return double3x3(
                 m00,-m10, m20,
                -m01, m11,-m21,
                 m02, -m12, m22) * (1.0 / det);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double determinant(double3x3 m)
        {
            double3 c0 = m.c0;
            double3 c1 = m.c1;
            double3 c2 = m.c2;

            double m00 = c1.y * c2.z - c1.z * c2.y;
            double m01 = c0.y * c2.z - c0.z * c2.y;
            double m02 = c0.y * c1.z - c0.z * c1.y;

            return c0.x * m00 - c1.x * m01 + c2.x * m02;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(double3x3 v)
        {
            return csum(fold_to_uint(v.c0) * uint3(0xFAAF07DDu, 0x625C45BDu, 0xC9F27FCBu) + 
                        fold_to_uint(v.c1) * uint3(0x6D2523B1u, 0x6E2BF6A9u, 0xCC74B3B7u) + 
                        fold_to_uint(v.c2) * uint3(0x83B58237u, 0x833E3E29u, 0xA9D919BFu)) + 0xC3EC1D97u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(double3x3 v)
        {
            return (fold_to_uint(v.c0) * uint3(0xB8B208C7u, 0x5D3ED947u, 0x4473BBB1u) + 
                    fold_to_uint(v.c1) * uint3(0xCBA11D5Fu, 0x685835CFu, 0xC3D32AE1u) + 
                    fold_to_uint(v.c2) * uint3(0xB966942Fu, 0xFE9856B3u, 0xFA3A3285u)) + 0xAD55999Du;
        }

    }
}
