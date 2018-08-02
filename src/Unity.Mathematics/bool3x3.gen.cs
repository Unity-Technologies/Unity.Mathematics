// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct bool3x3 : System.IEquatable<bool3x3>
    {
        public bool3 c0;
        public bool3 c1;
        public bool3 c2;


        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x3(bool3 c0, bool3 c1, bool3 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x3(bool m00, bool m01, bool m02,
                       bool m10, bool m11, bool m12,
                       bool m20, bool m21, bool m22)
        { 
            this.c0 = new bool3(m00, m10, m20);
            this.c1 = new bool3(m01, m11, m21);
            this.c2 = new bool3(m02, m12, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x3(bool v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool3x3(bool v) { return new bool3x3(v); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (bool3x3 lhs, bool3x3 rhs) { return new bool3x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (bool3x3 lhs, bool rhs) { return new bool3x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator == (bool lhs, bool3x3 rhs) { return new bool3x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (bool3x3 lhs, bool3x3 rhs) { return new bool3x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (bool3x3 lhs, bool rhs) { return new bool3x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator != (bool lhs, bool3x3 rhs) { return new bool3x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator & (bool3x3 lhs, bool3x3 rhs) { return new bool3x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator & (bool3x3 lhs, bool rhs) { return new bool3x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator & (bool lhs, bool3x3 rhs) { return new bool3x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator | (bool3x3 lhs, bool3x3 rhs) { return new bool3x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator | (bool3x3 lhs, bool rhs) { return new bool3x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator | (bool lhs, bool3x3 rhs) { return new bool3x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator ^ (bool3x3 lhs, bool3x3 rhs) { return new bool3x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator ^ (bool3x3 lhs, bool rhs) { return new bool3x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 operator ^ (bool lhs, bool3x3 rhs) { return new bool3x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }

        // [int index] 
        unsafe public bool3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (bool3x3* array = &this) { return ((bool3*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (bool3* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(bool3x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((bool3x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z);
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 bool3x3(bool3 c0, bool3 c1, bool3 c2) { return new bool3x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 bool3x3(bool m00, bool m01, bool m02,
                                      bool m10, bool m11, bool m12,
                                      bool m20, bool m21, bool m22)
        {
            return new bool3x3(m00, m01, m02,
                               m10, m11, m12,
                               m20, m21, m22);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 bool3x3(bool v) { return new bool3x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x3 transpose(bool3x3 v)
        {
            return bool3x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool3x3 v)
        {
            return csum(select(uint3(0xFA62D721u, 0x7E4DB1CFu, 0x68EEE0F5u), uint3(0xBC3B0A59u, 0x816EFB5Du, 0xA24E82B7u), v.c0) + 
                        select(uint3(0x45A22087u, 0xFC104C3Bu, 0x5FFF6B19u), uint3(0x5E6CBF3Bu, 0xB546F2A5u, 0xBBCF63E7u), v.c1) + 
                        select(uint3(0xC53F4755u, 0x6985C229u, 0xE133B0B3u), uint3(0xC3E0A3B9u, 0xFE31134Fu, 0x712A34D7u), v.c2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hash_wide(bool3x3 v)
        {
            return (select(uint3(0x9D77A59Bu, 0x4942CA39u, 0xB40EC62Du), uint3(0x565ED63Fu, 0x93C30C2Bu, 0xDCAF0351u), v.c0) + 
                    select(uint3(0x6E050B01u, 0x750FDBF5u, 0x7F3DD499u), uint3(0x52EAAEBBu, 0x4599C793u, 0x83B5E729u), v.c1) + 
                    select(uint3(0xC267163Fu, 0x67BC9149u, 0xAD7C5EC1u), uint3(0x822A7D6Du, 0xB492BF15u, 0xD37220E3u), v.c2));
        }

    }
}
