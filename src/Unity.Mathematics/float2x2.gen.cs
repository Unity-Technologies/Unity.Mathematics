// GENERATED CODE
using System.Runtime.CompilerServices;
#pragma warning disable 0660, 0661
namespace Unity.Mathematics
{
    public partial struct float2x2 : System.IEquatable<float2x2>
    {
        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(float2 c0, float2 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2x2(float m00, float m01,
                        float m10, float m11)
        { 
            this.c0 = new float2(m00, m10);
            this.c1 = new float2(m01, m11);
        }


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

        // Equals 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(float2x2 rhs)  { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

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

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(float2 c0, float2 c1) { return new float2x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x2 float2x2(float m00, float m01,
                                        float m10, float m11)
        {
            return new float2x2(m00, m01,
                                m10, m11);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float2x2 v)
        {
            return csum(asuint(v.c0) * uint2(0x833E3E29u, 0xA9D919BFu) + 
                        asuint(v.c1) * uint2(0xC3EC1D97u, 0xB8B208C7u)) + 0x5D3ED947u;
        }
    }
}
