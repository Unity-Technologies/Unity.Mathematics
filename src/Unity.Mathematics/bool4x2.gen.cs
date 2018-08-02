// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct bool4x2 : System.IEquatable<bool4x2>
    {
        public bool4 c0;
        public bool4 c1;


        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4x2(bool4 c0, bool4 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4x2(bool m00, bool m01,
                       bool m10, bool m11,
                       bool m20, bool m21,
                       bool m30, bool m31)
        { 
            this.c0 = new bool4(m00, m10, m20, m30);
            this.c1 = new bool4(m01, m11, m21, m31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4x2(bool v)
        {
            this.c0 = v;
            this.c1 = v;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool4x2(bool v) { return new bool4x2(v); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (bool4x2 lhs, bool4x2 rhs) { return new bool4x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (bool4x2 lhs, bool rhs) { return new bool4x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (bool lhs, bool4x2 rhs) { return new bool4x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (bool4x2 lhs, bool4x2 rhs) { return new bool4x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (bool4x2 lhs, bool rhs) { return new bool4x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (bool lhs, bool4x2 rhs) { return new bool4x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator & (bool4x2 lhs, bool4x2 rhs) { return new bool4x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator & (bool4x2 lhs, bool rhs) { return new bool4x2 (lhs.c0 & rhs, lhs.c1 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator & (bool lhs, bool4x2 rhs) { return new bool4x2 (lhs & rhs.c0, lhs & rhs.c1); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator | (bool4x2 lhs, bool4x2 rhs) { return new bool4x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator | (bool4x2 lhs, bool rhs) { return new bool4x2 (lhs.c0 | rhs, lhs.c1 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator | (bool lhs, bool4x2 rhs) { return new bool4x2 (lhs | rhs.c0, lhs | rhs.c1); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator ^ (bool4x2 lhs, bool4x2 rhs) { return new bool4x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator ^ (bool4x2 lhs, bool rhs) { return new bool4x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator ^ (bool lhs, bool4x2 rhs) { return new bool4x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }

        // [int index] 
        unsafe public bool4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool4x2* array = &this) { return ((bool4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(bool4x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((bool4x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z, c0.w, c1.w);
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 bool4x2(bool4 c0, bool4 c1) { return new bool4x2(c0, c1); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 bool4x2(bool m00, bool m01,
                                      bool m10, bool m11,
                                      bool m20, bool m21,
                                      bool m30, bool m31)
        {
            return new bool4x2(m00, m01,
                               m10, m11,
                               m20, m21,
                               m30, m31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 bool4x2(bool v) { return new bool4x2(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 transpose(bool4x2 v)
        {
            return bool2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool4x2 v)
        {
            return csum(select(uint4(0x56A1530Du, 0x804B722Du, 0x738E50E5u, 0x4FC93C25u), uint4(0xCD0445A5u, 0xD2B90D9Bu, 0xD35C9B2Du, 0xA10D9E27u), v.c0) + 
                        select(uint4(0x568DAAA9u, 0x7530254Fu, 0x9F090439u, 0x5E9F85C9u), uint4(0x8C4CA03Fu, 0xB8D969EDu, 0xAC5DB57Bu, 0xA91A02EDu), v.c1));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hash_wide(bool4x2 v)
        {
            return (select(uint4(0xB3C49313u, 0xF43A9ABBu, 0x84E7E01Bu, 0x8E055BE5u), uint4(0x6E624EB7u, 0x7383ED49u, 0xDD49C23Bu, 0xEBD0D005u), v.c0) + 
                    select(uint4(0x91475DF7u, 0x55E84827u, 0x90A285BBu, 0x5D19E1D5u), uint4(0xFAAF07DDu, 0x625C45BDu, 0xC9F27FCBu, 0x6D2523B1u), v.c1));
        }

    }
}
