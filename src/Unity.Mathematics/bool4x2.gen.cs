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
            return csum(select(uint4(0xCAE78587u, 0x7A1541C9u, 0xF83BD927u, 0x6A243BCBu), uint4(0x509B84C9u, 0x91D13847u, 0x52F7230Fu, 0xCF286E83u), v.c0) + 
                        select(uint4(0xE121E6ADu, 0xC9CA1249u, 0x69B60C81u, 0xE0EB6C25u), uint4(0xF648BEABu, 0x6BDB2B07u, 0xEF63C699u, 0x9001903Fu), v.c1));
        }

    }
}
