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

        public static float3x3 euler(float x, float y, float z, RotationOrder order = RotationOrder.ZXY)
        {
            switch (order)
            {
                case RotationOrder.XYZ:
                    return mul(rotateZ(z), mul(rotateY(y), rotateX(x)));
                case RotationOrder.XZY:
                    return mul(rotateY(y), mul(rotateZ(z), rotateX(x)));
                case RotationOrder.YXZ:
                    return mul(rotateZ(z), mul(rotateX(x), rotateY(y)));
                case RotationOrder.YZX:
                    return mul(rotateX(x), mul(rotateZ(z), rotateY(y)));
                case RotationOrder.ZXY:
                    return mul(rotateY(y), mul(rotateX(x), rotateZ(z)));
                case RotationOrder.ZYX:
                    return mul(rotateX(x), mul(rotateY(y), rotateZ(z)));
                default:
                    return float3x3.identity;
            }
        }

        public static float3x3 euler(float3 xyz, RotationOrder order = RotationOrder.ZXY)
        {
            return euler(xyz.x, xyz.y, xyz.z, order);
        }

        public static float3x3 rotateX(float angle)
        {
            float s, c;
            sincos(angle, out s, out c);
            return float3x3(1.0f, 0.0f, 0.0f,
                            0.0f, c,    -s,
                            0.0f, s,    c);
        }

        public static float3x3 rotateY(float angle)
        {
            float s, c;
            sincos(angle, out s, out c);
            return float3x3(c,    0.0f, s,
                            0.0f, 1.0f, 0.0f,
                            -s,   0.0f, c);
        }

        public static float3x3 rotateZ(float angle)
        {
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

        
        public static float4x4 euler(float x, float y, float z, RotationOrder order = RotationOrder.ZXY)
        {
            switch(order)
            {
                case RotationOrder.XYZ:
                    return mul(rotateZ(z), mul(rotateY(y), rotateX(x)));
                case RotationOrder.XZY:
                    return mul(rotateY(y), mul(rotateZ(z), rotateX(x)));
                case RotationOrder.YXZ:
                    return mul(rotateZ(z), mul(rotateX(x), rotateY(y)));
                case RotationOrder.YZX:
                    return mul(rotateX(x), mul(rotateZ(z), rotateY(y)));
                case RotationOrder.ZXY:
                    return mul(rotateY(y), mul(rotateX(x), rotateZ(z)));
                case RotationOrder.ZYX:
                    return mul(rotateX(x), mul(rotateY(y), rotateZ(z)));
                default:
                    return float4x4.identity;
            }
        }

        public static float4x4 euler(float3 xyz, RotationOrder order = RotationOrder.ZXY)
        {
            return euler(xyz.x, xyz.y, xyz.z, order);
        }

        public static float4x4 rotateX(float angle)
        {
            float s, c;
            sincos(angle, out s, out c);
            return float4x4(1.0f, 0.0f, 0.0f, 0.0f,
                            0.0f, c,    -s,   0.0f,
                            0.0f, s,    c,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);

        }

        public static float4x4 rotateY(float angle)
        {
            float s, c;
            sincos(angle, out s, out c);
            return float4x4(c,    0.0f, s,    0.0f,
                            0.0f, 1.0f, 0.0f, 0.0f,
                            -s,   0.0f, c,    0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);

        }

        public static float4x4 rotateZ(float angle)
        {
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

        public static float4 unpacklo(float4 a, float4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY);
        }

        public static float4 unpackhi(float4 a, float4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftW, ShuffleComponent.RightW);
        }

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
            // naive scalar implementation using direct calculation by cofactors
            float4 c0 = m.c0;
            float4 c1 = m.c1;
            float4 c2 = m.c2;
            float4 c3 = m.c3;

            // calculate minors
            float m00 = c1.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c1.z * c3.w - c1.w * c3.z) + c3.y * (c1.z * c2.w - c1.w * c2.z);
            float m01 = c0.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c2.w - c0.w * c2.z);
            float m02 = c0.y * (c1.z * c3.w - c1.w * c3.z) - c1.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c1.w - c0.w * c1.z);
            float m03 = c0.y * (c1.z * c2.w - c1.w * c2.z) - c1.y * (c0.z * c2.w - c0.w * c2.z) + c2.y * (c0.z * c1.w - c0.w * c1.z);

            float m10 = c1.x * (c2.z * c3.w - c2.w * c3.z) - c2.x * (c1.z * c3.w - c1.w * c3.z) + c3.x * (c1.z * c2.w - c1.w * c2.z);
            float m11 = c0.x * (c2.z * c3.w - c2.w * c3.z) - c2.x * (c0.z * c3.w - c0.w * c3.z) + c3.x * (c0.z * c2.w - c0.w * c2.z);
            float m12 = c0.x * (c1.z * c3.w - c1.w * c3.z) - c1.x * (c0.z * c3.w - c0.w * c3.z) + c3.x * (c0.z * c1.w - c0.w * c1.z);
            float m13 = c0.x * (c1.z * c2.w - c1.w * c2.z) - c1.x * (c0.z * c2.w - c0.w * c2.z) + c2.x * (c0.z * c1.w - c0.w * c1.z);

            float m20 = c1.x * (c2.y * c3.w - c2.w * c3.y) - c2.x * (c1.y * c3.w - c1.w * c3.y) + c3.x * (c1.y * c2.w - c1.w * c2.y);
            float m21 = c0.x * (c2.y * c3.w - c2.w * c3.y) - c2.x * (c0.y * c3.w - c0.w * c3.y) + c3.x * (c0.y * c2.w - c0.w * c2.y);
            float m22 = c0.x * (c1.y * c3.w - c1.w * c3.y) - c1.x * (c0.y * c3.w - c0.w * c3.y) + c3.x * (c0.y * c1.w - c0.w * c1.y);
            float m23 = c0.x * (c1.y * c2.w - c1.w * c2.y) - c1.x * (c0.y * c2.w - c0.w * c2.y) + c2.x * (c0.y * c1.w - c0.w * c1.y);

            float m30 = c1.x * (c2.y * c3.z - c2.z * c3.y) - c2.x * (c1.y * c3.z - c1.z * c3.y) + c3.x * (c1.y * c2.z - c1.z * c2.y);
            float m31 = c0.x * (c2.y * c3.z - c2.z * c3.y) - c2.x * (c0.y * c3.z - c0.z * c3.y) + c3.x * (c0.y * c2.z - c0.z * c2.y);
            float m32 = c0.x * (c1.y * c3.z - c1.z * c3.y) - c1.x * (c0.y * c3.z - c0.z * c3.y) + c3.x * (c0.y * c1.z - c0.z * c1.y);
            float m33 = c0.x * (c1.y * c2.z - c1.z * c2.y) - c1.x * (c0.y * c2.z - c0.z * c2.y) + c2.x * (c0.y * c1.z - c0.z * c1.y);
            
            float det = c0.x * m00 - c1.x * m01 + c2.x * m02 - c3.x * m03;
            
            return float4x4( m00, -m10,  m20, -m30,
                            -m01,  m11, -m21,  m31,
                             m02, -m12,  m22, -m32,
                            -m03,  m13, -m23,  m33) * (1.0f / det);
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
