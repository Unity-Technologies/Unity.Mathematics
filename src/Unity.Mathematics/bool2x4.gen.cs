// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct bool2x4 : System.IEquatable<bool2x4>
    {
        public bool2 c0;
        public bool2 c1;
        public bool2 c2;
        public bool2 c3;


        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x4(bool m00, bool m01, bool m02, bool m03,
                       bool m10, bool m11, bool m12, bool m13)
        { 
            this.c0 = new bool2(m00, m10);
            this.c1 = new bool2(m01, m11);
            this.c2 = new bool2(m02, m12);
            this.c3 = new bool2(m03, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x4(bool v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool2x4(bool v) { return new bool2x4(v); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator & (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator & (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator & (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator | (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator | (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator | (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator ^ (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator ^ (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator ^ (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }

        // [int index] 
        unsafe public bool2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (bool2x4* array = &this) { return ((bool2*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (bool2* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(bool2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((bool2x4)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3) { return new bool2x4(c0, c1, c2, c3); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 bool2x4(bool m00, bool m01, bool m02, bool m03,
                                      bool m10, bool m11, bool m12, bool m13)
        {
            return new bool2x4(m00, m01, m02, m03,
                               m10, m11, m12, m13);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 bool2x4(bool v) { return new bool2x4(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 transpose(bool2x4 v)
        {
            return bool4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool2x4 v)
        {
            return csum(select(uint2(0x4599C793u, 0x83B5E729u), uint2(0xC267163Fu, 0x67BC9149u), v.c0) + 
                        select(uint2(0xAD7C5EC1u, 0x822A7D6Du), uint2(0xB492BF15u, 0xD37220E3u), v.c1) + 
                        select(uint2(0x7AA2C2BDu, 0xE16BC89Du), uint2(0x7AA07CD3u, 0xAF642BA9u), v.c2) + 
                        select(uint2(0xA8F2213Bu, 0x9F3FDC37u), uint2(0xAC60D0C3u, 0x9263662Fu), v.c3));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hash_wide(bool2x4 v)
        {
            return (select(uint2(0xE69626FFu, 0xBD010EEBu), uint2(0x9CEDE1D1u, 0x43BE0B51u), v.c0) + 
                    select(uint2(0xAF836EE1u, 0xB130C137u), uint2(0x54834775u, 0x7C022221u), v.c1) + 
                    select(uint2(0xA2D00EDFu, 0xA8977779u), uint2(0x9F1C739Bu, 0x4B1BD187u), v.c2) + 
                    select(uint2(0x9DF50593u, 0xF18EEB85u), uint2(0x9E19BFC3u, 0x8196B06Fu), v.c3));
        }

    }
}
