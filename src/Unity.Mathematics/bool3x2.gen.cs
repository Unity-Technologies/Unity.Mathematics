//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    [Il2CppEagerStaticClassConstruction]
    public partial struct bool3x2 : System.IEquatable<bool3x2>
    {
        public bool3 c0;
        public bool3 c1;


        /// <summary>Constructs a bool3x2 matrix from two bool3 vectors.</summary>
        /// <param name="c0">The matrix column c0 will be set to this value.</param>
        /// <param name="c1">The matrix column c1 will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x2(bool3 c0, bool3 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a bool3x2 matrix from 6 bool values given in row-major order.</summary>
        /// <param name="m00">The matrix at row 0, column 0 will be set to this value.</param>
        /// <param name="m01">The matrix at row 0, column 1 will be set to this value.</param>
        /// <param name="m10">The matrix at row 1, column 0 will be set to this value.</param>
        /// <param name="m11">The matrix at row 1, column 1 will be set to this value.</param>
        /// <param name="m20">The matrix at row 2, column 0 will be set to this value.</param>
        /// <param name="m21">The matrix at row 2, column 1 will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x2(bool m00, bool m01,
                       bool m10, bool m11,
                       bool m20, bool m21)
        {
            this.c0 = new bool3(m00, m10, m20);
            this.c1 = new bool3(m01, m11, m21);
        }

        /// <summary>Constructs a bool3x2 matrix from a single bool value by assigning it to every component.</summary>
        /// <param name="v">bool to convert to bool3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3x2(bool v)
        {
            this.c0 = v;
            this.c1 = v;
        }


        /// <summary>Implicitly converts a single bool value to a bool3x2 matrix by assigning it to every component.</summary>
        /// <param name="v">bool to convert to bool3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator bool3x2(bool v) { return new bool3x2(v); }


        /// <summary>Returns the result of a componentwise equality operation on two bool3x2 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise equality.</param>
        /// <returns>bool3x2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a bool3x2 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise equality.</param>
        /// <returns>bool3x2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a bool3x2 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise equality.</param>
        /// <returns>bool3x2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two bool3x2 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise not equal.</param>
        /// <returns>bool3x2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool3x2 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise not equal.</param>
        /// <returns>bool3x2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a bool3x2 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise not equal.</param>
        /// <returns>bool3x2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs != rhs.c0, lhs != rhs.c1); }


        /// <summary>Returns the result of a componentwise not operation on a bool3x2 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise not.</param>
        /// <returns>bool3x2 result of the componentwise not.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator ! (bool3x2 val) { return new bool3x2 (!val.c0, !val.c1); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two bool3x2 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise bitwise and.</param>
        /// <returns>bool3x2 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator & (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool3x2 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise and.</param>
        /// <returns>bool3x2 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator & (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 & rhs, lhs.c1 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a bool3x2 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise and.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise bitwise and.</param>
        /// <returns>bool3x2 result of the componentwise bitwise and.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator & (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs & rhs.c0, lhs & rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two bool3x2 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise bitwise or.</param>
        /// <returns>bool3x2 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator | (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool3x2 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise or.</param>
        /// <returns>bool3x2 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator | (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 | rhs, lhs.c1 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a bool3x2 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise or.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise bitwise or.</param>
        /// <returns>bool3x2 result of the componentwise bitwise or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator | (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs | rhs.c0, lhs | rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two bool3x2 matrices.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>bool3x2 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator ^ (bool3x2 lhs, bool3x2 rhs) { return new bool3x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool3x2 matrix and a bool value.</summary>
        /// <param name="lhs">Left hand side bool3x2 to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side bool to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>bool3x2 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator ^ (bool3x2 lhs, bool rhs) { return new bool3x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a bool3x2 matrix.</summary>
        /// <param name="lhs">Left hand side bool to use to compute componentwise bitwise exclusive or.</param>
        /// <param name="rhs">Right hand side bool3x2 to use to compute componentwise bitwise exclusive or.</param>
        /// <returns>bool3x2 result of the componentwise bitwise exclusive or.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator ^ (bool lhs, bool3x2 rhs) { return new bool3x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }



        /// <summary>Returns the bool3 element at a specified index.</summary>
        unsafe public ref bool3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool3x2* array = &this) { return ref ((bool3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the bool3x2 is equal to a given bool3x2, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(bool3x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the bool3x2 is equal to a given bool3x2, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is bool3x2 converted && Equals(converted); }


        /// <summary>Returns a hash code for the bool3x2.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the bool3x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("bool3x2({0}, {1},  {2}, {3},  {4}, {5})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z);
        }

    }

    public static partial class math
    {
        /// <summary>Returns a bool3x2 matrix constructed from two bool3 vectors.</summary>
        /// <param name="c0">The matrix column c0 will be set to this value.</param>
        /// <param name="c1">The matrix column c1 will be set to this value.</param>
        /// <returns>bool3x2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 bool3x2(bool3 c0, bool3 c1) { return new bool3x2(c0, c1); }

        /// <summary>Returns a bool3x2 matrix constructed from from 6 bool values given in row-major order.</summary>
        /// <param name="m00">The matrix at row 0, column 0 will be set to this value.</param>
        /// <param name="m01">The matrix at row 0, column 1 will be set to this value.</param>
        /// <param name="m10">The matrix at row 1, column 0 will be set to this value.</param>
        /// <param name="m11">The matrix at row 1, column 1 will be set to this value.</param>
        /// <param name="m20">The matrix at row 2, column 0 will be set to this value.</param>
        /// <param name="m21">The matrix at row 2, column 1 will be set to this value.</param>
        /// <returns>bool3x2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 bool3x2(bool m00, bool m01,
                                      bool m10, bool m11,
                                      bool m20, bool m21)
        {
            return new bool3x2(m00, m01,
                               m10, m11,
                               m20, m21);
        }

        /// <summary>Returns a bool3x2 matrix constructed from a single bool value by assigning it to every component.</summary>
        /// <param name="v">bool to convert to bool3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 bool3x2(bool v) { return new bool3x2(v); }

        /// <summary>Return the bool2x3 transpose of a bool3x2 matrix.</summary>
        /// <param name="v">Value to transpose.</param>
        /// <returns>Transposed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2x3 transpose(bool3x2 v)
        {
            return bool2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        /// <summary>Returns a uint hash code of a bool3x2 matrix.</summary>
        /// <param name="v">Matrix value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(bool3x2 v)
        {
            return csum(select(uint3(0x9C9F0823u, 0x5A9CA13Bu, 0xAFCDD5EFu), uint3(0xA88D187Du, 0xCF6EBA1Du, 0x9D88E5A1u), v.c0) +
                        select(uint3(0xEADF0775u, 0x747A9D7Bu, 0x4111F799u), uint3(0xB5F05AF1u, 0xFD80290Bu, 0x8B65ADB7u), v.c1));
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a bool3x2 matrix.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Matrix value to hash.</param>
        /// <returns>uint3 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(bool3x2 v)
        {
            return (select(uint3(0xDFF4F563u, 0x7069770Du, 0xD1224537u), uint3(0xE99ED6F3u, 0x48125549u, 0xEEE2123Bu), v.c0) +
                    select(uint3(0xE3AD9FE5u, 0xCE1CF8BFu, 0x7BE39F3Bu), uint3(0xFAB9913Fu, 0xB4501269u, 0xE04B89FDu), v.c1));
        }

    }
}
