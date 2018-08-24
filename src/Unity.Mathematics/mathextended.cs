using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class math
    {
        public const float epsilon_normal = 1e-30f;
        
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

       /// <summary>Returns the result of converting a float value from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float radians(float x) { return x * 0.0174532925f; }

       /// <summary>Returns the result of a componentwise conversion of a float2 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 radians(float2 x) { return x * 0.0174532925f; }

       /// <summary>Returns the result of a componentwise conversion of a float3 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 radians(float3 x) { return x * 0.0174532925f; }

       /// <summary>Returns the result of a componentwise conversion of a float4 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 radians(float4 x) { return x * 0.0174532925f; }


        /// <summary>Returns the result of converting a float value from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double radians(double x) { return x * 0.017453292519943296; }

        /// <summary>Returns the result of a componentwise conversion of a float2 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 radians(double2 x) { return x * 0.017453292519943296; }

        /// <summary>Returns the result of a componentwise conversion of a float3 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 radians(double3 x) { return x * 0.017453292519943296; }

        /// <summary>Returns the result of a componentwise conversion of a float4 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 radians(double4 x) { return x * 0.017453292519943296; }


        /// <summary>Returns the result of converting a double value from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float degrees(float x) { return x * 57.295779513f; }

       /// <summary>Returns the result of a componentwise conversion of a double2 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 degrees(float2 x) { return x * 57.295779513f; }

       /// <summary>Returns the result of a componentwise conversion of a double3 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 degrees(float3 x) { return x * 57.295779513f; }

       /// <summary>Returns the result of a componentwise conversion of a double4 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 degrees(float4 x) { return x * 57.295779513f; }


        /// <summary>Returns the result of converting a double value from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double degrees(double x) { return x * 57.29577951308232; }

        /// <summary>Returns the result of a componentwise conversion of a double2 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 degrees(double2 x) { return x * 57.29577951308232; }

        /// <summary>Returns the result of a componentwise conversion of a double3 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 degrees(double3 x) { return x * 57.29577951308232; }

        /// <summary>Returns the result of a componentwise conversion of a double4 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 degrees(double4 x) { return x * 57.29577951308232; }


        /// <summary>Returns the input int value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmin(int x) { return x; }

       /// <summary>Returns the minimum component of an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmin(int2 x) { return min(x.x, x.y); }

       /// <summary>Returns the minimum component of an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmin(int3 x) { return min(min(x.x, x.y), x.z); }

       /// <summary>Returns the minimum component of an int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmin(int4 x) { return min(min(x.x, x.y), min(x.z, x.w)); }


       /// <summary>Returns the input uint value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint cmin(uint x) { return x; }

       /// <summary>Returns the minimum component of a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint cmin(uint2 x) { return min(x.x, x.y); }

       /// <summary>Returns the minimum component of a uint3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint cmin(uint3 x) { return min(min(x.x, x.y), x.z); }

       /// <summary>Returns the minimum component of a uint4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint cmin(uint4 x) { return min(min(x.x, x.y), min(x.z, x.w)); }


       /// <summary>Returns the input float value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmin(float x) { return x; }

       /// <summary>Returns the minimum component of a float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmin(float2 x) { return min(x.x, x.y); }

       /// <summary>Returns the minimum component of a float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmin(float3 x) { return min(min(x.x, x.y), x.z); }

       /// <summary>Returns the maximum component of a float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmin(float4 x) { return min(min(x.x, x.y), min(x.z, x.w)); }


       /// <summary>Returns the input float value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cmin(double x) { return x; }

       /// <summary>Returns the minimum component of a float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cmin(double2 x) { return min(x.x, x.y); }

       /// <summary>Returns the minimum component of a float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cmin(double3 x) { return min(min(x.x, x.y), x.z); }

       /// <summary>Returns the maximum component of a float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cmin(double4 x) { return min(min(x.x, x.y), min(x.z, x.w)); }


       /// <summary>Returns the input int value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmax(int x) { return x; }

       /// <summary>Returns the maximum component of an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmax(int2 x) { return max(x.x, x.y); }

       /// <summary>Returns the maximum component of an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmax(int3 x) { return max(max(x.x, x.y), x.z); }

       /// <summary>Returns the maximum component of an int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int cmax(int4 x) { return max(max(x.x, x.y), max(x.z, x.w)); }


       /// <summary>Returns the input uint value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint cmax(uint x) { return x; }

       /// <summary>Returns the maximum component of a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint cmax(uint2 x) { return max(x.x, x.y); }

       /// <summary>Returns the maximum component of a uint3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint cmax(uint3 x) { return max(max(x.x, x.y), x.z); }

       /// <summary>Returns the maximum component of a uint4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint cmax(uint4 x) { return max(max(x.x, x.y), max(x.z, x.w)); }


       /// <summary>Returns the input float value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmax(float x) { return x; }

       /// <summary>Returns the maximum component of a float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmax(float2 x) { return max(x.x, x.y); }

       /// <summary>Returns the maximum component of a float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmax(float3 x) { return max(max(x.x, x.y), x.z); }

       /// <summary>Returns the maximum component of a float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float cmax(float4 x) { return max(max(x.x, x.y), max(x.z, x.w)); }


       /// <summary>Returns the input double value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cmax(double x) { return x; }

       /// <summary>Returns the maximum component of a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cmax(double2 x) { return max(x.x, x.y); }

       /// <summary>Returns the maximum component of a double3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cmax(double3 x) { return max(max(x.x, x.y), x.z); }

       /// <summary>Returns the maximum component of a double4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double cmax(double4 x) { return max(max(x.x, x.y), max(x.z, x.w)); }


       /// <summary>Returns the input int value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int csum(int x) { return x; }

       /// <summary>Returns the horizontal sum of components of an int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int csum(int2 x) { return x.x + x.y; }

       /// <summary>Returns the horizontal sum of components of an int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int csum(int3 x) { return x.x + x.y + x.z; }

       /// <summary>Returns the horizontal sum of components of an int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int csum(int4 x) { return x.x + x.y + x.z + x.w; }


       /// <summary>Returns the input uint value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint csum(uint x) { return x; }

       /// <summary>Returns the horizontal sum of components of a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint csum(uint2 x) { return x.x + x.y; }

       /// <summary>Returns the horizontal sum of components of a uint3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint csum(uint3 x) { return x.x + x.y + x.z; }

       /// <summary>Returns the horizontal sum of components of a uint4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint csum(uint4 x) { return x.x + x.y + x.z + x.w; }


       /// <summary>Returns the input float value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float csum(float x) { return x; }

       /// <summary>Returns the horizontal sum of components of a float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float csum(float2 x) { return x.x + x.y; }

       /// <summary>Returns the horizontal sum of components of a float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float csum(float3 x) { return x.x + x.y + x.z; }

       /// <summary>Returns the horizontal sum of components of a float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float csum(float4 x) { return x.x + x.y + x.z + x.w; }


       /// <summary>Returns the input double value. Identity function.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double csum(double x) { return x; }

       /// <summary>Returns the horizontal sum of components of a double2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 csum(double2 x) { return x.x + x.y; }

       /// <summary>Returns the horizontal sum of components of a double3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 csum(double3 x) { return x.x + x.y + x.z; }

       /// <summary>Returns the horizontal sum of components of a double4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 csum(double4 x) { return x.x + x.y + x.z + x.w; }



        // A numeric optimization fence.
        // prevents the compiler from optimizing operators.
        // Some algorithms are written in specific ways to get more precision.
        // For example: https://en.wikipedia.org/wiki/Kahan_summation_algorithm
        // this gives the programmer a tool to prevent specific optimization.
        // example:
        // var c = math.nfence(a + b) * c;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float nfence(float x) { return x; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 nfence(float2 x) { return x; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 nfence(float3 x) { return x; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 nfence(float4 x) { return x; }
    }
}
