using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class math
    {
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        private static void condSwap(bool c, ref float x, ref float y)
        {
            var z = x;
            x = select(x, y, c);
            y = select(y, z, c);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        private static void condSwap(bool c, ref float3 x, ref float3 y)
        {
            var z = x;
            x = select(x, y, c);
            y = select(y, z, c);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        private static void condNegSwap(bool c, ref float3 x, ref float3 y)
        {
            var z = -x;
            x = select(x, y, c);
            y = select(y, z, c);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        private static quaternion condNegSwapQuat(bool c, quaternion q, float4 mask)
        {
            const float halfSqrt2 = 0.707106781186548f;
            var qr = select(quaternion.identity.value, mask * halfSqrt2, c);
            return mul(q, new quaternion(qr));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        private static void sortSigularValues(ref float3x3 b, ref quaternion v)
        {
            var l0 = dot(b.m0, b.m0);
            var l1 = dot(b.m1, b.m1);
            var l2 = dot(b.m2, b.m2);

            var c = l0 < l1;
            condNegSwap(c, ref b.m0, ref b.m1);
            v = condNegSwapQuat(c, v, new float4(0, 0, 1, 1));
            condSwap(c, ref l0, ref l1);

            c = l0 < l2;
            condNegSwap(c, ref b.m0, ref b.m2);
            v = condNegSwapQuat(c, v, new float4(0, -1, 0, 1));
            condSwap(c, ref l0, ref l2);

            c = l1 < l2;
            condNegSwap(c, ref b.m1, ref b.m2);
            v = condNegSwapQuat(c, v, new float4(1, 0, 0, 1));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        private static quaternion approxGivensQuat(float3 pq, float4 mask)
        {
            const float c8 = 0.923879532511287f; // cos(pi/8)
            const float s8 = 0.38268343236509f; // sin(pi/8)
            const float g = 5.82842712474619f; // 3 + 2 * sqrt(2)

            var ch = 2.0f * (pq.x - pq.y); // approx cos(a/2)
            var sh = pq.z; // approx sin(a/2)
            var r = select(new float4(s8, s8, s8, c8), new float4(sh, sh, sh, ch), g * sh * sh  < ch * ch) * mask;
            return new quaternion(normalize(r));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        private static quaternion qrGivensQuat(float2 pq, float4 mask)
        {
            var a1 = pq.x;
            var a2 = pq.y;
            var l = sqrt(a1 * a1 + a2 * a2);
            var sh = select(0.0f, a2, l > epsilon_normal);
            var ch = abs(a1) + max(l, epsilon_normal);
            condSwap(a1 < 0.0f, ref sh, ref ch);
            var r = new float4(sh, sh, sh, ch) * mask;
            return new quaternion(normalize(r));
        }

        private static quaternion givensQRFactorization(float3x3 b, ref float3x3 r)
        {
            var u = qrGivensQuat(new float2(b.m0.x, b.m0.y), new float4(0, 0, 1, 1));
            var qmt = quatToMatrix(conj(u));
            r = mul(qmt, b);

            var q = qrGivensQuat(new float2(r.m0.x, r.m0.z), new float4(0, -1, 0, 1));
            u = mul(u, q);
            qmt = quatToMatrix(conj(q));
            r = mul(qmt, r);

            q = qrGivensQuat(new float2(r.m1.y, r.m1.z), new float4(1, 0, 0, 1));
            u = mul(u, q);
            qmt = quatToMatrix(conj(q));
            r = mul(qmt, r);

            return u;
        }

        private static quaternion jacobiIteration(ref float3x3 s, int count = 5)
        {
            var qm = float3x3.zero;
            var q = quaternion.identity;
            var v = quaternion.identity;

            for (var iter = 0; iter < count; iter++)
            {
                q = approxGivensQuat(new float3(s.m0.x, s.m1.y, s.m0.y), new float4(0, 0, 1, 1));
                v = mul(v, q);
                qm = quatToMatrix(q);
                s = mul(mul(transpose(qm), s), qm);

                q = approxGivensQuat(new float3(s.m1.y, s.m2.z, s.m1.z), new float4(1, 0, 0, 1));
                v = mul(v, q);
                qm = quatToMatrix(q);
                s = mul(mul(transpose(qm), s), qm);

                q = approxGivensQuat(new float3(s.m2.z, s.m0.x, s.m2.x), new float4(0, 1, 0, 1));
                v = mul(v, q);
                qm = quatToMatrix(q);
                s = mul(mul(transpose(qm), s), qm);
            }

            return v;
        }

        private static float3 singularValuesDecomposition(float3x3 a, ref quaternion u, ref quaternion v)
        {
            var e = float3x3.zero;
            var s = mul(transpose(a), a);
            v = jacobiIteration(ref s);
            var b = quatToMatrix(v);
            b = mul(a, b);
            sortSigularValues(ref b, ref v);
            u = givensQRFactorization(b, ref e);

            return new float3(e.m0.x, e.m1.y, e.m2.z);
        }

        public static float3x3 svdInverse(float3x3 a)
        {
            var u = quaternion.identity;
            var v = quaternion.identity;
            var e = singularValuesDecomposition(a, ref u, ref v);

            var um = quatToMatrix(u);
            var vm = quatToMatrix(v);

            return mul(vm, scaleMul(inverseScale(e, epsilon_determinant), transpose(um)));
        }

        public static quaternion svdRotation(float3x3 a)
        {
            var u = quaternion.identity;
            var v = quaternion.identity;

            singularValuesDecomposition(a, ref u, ref v);

            return mul(u, conj(v));
        }
    }
}