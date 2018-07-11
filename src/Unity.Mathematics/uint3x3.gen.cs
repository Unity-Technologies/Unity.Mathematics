// GENERATED CODE
using System.Runtime.CompilerServices;
#pragma warning disable 0660, 0661
namespace Unity.Mathematics
{
    public partial struct uint3x3 : System.IEquatable<uint3x3>
    {
        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(uint3 c0, uint3 c1, uint3 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3x3(uint m00, uint m01, uint m02,
                       uint m10, uint m11, uint m12,
                       uint m20, uint m21, uint m22)
        { 
            this.c0 = new uint3(m00, m10, m20);
            this.c1 = new uint3(m01, m11, m21);
            this.c2 = new uint3(m02, m12, m22);
        }


        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator * (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator * (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator * (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator / (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator / (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator / (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator % (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator % (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator % (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ++ (uint3x3 val) { return new uint3x3 (++val.c0, ++val.c1, ++val.c2); }
        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator -- (uint3x3 val) { return new uint3x3 (--val.c0, --val.c1, --val.c2); }
        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator < (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator <= (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator > (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator >= (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator - (uint3x3 val) { return new uint3x3 (-val.c0, -val.c1, -val.c2); }
        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator + (uint3x3 val) { return new uint3x3 (+val.c0, +val.c1, +val.c2); }
        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator << (uint3x3 lhs, int rhs) { return new uint3x3 (lhs.c0 << rhs, lhs.c1 << rhs, lhs.c2 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator >> (uint3x3 lhs, int rhs) { return new uint3x3 (lhs.c0 >> rhs, lhs.c1 >> rhs, lhs.c2 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (uint3x3 lhs, uint3x3 rhs) { return new bool3x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (uint3x3 lhs, uint rhs) { return new bool3x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (uint lhs, uint3x3 rhs) { return new bool3x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // Equals 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(uint3x3 rhs)  { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        // [int index] 
        unsafe public uint3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (uint3x3* array = &this) { return ((uint3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (uint3* array = &c0) { array[index] = value; }
            }
        }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator & (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator & (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator & (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator | (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator | (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator | (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ^ (uint3x3 lhs, uint3x3 rhs) { return new uint3x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ^ (uint3x3 lhs, uint rhs) { return new uint3x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ^ (uint lhs, uint3x3 rhs) { return new uint3x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 operator ~ (uint3x3 val) { return new uint3x3 (~val.c0, ~val.c1, ~val.c2); }
    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(uint3 c0, uint3 c1, uint3 c2) { return new uint3x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3x3 uint3x3(uint m00, uint m01, uint m02,
                                      uint m10, uint m11, uint m12,
                                      uint m20, uint m21, uint m22)
        {
            return new uint3x3(m00, m01, m02,
                               m10, m11, m12,
                               m20, m21, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint3x3 v)
        {
            return csum(v.c0 * uint3(0xC4B1493Fu, 0xBA0966D3u, 0xAFBEE253u) + 
                        v.c1 * uint3(0x5B419C01u, 0x515D90F5u, 0xEC9F68F3u) + 
                        v.c2 * uint3(0xF9EA92D5u, 0xC2FAFCB9u, 0x616E9CA1u)) + 0xC5C5394Bu;
        }
    }
}
