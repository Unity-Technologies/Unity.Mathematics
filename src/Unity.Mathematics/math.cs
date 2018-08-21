using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class math
    {
        public enum RotationOrder
        {
            XYZ,
            XZY,
            YXZ,
            YZX,
            ZXY,    // Unity Default
            ZYX,
        };

        public enum ShuffleComponent
        {
            LeftX,
            LeftY,
            LeftZ,
            LeftW,
            RightX,
            RightY,
            RightZ,
            RightW
        };

        // constants
        public static readonly double E = 2.71828182845904523536;
        public static readonly double LOG2E = 1.44269504088896340736;
        public static readonly double LOG10E = 0.434294481903251827651;
        public static readonly double LN2 = 0.693147180559945309417;
        public static readonly double LN10 = 2.30258509299404568402;
        public static readonly double PI = 3.14159265358979323846;
        public static readonly double SQRT2 = 1.41421356237309504880;

        // asint
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int asint(float v) {
            IntFloatUnion u;
            u.intValue = 0;
            u.floatValue = v;
            return u.intValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 asint(float2 v) { return int2(asint(v.x), asint(v.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 asint(float3 v) { return int3(asint(v.x), asint(v.y), asint(v.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 asint(float4 v) { return int4(asint(v.x), asint(v.y), asint(v.z), asint(v.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int  asint(uint v) { return (int)v; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 asint(uint2 v) { return int2((int)v.x, (int)v.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 asint(uint3 v) { return int3((int)v.x, (int)v.y, (int)v.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 asint(uint4 v) { return int4((int)v.x, (int)v.y, (int)v.z, (int)v.w); }

        // asuint
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint asuint(float v) { return (uint)asint(v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 asuint(float2 v) { return uint2(asuint(v.x), asuint(v.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 asuint(float3 v) { return uint3(asuint(v.x), asuint(v.y), asuint(v.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 asuint(float4 v) { return uint4(asuint(v.x), asuint(v.y), asuint(v.z), asuint(v.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint  asuint(int v) { return (uint)v; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 asuint(int2 v) { return uint2((uint)v.x, (uint)v.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 asuint(int3 v) { return uint3((uint)v.x, (uint)v.y, (uint)v.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 asuint(int4 v) { return uint4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long aslong(double v)
        {
            LongDoubleUnion u;
            u.longValue = 0;
            u.doubleValue = v;
            return u.longValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong asulong(double v) { return (ulong) aslong(v); }

        // asfloat
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float asfloat(int v)
        {
            IntFloatUnion u;
            u.floatValue = 0;
            u.intValue = v;

            return u.floatValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 asfloat(int2 v) { return float2(asfloat(v.x), asfloat(v.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 asfloat(int3 v) { return float3(asfloat(v.x), asfloat(v.y), asfloat(v.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 asfloat(int4 v) { return float4(asfloat(v.x), asfloat(v.y), asfloat(v.z), asfloat(v.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float  asfloat(uint v) { return asfloat((int)v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 asfloat(uint2 v) { return float2(asfloat(v.x), asfloat(v.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 asfloat(uint3 v) { return float3(asfloat(v.x), asfloat(v.y), asfloat(v.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 asfloat(uint4 v) { return float4(asfloat(v.x), asfloat(v.y), asfloat(v.z), asfloat(v.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double asdouble(long v)
        {
            LongDoubleUnion u;
            u.doubleValue = 0;
            u.longValue = v;
            return u.doubleValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double asdouble(ulong v) { return asdouble((long)v); }

        // isfinite
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool isfinite(float x) { return abs(x) < float.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 isfinite(float2 x) { return abs(x) < float.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 isfinite(float3 x) { return abs(x) < float.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 isfinite(float4 x) { return abs(x) < float.PositiveInfinity; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool isfinite(double x) { return abs(x) < double.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 isfinite(double2 x) { return abs(x) < double.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 isfinite(double3 x) { return abs(x) < double.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 isfinite(double4 x) { return abs(x) < double.PositiveInfinity; }

        // isinf
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool isinf(float x) { return abs(x) == float.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 isinf(float2 x) { return abs(x) == float.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 isinf(float3 x) { return abs(x) == float.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 isinf(float4 x) { return abs(x) == float.PositiveInfinity; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool isinf(double x) { return abs(x) == double.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 isinf(double2 x) { return abs(x) == double.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 isinf(double3 x) { return abs(x) == double.PositiveInfinity; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 isinf(double4 x) { return abs(x) == double.PositiveInfinity; }

        // isnan
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool isnan(float x) { return (asuint(x) & 0x7FFFFFFF) > 0x7F800000; }    //TODO: evaluate as (x != x) with burst intrinsic
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 isnan(float2 x) { return (asuint(x) & 0x7FFFFFFF) > 0x7F800000; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 isnan(float3 x) { return (asuint(x) & 0x7FFFFFFF) > 0x7F800000; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 isnan(float4 x) { return (asuint(x) & 0x7FFFFFFF) > 0x7F800000; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool isnan(double x) { return (asulong(x) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 isnan(double2 x) {
            return bool2((asulong(x.x) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                         (asulong(x.y) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 isnan(double3 x)
        {
            return bool3((asulong(x.x) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                         (asulong(x.y) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                         (asulong(x.z) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 isnan(double4 x)
        {
            return bool4((asulong(x.x) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                         (asulong(x.y) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                         (asulong(x.z) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000,
                         (asulong(x.w) & 0x7FFFFFFFFFFFFFFF) > 0x7FF0000000000000);
        }

        // min
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int min(int a, int b) { return a < b ? a : b; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 min(int2 a, int2 b) { return new int2(min(a.x, b.x), min(a.y, b.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 min(int3 a, int3 b) { return new int3(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 min(int4 a, int4 b) { return new int4(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z), min(a.w, b.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint min(uint a, uint b) { return a < b ? a : b; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 min(uint2 a, uint2 b) { return new uint2(min(a.x, b.x), min(a.y, b.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 min(uint3 a, uint3 b) { return new uint3(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 min(uint4 a, uint4 b) { return new uint4(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z), min(a.w, b.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float min(float a, float b) { return float.IsNaN(b) || a < b ? a : b; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 min(float2 a, float2 b) { return new float2(min(a.x, b.x), min(a.y, b.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 min(float3 a, float3 b) { return new float3(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 min(float4 a, float4 b) { return new float4(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z), min(a.w, b.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double min(double a, double b) { return double.IsNaN(b) || a < b ? a : b; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 min(double2 a, double2 b) { return new double2(min(a.x, b.x), min(a.y, b.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 min(double3 a, double3 b) { return new double3(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 min(double4 a, double4 b) { return new double4(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z), min(a.w, b.w)); }

        // max
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int max(int a, int b) { return a > b ? a : b; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 max(int2 a, int2 b) { return new int2(max(a.x, b.x), max(a.y, b.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 max(int3 a, int3 b) { return new int3(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 max(int4 a, int4 b) { return new int4(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z), max(a.w, b.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint max(uint a, uint b) { return a > b ? a : b; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 max(uint2 a, uint2 b) { return new uint2(max(a.x, b.x), max(a.y, b.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 max(uint3 a, uint3 b) { return new uint3(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 max(uint4 a, uint4 b) { return new uint4(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z), max(a.w, b.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float max(float a, float b) { return float.IsNaN(b) || a > b ? a : b; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 max(float2 a, float2 b) { return new float2(max(a.x, b.x), max(a.y, b.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 max(float3 a, float3 b) { return new float3(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 max(float4 a, float4 b) { return new float4(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z), max(a.w, b.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double max(double a, double b) { return double.IsNaN(b) || a > b ? a : b; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 max(double2 a, double2 b) { return new double2(max(a.x, b.x), max(a.y, b.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 max(double3 a, double3 b) { return new double3(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 max(double4 a, double4 b) { return new double4(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z), max(a.w, b.w)); }


        // lerp
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float lerp(float a, float b, float x) { return a + x * (b - a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 lerp(float2 a, float2 b, float x) { return a + x * (b - a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 lerp(float3 a, float3 b, float x) { return a + x * (b - a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 lerp(float4 a, float4 b, float x) { return a + x * (b - a); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double lerp(double a, double b, double x) { return a + x * (b - a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 lerp(double2 a, double2 b, double x) { return a + x * (b - a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 lerp(double3 a, double3 b, double x) { return a + x * (b - a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 lerp(double4 a, double4 b, double x) { return a + x * (b - a); }

        // unlerp - The inverse of lerp. unlerp(a, b, lerp(a, b, x)) = x
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float unlerp(float a, float b, float x) { return (x - a) / (b - a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double unlerp(double a, double b, double x) { return (x - a) / (b - a); }

        // remap - Linearly remaps a value x from [sa, sb] to [da, db]. lerp(da, db, unlerp(sa, sb, x));
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float remap(float sa, float sb, float da, float db, float x) { return lerp(da, db, unlerp(sa, sb, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double remap(double sa, double sb, double da, double db, double x) { return lerp(da, db, unlerp(sa, sb, x)); }

        // mad
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int mad(int a, int b, int c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 mad(int2 a, int2 b, int2 c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 mad(int3 a, int3 b, int3 c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 mad(int4 a, int4 b, int4 c) { return a * b + c; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint mad(uint a, uint b, uint c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 mad(uint2 a, uint2 b, uint2 c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 mad(uint3 a, uint3 b, uint3 c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 mad(uint4 a, uint4 b, uint4 c) { return a * b + c; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float mad(float a, float b, float c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 mad(float2 a, float2 b, float2 c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mad(float3 a, float3 b, float3 c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 mad(float4 a, float4 b, float4 c) { return a * b + c; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double mad(double a, double b, double c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 mad(double2 a, double2 b, double2 c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 mad(double3 a, double3 b, double3 c) { return a * b + c; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 mad(double4 a, double4 b, double4 c) { return a * b + c; }

        // clamp
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int clamp(int x, int a, int b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 clamp(int2 x, int2 a, int2 b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 clamp(int3 x, int3 a, int3 b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 clamp(int4 x, int4 a, int4 b) { return max(a, min(b, x)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint clamp(uint x, uint a, uint b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 clamp(uint2 x, uint2 a, uint2 b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 clamp(uint3 x, uint3 a, uint3 b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 clamp(uint4 x, uint4 a, uint4 b) { return max(a, min(b, x)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float clamp(float x, float a, float b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 clamp(float2 x, float2 a, float2 b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 clamp(float3 x, float3 a, float3 b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 clamp(float4 x, float4 a, float4 b) { return max(a, min(b, x)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double clamp(double x, double a, double b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 clamp(double2 x, double2 a, double2 b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 clamp(double3 x, double3 a, double3 b) { return max(a, min(b, x)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 clamp(double4 x, double4 a, double4 b) { return max(a, min(b, x)); }

        // saturate
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float saturate(float x) { return clamp(x, 0.0f, 1.0f); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 saturate(float2 x) { return clamp(x, new float2(0.0f), new float2(1.0f)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 saturate(float3 x) { return clamp(x, new float3(0.0f), new float3(1.0f)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 saturate(float4 x) { return clamp(x, new float4(0.0f), new float4(1.0f)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double saturate(double x) { return clamp(x, 0.0, 1.0); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 saturate(double2 x) { return clamp(x, new double2(0.0), new double2(1.0)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 saturate(double3 x) { return clamp(x, new double3(0.0), new double3(1.0)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 saturate(double4 x) { return clamp(x, new double4(0.0), new double4(1.0)); }

        // abs
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int abs(int a) { return max(-a, a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 abs(int2 a) { return max(-a, a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 abs(int3 a) { return max(-a, a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 abs(int4 a) { return max(-a, a); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float abs(float a) { return max(-a, a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 abs(float2 a) { return max(-a, a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 abs(float3 a) { return max(-a, a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 abs(float4 a) { return max(-a, a); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double abs(double a) { return max(-a, a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 abs(double2 a) { return max(-a, a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 abs(double3 a) { return max(-a, a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 abs(double4 a) { return max(-a, a); }


        // dot
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int dot(int pt1, int pt2) { return pt1 * pt2; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int dot(int2 pt1, int2 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int dot(int3 pt1, int3 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int dot(int4 pt1, int4 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z + pt1.w * pt2.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint dot(uint pt1, uint pt2) { return pt1 * pt2; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint dot(uint2 pt1, uint2 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint dot(uint3 pt1, uint3 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint dot(uint4 pt1, uint4 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z + pt1.w * pt2.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float pt1, float pt2) { return pt1 * pt2; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float2 pt1, float2 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float3 pt1, float3 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(float4 pt1, float4 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z + pt1.w * pt2.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double pt1, double pt2) { return pt1 * pt2; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double2 pt1, double2 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double3 pt1, double3 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double dot(double4 pt1, double4 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z + pt1.w * pt2.w; }

        // tan
        public static float tan(float value) { return (float)System.Math.Tan(value); }
        public static float2 tan(float2 value) { return new float2(tan(value.x), tan(value.y)); }
        public static float3 tan(float3 value) { return new float3(tan(value.x), tan(value.y), tan(value.z)); }
        public static float4 tan(float4 value) { return new float4(tan(value.x), tan(value.y), tan(value.z), tan(value.w)); }

        public static double tan(double value) { return (double)System.Math.Tan(value); }
        public static double2 tan(double2 value) { return new double2(tan(value.x), tan(value.y)); }
        public static double3 tan(double3 value) { return new double3(tan(value.x), tan(value.y), tan(value.z)); }
        public static double4 tan(double4 value) { return new double4(tan(value.x), tan(value.y), tan(value.z), tan(value.w)); }

        // tanh
        public static float tanh(float value) { return (float)System.Math.Tanh(value); }
        public static float2 tanh(float2 value) { return new float2(tanh(value.x), tanh(value.y)); }
        public static float3 tanh(float3 value) { return new float3(tanh(value.x), tanh(value.y), tanh(value.z)); }
        public static float4 tanh(float4 value) { return new float4(tanh(value.x), tanh(value.y), tanh(value.z), tanh(value.w)); }

        public static double tanh(double value) { return (double)System.Math.Tanh(value); }
        public static double2 tanh(double2 value) { return new double2(tanh(value.x), tanh(value.y)); }
        public static double3 tanh(double3 value) { return new double3(tanh(value.x), tanh(value.y), tanh(value.z)); }
        public static double4 tanh(double4 value) { return new double4(tanh(value.x), tanh(value.y), tanh(value.z), tanh(value.w)); }

        // atan
        public static float atan(float value) { return (float)System.Math.Atan(value); }
        public static float2 atan(float2 value) { return new float2(atan(value.x), atan(value.y)); }
        public static float3 atan(float3 value) { return new float3(atan(value.x), atan(value.y), atan(value.z)); }
        public static float4 atan(float4 value) { return new float4(atan(value.x), atan(value.y), atan(value.z), atan(value.w)); }

        public static double atan(double value) { return (double)System.Math.Atan(value); }
        public static double2 atan(double2 value) { return new double2(atan(value.x), atan(value.y)); }
        public static double3 atan(double3 value) { return new double3(atan(value.x), atan(value.y), atan(value.z)); }
        public static double4 atan(double4 value) { return new double4(atan(value.x), atan(value.y), atan(value.z), atan(value.w)); }

        // atan2
        public static float atan2(float pt1, float pt2) { return (float)System.Math.Atan2(pt1, pt2); }
        public static float2 atan2(float2 pt1, float2 pt2) { return new float2(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y)); }
        public static float3 atan2(float3 pt1, float3 pt2) { return new float3(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z)); }
        public static float4 atan2(float4 pt1, float4 pt2) { return new float4(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z), atan2(pt1.w, pt2.w)); }

        public static double atan2(double pt1, double pt2) { return (double)System.Math.Atan2(pt1, pt2); }
        public static double2 atan2(double2 pt1, double2 pt2) { return new double2(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y)); }
        public static double3 atan2(double3 pt1, double3 pt2) { return new double3(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z)); }
        public static double4 atan2(double4 pt1, double4 pt2) { return new double4(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z), atan2(pt1.w, pt2.w)); }

        // cos
        public static float cos(float a) { return (float)System.Math.Cos(a); }
        public static float2 cos(float2 a) { return new float2(cos(a.x), cos(a.y)); }
        public static float3 cos(float3 a) { return new float3(cos(a.x), cos(a.y), cos(a.z)); }
        public static float4 cos(float4 a) { return new float4(cos(a.x), cos(a.y), cos(a.z), cos(a.w)); }

        public static double cos(double a) { return (double)System.Math.Cos(a); }
        public static double2 cos(double2 a) { return new double2(cos(a.x), cos(a.y)); }
        public static double3 cos(double3 a) { return new double3(cos(a.x), cos(a.y), cos(a.z)); }
        public static double4 cos(double4 a) { return new double4(cos(a.x), cos(a.y), cos(a.z), cos(a.w)); }

        // cosh
        public static float cosh(float a) { return (float)System.Math.Cosh(a); }
        public static float2 cosh(float2 a) { return new float2(cosh(a.x), cosh(a.y)); }
        public static float3 cosh(float3 a) { return new float3(cosh(a.x), cosh(a.y), cosh(a.z)); }
        public static float4 cosh(float4 a) { return new float4(cosh(a.x), cosh(a.y), cosh(a.z), cosh(a.w)); }

        public static double cosh(double a) { return (double)System.Math.Cosh(a); }
        public static double2 cosh(double2 a) { return new double2(cosh(a.x), cosh(a.y)); }
        public static double3 cosh(double3 a) { return new double3(cosh(a.x), cosh(a.y), cosh(a.z)); }
        public static double4 cosh(double4 a) { return new double4(cosh(a.x), cosh(a.y), cosh(a.z), cosh(a.w)); }

        // acos
        public static float acos(float a) { return (float)System.Math.Acos((float)a); }
        public static float2 acos(float2 a) { return new float2(acos(a.x), acos(a.y)); }
        public static float3 acos(float3 a) { return new float3(acos(a.x), acos(a.y), acos(a.z)); }
        public static float4 acos(float4 a) { return new float4(acos(a.x), acos(a.y), acos(a.z), acos(a.w)); }

        public static double acos(double a) { return (double)System.Math.Acos(a); }
        public static double2 acos(double2 a) { return new double2(acos(a.x), acos(a.y)); }
        public static double3 acos(double3 a) { return new double3(acos(a.x), acos(a.y), acos(a.z)); }
        public static double4 acos(double4 a) { return new double4(acos(a.x), acos(a.y), acos(a.z), acos(a.w)); }

        // sin
        public static float sin(float a) { return (float)System.Math.Sin((float)a); }
        public static float2 sin(float2 a) { return new float2(sin(a.x), sin(a.y)); }
        public static float3 sin(float3 a) { return new float3(sin(a.x), sin(a.y), sin(a.z)); }
        public static float4 sin(float4 a) { return new float4(sin(a.x), sin(a.y), sin(a.z), sin(a.w)); }

        public static double sin(double a) { return (double)System.Math.Sin(a); }
        public static double2 sin(double2 a) { return new double2(sin(a.x), sin(a.y)); }
        public static double3 sin(double3 a) { return new double3(sin(a.x), sin(a.y), sin(a.z)); }
        public static double4 sin(double4 a) { return new double4(sin(a.x), sin(a.y), sin(a.z), sin(a.w)); }

        // sinh
        public static float sinh(float a) { return (float)System.Math.Sinh((float)a); }
        public static float2 sinh(float2 a) { return new float2(sinh(a.x), sinh(a.y)); }
        public static float3 sinh(float3 a) { return new float3(sinh(a.x), sinh(a.y), sinh(a.z)); }
        public static float4 sinh(float4 a) { return new float4(sinh(a.x), sinh(a.y), sinh(a.z), sinh(a.w)); }

        public static double sinh(double a) { return (double)System.Math.Sinh(a); }
        public static double2 sinh(double2 a) { return new double2(sinh(a.x), sinh(a.y)); }
        public static double3 sinh(double3 a) { return new double3(sinh(a.x), sinh(a.y), sinh(a.z)); }
        public static double4 sinh(double4 a) { return new double4(sinh(a.x), sinh(a.y), sinh(a.z), sinh(a.w)); }

        // asin
        public static float asin(float a) { return (float)System.Math.Asin((float)a); }
        public static float2 asin(float2 a) { return new float2(asin(a.x), asin(a.y)); }
        public static float3 asin(float3 a) { return new float3(asin(a.x), asin(a.y), asin(a.z)); }
        public static float4 asin(float4 a) { return new float4(asin(a.x), asin(a.y), asin(a.z), asin(a.w)); }

        public static double asin(double a) { return (double)System.Math.Asin(a); }
        public static double2 asin(double2 a) { return new double2(asin(a.x), asin(a.y)); }
        public static double3 asin(double3 a) { return new double3(asin(a.x), asin(a.y), asin(a.z)); }
        public static double4 asin(double4 a) { return new double4(asin(a.x), asin(a.y), asin(a.z), asin(a.w)); }

        // floor
        public static float floor(float a) { return (float)System.Math.Floor((float)a); }
        public static float2 floor(float2 a) { return new float2(floor(a.x), floor(a.y)); }
        public static float3 floor(float3 a) { return new float3(floor(a.x), floor(a.y), floor(a.z)); }
        public static float4 floor(float4 a) { return new float4(floor(a.x), floor(a.y), floor(a.z), floor(a.w)); }

        public static double floor(double a) { return (double)System.Math.Floor(a); }
        public static double2 floor(double2 a) { return new double2(floor(a.x), floor(a.y)); }
        public static double3 floor(double3 a) { return new double3(floor(a.x), floor(a.y), floor(a.z)); }
        public static double4 floor(double4 a) { return new double4(floor(a.x), floor(a.y), floor(a.z), floor(a.w)); }

        // ceil
        public static float ceil(float a) { return (float)System.Math.Ceiling((float)a); }
        public static float2 ceil(float2 a) { return new float2(ceil(a.x), ceil(a.y)); }
        public static float3 ceil(float3 a) { return new float3(ceil(a.x), ceil(a.y), ceil(a.z)); }
        public static float4 ceil(float4 a) { return new float4(ceil(a.x), ceil(a.y), ceil(a.z), ceil(a.w)); }

        public static double ceil(double a) { return (double)System.Math.Ceiling(a); }
        public static double2 ceil(double2 a) { return new double2(ceil(a.x), ceil(a.y)); }
        public static double3 ceil(double3 a) { return new double3(ceil(a.x), ceil(a.y), ceil(a.z)); }
        public static double4 ceil(double4 a) { return new double4(ceil(a.x), ceil(a.y), ceil(a.z), ceil(a.w)); }

        // round
        public static float round(float a) { return (float)System.Math.Round((float)a); }
        public static float2 round(float2 a) { return new float2(round(a.x), round(a.y)); }
        public static float3 round(float3 a) { return new float3(round(a.x), round(a.y), round(a.z)); }
        public static float4 round(float4 a) { return new float4(round(a.x), round(a.y), round(a.z), round(a.w)); }

        public static double round(double a) { return (double)System.Math.Round(a); }
        public static double2 round(double2 a) { return new double2(round(a.x), round(a.y)); }
        public static double3 round(double3 a) { return new double3(round(a.x), round(a.y), round(a.z)); }
        public static double4 round(double4 a) { return new double4(round(a.x), round(a.y), round(a.z), round(a.w)); }

        // trunc
        public static float trunc(float a) { return (float)System.Math.Truncate((float)a); }
        public static float2 trunc(float2 a) { return new float2(trunc(a.x), trunc(a.y)); }
        public static float3 trunc(float3 a) { return new float3(trunc(a.x), trunc(a.y), trunc(a.z)); }
        public static float4 trunc(float4 a) { return new float4(trunc(a.x), trunc(a.y), trunc(a.z), trunc(a.w)); }

        public static double trunc(double a) { return (double)System.Math.Truncate(a); }
        public static double2 trunc(double2 a) { return new double2(trunc(a.x), trunc(a.y)); }
        public static double3 trunc(double3 a) { return new double3(trunc(a.x), trunc(a.y), trunc(a.z)); }
        public static double4 trunc(double4 a) { return new double4(trunc(a.x), trunc(a.y), trunc(a.z), trunc(a.w)); }

        // frac
        public static float frac(float a) { return a - floor(a); }
        public static float2 frac(float2 a) { return a - floor(a); }
        public static float3 frac(float3 a) { return a - floor(a); }
        public static float4 frac(float4 a) { return a - floor(a); }

        public static double frac(double a) { return a - floor(a); }
        public static double2 frac(double2 a) { return a - floor(a); }
        public static double3 frac(double3 a) { return a - floor(a); }
        public static double4 frac(double4 a) { return a - floor(a); }

        // rcp
        public static float rcp(float a) { return 1f / a; }
        public static float2 rcp(float2 a) { return 1f / a; }
        public static float3 rcp(float3 a) { return 1f / a; }
        public static float4 rcp(float4 a) { return 1f / a; }

        public static double rcp(double a) { return 1.0 / a; }
        public static double2 rcp(double2 a) { return 1.0 / a; }
        public static double3 rcp(double3 a) { return 1.0 / a; }
        public static double4 rcp(double4 a) { return 1.0 / a; }

        // sign
        public static float sign(float f) { return f == 0.0f ? 0.0f : (f > 0.0f ? 1.0f : 0.0f) - (f < 0.0f ? 1.0f : 0.0f); }
        public static float2 sign(float2 f) { return new float2(sign(f.x), sign(f.y)); }
        public static float3 sign(float3 f) { return new float3(sign(f.x), sign(f.y), sign(f.z)); }
        public static float4 sign(float4 f) { return new float4(sign(f.x), sign(f.y), sign(f.z), sign(f.w)); }

        public static double sign(double f) { return f == 0 ? 0 : (f > 0.0 ? 1.0 : 0.0) - (f < 0.0 ? 1.0 : 0.0); }
        public static double2 sign(double2 f) { return new double2(sign(f.x), sign(f.y)); }
        public static double3 sign(double3 f) { return new double3(sign(f.x), sign(f.y), sign(f.z)); }
        public static double4 sign(double4 f) { return new double4(sign(f.x), sign(f.y), sign(f.z), sign(f.w)); }

        // mix
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float mix(float a, float b, float x) { return x * (b - a) + a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 mix(float2 a, float2 b, float2 x) { return x * (b - a) + a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mix(float3 a, float3 b, float3 x) { return x * (b - a) + a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 mix(float4 a, float4 b, float4 x) { return x * (b - a) + a; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double mix(double a, double b, double x) { return x * (b - a) + a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 mix(double2 a, double2 b, double2 x) { return x * (b - a) + a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 mix(double3 a, double3 b, double3 x) { return x * (b - a) + a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 mix(double4 a, double4 b, double4 x) { return x * (b - a) + a; }

        // pow
        public static float pow(float a, float b) { return (float)System.Math.Pow((float)a, (float)b); }
        public static float2 pow(float2 a, float2 b) { return new float2(pow(a.x, b.x), pow(a.y, b.y)); }
        public static float3 pow(float3 a, float3 b) { return new float3(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z)); }
        public static float4 pow(float4 a, float4 b) { return new float4(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z), pow(a.w, b.w)); }

        public static double pow(double a, double b) { return (double)System.Math.Pow(a, b); }
        public static double2 pow(double2 a, double2 b) { return new double2(pow(a.x, b.x), pow(a.y, b.y)); }
        public static double3 pow(double3 a, double3 b) { return new double3(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z)); }
        public static double4 pow(double4 a, double4 b) { return new double4(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z), pow(a.w, b.w)); }


        // powr - assumes sign of a is 0 or greater
        public static float powr(float a, float b) { return pow(a, b); }
        public static float2 powr(float2 a, float2 b) { return pow(a, b); }
        public static float3 powr(float3 a, float3 b) { return pow(a, b); }
        public static float4 powr(float4 a, float4 b) { return pow(a, b); }

        public static double powr(double a, double b) { return pow(a, b); }
        public static double2 powr(double2 a, double2 b) { return pow(a, b); }
        public static double3 powr(double3 a, double3 b) { return pow(a, b); }
        public static double4 powr(double4 a, double4 b) { return pow(a, b); }

        // exp
        public static float exp(float x) { return (float)System.Math.Exp((float)x); }
        public static float2 exp(float2 a) { return new float2(exp(a.x), exp(a.y)); }
        public static float3 exp(float3 a) { return new float3(exp(a.x), exp(a.y), exp(a.z)); }
        public static float4 exp(float4 a) { return new float4(exp(a.x), exp(a.y), exp(a.z), exp(a.w)); }

        public static double exp(double x) { return System.Math.Exp(x); }
        public static double2 exp(double2 a) { return new double2(exp(a.x), exp(a.y)); }
        public static double3 exp(double3 a) { return new double3(exp(a.x), exp(a.y), exp(a.z)); }
        public static double4 exp(double4 a) { return new double4(exp(a.x), exp(a.y), exp(a.z), exp(a.w)); }

        // exp2
        public static float exp2(float x) { return (float)System.Math.Pow(2.0f, (float)x); }
        public static float2 exp2(float2 a) { return new float2(exp2(a.x), exp2(a.y)); }
        public static float3 exp2(float3 a) { return new float3(exp2(a.x), exp2(a.y), exp2(a.z)); }
        public static float4 exp2(float4 a) { return new float4(exp2(a.x), exp2(a.y), exp2(a.z), exp2(a.w)); }

        public static double exp2(double x) { return System.Math.Pow(2.0, x); }
        public static double2 exp2(double2 a) { return new double2(exp2(a.x), exp2(a.y)); }
        public static double3 exp2(double3 a) { return new double3(exp2(a.x), exp2(a.y), exp2(a.z)); }
        public static double4 exp2(double4 a) { return new double4(exp2(a.x), exp2(a.y), exp2(a.z), exp2(a.w)); }

        // exp10
        public static float exp10(float x) { return (float)System.Math.Exp((float)x); }
        public static float2 exp10(float2 a) { return new float2(exp10(a.x), exp10(a.y)); }
        public static float3 exp10(float3 a) { return new float3(exp10(a.x), exp10(a.y), exp10(a.z)); }
        public static float4 exp10(float4 a) { return new float4(exp10(a.x), exp10(a.y), exp10(a.z), exp10(a.w)); }

        public static double exp10(double x) { return System.Math.Pow(10.0, x); }
        public static double2 exp10(double2 a) { return new double2(exp10(a.x), exp10(a.y)); }
        public static double3 exp10(double3 a) { return new double3(exp10(a.x), exp10(a.y), exp10(a.z)); }
        public static double4 exp10(double4 a) { return new double4(exp10(a.x), exp10(a.y), exp10(a.z), exp10(a.w)); }
        
        // log
        public static float log(float x) { return (float)System.Math.Log((float)x); }
        public static float2 log(float2 a) { return new float2(log(a.x), log(a.y)); }
        public static float3 log(float3 a) { return new float3(log(a.x), log(a.y), log(a.z)); }
        public static float4 log(float4 a) { return new float4(log(a.x), log(a.y), log(a.z), log(a.w)); }

        public static double log(double x) { return (double)System.Math.Log(x); }
        public static double2 log(double2 a) { return new double2(log(a.x), log(a.y)); }
        public static double3 log(double3 a) { return new double3(log(a.x), log(a.y), log(a.z)); }
        public static double4 log(double4 a) { return new double4(log(a.x), log(a.y), log(a.z), log(a.w)); }

        // log2
        public static float log2(float x) { return (float)System.Math.Log((float)x, 2.0f); }
        public static float2 log2(float2 a) { return new float2(log2(a.x), log2(a.y)); }
        public static float3 log2(float3 a) { return new float3(log2(a.x), log2(a.y), log2(a.z)); }
        public static float4 log2(float4 a) { return new float4(log2(a.x), log2(a.y), log2(a.z), log2(a.w)); }

        public static double log2(double x) { return (double)System.Math.Log(x, 2.0); }
        public static double2 log2(double2 a) { return new double2(log2(a.x), log2(a.y)); }
        public static double3 log2(double3 a) { return new double3(log2(a.x), log2(a.y), log2(a.z)); }
        public static double4 log2(double4 a) { return new double4(log2(a.x), log2(a.y), log2(a.z), log2(a.w)); }

        // log10
        public static float log10(float x) { return (float)System.Math.Log10((float)x); }
        public static float2 log10(float2 a) { return new float2(log10(a.x), log10(a.y)); }
        public static float3 log10(float3 a) { return new float3(log10(a.x), log10(a.y), log10(a.z)); }
        public static float4 log10(float4 a) { return new float4(log10(a.x), log10(a.y), log10(a.z), log10(a.w)); }

        public static double log10(double x) { return (double)System.Math.Log10(x); }
        public static double2 log10(double2 a) { return new double2(log10(a.x), log10(a.y)); }
        public static double3 log10(double3 a) { return new double3(log10(a.x), log10(a.y), log10(a.z)); }
        public static double4 log10(double4 a) { return new double4(log10(a.x), log10(a.y), log10(a.z), log10(a.w)); }

        // mod
        public static float mod(float a, float b) { return a % b; }
        public static float2 mod(float2 a, float2 b) { return new float2(a.x % b.x, a.y % b.y); }
        public static float3 mod(float3 a, float3 b) { return new float3(a.x % b.x, a.y % b.y, a.z % b.z); }
        public static float4 mod(float4 a, float4 b) { return new float4(a.x % b.x, a.y % b.y, a.z % b.z, a.w % b.w); }

        public static double mod(double a, double b) { return a % b; }
        public static double2 mod(double2 a, double2 b) { return new double2(a.x % b.x, a.y % b.y); }
        public static double3 mod(double3 a, double3 b) { return new double3(a.x % b.x, a.y % b.y, a.z % b.z); }
        public static double4 mod(double4 a, double4 b) { return new double4(a.x % b.x, a.y % b.y, a.z % b.z, a.w % b.w); }

        // modf - Splits a value v into an integer part i and a fractional part. Both parts take the sign of the input
        public static float modf(float v, out float i) { i = trunc(v); return v - i; }
        public static float2 modf(float2 v, out float2 i) { i = trunc(v); return v - i; }
        public static float3 modf(float3 v, out float3 i) { i = trunc(v); return v - i; }
        public static float4 modf(float4 v, out float4 i) { i = trunc(v); return v - i; }

        public static double modf(double v, out double i) { i = trunc(v); return v - i; }
        public static double2 modf(double2 v, out double2 i) { i = trunc(v); return v - i; }
        public static double3 modf(double3 v, out double3 i) { i = trunc(v); return v - i; }
        public static double4 modf(double4 v, out double4 i) { i = trunc(v); return v - i; }

        // sqrt
        public static float sqrt(float a) { return (float)System.Math.Sqrt((float)a); }
        public static float2 sqrt(float2 a) { return new float2(sqrt(a.x), sqrt(a.y)); }
        public static float3 sqrt(float3 a) { return new float3(sqrt(a.x), sqrt(a.y), sqrt(a.z)); }
        public static float4 sqrt(float4 a) { return new float4(sqrt(a.x), sqrt(a.y), sqrt(a.z), sqrt(a.w)); }

        public static double sqrt(double a) { return (double)System.Math.Sqrt(a); }
        public static double2 sqrt(double2 a) { return new double2(sqrt(a.x), sqrt(a.y)); }
        public static double3 sqrt(double3 a) { return new double3(sqrt(a.x), sqrt(a.y), sqrt(a.z)); }
        public static double4 sqrt(double4 a) { return new double4(sqrt(a.x), sqrt(a.y), sqrt(a.z), sqrt(a.w)); }

        // rsqrt
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float rsqrt(float a) { return 1.0f / sqrt(a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 rsqrt(float2 a) { return 1.0f / sqrt(a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 rsqrt(float3 a) { return 1.0f / sqrt(a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 rsqrt(float4 a) { return 1.0f / sqrt(a); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double rsqrt(double a) { return 1.0 / sqrt(a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 rsqrt(double2 a) { return 1.0 / sqrt(a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 rsqrt(double3 a) { return 1.0 / sqrt(a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 rsqrt(double4 a) { return 1.0 / sqrt(a); }

        // normalize
        public static float2 normalize(float2 v) { return rsqrt(dot(v, v)) * v; }
        public static float3 normalize(float3 v) { return rsqrt(dot(v, v)) * v; }
        public static float4 normalize(float4 v) { return rsqrt(dot(v, v)) * v; }

        public static double2 normalize(double2 v) { return rsqrt(dot(v, v)) * v; }
        public static double3 normalize(double3 v) { return rsqrt(dot(v, v)) * v; }
        public static double4 normalize(double4 v) { return rsqrt(dot(v, v)) * v; }

        // length
        public static float length(float v) { return abs(v); }
        public static float length(float2 v) { return sqrt(dot(v, v)); }
        public static float length(float3 v) { return sqrt(dot(v, v)); }
        public static float length(float4 v) { return sqrt(dot(v, v)); }

        public static double length(double v) { return abs(v); }
        public static double length(double2 v) { return sqrt(dot(v, v)); }
        public static double length(double3 v) { return sqrt(dot(v, v)); }
        public static double length(double4 v) { return sqrt(dot(v, v)); }

        // length squared
        public static float lengthSquared(float v) { return v*v; }
        public static float lengthSquared(float2 v) { return dot(v, v); }
        public static float lengthSquared(float3 v) { return dot(v, v); }
        public static float lengthSquared(float4 v) { return dot(v, v); }

        public static double lengthSquared(double v) { return v * v; }
        public static double lengthSquared(double2 v) { return dot(v, v); }
        public static double lengthSquared(double3 v) { return dot(v, v); }
        public static double lengthSquared(double4 v) { return dot(v, v); }

        // distance
        public static float distance(float pt1, float pt2) { return length(pt2 - pt1); }
        public static float distance(float2 pt1, float2 pt2) { return length(pt2 - pt1); }
        public static float distance(float3 pt1, float3 pt2) { return length(pt2 - pt1); }
        public static float distance(float4 pt1, float4 pt2) { return length(pt2 - pt1); }

        public static double distance(double pt1, double pt2) { return length(pt2 - pt1); }
        public static double distance(double2 pt1, double2 pt2) { return length(pt2 - pt1); }
        public static double distance(double3 pt1, double3 pt2) { return length(pt2 - pt1); }
        public static double distance(double4 pt1, double4 pt2) { return length(pt2 - pt1); }

        // cross
        public static float3 cross(float3 p0, float3 p1) { return (p0 * p1.yzx - p0.yzx * p1).yzx; }
        public static double3 cross(double3 p0, double3 p1) { return (p0 * p1.yzx - p0.yzx * p1).yzx; }

        public static float smoothstep(float a, float b, float x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        public static float2 smoothstep(float2 a, float2 b, float2 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        public static float3 smoothstep(float3 a, float3 b, float3 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        public static float4 smoothstep(float4 a, float4 b, float4 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }


        public static double smoothstep(double a, double b, double x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        public static double2 smoothstep(double2 a, double2 b, double2 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        public static double3 smoothstep(double3 a, double3 b, double3 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        public static double4 smoothstep(double4 a, double4 b, double4 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        // any
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(bool a) { return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(bool2 a) { return a.x || a.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(bool3 a) { return a.x || a.y || a.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(bool4 a) { return a.x || a.y || a.z || a.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(int a) { return a != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(int2 a) { return a.x != 0 || a.y != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(int3 a) { return a.x != 0 || a.y != 0 || a.z != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(int4 a) { return a.x != 0 || a.y != 0 || a.z != 0 || a.w != 0; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(uint a) { return a != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(uint2 a) { return a.x != 0 || a.y != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(uint3 a) { return a.x != 0 || a.y != 0 || a.z != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(uint4 a) { return a.x != 0 || a.y != 0 || a.z != 0 || a.w != 0; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(float a) { return a != 0.0f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(float2 a) { return a.x != 0.0f || a.y != 0.0f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(float3 a) { return a.x != 0.0f || a.y != 0.0f || a.z != 0.0f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(float4 a) { return a.x != 0.0f || a.y != 0.0f || a.z != 0.0f || a.w != 0.0f; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(double a) { return a != 0.0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(double2 a) { return a.x != 0.0 || a.y != 0.0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(double3 a) { return a.x != 0.0 || a.y != 0.0 || a.z != 0.0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool any(double4 a) { return a.x != 0.0 || a.y != 0.0 || a.z != 0.0 || a.w != 0.0; }

        // all
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(bool a) { return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(bool2 a) { return a.x && a.y; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(bool3 a) { return a.x && a.y && a.z; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(bool4 a) { return a.x && a.y && a.z && a.w; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(int a) { return a != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(int2 a) { return a.x != 0 && a.y != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(int3 a) { return a.x != 0 && a.y != 0 && a.z != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(int4 a) { return a.x != 0 && a.y != 0 && a.z != 0 && a.w != 0; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(uint a) { return a != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(uint2 a) { return a.x != 0 && a.y != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(uint3 a) { return a.x != 0 && a.y != 0 && a.z != 0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(uint4 a) { return a.x != 0 && a.y != 0 && a.z != 0 && a.w != 0; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(float a) { return a != 0.0f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(float2 a) { return a.x != 0.0f && a.y != 0.0f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(float3 a) { return a.x != 0.0f && a.y != 0.0f && a.z != 0.0f; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(float4 a) { return a.x != 0.0f && a.y != 0.0f && a.z != 0.0f && a.w != 0.0f; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(double a) { return a != 0.0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(double2 a) { return a.x != 0.0 && a.y != 0.0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(double3 a) { return a.x != 0.0 && a.y != 0.0 && a.z != 0.0; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool all(double4 a) { return a.x != 0.0 && a.y != 0.0 && a.z != 0.0 && a.w != 0.0; }

        // Select
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int select(int a, int b, bool c)    { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 select(int2 a, int2 b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 select(int3 a, int3 b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 select(int4 a, int4 b, bool c) { return c ? b : a; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 select(int2 a, int2 b, bool2 c) { return new int2(c.x ? b.x : a.x, c.y ? b.y : a.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 select(int3 a, int3 b, bool3 c) { return new int3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 select(int4 a, int4 b, bool4 c) { return new int4(c.x ? b.x : a.x, c.y ? a.y : b.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint select(uint a, uint b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 select(uint2 a, uint2 b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 select(uint3 a, uint3 b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 select(uint4 a, uint4 b, bool c) { return c ? b : a; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 select(uint2 a, uint2 b, bool2 c) { return new uint2(c.x ? b.x : a.x, c.y ? b.y : a.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 select(uint3 a, uint3 b, bool3 c) { return new uint3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 select(uint4 a, uint4 b, bool4 c) { return new uint4(c.x ? b.x : a.x, c.y ? a.y : b.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float select(float a, float b, bool c)    { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 select(float2 a, float2 b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 select(float3 a, float3 b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 select(float4 a, float4 b, bool c) { return c ? b : a; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 select(float2 a, float2 b, bool2 c) { return new float2(c.x ? b.x : a.x, c.y ? b.y : a.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 select(float3 a, float3 b, bool3 c) { return new float3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 select(float4 a, float4 b, bool4 c) { return new float4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double select(double a, double b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 select(double2 a, double2 b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 select(double3 a, double3 b, bool c) { return c ? b : a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 select(double4 a, double4 b, bool c) { return c ? b : a; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 select(double2 a, double2 b, bool2 c) { return new double2(c.x ? b.x : a.x, c.y ? b.y : a.y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 select(double3 a, double3 b, bool3 c) { return new double3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 select(double4 a, double4 b, bool4 c) { return new double4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }

        //Step
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float step(float a, float b) { return select(0.0f, 1.0f, b >= a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 step(float2 a, float2 b) { return select(float2(0.0f), float2(1.0f), b >= a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 step(float3 a, float3 b) { return select(float3(0.0f), float3(1.0f), b >= a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 step(float4 a, float4 b) { return select(float4(0.0f), float4(1.0f), b >= a); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double step(double a, double b) { return select(0.0, 1.0, b >= a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 step(double2 a, double2 b) { return select(double2(0.0), double2(1.0), b >= a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 step(double3 a, double3 b) { return select(double3(0.0), double3(1.0), b >= a); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 step(double4 a, double4 b) { return select(double4(0.0), double4(1.0), b >= a); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float reflect(float i, float n) { return i - 2f * n * dot(i, n); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 reflect(float2 i, float2 n) { return i - 2f * n * dot(i, n); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 reflect(float3 i, float3 n) { return i - 2f * n * dot(i, n); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 reflect(float4 i, float4 n) { return i - 2f * n * dot(i, n); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double reflect(double i, double n) { return i - 2 * n * dot(i, n); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 reflect(double2 i, double2 n) { return i - 2 * n * dot(i, n); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 reflect(double3 i, double3 n) { return i - 2 * n * dot(i, n); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 reflect(double4 i, double4 n) { return i - 2 * n * dot(i, n); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float refract(float i, float n, float eta)
        {
            float ni = dot(n, i);
            float k = 1.0f - eta * eta * (1.0f - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 refract(float2 i, float2 n, float eta)
        {
            float ni = dot(n, i);
            float k = 1.0f - eta * eta * (1.0f - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 refract(float3 i, float3 n, float eta)
        {
            float ni = dot(n, i);
            float k = 1.0f - eta * eta * (1.0f - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 refract(float4 i, float4 n, float eta)
        {
            float ni = dot(n, i);
            float k = 1.0f - eta * eta * (1.0f - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double refract(double i, double n, double eta)
        {
            double ni = dot(n, i);
            double k = 1.0 - eta * eta * (1.0 - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 refract(double2 i, double2 n, double eta)
        {
            double ni = dot(n, i);
            double k = 1.0 - eta * eta * (1.0 - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 refract(double3 i, double3 n, double eta)
        {
            double ni = dot(n, i);
            double k = 1.0 - eta * eta * (1.0 - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 refract(double4 i, double4 n, double eta)
        {
            double ni = dot(n, i);
            double k = 1.0 - eta * eta * (1.0 - ni * ni);
            return select(0.0f, eta * i - (eta * ni + sqrt(k)) * n, k >= 0);
        }

        // Returns n if dot(i, ng) < 0, otherwise returns -N
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float faceforward(float n, float i, float ng) { return select(n, -n, dot(ng, i) >= 0.0f); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float2 faceforward(float2 n, float2 i, float2 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 faceforward(float3 n, float3 i, float3 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 faceforward(float4 n, float4 i, float4 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double faceforward(double n, double i, double ng) { return select(n, -n, dot(ng, i) >= 0.0f); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double2 faceforward(double2 n, double2 i, double2 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 faceforward(double3 n, double3 i, double3 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 faceforward(double4 n, double4 i, double4 ng) { return select(n, -n, dot(ng, i) >= 0.0f); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(float x, out float s, out float c) { s = sin(x); c = cos(x); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(float2 x, out float2 s, out float2 c) { s = sin(x); c = cos(x); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(float3 x, out float3 s, out float3 c) { s = sin(x); c = cos(x); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(float4 x, out float4 s, out float4 c) { s = sin(x); c = cos(x); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(double x, out double s, out double c) { s = sin(x); c = cos(x); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(double2 x, out double2 s, out double2 c) { s = sin(x); c = cos(x); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(double3 x, out double3 s, out double3 c) { s = sin(x); c = cos(x); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void sincos(double4 x, out double4 s, out double4 c) { s = sin(x); c = cos(x); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 up() { return new float3(0.0f,1.0f,0.0f); }

        // count bits
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int countbits(uint v)
        {
            v = v - ((v >> 1) & 0x55555555);
            v = (v & 0x33333333) + ((v >> 2) & 0x33333333);
            return (int)((((v + (v >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 countbits(uint2 v)
        {
            v = v - ((v >> 1) & 0x55555555);
            v = (v & 0x33333333) + ((v >> 2) & 0x33333333);
            return int2((((v + (v >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 countbits(uint3 v)
        {
            v = v - ((v >> 1) & 0x55555555);
            v = (v & 0x33333333) + ((v >> 2) & 0x33333333);
            return int3((((v + (v >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 countbits(uint4 v)
        {
            v = v - ((v >> 1) & 0x55555555);
            v = (v & 0x33333333) + ((v >> 2) & 0x33333333);
            return int4((((v + (v >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int countbits(int v) { return countbits((uint)v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 countbits(int2 v) { return countbits((uint2)v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 countbits(int3 v) { return countbits((uint3)v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 countbits(int4 v) { return countbits((uint4)v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int countbits(ulong v)
        {
            v = v - ((v >> 1) & 0x5555555555555555);
            v = (v & 0x3333333333333333) + ((v >> 2) & 0x3333333333333333);
            return (int)((((v + (v >> 4)) & 0x0F0F0F0F0F0F0F0F) * 0x0101010101010101) >> 56);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int countbits(long v) { return countbits((ulong)v); }

        // leading zero count
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int lzcnt(uint v)
        {
            if (v == 0)
                return 32;
            LongDoubleUnion u;
            u.doubleValue = 0.0;
            u.longValue = 0x4330000000000000L + v;
            u.doubleValue -= 4503599627370496.0;
            return 0x41E - (int)(u.longValue >> 52);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int lzcnt(int v) { return lzcnt((uint)v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 lzcnt(int2 v) { return int2(lzcnt(v.x), lzcnt(v.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 lzcnt(int3 v) { return int3(lzcnt(v.x), lzcnt(v.y), lzcnt(v.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 lzcnt(int4 v) { return int4(lzcnt(v.x), lzcnt(v.y), lzcnt(v.z), lzcnt(v.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 lzcnt(uint2 v) { return int2(lzcnt(v.x), lzcnt(v.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 lzcnt(uint3 v) { return int3(lzcnt(v.x), lzcnt(v.y), lzcnt(v.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 lzcnt(uint4 v) { return int4(lzcnt(v.x), lzcnt(v.y), lzcnt(v.z), lzcnt(v.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int lzcnt(ulong v)
        {
            if (v == 0)
                return 64;

            uint vh = (uint)(v >> 32);
            uint bits = vh != 0 ? vh : (uint)v;
            int offset = vh != 0 ? 0x41E : 0x43E;

            LongDoubleUnion u;
            u.doubleValue = 0.0;
            u.longValue = 0x4330000000000000L + bits;
            u.doubleValue -= 4503599627370496.0;
            return offset - (int)(u.longValue >> 52);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int lzcnt(long v) { return lzcnt((ulong)v); }

        // trailing zero count
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int tzcnt(uint v)
        {
            if (v == 0)
                return 32;

            v &= (uint)-v;
            LongDoubleUnion u;
            u.doubleValue = 0.0;
            u.longValue = 0x4330000000000000L + v;
            u.doubleValue -= 4503599627370496.0;
            return (int)(u.longValue >> 52) - 0x3FF;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int tzcnt(int v) { return tzcnt((uint)v); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 tzcnt(int2 v) { return int2(tzcnt(v.x), tzcnt(v.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 tzcnt(int3 v) { return int3(tzcnt(v.x), tzcnt(v.y), tzcnt(v.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 tzcnt(int4 v) { return int4(tzcnt(v.x), tzcnt(v.y), tzcnt(v.z), tzcnt(v.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 tzcnt(uint2 v) { return int2(tzcnt(v.x), tzcnt(v.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 tzcnt(uint3 v) { return int3(tzcnt(v.x), tzcnt(v.y), tzcnt(v.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 tzcnt(uint4 v) { return int4(tzcnt(v.x), tzcnt(v.y), tzcnt(v.z), tzcnt(v.w)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int tzcnt(ulong v)
        {
            if (v == 0)
                return 64;

            v = v & (ulong)-(long)v;
            uint vl = (uint)v;

            uint bits = vl != 0 ? vl : (uint)(v >> 32);
            int offset = vl != 0 ? 0x3FF : 0x3DF;

            LongDoubleUnion u;
            u.doubleValue = 0.0;
            u.longValue = 0x4330000000000000L + bits;
            u.doubleValue -= 4503599627370496.0;
            return (int)(u.longValue >> 52) - offset;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int tzcnt(long v) { return tzcnt((ulong)v); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int reversebits(int x) { return (int)reversebits((uint)x); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int2 reversebits(int2 x) { return (int2)reversebits((uint2)x); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int3 reversebits(int3 x) { return (int3)reversebits((uint3)x); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int4 reversebits(int4 x) { return (int4)reversebits((uint4)x); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint reversebits(uint x) {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 reversebits(uint2 x)
        {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 reversebits(uint3 x)
        {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 reversebits(uint4 x)
        {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong reversebits(ulong x)
        {
            x = ((x >> 1) & 0x5555555555555555ul) | ((x & 0x5555555555555555ul) << 1);
            x = ((x >> 2) & 0x3333333333333333ul) | ((x & 0x3333333333333333ul) << 2);
            x = ((x >> 4) & 0x0F0F0F0F0F0F0F0Ful) | ((x & 0x0F0F0F0F0F0F0F0Ful) << 4);
            x = ((x >> 8) & 0x00FF00FF00FF00FFul) | ((x & 0x00FF00FF00FF00FFul) << 8);
            x = ((x >> 16) & 0x0000FFFF0000FFFFul) | ((x & 0x0000FFFF0000FFFFul) << 16);
            return (x >> 32) | (x << 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long reversebits(long x) { return (long)reversebits((ulong)x); }

        // SSE shuffles
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 unpacklo(float4 a, float4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 unpacklo(double4 a, double4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 unpackhi(float4 a, float4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftW, ShuffleComponent.RightW);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 unpackhi(double4 a, double4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftW, ShuffleComponent.RightW);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 movelh(float4 a, float4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.RightY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 movelh(double4 a, double4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.RightY);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 movehl(float4 a, float4 b)
        {
            return shuffle(b, a, ShuffleComponent.LeftZ, ShuffleComponent.LeftW, ShuffleComponent.RightZ, ShuffleComponent.RightW);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 movehl(double4 a, double4 b)
        {
            return shuffle(b, a, ShuffleComponent.LeftZ, ShuffleComponent.LeftW, ShuffleComponent.RightZ, ShuffleComponent.RightW);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint fold_to_uint(double v)  // utility for double hashing
        {
            LongDoubleUnion u;
            u.longValue = 0;
            u.doubleValue = v;
            return (uint)(u.longValue >> 32) ^ (uint)u.longValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint2 fold_to_uint(double2 v) { return uint2(fold_to_uint(v.x), fold_to_uint(v.y)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint3 fold_to_uint(double3 v) { return uint3(fold_to_uint(v.x), fold_to_uint(v.y), fold_to_uint(v.z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint4 fold_to_uint(double4 v) { return uint4(fold_to_uint(v.x), fold_to_uint(v.y), fold_to_uint(v.z), fold_to_uint(v.w)); }

        [StructLayout(LayoutKind.Explicit)]
        internal struct IntFloatUnion
        {
            [FieldOffset(0)]
            public int intValue;
            [FieldOffset(0)]
            public float floatValue;
        }

        [StructLayout(LayoutKind.Explicit)]
        internal struct LongDoubleUnion
        {
            [FieldOffset(0)]
            public long longValue;
            [FieldOffset(0)]
            public double doubleValue;
        }
    }
}
