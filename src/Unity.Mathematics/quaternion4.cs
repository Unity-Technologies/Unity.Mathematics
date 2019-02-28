using Unity.Mathematics;

namespace Unity.Mathematics.SOA
{
    /// <summary>
    /// SIMD quaternion helper functions for working with 4-wide SOA quaternion data.
    /// </summary>
    public static class quaternion4
    {
        private static void flip_q2_sign(ref float4 dt, ref float4 qx, ref float4 qy, ref float4 qz, ref float4 qw)
        {
            uint4 sign_bits = math.asuint(dt) & 0x80000000;

            dt = math.asfloat(math.asuint(dt) ^ sign_bits);
            qx = math.asfloat(math.asuint(qx) ^ sign_bits);
            qy = math.asfloat(math.asuint(qy) ^ sign_bits);
            qz = math.asfloat(math.asuint(qz) ^ sign_bits);
            qw = math.asfloat(math.asuint(qw) ^ sign_bits);
        }

        public static void nlerp4(
            float4 q1x, float4 q1y, float4 q1z, float4 q1w,
            float4 q2x, float4 q2y, float4 q2z, float4 q2w,
            float4 t,
            out float4 oqx, out float4 oqy, out float4 oqz, out float4 oqw)
        {
            float4 dt = q1x * q2x + q1y * q2y + q1z * q2z + q1w * q2w;

            flip_q2_sign(ref dt, ref q2x, ref q2y, ref q2z, ref q2w);

            float4 x = math.lerp(q1x, q2x, t);
            float4 y = math.lerp(q1y, q2y, t);
            float4 z = math.lerp(q1z, q2z, t);
            float4 w = math.lerp(q1w, q2w, t);

            float4 lensq = x * x + y * y + z * z + w * w;
            float4 recip = math.rsqrt(lensq);

            oqx = x * recip;
            oqy = y * recip;
            oqz = z * recip;
            oqw = w * recip;
        }

        public static void slerp4(
            float4 q1x, float4 q1y, float4 q1z, float4 q1w,
            float4 q2x, float4 q2y, float4 q2z, float4 q2w, float4 t,
            out float4 oqx, out float4 oqy, out float4 oqz, out float4 oqw)
        {
            float4 dt = q1x * q2x + q1y * q2y + q1z * q2z + q1w * q2w;

            flip_q2_sign(ref dt, ref q2x, ref q2y, ref q2z, ref q2w);

            bool4 acos_mask = dt < 0.9995f;

            float4 a_qx = default(float4);
            float4 a_qy = default(float4);
            float4 a_qz = default(float4);
            float4 a_qw = default(float4);

            if (math.any(acos_mask))
            {
                float4 angles = math.acos(dt);
                float4 s = math.rsqrt(1.0f - dt * dt);    // 1.0f / sin(angle)
                float4 w1 = math.sin(angles * (1.0f - t)) * s;
                float4 w2 = math.sin(angles * t) * s;

                a_qx = q1x * w1 + q2x * w2;
                a_qy = q1y * w1 + q2y * w2;
                a_qz = q1z * w1 + q2z * w2;
                a_qw = q1w * w1 + q2w * w2;
            }

            // if the angle is small, use linear interpolation
            float4 b_qx, b_qy, b_qz, b_qw;
            nlerp4(
                q1x, q1y, q1z, q1w,
                q2x, q2y, q2z, q2w,
                t,
                out b_qx, out b_qy, out b_qz, out b_qw);

            oqx = math.select(b_qx, a_qx, acos_mask);
            oqy = math.select(b_qy, a_qy, acos_mask);
            oqz = math.select(b_qz, a_qz, acos_mask);
            oqw = math.select(b_qw, a_qw, acos_mask);
        }
    }
}