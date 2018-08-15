// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct float2x4 : System.IEquatable<float2x4>, IFormattable
    {
        public float2 c0;
        public float2 c1;
        public float2 c2;
        public float2 c3;

        public static readonly float2x4 zero = new float2x4(0.0f, 0.0f, 0.0f, 0.0f,   0.0f, 0.0f, 0.0f, 0.0f);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(float2 c0, float2 c1, float2 c2, float2 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(float m00, float m01, float m02, float m03,
                        float m10, float m11, float m12, float m13)
        { 
            this.c0 = new float2(m00, m10);
            this.c1 = new float2(m01, m11);
            this.c2 = new float2(m02, m12);
            this.c3 = new float2(m03, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(bool v)
        {
            this.c0 = math.select(new float2(0.0f), new float2(1.0f), v);
            this.c1 = math.select(new float2(0.0f), new float2(1.0f), v);
            this.c2 = math.select(new float2(0.0f), new float2(1.0f), v);
            this.c3 = math.select(new float2(0.0f), new float2(1.0f), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(bool2x4 v)
        {
            this.c0 = math.select(new float2(0.0f), new float2(1.0f), v.c0);
            this.c1 = math.select(new float2(0.0f), new float2(1.0f), v.c1);
            this.c2 = math.select(new float2(0.0f), new float2(1.0f), v.c2);
            this.c3 = math.select(new float2(0.0f), new float2(1.0f), v.c3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(int2x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(uint2x4 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
            this.c3 = v.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(double v)
        {
            this.c0 = (float2)v;
            this.c1 = (float2)v;
            this.c2 = (float2)v;
            this.c3 = (float2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x4(double2x4 v)
        {
            this.c0 = (float2)v.c0;
            this.c1 = (float2)v.c1;
            this.c2 = (float2)v.c2;
            this.c3 = (float2)v.c3;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x4(float v) { return new float2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x4(bool v) { return new float2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x4(bool2x4 v) { return new float2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x4(int v) { return new float2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x4(int2x4 v) { return new float2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x4(uint v) { return new float2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x4(uint2x4 v) { return new float2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x4(double v) { return new float2x4(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x4(double2x4 v) { return new float2x4(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator * (float2x4 lhs, float2x4 rhs) { return new float2x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator * (float2x4 lhs, float rhs) { return new float2x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator * (float lhs, float2x4 rhs) { return new float2x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator + (float2x4 lhs, float2x4 rhs) { return new float2x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator + (float2x4 lhs, float rhs) { return new float2x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator + (float lhs, float2x4 rhs) { return new float2x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator - (float2x4 lhs, float2x4 rhs) { return new float2x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator - (float2x4 lhs, float rhs) { return new float2x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator - (float lhs, float2x4 rhs) { return new float2x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator / (float2x4 lhs, float2x4 rhs) { return new float2x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator / (float2x4 lhs, float rhs) { return new float2x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator / (float lhs, float2x4 rhs) { return new float2x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator % (float2x4 lhs, float2x4 rhs) { return new float2x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator % (float2x4 lhs, float rhs) { return new float2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator % (float lhs, float2x4 rhs) { return new float2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator ++ (float2x4 val) { return new float2x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator -- (float2x4 val) { return new float2x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator < (float lhs, float2x4 rhs) { return new bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator <= (float lhs, float2x4 rhs) { return new bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator > (float lhs, float2x4 rhs) { return new bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator >= (float lhs, float2x4 rhs) { return new bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator - (float2x4 val) { return new float2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 operator + (float2x4 val) { return new float2x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (float lhs, float2x4 rhs) { return new bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (float2x4 lhs, float2x4 rhs) { return new bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (float2x4 lhs, float rhs) { return new bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (float lhs, float2x4 rhs) { return new bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // [int index] 
        unsafe public float2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (float2x4* array = &this) { return ((float2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (float2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(float2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((float2x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float2x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f)", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float2x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(float2 c0, float2 c1, float2 c2, float2 c3) { return new float2x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(float m00, float m01, float m02, float m03,
                                        float m10, float m11, float m12, float m13)
        {
            return new float2x4(m00, m01, m02, m03,
                                m10, m11, m12, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(float v) { return new float2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(bool v) { return new float2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(bool2x4 v) { return new float2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(int v) { return new float2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(int2x4 v) { return new float2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(uint v) { return new float2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(uint2x4 v) { return new float2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(double v) { return new float2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x4 float2x4(double2x4 v) { return new float2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x2 transpose(float2x4 v)
        {
            return float4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float2x4 v)
        {
            return csum(asuint(v.c0) * uint2(0xFAAF07DDu, 0x625C45BDu) + 
                        asuint(v.c1) * uint2(0xC9F27FCBu, 0x6D2523B1u) + 
                        asuint(v.c2) * uint2(0x6E2BF6A9u, 0xCC74B3B7u) + 
                        asuint(v.c3) * uint2(0x83B58237u, 0x833E3E29u)) + 0xA9D919BFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(float2x4 v)
        {
            return (asuint(v.c0) * uint2(0xC3EC1D97u, 0xB8B208C7u) + 
                    asuint(v.c1) * uint2(0x5D3ED947u, 0x4473BBB1u) + 
                    asuint(v.c2) * uint2(0xCBA11D5Fu, 0x685835CFu) + 
                    asuint(v.c3) * uint2(0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;
        }

    }
}
