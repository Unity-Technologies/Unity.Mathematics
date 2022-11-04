# Compatibility with `UnityEngine` mathematics

If you want to Burst-compile your project, it's best practice to use the Unity Mathematics package by default and only use `Mathf` when necessary. Unity Mathematics isn't implemented in the same way as the [`UnityEngine.Mathf`](https://docs.unity3d.com/ScriptReference/Mathf.html) struct in the core Unity engine. Because of this, if your application relies on the specific behaviors of `Mathf`, you'll have to reimplement them to get similar behavior in Unity Mathematics. 

>[!IMPORTANT]
>For performance reasons, if your project uses the Mono compiler, you should continue to use the mathematical operations in `Mathf`, rather than Unity Mathematics.

You can use both `Mathf` and Unity Mathematics methods in your project, but it might impact on the performance of your application because the conversions between the `UnityEngine` and `Unity.Mathematics` types such as `Vector3` to `float3` and vice-versa are performance-intensive. 

## Porting `UnityEngine` code to `Unity.Mathematics`

If you want to migrate code from `UnityEngine` to `Unity.Mathematics`, you need to make the following changes first:

* Update `UnityEngine` types to `Unity.Mathematics` types. For example, [`Vector4`](https://docs.unity3d.com/ScriptReference/Vector4.html) to [`float4`](xref:Unity.Mathematics.float4), and [`Quaternion`](https://docs.unity3d.com/ScriptReference/Quaternion.html) to [`quaternion`](xref:Unity.Mathematics.quaternion). These examples aren't exhaustive: see the [Scripting API reference](https://docs.unity3d.com/Packages/com.unity.mathematics@latest/index.html?subfolder=/api/index.html) for the full list of Unity Mathematics types available.
* Update any operators involved in matrices or vectors. For example, the `Matrix4x4` multiplication operator implements matrix multiplication, but the `float4x4` multiplication operator implements componentwise multiplication.
* Degrees to radians
* How your code generates random numbers. `Random` in `Unity.Mathematics` works differently to [`Random`](https://docs.unity3d.com/ScriptReference/Random.html) in `UnityEngine`. You can completely control random number generation with `Random` in `Unity.Mathematics`, and it's instanced, rather than static. It's also exclusive with its upper bound, which is important to bear in mind if you want to convert `UnityEngine` code which is sensitive to the bounds. For more information, see the documentation on [Random numbers](random-numbers.md).
