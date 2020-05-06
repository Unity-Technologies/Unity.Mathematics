# Changelog

## [Unreleased]
- Added math.project() and math.projectsafe() for vector projection.
- Added math.EPSILON, math.INFINITY, math.NAN and their double counterparts.
- Added [Serializable] to RigidTransform.
- Added math.ceillog2().
- Added math.floorlog2().
- Added float3.down, float3.forward, etc for Cartesian coordinate axes that match UnityEngine Vector3 equivalents.
- Added math.ispow2().
- Added half.MinValueAsHalf and half.MaxValueAsHalf to avoid having to explicitly convert from float.
- Added a float3x3 constructor which takes a float4x4 as input.
- Added [Serializable] to half types.
- Added some performance tests which can be run from the Unity test project.
- Added Random.CreateFromIndex() to assist in creating Random instances from loop indices.
- Fixed documentation bug where quaternion.RotateX/Y/Z referred to a float4x4 instead of quaternion.
- Fixed code generation bugs which could cause Windows and Mac to generate different test code.
- Updated documentation for math.countbits() to include equivalent names on Intel and ARM architectures to aid in discoverability.
- Internal: Added Unity.Mathematics.Geometry.Plane to represent planes in 3D space.
- Internal: Added more MinMaxAABB functionality from Unity.Physics.Aabb.
- Internal: Added Unity.Mathematics.Geometry.Math to hold static functions like AABB transformations.
- Internal: Added MinMaxAABB.

## [1.1.0] - 2019-07-08

- Release stable version

## [1.1.0-preview.1] - 2019-06-27

- Add new math.bitmask to return a bit mask from a bool4

## [1.0.1] - 2019-04-15

- Release stable version
- Modify all math constants (e.g `math.PI`) to provide float constant by default instead of double. Use for example `math.PI_DBL` to get the previous double constant.

## [1.0.0-preview.1] - 2019-02-28

- Fixed bug where modifications on prefabs could not be reverted for vector properties when using context menu in Inspector.
- Fixed structure of the package for internal validation
