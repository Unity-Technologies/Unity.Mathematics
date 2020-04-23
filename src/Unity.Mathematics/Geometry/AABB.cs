using System;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.Geometry
{
    [Serializable]
    internal partial struct AABB
    {
        public float3 Center;
        public float3 HalfExtents;

        public float3 Extents { get { return HalfExtents * 2; } }
        public float3 Min { get { return Center - HalfExtents; } }
        public float3 Max { get { return Center + HalfExtents; } }

        /// <summary>Returns a string representation of the AABB.</summary>
        public override string ToString()
        {
            return $"AABB(Center:{Center}, HalfExtents:{HalfExtents}";
        }

        public bool Contains(float3 point)
        {
            if (point[0] < Center[0] - HalfExtents[0])
                return false;
            if (point[0] > Center[0] + HalfExtents[0])
                return false;

            if (point[1] < Center[1] - HalfExtents[1])
                return false;
            if (point[1] > Center[1] + HalfExtents[1])
                return false;

            if (point[2] < Center[2] - HalfExtents[2])
                return false;
            if (point[2] > Center[2] + HalfExtents[2])
                return false;

            return true;
        }

        public bool Contains(AABB b)
        {
            return    Contains(b.Center + float3(-b.HalfExtents.x, -b.HalfExtents.y, -b.HalfExtents.z))
                   && Contains(b.Center + float3(-b.HalfExtents.x, -b.HalfExtents.y,  b.HalfExtents.z))
                   && Contains(b.Center + float3(-b.HalfExtents.x,  b.HalfExtents.y, -b.HalfExtents.z))
                   && Contains(b.Center + float3(-b.HalfExtents.x,  b.HalfExtents.y,  b.HalfExtents.z))
                   && Contains(b.Center + float3( b.HalfExtents.x, -b.HalfExtents.y, -b.HalfExtents.z))
                   && Contains(b.Center + float3( b.HalfExtents.x, -b.HalfExtents.y,  b.HalfExtents.z))
                   && Contains(b.Center + float3( b.HalfExtents.x,  b.HalfExtents.y, -b.HalfExtents.z))
                   && Contains(b.Center + float3( b.HalfExtents.x,  b.HalfExtents.y,  b.HalfExtents.z));
        }

        static float3 RotateExtents(float3 extents, float3 m0, float3 m1, float3 m2)
        {
            return math.abs(m0 * extents.x) + math.abs(m1 * extents.y) + math.abs(m2 * extents.z);
        }

        public static AABB Transform(float4x4 transform, AABB localBounds)
        {
            AABB transformed;
            transformed.HalfExtents = RotateExtents(localBounds.HalfExtents, transform.c0.xyz, transform.c1.xyz, transform.c2.xyz);
            transformed.Center = math.transform(transform, localBounds.Center);
            return transformed;
        }

        public float DistanceSq(float3 point)
        {
            return lengthsq(max(abs(point - Center), HalfExtents) - HalfExtents);
        }
    }
}
