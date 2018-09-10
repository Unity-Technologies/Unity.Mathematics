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


        /// <summary>Constructs a bool2x4 matrix from four bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3)
        { 
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a bool2x4 matrix from 8 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x4(bool m00, bool m01, bool m02, bool m03,
                       bool m10, bool m11, bool m12, bool m13)
        { 
            this.c0 = new bool2(m00, m10);
            this.c1 = new bool2(m01, m11);
            this.c2 = new bool2(m02, m12);
            this.c3 = new bool2(m03, m13);
        }

        /// <summary>Constructs a bool2x4 matrix from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2x4(bool v)
        {
            this.c0 = v;
            this.c1 = v;
            this.c2 = v;
            this.c3 = v;
        }


        /// <summary>Implicitly converts a single bool value to a bool2x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool2x4(bool v) { return new bool2x4(v); }


        /// <summary>Returns the result of a componentwise equality operation on two bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator == (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator != (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }


        /// <summary>Returns the result of a componentwise not operation on a bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator ! (bool2x4 val) { return new bool2x4 (!val.c0, !val.c1, !val.c2, !val.c3); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator & (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator & (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator & (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator | (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator | (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator | (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator ^ (bool2x4 lhs, bool2x4 rhs) { return new bool2x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator ^ (bool2x4 lhs, bool rhs) { return new bool2x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 operator ^ (bool lhs, bool2x4 rhs) { return new bool2x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }



        /// <summary>Returns the bool2 element at a specified index.</summary>
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

        /// <summary>Returns true if the bool2x4 is equal to a given bool2x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(bool2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the bool2x4 is equal to a given bool2x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((bool2x4)o); }


        /// <summary>Returns a hash code for the bool2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the bool2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

    }

    public static partial class math
    {
        /// <summary>Returns a bool2x4 matrix constructed from four bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 bool2x4(bool2 c0, bool2 c1, bool2 c2, bool2 c3) { return new bool2x4(c0, c1, c2, c3); }

        /// <summary>Returns a bool2x4 matrix constructed from from 8 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 bool2x4(bool m00, bool m01, bool m02, bool m03,
                                      bool m10, bool m11, bool m12, bool m13)
        {
            return new bool2x4(m00, m01, m02, m03,
                               m10, m11, m12, m13);
        }

        /// <summary>Returns a bool2x4 matrix constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x4 bool2x4(bool v) { return new bool2x4(v); }

        /// <summary>Return the bool4x2 transpose of a bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 transpose(bool2x4 v)
        {
            return bool4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        /// <summary>Returns a uint hash code of a bool2x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool2x4 v)
        {
            return csum(select(uint2(0x4599C793u, 0x83B5E729u), uint2(0xC267163Fu, 0x67BC9149u), v.c0) + 
                        select(uint2(0xAD7C5EC1u, 0x822A7D6Du), uint2(0xB492BF15u, 0xD37220E3u), v.c1) + 
                        select(uint2(0x7AA2C2BDu, 0xE16BC89Du), uint2(0x7AA07CD3u, 0xAF642BA9u), v.c2) + 
                        select(uint2(0xA8F2213Bu, 0x9F3FDC37u), uint2(0xAC60D0C3u, 0x9263662Fu), v.c3));
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a bool2x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(bool2x4 v)
        {
            return (select(uint2(0xE69626FFu, 0xBD010EEBu), uint2(0x9CEDE1D1u, 0x43BE0B51u), v.c0) + 
                    select(uint2(0xAF836EE1u, 0xB130C137u), uint2(0x54834775u, 0x7C022221u), v.c1) + 
                    select(uint2(0xA2D00EDFu, 0xA8977779u), uint2(0x9F1C739Bu, 0x4B1BD187u), v.c2) + 
                    select(uint2(0x9DF50593u, 0xF18EEB85u), uint2(0x9E19BFC3u, 0x8196B06Fu), v.c3));
        }

    }
}
