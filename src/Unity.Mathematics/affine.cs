using System;

namespace Unity.Mathematics
{
    // https://en.wikipedia.org/wiki/Affine_transformation
    [Serializable]
    public partial struct affine
    {
        public float3 t;
        public float3x3 rs;
 
        public affine(float3 t, float3x3 rs)
        {
            this.t = t;
            this.rs = rs;
        }

        public affine(float3 t, quaternion r, float3 s)
        {
            this.t = t;
            rs = math.mulScale(math.quatToMatrix(r),s);
        }
               
        public affine(rigid x)
        {
            t = x.position;
            rs = math.mulScale(math.quatToMatrix(x.rotation), new float3(x.scale));
        }
        
        public float4x4 float4x4 => new float4x4(new float4(rs.m0, 0), new float4(rs.m1, 0), new float4(rs.m2, 0), new float4(t, 1));    
        
        public static affine identity => new affine(new float3(0.0f), float3x3.identity);
    }

    public static partial class math
    {
        public static float3 mul(affine a, float3 t)
        {
            return a.t + mul(a.rs, t);
        }

        public static affine mul(affine a, affine b)
        {
            return new affine(mul(a, b.t), mul(a.rs, b.rs));
        }
        
        public static affine inverse(affine x)
        {
            affine i;
            i.rs = inverse(x.rs);
            i.t = mul(i.rs, -x.t);
            return i;
        }
    }
}
