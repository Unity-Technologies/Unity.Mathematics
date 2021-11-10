using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public partial struct float3
    {
        /// <summary>
        /// Returns the Euler angle representation of the quaternion following the XYZ rotation order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="q">The quaternion to convert to Euler angles.</param>
        /// <returns>The Euler angle representation of the quaternion in XYZ order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 EulerXYZ(quaternion q)
        {
            const float epsilon = 1e-6f;
            const float cutoff = (1f - 2f * epsilon) * (1f - 2f * epsilon);

            // prepare the data
            var qv = q.value;
            var d1 = qv * qv.wwww * float4(2f); //xw, yw, zw, ww
            var d2 = qv * qv.yzxw * float4(2f); //xy, yz, zx, ww
            var d3 = qv * qv;
            var euler = float3.zero;

            var y1 = d2.z - d1.y;
            if (y1 * y1 < cutoff)
            {
                var x1 = d2.y + d1.x;
                var x2 = d3.z + d3.w - d3.y - d3.x;
                var z1 = d2.x + d1.z;
                var z2 = d3.x + d3.w - d3.y - d3.z;
                euler = float3(atan2(x1, x2), -asin(y1), atan2(z1, z2));
            }
            else //xzx
            {
                y1 = clamp(y1, -1f, 1f);
                var abcd = float4(d2.z, d1.y, d2.x, d1.z);
                var x1 = 2f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                var x2 = csum(abcd * abcd * float4(-1f, 1f, -1f, 1f));
                euler = float3(atan2(x1, x2), -asin(y1), 0f);
            }

            return euler;
        }

        /// <summary>
        /// Returns the Euler angle representation of the quaternion following the XZY rotation order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="q">The quaternion to convert to Euler angles.</param>
        /// <returns>The Euler angle representation of the quaternion in XZY order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 EulerXZY(quaternion q)
        {
            const float epsilon = 1e-6f;
            const float cutoff = (1f - 2f * epsilon) * (1f - 2f * epsilon);

            // prepare the data
            var qv = q.value;
            var d1 = qv * qv.wwww * float4(2f); //xw, yw, zw, ww
            var d2 = qv * qv.yzxw * float4(2f); //xy, yz, zx, ww
            var d3 = qv * qv;
            var euler = float3.zero;

            var y1 = d2.x + d1.z;
            if (y1 * y1 < cutoff)
            {
                var x1 = -d2.y + d1.x;
                var x2 = d3.y + d3.w - d3.z - d3.x;
                var z1 = -d2.z + d1.y;
                var z2 = d3.x + d3.w - d3.y - d3.z;
                euler = float3(atan2(x1, x2), asin(y1), atan2(z1, z2));
            }
            else //xyx
            {
                y1 = clamp(y1, -1f, 1f);
                var abcd = float4(d2.x, d1.z, d2.z, d1.y);
                var x1 = 2f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                var x2 = csum(abcd * abcd * float4(-1f, 1f, -1f, 1f));
                euler = float3(atan2(x1, x2), asin(y1), 0f);
            }

            return euler.xzy;
        }

        /// <summary>
        /// Returns the Euler angle representation of the quaternion following the YXZ rotation order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="q">The quaternion to convert to Euler angles.</param>
        /// <returns>The Euler angle representation of the quaternion in YXZ order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 EulerYXZ(quaternion q)
        {
            const float epsilon = 1e-6f;
            const float cutoff = (1f - 2f * epsilon) * (1f - 2f * epsilon);

            // prepare the data
            var qv = q.value;
            var d1 = qv * qv.wwww * float4(2f); //xw, yw, zw, ww
            var d2 = qv * qv.yzxw * float4(2f); //xy, yz, zx, ww
            var d3 = qv * qv;
            var euler = float3.zero;

            var y1 = d2.y + d1.x;
            if (y1 * y1 < cutoff)
            {
                var x1 = -d2.z + d1.y;
                var x2 = d3.z + d3.w - d3.x - d3.y;
                var z1 = -d2.x + d1.z;
                var z2 = d3.y + d3.w - d3.z - d3.x;
                euler = float3(atan2(x1, x2), asin(y1), atan2(z1, z2));
            }
            else //yzy
            {
                y1 = clamp(y1, -1f, 1f);
                var abcd = float4(d2.x, d1.z, d2.y, d1.x);
                var x1 = 2f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                var x2 = csum(abcd * abcd * float4(-1f, 1f, -1f, 1f));
                euler = float3(atan2(x1, x2), asin(y1), 0f);
            }

            return euler.yxz;
        }

        /// <summary>
        /// Returns the Euler angle representation of the quaternion following the YZX rotation order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="q">The quaternion to convert to Euler angles.</param>
        /// <returns>The Euler angle representation of the quaternion in YZX order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 EulerYZX(quaternion q)
        {
            const float epsilon = 1e-6f;
            const float cutoff = (1f - 2f * epsilon) * (1f - 2f * epsilon);

            // prepare the data
            var qv = q.value;
            var d1 = qv * qv.wwww * float4(2f); //xw, yw, zw, ww
            var d2 = qv * qv.yzxw * float4(2f); //xy, yz, zx, ww
            var d3 = qv * qv;
            var euler = float3.zero;

            var y1 = d2.x - d1.z;
            if (y1 * y1 < cutoff)
            {
                var x1 = d2.z + d1.y;
                var x2 = d3.x + d3.w - d3.z - d3.y;
                var z1 = d2.y + d1.x;
                var z2 = d3.y + d3.w - d3.x - d3.z;
                euler = float3(atan2(x1, x2), -asin(y1), atan2(z1, z2));
            }
            else //yxy
            {
                y1 = clamp(y1, -1f, 1f);
                var abcd = float4(d2.x, d1.z, d2.y, d1.x);
                var x1 = 2f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                var x2 = csum(abcd * abcd * float4(-1f, 1f, -1f, 1f));
                euler = float3(atan2(x1, x2), -asin(y1), 0f);
            }

            return euler.zxy;
        }

        /// <summary>
        /// Returns the Euler angle representation of the quaternion following the ZXY rotation order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="q">The quaternion to convert to Euler angles.</param>
        /// <returns>The Euler angle representation of the quaternion in ZXY order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 EulerZXY(quaternion q)
        {
            const float epsilon = 1e-6f;
            const float cutoff = (1f - 2f * epsilon) * (1f - 2f * epsilon);

            // prepare the data
            var qv = q.value;
            var d1 = qv * qv.wwww * float4(2f); //xw, yw, zw, ww
            var d2 = qv * qv.yzxw * float4(2f); //xy, yz, zx, ww
            var d3 = qv * qv;
            var euler = float3.zero;

            var y1 = d2.y - d1.x;
            if (y1 * y1 < cutoff)
            {
                var x1 = d2.x + d1.z;
                var x2 = d3.y + d3.w - d3.x - d3.z;
                var z1 = d2.z + d1.y;
                var z2 = d3.z + d3.w - d3.x - d3.y;
                euler = float3(atan2(x1, x2), -asin(y1), atan2(z1, z2));
            }
            else //zxz
            {
                y1 = clamp(y1, -1f, 1f);
                var abcd = float4(d2.z, d1.y, d2.y, d1.x);
                var x1 = 2f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                var x2 = csum(abcd * abcd * float4(-1f, 1f, -1f, 1f));
                euler = float3(atan2(x1, x2), -asin(y1), 0f);
            }

            return euler.yzx;
        }

        /// <summary>
        /// Returns the Euler angle representation of the quaternion following the ZYX rotation order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="q">The quaternion to convert to Euler angles.</param>
        /// <returns>The Euler angle representation of the quaternion in ZYX order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 EulerZYX(quaternion q)
        {
            const float epsilon = 1e-6f;
            const float cutoff = (1f - 2f * epsilon) * (1f - 2f * epsilon);

            var qv = q.value;
            var d1 = qv * qv.wwww * float4(2f); //xw, yw, zw, ww
            var d2 = qv * qv.yzxw * float4(2f); //xy, yz, zx, ww
            var d3 = qv * qv;
            var euler = float3.zero;

            var y1 = d2.z + d1.y;
            if (y1 * y1 < cutoff)
            {
                var x1 = -d2.x + d1.z;
                var x2 = d3.x + d3.w - d3.y - d3.z;
                var z1 = -d2.y + d1.x;
                var z2 = d3.z + d3.w - d3.y - d3.x;
                euler = float3(atan2(x1, x2), asin(y1), atan2(z1, z2));
            }
            else //zxz
            {
                y1 = clamp(y1, -1f, 1f);
                var abcd = float4(d2.z, d1.y, d2.y, d1.x);
                var x1 = 2f * (abcd.x * abcd.w + abcd.y * abcd.z); //2(ad+bc)
                var x2 = csum(abcd * abcd * float4(-1f, 1f, -1f, 1f));
                euler = float3(atan2(x1, x2), asin(y1), 0f);
            }

            return euler.zyx;
        }

        /// <summary>
        /// Returns the Euler angle representation of the quaternion. Angles returned depend on the specified order to apply the
        /// 3 rotations around the principal axes. All rotation angles are in radians and clockwise when looking along the
        /// rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="q">The quaternion to convert to Euler angles.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        /// <returns>The Euler angle representation of the quaternion in the specified order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 Euler(quaternion q, math.RotationOrder order = math.RotationOrder.Default)
        {
            switch (order)
            {
                case math.RotationOrder.XYZ:
                    return EulerXYZ(q);
                case math.RotationOrder.XZY:
                    return EulerXZY(q);
                case math.RotationOrder.YXZ:
                    return EulerYXZ(q);
                case math.RotationOrder.YZX:
                    return EulerYZX(q);
                case math.RotationOrder.ZXY:
                    return EulerZXY(q);
                case math.RotationOrder.ZYX:
                    return EulerZYX(q);
                default:
                    return float3.zero;
            }
        }
    }
}