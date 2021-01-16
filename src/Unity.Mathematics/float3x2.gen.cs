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
    public partial struct float3x2 : System.IEquatable<float3x2>, IFormattable
    {
        public float3 c0;
        public float3 c1;

        /// <summary>float3x2 zero value.</summary>
        public static readonly float3x2 zero;

        /// <summary>Constructs a float3x2 matrix from two float3 vectors.</summary>
        /// <param name="c0">The matrix column c0 will be set to this value.</param>
        /// <param name="c1">The matrix column c1 will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(float3 c0, float3 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a float3x2 matrix from 6 float values given in row-major order.</summary>
        /// <param name="m00">The matrix at row 0, column 0 will be set to this value.</param>
        /// <param name="m01">The matrix at row 0, column 1 will be set to this value.</param>
        /// <param name="m10">The matrix at row 1, column 0 will be set to this value.</param>
        /// <param name="m11">The matrix at row 1, column 1 will be set to this value.</param>
        /// <param name="m20">The matrix at row 2, column 0 will be set to this value.</param>
        /// <param name="m21">The matrix at row 2, column 1 will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(float m00, float m01,
                        float m10, float m11,
                        float m20, float m21)
        {
            this.c0 = new float3(m00, m10, m20);
            this.c1 = new float3(m01, m11, m21);
        }

        /// <summary>Constructs a float3x2 matrix from a single float value by assigning it to every component.</summary>
        /// <param name="v">float to convert to float3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(float v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a float3x2 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        /// <param name="v">bool to convert to float3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(bool v)
        {
            this.c0 = math.select(new float3(0.0f), new float3(1.0f), v);
            this.c1 = math.select(new float3(0.0f), new float3(1.0f), v);
        }

        /// <summary>Constructs a float3x2 matrix from a bool3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">bool3x2 to convert to float3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(bool3x2 v)
        {
            this.c0 = math.select(new float3(0.0f), new float3(1.0f), v.c0);
            this.c1 = math.select(new float3(0.0f), new float3(1.0f), v.c1);
        }

        /// <summary>Constructs a float3x2 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        /// <param name="v">int to convert to float3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(int v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a float3x2 matrix from a int3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">int3x2 to convert to float3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(int3x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        /// <summary>Constructs a float3x2 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        /// <param name="v">uint to convert to float3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a float3x2 matrix from a uint3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">uint3x2 to convert to float3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(uint3x2 v)
        {
            this.c0 = v.c0;
            this.c1 = v.c1;
        }

        /// <summary>Constructs a float3x2 matrix from a single double value by converting it to float and assigning it to every component.</summary>
        /// <param name="v">double to convert to float3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(double v)
        {
            this.c0 = (float3)v;
            this.c1 = (float3)v;
        }

        /// <summary>Constructs a float3x2 matrix from a double3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">double3x2 to convert to float3x2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3x2(double3x2 v)
        {
            this.c0 = (float3)v.c0;
            this.c1 = (float3)v.c1;
        }


        /// <summary>Implicitly converts a single float value to a float3x2 matrix by assigning it to every component.</summary>
        /// <param name="v">float to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(float v) { return new float3x2(v); }

        /// <summary>Explicitly converts a single bool value to a float3x2 matrix by converting it to float and assigning it to every component.</summary>
        /// <param name="v">bool to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x2(bool v) { return new float3x2(v); }

        /// <summary>Explicitly converts a bool3x2 matrix to a float3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">bool3x2 to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x2(bool3x2 v) { return new float3x2(v); }

        /// <summary>Implicitly converts a single int value to a float3x2 matrix by converting it to float and assigning it to every component.</summary>
        /// <param name="v">int to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(int v) { return new float3x2(v); }

        /// <summary>Implicitly converts a int3x2 matrix to a float3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">int3x2 to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(int3x2 v) { return new float3x2(v); }

        /// <summary>Implicitly converts a single uint value to a float3x2 matrix by converting it to float and assigning it to every component.</summary>
        /// <param name="v">uint to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(uint v) { return new float3x2(v); }

        /// <summary>Implicitly converts a uint3x2 matrix to a float3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">uint3x2 to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x2(uint3x2 v) { return new float3x2(v); }

        /// <summary>Explicitly converts a single double value to a float3x2 matrix by converting it to float and assigning it to every component.</summary>
        /// <param name="v">double to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x2(double v) { return new float3x2(v); }

        /// <summary>Explicitly converts a double3x2 matrix to a float3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">double3x2 to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator float3x2(double3x2 v) { return new float3x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise multiplication.</param>
        /// <returns>float3x2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator * (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise multiplication.</param>
        /// <returns>float3x2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator * (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise multiplication.</param>
        /// <returns>float3x2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator * (float lhs, float3x2 rhs) { return new float3x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise addition.</param>
        /// <returns>float3x2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator + (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise addition.</param>
        /// <returns>float3x2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator + (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise addition.</param>
        /// <returns>float3x2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator + (float lhs, float3x2 rhs) { return new float3x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise subtraction.</param>
        /// <returns>float3x2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator - (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise subtraction.</param>
        /// <returns>float3x2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator - (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise subtraction.</param>
        /// <returns>float3x2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator - (float lhs, float3x2 rhs) { return new float3x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise division.</param>
        /// <returns>float3x2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator / (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise division.</param>
        /// <returns>float3x2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator / (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise division.</param>
        /// <returns>float3x2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator / (float lhs, float3x2 rhs) { return new float3x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise modulus.</param>
        /// <returns>float3x2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator % (float3x2 lhs, float3x2 rhs) { return new float3x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise modulus.</param>
        /// <returns>float3x2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator % (float3x2 lhs, float rhs) { return new float3x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise modulus.</param>
        /// <returns>float3x2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator % (float lhs, float3x2 rhs) { return new float3x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on a float3x2 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>float3x2 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator ++ (float3x2 val) { return new float3x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on a float3x2 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>float3x2 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator -- (float3x2 val) { return new float3x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise less than.</param>
        /// <returns>bool3x2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise less than.</param>
        /// <returns>bool3x2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise less than.</param>
        /// <returns>bool3x2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator < (float lhs, float3x2 rhs) { return new bool3x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise less or equal.</param>
        /// <returns>bool3x2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise less or equal.</param>
        /// <returns>bool3x2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise less or equal.</param>
        /// <returns>bool3x2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator <= (float lhs, float3x2 rhs) { return new bool3x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise greater than.</param>
        /// <returns>bool3x2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise greater than.</param>
        /// <returns>bool3x2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise greater than.</param>
        /// <returns>bool3x2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator > (float lhs, float3x2 rhs) { return new bool3x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3x2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise greater or equal.</param>
        /// <returns>bool3x2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3x2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator >= (float lhs, float3x2 rhs) { return new bool3x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on a float3x2 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>float3x2 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator - (float3x2 val) { return new float3x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on a float3x2 matrix.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>float3x2 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 operator + (float3x2 val) { return new float3x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise equality operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise equality.</param>
        /// <returns>bool3x2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise equality.</param>
        /// <returns>bool3x2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise equality.</param>
        /// <returns>bool3x2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator == (float lhs, float3x2 rhs) { return new bool3x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two float3x2 matrices.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise not equal.</param>
        /// <returns>bool3x2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (float3x2 lhs, float3x2 rhs) { return new bool3x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a float3x2 matrix and a float value.</summary>
        /// <param name="lhs">Left hand side float3x2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side float to use to compute componentwise not equal.</param>
        /// <returns>bool3x2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (float3x2 lhs, float rhs) { return new bool3x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a float3x2 matrix.</summary>
        /// <param name="lhs">Left hand side float to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side float3x2 to use to compute componentwise not equal.</param>
        /// <returns>bool3x2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3x2 operator != (float lhs, float3x2 rhs) { return new bool3x2 (lhs != rhs.c0, lhs != rhs.c1); }



        /// <summary>Returns the float3 element at a specified index.</summary>
        unsafe public ref float3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (float3x2* array = &this) { return ref ((float3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the float3x2 is equal to a given float3x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(float3x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the float3x2 is equal to a given float3x2, false otherwise.</summary>
        public override bool Equals(object o) { return o is float3x2 converted && Equals(converted); }


        /// <summary>Returns a hash code for the float3x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the float3x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("float3x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f)", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z);
        }

        /// <summary>Returns a string representation of the float3x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float3x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a float3x2 matrix constructed from two float3 vectors.</summary>
        /// <param name="c0">The matrix column c0 will be set to this value.</param>
        /// <param name="c1">The matrix column c1 will be set to this value.</param>
        /// <returns>float3x2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(float3 c0, float3 c1) { return new float3x2(c0, c1); }

        /// <summary>Returns a float3x2 matrix constructed from from 6 float values given in row-major order.</summary>
        /// <param name="m00">The matrix at row 0, column 0 will be set to this value.</param>
        /// <param name="m01">The matrix at row 0, column 1 will be set to this value.</param>
        /// <param name="m10">The matrix at row 1, column 0 will be set to this value.</param>
        /// <param name="m11">The matrix at row 1, column 1 will be set to this value.</param>
        /// <param name="m20">The matrix at row 2, column 0 will be set to this value.</param>
        /// <param name="m21">The matrix at row 2, column 1 will be set to this value.</param>
        /// <returns>float3x2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(float m00, float m01,
                                        float m10, float m11,
                                        float m20, float m21)
        {
            return new float3x2(m00, m01,
                                m10, m11,
                                m20, m21);
        }

        /// <summary>Returns a float3x2 matrix constructed from a single float value by assigning it to every component.</summary>
        /// <param name="v">float to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(float v) { return new float3x2(v); }

        /// <summary>Returns a float3x2 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        /// <param name="v">bool to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(bool v) { return new float3x2(v); }

        /// <summary>Return a float3x2 matrix constructed from a bool3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">bool3x2 to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(bool3x2 v) { return new float3x2(v); }

        /// <summary>Returns a float3x2 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        /// <param name="v">int to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(int v) { return new float3x2(v); }

        /// <summary>Return a float3x2 matrix constructed from a int3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">int3x2 to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(int3x2 v) { return new float3x2(v); }

        /// <summary>Returns a float3x2 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        /// <param name="v">uint to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(uint v) { return new float3x2(v); }

        /// <summary>Return a float3x2 matrix constructed from a uint3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">uint3x2 to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(uint3x2 v) { return new float3x2(v); }

        /// <summary>Returns a float3x2 matrix constructed from a single double value by converting it to float and assigning it to every component.</summary>
        /// <param name="v">double to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(double v) { return new float3x2(v); }

        /// <summary>Return a float3x2 matrix constructed from a double3x2 matrix by componentwise conversion.</summary>
        /// <param name="v">double3x2 to convert to float3x2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x2 float3x2(double3x2 v) { return new float3x2(v); }

        /// <summary>Return the float2x3 transpose of a float3x2 matrix.</summary>
        /// <param name="v">Value to transpose.</param>
        /// <returns>Transposed value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2x3 transpose(float3x2 v)
        {
            return float2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        /// <summary>Returns a uint hash code of a float3x2 matrix.</summary>
        /// <param name="v">Matrix value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(float3x2 v)
        {
            return csum(asuint(v.c0) * uint3(0xE121E6ADu, 0xC9CA1249u, 0x69B60C81u) +
                        asuint(v.c1) * uint3(0xE0EB6C25u, 0xF648BEABu, 0x6BDB2B07u)) + 0xEF63C699u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a float3x2 matrix.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Matrix value to hash.</param>
        /// <returns>uint3 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(float3x2 v)
        {
            return (asuint(v.c0) * uint3(0x9001903Fu, 0xA895B9CDu, 0x9D23B201u) +
                    asuint(v.c1) * uint3(0x4B01D3E1u, 0x7461CA0Du, 0x79725379u)) + 0xD6258E5Bu;
        }

    }
}
