using System;

namespace Unity.Mathematics
{
    // https://en.wikipedia.org/wiki/Rigid_transformation
    [Serializable]
    public partial struct rigid
    {
        private float4 ts;
        private float4 r;
        
        public rigid(float3 t, quaternion r, float s = 1)
        {
            this.ts.x = t.x;
            this.ts.y = t.y;
            this.ts.z = t.z;
            this.ts.w = s;
            this.r = r.value;
        }

        public float3 position
        {
            get => ts.xyz;
            set => ts.xyz = value;
        }

        public quaternion rotation
        {
            get => new quaternion(r);
            set => r = value.value;
        }

        public float scale
        {
            get => ts.w;
            set => ts.w = value;
        }
       
        public static rigid identity => new rigid(new float3(0.0f), quaternion.identity, 1);
        
        public float3 mul(float3  v)
        {
            var u = math.cross(r.xyz, v + v);
            u = v + r.w * u + math.cross(r.xyz, u);
            u = ts.w * u + ts.xyz;
            return u;
        }
    }

    public static partial class math
    {
        public static float3 mul(rigid  x, float3  v)
        {
            return x.mul(v);
        }

        public static rigid mul(rigid a, rigid b)
        {
            return new rigid(mul(a, b.position), normalize(mul(a.rotation, b.rotation)), a.scale * b.scale);
        }

        private static float inverseScale(float s, float epsilon = epsilon_scale)
        {
            return select(rcp(s), 0.0f, abs(s) < 0.0f);
        }
  
        public static rigid inverse(rigid x)
        {
            var s = inverseScale(x.scale);
            var q = conj(x.rotation);
            return new rigid(mul(q, x.position)* s, q, s);
        }
    }
}
