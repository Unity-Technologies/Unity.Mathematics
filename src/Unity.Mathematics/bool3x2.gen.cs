// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct bool3x2 : System.IEquatable<bool3x2>
    {
        public bool3 c0;
        public bool3 c1;


        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x2(bool3 c0, bool3 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x2(bool m00, bool m01,
                       bool m10, bool m11,
                       bool m20, bool m21)
        { 
            this.c0 = new bool3(m00, m10, m20);
            this.c1 = new bool3(m01, m11, m21);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x2(bool v)
        {
            this.c0 = v;
            this.c1 = v;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool3x2(bool v) { return new bool3x2(v); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator & (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator & (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 & rhs, lhs.c1 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator & (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs & rhs.c0, lhs & rhs.c1); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator | (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator | (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 | rhs, lhs.c1 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator | (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs | rhs.c0, lhs | rhs.c1); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator ^ (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator ^ (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator ^ (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }

        // [int index] 
        unsafe public bool3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool3x2* array = &this) { return ((bool3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(bool3x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((bool3x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool3x2({0}, {1},  {2}, {3},  {4}, {5})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z);
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 bool3x2(bool3 c0, bool3 c1) { return new bool3x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 bool3x2(bool m00, bool m01,
                                      bool m10, bool m11,
                                      bool m20, bool m21)
        {
            return new bool3x2(m00, m01,
                               m10, m11,
                               m20, m21);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 bool3x2(bool v) { return new bool3x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 transpose(bool3x2 v)
        {
            return bool2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool3x2 v)
        {
            return csum(select(uint3(0x816EFB5Du, 0xA24E82B7u, 0x45A22087u), uint3(0xFC104C3Bu, 0x5FFF6B19u, 0x5E6CBF3Bu), v.c0) + 
                        select(uint3(0xB546F2A5u, 0xBBCF63E7u, 0xC53F4755u), uint3(0x6985C229u, 0xE133B0B3u, 0xC3E0A3B9u), v.c1));
        }

    }
}
