using System;
using Unity.Mathematics.Experimental;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    [Serializable]
    public partial struct Random
    {
        public uint4 state;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Random(uint seed = 0x6E624EB7u)
        {
            state = uint4(seed) ^ uint4(0xFAAF07DDu, 0x625C45BDu, 0xC9F27FCBu, 0x6D2523B1u);
        }

        // return numbers from 0 (inclusive) to 1 (exclusive)
        public float NextFloat()
        {
            float v = asfloat(0x3f800000 | (state.x & 0x7fffff)) - 1.0f;
            advance_state();
            return v;
        }

        public float2 NextFloat2()
        {
            float2 v = asfloat(0x3f80_0000 | (state.xy >> 9)) - 1.0f;
            advance_state();
            return v;
        }

        public float3 NextFloat3()
        {
            float3 v = asfloat(0x3f80_0000 | (state.xyz >> 9)) - 1.0f;
            advance_state();
            return v;
        }

        public float4 NextFloat4()
        {
            float4 v = asfloat(0x3f80_0000 | (state >> 9)) - 1.0f;
            advance_state();
            return v;
        }

        public double NextDouble()
        {
            ulong sx = ((ulong)state.x << 20) ^ state.y;
            double v = asdouble(0x3ff0_0000_0000_0000 | sx) - 1.0;
            advance_state();
            return v;
        }

        public double2 NextDouble2()
        {
            ulong sx = ((ulong)state.x << 20) ^ state.y;
            ulong sy = ((ulong)state.z << 20) ^ state.w;
            double2 v = double2(asdouble(0x3ff0_0000_0000_0000 | sx),
                                asdouble(0x3ff0_0000_0000_0000 | sy)) - 1.0;
            advance_state();
            return v;
        }

        public double3 NextDouble3()
        {
            ulong sx = ((ulong)state.x << 20) ^ state.y;
            ulong sy = ((ulong)state.z << 20) ^ state.w;
            advance_state();
            ulong sz = ((ulong)state.x << 20) ^ state.y;

            double3 v = double3(asdouble(0x3ff0_0000_0000_0000 | sx),
                                asdouble(0x3ff0_0000_0000_0000 | sy),
                                asdouble(0x3ff0_0000_0000_0000 | sz)) - 1.0;
            advance_state();
            return v;
        }

        public double4 NextDouble4()
        {
            ulong sx = ((ulong)state.x << 20) ^ state.y;
            ulong sy = ((ulong)state.z << 20) ^ state.w;
            advance_state();
            ulong sz = ((ulong)state.y << 20) ^ state.z;
            ulong sw = ((ulong)state.w << 20) ^ state.x;

            double4 v = double4(asdouble(0x3ff0_0000_0000_0000 | sx),
                                asdouble(0x3ff0_0000_0000_0000 | sy),
                                asdouble(0x3ff0_0000_0000_0000 | sz),
                                asdouble(0x3ff0_0000_0000_0000 | sw)) - 1.0;
            advance_state();
            return v;
        }

        public uint NextUInt()
        {
            uint v = state.x;
            advance_state();
            return v;
        }

        public uint2 NextUInt2()
        {
            uint2 v = state.xy;
            advance_state();
            return v;
        }

        public uint3 NextUInt3()
        {
            uint3 v = state.xyz;
            advance_state();
            return v;
        }

        public uint4 NextUInt4()
        {
            uint4 v = state;
            advance_state();
            return v;
        }

        public float NextFloat(float max) { return NextFloat() * max; }
        public float2 NextFloat2(float2 max) { return NextFloat2() * max; }
        public float3 NextFloat3(float3 max) { return NextFloat3() * max; }
        public float4 NextFloat4(float4 max) { return NextFloat4() * max; }
        
        public float NextFloat(float min, float max) { return NextFloat() * (max - min) + min; }
        public float2 NextFloat2(float2 min, float2 max) { return NextFloat2() * (max - min) + min; }
        public float3 NextFloat3(float3 min, float3 max) { return NextFloat3() * (max - min) + min; }
        public float4 NextFloat4(float4 min, float4 max) { return NextFloat4() * (max - min) + min; }

        public float2 NextFloat2Direction()
        {
            float angle = NextFloat() * (float)PI * 2.0f;
            float s, c;
            sincos(angle, out s, out c);
            return float2(c, s);
        }

        public double2 NextDouble2Direction()
        {
            double angle = NextDouble() * PI * 2.0;
            double s, c;
            sincos(angle, out s, out c);
            return double2(c, s);
        }

        public float3 NextFloat3Direction()
        {
            float2 rnd = NextFloat2();
            float z = rnd.x * 2.0f - 1.0f;
            float r = sqrt(max(1.0f - z * z, 0.0f));
            float angle = rnd.y * (float)PI * 2.0f;
            float s, c;
            sincos(angle, out s, out c);
            return float3(c*r, s*r, z);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void advance_state()
        {
            state ^= state << 13;
            state ^= state >> 17;
            state ^= state << 5;
        }
    }
}
