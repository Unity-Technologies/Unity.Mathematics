using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics.Extras
{
    /// <summary>
    /// A plane represented by a unit length normal vector and a distance along the normal from the origin.
    /// </summary>
    /// <remarks>
    /// A plane splits the 3D space in half.  The normal vector points to the positive half and the other half is
    /// considered negative.
    /// </remarks>
    // A plane described by a normal and a distance from the origin
    [DebuggerDisplay("{Normal}, {Distance}")]
    [Serializable]
    internal struct NormalizedPlane
    {
        /// <summary>
        /// A plane in the form Ax + By + Cz + Dw = 0.
        /// </summary>
        /// <remarks>
        /// Stores the coefficients A, B, C, D where (A, B, C) is a unit length normal and D is distance from the
        /// origin along the normal.
        /// </remarks>
        public float4 NormalAndDistance;

        /// <summary>
        /// Constructs a plane with a normal vector and distance from the origin.
        /// </summary>
        /// <param name="normal">A non-zero vector that is perpendicular to the plane.  It may be any length.</param>
        /// <param name="distance">Distance from the origin along the normal.  A negative value moves the plane in the
        /// same direction as the normal while a positive value moves it in the opposite direction.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NormalizedPlane(float3 normal, float distance)
        {
            NormalAndDistance = new float4(normal, distance) * math.rsqrt(math.lengthsq(normal.xyz));
        }

        /// <summary>
        /// Constructs a plane with a normal vector and a point that lies in the plane.
        /// </summary>
        /// <param name="normal">A non-zero vector that is perpendicular to the plane.  It may be any length.</param>
        /// <param name="pointInPlane">A point that lies in the plane.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NormalizedPlane(float3 normal, float3 pointInPlane)
        {
            normal = math.normalize(normal);
            NormalAndDistance = new float4(normal, -math.dot(normal, pointInPlane));
        }

        /// <summary>
        /// Constructs a plane with two vectors and a point that all lie in the plane.
        /// </summary>
        /// <param name="vector1InPlane">A non-zero vector that lies in the plane.  It may be any length.</param>
        /// <param name="vector2InPlane">A non-zero vector that lies in the plane.  It may be any length and must not be a scalar multiple of <paramref name="vector1InPlane"/>.</param>
        /// <param name="pointInPlane">A point that lies in the plane.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public NormalizedPlane(float3 vector1InPlane, float3 vector2InPlane, float3 pointInPlane)
        : this(math.cross(vector1InPlane, vector2InPlane), pointInPlane)
        {
        }

        /// <summary>
        /// Get/set the normal vector of the plane.
        /// </summary>
        public float3 Normal
        {
            get => NormalAndDistance.xyz;
            set => NormalAndDistance.xyz = value;
        }

        /// <summary>
        /// Get/set the distance of the plane from the origin.  May be a negative value.
        /// </summary>
        public float Distance
        {
            get => NormalAndDistance.w;
            set => NormalAndDistance.w = value;
        }

        /// <summary>
        /// Get the signed distance from the point to the plane.
        /// </summary>
        /// <remarks>
        /// Distance is positive if point is on side of the plane the normal points to, negative if on the opposite side
        /// and zero if the point lies in the plane.  Avoid comparing equality with 0.0f when testing if a point lies exactly
        /// in the plane and use an approximate comparison instead.
        /// </remarks>
        /// <param name="point">Point to find the signed distance with.</param>
        /// <returns>Signed distance of the point from the plane.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float SignedDistanceToPoint(float3 point)
        {
            return math.dot(NormalAndDistance, new float4(point, 1.0f));
        }

        /// <summary>
        /// Projects the given point onto the plane.
        /// </summary>
        /// <remarks>
        /// The result is the position closest to the point that still lies in the plane.
        /// </remarks>
        /// <param name="point">Point to project onto the plane.</param>
        /// <returns>Projected point that's inside the plane.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public float3 Projection(float3 point)
        {
            return point - Normal * SignedDistanceToPoint(point);
        }

        /// <summary>
        /// Flips the plane so the normal points in the opposite direction.
        /// </summary>
        public NormalizedPlane Flipped => new NormalizedPlane { NormalAndDistance = -NormalAndDistance };

        /// <summary>
        /// Implicitly converts a <see cref="NormalizedPlane"/> to <see cref="float4"/>.
        /// </summary>
        /// <param name="plane">Plane to convert.</param>
        /// <returns>A <see cref="float4"/> representing the plane.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator float4(NormalizedPlane plane) => plane.NormalAndDistance;
    }
}
