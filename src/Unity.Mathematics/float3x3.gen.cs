// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct float3x3 : System.IEquatable<float3x3>, IFormattable
    {
        public float3 c0;
        public float3 c1;
        public float3 c2;

        public static readonly float3x3 identity = new float3x3(1.0f, 0.0f, 0.0f,   0.0f, 1.0f, 0.0f,   0.0f, 0.0f, 1.0f);
        public static readonly float3x3 zero = new float3x3(0.0f, 0.0f, 0.0f,   0.0f, 0.0f, 0.0f,   0.0f, 0.0f, 0.0f);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(float3 c0, float3 c1, float3 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(float m00, float m01, float m02,
                        float m10, float m11, float m12,
                        float m20, float m21, float m22)
        { 
            this.c0 = new float3(m00, m10, m20);
            this.c1 = new float3(m01, m11, m21);
            this.c2 = new float3(m02, m12, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(bool v)
        {
            this.c0 = math.select(new float3(0.0f), new float3(1.0f), v);
            this.c1 = math.select(new float3(0.0f), new float3(1.0f), v);
            this.c2 = math.select(new float3(0.0f), new float3(1.0f), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(bool3x3 v)
        {
            this.c0 = math.select(new float3(0.0f), new float3(1.0f), v.c0);
            this.c1 = math.select(new float3(0.0f), new float3(1.0f), v.c1);
            this.c2 = math.select(new float3(0.0f), new float3(1.0f), v.c2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(int3x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(uint3x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(double v)
        {
            this.c0 = (float3)v;
            this.c1 = (float3)v;
            this.c2 = (float3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x3(double3x3 v)
        {
            this.c0 = (float3)v.c0;
            this.c1 = (float3)v.c1;
            this.c2 = (float3)v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x3(float v) { return new float3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x3(bool v) { return new float3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x3(bool3x3 v) { return new float3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x3(int v) { return new float3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x3(int3x3 v) { return new float3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x3(uint v) { return new float3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x3(uint3x3 v) { return new float3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x3(double v) { return new float3x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x3(double3x3 v) { return new float3x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator * (float3x3 lhs, float3x3 rhs) { return new float3x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator * (float3x3 lhs, float rhs) { return new float3x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator * (float lhs, float3x3 rhs) { return new float3x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator + (float3x3 lhs, float3x3 rhs) { return new float3x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator + (float3x3 lhs, float rhs) { return new float3x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator + (float lhs, float3x3 rhs) { return new float3x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator - (float3x3 lhs, float3x3 rhs) { return new float3x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator - (float3x3 lhs, float rhs) { return new float3x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator - (float lhs, float3x3 rhs) { return new float3x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator / (float3x3 lhs, float3x3 rhs) { return new float3x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator / (float3x3 lhs, float rhs) { return new float3x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator / (float lhs, float3x3 rhs) { return new float3x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator % (float3x3 lhs, float3x3 rhs) { return new float3x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator % (float3x3 lhs, float rhs) { return new float3x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator % (float lhs, float3x3 rhs) { return new float3x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator ++ (float3x3 val) { return new float3x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator -- (float3x3 val) { return new float3x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (float3x3 lhs, float3x3 rhs) { return new bool3x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (float3x3 lhs, float rhs) { return new bool3x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (float lhs, float3x3 rhs) { return new bool3x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (float3x3 lhs, float3x3 rhs) { return new bool3x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (float3x3 lhs, float rhs) { return new bool3x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (float lhs, float3x3 rhs) { return new bool3x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (float3x3 lhs, float3x3 rhs) { return new bool3x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (float3x3 lhs, float rhs) { return new bool3x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (float lhs, float3x3 rhs) { return new bool3x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (float3x3 lhs, float3x3 rhs) { return new bool3x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (float3x3 lhs, float rhs) { return new bool3x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (float lhs, float3x3 rhs) { return new bool3x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator - (float3x3 val) { return new float3x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 operator + (float3x3 val) { return new float3x3 (+val.c0, +val.c1, +val.c2); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (float3x3 lhs, float3x3 rhs) { return new bool3x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (float3x3 lhs, float rhs) { return new bool3x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (float lhs, float3x3 rhs) { return new bool3x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (float3x3 lhs, float3x3 rhs) { return new bool3x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (float3x3 lhs, float rhs) { return new bool3x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (float lhs, float3x3 rhs) { return new bool3x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // [int index] 
        unsafe public float3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (float3x3* array = &this) { return ((float3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (float3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(float3x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((float3x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float3x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f,  {6}f, {7}f, {8}f)", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float3x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f,  {6}f, {7}f, {8}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(float3 c0, float3 c1, float3 c2) { return new float3x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(float m00, float m01, float m02,
                                        float m10, float m11, float m12,
                                        float m20, float m21, float m22)
        {
            return new float3x3(m00, m01, m02,
                                m10, m11, m12,
                                m20, m21, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(float v) { return new float3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(bool v) { return new float3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(bool3x3 v) { return new float3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(int v) { return new float3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(int3x3 v) { return new float3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(uint v) { return new float3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(uint3x3 v) { return new float3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(double v) { return new float3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 float3x3(double3x3 v) { return new float3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 transpose(float3x3 v)
        {
            return float3x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z);
        }

public static float3x3 inverse(float3x3 m)
        {
            // naive scalar implementation using direct calculation by cofactors
            float3 c0 = m.c0;
            float3 c1 = m.c1;
            float3 c2 = m.c2;

            // calculate minors
            float m00 = c1.y * c2.z - c1.z * c2.y;
            float m01 = c0.y * c2.z - c0.z * c2.y;
            float m02 = c0.y * c1.z - c0.z * c1.y;

            float m10 = c1.x * c2.z - c1.z * c2.x;
            float m11 = c0.x * c2.z - c0.z * c2.x;
            float m12 = c0.x * c1.z - c0.z * c1.x;

            float m20 = c1.x * c2.y - c1.y * c2.x;
            float m21 = c0.x * c2.y - c0.y * c2.x;
            float m22 = c0.x * c1.y - c0.y * c1.x;

            float det = c0.x * m00 - c1.x * m01 + c2.x * m02;

            return float3x3(
                 m00,-m10, m20,
                -m01, m11,-m21,
                 m02, -m12, m22) * (1.0f / det);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float determinant(float3x3 m)
        {
            float3 c0 = m.c0;
            float3 c1 = m.c1;
            float3 c2 = m.c2;

            float m00 = c1.y * c2.z - c1.z * c2.y;
            float m01 = c0.y * c2.z - c0.z * c2.y;
            float m02 = c0.y * c1.z - c0.z * c1.y;

            return c0.x * m00 - c1.x * m01 + c2.x * m02;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float3x3 v)
        {
            return csum(asuint(v.c0) * uint3(0x568DAAA9u, 0x7530254Fu, 0x9F090439u) + 
                        asuint(v.c1) * uint3(0x5E9F85C9u, 0x8C4CA03Fu, 0xB8D969EDu) + 
                        asuint(v.c2) * uint3(0xAC5DB57Bu, 0xA91A02EDu, 0xB3C49313u)) + 0xF43A9ABBu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(float3x3 v)
        {
            return (asuint(v.c0) * uint3(0x84E7E01Bu, 0x8E055BE5u, 0x6E624EB7u) + 
                    asuint(v.c1) * uint3(0x7383ED49u, 0xDD49C23Bu, 0xEBD0D005u) + 
                    asuint(v.c2) * uint3(0x91475DF7u, 0x55E84827u, 0x90A285BBu)) + 0x5D19E1D5u;
        }

    }
}
