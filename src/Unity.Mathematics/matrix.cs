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
            this.c0 = new float2(m00, m10);
            this.c1 = new float2(m01, m11);
        }

        public static float2x2 operator *(float2x2 mat, float s)
        {
            return new float2x2(mat.c0 * s, mat.c1 * s);
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
            this.c0 = new float3(m00, m10, m20);
            this.c1 = new float3(m01, m11, m21);
            this.c2 = new float3(m02, m12, m22);
        }

        public static float3x3 operator *(float3x3 mat, float s)
        {
            return new float3x3(mat.c0 * s, mat.c1 * s, mat.c2 * s);
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
            this.c0 = new float4(m00, m10, m20, m30);
            this.c1 = new float4(m01, m11, m21, m31);
            this.c2 = new float4(m02, m12, m22, m32);
            this.c3 = new float4(m03, m13, m23, m33);
        }

        public static float4x4 operator *(float4x4 mat, float s)
        {
            return new float4x4(mat.c0 * s, mat.c1 * s, mat.c2 * s, mat.c3 * s);
        }

        public static float4x4 identity => new float4x4
        {
            c0 = new float4(1.0f, 0.0f, 0.0f, 0.0f),
            c1 = new float4(0.0f, 1.0f, 0.0f, 0.0f),
            c2 = new float4(0.0f, 0.0f, 1.0f, 0.0f),
            c3 = new float4(0.0f, 0.0f, 0.0f, 1.0f)
        };
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

        public static float4 mul(float4x4 x, float4 v)
        {
            return mad(x.c0, v.x, x.c1 * v.y) + mad(x.c2, v.z, x.c3 * v.w);
        }

        public static float4x4 mul(float4x4 a, float4x4 b)
        {
            return new float4x4(mul(a, b.c0), mul(a, b.c1), mul(a, b.c2), mul(a, b.c3));
        }

        public static float2 mul(float2x2 x, float2 v)
        {
            return mad(x.c0, v.x, x.c1 * v.y);
        }

        public static float2x2 mul(float2x2 a, float2x2 b)
        {
            return new float2x2(mul(a, b.c0), mul(a, b.c1));
        }

        public static float3 mul(float3x3 x, float3 v)
        {
            return mad(x.c2, v.z, mad(x.c0, v.x, x.c1 * v.y));
        }

        public static float3x3 mul(float3x3 a, float3x3 b)
        {
            return new float3x3(mul(a, b.c0), mul(a, b.c1), mul(a, b.c2));
        }

        public static float3x3 orthogonalize(float3x3 i)
        {
            float3x3 o;

            float3 u = i.c0;
            float3 v = i.c1 - i.c0 * math.dot(i.c1, i.c0);

            float lenU = math.length(u);
            float lenV = math.length(v);

            bool c = lenU > epsilon_normal && lenV > epsilon_normal;

            o.c0 = math.select(new float3(1, 0, 0), u / lenU, c);
            o.c1 = math.select(new float3(0, 1, 0), v / lenV, c);
            o.c2 = math.cross(o.c0, o.c1);

            return o;
        }

        public static float2x2 transpose(float2x2 i) { return new float2x2(i.c0.x, i.c1.x, i.c0.y, i.c1.y); }
        public static float3x3 transpose(float3x3 i) { return new float3x3(i.c0.x, i.c1.x, i.c2.x, i.c0.y, i.c1.y, i.c2.y, i.c0.z, i.c1.z, i.c2.z); }
        public static float4x4 transpose(float4x4 i) { return new float4x4(i.c0.x, i.c1.x, i.c2.x, i.c3.x, i.c0.y, i.c1.y, i.c2.y, i.c3.y, i.c0.z, i.c1.z, i.c2.z, i.c3.z, i.c0.w, i.c1.w, i.c2.w, i.c3.w); }
        
        public static float4x4 scale(float3 vector)
        {
            float4x4 matrix4x4 = new float4x4();
            matrix4x4.c0 = new float4(vector.x,0.0f,0.0f,0.0f);
            matrix4x4.c1 = new float4(0.0f,vector.y,0.0f,0.0f);
            matrix4x4.c2 = new float4(0.0f,0.0f,vector.z,0.0f);
            matrix4x4.c3 = new float4(0.0f, 0.0f, 0.0f, 1.0f);
            return matrix4x4;
        }

        public static float4x4 translate(float3 vector)
        {
            float4x4 matrix4x4 = new float4x4();
            matrix4x4.c0 = new float4(1.0f, 0.0f, 0.0f, 0.0f);
            matrix4x4.c1 = new float4(0.0f, 1.0f, 0.0f, 0.0f);
            matrix4x4.c2 = new float4(0.0f, 0.0f, 1.0f, 0.0f);
            matrix4x4.c3 = new float4(vector.x, vector.y, vector.z, 1.0f);
            return matrix4x4;
        }        

        const float epsilon = 0.000001F;

        public static float3x3 identity3
        {
            get { return new float3x3(new float3(1, 0, 0), new float3(0, 1, 0), new float3(0, 0, 1)); }
        }
        public static float4x4 identity4
        {
            get { return new float4x4(new float4(1, 0, 0, 0), new float4(0, 1, 0, 0), new float4(0, 0, 1, 0), new float4(0, 0, 0, 1)); }
        }

        public static float4x4 lookRotationToMatrix(float3 position, float3 forward, float3 up)
        {
            float3x3 rot = lookRotationToMatrix(forward, up);

            float4x4 matrix;
            matrix.c0 = new float4(rot.c0, 0.0F);
            matrix.c1 = new float4(rot.c1, 0.0F);
            matrix.c2 = new float4(rot.c2, 0.0F);
            matrix.c3 = new float4(position, 1.0F);

            return matrix;
        }

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

        /* @TODO:
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float determinant(float2x2 x) { throw new System.NotImplementedException(); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float determinant(float3x3 x) { throw new System.NotImplementedException(); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float determinant(float4x4 x) { throw new System.NotImplementedException(); }
        */
    }
}
