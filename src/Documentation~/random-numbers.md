## Random numbers

To generate random numbers, you must create and manage the random number generator state yourself with the [`Random`](xref:Unity.Mathematics.Random) struct. You can control the random number generator state explicitly, which is useful if you're using parallel code, or if you want to make sure that one source of random numbers is seeded differently than another source. You can also have as many `Random` instances as you like.

Once you set up the state, use [`NextFloat`](xref:Unity.Mathematics.Random.NextFloat) to get random floats. By default it returns random numbers between `[0, 1)`, exclusive:

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
