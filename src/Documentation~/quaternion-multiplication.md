# Quaternion multiplication

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
