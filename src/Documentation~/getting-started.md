# Getting started

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
