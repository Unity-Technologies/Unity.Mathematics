# Intrinsic functions

The following table shows the list of intrinsic functions exposed by the static class `math`:


|Unity           | HLSL | Comment
|--------------- | ---- | ---------------------------------------
|abs             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-abs) | Returns the componentwise absolute value of a specified value.
|acos            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-acos) | Returns the componentwise arccosine of a scalar or vector value.
|all             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-all) | Returns true if all component in the input vector or scalar is non-zero.
|any             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-any) | Returns true if any component in the input vector or scalar is non-zero.
|asdouble        |   | Returns the bit pattern of a long/ulong as a double.
|asfloat         | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-asfloat) | Returns the bit pattern of a int/uint vector (or scalar) as a float vector (or scalar) of the same length.
|asin            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-asin) | Returns the componentwise arcsine of a scalar or vector value.
|asint           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-asint) | Returns the bit pattern of a float vector (or scalar) as an int vector (or scalar) of the same length.
|aslong          |   | Returns the bit pattern of a double as a long.
|asuint          | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-asuint) | Returns the bit pattern of a float vector (or scalar) as an int vector (or scalar) of the same length.
|asulong         |   | Returns the bit pattern of a double as an ulong.
|atan            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-atan) | Returns the componentwise arctangent of a scalar or vector value.
|atan2           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-atan2) | Returns the componentwise 2-argument arctangent of a pair of scalar or vector values.
|ceil            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-ceil) | Returns the result of rounding each component of a vector or scalar to the nearest integral value greater or equal to the original value.
|ceilpow2        |   | Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input vector or scalar.
|clamp           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-clamp) | Returns the result of a componentwise clamping of the input value x into the interval [a, b], where x, a and b are all of the same scalar or vector type.
|cmax            |   | Returns the maximum component of a vector.
|cmin            |   | Returns the minimum component of a vector.
|compress        |   |
|conjugate       |   | Returns the conjugate (-x,-y,-z,w) of a quaternion value.
|cos             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-cos) | Returns the componentwise cosine of a scalar or vector value.
|cosh            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-cosh) | Returns the componentwise hyperbolic cosine of a scalar or vector value.
|countbits       | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-countbits) | Returns the componentwise number of 1-bits in the binary representations of an integer scalar or vector value.
|cross           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-cross) | Returns the cross product of two 3 dimensional vectors.
|csum            |   | Returns the horizontal sum of components of a vector.
|degrees         | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-degrees) | Returns the result of a componentwise conversion of a vector or scalar value from radians to degrees.
|determinant     | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-determinant) | Returns the determinant of a square integer or floating point matrix.
|distance        | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-distance) | Returns the distance between two scalar or vector values.
|dot             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-dot) | Returns the dot product of two quaternion or two vectors of the same type.
|exp             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-exp) | Returns the componentwise base-e exponential of a vector or scalar value.
|exp2            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-exp2) | Returns the componentwise base-2 exponential of a vector or scalar value.
|exp10           |   | Returns the componentwise base-10 exponential of a vector or scalar value.
|faceforward     | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-faceforward) | Conditionally flips a vector n to face in the direction of i. Returns n if dot(i, ng) < 0, -n otherwise.
|fastinverse     |   | Returns the inverse of a square matrix that is assumed to represent a rigid transformation (only rotation, reflection and translation). A faster alternative to inverse when applicable.
|floor           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-floor) | Returns the result of rounding each component of a vector or scalar to the nearest integral value less or equal to the original value.
|frac            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-frac) | Returns the componentwise fractional parts of a floating point vector or scalar.
|hash            |   | Returns a uint hash code of a matrix, vector, quaternion or scalar type.
|hashwide        |   | Returns a uint vector hash code of a matrix, vector, quaternion or scalar type. The number of components of the result corresponds to the number of rows in the input. When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hashes that are only reduced to a narrow uint hash at the very end.
|inverse         |   | Returns the full inverse of a square matrix or quaternion.
|isfinite        | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-isfinite) | Returns a bool vector of equal length to the input indicating for each component whether the value is a finite floating point number.
|isinf           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-isinf) | Returns a bool vector of equal length to the input indicating for each component whether the value is an infinite floating point number.
|isnan           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-isnan) | Returns a bool vector of equal length to the input indicating for each component whether the value is NaN (not a number) floating point number.
|length          | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-length) | Returns the length of a vector, quaternion or scalar value.
|lengthsq        |   | Returns the squared length of a vector, quaternion or scalar value.
|lerp            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-lerp) | Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.
|log             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-log) | Returns the componentwise natural logarithm of a scalar or vector value.
|log2            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-log2) | Returns the componentwise base-2 logarithm of a scalar or vector value.
|log10           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-log10) | Returns the componentwise base-10 logarithm of a scalar or vector value.
|lzcnt           |   | Returns the componentwise number of leading zeros in the binary representations of an integer scalar or vector value.
|mad             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-mad) | Returns the result of a componentwise multiply-add operation (a * b + c) on 3 scalar or vector values.
|max             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-max) | Returns the componentwise maximum of two scalar or vector values.
|min             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-min) | Returns the componentwise minimum of two scalar or vector values.
|fmod            |   | Returns the componentwise floating point remainder of a division between two floating point vectors or scalars.
|modf            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-modf) | Performs a componentwise split of a vector or scalar into an integral part i and a fractional part that gets returned. Both parts take the sign of the corresponding input component.
|mul             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-mul) |
|nfence          |   |
|nlerp           |   | Returns the result of a normalized linear interpolation between two quaternions using an interpolation parameter.
|normalize       | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-normalize) | Returns a normalized version of a vector or quaternion x by scaling it by 1 / length(x).
|orthogonalize   |   | Returns the result of orthogonalizing a matrix.
|pow             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-pow) | Returns the componentwise result of raising x to the power y.
|powr            |   | Returns the componentwise result of raising x to the power y. Assumes the components of x are non-negative.
|radians         | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-radians) | Returns the result of a componentwise conversion of a vector or scalar value from degrees to radians.
|rcp             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-rcp) | Returns the componentwise reciprocal of a scalar or vector value.
|reflect         | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-reflect) | Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2 * dot(i, n) * n.
|refract         | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-refract) | Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.
|remap           |   | Returns the componentwise result of a non-clamping linear remapping of a value x from [a, b] to [c, d].
|reversebits     | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-reversebits) | Returns the result of performing a componentwise reversal of the bit pattern of an integer vector or scalar.
|rol             |   | Returns the result of a componentwise left rotation by n bits of the bit pattern of an integer vector or scalar.
|ror             |   | Returns the result of a componentwise right rotation by n bits of the bit pattern of an integer vector or scalar.

