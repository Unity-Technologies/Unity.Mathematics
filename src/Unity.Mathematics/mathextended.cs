using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class math
    {
        public const float epsilon_normal = 1e-30f;
        
        public static int ceilpow2(int i)
        {
            i -= 1;
            i |= i >> 1;
            i |= i >> 2;
            i |= i >> 4;
            i |= i >> 8;
            i |= i >> 16;
            return i + 1;
        }

        // Packs components with an enabled mask (LSB) to the left
        // The value of components after the last packed component are undefined.
        // Returns the number of enabled mask bits. (0 ... 4)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe int compress(int* output, int index, int4 val, bool4 mask)
        {
            if (mask.x)
                output[index++] = val.x;
            if (mask.y)
                output[index++] = val.y;
            if (mask.z)
                output[index++] = val.z;
            if (mask.w)
                output[index++] = val.w;

            return index;
        }

        // radians (convert from degrees to radians)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float radians(float degrees) { return degrees * 0.0174532925f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 radians(float2 degrees) { return degrees * 0.0174532925f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 radians(float3 degrees) { return degrees * 0.0174532925f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 radians(float4 degrees) { return degrees * 0.0174532925f; }

        // radians (convert from radians to degrees)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float degrees(float radians) { return radians * 57.295779513f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 degrees(float2 radians) { return radians * 57.295779513f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 degrees(float3 radians) { return radians * 57.295779513f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 degrees(float4 radians) { return radians * 57.295779513f; }


        // cmin - returns the smallest component of the vector
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmin(float a) { return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmin(float2 a) { return min(a.x, a.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmin(float3 a) { return min(min(a.x, a.y), a.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmin(float4 a) { return min(min(min(a.x, a.y), a.z), a.w); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmin(int a) { return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmin(int2 a) { return min(a.x, a.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmin(int3 a) { return min(min(a.x, a.y), a.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmin(int4 a) { return min(min(min(a.x, a.y), a.z), a.w); }

        // cmax - returns the largest component of the vector
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmax(float a) { return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmax(float2 a) { return max(a.x, a.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmax(float3 a) { return max(max(a.x, a.y), a.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmax(float4 a) { return max(max(max(a.x, a.y), a.z), a.w); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmax(int a) { return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmax(int2 a) { return max(a.x, a.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmax(int3 a) { return max(max(a.x, a.y), a.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmax(int4 a) { return max(max(max(a.x, a.y), a.z), a.w); }

        // csum - sums all components of the vector
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float csum(float a) { return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float csum(float2 a) { return a.x + a.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float csum(float3 a) { return a.x + a.y + a.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float csum(float4 a) { return a.x + a.y + a.z + a.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int csum(int a) { return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int csum(int2 a) { return a.x + a.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int csum(int3 a) { return a.x + a.y + a.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int csum(int4 a) { return a.x + a.y + a.z + a.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint csum(uint a) { return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint csum(uint2 a) { return a.x + a.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint csum(uint3 a) { return a.x + a.y + a.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint csum(uint4 a) { return a.x + a.y + a.z + a.w; }

        // A numeric optimization fence.
        // prevents the compiler from optimizing operators.
        // Some algorithms are written in specific ways to get more precision.
        // For example: https://en.wikipedia.org/wiki/Kahan_summation_algorithm
        // this gives the programmer a tool to prevent specific optimization.
        // example:
        // var c = math.nfence(a + b) * c;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float nfence(float value) { return value; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 nfence(float2 value) { return value; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 nfence(float3 value) { return value; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 nfence(float4 value) { return value; }
    }
}
