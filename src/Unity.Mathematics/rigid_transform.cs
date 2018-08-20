using System;
using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public struct RigidTransform
    {
        public quaternion rot;
        public float3 pos;

        public static readonly RigidTransform identity = new RigidTransform(quaternion.identity, float3.zero);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RigidTransform(quaternion rotation, float3 translation)
        {
            this.rot = rotation;
            this.pos = translation;
        }

        public RigidTransform(float3x3 rotation, float3 translation)
        {
            this.rot = new quaternion(rotation);
            this.pos = translation;
        }

        public RigidTransform(float4x4 transform)
        {
            this.rot = new quaternion(transform);
            this.pos = transform.c3.xyz;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform axisAngle(float3 axis, float angle) { return new RigidTransform(quaternion.axisAngle(axis, angle), float3.zero); }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerXYZ(float3 xyz) { return new RigidTransform(quaternion.eulerXYZ(xyz), float3.zero); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerXZY(float3 xyz) { return new RigidTransform(quaternion.eulerXZY(xyz), float3.zero); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerYXZ(float3 xyz) { return new RigidTransform(quaternion.eulerYXZ(xyz), float3.zero); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerYZX(float3 xyz) { return new RigidTransform(quaternion.eulerYZX(xyz), float3.zero); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerZXY(float3 xyz) { return new RigidTransform(quaternion.eulerZXY(xyz), float3.zero); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerZYX(float3 xyz) { return new RigidTransform(quaternion.eulerZYX(xyz), float3.zero); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerXYZ(float x, float y, float z) { return eulerXYZ(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerXZY(float x, float y, float z) { return eulerXZY(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerYXZ(float x, float y, float z) { return eulerYXZ(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerYZX(float x, float y, float z) { return eulerYZX(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerZXY(float x, float y, float z) { return eulerZXY(float3(x, y, z)); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform eulerZYX(float x, float y, float z) { return eulerZYX(float3(x, y, z)); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform euler(float3 xyz, RotationOrder order = RotationOrder.ZXY)
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
                    return RigidTransform.identity;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform euler(float x, float y, float z, RotationOrder order = RotationOrder.ZXY)
        {
            return euler(float3(x, y, z), order);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform rotateX(float angle)
        {
            return new RigidTransform(quaternion.rotateX(angle), float3.zero);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform rotateY(float angle)
        {
            return new RigidTransform(quaternion.rotateY(angle), float3.zero);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform rotateZ(float angle)
        {
            return new RigidTransform(quaternion.rotateZ(angle), float3.zero);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform scale(float s)
        {
            return new RigidTransform(quaternion.scale(s), float3.zero);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform translate(float3 vector)
        {
            return new RigidTransform(quaternion.identity, vector);
        }


        // Equals
        public bool Equals(RigidTransform rhs) { return rot.Equals(rhs.rot) && pos.Equals(rhs.pos); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((RigidTransform)o); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }

        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("RigidTransform(({0}f, {1}f, {2}f, {3}f),  ({4}f, {5}f, {6}f))",
                rot.value.x, rot.value.y, rot.value.z, rot.value.w, pos.x, pos.y, pos.z);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float4x4(({0}f, {1}f, {2}f, {3}f),  ({4}f, {5}f, {6}f))",
                rot.value.x.ToString(format, formatProvider),
                rot.value.y.ToString(format, formatProvider),
                rot.value.z.ToString(format, formatProvider),
                rot.value.w.ToString(format, formatProvider),
                pos.x.ToString(format, formatProvider),
                pos.y.ToString(format, formatProvider),
                pos.z.ToString(format, formatProvider));
        }
    }

    public static partial class math
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RigidTransform(quaternion rot, float3 pos) { return new RigidTransform(rot, pos); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RigidTransform(float3x3 rotation, float3 translation) { return new RigidTransform(rotation, translation); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RigidTransform(float4x4 transform) { return new RigidTransform(transform); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform inverse(RigidTransform t)
        {
            quaternion invRotation = inverse(t.rot);
            float3 invTranslation = mul(invRotation, -t.pos);
            return new RigidTransform(invRotation, invTranslation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform mul(RigidTransform a, RigidTransform b)
        {
            return new RigidTransform(mul(a.rot, b.rot), mul(a.rot, b.pos) + a.pos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float4 mul(RigidTransform a, float4 pos)
        {
            return float4(mul(a.rot, pos.xyz) + a.pos * pos.w, pos.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 rotate(RigidTransform a, float3 dir)
        {
            return mul(a.rot, dir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 transform(RigidTransform a, float3 pos)
        {
            return mul(a.rot, pos) + a.pos;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(RigidTransform t)
        {
            return hash(t.rot) + 0xC5C5394Bu * hash(t.pos);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hash_wide(RigidTransform t)
        {
            return hash_wide(t.rot) + 0xC5C5394Bu * hash_wide(t.pos).xyzz;
        }
    }
}