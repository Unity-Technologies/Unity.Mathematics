using NUnit.Framework;
using System;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestRandom
    {
        // Kolmogorov–Smirnov test on lambda assuming the ideal distribution is uniform [0, 1]
        private void ks_test(Func<double> func, int num_buckets = 256)
        {
            const int N = 2048;
            var histogram = new int[num_buckets];

            for (int i = 0; i < N; i++)
            {
                double x = func();
                Assert.GreaterOrEqual(x, 0.0);
                Assert.LessOrEqual(x, 1.0);
                int bucket = min((int)(x * num_buckets), num_buckets - 1);

                histogram[bucket]++;
            }

            double largest_delta = 0.0f;
            int accum = 0;
            for (int i = 0; i < histogram.Length; i++)
            {
                accum += histogram[i];
                double current = accum / (double)N;
                double target = (double)(i + 1) / histogram.Length;
                largest_delta = math.max(largest_delta, math.abs(current - target));
            }
            double d = 1.62762 / math.sqrt((double)N);   // significance: 0.01
            Assert.Less(largest_delta, d);
        }

        private void ks_test(Func<double2> func)
        {
            ks_test(() => func().x);
            ks_test(() => func().y);
        }

        // Pearson's product-moment coefficient
        private void r_test(Func<double2> func)
        {
            const int N = 4096;

            double2 sum = 0.0;
            var values = new double2[N]; 
            for(int i = 0; i < N; i++)
            {
                values[i] = func();
                sum += values[i];
            }

            double2 avg = sum / N;
            double var_a = 0.0;
            double var_b = 0.0;
            double cov = 0.0;
            for (int i = 0; i < N; i++)
            {
                double2 delta = values[i] - avg;
                var_a += delta.x * delta.x;
                var_b += delta.y * delta.y;
                cov += delta.x * delta.y;
            }

            double r = cov / sqrt(var_a * var_b);
            Assert.Less(abs(r), 0.05);
        }

        [Test]
        public void bool_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextBool() ? 0.75 : 0.25), 2);
        }

        [Test]
        public void bool2_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextBool2().x ? 0.75 : 0.25), 2);
            ks_test((() => rnd.NextBool2().y ? 0.75 : 0.25), 2);
        }

        [Test]
        public void bool2_independent()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool2().xy)));
        }
        
        [Test]
        public void bool3_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextBool3().x ? 0.75 : 0.25), 2);
            ks_test((() => rnd.NextBool3().y ? 0.75 : 0.25), 2);
            ks_test((() => rnd.NextBool3().z ? 0.75 : 0.25), 2);
        }

        [Test]
        public void bool3_independent()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool3().xy)));
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool3().xz)));
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool3().yz)));
        }

        [Test]
        public void bool4_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextBool4().x ? 0.75 : 0.25), 2);
            ks_test((() => rnd.NextBool4().y ? 0.75 : 0.25), 2);
            ks_test((() => rnd.NextBool4().z ? 0.75 : 0.25), 2);
            ks_test((() => rnd.NextBool4().w ? 0.75 : 0.25), 2);
        }

        [Test]
        public void bool4_independent()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool4().xy)));
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool4().xz)));
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool4().xw)));
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool4().yz)));
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool4().yw)));
            r_test((() => select(double2(0.25), double2(0.75), rnd.NextBool4().zw)));
        }

        [Test]
        public void int_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextInt() & 255u) + 0.5) / 256.0), 256);
        }

        [Test]
        public void int_uniform_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (((uint)rnd.NextInt() >> 24) + 0.5) / 256.0), 256);
        }

        [Test]
        public void int_uniform_max()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (rnd.NextInt(17) + 0.5) / 17.0), 17);
        }

        [Test]
        public void int2_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextInt2().x & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextInt2().y & 255u) + 0.5) / 256.0), 256);
        }

        [Test]
        public void int2_uniform_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (((uint)rnd.NextInt2().x >> 24) + 0.5) / 256.0), 256);
            ks_test((() => (((uint)rnd.NextInt2().y >> 24) + 0.5) / 256.0), 256);
        }

        [Test]
        public void int2_uniform_max()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (rnd.NextInt2(int2(13, 17)).x + 0.5) / 13.0), 13);
            ks_test((() => (rnd.NextInt2(int2(13, 17)).y + 0.5) / 17.0), 17);
        }

        [Test]
        public void int2_independent_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => (rnd.NextInt2().xy & 255));
        }

        [Test]
        public void int2_independent_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => ((uint2)rnd.NextInt2().xy >> 24));
        }

        [Test]
        public void int3_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextInt3().x & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextInt3().y & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextInt3().z & 255u) + 0.5) / 256.0), 256);
        }

        [Test]
        public void int3_uniform_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (((uint)rnd.NextInt3().x >> 24) + 0.5) / 256.0), 256);
            ks_test((() => (((uint)rnd.NextInt3().y >> 24) + 0.5) / 256.0), 256);
            ks_test((() => (((uint)rnd.NextInt3().z >> 24) + 0.5) / 256.0), 256);
        }

        [Test]
        public void int3_uniform_max()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((uint)rnd.NextInt3(int3(13, 17, 19)).x + 0.5) / 13.0), 13);
            ks_test((() => ((uint)rnd.NextInt3(int3(13, 17, 19)).y + 0.5) / 17.0), 17);
            ks_test((() => ((uint)rnd.NextInt3(int3(13, 17, 19)).z + 0.5) / 19.0), 19);
        }

        [Test]
        public void int3_independent_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => (rnd.NextInt3().xy & 255));
            r_test(() => (rnd.NextInt3().xz & 255));
            r_test(() => (rnd.NextInt3().yz & 255));
        }

        [Test]
        public void int3_independent_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => ((uint2)rnd.NextInt3().xy >> 24));
            r_test(() => ((uint2)rnd.NextInt3().xz >> 24));
            r_test(() => ((uint2)rnd.NextInt3().yz >> 24));
        }

        [Test]
        public void int4_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextInt4().x & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextInt4().y & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextInt4().z & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextInt4().w & 255u) + 0.5) / 256.0), 256);
        }

        [Test]
        public void int4_uniform_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (((uint)rnd.NextInt4().x >> 24) + 0.5) / 256.0), 256);
            ks_test((() => (((uint)rnd.NextInt4().y >> 24) + 0.5) / 256.0), 256);
            ks_test((() => (((uint)rnd.NextInt4().z >> 24) + 0.5) / 256.0), 256);
            ks_test((() => (((uint)rnd.NextInt4().w >> 24) + 0.5) / 256.0), 256);
        }

        [Test]
        public void int4_uniform_max()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (rnd.NextInt4(int4(13, 17, 19, 23)).x + 0.5) / 13.0), 13);
            ks_test((() => (rnd.NextInt4(int4(13, 17, 19, 23)).y + 0.5) / 17.0), 17);
            ks_test((() => (rnd.NextInt4(int4(13, 17, 19, 23)).z + 0.5) / 19.0), 19);
            ks_test((() => (rnd.NextInt4(int4(13, 17, 19, 23)).w + 0.5) / 23.0), 23);
        }

        [Test]
        public void int4_independent_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => (rnd.NextUInt4().xy & 255));
            r_test(() => (rnd.NextUInt4().xz & 255));
            r_test(() => (rnd.NextUInt4().xw & 255));
            r_test(() => (rnd.NextUInt4().yz & 255));
            r_test(() => (rnd.NextUInt4().yw & 255));
            r_test(() => (rnd.NextUInt4().zw & 255));
        }

        [Test]
        public void int4_independent_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => ((uint2)rnd.NextUInt4().xy >> 24));
            r_test(() => ((uint2)rnd.NextUInt4().xz >> 24));
            r_test(() => ((uint2)rnd.NextUInt4().xw >> 24));
            r_test(() => ((uint2)rnd.NextUInt4().yz >> 24));
            r_test(() => ((uint2)rnd.NextUInt4().yw >> 24));
            r_test(() => ((uint2)rnd.NextUInt4().zw >> 24));
        }


        [Test]
        public void uint_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextUInt() & 255u) + 0.5) / 256.0), 256);
        }

        [Test]
        public void uint_uniform_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextUInt() >> 24) + 0.5) / 256.0), 256);
        }

        [Test]
        public void uint_uniform_max()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (rnd.NextUInt(17) + 0.5) / 17.0), 17);
        }

        [Test]
        public void uint2_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextUInt2().x & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt2().y & 255u) + 0.5) / 256.0), 256);
        }

        [Test]
        public void uint2_uniform_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextUInt2().x >> 24) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt2().y >> 24) + 0.5) / 256.0), 256);
        }

        [Test]
        public void uint2_uniform_max()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (rnd.NextUInt2(uint2(13,17)).x + 0.5) / 13.0), 13);
            ks_test((() => (rnd.NextUInt2(uint2(13,17)).y + 0.5) / 17.0), 17);
        }

        [Test]
        public void uint2_independent_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => (rnd.NextUInt2().xy & 255));
        }

        [Test]
        public void uint2_independent_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => (rnd.NextUInt2().xy >> 24));
        }

        [Test]
        public void uint3_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextUInt3().x & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt3().y & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt3().z & 255u) + 0.5) / 256.0), 256);
        }

        [Test]
        public void uint3_uniform_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextUInt3().x >> 24) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt3().y >> 24) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt3().z >> 24) + 0.5) / 256.0), 256);
        }

        [Test]
        public void uint3_uniform_max()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (rnd.NextUInt3(uint3(13, 17, 19)).x + 0.5) / 13.0), 13);
            ks_test((() => (rnd.NextUInt3(uint3(13, 17, 19)).y + 0.5) / 17.0), 17);
            ks_test((() => (rnd.NextUInt3(uint3(13, 17, 19)).z + 0.5) / 19.0), 19);
        }

        [Test]
        public void uint3_independent_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => (rnd.NextUInt3().xy & 255));
            r_test(() => (rnd.NextUInt3().xz & 255));
            r_test(() => (rnd.NextUInt3().yz & 255));
        }

        [Test]
        public void uint3_independent_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => (rnd.NextUInt3().xy >> 24));
            r_test(() => (rnd.NextUInt3().xz >> 24));
            r_test(() => (rnd.NextUInt3().yz >> 24));
        }

        [Test]
        public void uint4_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextUInt4().x & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt4().y & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt4().z & 255u) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt4().w & 255u) + 0.5) / 256.0), 256);
        }

        [Test]
        public void uint4_uniform_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => ((rnd.NextUInt4().x >> 24) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt4().y >> 24) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt4().z >> 24) + 0.5) / 256.0), 256);
            ks_test((() => ((rnd.NextUInt4().w >> 24) + 0.5) / 256.0), 256);
        }

        [Test]
        public void uint4_uniform_max()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => (rnd.NextUInt4(uint4(13, 17, 19, 23)).x + 0.5) / 13.0), 13);
            ks_test((() => (rnd.NextUInt4(uint4(13, 17, 19, 23)).y + 0.5) / 17.0), 17);
            ks_test((() => (rnd.NextUInt4(uint4(13, 17, 19, 23)).z + 0.5) / 19.0), 19);
            ks_test((() => (rnd.NextUInt4(uint4(13, 17, 19, 23)).w + 0.5) / 23.0), 23);
        }

        [Test]
        public void uint4_independent_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => (rnd.NextUInt4().xy & 255));
            r_test(() => (rnd.NextUInt4().xz & 255));
            r_test(() => (rnd.NextUInt4().xw & 255));
            r_test(() => (rnd.NextUInt4().yz & 255));
            r_test(() => (rnd.NextUInt4().yw & 255));
            r_test(() => (rnd.NextUInt4().zw & 255));
        }

        [Test]
        public void uint4_independent_high_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test(() => (rnd.NextUInt4().xy >> 24));
            r_test(() => (rnd.NextUInt4().xz >> 24));
            r_test(() => (rnd.NextUInt4().xw >> 24));
            r_test(() => (rnd.NextUInt4().yz >> 24));
            r_test(() => (rnd.NextUInt4().yw >> 24));
            r_test(() => (rnd.NextUInt4().zw >> 24));
        }

        [Test]
        public void float_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextFloat()));
        }

        [Test]
        public void float_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => frac(rnd.NextFloat() * 65536.0f)));
        }

        [Test]
        public void float2_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextFloat2().x));
            ks_test((() => rnd.NextFloat2().y));
        }

        [Test]
        public void float2_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => frac(rnd.NextFloat2().x * 65536.0f)));
            ks_test((() => frac(rnd.NextFloat2().y * 65536.0f)));
        }

        [Test]
        public void float2_independent()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test((() => rnd.NextFloat2()));
        }

        [Test]
        public void float3_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextFloat3().x));
            ks_test((() => rnd.NextFloat3().y));
            ks_test((() => rnd.NextFloat3().z));
        }

        [Test]
        public void float3_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => frac(rnd.NextFloat3().x * 65536.0f)));
            ks_test((() => frac(rnd.NextFloat3().y * 65536.0f)));
            ks_test((() => frac(rnd.NextFloat3().z * 65536.0f)));
        }

        [Test]
        public void float3_independent()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test((() => rnd.NextFloat3().xy));
            r_test((() => rnd.NextFloat3().xz));
            r_test((() => rnd.NextFloat3().yz));
        }

        [Test]
        public void float4_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextFloat4().x));
            ks_test((() => rnd.NextFloat4().y));
            ks_test((() => rnd.NextFloat4().z));
            ks_test((() => rnd.NextFloat4().w));
        }

        [Test]
        public void float4_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => frac(rnd.NextFloat4().x * 65536.0f)));
            ks_test((() => frac(rnd.NextFloat4().y * 65536.0f)));
            ks_test((() => frac(rnd.NextFloat4().z * 65536.0f)));
            ks_test((() => frac(rnd.NextFloat4().w * 65536.0f)));
        }

        [Test]
        public void float4_independent()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test((() => rnd.NextFloat4().xy));
            r_test((() => rnd.NextFloat4().xz));
            r_test((() => rnd.NextFloat4().xw));
            r_test((() => rnd.NextFloat4().yz));
            r_test((() => rnd.NextFloat4().yw));
            r_test((() => rnd.NextFloat4().zw));
        }

        [Test]
        public void double_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextDouble()));
        }

        [Test]
        public void double_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => frac(rnd.NextDouble() * 35184372088832.0)));
        }

        [Test]
        public void double2_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextDouble2().x));
            ks_test((() => rnd.NextDouble2().y));
        }

        [Test]
        public void double2_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => frac(rnd.NextDouble2().x * 35184372088832.0)));
            ks_test((() => frac(rnd.NextDouble2().y * 35184372088832.0)));
        }

        [Test]
        public void double2_independent()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test((() => rnd.NextDouble2()));
        }

        [Test]
        public void double3_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextDouble3().x));
            ks_test((() => rnd.NextDouble3().y));
            ks_test((() => rnd.NextDouble3().z));
        }

        [Test]
        public void double3_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => frac(rnd.NextDouble3().x * 35184372088832.0)));
            ks_test((() => frac(rnd.NextDouble3().y * 35184372088832.0)));
            ks_test((() => frac(rnd.NextDouble3().z * 35184372088832.0)));
        }

        [Test]
        public void double3_independent()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test((() => rnd.NextDouble3().xy));
            r_test((() => rnd.NextDouble3().xz));
            r_test((() => rnd.NextDouble3().yz));
        }

        [Test]
        public void double4_uniform()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => rnd.NextDouble4().x));
            ks_test((() => rnd.NextDouble4().y));
            ks_test((() => rnd.NextDouble4().z));
            ks_test((() => rnd.NextDouble4().w));
        }

        [Test]
        public void double4_uniform_low_bits()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test((() => frac(rnd.NextDouble4().x * 35184372088832.0)));
            ks_test((() => frac(rnd.NextDouble4().y * 35184372088832.0)));
            ks_test((() => frac(rnd.NextDouble4().z * 35184372088832.0)));
            ks_test((() => frac(rnd.NextDouble4().w * 35184372088832.0)));
        }

        [Test]
        public void double4_independent()
        {
            var rnd = new Random(0x6E624EB7u);
            r_test((() => rnd.NextDouble4().xy));
            r_test((() => rnd.NextDouble4().xz));
            r_test((() => rnd.NextDouble4().xw));
            r_test((() => rnd.NextDouble4().yz));
            r_test((() => rnd.NextDouble4().yw));
            r_test((() => rnd.NextDouble4().zw));
        }

        [Test]
        public void float2_direction()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test(() => {
                float2 dir = rnd.NextFloat2Direction();
                Assert.AreEqual(1.0f, length(dir), 0.001f);
                return atan2(dir.x, dir.y)/(2.0f*(float)PI) + 0.5f;
            });
        }

        [Test]
        public void double2_direction()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test(() => {
                double2 dir = rnd.NextFloat2Direction();
                Assert.AreEqual(1.0, length(dir), 0.000001);
                return atan2(dir.y, dir.x) / (2.0 * PI) + 0.5;
            });
        }


        [Test]
        public void float3_direction()
        {
            var rnd = new Random(0x6E624EB7u);
            ks_test(() =>
            {
                float3 dir = rnd.NextFloat3Direction();
                float r = length(dir);
                Assert.AreEqual(1.0f, r, 0.001f);

                float phi = atan2(dir.y, dir.x) / (2.0f * (float)PI) + 0.5f;
                float z = saturate(dir.z / r * 0.5f + 0.5f);
                return double2(phi, z);
            });
        }
    }
}
