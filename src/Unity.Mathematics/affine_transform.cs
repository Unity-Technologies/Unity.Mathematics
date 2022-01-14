using System;
using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    /// <summary>
    /// An affine transformation type.
    /// </summary>
    [Il2CppEagerStaticClassConstruction]
    [Serializable]
    public struct AffineTransform : IEquatable<AffineTransform>, IFormattable
    {
        /// <summary>
        /// The rotation and scale part of the affine transformation.
        /// </summary>
        public float3x3 rs;

        /// <summary>
        /// The translation part of the affine transformation.
        /// </summary>
        public float3 t;

        /// <summary>An AffineTransform representing the identity transform.</summary>
        public static readonly AffineTransform identity = new AffineTransform(float3.zero, float3x3.identity);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AffineTransform(float3 t, float3x3 rs)
        {
            this.rs = rs;
            this.t = t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AffineTransform(float3 t, quaternion r)
        {
            this.rs = float3x3(r);
            this.t = t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AffineTransform(float3 t, quaternion r, float3 s)
        {
            this.rs = svd.mulScale(math.float3x3(r), s);
            this.t = t;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AffineTransform(RigidTransform rigid)
        {
            rs = math.float3x3(rigid.rot);
            t = rigid.pos;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AffineTransform(float3x3 m)
        {
            rs = m;
            t = float3.zero;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AffineTransform(float3x4 m)
        {
            rs = math.float3x3(m.c0, m.c1, m.c2);
            t = m.c3;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public AffineTransform(float4x4 m)
        {
            rs = math.float3x3(m.c0.xyz, m.c1.xyz, m.c2.xyz);
            t = m.c3.xyz;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float3x4(AffineTransform m) { return float3x4(m.rs.c0, m.rs.c1, m.rs.c2, m.t); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4x4(AffineTransform m) { return float4x4(float4(m.rs.c0, 0f), float4(m.rs.c1, 0f), float4(m.rs.c2, 0f), float4(m.t, 1f)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(AffineTransform x) { return rs.Equals(x.rs) && t.Equals(x.t); }

        public override bool Equals(object o) { return o is AffineTransform converted && Equals(converted); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)hash(this); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("AffineTransform(({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f,  {6}f, {7}f, {8}f), ({9}f, {10}f, {11}f))",
                rs.c0.x, rs.c1.x, rs.c2.x, rs.c0.y, rs.c1.y, rs.c2.y, rs.c0.z, rs.c1.z, rs.c2.z, t.x, t.y, t.z
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("AffineTransform(({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f,  {6}f, {7}f, {8}f), ({9}f, {10}f, {11}f))",
                rs.c0.x.ToString(format, formatProvider), rs.c1.x.ToString(format, formatProvider), rs.c2.x.ToString(format, formatProvider),
                rs.c0.y.ToString(format, formatProvider), rs.c1.y.ToString(format, formatProvider), rs.c2.y.ToString(format, formatProvider),
                rs.c0.z.ToString(format, formatProvider), rs.c1.z.ToString(format, formatProvider), rs.c2.z.ToString(format, formatProvider),
                t.x.ToString(format, formatProvider), t.y.ToString(format, formatProvider), t.z.ToString(format, formatProvider)
            );
        }
    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform AffineTransform(float3 translation, quaternion rotation) { return AffineTransform(translation, rotation); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform AffineTransform(float3 translation, quaternion rotation, float3 scale) { return AffineTransform(translation, rotation, scale); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform AffineTransform(float3 translation, float3x3 rs) { return AffineTransform(translation, rs); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform AffineTransform(float4x4 m) { return AffineTransform(m); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform AffineTransform(float3x4 m) { return AffineTransform(m); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform AffineTransform(float3x3 m) { return AffineTransform(m); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform AffineTransform(RigidTransform m) { return AffineTransform(m); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4x4 float4x4(AffineTransform transform) { return float4x4(float4(transform.rs.c0, 0f), float4(transform.rs.c1, 0f), float4(transform.rs.c2, 0f), float4(transform.t, 1f)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3x4 float3x4(AffineTransform transform) { return float3x4(transform.rs.c0, transform.rs.c1, transform.rs.c2, transform.t); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mul(AffineTransform a, float3 v)
        {
            return a.t + mul(a.rs, v);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform mul(AffineTransform a, AffineTransform b)
        {
            return new AffineTransform(mul(a, b.t), mul(a.rs, b.rs));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform mul(float3x3 rs, AffineTransform b)
        {
            return new AffineTransform(mul(rs, b.t), mul(rs, b.rs));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform mul(AffineTransform a, float3x3 rs)
        {
            return new AffineTransform(a.t, mul(rs, a.rs));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static AffineTransform inverse(AffineTransform a)
        {
            AffineTransform inv;
            inv.rs = pseudoinverse(a.rs);
            inv.t = mul(inv.rs, -a.t);
            return inv;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void decompose(AffineTransform a, out float3 translation, out quaternion rotation, out float3 scale)
        {
            translation = a.t;
            rotation = math.rotation(a.rs);
            var sm = mul(float3x3(conjugate(rotation)), a.rs);
            scale = float3(sm.c0.x, sm.c1.y, sm.c2.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(AffineTransform a)
        {
            return hash(a.rs) + 0xC5C5394Bu * hash(a.t);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(AffineTransform a)
        {
            return hashwide(a.rs).xyzz + 0xC5C5394Bu * hashwide(a.t).xyzz;
        }
    }
}
