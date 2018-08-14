using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public partial struct float2x2
    {
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
    }

    public partial struct float3x3
    {
        public float3x3(Quaternion rotation)
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
    }

    public partial struct float4x4
    {
        public float4x4(float3x3 rotation, float3 translation)
        {
            c0 = float4(rotation.c0, 0.0f);
            c1 = float4(rotation.c1, 0.0f);
            c2 = float4(rotation.c2, 0.0f);
            c3 = float4(translation, 1.0f);
        }

        public float4x4(Quaternion rotation, float3 translation)
        {
            float3x3 rot = float3x3(rotation);
            c0 = float4(rot.c0, 0.0f);
            c1 = float4(rot.c1, 0.0f);
            c2 = float4(rot.c2, 0.0f);
            c3 = float4(translation, 1.0f);
        }

        public float4x4(RigidTransform transform)
        {
            float3x3 rot = float3x3(transform.rot);
            c0 = float4(rot.c0, 0.0f);
            c1 = float4(rot.c1, 0.0f);
            c2 = float4(rot.c2, 0.0f);
            c3 = float4(transform.pos, 1.0f);
        }
        
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
    }

    partial class math
    {
        public static float3x3 float3x3(Quaternion rotation)
        {
            return new float3x3(rotation);
        }

        public static float4x4 float4x4(float3x3 rotation, float3 translation)
        {
            return new float4x4(rotation, translation);
        }

        public static float4x4 float4x4(Quaternion rotation, float3 translation)
        {
            return new float4x4(rotation, translation);
        }

        public static float4x4 float4x4(RigidTransform transform)
        {
            return new float4x4(transform);
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
    }
}
