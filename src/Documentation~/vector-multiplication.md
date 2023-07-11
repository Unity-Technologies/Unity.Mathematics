# Vector multiplication

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