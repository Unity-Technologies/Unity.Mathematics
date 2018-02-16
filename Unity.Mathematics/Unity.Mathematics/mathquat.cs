// Needs lots of work before ready...
#if false

using System.Runtime.CompilerServices;

namespace Unity.Mathematics.Experimental
{
    public partial struct quaternion
    {
        public float4 value;

        public quaternion(float x, float y, float z, float w) { value.x = x; value.y = y; value.z = z; value.w = w; }
        public quaternion(float4 value)                       { this.value = value; }

        public static quaternion identity { get { return new quaternion(0.0F, 0.0F, 0.0F, 1.0F); } }

        public static quaternion axisAngle(float3 axis, float angle)
        {
            throw new System.NotImplementedException();
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
            var res = math.normalize(lhs.value + t * (math.chgsign(rhs.value, math.dot(lhs.value, rhs.value)) - rhs.value));
            return new quaternion(res);
        }
    }

    public static partial class math_experimental
    {
        public static quaternion normalize(quaternion q)
        {
            float4 value = q.value;
            float len = math.dot(value, value);

            // note we use float4 comparison here because this gives us -1 / 0 which is necessary for select.
            //return select(quatIdentity(), q*rsqrt(len), len > float4(epsilon_normal()));
            value = math.select(quaternion.identity.value, value * math.rsqrt(len), len > math.epsilon_normal);

            return new quaternion(value);
        }

        public static quaternion mul(quaternion lhs, quaternion rhs)
        {
            return new quaternion(
                lhs.value.w* rhs.value.x + lhs.value.x* rhs.value.w + lhs.value.y* rhs.value.z - lhs.value.z* rhs.value.y,
                lhs.value.w* rhs.value.y + lhs.value.y* rhs.value.w + lhs.value.z* rhs.value.x - lhs.value.x* rhs.value.z,
                lhs.value.w* rhs.value.z + lhs.value.z* rhs.value.w + lhs.value.x* rhs.value.y - lhs.value.y* rhs.value.x,
                lhs.value.w* rhs.value.w - lhs.value.x* rhs.value.x - lhs.value.y* rhs.value.y - lhs.value.z* rhs.value.z);
        }

        public static float3 mul(quaternion rotation, float3 position)
        {
            float x = rotation.value.x * 2F;
            float y = rotation.value.y * 2F;
            float z = rotation.value.z * 2F;
            float xx = rotation.value.x * x;
            float yy = rotation.value.y * y;
            float zz = rotation.value.z * z;
            float xy = rotation.value.x * y;
            float xz = rotation.value.x * z;
            float yz = rotation.value.y * z;
            float wx = rotation.value.w * x;
            float wy = rotation.value.w * y;
            float wz = rotation.value.w * z;

            float3 res;
            res.x = (1F - (yy + zz)) * position.x + (xy - wz) * position.y + (xz + wy) * position.z;
            res.y = (xy + wz) * position.x + (1F - (xx + zz)) * position.y + (yz - wx) * position.z;
            res.z = (xz - wy) * position.x + (yz + wx) * position.y + (1F - (xx + yy)) * position.z;
            return res;
        }

        // get unit quaternion from rotation matrix
        // u, v, w must be ortho-normal.
        static quaternion matrixToQuat(float3 u, float3 v, float3 w)
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
    }

}

#endif