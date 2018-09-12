using System;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    [Serializable]
    public partial struct quaternion : System.IEquatable<quaternion>, IFormattable
    {
        public float4 value;

        /// <summary>A quaternion representing the identity transform.</summary>
        public static readonly quaternion identity = new quaternion(0.0f, 0.0f, 0.0f, 1.0f);

        /// <summary>Constructs a quaternion from four float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public quaternion(float x, float y, float z, float w) { value.x = x; value.y = y; value.z = z; value.w = w; }

        /// <summary>Constructs a quaternion from float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public quaternion(float4 value) { this.value = value; }

        /// <summary>Implicitly converts a float4 vector to a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quaternion(float4 v) { return new quaternion(v); }

        /// <summary>Constructs a unit quaternion from a float3x3 rotation matrix. The matrix must be orthonormal.</summary>
        public quaternion(float3x3 m)
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

        /// <summary>Constructs a unit quaternion from an orthonormal float4x4 matrix.</summary>
        public quaternion(float4x4 m)
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

        /// <summary>
        /// Returns a quaternion representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion AxisAngle(float3 axis, float angle)
        {
            float sina, cosa;
            math.sincos(0.5f * angle, out sina, out cosa);
            return quaternion(float4(axis * sina, cosa));
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        public static quaternion EulerXYZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(-1.0f, 1.0f, -1.0f, 1.0f)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        public static quaternion EulerXZY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(1.0f, 1.0f, -1.0f, -1.0f)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        public static quaternion EulerYXZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(-1.0f, 1.0f, 1.0f, -1.0f)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        public static quaternion EulerYZX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(-1.0f, -1.0f, 1.0f, 1.0f)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        public static quaternion EulerZXY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(1.0f, -1.0f, -1.0f, 1.0f)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        public static quaternion EulerZYX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            float3 s, c;
            sincos(0.5f * xyz, out s, out c);
            return quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.x * s.z
                float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * float4(c.xyz, s.x) * float4(1.0f, -1.0f, 1.0f, -1.0f)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerXYZ(float x, float y, float z) { return EulerXYZ(float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerXZY(float x, float y, float z) { return EulerXZY(float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerYXZ(float x, float y, float z) { return EulerYXZ(float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerYZX(float x, float y, float z) { return EulerYZX(float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerZXY(float x, float y, float z) { return EulerZXY(float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerZYX(float x, float y, float z) { return EulerZYX(float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        public static quaternion Euler(float3 xyz, RotationOrder order = RotationOrder.ZXY)
        {
            switch (order)
            {
                case RotationOrder.XYZ:
                    return EulerXYZ(xyz);
                case RotationOrder.XZY:
                    return EulerXZY(xyz);
                case RotationOrder.YXZ:
                    return EulerYXZ(xyz);
                case RotationOrder.YZX:
                    return EulerYZX(xyz);
                case RotationOrder.ZXY:
                    return EulerZXY(xyz);
                case RotationOrder.ZYX:
                    return EulerZYX(xyz);
                default:
                    return quaternion.identity;
            }
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion Euler(float x, float y, float z, RotationOrder order = RotationOrder.Default)
        {
            return Euler(float3(x, y, z), order);
        }

        /// <summary>Returns a float4x4 matrix that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion RotateX(float angle)
        {
            float sina, cosa;
            math.sincos(0.5f * angle, out sina, out cosa);
            return quaternion(sina, 0.0f, 0.0f, cosa);
        }

        /// <summary>Returns a float4x4 matrix that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion RotateY(float angle)
        {
            float sina, cosa;
            math.sincos(0.5f * angle, out sina, out cosa);
            return quaternion(0.0f, sina, 0.0f, cosa);
        }

        /// <summary>Returns a float4x4 matrix that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion RotateZ(float angle)
        {
            float sina, cosa;
            math.sincos(0.5f * angle, out sina, out cosa);
            return quaternion(0.0f, 0.0f, sina, cosa);
        }

        public static quaternion LookRotation(float3 direction, float3 up)
        {
            var vector = normalizesafe(direction);
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
                return normalize(quaternion(q));
            }
            if ((m00 >= m11) && (m00 >= m22))
            {
                var num7 = sqrt(((1.0f + m00) - m11) - m22);
                var num4 = 0.5f / num7;
                q.x = 0.5f * num7;
                q.y = (m01 + m10) * num4;
                q.z = (m02 + m20) * num4;
                q.w = (m12 - m21) * num4;
                return normalize(quaternion(q));
            }
            if (m11 > m22)
            {
                var num6 = sqrt(((1.0f + m11) - m00) - m22);
                var num3 = 0.5f / num6;
                q.x = (m10 + m01) * num3;
                q.y = 0.5f * num6;
                q.z = (m21 + m12) * num3;
                q.w = (m20 - m02) * num3;
                return normalize(quaternion(q));
            }
            var num5 = sqrt(((1.0f + m22) - m00) - m11);
            var num2 = 0.5f / num5;
            q.x = (m20 + m02) * num2;
            q.y = (m21 + m12) * num2;
            q.z = 0.5f * num5;
            q.w = (m01 - m10) * num2;
            return normalize(quaternion(q));
        }

        /// <summary>Returns true if the quaternion is equal to a given quaternion, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(quaternion x) { return value.x == x.value.x && value.y == x.value.y && value.z == x.value.z && value.w == x.value.w; }

        /// <summary>Returns whether true if the quaternion is equal to a given quaternion, false otherwise.</summary>
        public override bool Equals(object x) { return Equals((quaternion)x); }

        /// <summary>Returns a hash code for the quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }

        /// <summary>Returns a string representation of the quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("quaternion({0}f, {1}f, {2}f, {3}f)", value.x, value.y, value.z, value.w);
        }

        /// <summary>Returns a string representation of the quaternion using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("quaternion({0}f, {1}f, {2}f, {3}f)", value.x.ToString(format, formatProvider), value.y.ToString(format, formatProvider), value.z.ToString(format, formatProvider), value.w.ToString(format, formatProvider));
        }
    }

    public static partial class math
    {
        /// <summary>Returns a quaternion constructed from four float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quaternion(float x, float y, float z, float w) { return new quaternion(x, y, z, w); }

        /// <summary>Returns a quaternion constructed from a float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quaternion(float4 value) { return new quaternion(value); }

        /// <summary>Returns a unit quaternion constructed from a float3x3 rotation matrix. The matrix must be orthonormal.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quaternion(float3x3 m) { return new quaternion(m); }

        /// <summary>Returns a unit quaternion constructed from a float4x4 matrix. The matrix must be orthonormal.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quaternion(float4x4 m) { return new quaternion(m); }

       /// <summary>Returns the conjugate of a quaternion value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion conjugate(quaternion q)
        {
            return quaternion(q.value * float4(-1.0f, -1.0f, -1.0f, 1.0f));
        }

       /// <summary>Returns the inverse of a quaternion value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion inverse(quaternion q)
        {
            float4 x = q.value;
            return quaternion(rcp(dot(x, x)) * x * float4(-1.0f, -1.0f, -1.0f, 1.0f));
        }

        /// <summary>Returns the dot product of two quaternions.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float dot(quaternion a, quaternion b)
        {
            return dot(a.value, b.value);
        }

        /// <summary>Returns the length of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float length(quaternion q)
        {
            return sqrt(dot(q.value, q.value));
        }

        /// <summary>Returns the squared length of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float lengthsq(quaternion q)
        {
            return dot(q.value, q.value);
        }

        /// <summary>Returns a normalized version of a quaternion q by scaling it by 1 / length(q).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion normalize(quaternion q)
        {
            float4 x = q.value;
            return quaternion(rsqrt(dot(x, x)) * x);
        }

        /// <summary>
        /// Returns a safe normalized version of the q by scaling it by 1 / length(q).
        /// Returns the identity when 1 / length(q) does not produce a finite number.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion normalizesafe(quaternion q)
        {
            float4 x = q.value;
            float len = math.dot(x, x);
            return quaternion(math.select(Mathematics.quaternion.identity.value, x * math.rsqrt(len), len > FLT_MIN_NORMAL));
        }

        /// <summary>
        /// Returns a safe normalized version of the q by scaling it by 1 / length(q).
        /// Returns the given default value when 1 / length(q) does not produce a finite number.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion normalizesafe(quaternion q, quaternion defaultvalue)
        {
            float4 x = q.value;
            float len = math.dot(x, x);
            return quaternion(math.select(defaultvalue.value, x * math.rsqrt(len), len > FLT_MIN_NORMAL));
        }

        /// <summary>Returns the natural exponent of a quaternion. Assumes w is zero.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion unitexp(quaternion q)
        {
            float v_rcp_len = rsqrt(dot(q.value.xyz, q.value.xyz));
            float v_len = rcp(v_rcp_len);
            float sin_v_len, cos_v_len;
            sincos(v_len, out sin_v_len, out cos_v_len);
            return quaternion(float4(q.value.xyz * v_rcp_len * sin_v_len, cos_v_len));
        }

        /// <summary>Returns the natural exponent of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion exp(quaternion q)
        {
            float v_rcp_len = rsqrt(dot(q.value.xyz, q.value.xyz));
            float v_len = rcp(v_rcp_len);
            float sin_v_len, cos_v_len;
            sincos(v_len, out sin_v_len, out cos_v_len);
            return quaternion(float4(q.value.xyz * v_rcp_len * sin_v_len, cos_v_len) * exp(q.value.w));
        }

        /// <summary>Returns the natural logarithm of a unit length quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion unitlog(quaternion q)
        {
            float w = clamp(q.value.w, -1.0f, 1.0f);
            float s = acos(w) * rsqrt(1.0f - w*w);
            return quaternion(float4(q.value.xyz * s, 0.0f));
        }

        /// <summary>Returns the natural logarithm of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion log(quaternion q)
        {
            float v_len_sq = dot(q.value.xyz, q.value.xyz);
            float q_len_sq = v_len_sq + q.value.w*q.value.w;

            float s = acos(clamp(q.value.w * rsqrt(q_len_sq), -1.0f, 1.0f)) * rsqrt(v_len_sq);
            return quaternion(float4(q.value.xyz * s, 0.5f * log(q_len_sq)));
        }

        /// <summary>Returns the result of transforming the quaternion b by the quaternion a.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion mul(quaternion a, quaternion b)
        {
            return quaternion(a.value.wwww * b.value + (a.value.xyzx * b.value.wwwx + a.value.yzxy * b.value.zxyy) * float4(1.0f, 1.0f, 1.0f, -1.0f) - a.value.zxyz * b.value.yzxz);
        }

        /// <summary>Returns the result of transforming a vector by a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mul(quaternion q, float3 v)
        {
            float3 t = 2 * cross(q.value.xyz, v);
            return v + q.value.w * t + cross(q.value.xyz, t);
        }

        /// <summary>Returns the result of rotating a vector by a unit quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 rotate(quaternion q, float3 v)
        {
            float3 t = 2 * cross(q.value.xyz, v);
            return v + q.value.w * t + cross(q.value.xyz, t);
        }

        /// <summary>Returns the result of a normalized linear interpolation between two quaternions q1 and a2 using an interpolation parameter t.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion nlerp(quaternion q1, quaternion q2, float t)
        {
            float dt = dot(q1, q2);
            if(dt < 0.0f)
            {
                q2.value = -q2.value;
            }

            return normalize(quaternion(lerp(q1.value, q2.value, t)));
        }

        /// <summary>Returns the result of a spherical interpolation between two quaternions q1 and a2 using an interpolation parameter t.</summary>
        public static quaternion slerp(quaternion q1, quaternion q2, float t)
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
                return quaternion(q1.value * w1 + q2.value * w2);
            }
            else
            {
                // if the angle is small, use linear interpolation
                return nlerp(q1, q2, t);
            }
        }

        /// <summary>Returns a uint hash code of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(quaternion q)
        {
            return hash(q.value);
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a quaternion.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(quaternion q)
        {
            return hashwide(q.value);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 forward(quaternion q) { return mul(q, float3(0, 0, 1)); }  // for compatibility
    }
}
