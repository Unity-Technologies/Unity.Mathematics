using System;
using Unity.Mathematics.Experimental;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    [Serializable]
    public partial struct Quaternion
    {
        public float4 value;

        public Quaternion(float x, float y, float z, float w) { value.x = x; value.y = y; value.z = z; value.w = w; }
        public Quaternion(float4 value)                       { this.value = value; }


        // Construct unit quaternion from rotation matrix. The matrix must be orthonormal.
        public Quaternion(float3x3 m)
        {
            float3 u = m.c0;
            float3 v = m.c1;
            float3 w = m.c2;

            if (u.x >= 0f)
            {
                float t = v.y + w.z;
                if (t >= 0f)
                    value = float4(v.z - w.y, w.x - u.z, u.y - v.x, 1f + u.x + t);
                else
                    value = float4(1f + u.x - t, u.y + v.x, w.x + u.z, v.z - w.y);
            }
            else
            {
                float t = v.y - w.z;
                if (t >= 0f)
                    value = float4(u.y + v.x, 1f - u.x + t, v.z + w.y, w.x - u.z);
                else
                    value = float4(w.x + u.z, v.z + w.y, 1f - u.x - t, u.y - v.x);
            }
            value = normalize(value);
        }

        // Construct unit quaternion from rigid-transformation matrix. The matrix must be orthonormal.
        public Quaternion(float4x4 m)
        {
            float4 u = m.c0;
            float4 v = m.c1;
            float4 w = m.c2;

            if (u.x >= 0f)
            {
                float t = v.y + w.z;
                if (t >= 0f)
                    value = float4(v.z - w.y, w.x - u.z, u.y - v.x, 1f + u.x + t);
                else
                    value = float4(1f + u.x - t, u.y + v.x, w.x + u.z, v.z - w.y);
            }
            else
            {
                float t = v.y - w.z;
                if (t >= 0f)
                    value = float4(u.y + v.x, 1f - u.x + t, v.z + w.y, w.x - u.z);
                else
                    value = float4(w.x + u.z, v.z + w.y, 1f - u.x - t, u.y - v.x);
            }
            value = normalize(value);
        }

        public static readonly Quaternion identity = new Quaternion(0.0f, 0.0f, 0.0f, 1.0f);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion axisAngle(float3 axis, float angle)
        {
            float sina, cosa;
            math.sincos(0.5f * angle, out sina, out cosa);
            return Quaternion(float4(math.normalize(axis) * sina, cosa));
        }

        public static Quaternion eulerXYZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return Quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(-1.0f, 1.0f, -1.0f, 1.0f)
                );
        }

        public static Quaternion eulerXZY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return Quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(1.0f, 1.0f, -1.0f, -1.0f)
                );
        }
        public static Quaternion eulerYXZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return Quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(-1.0f, 1.0f, 1.0f, -1.0f)
                );
        }
        public static Quaternion eulerYZX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return Quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(-1.0f, -1.0f, 1.0f, 1.0f)
                );
        }
        public static Quaternion eulerZXY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return Quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(1.0f, -1.0f, -1.0f, 1.0f)
                );
        }
        public static Quaternion eulerZYX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return Quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.x * s.z
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(1.0f, -1.0f, 1.0f, -1.0f)
                );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion eulerXYZ(float x, float y, float z) { return eulerXYZ(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion eulerXZY(float x, float y, float z) { return eulerXZY(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion eulerYXZ(float x, float y, float z) { return eulerYXZ(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion eulerYZX(float x, float y, float z) { return eulerYZX(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion eulerZXY(float x, float y, float z) { return eulerZXY(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion eulerZYX(float x, float y, float z) { return eulerZYX(float3(x, y, z)); }

        public static Quaternion euler(float3 xyz, RotationOrder order = RotationOrder.ZXY)
        {
            switch (order)
            {
                case RotationOrder.XYZ:
                    return eulerXYZ(xyz);
                case RotationOrder.XZY:
                    return eulerXZY(xyz);
                case RotationOrder.YXZ:
                    return eulerYXZ(xyz);
                case RotationOrder.YZX:
                    return eulerYZX(xyz);
                case RotationOrder.ZXY:
                    return eulerZXY(xyz);
                case RotationOrder.ZYX:
                    return eulerZYX(xyz);
                default:
                    return Quaternion.identity;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion euler(float x, float y, float z, RotationOrder order = RotationOrder.ZXY)
        {
            return euler(float3(x, y, z), order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion rotateX(float angle)
        {
            float sina, cosa;
            math.sincos(0.5f * angle, out sina, out cosa);
            return Quaternion(sina, 0.0f, 0.0f, cosa);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion rotateY(float angle)
        {
            float sina, cosa;
            math.sincos(0.5f * angle, out sina, out cosa);
            return Quaternion(0.0f, sina, 0.0f, cosa);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion rotateZ(float angle)
        {
            float sina, cosa;
            math.sincos(0.5f * angle, out sina, out cosa);
            return Quaternion(0.0f, 0.0f, sina, cosa);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion scale(float s)
        {
            return Quaternion(0.0f, 0.0f, 0.0f, sqrt(s)); 
        }
   
        public static Quaternion lookRotation(float3 direction, float3 up)
        {
            var vector = math_experimental.normalizeSafe(direction);
            var vector2 = cross(up, vector);
            var vector3 = cross(vector, vector2);
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
                return Quaternion(q);
            }
            if ((m00 >= m11) && (m00 >= m22))
            {
                var num7 = sqrt(((1.0f + m00) - m11) - m22);
                var num4 = 0.5f / num7;
                q.x = 0.5f * num7;
                q.y = (m01 + m10) * num4;
                q.z = (m02 + m20) * num4;
                q.w = (m12 - m21) * num4;
                return Quaternion(q);
            }
            if (m11 > m22)
            {
                var num6 = sqrt(((1.0f + m11) - m00) - m22);
                var num3 = 0.5f / num6;
                q.x = (m10 + m01) * num3;
                q.y = 0.5f * num6;
                q.z = (m21 + m12) * num3;
                q.w = (m20 - m02) * num3;
                return Quaternion(q);
            }
            var num5 = sqrt(((1.0f + m22) - m00) - m11);
            var num2 = 0.5f / num5;
            q.x = (m20 + m02) * num2;
            q.y = (m21 + m12) * num2;
            q.z = 0.5f * num5;
            q.w = (m01 - m10) * num2;
            return Quaternion(q);
        }
    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(float x, float y, float z, float w) { return new Quaternion(x, y, z, w); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(float4 value) { return new Quaternion(value); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(float3x3 m) { return new Quaternion(m); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(float4x4 m) { return new Quaternion(m); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion conjugate(Quaternion q)
        {
            return Quaternion(q.value * float4(-1.0f, -1.0f, -1.0f, 1.0f)); // TODO: should only be one xorps
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion inverse(Quaternion q)
        {
            return conjugate(normalize(q));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(Quaternion a, Quaternion b)
        {
            return dot(a.value, b.value);
        }

        public static Quaternion normalize(Quaternion q)
        {
            float4 value = q.value;
            float len = dot(value, value);
            value = math.select(Mathematics.Quaternion.identity.value, value * math.rsqrt(len), len > math.epsilon_normal);

            return Quaternion(value);
        }

        public static Quaternion mul(Quaternion a, Quaternion b)
        {
            return Quaternion(a.value.wwww * b.value + (a.value.xyzx * b.value.wwwx + a.value.yzxy * b.value.zxyy) * float4(1.0f, 1.0f, 1.0f, -1.0f) - a.value.zxyz * b.value.yzxz);
        }

        public static float3 mul(Quaternion q, float3 vector)
        {
            float3 t = 2 * cross(q.value.xyz, vector);
            return vector + q.value.w * t + cross(q.value.xyz, t);
        }

        public static Quaternion nlerp(Quaternion q1, Quaternion q2, float t)
        {
            float dt = dot(q1, q2);
            if(dt < 0.0f)
            {
                q2.value = -q2.value;
            }

            return normalize(Quaternion(lerp(q1.value, q2.value, t)));
        }

        public static Quaternion slerp(Quaternion q1, Quaternion q2, float t)
        {
            float dt = dot(q1, q2);
            if (dt < 0.0f)
            {
                dt = -dt;
                q2.value = -q2.value;
            }

            if (dt < 0.9995f)
            {
                float angle = acos(dt);
                float s = rsqrt(1.0f - dt * dt);    // 1.0f / sin(angle)
                float w1 = sin(angle * (1.0f - t)) * s;
                float w2 = sin(angle * t) * s;
                return Quaternion(q1.value * w1 + q2.value * w2);
            }
            else
            {
                // if the angle is small, use linear interpolation
                return nlerp(q1, q2, t);
            }
        }

        public static float3 forward(Quaternion q)
        {
            return mul(q, float3(0, 0, 1));
        }
        
        public static float3 up(Quaternion q)
        {
            return mul(q, float3(0, 1, 0));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(Quaternion q)
        {
            return hash(q.value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hash_wide(Quaternion q)
        {
            return hash_wide(q.value);
        }
    }
}
