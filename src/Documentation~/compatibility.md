# Compatibility with `Mathf`

Unity Mathematics isn't implemented in the same way as the [`UnityEngine.Mathf`](https://docs.unity3d.com/ScriptReference/Mathf.html) struct in the core Unity engine. Because of this, if your application relies on the specific behaviors of `Mathf`, it might not be possible to use Unity Mathematics in your project. Also, if your project uses `Mathf` functions that have no corresponding Unity Mathematics function, or your code uses external plug-ins that depend on Unity types such as `Vector3`, or `Matrix4x4`, then you shouldn't use Unity Mathematics.

>[!IMPORTANT]
>For performance reasons, if your project uses the Mono compiler, you should continue to use the mathematical operations in `Mathf`, rather than Unity Mathematics.

## Porting `Mathf` code to Unity Mathematics

If you want to migrate code from `UnityEngine` to `Unity.Mathematics`, you need to make the following changes first:

* `Vector4` to `float4`
* Multiplications on vector or matrix objects to component multiplication with the `*` operator.
* Degrees to radians
* How your code generates random numbers