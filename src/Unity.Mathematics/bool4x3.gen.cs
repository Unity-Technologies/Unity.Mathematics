// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct bool4x3 : System.IEquatable<bool4x3>
    {
        public bool4 c0;
        public bool4 c1;
        public bool4 c2;


        // constructors
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4x3(bool4 c0, bool4 c1, bool4 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4x3(bool m00, bool m01, bool m02,
                       bool m10, bool m11, bool m12,
                       bool m20, bool m21, bool m22,
                       bool m30, bool m31, bool m32)
        { 
            this.c0 = new bool4(m00, m10, m20, m30);
            this.c1 = new bool4(m01, m11, m21, m31);
            this.c2 = new bool4(m02, m12, m22, m32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4x3(bool v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }


        // conversions
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool4x3(bool v) { return new bool4x3(v); }


        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (bool4x3 lhs, bool4x3 rhs) { return new bool4x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (bool4x3 lhs, bool rhs) { return new bool4x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator == (bool lhs, bool4x3 rhs) { return new bool4x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (bool4x3 lhs, bool4x3 rhs) { return new bool4x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (bool4x3 lhs, bool rhs) { return new bool4x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator != (bool lhs, bool4x3 rhs) { return new bool4x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }

        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator & (bool4x3 lhs, bool4x3 rhs) { return new bool4x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator & (bool4x3 lhs, bool rhs) { return new bool4x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator & (bool lhs, bool4x3 rhs) { return new bool4x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator | (bool4x3 lhs, bool4x3 rhs) { return new bool4x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator | (bool4x3 lhs, bool rhs) { return new bool4x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator | (bool lhs, bool4x3 rhs) { return new bool4x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator ^ (bool4x3 lhs, bool4x3 rhs) { return new bool4x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator ^ (bool4x3 lhs, bool rhs) { return new bool4x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 operator ^ (bool lhs, bool4x3 rhs) { return new bool4x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }

        // [int index] 
        unsafe public bool4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (bool4x3* array = &this) { return ((bool4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (bool4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(bool4x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((bool4x3)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z, c0.w, c1.w, c2.w);
        }

    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 bool4x3(bool4 c0, bool4 c1, bool4 c2) { return new bool4x3(c0, c1, c2); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 bool4x3(bool m00, bool m01, bool m02,
                                      bool m10, bool m11, bool m12,
                                      bool m20, bool m21, bool m22,
                                      bool m30, bool m31, bool m32)
        {
            return new bool4x3(m00, m01, m02,
                               m10, m11, m12,
                               m20, m21, m22,
                               m30, m31, m32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x3 bool4x3(bool v) { return new bool4x3(v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x4 transpose(bool4x3 v)
        {
            return bool3x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool4x3 v)
        {
            return csum(select(uint4(0xFD80290Bu, 0x8B65ADB7u, 0xDFF4F563u, 0x7069770Du), uint4(0xD1224537u, 0xE99ED6F3u, 0x48125549u, 0xEEE2123Bu), v.c0) + 
                        select(uint4(0xE3AD9FE5u, 0xCE1CF8BFu, 0x7BE39F3Bu, 0xFAB9913Fu), uint4(0xB4501269u, 0xE04B89FDu, 0xDB3DE101u, 0x7B6D1B4Bu), v.c1) + 
                        select(uint4(0x58399E77u, 0x5EAC29C9u, 0xFC6014F9u, 0x6BF6693Fu), uint4(0x9D1B1D9Bu, 0xF842F5C1u, 0xA47EC335u, 0xA477DF57u), v.c2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hash_wide(bool4x3 v)
        {
            return (select(uint4(0xC4B1493Fu, 0xBA0966D3u, 0xAFBEE253u, 0x5B419C01u), uint4(0x515D90F5u, 0xEC9F68F3u, 0xF9EA92D5u, 0xC2FAFCB9u), v.c0) + 
                    select(uint4(0x616E9CA1u, 0xC5C5394Bu, 0xCAE78587u, 0x7A1541C9u), uint4(0xF83BD927u, 0x6A243BCBu, 0x509B84C9u, 0x91D13847u), v.c1) + 
                    select(uint4(0x52F7230Fu, 0xCF286E83u, 0xE121E6ADu, 0xC9CA1249u), uint4(0x69B60C81u, 0xE0EB6C25u, 0xF648BEABu, 0x6BDB2B07u), v.c2));
        }

    }
}
