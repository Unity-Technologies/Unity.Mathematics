using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public partial struct float2x2
    {
        public float2 c0;
        public float2 c1;

        public float2x2(float2 c0, float2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        public float2x2(float m00, float m01,
                        float m10, float m11)
        {
            this.c0 = float2(m00, m10);
            this.c1 = float2(m01, m11);
        }

        public static readonly float2x2 identity = new float2x2(1.0f, 0.0f, 0.0f, 1.0f);

        public static float2x2 rotate(float angle)  // counter-clockwise rotation
        {
            float s, c;
            sincos(angle, out s, out c);
            return float2x2(c, -s, 
                            s,  c);
        }

        public static float2x2 scale(float s)
        {
            return float2x2(s,    0.0f,
                            0.0f, s);
        }

        public static float2x2 scale(float x, float y)
        {
            return float2x2(x,    0.0f,
                            0.0f, y);
        }

        public static float2x2 scale(float2 v)
        {
            return scale(v.x, v.y);
        }

        public static float2x2 operator *(float2x2 mat, float s)
        {
            return float2x2(mat.c0 * s, mat.c1 * s);
        }
    }

    public partial struct float3x3
    {
        public float3 c0;
        public float3 c1;
        public float3 c2;

        public float3x3(float3 c0, float3 c1, float3 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        public float3x3(float m00, float m01, float m02,
                        float m10, float m11, float m12,
                        float m20, float m21, float m22)
        {
            this.c0 = float3(m00, m10, m20);
            this.c1 = float3(m01, m11, m21);
            this.c2 = float3(m02, m12, m22);
        }

        public float3x3(quaternion rotation)
        {
            rotation = math.normalize(rotation);

            float x = rotation.value.x * 2.0F;
            float y = rotation.value.y * 2.0F;
            float z = rotation.value.z * 2.0F;
            float xx = rotation.value.x * x;
            float yy = rotation.value.y * y;
            float zz = rotation.value.z * z;
            float xy = rotation.value.x * y;
            float xz = rotation.value.x * z;
            float yz = rotation.value.y * z;
            float wx = rotation.value.w * x;
            float wy = rotation.value.w * y;
            float wz = rotation.value.w * z;

            c0 = float3(1.0f - (yy + zz), xy + wz, xz - wy);
            c1 = float3(xy - wz, 1.0f - (xx + zz), yz + wx);
            c2 = float3(xz + wy, yz - wx, 1.0f - (xx + yy));
        }

        public static readonly float3x3 identity = new float3x3(1.0f, 0.0f, 0.0f,
            0.0f, 1.0f, 0.0f,
            0.0f, 0.0f, 1.0f);

        public static float3x3 eulerXYZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float3x3(
                c.y * c.z,  c.z * s.x * s.y - c.x * s.z,    c.x * c.z * s.y + s.x * s.z,
                c.y * s.z,  c.x * c.z + s.x * s.y * s.z,    c.x * s.y * s.z - c.z * s.x,
                -s.y,       c.y * s.x,                      c.x * c.y
                );
        }

        public static float3x3 eulerXZY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x))); }
            float3 s, c;
            sincos(xyz, out s, out c);
            return float3x3(
                c.y * c.z,  s.x * s.y - c.x * c.y * s.z,    c.x * s.y + c.y * s.x * s.z,
                s.z,        c.x * c.z,                      -c.z * s.x,
                -c.z * s.y, c.y * s.x + c.x * s.y * s.z,    c.x * c.y - s.x * s.y * s.z
                );
        }
        public static float3x3 eulerYXZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float3x3(
                c.y * c.z - s.x * s.y * s.z,    -c.x * s.z, c.z * s.y + c.y * s.x * s.z,
                c.z * s.x * s.y + c.y * s.z,    c.x * c.z,  s.y * s.z - c.y * c.z * s.x,
                -c.x * s.y,                     s.x,        c.x * c.y
                );
        }
        public static float3x3 eulerYZX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float3x3(
                c.y * c.z,                      -s.z,       c.z * s.y,
                s.x * s.y + c.x * c.y * s.z,    c.x * c.z,  c.x * s.y * s.z - c.y * s.x,
                c.y * s.x * s.z - c.x * s.y,    c.z * s.x,  c.x * c.y + s.x * s.y * s.z
                );
        }
        public static float3x3 eulerZXY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float3x3(
                c.y * c.z + s.x * s.y * s.z,    c.z * s.x * s.y - c.y * s.z,    c.x * s.y,
                c.x * s.z,                      c.x * c.z,                      -s.x,
                c.y * s.x * s.z - c.z * s.y,    c.y * c.z * s.x + s.y * s.z,    c.x * c.y
                );
        }
        public static float3x3 eulerZYX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float3x3(
                c.y * c.z,                      -c.y * s.z,                     s.y,
                c.z * s.x * s.y + c.x * s.z,    c.x * c.z - s.x * s.y * s.z,    -c.y * s.x,
                s.x * s.z - c.x * c.z * s.y,    c.z * s.x + c.x * s.y * s.z,    c.x * c.y
                );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 eulerXYZ(float x, float y, float z) { return eulerXYZ(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 eulerXZY(float x, float y, float z) { return eulerXZY(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 eulerYXZ(float x, float y, float z) { return eulerYXZ(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 eulerYZX(float x, float y, float z) { return eulerYZX(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 eulerZXY(float x, float y, float z) { return eulerZXY(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 eulerZYX(float x, float y, float z) { return eulerZYX(float3(x, y, z)); }

        public static float3x3 euler(float3 xyz, RotationOrder order = RotationOrder.ZXY)
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
                    return float3x3.identity;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x3 euler(float x, float y, float z, RotationOrder order = RotationOrder.ZXY)
        {
            return euler(float3(x, y, z), order);
        }

        public static float3x3 rotateX(float angle)
        {
            // {{1, 0, 0}, {0, c_0, -s_0}, {0, s_0, c_0}}
            float s, c;
            sincos(angle, out s, out c);
            return float3x3(1.0f, 0.0f, 0.0f,
                            0.0f, c,    -s,
                            0.0f, s,    c);
        }

        public static float3x3 rotateY(float angle)
        {
            // {{c_1, 0, s_1}, {0, 1, 0}, {-s_1, 0, c_1}}
            float s, c;
            sincos(angle, out s, out c);
            return float3x3(c,    0.0f, s,
                            0.0f, 1.0f, 0.0f,
                            -s,   0.0f, c);
        }

        public static float3x3 rotateZ(float angle)
        {
            // {{c_2, -s_2, 0}, {s_2, c_2, 0}, {0, 0, 1}}
            float s, c;
            sincos(angle, out s, out c);
            return float3x3(c,    -s,   0.0f,
                            s,    c,    0.0f,
                            0.0f, 0.0f, 1.0f);
        }

        public static float3x3 scale(float s)
        {
            return float3x3(s,    0.0f, 0.0f,
                            0.0f, s,    0.0f,
                            0.0f, 0.0f, s);
        }

        public static float3x3 scale(float x, float y, float z)
        {
            return float3x3(x,    0.0f, 0.0f,
                            0.0f, y,    0.0f,
                            0.0f, 0.0f, z);
        }

        public static float3x3 scale(float3 v)
        {
            return scale(v.x, v.y, v.z);
        }

        public static float3x3 lookRotation(float3 forward, float3 up)
        {
            const float epsilon = 0.000001F;
            float3 z = forward;
            // compute u0
            float mag = math.length(z);
            if (mag < epsilon)
                return Mathematics.float3x3.identity;
            z /= mag;

            float3 x = math.cross(up, z);
            mag = math.length(x);
            if (mag < epsilon)
                return Mathematics.float3x3.identity;
            x /= mag;

            float3 y = math.cross(z, x);
            float yLength = math.length(y);
            if (yLength < 0.9F || yLength > 1.1F)
                return Mathematics.float3x3.identity;

            return float3x3(x, y, z);
        }

        public static float3x3 operator *(float3x3 mat, float s)
        {
            return float3x3(mat.c0 * s, mat.c1 * s, mat.c2 * s);
        }
    }

    public partial struct float4x4
    {
        public float4 c0;
        public float4 c1;
        public float4 c2;
        public float4 c3;

        public float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        public float4x4(float m00, float m01, float m02, float m03,
                        float m10, float m11, float m12, float m13,
                        float m20, float m21, float m22, float m23,
                        float m30, float m31, float m32, float m33)
        {
            this.c0 = float4(m00, m10, m20, m30);
            this.c1 = float4(m01, m11, m21, m31);
            this.c2 = float4(m02, m12, m22, m32);
            this.c3 = float4(m03, m13, m23, m33);
        }

        public float4x4(float3x3 rotation, float3 translation)
        {
            c0 = float4(rotation.c0, 0.0f);
            c1 = float4(rotation.c1, 0.0f);
            c2 = float4(rotation.c2, 0.0f);
            c3 = float4(translation, 1.0f);
        }

        public float4x4(quaternion rotation, float3 translation)
        {
            float3x3 rot = float3x3(rotation);
            c0 = float4(rot.c0, 0.0f);
            c1 = float4(rot.c1, 0.0f);
            c2 = float4(rot.c2, 0.0f);
            c3 = float4(translation, 1.0f);
        }

        public static readonly float4x4 identity = new float4x4(1.0f, 0.0f, 0.0f, 0.0f,
                                                                0.0f, 1.0f, 0.0f, 0.0f,
                                                                0.0f, 0.0f, 1.0f, 0.0f,
                                                                0.0f, 0.0f, 0.0f, 1.0f);

        public static float4x4 eulerXYZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float4x4(
                c.y * c.z,  c.z * s.x * s.y - c.x * s.z,    c.x * c.z * s.y + s.x * s.z,    0.0f,
                c.y * s.z,  c.x * c.z + s.x * s.y * s.z,    c.x * s.y * s.z - c.z * s.x,    0.0f,
                -s.y,       c.y * s.x,                      c.x * c.y,                      0.0f,
                0.0f,       0.0f,                           0.0f,                           1.0f
                );
        }

        public static float4x4 eulerXZY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x))); }
            float3 s, c;
            sincos(xyz, out s, out c);
            return float4x4(
                c.y * c.z,  s.x * s.y - c.x * c.y * s.z,    c.x * s.y + c.y * s.x * s.z,    0.0f,
                s.z,        c.x * c.z,                      -c.z * s.x,                     0.0f,
                -c.z * s.y, c.y * s.x + c.x * s.y * s.z,    c.x * c.y - s.x * s.y * s.z,    0.0f,
                0.0f,       0.0f,                           0.0f,                           1.0f
                );
        }
        public static float4x4 eulerYXZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float4x4(
                c.y * c.z - s.x * s.y * s.z,    -c.x * s.z, c.z * s.y + c.y * s.x * s.z,    0.0f,
                c.z * s.x * s.y + c.y * s.z,    c.x * c.z,  s.y * s.z - c.y * c.z * s.x,    0.0f,
                -c.x * s.y,                     s.x,        c.x * c.y,                      0.0f,
                0.0f,                           0.0f,       0.0f,                           1.0f
                );
        }
        public static float4x4 eulerYZX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float4x4(
                c.y * c.z,                      -s.z,       c.z * s.y,                      0.0f,
                s.x * s.y + c.x * c.y * s.z,    c.x * c.z,  c.x * s.y * s.z - c.y * s.x,    0.0f,
                c.y * s.x * s.z - c.x * s.y,    c.z * s.x,  c.x * c.y + s.x * s.y * s.z,    0.0f,
                0.0f,                           0.0f,       0.0f,                           1.0f
                );
        }
        public static float4x4 eulerZXY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float4x4(
                c.y * c.z + s.x * s.y * s.z,    c.z * s.x * s.y - c.y * s.z,    c.x * s.y,  0.0f,
                c.x * s.z,                      c.x * c.z,                      -s.x,       0.0f,
                c.y * s.x * s.z - c.z * s.y,    c.y * c.z * s.x + s.y * s.z,    c.x * c.y,  0.0f,
                0.0f,                           0.0f,                           0.0f,       1.0f
                );
        }
        public static float4x4 eulerZYX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            float3 s, c;
            sincos(xyz, out s, out c);
            return float4x4(
                c.y * c.z,                      -c.y * s.z,                     s.y,        0.0f,
                c.z * s.x * s.y + c.x * s.z,    c.x * c.z - s.x * s.y * s.z,    -c.y * s.x, 0.0f,
                s.x * s.z - c.x * c.z * s.y,    c.z * s.x + c.x * s.y * s.z,    c.x * c.y,  0.0f,
                0.0f,                           0.0f,                           0.0f,       1.0f
                );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x4 eulerXYZ(float x, float y, float z) { return eulerXYZ(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x4 eulerXZY(float x, float y, float z) { return eulerXZY(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x4 eulerYXZ(float x, float y, float z) { return eulerYXZ(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x4 eulerYZX(float x, float y, float z) { return eulerYZX(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x4 eulerZXY(float x, float y, float z) { return eulerZXY(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x4 eulerZYX(float x, float y, float z) { return eulerZYX(float3(x, y, z)); }

        public static float4x4 euler(float3 xyz, RotationOrder order = RotationOrder.ZXY)
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
                    return float4x4.identity;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x4 euler(float x, float y, float z, RotationOrder order = RotationOrder.ZXY)
        {
            return euler(float3(x, y, z), order);
        }

        public static float4x4 rotateX(float angle)
        {
            // {{1, 0, 0}, {0, c_0, -s_0}, {0, s_0, c_0}}
            float s, c;
            sincos(angle, out s, out c);
            return float4x4(1.0f, 0.0f, 0.0f, 0.0f,
                            0.0f, c,    -s,   0.0f,
                            0.0f, s,    c,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);

        }

        public static float4x4 rotateY(float angle)
        {
            // {{c_1, 0, s_1}, {0, 1, 0}, {-s_1, 0, c_1}}
            float s, c;
            sincos(angle, out s, out c);
            return float4x4(c,    0.0f, s,    0.0f,
                            0.0f, 1.0f, 0.0f, 0.0f,
                            -s,   0.0f, c,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);

        }

        public static float4x4 rotateZ(float angle)
        {
            // {{c_2, -s_2, 0}, {s_2, c_2, 0}, {0, 0, 1}}
            float s, c;
            sincos(angle, out s, out c);
            return float4x4(c,    -s,   0.0f, 0.0f,
                            s,    c,    0.0f, 0.0f,
                            0.0f, 0.0f, 1.0f, 0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);

        }

        public static float4x4 scale(float s)
        {
            return float4x4(s,    0.0f, 0.0f, 0.0f,
                            0.0f, s,    0.0f, 0.0f,
                            0.0f, 0.0f, s,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static float4x4 scale(float x, float y, float z)
        {
            return float4x4(x,    0.0f, 0.0f, 0.0f,
                            0.0f, y,    0.0f, 0.0f,
                            0.0f, 0.0f, z,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static float4x4 scale(float3 v)
        {
            return scale(v.x, v.y, v.z);
        }

        public static float4x4 translate(float3 vector)
        {
            return float4x4(float4(1.0f, 0.0f, 0.0f, 0.0f),
                            float4(0.0f, 1.0f, 0.0f, 0.0f),
                            float4(0.0f, 0.0f, 1.0f, 0.0f),
                            float4(vector.x, vector.y, vector.z, 1.0f));
        }

        public static float4x4 lookAt(float3 position, float3 forward, float3 up)
        {
            float3x3 rot = float3x3.lookRotation(forward, up);

            float4x4 matrix;
            matrix.c0 = float4(rot.c0, 0.0F);
            matrix.c1 = float4(rot.c1, 0.0F);
            matrix.c2 = float4(rot.c2, 0.0F);
            matrix.c3 = float4(position, 1.0F);
            return matrix;
        }

        public static float4x4 operator *(float4x4 mat, float s)
        {
            return float4x4(mat.c0 * s, mat.c1 * s, mat.c2 * s, mat.c3 * s);
        }
    }

    partial class math
    {
        public static float2x2 float2x2(float2 c0, float2 c1)
        {
            return new float2x2(c0, c1);
        }

        public static float2x2 float2x2(float m00, float m01,
                                        float m10, float m11)
        {
            return new float2x2(m00, m01,
                                m10, m11);
        }

        public static float3x3 float3x3(float3 c0, float3 c1, float3 c2)
        {
            return new float3x3(c0, c1, c2);
        }

        public static float3x3 float3x3(float m00, float m01, float m02,
                                        float m10, float m11, float m12,
                                        float m20, float m21, float m22)
        {
            return new float3x3(m00, m01, m02,
                                m10, m11, m12,
                                m20, m21, m22);
        }

        public static float3x3 float3x3(quaternion rotation)
        {
            return new float3x3(rotation);
        }

        public static float4x4 float4x4(float4 c0, float4 c1, float4 c2, float4 c3)
        {
            return new float4x4(c0, c1, c2, c3);
        }

        public static float4x4 float4x4(float m00, float m01, float m02, float m03,
                                        float m10, float m11, float m12, float m13,
                                        float m20, float m21, float m22, float m23,
                                        float m30, float m31, float m32, float m33)
        {
            return new float4x4(m00, m01, m02, m03,
                                m10, m11, m12, m13,
                                m20, m21, m22, m23,
                                m30, m31, m32, m33);
        }

        public static float4x4 float4x4(float3x3 rotation, float3 translation)
        {
            return new float4x4(rotation, translation);
        }

        public static float4x4 float4x4(quaternion rotation, float3 translation)
        {
            return new float4x4(rotation, translation);
        }

        public static float2 mul(float2x2 x, float2 v)
        {
            return mad(x.c0, v.x, x.c1 * v.y);
        }

        public static float2x2 mul(float2x2 a, float2x2 b)
        {
            return float2x2(mul(a, b.c0), mul(a, b.c1));
        }

        public static float3 mul(float3x3 x, float3 v)
        {
            return mad(x.c2, v.z, mad(x.c0, v.x, x.c1 * v.y));
        }

        public static float3x3 mul(float3x3 a, float3x3 b)
        {
            return float3x3(mul(a, b.c0), mul(a, b.c1), mul(a, b.c2));
        }

        public static float4 mul(float4x4 x, float4 v)
        {
            return mad(x.c0, v.x, x.c1 * v.y) + mad(x.c2, v.z, x.c3 * v.w);
        }

        public static float4x4 mul(float4x4 a, float4x4 b)
        {
            return float4x4(mul(a, b.c0), mul(a, b.c1), mul(a, b.c2), mul(a, b.c3));
        }

        public static float3x3 orthogonalize(float3x3 i)
        {
            float3x3 o;

            float3 u = i.c0;
            float3 v = i.c1 - i.c0 * math.dot(i.c1, i.c0);

            float lenU = math.length(u);
            float lenV = math.length(v);

            bool c = lenU > epsilon_normal && lenV > epsilon_normal;

            o.c0 = math.select(float3(1, 0, 0), u / lenU, c);
            o.c1 = math.select(float3(0, 1, 0), v / lenV, c);
            o.c2 = math.cross(o.c0, o.c1);

            return o;
        }

        public static float2x2 transpose(float2x2 m) { return float2x2(m.c0.x, m.c0.y, m.c1.x, m.c1.y); }
        public static float3x3 transpose(float3x3 m) { return float3x3(m.c0.x, m.c0.y, m.c0.z, m.c1.x, m.c1.y, m.c1.z, m.c2.x, m.c2.y, m.c2.z); }
        // public static float4x4 transpose(float4x4 m) { return float4x4(m.c0.x, m.c0.y, m.c0.z, m.c0.w, m.c1.x, m.c1.y, m.c1.z, m.c1.w, m.c2.x, m.c2.y, m.c2.z, m.c2.w, m.c3.x, m.c3.y, m.c3.z, m.c3.w); }

        public static float4x4 transpose(float4x4 m)
        {
            float4 t0 = unpacklo(m.c0, m.c2);
            float4 t1 = unpacklo(m.c1, m.c3);
            float4 t2 = unpackhi(m.c0, m.c2);
            float4 t3 = unpackhi(m.c1, m.c3);
            return float4x4(unpacklo(t0, t1), unpackhi(t0, t1), unpacklo(t2, t3), unpackhi(t2, t3));
        }

        public static float2x2 inverse(float2x2 m)
        {
            float a = m.c0.x;
            float b = m.c1.x;
            float c = m.c0.y;
            float d = m.c1.y;

            float det = a * d - b * c;

            return float2x2( d, -b,
                            -c,  a) * (1.0f / det);
        }

        public static float3x3 inverse(float3x3 m)
        {
            // naive scalar implementation using direct calculation by cofactors
            float3 c0 = m.c0;
            float3 c1 = m.c1;
            float3 c2 = m.c2;
            
            // calculate minors
            float m00 = c1.y * c2.z - c1.z * c2.y;
            float m01 = c0.y * c2.z - c0.z * c2.y;
            float m02 = c0.y * c1.z - c0.z * c1.y;

            float m10 = c1.x * c2.z - c1.z * c2.x;
            float m11 = c0.x * c2.z - c0.z * c2.x;
            float m12 = c0.x * c1.z - c0.z * c1.x;

            float m20 = c1.x * c2.y - c1.y * c2.x;
            float m21 = c0.x * c2.y - c0.y * c2.x;
            float m22 = c0.x * c1.y - c0.y * c1.x;
            
            float det = c0.x * m00 - c1.x * m01 + c2.x * m02;
            
            return float3x3( m00, -m10,  m20,
                            -m01,  m11, -m21,
                             m02, -m12,  m22) * (1.0f / det);
        }

        public static float4x4 inverse(float4x4 m)
        {
            float4 c0 = m.c0;
            float4 c1 = m.c1;
            float4 c2 = m.c2;
            float4 c3 = m.c3;

            float4 r0y_r1y_r0x_r1x = movelh(c1, c0);
            float4 r0z_r1z_r0w_r1w = movelh(c2, c3);
            float4 r2y_r3y_r2x_r3x = movehl(c0, c1);
            float4 r2z_r3z_r2w_r3w = movehl(c3, c2);

            float4 r1y_r2y_r1x_r2x = shuffle(c1, c0, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightZ);
            float4 r1z_r2z_r1w_r2w = shuffle(c2, c3, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightZ);
            float4 r3y_r0y_r3x_r0x = shuffle(c1, c0, ShuffleComponent.LeftW, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightX);
            float4 r3z_r0z_r3w_r0w = shuffle(c2, c3, ShuffleComponent.LeftW, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightX);

            float4 r0_wzyx = shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);
            float4 r1_wzyx = shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightW);
            float4 r2_wzyx = shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);
            float4 r3_wzyx = shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightW);
            float4 r0_xyzw = shuffle(r0y_r1y_r0x_r1x, r0z_r1z_r0w_r1w, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);

            // Calculate remaining inner term pairs. inner terms have zw=-xy, so we only have to calculate xy and can pack two pairs per vector.
            float4 inner12_23 = r1y_r2y_r1x_r2x * r2z_r3z_r2w_r3w - r1z_r2z_r1w_r2w * r2y_r3y_r2x_r3x;
            float4 inner02_13 = r0y_r1y_r0x_r1x * r2z_r3z_r2w_r3w - r0z_r1z_r0w_r1w * r2y_r3y_r2x_r3x;
            float4 inner30_01 = r3z_r0z_r3w_r0w * r0y_r1y_r0x_r1x - r3y_r0y_r3x_r0x * r0z_r1z_r0w_r1w;

            // Expand inner terms back to 4 components. zw signs still need to be flipped
            float4 inner12 = shuffle(inner12_23, inner12_23, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            float4 inner23 = shuffle(inner12_23, inner12_23, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            float4 inner02 = shuffle(inner02_13, inner02_13, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            float4 inner13 = shuffle(inner02_13, inner02_13, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            // Calculate minors
            float4 minors0 = r3_wzyx * inner12 - r2_wzyx * inner13 + r1_wzyx * inner23;

            float4 denom = r0_xyzw * minors0;

            // Horizontal sum of denominator. Free sign flip of z and w compensates for missing flip in inner terms.
            denom = denom + shuffle(denom, denom, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightZ);   // x+y		x+y			z+w			z+w
            denom = denom - shuffle(denom, denom, ShuffleComponent.LeftZ, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.RightX);   // x+y-z-w  x+y-z-w		z+w-x-y		z+w-x-y

            float4 rcp_denom_ppnn = float4(1.0f) / denom;
            float4x4 res;
            res.c0 = minors0 * rcp_denom_ppnn;

            float4 inner30 = shuffle(inner30_01, inner30_01, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            float4 inner01 = shuffle(inner30_01, inner30_01, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            float4 minors1 = r2_wzyx * inner30 - r0_wzyx * inner23 - r3_wzyx * inner02;
            res.c1 = minors1 * rcp_denom_ppnn;

            float4 minors2 = r0_wzyx * inner13 - r1_wzyx * inner30 - r3_wzyx * inner01;
            res.c2 = minors2 * rcp_denom_ppnn;

            float4 minors3 = r1_wzyx * inner02 - r0_wzyx * inner12 + r2_wzyx * inner01;
            res.c3 = minors3 * rcp_denom_ppnn;
            return res;
        }

        public static float determinant(float2x2 m)
        {
            float a = m.c0.x;
            float b = m.c1.x;
            float c = m.c0.y;
            float d = m.c1.y;

            return a * d - b * c;
        }

        public static float determinant(float3x3 m)
        {
            float3 c0 = m.c0;
            float3 c1 = m.c1;
            float3 c2 = m.c2;

            float m00 = c1.y * c2.z - c1.z * c2.y;
            float m01 = c0.y * c2.z - c0.z * c2.y;
            float m02 = c0.y * c1.z - c0.z * c1.y;

            return c0.x * m00 - c1.x * m01 + c2.x * m02;
        }

        public static float determinant(float4x4 m)
        {
            float4 c0 = m.c0;
            float4 c1 = m.c1;
            float4 c2 = m.c2;
            float4 c3 = m.c3;

            float m00 = c1.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c1.z * c3.w - c1.w * c3.z) + c3.y * (c1.z * c2.w - c1.w * c2.z);
            float m01 = c0.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c2.w - c0.w * c2.z);
            float m02 = c0.y * (c1.z * c3.w - c1.w * c3.z) - c1.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c1.w - c0.w * c1.z);
            float m03 = c0.y * (c1.z * c2.w - c1.w * c2.z) - c1.y * (c0.z * c2.w - c0.w * c2.z) + c2.y * (c0.z * c1.w - c0.w * c1.z);

            return c0.x * m00 - c1.x * m01 + c2.x * m02 - c3.x * m03;
        }
    }
}
