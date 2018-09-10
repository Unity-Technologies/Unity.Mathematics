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


        /// <summary>Constructs a bool2x3 matrix from three bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x3(bool2 c0, bool2 c1, bool2 c2)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a bool2x3 matrix from 6 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x3(bool m00, bool m01, bool m02,
                       bool m10, bool m11, bool m12)
        { 
            this.c0 = new bool2(m00, m10);
            this.c1 = new bool2(m01, m11);
            this.c2 = new bool2(m02, m12);
        }

        /// <summary>Constructs a bool2x3 matrix from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x3(bool v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
        }


        /// <summary>Implicitly converts a single bool value to a bool2x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool2x3(bool v) { return new bool2x3(v); }


        /// <summary>Returns the result of a componentwise equality operation on two bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator == (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator != (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }


        /// <summary>Returns the result of a componentwise not operation on a bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator ! (bool2x3 val) { return new bool2x3 (!val.c0, !val.c1, !val.c2); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator & (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator & (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator & (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator | (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator | (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator | (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator ^ (bool2x3 lhs, bool2x3 rhs) { return new bool2x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator ^ (bool2x3 lhs, bool rhs) { return new bool2x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 operator ^ (bool lhs, bool2x3 rhs) { return new bool2x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }



        /// <summary>Returns the bool2 element at a specified index.</summary>
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

        /// <summary>Returns true if the bool2x3 is equal to a given bool2x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(bool2x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the bool2x3 is equal to a given bool2x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((bool2x3)o); }


        /// <summary>Returns a hash code for the bool2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the bool2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y);
        }

    }

    public static partial class math
    {
        /// <summary>Returns a bool2x3 matrix constructed from three bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 bool2x3(bool2 c0, bool2 c1, bool2 c2) { return new bool2x3(c0, c1, c2); }

        /// <summary>Returns a bool2x3 matrix constructed from from 6 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 bool2x3(bool m00, bool m01, bool m02,
                                      bool m10, bool m11, bool m12)
        {
            return new bool2x3(m00, m01, m02,
                               m10, m11, m12);
        }

        /// <summary>Returns a bool2x3 matrix constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 bool2x3(bool v) { return new bool2x3(v); }

        /// <summary>Return the bool3x2 transpose of a bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 transpose(bool2x3 v)
        {
            return bool3x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y);
        }

        /// <summary>Returns a uint hash code of a bool2x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool2x3 v)
        {
            return csum(select(uint2(0x616E9CA1u, 0xC5C5394Bu), uint2(0xCAE78587u, 0x7A1541C9u), v.c0) + 
                        select(uint2(0xF83BD927u, 0x6A243BCBu), uint2(0x509B84C9u, 0x91D13847u), v.c1) + 
                        select(uint2(0x52F7230Fu, 0xCF286E83u), uint2(0xE121E6ADu, 0xC9CA1249u), v.c2));
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a bool2x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(bool2x3 v)
        {
            return (select(uint2(0x69B60C81u, 0xE0EB6C25u), uint2(0xF648BEABu, 0x6BDB2B07u), v.c0) + 
                    select(uint2(0xEF63C699u, 0x9001903Fu), uint2(0xA895B9CDu, 0x9D23B201u), v.c1) + 
                    select(uint2(0x4B01D3E1u, 0x7461CA0Du), uint2(0x79725379u, 0xD6258E5Bu), v.c2));
        }

    }
}
