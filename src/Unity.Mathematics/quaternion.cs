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

        // todo:static member or static func
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

        public static quaternion mul(quaternion q1, quaternion q2)
        {
            var v1 = q1.value;
            var v2 = q2.value;
            
            return conj(new quaternion((v1.ywzx * v2.xwyz - v1.wxyz * v2.zxzx - v1.zzww * v2.wzxy - v1.xyxy * v2.yyww).zwxy));
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

        // todo: push on vectorized form amap?
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
        
        public static quaternion axisAngle(float3 axis, float angle)
        {
            float3 axisUnit  = math.normalize(axis);
            float sina = math.sin(0.5f * angle);
            float cosa = math.cos(0.5f * angle);
            return new quaternion { value = new float4( axisUnit.x * sina, axisUnit.y * sina, axisUnit.z * sina, cosa ) };
        }

        //@TODO: Seperated x, y, z
        public static quaternion euler(float3 eulerInDegrees)
        {
            throw new System.NotImplementedException();
        }

        //@TODO: Decide on saturate for t (old math lib did it...)

        public static quaternion slerp(quaternion lhs, quaternion rhs, float t)
        {
            throw new System.NotImplementedException();
        }

        public static quaternion lerp(quaternion lhs, quaternion rhs, float t)
        {
            throw new System.NotImplementedException();
            // var res = math.normalize(lhs.value + t * (math.chgsign(rhs.value, math.dot(lhs.value, rhs.value)) - rhs.value));
            // return new quaternion(res);
        }

        public static float3 forward(quaternion q)
        {
            return mul(q, new float3(0, 0, 1));
        }
        
        public static float3 up(quaternion q)
        {
            return mul(q, new float3(0, 1, 0));
        }

        public static quaternion lookRotationToQuaternion(float3 direction, float3 up)
        {
            var vector = math_experimental.normalizeSafe(direction);
            var vector2 = cross(up, vector);
            var vector3 = cross(vector,vector2);
            var m00 = vector2.x;
            var m01 = vector2.y;
            var m02 = vector2.z;
            var m10 = vector3.x;
            var m11 = vector3.y;
            var m12 = vector3.z;
            var m20 = vector.x;
            var m21 = vector.y;
            var m22 = vector.z;
            var num8 = (m00 + m11) + m22;
            float4 q;
            if (num8 > 0.0)
            {
                var num = sqrt(num8 + 1.0f);
                q.w = num * 0.5f;
                num = 0.5f / num;
                q.x = (m12 - m21) * num;
                q.y = (m20 - m02) * num;
                q.z = (m01 - m10) * num;
                return new quaternion(q);
            }
            if ((m00 >= m11) && (m00 >= m22))
            {
                var num7 = sqrt(((1.0f + m00) - m11) - m22);
                var num4 = 0.5f / num7;
                q.x = 0.5f * num7;
                q.y = (m01 + m10) * num4;
                q.z = (m02 + m20) * num4;
                q.w = (m12 - m21) * num4;
                return new quaternion(q);
            }
            if (m11 > m22)
            {
                var num6 = sqrt(((1.0f + m11) - m00) - m22);
                var num3 = 0.5f / num6;
                q.x = (m10 + m01) * num3;
                q.y = 0.5f * num6;
                q.z = (m21 + m12) * num3;
                q.w = (m20 - m02) * num3;
                return new quaternion(q);
            }
            var num5 = sqrt(((1.0f + m22) - m00) - m11);
            var num2 = 0.5f / num5;
            q.x = (m20 + m02) * num2;
            q.y = (m21 + m12) * num2;
            q.z = 0.5f * num5;
            q.w = (m01 - m10) * num2;
            return new quaternion(q);
        }
        
        public static float4x4 rottrans(quaternion q, float3 t)
        {
            var m3x3 = quatToMatrix(q);
            var m = new float4x4
            {
                m0 = new float4(m3x3.m0, 0.0f),
                m1 = new float4(m3x3.m1, 0.0f),
                m2 = new float4(m3x3.m2, 0.0f),
                m3 = new float4(t, 1.0f)
            };
            return m;
        }
    }
}
