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
        public static float4x4 transpose(float4x4 m) { return float4x4(m.c0.x, m.c0.y, m.c0.z, m.c0.w, m.c1.x, m.c1.y, m.c1.z, m.c1.w, m.c2.x, m.c2.y, m.c2.z, m.c2.w, m.c3.x, m.c3.y, m.c3.z, m.c3.w); }

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
        
        public static float4x4 scale(float3 vector)
        {
            return float4x4(float4(vector.x, 0.0f, 0.0f, 0.0f),
                            float4(0.0f, vector.y, 0.0f, 0.0f),
                            float4(0.0f, 0.0f, vector.z, 0.0f),
                            float4(0.0f, 0.0f, 0.0f, 1.0f));
        }

        public static float4x4 translate(float3 vector)
        {
            return float4x4(float4(1.0f, 0.0f, 0.0f, 0.0f),
                            float4(0.0f, 1.0f, 0.0f, 0.0f),
                            float4(0.0f, 0.0f, 1.0f, 0.0f),
                            float4(vector.x, vector.y, vector.z, 1.0f));
        }        

        const float epsilon = 0.000001F;

        public static float2x2 identity2()
        {
            return float2x2(1.0f, 0.0f,
                            0.0f, 1.0f);
        }

        public static float3x3 identity3()
        {
            return float3x3(1.0f, 0.0f, 0.0f,
                            0.0f, 1.0f, 0.0f,
                            0.0f, 0.0f, 1.0f);
        }

        public static float4x4 identity4()
        {
            return float4x4(1.0f, 0.0f, 0.0f, 0.0f,
                            0.0f, 1.0f, 0.0f, 0.0f,
                            0.0f, 0.0f, 1.0f, 0.0f,
                            0.0f, 0.0f, 0.0f, 1.0f);
        }

        public static float4x4 lookRotationToMatrix(float3 position, float3 forward, float3 up)
        {
            float3x3 rot = lookRotationToMatrix(forward, up);

            float4x4 matrix;
            matrix.c0 = float4(rot.c0, 0.0F);
            matrix.c1 = float4(rot.c1, 0.0F);
            matrix.c2 = float4(rot.c2, 0.0F);
            matrix.c3 = float4(position, 1.0F);
            return matrix;
        }

        public static float3x3 lookRotationToMatrix(float3 forward, float3 up)
        {
            float3 z = forward;
            // compute u0
            float mag = math.length(z);
            if (mag < epsilon)
                return identity3();
            z /= mag;

            float3 x = math.cross(up, z);
            mag = math.length(x);
            if (mag < epsilon)
                return identity3();
            x /= mag;

            float3 y = math.cross(z, x);
            float yLength = math.length(y);
            if (yLength < 0.9F || yLength > 1.1F)
                return identity3();

            return float3x3(x, y, z);
        }
    }
}
