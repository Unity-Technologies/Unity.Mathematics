using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using Unity.Mathematics.Experimental;

namespace Unity.Mathematics
{
    [Serializable]
    public partial struct quaternion
    {
        public float4 value;

        public quaternion(float x, float y, float z, float w) { value.x = x; value.y = y; value.z = z; value.w = w; }
        public quaternion(float4 value)                       { this.value = value; }

        public static readonly quaternion identity = new quaternion(0.0f, 0.0f, 0.0f, 1.0f);
    }

    public static partial class math
    {
        public static quaternion conj(quaternion q)
        {   
            var mask = new float4(-1.0f, -1.0f, -1.0f, 1.0f); 
     
            return new quaternion(chgsign(q.value, mask));
        }

        // align qa to point same direction than qb
        public static quaternion align(quaternion qa, quaternion qb)
        {
            return new quaternion(chgsign(qa.value, new float4(dot(qa.value, qb.value))));
        }
        
        public static quaternion normalize(quaternion q)
        {
            var value = q.value;
            var lenSquare = math.lengthSquared(value);
            value = math.select(quaternion.identity.value, value * math.rsqrt(lenSquare), lenSquare > math.epsilon_normal_square);

            return new quaternion(value);
        }

        public static float3 mul(quaternion q, float3 u)
        {
            var c0 = new float3(-2, +2, -2);
            var c1 = new float3(-2, -2, +2);
            var c2 = new float3(+2, -2, -2);

            var qv = q.value;

            var qyxw = qv.yxw;
            var qzwx = qv.zwx;
            var qwzy = qv.wzy;

            var m0 = (c0 * qv.y) * qyxw - (c2 * qv.z) * qzwx;
            var m1 = (c1 * qv.z) * qwzy - (c0 * qv.x) * qyxw;
            var m2 = (c2 * qv.x) * qzwx - (c1 * qv.y) * qwzy;

            return (u + u.x * m0) + (u.y * m1 + u.z * m2);
        }

        public static quaternion mul(quaternion q1, quaternion q2)
        {
            var v1 = q1.value;
            var v2 = q2.value;

            return conj(new quaternion((v1.ywzx * v2.xwyz - v1.wxyz * v2.zxzx - v1.zzww * v2.wzxy - v1.xyxy * v2.yyww)
                .zwxy));
        }

        public static quaternion axisAngle(float3 axis, float angle)
        {
            var axisUnit = math.normalize(axis);
            var sina = math.sin(0.5f * angle);
            var cosa = math.cos(0.5f * angle);
            return new quaternion { value = new float4( axisUnit.x * sina, axisUnit.y * sina, axisUnit.z * sina, cosa ) };
        }
        
        public static quaternion lerp(quaternion lhs, quaternion rhs, float t)
        {
            var p = lhs.value;
            var q = rhs.value;
            
            return normalize(new quaternion(p + t * (chgsign(q, dot(p, q)) - p)));
        }

        public static quaternion lookAtQuaternion(float3 forward, float3 up)
        {
            return matrixToQuat(lookAtRotation(forward, up));
        }
        
        //@TODO: Decide on saturate for t (old math lib did it...)
        public static quaternion slerp(quaternion lhs, quaternion rhs, float t)
        {
            throw new System.NotImplementedException();
        }
    }
}
