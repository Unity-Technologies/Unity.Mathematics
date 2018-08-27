// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct float2x2 : System.IEquatable<float2x2>, IFormattable
    {
        public float2 c0;
        public float2 c1;

        /// <summary>float2x2 identity transform.</summary>
        public static readonly float2x2 identity = new float2x2(1.0f, 0.0f,   0.0f, 1.0f);

        /// <summary>float2x2 zero value.</summary>
        public static readonly float2x2 zero = new float2x2(0.0f, 0.0f,   0.0f, 0.0f);


        /// <summary>Constructs a float2x2 matrix from 2 float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(float2 c0, float2 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a float2x2 matrix from 4 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(float m00, float m01,
                        float m10, float m11)
        { 
            this.c0 = new float2(m00, m10);
            this.c1 = new float2(m01, m11);
        }

        /// <summary>Constructs a float2x2 matrix constructed from a single float value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(float v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a float2x2 matrix from a single bool value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(bool v)
        {
            this.c0 = math.select(new float2(0.0f), new float2(1.0f), v);
            this.c1 = math.select(new float2(0.0f), new float2(1.0f), v);
        }

        /// <summary>Constructs a float2x2 matrix from a bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(bool2x2 v)
        {
            this.c0 = math.select(new float2(0.0f), new float2(1.0f), v.c0);
            this.c1 = math.select(new float2(0.0f), new float2(1.0f), v.c1);
        }

        /// <summary>Constructs a float2x2 matrix from a single int value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a float2x2 matrix from a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(int2x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        /// <summary>Constructs a float2x2 matrix from a single uint value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a float2x2 matrix from a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(uint2x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        /// <summary>Constructs a float2x2 matrix from a single double value by converting it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(double v)
        {
            this.c0 = (float2)v;
            this.c1 = (float2)v;
        }

        /// <summary>Constructs a float2x2 matrix from a double2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(double2x2 v)
        {
            this.c0 = (float2)v.c0;
            this.c1 = (float2)v.c1;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x2(float v) { return new float2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x2(bool v) { return new float2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x2(bool2x2 v) { return new float2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x2(int v) { return new float2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x2(int2x2 v) { return new float2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x2(uint v) { return new float2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x2(uint2x2 v) { return new float2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x2(double v) { return new float2x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x2(double2x2 v) { return new float2x2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator * (float2x2 lhs, float2x2 rhs) { return new float2x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator * (float2x2 lhs, float rhs) { return new float2x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator * (float lhs, float2x2 rhs) { return new float2x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator + (float2x2 lhs, float2x2 rhs) { return new float2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator + (float2x2 lhs, float rhs) { return new float2x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator + (float lhs, float2x2 rhs) { return new float2x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator - (float2x2 lhs, float2x2 rhs) { return new float2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator - (float2x2 lhs, float rhs) { return new float2x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator - (float lhs, float2x2 rhs) { return new float2x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator / (float2x2 lhs, float2x2 rhs) { return new float2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator / (float2x2 lhs, float rhs) { return new float2x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator / (float lhs, float2x2 rhs) { return new float2x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator % (float2x2 lhs, float2x2 rhs) { return new float2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator % (float2x2 lhs, float rhs) { return new float2x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator % (float lhs, float2x2 rhs) { return new float2x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator ++ (float2x2 val) { return new float2x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator -- (float2x2 val) { return new float2x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (float2x2 lhs, float2x2 rhs) { return new bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (float2x2 lhs, float rhs) { return new bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator < (float lhs, float2x2 rhs) { return new bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (float2x2 lhs, float2x2 rhs) { return new bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (float2x2 lhs, float rhs) { return new bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator <= (float lhs, float2x2 rhs) { return new bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (float2x2 lhs, float2x2 rhs) { return new bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (float2x2 lhs, float rhs) { return new bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator > (float lhs, float2x2 rhs) { return new bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (float2x2 lhs, float2x2 rhs) { return new bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (float2x2 lhs, float rhs) { return new bool2x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator >= (float lhs, float2x2 rhs) { return new bool2x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator - (float2x2 val) { return new float2x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 operator + (float2x2 val) { return new float2x2 (+val.c0, +val.c1); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (float2x2 lhs, float2x2 rhs) { return new bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (float2x2 lhs, float rhs) { return new bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator == (float lhs, float2x2 rhs) { return new bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (float2x2 lhs, float2x2 rhs) { return new bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (float2x2 lhs, float rhs) { return new bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x2 operator != (float lhs, float2x2 rhs) { return new bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // [int index] 
        unsafe public float2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float2x2* array = &this) { return ((float2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(float2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((float2x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float2x2({0}f, {1}f,  {2}f, {3}f)", c0.x, c1.x, c0.y, c1.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float2x2({0}f, {1}f,  {2}f, {3}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a float2x2 matrix constructed from 2 float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(float2 c0, float2 c1) { return new float2x2(c0, c1); }

        /// <summary>Returns a float2x2 matrix constructed from from 4 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(float m00, float m01,
                                        float m10, float m11)
        {
            return new float2x2(m00, m01,
                                m10, m11);
        }

        /// <summary>Returns a float2x2 matrix constructed from a single float value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(float v) { return new float2x2(v); }

        /// <summary>Returns a float2x2 matrix constructed from a single bool value by convering it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(bool v) { return new float2x2(v); }

        /// <summary>Return a float2x2 matrix constructed from a bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(bool2x2 v) { return new float2x2(v); }

        /// <summary>Returns a float2x2 matrix constructed from a single int value by convering it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(int v) { return new float2x2(v); }

        /// <summary>Return a float2x2 matrix constructed from a int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(int2x2 v) { return new float2x2(v); }

        /// <summary>Returns a float2x2 matrix constructed from a single uint value by convering it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(uint v) { return new float2x2(v); }

        /// <summary>Return a float2x2 matrix constructed from a uint2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(uint2x2 v) { return new float2x2(v); }

        /// <summary>Returns a float2x2 matrix constructed from a single double value by convering it to float and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(double v) { return new float2x2(v); }

        /// <summary>Return a float2x2 matrix constructed from a double2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(double2x2 v) { return new float2x2(v); }

        /// <summary>Return the float2x2 transpose of a float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 transpose(float2x2 v)
        {
            return float2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 inverse(float2x2 m)
        {
            float a = m.c0.x;
            float b = m.c1.x;
            float c = m.c0.y;
            float d = m.c1.y;

            float det = a * d - b * c;

            return float2x2(d, -b, -c, a) * (1.0f / det);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float determinant(float2x2 m)
        {
            float a = m.c0.x;
            float b = m.c1.x;
            float c = m.c0.y;
            float d = m.c1.y;

            return a * d - b * c;
        }

        /// <summary>Returns a uint hash code of a float2x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float2x2 v)
        {
            return csum(asuint(v.c0) * uint2(0xB4501269u, 0xE04B89FDu) + 
                        asuint(v.c1) * uint2(0xDB3DE101u, 0x7B6D1B4Bu)) + 0x58399E77u;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a float2x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(float2x2 v)
        {
            return (asuint(v.c0) * uint2(0x5EAC29C9u, 0xFC6014F9u) + 
                    asuint(v.c1) * uint2(0x6BF6693Fu, 0x9D1B1D9Bu)) + 0xF842F5C1u;
        }

    }
}
