// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct float4x2 : System.IEquatable<float4x2>, IFormattable
    {
        public float4 c0;
        public float4 c1;

        public static readonly float4x2 zero = new float4x2(0.0f, 0.0f,   0.0f, 0.0f,   0.0f, 0.0f,   0.0f, 0.0f);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(float4 c0, float4 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(float m00, float m01,
                        float m10, float m11,
                        float m20, float m21,
                        float m30, float m31)
        { 
            this.c0 = new float4(m00, m10, m20, m30);
            this.c1 = new float4(m01, m11, m21, m31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(float v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(bool v)
        {
            this.c0 = math.select(new float4(0.0f), new float4(1.0f), v);
            this.c1 = math.select(new float4(0.0f), new float4(1.0f), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(bool4x2 v)
        {
            this.c0 = math.select(new float4(0.0f), new float4(1.0f), v.c0);
            this.c1 = math.select(new float4(0.0f), new float4(1.0f), v.c1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(int4x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(uint4x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(double v)
        {
            this.c0 = (float4)v;
            this.c1 = (float4)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4x2(double4x2 v)
        {
            this.c0 = (float4)v.c0;
            this.c1 = (float4)v.c1;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4x2(float v) { return new float4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float4x2(bool v) { return new float4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float4x2(bool4x2 v) { return new float4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4x2(int v) { return new float4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4x2(int4x2 v) { return new float4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4x2(uint v) { return new float4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4x2(uint4x2 v) { return new float4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float4x2(double v) { return new float4x2(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float4x2(double4x2 v) { return new float4x2(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator * (float4x2 lhs, float4x2 rhs) { return new float4x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator * (float4x2 lhs, float rhs) { return new float4x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator * (float lhs, float4x2 rhs) { return new float4x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator + (float4x2 lhs, float4x2 rhs) { return new float4x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator + (float4x2 lhs, float rhs) { return new float4x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator + (float lhs, float4x2 rhs) { return new float4x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator - (float4x2 lhs, float4x2 rhs) { return new float4x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator - (float4x2 lhs, float rhs) { return new float4x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator - (float lhs, float4x2 rhs) { return new float4x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator / (float4x2 lhs, float4x2 rhs) { return new float4x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator / (float4x2 lhs, float rhs) { return new float4x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator / (float lhs, float4x2 rhs) { return new float4x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator % (float4x2 lhs, float4x2 rhs) { return new float4x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator % (float4x2 lhs, float rhs) { return new float4x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator % (float lhs, float4x2 rhs) { return new float4x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator ++ (float4x2 val) { return new float4x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator -- (float4x2 val) { return new float4x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (float4x2 lhs, float4x2 rhs) { return new bool4x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (float4x2 lhs, float rhs) { return new bool4x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (float lhs, float4x2 rhs) { return new bool4x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (float4x2 lhs, float4x2 rhs) { return new bool4x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (float4x2 lhs, float rhs) { return new bool4x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (float lhs, float4x2 rhs) { return new bool4x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (float4x2 lhs, float4x2 rhs) { return new bool4x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (float4x2 lhs, float rhs) { return new bool4x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (float lhs, float4x2 rhs) { return new bool4x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (float4x2 lhs, float4x2 rhs) { return new bool4x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (float4x2 lhs, float rhs) { return new bool4x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (float lhs, float4x2 rhs) { return new bool4x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator - (float4x2 val) { return new float4x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 operator + (float4x2 val) { return new float4x2 (+val.c0, +val.c1); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (float4x2 lhs, float4x2 rhs) { return new bool4x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (float4x2 lhs, float rhs) { return new bool4x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (float lhs, float4x2 rhs) { return new bool4x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (float4x2 lhs, float4x2 rhs) { return new bool4x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (float4x2 lhs, float rhs) { return new bool4x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (float lhs, float4x2 rhs) { return new bool4x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // [int index] 
        unsafe public float4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float4x2* array = &this) { return ((float4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(float4x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((float4x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float4x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f,  {6}f, {7}f)", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z, c0.w, c1.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float4x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f,  {6}f, {7}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(float4 c0, float4 c1) { return new float4x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(float m00, float m01,
                                        float m10, float m11,
                                        float m20, float m21,
                                        float m30, float m31)
        {
            return new float4x2(m00, m01,
                                m10, m11,
                                m20, m21,
                                m30, m31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(float v) { return new float4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(bool v) { return new float4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(bool4x2 v) { return new float4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(int v) { return new float4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(int4x2 v) { return new float4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(uint v) { return new float4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(uint4x2 v) { return new float4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(double v) { return new float4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 float4x2(double4x2 v) { return new float4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 transpose(float4x2 v)
        {
            return float2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float4x2 v)
        {
            return csum(asuint(v.c0) * uint4(0x5BA2C50Bu, 0x8C455ACBu, 0xCD266C89u, 0xF1852A33u) + 
                        asuint(v.c1) * uint4(0x77E35E77u, 0x863E3729u, 0xE191B035u, 0x68586FAFu)) + 0xD4DFF6D3u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hash_wide(float4x2 v)
        {
            return (asuint(v.c0) * uint4(0xCB634F4Du, 0x9B13B92Du, 0x4ABF0813u, 0x86068063u) + 
                    asuint(v.c1) * uint4(0xD75513F9u, 0x5AB3E8CDu, 0x676E8407u, 0xB36DE767u)) + 0x6FCA387Du;
        }

    }
}
