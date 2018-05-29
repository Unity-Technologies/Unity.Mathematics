using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics.Experimental;

namespace Unity.Mathematics
{
    public partial struct float3x3
    {
        [Obsolete("operator * is deprecated, please use mulScale instead.")]
        public static float3x3 operator *(float3x3 mat, float s)
        {
            return new float3x3(mat.m0 * s, mat.m1 * s, mat.m2 * s);
        }
    }

    partial class math
    {      
        [Obsolete("identity3 is deprecated, please use float3x3.identity instead.")]
        public static float3x3 identity3 => new float3x3(new float3(1, 0, 0), new float3(0, 1, 0), new float3(0, 0, 1));

        // this is a relatively week orthogonalize as it ignores z
        // should use svdOrthogonalize
        public static float3x3 orthogonalize(float3x3 i)
        {
            float3x3 o;

            float3 u = i.m0;
            float3 v = i.m1 - i.m0 * math.dot(i.m1, i.m0);

            float lenU = math.length(u);
            float lenV = math.length(v);

            bool c = lenU > epsilon_normal && lenV > epsilon_normal;

            o.m0 = math.select(new float3(1, 0, 0), u / lenU, c);
            o.m1 = math.select(new float3(0, 1, 0), v / lenV, c);
            o.m2 = math.cross(o.m0, o.m1);

            return o;
        }

        [Obsolete("lookRotationToMatrix is deprecated, please use lookAtRotation instead.")]
        public static float3x3 lookRotationToMatrix(float3 forward, float3 up)
        {
            float3 z = forward;
            // compute u0
            float mag = math.length(z);
            if (mag < epsilon)
                return identity3;
            z /= mag;

            float3 x = math.cross(up, z);
            mag = math.length(x);
            if (mag < epsilon)
                return identity3;
            x /= mag;

            float3 y = math.cross(z, x);
            float yLength = math.length(y);
            if (yLength < 0.9F || yLength > 1.1F)
                return identity3;

            return new float3x3(x, y, z);
        }
     
        [Obsolete("lookRotationToQuaternion is deprecated, please use lookAtQuaternion instead.")]
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
