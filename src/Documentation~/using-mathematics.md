# Using Unity Mathematics

To use Unity Mathematics, add `using Unity.Mathematics` to your code:

```C#
using static Unity.Mathematics.math;
namespace MyNamespace
{
    using Unity.Mathematics;
    
    ...
    var v1 = float3(1,2,3);
    var v2 = float3(4,5,6);
    v1 = normalize(v1);
    v2 = normalize(v2);
    var v3 = dot(v1, v2);
    ...
}
```

## Naming convention

In C# `int` and `float` are built-in types. The Burst compiler extends this set of built-in types to also include vectors, matrices, and quaternions. These types are built-in because the Burst compiler already has implementations of these types, and so can use them to generate better code than for custom types.

To signify that these types are built-in their type names are in all lower case. The operators on these built-in types in [`Unity.Mathematics.math`](xref:Unity.Mathematics.math) are intrinsics and are always in lower case.

There are no plans to extend the set of intrinsic types beyond the current set of vectors (`typeN`), matrices (`typeNxN`) and quaternions (`quaternion`).

This convention has the added benefit of making the library highly compatible with shader code and makes porting or sharing code between the two almost frictionless.


## Vector multiplication

To multiply vectors, use the `*`:

```c#
// Unity Mathematics example
void ComponentwiseVectorMultiplyUnityMathematics()
{
   var v0 = new float4(2.0f, 4.0f, 6.0f, 8.0f);
   var v1 = new float4(1.0f, -1.0f, 1.0f, -1.0f);
   var result = v0 * v1;
   // result == new float4(2.0f, -4.0f, 6.0f, -8.0f).
}
```

This is a common way of writing [SIMD](https://en.wikipedia.org/wiki/Single_instruction,_multiple_data) code, which applies a single instruction to multiple data elements. Other operators such as addition, subtraction, and division work in the same way.

## Quaternion multiplication

To rotate a quaternion, use the [`AxisAngle`](xref:Unity.Mathematics.quaternion.AxisAngle*) method. You specify the axis of rotation and the rotation around that axis, but supply the axis first and the angle second. Also, all the angles are in radians rather than degrees. `math.mul` multiplies the quaternion, just as with [matrices](4x4-matrices.md) and vectors.

```c#
// Unity Mathematics example
void QuaternionMultiplicationUnityMathematics()
{
   var axis = new float3(0.0f, 1.0f, 0.0f);
   var q = quaternion.AxisAngle(axis,math.radians(45.0f));
   var orientation = quaternion.Euler(
       math.radians(45.0f),
       math.radians(90.0f),
       math.radians(180.0f));
   var result = math.mul(q, orientation);
}
```

## Random numbers

To generate random numbers, you must create and manage the random number generator state yourself. This means you can control the random number generator state explicitly, which is useful it you're using parallel code, or if you want to make sure that one source of random numbers is seeded differently than another source.

Once you set up the state, use [`NextFloat`](xref:Unity.Mathematics.Random.NextFloat) to get random floats. By default it returns random numbers between `[0, 1]`, exclusive:

```c#
// Unity Mathematics example
void RandomNumberUnityMathematics()
{
   // Choose some non-zero seed and set up the random number generator state.
   uint seed = 1;
   Unity.Mathematics.Random rng = new Unity.Mathematics.Random(seed);

   // [0, 1) exclusive
   float randomFloat1 = rng.NextFloat();

   // [-5, 5) exclusive
   float randomFloat2 = rng.NextFloat(-5.0f, 5.0f);
}
```