using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    [Serializable]
    public partial struct float3x3
    {
        public float3 m0;
        public float3 m1;
        public float3 m2;

        public float3x3(float m00, float m01, float m02,
            float m10, float m11, float m12,
            float m20, float m21, float m22)
        {
            this.m0 = new float3(m00, m01, m02);
            this.m1 = new float3(m10, m11, m12);
            this.m2 = new float3(m20, m21, m22);
        }
        
        public float3x3(float3 m0, float3 m1, float3 m2)
        {
            this.m0 = m0;
            this.m1 = m1;
            this.m2 = m2;
        }
       
        public static readonly float3x3 zero = new float3x3(new float3(0.0f, 0.0f, 0.0f), new float3(0.0f, 0.0f, 0.0f), new float3(0.0f, 0.0f, 0.0f));
        public static readonly float3x3 identity = new float3x3(new float3(1.0f, 0.0f, 0.0f), new float3(0.0f, 1.0f, 0.0f), new float3(0.0f, 0.0f, 1.0f));
    }

    public static partial class math
    {
        public static float det(float3x3 x)
        {
            return dot(cross(x.m0, x.m1), x.m2);
        }
        
        public static float3 mul(float3x3 x, float3 v)
        {
            return mad(x.m2, v.z, mad(x.m0, v.x, x.m1 * v.y));
        }

        public static float3x3 mul(float3x3 x0, float3x3 x1)
        {
            return new float3x3(mul(x0, x1.m0), mul(x0, x1.m1), mul(x0, x1.m2));
        }
        
        // mul 3x3 with scalar
        public static float3x3 mulScale(float3x3 x, float s)
        {
            return new float3x3(x.m0 * s, x.m1 * s, x.m2 * s);
        }
        
        // post mul 3x3 with scale vector
        public static float3x3 mulScale(float3x3 x, float3 s)
        {
            return new float3x3(x.m0 * s.x, x.m1 * s.y, x.m2 * s.z);
        }

        // pre mul 3x3 with scale vector
        public static float3x3 scaleMul(float3 s, float3x3 x)
        {
            return new float3x3(x.m0 * s, x.m1 * s, x.m2 * s);
        }
        
        public static float3x3 transpose(float3x3 x)
        {
            return new float3x3(
                new float3(x.m0.x, x.m1.x, x.m2.x), 
                new float3(x.m0.y, x.m1.y, x.m2.y),
                new float3(x.m0.z, x.m1.z, x.m2.z));
        }
        
        public static float3x3 inverse(float3x3 x)
        {
            var scaleSquared = uniformScaleSquared(x);
            if (scaleSquared < epsilon_normal_square)
                return float3x3.zero;
            var scaleInv = rsqrt(new float3(scaleSquared));
            var xs = mulScale(x, scaleInv);
            if (!adjInverse(xs, out var i, epsilon_determinant))
            {
                i = svdInverse(xs);
            }
            i = mulScale(i, scaleInv);
            return i;
        }
       
        public static float3x3 quatToMatrix(quaternion q)
        {
            q = math.normalize(q);

            var qv = q.value;
            
            var yxw = qv.yxw;
            var zwx = qv.zwx;
            var wzy = qv.wzy;

            var m = new float3x3
            {  
                m0 = new float3(-2, +2, -2) * qv.y * yxw + new float3(-2, +2, +2) * qv.z * zwx + new float3(1, 0, 0),
                m1 = new float3(-2, -2, +2) * qv.z * wzy + new float3(+2, -2, +2) * qv.x * yxw + new float3(0, 1, 0),
                m2 = new float3(+2, -2, -2) * qv.x * zwx + new float3(+2, +2, -2) * qv.y * wzy + new float3(0, 0, 1)
            };
            
            return m;
        }

        // get unit quaternion from rotation matrix
        // u, v, w must be ortho-normal.
        public static quaternion matrixToQuat(float3 u, float3 v, float3 w)
        {
            float4 q;
            if (u.x >= 0f)
            {
                float t = v.y + w.z;
                if (t >= 0f)
                    q = new float4(v.z - w.y, w.x - u.z, u.y - v.x, 1f + u.x + t);
                else
                    q = new float4(1f + u.x - t, u.y + v.x, w.x + u.z, v.z - w.y);
            }
            else
            {
                float t = v.y - w.z;
                if (t >= 0f)
                    q = new float4(u.y + v.x, 1f - u.x + t, v.z + w.y, w.x - u.z);
                else
                    q = new float4(w.x + u.z, v.z + w.y, 1f - u.x - t, u.y - v.x);
            }
            return normalize(new quaternion(q));
        }
        
        public static quaternion matrixToQuat(float3x3 x)
        {
            return matrixToQuat(x.m0, x.m1, x.m2);
        }

        public static float3x3 lookAtRotation(float3 forward, float3 up)
        {
            var left = cross(up, forward);
            var leftLen = length(left);
            return leftLen > epsilon_normal
                ? new float3x3(left * rcp(leftLen), normalize(cross(forward, left)), normalize(forward))
                : float3x3.identity;
        }
    }

    public static partial class math
    {
        private static float uniformScaleSquared(float3x3 x)
        {
            return 0.333333f * (dot(x.m0, x.m0) + dot(x.m1, x.m1) + dot(x.m2, x.m2));
        }
         
        // returns adjoint matrix
        private static float3x3 adj(float3x3 x, out float det)
        {
            float3x3 adjT;

            adjT.m0 = cross(x.m1, x.m2);
            adjT.m1 = cross(x.m2, x.m0);
            adjT.m2 = cross(x.m0, x.m1);

            det = dot(x.m0, adjT.m0);

            return transpose(adjT);
        }

        // inverts a non singular matrix. returns false if matrix is singular and i is set to adjoint
        // fastest inverse, when you know you deal with a non singular matrix
        private static bool adjInverse(float3x3 x, out float3x3 i, float epsilonDet)
        {
            i = adj(x, out var det);
            var c = abs(det) > epsilonDet;
            var detInv = select(new float3(rcp(det)), new float3(1.0f), c);
            i = scaleMul(detInv, i);
            return c;
        }
    }
}
