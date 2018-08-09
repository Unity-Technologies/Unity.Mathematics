using System;
using Unity.Mathematics.Experimental;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

// Random Number Generator based on xorshift.
// Designed to have minimal state size to be easily embeddable and without use of multiplication
// to make it easier to vectorize on targets with limited SIMD capabilities.

namespace Unity.Mathematics
{
    [Serializable]
    public partial struct Random
    {
        private uint state;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Random(uint seed = 0x6E624EB7u)
        {
            state = seed;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool NextBool()
        {
            return ((int)NextState() < 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool2 NextBool2()
        {
            return (int2((int)NextState(), (int)NextState()) < 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool3 NextBool3()
        {
            return (int3((int)NextState(), (int)NextState(), (int)NextState()) < 0);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool4 NextBool4()
        {
            return (int4((int)NextState(), (int)NextState(), (int)NextState(), (int)NextState()) < 0);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int NextInt()    // [-2147483647, 2147483647]
        {
            return (int)NextState() ^ -2147483648;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int2 NextInt2()  // [-2147483647, 2147483647]
        {
            return int2((int)NextState(), (int)NextState()) ^ -2147483648;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int3 NextInt3()  // [-2147483647, 2147483647]
        {
            return int3((int)NextState(), (int)NextState(), (int)NextState()) ^ -2147483648;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int4 NextInt4()  // [-2147483647, 2147483647]
        {
            return int4((int)NextState(), (int)NextState(), (int)NextState(), (int)NextState()) ^ -2147483648;
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint NextUInt()  // [0, 4294967294]
        {
            return NextState() - 1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2 NextUInt2()    // [0, 4294967294]
        {
            return uint2(NextState(), NextState()) - 1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3 NextUInt3()    // [0, 4294967294]
        {
            return uint3(NextState(), NextState(), NextState()) - 1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4 NextUInt4()    // [0, 4294967294]
        {
            return uint4(NextState(), NextState(), NextState(), NextState()) - 1u;
        }

        // return numbers from 0 (inclusive) to 1 (exclusive)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float NextFloat()    // [0, 1)
        {
            return asfloat(0x3f80_0000 | (NextState() >> 9)) - 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2 NextFloat2()  // [0, 1)
        {
            return asfloat(0x3f80_0000 | (uint2(NextState(), NextState()) >> 9)) - 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 NextFloat3()  // [0, 1)
        {
            return asfloat(0x3f80_0000 | (uint3(NextState(), NextState(), NextState()) >> 9)) - 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4 NextFloat4()  // [0, 1)
        {
            return asfloat(0x3f80_0000 | (uint4(NextState(), NextState(), NextState(), NextState()) >> 9)) - 1.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double NextDouble()  // [0, 1)
        {
            ulong sx = ((ulong)NextState() << 20) ^ NextState();
            return asdouble(0x3ff0_0000_0000_0000 | sx) - 1.0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double2 NextDouble2()    // [0, 1)
        {
            ulong sx = ((ulong)NextState() << 20) ^ NextState();
            ulong sy = ((ulong)NextState() << 20) ^ NextState();
            return double2(asdouble(0x3ff0_0000_0000_0000 | sx),
                           asdouble(0x3ff0_0000_0000_0000 | sy)) - 1.0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double3 NextDouble3()    // [0, 1)
        {
            ulong sx = ((ulong)NextState() << 20) ^ NextState();
            ulong sy = ((ulong)NextState() << 20) ^ NextState();
            ulong sz = ((ulong)NextState() << 20) ^ NextState();
            return double3(asdouble(0x3ff0_0000_0000_0000 | sx),
                           asdouble(0x3ff0_0000_0000_0000 | sy),
                           asdouble(0x3ff0_0000_0000_0000 | sz)) - 1.0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public double4 NextDouble4()    // [0, 1)
        {
            ulong sx = ((ulong)NextState() << 20) ^ NextState();
            ulong sy = ((ulong)NextState() << 20) ^ NextState();
            ulong sz = ((ulong)NextState() << 20) ^ NextState();
            ulong sw = ((ulong)NextState() << 20) ^ NextState();
            return double4(asdouble(0x3ff0_0000_0000_0000 | sx),
                           asdouble(0x3ff0_0000_0000_0000 | sy),
                           asdouble(0x3ff0_0000_0000_0000 | sz),
                           asdouble(0x3ff0_0000_0000_0000 | sw)) - 1.0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint NextUInt(uint max)  // [0, max)
        {
            return (uint)((NextState() * (ulong)max) >> 32);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2 NextUInt2(uint2 max)   // [0, max)
        {
            return uint2(   (uint)(NextState() * (ulong)max.x >> 32),
                            (uint)(NextState() * (ulong)max.y >> 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint3 NextUInt3(uint3 max)   // [0, max)
        {
            return uint3(   (uint)(NextState() * (ulong)max.x >> 32),
                            (uint)(NextState() * (ulong)max.y >> 32),
                            (uint)(NextState() * (ulong)max.z >> 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4 NextUInt4(uint4 max)   // [0, max)
        {
            return uint4(   (uint)(NextState() * (ulong)max.x >> 32),
                            (uint)(NextState() * (ulong)max.y >> 32),
                            (uint)(NextState() * (ulong)max.z >> 32),
                            (uint)(NextState() * (ulong)max.w >> 32));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float NextFloat(float max) { return NextFloat() * max; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2 NextFloat2(float2 max) { return NextFloat2() * max; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 NextFloat3(float3 max) { return NextFloat3() * max; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float4 NextFloat4(float4 max) { return NextFloat4() * max; }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float NextFloat(float min, float max) { return NextFloat() * (max - min) + min; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float2 NextFloat2(float2 min, float2 max) { return NextFloat2() * (max - min) + min; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 NextFloat3(float3 min, float3 max) { return NextFloat3() * (max - min) + min; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
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

        public double3 NextDouble3Direction()
        {
            double2 rnd = NextDouble2();
            double z = rnd.x * 2.0 - 1.0;
            double r = sqrt(max(1.0 - z * z, 0.0));
            double angle = rnd.y * PI * 2.0;
            double s, c;
            sincos(angle, out s, out c);
            return double3(c * r, s * r, z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private uint NextState()
        {
            uint t = state;
            state ^= state << 13;
            state ^= state >> 17;
            state ^= state << 5;
            return t;
        }
    }
}
