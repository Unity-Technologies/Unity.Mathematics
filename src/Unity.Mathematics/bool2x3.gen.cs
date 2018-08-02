// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct bool2x3 : System.IEquatable<bool2x3>
    {
        public bool2 c0;
        public bool2 c1;
        public bool2 c2;


        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x3(bool2 c0, bool2 c1, bool2 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x3(bool m00, bool m01, bool m02,
                       bool m10, bool m11, bool m12)
        { 
            this.c0 = new bool2(m00, m10);
            this.c1 = new bool2(m01, m11);
            this.c2 = new bool2(m02, m12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x3(bool v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool2x3(bool v) { return new bool2x3(v); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator & (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator & (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator & (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator | (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator | (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator | (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator ^ (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator ^ (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator ^ (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }

        // [int index] 
        unsafe public bool2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (bool2x3* array = &this) { return ((bool2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (bool2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(bool2x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((bool2x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y);
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 bool2x3(bool2 c0, bool2 c1, bool2 c2) { return new bool2x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 bool2x3(bool m00, bool m01, bool m02,
                                      bool m10, bool m11, bool m12)
        {
            return new bool2x3(m00, m01, m02,
                               m10, m11, m12);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 bool2x3(bool v) { return new bool2x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 transpose(bool2x3 v)
        {
            return bool3x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool2x3 v)
        {
            return csum(select(uint2(0x616E9CA1u, 0xC5C5394Bu), uint2(0xCAE78587u, 0x7A1541C9u), v.c0) + 
                        select(uint2(0xF83BD927u, 0x6A243BCBu), uint2(0x509B84C9u, 0x91D13847u), v.c1) + 
                        select(uint2(0x52F7230Fu, 0xCF286E83u), uint2(0xE121E6ADu, 0xC9CA1249u), v.c2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(bool2x3 v)
        {
            return (select(uint2(0x69B60C81u, 0xE0EB6C25u), uint2(0xF648BEABu, 0x6BDB2B07u), v.c0) + 
                    select(uint2(0xEF63C699u, 0x9001903Fu), uint2(0xA895B9CDu, 0x9D23B201u), v.c1) + 
                    select(uint2(0x4B01D3E1u, 0x7461CA0Du), uint2(0x79725379u, 0xD6258E5Bu), v.c2));
        }

    }
}
