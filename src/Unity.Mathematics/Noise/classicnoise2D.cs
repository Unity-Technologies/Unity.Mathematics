//
// GLSL textureless classic 2D noise "cnoise",
// with an RSL-style periodic variant "pnoise".
// Author:  Stefan Gustavson (stefan.gustavson@liu.se)
// Version: 2011-08-22
//
// Many thanks to Ian McEwan of Ashima Arts for the
// ideas for permutation and gradient selection.
//
// Copyright (c) 2011 Stefan Gustavson. All rights reserved.
// Distributed under the MIT license. See LICENSE file.
// https://github.com/stegu/webgl-noise
//

namespace Unity.Mathematics
{
    public static partial class noise
    {
        // Classic Perlin noise
        public static float cnoise(float2 P)
        {
            float4 Pi = math.floor(P.xyxy) + new float4(0.0f, 0.0f, 1.0f, 1.0f);
            float4 Pf = math.fract(P.xyxy) - new float4(0.0f, 0.0f, 1.0f, 1.0f);
            Pi = mod289(Pi); // To avoid truncation effects in permutation
            float4 ix = Pi.xzxz;
            float4 iy = Pi.yyww;
            float4 fx = Pf.xzxz;
            float4 fy = Pf.yyww;

            float4 i = permute(permute(ix) + iy);

            float4 gx = math.fract(i * (1.0f / 41.0f)) * 2.0f - 1.0f;
            float4 gy = math.abs(gx) - 0.5f;
            float4 tx = math.floor(gx + 0.5f);
            gx = gx - tx;

            float2 g00 = new float2(gx.x, gy.x);
            float2 g10 = new float2(gx.y, gy.y);
            float2 g01 = new float2(gx.z, gy.z);
            float2 g11 = new float2(gx.w, gy.w);

            float4 norm = taylorInvSqrt(new float4(math.dot(g00, g00), math.dot(g01, g01), math.dot(g10, g10), math.dot(g11, g11)));
            g00 *= norm.x;
            g01 *= norm.y;
            g10 *= norm.z;
            g11 *= norm.w;

            float n00 = math.dot(g00, new float2(fx.x, fy.x));
            float n10 = math.dot(g10, new float2(fx.y, fy.y));
            float n01 = math.dot(g01, new float2(fx.z, fy.z));
            float n11 = math.dot(g11, new float2(fx.w, fy.w));

            float2 fade_xy = fade(Pf.xy);
            float2 n_x = math.mix(new float2(n00, n01), new float2(n10, n11), fade_xy.x);
            float n_xy = math.mix(n_x.x, n_x.y, fade_xy.y);
            return 2.3f * n_xy;
        }

        // Classic Perlin noise, periodic variant
        public static float pnoise(float2 P, float2 rep)
        {
            float4 Pi = math.floor(P.xyxy) + new float4(0.0f, 0.0f, 1.0f, 1.0f);
            float4 Pf = math.fract(P.xyxy) - new float4(0.0f, 0.0f, 1.0f, 1.0f);
            Pi = math.mod(Pi, rep.xyxy); // To create noise with explicit period
            Pi = mod289(Pi); // To avoid truncation effects in permutation
            float4 ix = Pi.xzxz;
            float4 iy = Pi.yyww;
            float4 fx = Pf.xzxz;
            float4 fy = Pf.yyww;

            float4 i = permute(permute(ix) + iy);

            float4 gx = math.fract(i * (1.0f / 41.0f)) * 2.0f - 1.0f;
            float4 gy = math.abs(gx) - 0.5f;
            float4 tx = math.floor(gx + 0.5f);
            gx = gx - tx;

            float2 g00 = new float2(gx.x, gy.x);
            float2 g10 = new float2(gx.y, gy.y);
            float2 g01 = new float2(gx.z, gy.z);
            float2 g11 = new float2(gx.w, gy.w);

            float4 norm = taylorInvSqrt(new float4(math.dot(g00, g00), math.dot(g01, g01), math.dot(g10, g10), math.dot(g11, g11)));
            g00 *= norm.x;
            g01 *= norm.y;
            g10 *= norm.z;
            g11 *= norm.w;

            float n00 = math.dot(g00, new float2(fx.x, fy.x));
            float n10 = math.dot(g10, new float2(fx.y, fy.y));
            float n01 = math.dot(g01, new float2(fx.z, fy.z));
            float n11 = math.dot(g11, new float2(fx.w, fy.w));

            float2 fade_xy = fade(Pf.xy);
            float2 n_x = math.mix(new float2(n00, n01), new float2(n10, n11), fade_xy.x);
            float n_xy = math.mix(n_x.x, n_x.y, fade_xy.y);
            return 2.3f * n_xy;
        }
    }
}
