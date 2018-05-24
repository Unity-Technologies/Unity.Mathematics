using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public partial struct float3x3
    {
        // todo: should we use field offset 0,4,8 to match native 4x4
        public float3 m0;
        public float3 m1;
        public float3 m2;

        public float3x3(float3 m0, float3 m1, float3 m2)
        {
            this.m0 = m0;
            this.m1 = m1;
            this.m2 = m2;
        }
       
        public static float3x3 zero => new float3x3(new float3(0.0f, 0.0f, 0.0f), new float3(0.0f, 0.0f, 0.0f), new float3(0.0f, 0.0f, 0.0f));
        public static float3x3 identity => new float3x3(new float3(1.0f, 0.0f, 0.0f), new float3(0.0f, 1.0f, 0.0f), new float3(0.0f, 0.0f, 1.0f));
    }

    public static partial class math
    {
        // cross
        public static float3 cross(float3 v0, float3 v1)
        {
            return (v0 * v1.yzx - v0.yzx * v1).yzx;
        }

        public static float det(float3x3 x)
        {
            return dot(cross(x.m0, x.m1), x.m2);
        }
        
        public static float3 mul(float3x3 x, float3 v)
        {
            return mad(x.m2, v.z, mad(x.m0, v.x, x.m1 * v.y));
        }

        public static float3x3 mul(float3x3 x0, float3x3 x1)
        {
            return new float3x3(mul(x0, x1.m0), mul(x0, x1.m1), mul(x0, x1.m2));
        }

        public static float3x3 transpose(float3x3 x)
        {
            return new float3x3(
                new float3(x.m0.x, x.m1.x, x.m2.x), 
                new float3(x.m0.y, x.m1.y, x.m2.y),
                new float3(x.m0.z, x.m1.z, x.m2.z));
        }

        public static float3x3 inverse(float3x3 x)
        {
            var scaleSquared = uniformScaleSquared(x);
            if (scaleSquared < epsilon_normal_square)
                return float3x3.zero;
            var scaleInv = rsqrt(new float3(scaleSquared));
            var xs = mulScale(x, scaleInv);
            if (!adjInverse(xs, out var i, epsilon_determinant))
            {
                i = svdInverse(xs);
            }
            i = mulScale(i, scaleInv);
            return i;
        }
    }

    // todo:keep this private?
    public static partial class math
    {
        public static float3 inverseScale(float3 s, float epsilon = epsilon_scale)
        {
            return select(rcp(s), new float3(0.0f), abs(s) < new float3(epsilon));
        }

        public static float uniformScaleSquared(float3x3 x)
        {
            return 0.333333f * (dot(x.m0, x.m0) + dot(x.m1, x.m1) + dot(x.m2, x.m2));
        }

        // post mul 3x3 with scale vector
        public static float3x3 mulScale(float3x3 x, float3 s)
        {
            return new float3x3(x.m0 * s.x, x.m1 * s.y, x.m2 * s.z);
        }

        // pre mul 3xe3 with scale vector
        public static float3x3 scaleMul(float3 s, float3x3 x)
        {
            return new float3x3(x.m0 * s, x.m1 * s, x.m2 * s);
        }
        
        // returns adjoint matrix
        public static float3x3 adj(float3x3 x, out float det)
        {
            float3x3 adjT;

            adjT.m0 = cross(x.m1, x.m2);
            adjT.m1 = cross(x.m2, x.m0);
            adjT.m2 = cross(x.m0, x.m1);

            det = dot(x.m0, adjT.m0);

            return transpose(adjT);
        }

        // inverts a non singular matrix. returns false if matrix is singular and i is set to adjoint
        // fastest inverse, when you know you deal with a non singular matrix
        public static bool adjInverse(float3x3 x, out float3x3 i, float epsilonDet)
        {
            i = adj(x, out var det);
            var c = abs(det) > epsilonDet;
            var detInv = select(new float3(rcp(det)), new float3(1.0f), c);
            i = scaleMul(detInv, i);
            return c;
        }
    }

    // todo:review
    public partial struct float3x3
    {
        // is it needed?
        public float3x3(float m00, float m01, float m02,
            float m10, float m11, float m12,
            float m20, float m21, float m22)
        {
            this.m0 = new float3(m00, m01, m02);
            this.m1 = new float3(m10, m11, m12);
            this.m2 = new float3(m20, m21, m22);
        }

        // do we need/want an operator 
        public static float3x3 operator *(float3x3 mat, float s)
        {
            return new float3x3(mat.m0 * s, mat.m1 * s, mat.m2 * s);
        }
    }

    // todo:review
    partial class math
    {   
        // this is unity specific
        // Unity left-handed coordinate system
        // Y up, Z facing and X left
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 left() { return new float3(1.0f,0.0f,0.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 up() { return new float3(0.0f,1.0f,0.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 forward() { return new float3(0.0f,0.0f,1.0f); }
        
        // is it needed as we have it on struct
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

        // todo: safe stuff? 
        // bit weird limit check here for yLength
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
    }
}