|rotate          |   |
|round           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-round) | Returns the result of rounding each component of a vector or scalar to the nearest integral value.
|rsqrt           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-rsqrt) | Returns the componentwise reciprocal square root of a scalar or vector value.
|saturate        | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-saturate) |  Returns the result of a componentwise clamping of the input scalar or vector value x into the interval [0, 1].
|select          |   | Returns a componentwise selection between two vectors and b based on a boolean mask c. Per component b is selected when the corresponding component in c is true, a otherwise.
|shuffle         |   | Returns the result of a specified static shuffling of the components of two vectors of the same type.
|sign            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-sign) | Returns the componentwise sign of a vector or scalar value. 1.0 for positive components, 0.0 for zero components and -1.0 for negative components.
|sin             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-sin) | Returns the componentwise sine of a scalar or vector value.
|sincos          | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-sincos) | Returns the componentwise sine and cosine of a vector or scalar value.
|sinh            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-sinh) | Returns the componentwise hyperbolic sine of a scalar or vector value.
|slerp           |   | Returns the result of a spherical interpolation between two quaternions using an interpolation parameter.
|smoothstep      | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-smoothstep) | Returns a componenwise smooth Hermite interpolation between 0.0 and 1.0 when x is in [a, b].
|sqrt            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-sqrt) | Returns the componentwise square root of a scalar or vector value.
|step            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-step) | Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.
|tan             | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-tan) | Returns the componentwise tangent of a scalar or vector value.
|tanh            | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-tanh) | Returns the componentwise hyperbolic tangent of a scalar or vector value.
|transform       |   |
|transpose       | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-transpose) | Returns the transpose of a matrix.
|trunc           | [x](https://docs.microsoft.com/en-us/windows/desktop/direct3dhlsl/dx-graphics-hlsl-trunc) | Returns the result of a componentwise truncation of a floating point vector or scalar value to an integral value of the same type.
|tzcnt           |   | Returns the componentwise number of trailing zeros in the binary representations of an integer scalar or vector value.
|unitexp         |   | Returns the natural exponent of a quaternion. Assumes w is zero.
|unitlog         |   | Returns the natural logarithm of a unit length quaternion.
|unlerp          |   | Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).