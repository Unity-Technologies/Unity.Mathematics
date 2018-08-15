// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct float2x3 : System.IEquatable<float2x3>, IFormattable
    {
        public float2 c0;
        public float2 c1;
        public float2 c2;

        public static readonly float2x3 zero = new float2x3(0.0f, 0.0f, 0.0f,   0.0f, 0.0f, 0.0f);

        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(float2 c0, float2 c1, float2 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(float m00, float m01, float m02,
                        float m10, float m11, float m12)
        { 
            this.c0 = new float2(m00, m10);
            this.c1 = new float2(m01, m11);
            this.c2 = new float2(m02, m12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(float v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(bool v)
        {
            this.c0 = math.select(new float2(0.0f), new float2(1.0f), v);
            this.c1 = math.select(new float2(0.0f), new float2(1.0f), v);
            this.c2 = math.select(new float2(0.0f), new float2(1.0f), v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(bool2x3 v)
        {
            this.c0 = math.select(new float2(0.0f), new float2(1.0f), v.c0);
            this.c1 = math.select(new float2(0.0f), new float2(1.0f), v.c1);
            this.c2 = math.select(new float2(0.0f), new float2(1.0f), v.c2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(int v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(int2x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(uint v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(uint2x3 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
            this.c2 = v.c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(double v)
        {
            this.c0 = (float2)v;
            this.c1 = (float2)v;
            this.c2 = (float2)v;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x3(double2x3 v)
        {
            this.c0 = (float2)v.c0;
            this.c1 = (float2)v.c1;
            this.c2 = (float2)v.c2;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x3(float v) { return new float2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x3(bool v) { return new float2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x3(bool2x3 v) { return new float2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x3(int v) { return new float2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x3(int2x3 v) { return new float2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x3(uint v) { return new float2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float2x3(uint2x3 v) { return new float2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x3(double v) { return new float2x3(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float2x3(double2x3 v) { return new float2x3(v); }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator * (float2x3 lhs, float2x3 rhs) { return new float2x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator * (float2x3 lhs, float rhs) { return new float2x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator * (float lhs, float2x3 rhs) { return new float2x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator + (float2x3 lhs, float2x3 rhs) { return new float2x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator + (float2x3 lhs, float rhs) { return new float2x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator + (float lhs, float2x3 rhs) { return new float2x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator - (float2x3 lhs, float2x3 rhs) { return new float2x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator - (float2x3 lhs, float rhs) { return new float2x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator - (float lhs, float2x3 rhs) { return new float2x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator / (float2x3 lhs, float2x3 rhs) { return new float2x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator / (float2x3 lhs, float rhs) { return new float2x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator / (float lhs, float2x3 rhs) { return new float2x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator % (float2x3 lhs, float2x3 rhs) { return new float2x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator % (float2x3 lhs, float rhs) { return new float2x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator % (float lhs, float2x3 rhs) { return new float2x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator ++ (float2x3 val) { return new float2x3 (++val.c0, ++val.c1, ++val.c2); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator -- (float2x3 val) { return new float2x3 (--val.c0, --val.c1, --val.c2); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator < (float lhs, float2x3 rhs) { return new bool2x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator <= (float lhs, float2x3 rhs) { return new bool2x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator > (float lhs, float2x3 rhs) { return new bool2x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator >= (float lhs, float2x3 rhs) { return new bool2x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator - (float2x3 val) { return new float2x3 (-val.c0, -val.c1, -val.c2); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 operator + (float2x3 val) { return new float2x3 (+val.c0, +val.c1, +val.c2); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (float lhs, float2x3 rhs) { return new bool2x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (float2x3 lhs, float2x3 rhs) { return new bool2x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (float2x3 lhs, float rhs) { return new bool2x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (float lhs, float2x3 rhs) { return new bool2x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // [int index] 
        unsafe public float2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (float2x3* array = &this) { return ((float2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (float2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(float2x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((float2x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float2x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f)", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float2x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(float2 c0, float2 c1, float2 c2) { return new float2x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(float m00, float m01, float m02,
                                        float m10, float m11, float m12)
        {
            return new float2x3(m00, m01, m02,
                                m10, m11, m12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(float v) { return new float2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(bool v) { return new float2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(bool2x3 v) { return new float2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(int v) { return new float2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(int2x3 v) { return new float2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(uint v) { return new float2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(uint2x3 v) { return new float2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(double v) { return new float2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 float2x3(double2x3 v) { return new float2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 transpose(float2x3 v)
        {
            return float3x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float2x3 v)
        {
            return csum(asuint(v.c0) * uint2(0xFA62D721u, 0x7E4DB1CFu) + 
                        asuint(v.c1) * uint2(0x68EEE0F5u, 0xBC3B0A59u) + 
                        asuint(v.c2) * uint2(0x816EFB5Du, 0xA24E82B7u)) + 0x45A22087u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(float2x3 v)
        {
            return (asuint(v.c0) * uint2(0xFC104C3Bu, 0x5FFF6B19u) + 
                    asuint(v.c1) * uint2(0x5E6CBF3Bu, 0xB546F2A5u) + 
                    asuint(v.c2) * uint2(0xBBCF63E7u, 0xC53F4755u)) + 0x6985C229u;
        }

    }
}
