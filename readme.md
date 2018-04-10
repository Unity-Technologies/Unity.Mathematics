# Unity.Mathematics

A prototype of a C# math library providing vector types and math functions with a shader like syntax.  Used by the `burst` compiler to compile C#/IL to highly efficient native code.

The main goal of this library is to provide a friendly Math API familiar to SIMD and graphic/shaders developers, using the well known `float4`, `float3` types...etc. with all intrinsics functions provided by a static class `math` that can be imported easily into your C# program with `using static Unity.Mathematics.math`.

In addition to this, the `burst` compiler is able to recognize these types and provide the optimized SIMD type for the running CPU on all supported platforms (x64, ARMv7a...etc.)

> NOTICE: The API is a work in progress and we may introduce breaking changes (API and underlying behavior)

## Usage

You can use this library in your Unity game by using the Package Manager and referencing the package `com.unity.mathematics`. See the forum [Welcome](https://forum.unity.com/threads/welcome.522627) page for more details.

```C#
using Unity.Mathematics;
using static Unity.Mathematics.math;

var v1 = new float3(1,2,3);
var v2 = new float3(4,5,6);
v1 = normalize(v1);
v2 = normalize(v2);
var v3 = dot(v1, v2);
```

## Building

Open the `src\Unity.Mathematics.sln` under Visual Studio 2015 or MonoDevelop and compile in Debug\Release.

## Known issues

- [ ] Remove `bool1` to `bool` (temporarily required by burst at some point, but this should no longer be required)
- [ ] Lots of tests are missing. So far it was mainly a playground for prototyping the API
- [ ] Complete the library (quaternions, matrices...etc.)
- [ ] Provide double precision types
- [ ] Provide static readonly values once the support for static is done in burst
- [ ] Add the documentation on how to use this API

## Contributing

We don't yet accept PR on this repository. See the FAQ below.

The project is using [editorconfig](http://editorconfig.org/) to keep files correctly formatted for EOL and spaces.

We assume that your IDE has support for `editorconfig`, you can download the following extensions if your IDE is listed:

- [VS2015/VS2017 EditorConfig extension](https://marketplace.visualstudio.com/items?itemName=EditorConfigTeam.EditorConfig)
- [Visual Studio Code EditorConfig extension](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig)
- [SublimeText EditorConfig extension](https://github.com/sindresorhus/editorconfig-sublime)

## Frequently Asked Question

### Why developing another Math library instead of using existing Unity Vector3...etc.?

After years of feedback and experience with the previous API, we believe that providing an API that is closer to the way graphics developers have been using math libraries should better help its adoption and the ease of its usage. Unity developers might at some point be able to write shaders in C# directly, and having a math library that matches the behavior of GLSL/HLSL should simplify its integration.

### Why not using `System.Numerics.Vectors`?

Mainly for the reason mentioned above, `System.Numerics.Vectors` is in many ways similar to our previous Vector library (more object oriented than graphics programming oriented).
Also the fact that our `burst` compiler is able to recognize a lot more patterns for SIMD types and math intrinsics makes it easier to work with a dedicated API that reflects this ability.

### Why can't we send a PR yet?

We are working on providing a Contributor License Agreement (CLA) with a sign-over functionality and our UCL License doesn't cover this yet.

## Licensing

Unity Companion License (“License”)
Software Copyright © 2017 Unity Technologies ApS 

Licensed under the Unity Companion License for Unity-dependent projects--see [Unity Companion License](https://unity3d.com/legal/licenses/Unity_Companion_License).
