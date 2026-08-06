# Unity Mathematics

Unity Mathematics is a C# math library that provides vector types and math functions that have a shader-like
syntax, similar to [SIMD](https://en.wikipedia.org/wiki/Single_instruction,_multiple_data) or [HLSL](https://docs.microsoft.com/en-us/windows/win32/direct3dhlsl/dx-graphics-hlsl). The [Burst compiler](https://docs.unity3d.com/Packages/com.unity.burst@latest) uses Unity Mathematics to compile C#/IL code into highly efficient native code.

It implements the following vector and matrix types:

* floatN, quaternion
* float3×3, float4×4

Plus elementary functions:
* min, max, fabs, etc.
* sin, cos, sqrt, normalize, dot, cross, etc.

## Installation

You can install the Mathematics package through Unity's Package Manager. For more information, see the Unity User Manual documentation on [Adding and removing packages](https://docs.unity3d.com/Manual/upm-ui-actions.html).

>[!IMPORTANT]
>From Unity 6.5, Unity Mathematics is a built-in module of the core Editor and Engine and its APIs are available to user code by default in the `Unity.Mathematics` namespace, with no package installation required. Accordingly, from Unity 6.5 the Unity Mathematics API documentation is part of the [core Scripting API reference](https://docs.unity3d.com/ScriptReference/Unity.Mathematics.math.html), and the user manual is integrated with [the core Unity user manual](https://docs.unity3d.com/Manual/unity-mathematics.html).

### Editor config

Unity Mathematics uses [editorconfig](http://editorconfig.org/) to keep files formatted for EOL and spaces.

Your IDE should have support for `editorconfig`. If it doesn't, you can get the extension for it here: 

* [VS2015/VS2017 EditorConfig extension](https://marketplace.visualstudio.com/items?itemName=EditorConfigTeam.EditorConfig)
* [Visual Studio Code EditorConfig extension](https://marketplace.visualstudio.com/items?itemName=EditorConfig.EditorConfig)
* [SublimeText EditorConfig extension](https://github.com/sindresorhus/editorconfig-sublime)
