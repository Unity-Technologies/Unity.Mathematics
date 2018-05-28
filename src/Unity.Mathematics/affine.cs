using System;

namespace Unity.Mathematics
{
    // https://en.wikipedia.org/wiki/Affine_transformation
    [Serializable]
    public partial struct affine
    {
        // todo: should we use field offset 0,12 and try to match native 4x4?
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
               
        public affine(float4x4 x)
        {
            t = new float3(x.m3.x, x.m3.y, x.m3.z);
            rs.m0 = new float3(x.m0.x, x.m0.y, x.m0.z);
            rs.m1 = new float3(x.m1.x, x.m1.y, x.m1.z);
            rs.m2 = new float3(x.m2.x, x.m2.y, x.m2.z);
        }
      
        public float4x4 float4x4 => new float4x4(new float4(rs.m0, 0), new float4(rs.m1, 0), new float4(rs.m2, 0), new float4(t, 1));    
        
        public static affine identity => new affine(new float3(0.0f), float3x3.identity);
    }

    public static partial class math
    {
        // todo: agressive inline all around?
        public static float3 mul(affine a, float3 t)
        {
            return a.t + mul(a.rs, t);
        }

        public static affine mul(affine a, affine b)
        {
            return new affine(mul(a, b.t), mul(a.rs, b.rs));
        }
        
        static affine inverse(affine x)
        {
            affine i;
            i.rs = inverse(x.rs);
            i.t = mul(i.rs, -x.t);
            return i;
        }
    }
}
