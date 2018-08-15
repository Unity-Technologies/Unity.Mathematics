// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct float3x4 : System.IEquatable<float3x4>, IFormattable
    {
        public float3 c0;
        public float3 c1;
        public float3 c2;
        public float3 c3;

        public static readonly float3x4 zero = new float3x4(0.0f, 0.0f, 0.0f, 0.0f,   0.0f, 0.0f, 0.0f, 0.0f,   0.0f, 0.0f, 0.0f, 0.0f);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(float3 c0, float3 c1, float3 c2, float3 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(float m00, float m01, float m02, float m03,
                        float m10, float m11, float m12, float m13,
                        float m20, float m21, float m22, float m23)
        { 
            this.c0 = new float3(m00, m10, m20);
            this.c1 = new float3(m01, m11, m21);
            this.c2 = new float3(m02, m12, m22);
            this.c3 = new float3(m03, m13, m23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(bool v)
        {
            this.c0 = math.select(new float3(0.0f), new float3(1.0f), v);
            this.c1 = math.select(new float3(0.0f), new float3(1.0f), v);
            this.c2 = math.select(new float3(0.0f), new float3(1.0f), v);
            this.c3 = math.select(new float3(0.0f), new float3(1.0f), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(bool3x4 v)
        {
            this.c0 = math.select(new float3(0.0f), new float3(1.0f), v.c0);
            this.c1 = math.select(new float3(0.0f), new float3(1.0f), v.c1);
            this.c2 = math.select(new float3(0.0f), new float3(1.0f), v.c2);
            this.c3 = math.select(new float3(0.0f), new float3(1.0f), v.c3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(int3x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(uint3x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(double v)
        {
            this.c0 = (float3)v;
            this.c1 = (float3)v;
            this.c2 = (float3)v;
            this.c3 = (float3)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x4(double3x4 v)
        {
            this.c0 = (float3)v.c0;
            this.c1 = (float3)v.c1;
            this.c2 = (float3)v.c2;
            this.c3 = (float3)v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x4(float v) { return new float3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x4(bool v) { return new float3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x4(bool3x4 v) { return new float3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x4(int v) { return new float3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x4(int3x4 v) { return new float3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x4(uint v) { return new float3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x4(uint3x4 v) { return new float3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x4(double v) { return new float3x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x4(double3x4 v) { return new float3x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator * (float3x4 lhs, float3x4 rhs) { return new float3x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator * (float3x4 lhs, float rhs) { return new float3x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator * (float lhs, float3x4 rhs) { return new float3x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator + (float3x4 lhs, float3x4 rhs) { return new float3x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator + (float3x4 lhs, float rhs) { return new float3x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator + (float lhs, float3x4 rhs) { return new float3x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator - (float3x4 lhs, float3x4 rhs) { return new float3x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator - (float3x4 lhs, float rhs) { return new float3x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator - (float lhs, float3x4 rhs) { return new float3x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator / (float3x4 lhs, float3x4 rhs) { return new float3x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator / (float3x4 lhs, float rhs) { return new float3x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator / (float lhs, float3x4 rhs) { return new float3x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator % (float3x4 lhs, float3x4 rhs) { return new float3x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator % (float3x4 lhs, float rhs) { return new float3x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator % (float lhs, float3x4 rhs) { return new float3x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator ++ (float3x4 val) { return new float3x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator -- (float3x4 val) { return new float3x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (float3x4 lhs, float3x4 rhs) { return new bool3x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (float3x4 lhs, float rhs) { return new bool3x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator < (float lhs, float3x4 rhs) { return new bool3x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (float3x4 lhs, float3x4 rhs) { return new bool3x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (float3x4 lhs, float rhs) { return new bool3x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator <= (float lhs, float3x4 rhs) { return new bool3x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (float3x4 lhs, float3x4 rhs) { return new bool3x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (float3x4 lhs, float rhs) { return new bool3x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator > (float lhs, float3x4 rhs) { return new bool3x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (float3x4 lhs, float3x4 rhs) { return new bool3x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (float3x4 lhs, float rhs) { return new bool3x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator >= (float lhs, float3x4 rhs) { return new bool3x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator - (float3x4 val) { return new float3x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 operator + (float3x4 val) { return new float3x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (float3x4 lhs, float3x4 rhs) { return new bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (float3x4 lhs, float rhs) { return new bool3x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator == (float lhs, float3x4 rhs) { return new bool3x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (float3x4 lhs, float3x4 rhs) { return new bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (float3x4 lhs, float rhs) { return new bool3x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 operator != (float lhs, float3x4 rhs) { return new bool3x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // [int index] 
        unsafe public float3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (float3x4* array = &this) { return ((float3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (float3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(float3x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((float3x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float3x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f,  {8}f, {9}f, {10}f, {11}f)", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float3x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f,  {8}f, {9}f, {10}f, {11}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(float3 c0, float3 c1, float3 c2, float3 c3) { return new float3x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(float m00, float m01, float m02, float m03,
                                        float m10, float m11, float m12, float m13,
                                        float m20, float m21, float m22, float m23)
        {
            return new float3x4(m00, m01, m02, m03,
                                m10, m11, m12, m13,
                                m20, m21, m22, m23);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(float v) { return new float3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(bool v) { return new float3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(bool3x4 v) { return new float3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(int v) { return new float3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(int3x4 v) { return new float3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(uint v) { return new float3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(uint3x4 v) { return new float3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(double v) { return new float3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(double3x4 v) { return new float3x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x3 transpose(float3x4 v)
        {
            return float4x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z,
                v.c3.x, v.c3.y, v.c3.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float3x4 v)
        {
            return csum(asuint(v.c0) * uint3(0x69B60C81u, 0xE0EB6C25u, 0xF648BEABu) + 
                        asuint(v.c1) * uint3(0x6BDB2B07u, 0xEF63C699u, 0x9001903Fu) + 
                        asuint(v.c2) * uint3(0xA895B9CDu, 0x9D23B201u, 0x4B01D3E1u) + 
                        asuint(v.c3) * uint3(0x7461CA0Du, 0x79725379u, 0xD6258E5Bu)) + 0xEE390C97u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(float3x4 v)
        {
            return (asuint(v.c0) * uint3(0x9C8A2F05u, 0x4DDC6509u, 0x7CF083CBu) + 
                    asuint(v.c1) * uint3(0x5C4D6CEDu, 0xF9137117u, 0xE857DCE1u) + 
                    asuint(v.c2) * uint3(0xF62213C5u, 0x9CDAA959u, 0xAA269ABFu) + 
                    asuint(v.c3) * uint3(0xD54BA36Fu, 0xFD0847B9u, 0x8189A683u)) + 0xB139D651u;
        }

    }
}
