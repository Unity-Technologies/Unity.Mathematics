// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct float3x2 : System.IEquatable<float3x2>, IFormattable
    {
        public float3 c0;
        public float3 c1;

        public static readonly float3x2 zero = new float3x2(0.0f, 0.0f,   0.0f, 0.0f,   0.0f, 0.0f);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(float3 c0, float3 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(float m00, float m01,
                        float m10, float m11,
                        float m20, float m21)
        { 
            this.c0 = new float3(m00, m10, m20);
            this.c1 = new float3(m01, m11, m21);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(float v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(bool v)
        {
            this.c0 = math.select(new float3(0.0f), new float3(1.0f), v);
            this.c1 = math.select(new float3(0.0f), new float3(1.0f), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(bool3x2 v)
        {
            this.c0 = math.select(new float3(0.0f), new float3(1.0f), v.c0);
            this.c1 = math.select(new float3(0.0f), new float3(1.0f), v.c1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(int3x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(uint3x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(double v)
        {
            this.c0 = (float3)v;
            this.c1 = (float3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(double3x2 v)
        {
            this.c0 = (float3)v.c0;
            this.c1 = (float3)v.c1;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(float v) { return new float3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x2(bool v) { return new float3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x2(bool3x2 v) { return new float3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(int v) { return new float3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(int3x2 v) { return new float3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(uint v) { return new float3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(uint3x2 v) { return new float3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x2(double v) { return new float3x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x2(double3x2 v) { return new float3x2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator * (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator * (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator * (float lhs, float3x2 rhs) { return new float3x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator + (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator + (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator + (float lhs, float3x2 rhs) { return new float3x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator - (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator - (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator - (float lhs, float3x2 rhs) { return new float3x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator / (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator / (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator / (float lhs, float3x2 rhs) { return new float3x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator % (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator % (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator % (float lhs, float3x2 rhs) { return new float3x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator ++ (float3x2 val) { return new float3x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator -- (float3x2 val) { return new float3x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (float lhs, float3x2 rhs) { return new bool3x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (float lhs, float3x2 rhs) { return new bool3x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (float lhs, float3x2 rhs) { return new bool3x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (float lhs, float3x2 rhs) { return new bool3x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator - (float3x2 val) { return new float3x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator + (float3x2 val) { return new float3x2 (+val.c0, +val.c1); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (float lhs, float3x2 rhs) { return new bool3x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (float lhs, float3x2 rhs) { return new bool3x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // [int index] 
        unsafe public float3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float3x2* array = &this) { return ((float3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(float3x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((float3x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float3x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f)", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float3x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(float3 c0, float3 c1) { return new float3x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(float m00, float m01,
                                        float m10, float m11,
                                        float m20, float m21)
        {
            return new float3x2(m00, m01,
                                m10, m11,
                                m20, m21);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(float v) { return new float3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(bool v) { return new float3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(bool3x2 v) { return new float3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(int v) { return new float3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(int3x2 v) { return new float3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(uint v) { return new float3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(uint3x2 v) { return new float3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(double v) { return new float3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(double3x2 v) { return new float3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 transpose(float3x2 v)
        {
            return float2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float3x2 v)
        {
            return csum(asuint(v.c0) * uint3(0xEE390C97u, 0x9C8A2F05u, 0x4DDC6509u) + 
                        asuint(v.c1) * uint3(0x7CF083CBu, 0x5C4D6CEDu, 0xF9137117u)) + 0xE857DCE1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(float3x2 v)
        {
            return (asuint(v.c0) * uint3(0xF62213C5u, 0x9CDAA959u, 0xAA269ABFu) + 
                    asuint(v.c1) * uint3(0xD54BA36Fu, 0xFD0847B9u, 0x8189A683u)) + 0xB139D651u;
        }

    }
}
