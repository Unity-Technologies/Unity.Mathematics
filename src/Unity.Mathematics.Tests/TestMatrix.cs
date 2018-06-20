using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestMatrix
    {
        [Test]
        public void float2x2_constructor_columns()
        {
            float2x2 a = float2x2(float2(1.0f, 2.0f),
                                  float2(3.0f, 4.0f));

            Assert.AreEqual(a.c0.x, 1.0f);
            Assert.AreEqual(a.c0.y, 2.0f);
            Assert.AreEqual(a.c1.x, 3.0f);
            Assert.AreEqual(a.c1.y, 4.0f);
        }

        [Test]
        public void float3x3_constructor_columns()
        {
            float3x3 a = float3x3(float3(1.0f, 2.0f, 3.0f),
                                  float3(4.0f, 5.0f, 6.0f),
                                  float3(7.0f, 8.0f, 9.0f));

            Assert.AreEqual(a.c0.x, 1.0f);
            Assert.AreEqual(a.c0.y, 2.0f);
            Assert.AreEqual(a.c0.z, 3.0f);
            Assert.AreEqual(a.c1.x, 4.0f);
            Assert.AreEqual(a.c1.y, 5.0f);
            Assert.AreEqual(a.c1.z, 6.0f);
            Assert.AreEqual(a.c2.x, 7.0f);
            Assert.AreEqual(a.c2.y, 8.0f);
            Assert.AreEqual(a.c2.z, 9.0f);
        }

        [Test]
        public void float4x4_constructor_columns()
        {
            float4x4 a = float4x4(float4( 1.0f,  2.0f,  3.0f,  4.0f),
                                  float4( 5.0f,  6.0f,  7.0f,  8.0f),
                                  float4( 9.0f, 10.0f, 11.0f, 12.0f),
                                  float4(13.0f, 14.0f, 15.0f, 16.0f));

            Assert.AreEqual(a.c0.x, 1.0f);
            Assert.AreEqual(a.c0.y, 2.0f);
            Assert.AreEqual(a.c0.z, 3.0f);
            Assert.AreEqual(a.c0.w, 4.0f);
            Assert.AreEqual(a.c1.x, 5.0f);
            Assert.AreEqual(a.c1.y, 6.0f);
            Assert.AreEqual(a.c1.z, 7.0f);
            Assert.AreEqual(a.c1.w, 8.0f);
            Assert.AreEqual(a.c2.x, 9.0f);
            Assert.AreEqual(a.c2.y, 10.0f);
            Assert.AreEqual(a.c2.z, 11.0f);
            Assert.AreEqual(a.c2.w, 12.0f);
            Assert.AreEqual(a.c3.x, 13.0f);
            Assert.AreEqual(a.c3.y, 14.0f);
            Assert.AreEqual(a.c3.z, 15.0f);
            Assert.AreEqual(a.c3.w, 16.0f);
        }

        [Test]
        public void float2x2_constructor_scalars()
        {
            float2x2 a = float2x2(1.0f, 2.0f,
                                  3.0f, 4.0f);

            Assert.AreEqual(a.c0.x, 1.0f);
            Assert.AreEqual(a.c1.x, 2.0f);
            Assert.AreEqual(a.c0.y, 3.0f);
            Assert.AreEqual(a.c1.y, 4.0f);
        }

        [Test]
        public void float3x3_constructor_scalars()
        {
            float3x3 a = float3x3(1.0f, 2.0f, 3.0f,
                                  4.0f, 5.0f, 6.0f,
                                  7.0f, 8.0f, 9.0f);

            Assert.AreEqual(a.c0.x, 1.0f);
            Assert.AreEqual(a.c1.x, 2.0f);
            Assert.AreEqual(a.c2.x, 3.0f);
            Assert.AreEqual(a.c0.y, 4.0f);
            Assert.AreEqual(a.c1.y, 5.0f);
            Assert.AreEqual(a.c2.y, 6.0f);
            Assert.AreEqual(a.c0.z, 7.0f);
            Assert.AreEqual(a.c1.z, 8.0f);
            Assert.AreEqual(a.c2.z, 9.0f);
        }

        [Test]
        public void float4x4_constructor_scalars()
        {
            float4x4 a = float4x4( 1.0f,  2.0f,  3.0f,  4.0f,
                                   5.0f,  6.0f,  7.0f,  8.0f,
                                   9.0f, 10.0f, 11.0f, 12.0f,
                                  13.0f, 14.0f, 15.0f, 16.0f);

            Assert.AreEqual(a.c0.x, 1.0f);
            Assert.AreEqual(a.c1.x, 2.0f);
            Assert.AreEqual(a.c2.x, 3.0f);
            Assert.AreEqual(a.c3.x, 4.0f);
            Assert.AreEqual(a.c0.y, 5.0f);
            Assert.AreEqual(a.c1.y, 6.0f);
            Assert.AreEqual(a.c2.y, 7.0f);
            Assert.AreEqual(a.c3.y, 8.0f);
            Assert.AreEqual(a.c0.z, 9.0f);
            Assert.AreEqual(a.c1.z, 10.0f);
            Assert.AreEqual(a.c2.z, 11.0f);
            Assert.AreEqual(a.c3.z, 12.0f);
            Assert.AreEqual(a.c0.w, 13.0f);
            Assert.AreEqual(a.c1.w, 14.0f);
            Assert.AreEqual(a.c2.w, 15.0f);
            Assert.AreEqual(a.c3.w, 16.0f);
        }

        [Test]
        public void float4x4_constructor_float3x3()
        {
            float3x3 rot = float3x3(1.0f, 2.0f, 3.0f,
                                    4.0f, 5.0f, 6.0f,
                                    7.0f, 8.0f, 9.0f);
            float3 pos = float3(10.0f, 11.0f, 12.0f);
            float4x4 m = float4x4(rot, pos);

            float4x4 r = float4x4(1.0f, 2.0f, 3.0f, 10.0f,
                                  4.0f, 5.0f, 6.0f, 11.0f,
                                  7.0f, 8.0f, 9.0f, 12.0f,
                                  0.0f, 0.0f, 0.0f, 1.0f);
            TestUtils.AreEqual(m, r);
        }


        [Test]
        public void float3x3_constructor_quaternion()
        {
            float3x3 m = float3x3(normalize(quaternion(1.0f, 2.5f, 3.3f, 4.6f)));

            float3x3 r = float3x3( 0.12774f, -0.64529f, 0.75318f,
                                   0.89975f,  0.39491f, 0.18575f,
                                  -0.41730f,  0.65394f, 0.63104f);

            TestUtils.AreEqual(m, r, 0.0001f);
        }

        [Test]
        public void float4x4_constructor_quaternion_position()
        {
            float4x4 m = float4x4(normalize(quaternion(1.0f, 2.5f, 3.3f, 4.6f)), float3(1.0f, 2.0f, 3.0f));

            float4x4 r = float4x4( 0.12774f, -0.64529f, 0.75318f, 1.0f,
                                   0.89975f,  0.39491f, 0.18575f, 2.0f,
                                  -0.41730f,  0.65394f, 0.63104f, 3.0f,
                                   0.0f,      0.0f,     0.0f,     1.0f);

            TestUtils.AreEqual(m, r, 0.0001f);
        }

        [Test]
        public void float2x2_identity()
        {
            float2x2 a = float2x2.identity;
            Assert.AreEqual(a.c0.x, 1.0f);
            Assert.AreEqual(a.c1.x, 0.0f);
            Assert.AreEqual(a.c0.y, 0.0f);
            Assert.AreEqual(a.c1.y, 1.0f);
        }

        [Test]
        public void float3x3_identity()
        {
            float3x3 a = float3x3.identity;
            Assert.AreEqual(a.c0.x, 1.0f);
            Assert.AreEqual(a.c1.x, 0.0f);
            Assert.AreEqual(a.c2.x, 0.0f);
            Assert.AreEqual(a.c0.y, 0.0f);
            Assert.AreEqual(a.c1.y, 1.0f);
            Assert.AreEqual(a.c2.y, 0.0f);
            Assert.AreEqual(a.c0.z, 0.0f);
            Assert.AreEqual(a.c1.z, 0.0f);
            Assert.AreEqual(a.c2.z, 1.0f);
        }

        [Test]
        public void float4x4_identity()
        {
            float4x4 a = float4x4.identity;
            Assert.AreEqual(a.c0.x, 1.0f);
            Assert.AreEqual(a.c1.x, 0.0f);
            Assert.AreEqual(a.c2.x, 0.0f);
            Assert.AreEqual(a.c3.x, 0.0f);
            Assert.AreEqual(a.c0.y, 0.0f);
            Assert.AreEqual(a.c1.y, 1.0f);
            Assert.AreEqual(a.c2.y, 0.0f);
            Assert.AreEqual(a.c3.y, 0.0f);
            Assert.AreEqual(a.c0.z, 0.0f);
            Assert.AreEqual(a.c1.z, 0.0f);
            Assert.AreEqual(a.c2.z, 1.0f);
            Assert.AreEqual(a.c3.z, 0.0f);
            Assert.AreEqual(a.c0.w, 0.0f);
            Assert.AreEqual(a.c1.w, 0.0f);
            Assert.AreEqual(a.c2.w, 0.0f);
            Assert.AreEqual(a.c3.w, 1.0f);
        }

        [Test]
        public void float2x2_rotate()
        {
            float epsilon = 0.0001f;
            float angle = 10.3f;
            float2x2 m = float2x2.rotate(angle);
            Assert.AreEqual(m.c0.x, cos(angle), epsilon);
            Assert.AreEqual(m.c0.y, sin(angle), epsilon);
            Assert.AreEqual(m.c1.x, -sin(angle), epsilon);
            Assert.AreEqual(m.c1.y, cos(angle), epsilon);
        }

        [Test]
        public void float3x3_rotate_x()
        {
            float epsilon = 0.0001f;
            float angle = 10.3f;
            float3x3 m = float3x3.rotateX(angle);
            Assert.AreEqual(m.c0.x, 1.0f, epsilon);
            Assert.AreEqual(m.c0.y, 0.0f, epsilon);
            Assert.AreEqual(m.c0.z, 0.0f, epsilon);
            Assert.AreEqual(m.c1.x, 0.0f, epsilon);
            Assert.AreEqual(m.c1.y, cos(angle), epsilon);
            Assert.AreEqual(m.c1.z, sin(angle), epsilon);
            Assert.AreEqual(m.c2.x, 0.0f, epsilon);
            Assert.AreEqual(m.c2.y, -sin(angle), epsilon);
            Assert.AreEqual(m.c2.z, cos(angle), epsilon);
        }

        [Test]
        public void float3x3_rotate_y()
        {
            float epsilon = 0.0001f;
            float angle = 10.3f;
            float3x3 m = float3x3.rotateY(angle);
            Assert.AreEqual(m.c0.x, cos(angle), epsilon);
            Assert.AreEqual(m.c0.y, 0.0f, epsilon);
            Assert.AreEqual(m.c0.z, -sin(angle), epsilon);
            Assert.AreEqual(m.c1.x, 0.0f, epsilon);
            Assert.AreEqual(m.c1.y, 1.0f, epsilon);
            Assert.AreEqual(m.c1.z, 0.0f, epsilon);
            Assert.AreEqual(m.c2.x, sin(angle), epsilon);
            Assert.AreEqual(m.c2.y, 0.0f, epsilon);
            Assert.AreEqual(m.c2.z, cos(angle), epsilon);
        }

        [Test]
        public void float3x3_rotate_z()
        {
            float epsilon = 0.0001f;
            float angle = 10.3f;
            float3x3 m = float3x3.rotateZ(angle);
            Assert.AreEqual(m.c0.x, cos(angle), epsilon);
            Assert.AreEqual(m.c0.y, sin(angle), epsilon);
            Assert.AreEqual(m.c0.z, 0.0f, epsilon);
            Assert.AreEqual(m.c1.x, -sin(angle), epsilon);
            Assert.AreEqual(m.c1.y, cos(angle), epsilon);
            Assert.AreEqual(m.c1.z, 0.0f, epsilon);
            Assert.AreEqual(m.c2.x, 0.0f, epsilon);
            Assert.AreEqual(m.c2.y, 0.0f, epsilon);
            Assert.AreEqual(m.c2.z, 1.0f, epsilon);
        }

        [Test]
        public void float4x4_rotate_x()
        {
            float epsilon = 0.0001f;
            float angle = 10.3f;
            float4x4 m = float4x4.rotateX(angle);
            Assert.AreEqual(m.c0.x, 1.0f, epsilon);
            Assert.AreEqual(m.c0.y, 0.0f, epsilon);
            Assert.AreEqual(m.c0.z, 0.0f, epsilon);
            Assert.AreEqual(m.c0.w, 0.0f, epsilon);
            Assert.AreEqual(m.c1.x, 0.0f, epsilon);
            Assert.AreEqual(m.c1.y, cos(angle), epsilon);
            Assert.AreEqual(m.c1.z, sin(angle), epsilon);
            Assert.AreEqual(m.c1.w, 0.0f, epsilon);
            Assert.AreEqual(m.c2.x, 0.0f, epsilon);
            Assert.AreEqual(m.c2.y, -sin(angle), epsilon);
            Assert.AreEqual(m.c2.z, cos(angle), epsilon);
            Assert.AreEqual(m.c2.w, 0.0f, epsilon);
            Assert.AreEqual(m.c3.x, 0.0f, epsilon);
            Assert.AreEqual(m.c3.y, 0.0f, epsilon);
            Assert.AreEqual(m.c3.z, 0.0f, epsilon);
            Assert.AreEqual(m.c3.w, 1.0f, epsilon);
        }

        [Test]
        public void float4x4_rotate_y()
        {
            float epsilon = 0.0001f;
            float angle = 10.3f;
            float4x4 m = float4x4.rotateY(angle);
            Assert.AreEqual(m.c0.x, cos(angle), epsilon);
            Assert.AreEqual(m.c0.y, 0.0f, epsilon);
            Assert.AreEqual(m.c0.z, -sin(angle), epsilon);
            Assert.AreEqual(m.c0.w, 0.0f, epsilon);
            Assert.AreEqual(m.c1.x, 0.0f, epsilon);
            Assert.AreEqual(m.c1.y, 1.0f, epsilon);
            Assert.AreEqual(m.c1.z, 0.0f, epsilon);
            Assert.AreEqual(m.c1.w, 0.0f, epsilon);
            Assert.AreEqual(m.c2.x, sin(angle), epsilon);
            Assert.AreEqual(m.c2.y, 0.0f, epsilon);
            Assert.AreEqual(m.c2.z, cos(angle), epsilon);
            Assert.AreEqual(m.c2.w, 0.0f);
            Assert.AreEqual(m.c3.x, 0.0f);
            Assert.AreEqual(m.c3.y, 0.0f);
            Assert.AreEqual(m.c3.z, 0.0f);
            Assert.AreEqual(m.c3.w, 1.0f);
        }

        [Test]
        public void float4x4_rotate_z()
        {
            float epsilon = 0.0001f;
            float angle = 10.3f;
            float4x4 m = float4x4.rotateZ(angle);
            Assert.AreEqual(m.c0.x, cos(angle), epsilon);
            Assert.AreEqual(m.c0.y, sin(angle), epsilon);
            Assert.AreEqual(m.c0.z, 0.0f, epsilon);
            Assert.AreEqual(m.c0.w, 0.0f, epsilon);
            Assert.AreEqual(m.c1.x, -sin(angle), epsilon);
            Assert.AreEqual(m.c1.y, cos(angle), epsilon);
            Assert.AreEqual(m.c1.z, 0.0f, epsilon);
            Assert.AreEqual(m.c1.w, 0.0f, epsilon);
            Assert.AreEqual(m.c2.x, 0.0f, epsilon);
            Assert.AreEqual(m.c2.y, 0.0f, epsilon);
            Assert.AreEqual(m.c2.z, 1.0f, epsilon);
            Assert.AreEqual(m.c2.w, 0.0f, epsilon);
            Assert.AreEqual(m.c3.x, 0.0f, epsilon);
            Assert.AreEqual(m.c3.y, 0.0f, epsilon);
            Assert.AreEqual(m.c3.z, 0.0f, epsilon);
            Assert.AreEqual(m.c3.w, 1.0f, epsilon);
        }


        // rotation by (-50, 28, 39) degrees from Max
        static internal float3 test_angles = math.radians(float3(-50.0f, 28.0f, 39.0f));

        static internal float3x3 test3x3_xyz = float3x3( 0.686179155968f, -0.684009078513f, -0.247567660300f,
                                                0.555656924414f,  0.273213475262f,  0.785238676636f,
                                               -0.469471562786f, -0.676377097075f,  0.567547772692f);

        static internal float3x3 test3x3_xzy = float3x3( 0.686179155968f, -0.716805468125f, -0.123887395569f,
                                                0.629320391050f,  0.499539794942f,  0.595328345266f,
                                               -0.364847929038f, -0.486466765705f,  0.793874092373f);

        static internal float3x3 test3x3_yxz = float3x3( 0.912505475649f, -0.404519349890f, -0.0608099701904f,
                                                0.276167195792f,  0.499539794942f,  0.8210917568930f,
                                               -0.301770503659f, -0.766044443119f,  0.5675477726920f);

        static internal float3x3 test3x3_yzx = float3x3( 0.68617915596800f, -0.629320391050f, 0.364847929038f,
                                               -0.00246669562435f,  0.499539794942f, 0.866287428445f,
                                               -0.72742840288700f, -0.595328345266f, 0.341221453011f);

        static internal float3x3 test3x3_zxy = float3x3( 0.459852836288f, -0.835146653037f, 0.301770503659f,
                                                0.404519349890f,  0.499539794942f, 0.766044443119f,
                                               -0.790505828266f, -0.230195701935f, 0.567547772692f);

        static internal float3x3 test3x3_zyx = float3x3( 0.686179155968f, -0.555656924414f, 0.469471562786f,
                                                0.125029621267f,  0.725866114623f, 0.676377097075f,
                                               -0.716607116711f, -0.405418013897f, 0.567547772692f);


        static internal float4x4 test4x4_xyz = float4x4(test3x3_xyz, float3(0, 0, 0));
        static internal float4x4 test4x4_xzy = float4x4(test3x3_xzy, float3(0, 0, 0));
        static internal float4x4 test4x4_yxz = float4x4(test3x3_yxz, float3(0, 0, 0));
        static internal float4x4 test4x4_yzx = float4x4(test3x3_yzx, float3(0, 0, 0));
        static internal float4x4 test4x4_zxy = float4x4(test3x3_zxy, float3(0, 0, 0));
        static internal float4x4 test4x4_zyx = float4x4(test3x3_zyx, float3(0, 0, 0));


        [Test]
        public void float3x3_euler()
        {
            float3x3 m0_xyz = float3x3.eulerXYZ(test_angles);
            float3x3 m0_xzy = float3x3.eulerXZY(test_angles);
            float3x3 m0_yxz = float3x3.eulerYXZ(test_angles);
            float3x3 m0_yzx = float3x3.eulerYZX(test_angles);
            float3x3 m0_zxy = float3x3.eulerZXY(test_angles);
            float3x3 m0_zyx = float3x3.eulerZYX(test_angles);

            float3x3 m1 = float3x3.euler(test_angles);
            float3x3 m1_xyz = float3x3.euler(test_angles, RotationOrder.XYZ);
            float3x3 m1_xzy = float3x3.euler(test_angles, RotationOrder.XZY);
            float3x3 m1_yxz = float3x3.euler(test_angles, RotationOrder.YXZ);
            float3x3 m1_yzx = float3x3.euler(test_angles, RotationOrder.YZX);
            float3x3 m1_zxy = float3x3.euler(test_angles, RotationOrder.ZXY);
            float3x3 m1_zyx = float3x3.euler(test_angles, RotationOrder.ZYX);


            float3x3 m2_xyz = float3x3.eulerXYZ(test_angles.x, test_angles.y, test_angles.z);
            float3x3 m2_xzy = float3x3.eulerXZY(test_angles.x, test_angles.y, test_angles.z);
            float3x3 m2_yxz = float3x3.eulerYXZ(test_angles.x, test_angles.y, test_angles.z);
            float3x3 m2_yzx = float3x3.eulerYZX(test_angles.x, test_angles.y, test_angles.z);
            float3x3 m2_zxy = float3x3.eulerZXY(test_angles.x, test_angles.y, test_angles.z);
            float3x3 m2_zyx = float3x3.eulerZYX(test_angles.x, test_angles.y, test_angles.z);

            float3x3 m3 = float3x3.euler(test_angles.x, test_angles.y, test_angles.z);
            float3x3 m3_xyz = float3x3.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XYZ);
            float3x3 m3_xzy = float3x3.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XZY);
            float3x3 m3_yxz = float3x3.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YXZ);
            float3x3 m3_yzx = float3x3.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YZX);
            float3x3 m3_zxy = float3x3.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZXY);
            float3x3 m3_zyx = float3x3.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZYX);


            TestUtils.AreEqual(m0_xyz, test3x3_xyz, 0.0001f);
            TestUtils.AreEqual(m0_yzx, test3x3_yzx, 0.0001f);
            TestUtils.AreEqual(m0_zxy, test3x3_zxy, 0.0001f);
            TestUtils.AreEqual(m0_xzy, test3x3_xzy, 0.0001f);
            TestUtils.AreEqual(m0_yxz, test3x3_yxz, 0.0001f);
            TestUtils.AreEqual(m0_zyx, test3x3_zyx, 0.0001f);

            TestUtils.AreEqual(m1, test3x3_zxy, 0.0001f);
            TestUtils.AreEqual(m1_xyz, test3x3_xyz, 0.0001f);
            TestUtils.AreEqual(m1_yzx, test3x3_yzx, 0.0001f);
            TestUtils.AreEqual(m1_zxy, test3x3_zxy, 0.0001f);
            TestUtils.AreEqual(m1_xzy, test3x3_xzy, 0.0001f);
            TestUtils.AreEqual(m1_yxz, test3x3_yxz, 0.0001f);
            TestUtils.AreEqual(m1_zyx, test3x3_zyx, 0.0001f);


            TestUtils.AreEqual(m2_xyz, test3x3_xyz, 0.0001f);
            TestUtils.AreEqual(m2_yzx, test3x3_yzx, 0.0001f);
            TestUtils.AreEqual(m2_zxy, test3x3_zxy, 0.0001f);
            TestUtils.AreEqual(m2_xzy, test3x3_xzy, 0.0001f);
            TestUtils.AreEqual(m2_yxz, test3x3_yxz, 0.0001f);
            TestUtils.AreEqual(m2_zyx, test3x3_zyx, 0.0001f);

            TestUtils.AreEqual(m3, test3x3_zxy, 0.0001f);
            TestUtils.AreEqual(m3_xyz, test3x3_xyz, 0.0001f);
            TestUtils.AreEqual(m3_yzx, test3x3_yzx, 0.0001f);
            TestUtils.AreEqual(m3_zxy, test3x3_zxy, 0.0001f);
            TestUtils.AreEqual(m3_xzy, test3x3_xzy, 0.0001f);
            TestUtils.AreEqual(m3_yxz, test3x3_yxz, 0.0001f);
            TestUtils.AreEqual(m3_zyx, test3x3_zyx, 0.0001f);
        }

        [Test]
        public void float4x4_euler()
        {
            float4x4 m0_xyz = float4x4.eulerXYZ(test_angles);
            float4x4 m0_xzy = float4x4.eulerXZY(test_angles);
            float4x4 m0_yxz = float4x4.eulerYXZ(test_angles);
            float4x4 m0_yzx = float4x4.eulerYZX(test_angles);
            float4x4 m0_zxy = float4x4.eulerZXY(test_angles);
            float4x4 m0_zyx = float4x4.eulerZYX(test_angles);

            float4x4 m1 = float4x4.euler(test_angles);
            float4x4 m1_xyz = float4x4.euler(test_angles, RotationOrder.XYZ);
            float4x4 m1_xzy = float4x4.euler(test_angles, RotationOrder.XZY);
            float4x4 m1_yxz = float4x4.euler(test_angles, RotationOrder.YXZ);
            float4x4 m1_yzx = float4x4.euler(test_angles, RotationOrder.YZX);
            float4x4 m1_zxy = float4x4.euler(test_angles, RotationOrder.ZXY);
            float4x4 m1_zyx = float4x4.euler(test_angles, RotationOrder.ZYX);

            
            float4x4 m2_xyz = float4x4.eulerXYZ(test_angles.x, test_angles.y, test_angles.z);
            float4x4 m2_xzy = float4x4.eulerXZY(test_angles.x, test_angles.y, test_angles.z);
            float4x4 m2_yxz = float4x4.eulerYXZ(test_angles.x, test_angles.y, test_angles.z);
            float4x4 m2_yzx = float4x4.eulerYZX(test_angles.x, test_angles.y, test_angles.z);
            float4x4 m2_zxy = float4x4.eulerZXY(test_angles.x, test_angles.y, test_angles.z);
            float4x4 m2_zyx = float4x4.eulerZYX(test_angles.x, test_angles.y, test_angles.z);

            float4x4 m3 = float4x4.euler(test_angles.x, test_angles.y, test_angles.z);
            float4x4 m3_xyz = float4x4.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XYZ);
            float4x4 m3_xzy = float4x4.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.XZY);
            float4x4 m3_yxz = float4x4.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YXZ);
            float4x4 m3_yzx = float4x4.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.YZX);
            float4x4 m3_zxy = float4x4.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZXY);
            float4x4 m3_zyx = float4x4.euler(test_angles.x, test_angles.y, test_angles.z, RotationOrder.ZYX);

            
            TestUtils.AreEqual(m0_xyz, test4x4_xyz, 0.0001f);
            TestUtils.AreEqual(m0_yzx, test4x4_yzx, 0.0001f);
            TestUtils.AreEqual(m0_zxy, test4x4_zxy, 0.0001f);
            TestUtils.AreEqual(m0_xzy, test4x4_xzy, 0.0001f);
            TestUtils.AreEqual(m0_yxz, test4x4_yxz, 0.0001f);
            TestUtils.AreEqual(m0_zyx, test4x4_zyx, 0.0001f);

            TestUtils.AreEqual(m1, test4x4_zxy, 0.0001f);
            TestUtils.AreEqual(m1_xyz, test4x4_xyz, 0.0001f);
            TestUtils.AreEqual(m1_yzx, test4x4_yzx, 0.0001f);
            TestUtils.AreEqual(m1_zxy, test4x4_zxy, 0.0001f);
            TestUtils.AreEqual(m1_xzy, test4x4_xzy, 0.0001f);
            TestUtils.AreEqual(m1_yxz, test4x4_yxz, 0.0001f);
            TestUtils.AreEqual(m1_zyx, test4x4_zyx, 0.0001f);

            
            TestUtils.AreEqual(m2_xyz, test4x4_xyz, 0.0001f);
            TestUtils.AreEqual(m2_yzx, test4x4_yzx, 0.0001f);
            TestUtils.AreEqual(m2_zxy, test4x4_zxy, 0.0001f);
            TestUtils.AreEqual(m2_xzy, test4x4_xzy, 0.0001f);
            TestUtils.AreEqual(m2_yxz, test4x4_yxz, 0.0001f);
            TestUtils.AreEqual(m2_zyx, test4x4_zyx, 0.0001f);

            TestUtils.AreEqual(m3, test4x4_zxy, 0.0001f);
            TestUtils.AreEqual(m3_xyz, test4x4_xyz, 0.0001f);
            TestUtils.AreEqual(m3_yzx, test4x4_yzx, 0.0001f);
            TestUtils.AreEqual(m3_zxy, test4x4_zxy, 0.0001f);
            TestUtils.AreEqual(m3_xzy, test4x4_xzy, 0.0001f);
            TestUtils.AreEqual(m3_yxz, test4x4_yxz, 0.0001f);
            TestUtils.AreEqual(m3_zyx, test4x4_zyx, 0.0001f);
        }

        [Test]
        public void float2x2_scale()
        {
            float2x2 m = float2x2(1.0f, 2.0f,
                                  3.0f, 4.0f);

            float2x2 r0 = float2x2(2.0f, 4.0f,
                                   6.0f, 8.0f);

            float2x2 r1 = float2x2(2.0f,  4.0f,
                                   9.0f, 12.0f);

            float2x2 a = mul(float2x2.scale(2.0f), m);
            float2x2 b = mul(float2x2.scale(2.0f, 3.0f), m);
            float2x2 c = mul(float2x2.scale(2.0f, 3.0f), m);

            TestUtils.AreEqual(a, r0);
            TestUtils.AreEqual(b, r1);
            TestUtils.AreEqual(c, r1);
        }

        [Test]
        public void float3x3_scale()
        {
            float3x3 m = float3x3(1.0f, 2.0f, 3.0f,
                                  4.0f, 5.0f, 6.0f,
                                  7.0f, 8.0f, 9.0f);


            float3x3 r0 = float3x3( 2.0f,  4.0f,  6.0f,
                                    8.0f, 10.0f, 12.0f,
                                   14.0f, 16.0f, 18.0f);

            float3x3 r1 = float3x3( 2.0f,  4.0f,  6.0f,
                                   12.0f, 15.0f, 18.0f,
                                   28.0f, 32.0f, 36.0f);


            float3x3 a = mul(float3x3.scale(2.0f), m);
            float3x3 b = mul(float3x3.scale(2.0f, 3.0f, 4.0f), m);
            float3x3 c = mul(float3x3.scale(2.0f, 3.0f, 4.0f), m);

            TestUtils.AreEqual(a, r0);
            TestUtils.AreEqual(b, r1);
            TestUtils.AreEqual(c, r1);
        }

        [Test]
        public void float4x4_scale()
        {
            float4x4 m = float4x4( 1.0f,  2.0f,  3.0f,  4.0f,
                                   5.0f,  6.0f,  7.0f,  8.0f,
                                   9.0f, 10.0f, 11.0f, 12.0f,
                                  13.0f, 14.0f, 15.0f, 16.0f);

            float4x4 r0 = float4x4( 2.0f,  4.0f,  6.0f,  8.0f,
                                   10.0f, 12.0f, 14.0f, 16.0f,
                                   18.0f, 20.0f, 22.0f, 24.0f,
                                   13.0f, 14.0f, 15.0f, 16.0f);

            float4x4 r1 = float4x4( 2.0f,  4.0f,  6.0f,  8.0f,
                                   15.0f, 18.0f, 21.0f, 24.0f,
                                   36.0f, 40.0f, 44.0f, 48.0f,
                                   13.0f, 14.0f, 15.0f, 16.0f);

            float4x4 a = mul(float4x4.scale(2.0f), m);
            float4x4 b = mul(float4x4.scale(2.0f, 3.0f, 4.0f), m);
            float4x4 c = mul(float4x4.scale(2.0f, 3.0f, 4.0f), m);

            TestUtils.AreEqual(a, r0);
            TestUtils.AreEqual(b, r1);
            TestUtils.AreEqual(c, r1);
        }

        [Test]
        public void float2x2_matrix_mul()
        {
            // http://www.wolframalpha.com/input/?i=%5B%5B1,2%5D,%5B3,4%5D%5D*%5B%5B21,22%5D,%5B23,24%5D%5D
            float2x2 a = float2x2(1.0f, 2.0f,
                                  3.0f, 4.0f);

            float2x2 b = float2x2(21.0f, 22.0f,
                                  23.0f, 24.0f);

            float2x2 c = mul(a, b);
            Assert.AreEqual(c.c0.x, 67.0f);
            Assert.AreEqual(c.c1.x, 70.0f);

            Assert.AreEqual(c.c0.y, 155.0f);
            Assert.AreEqual(c.c1.y, 162.0f);
        }

        [Test]
        public void float3x3_matrix_mul()
        {
            // http://www.wolframalpha.com/input/?i=%5B%5B1,2,3%5D,%5B4,5,6%5D,%5B7,8,9%5D%5D*%5B%5B21,22,23%5D,%5B24,25,26%5D,%5B27,28,29%5D%5D
            float3x3 a = float3x3(1.0f, 2.0f, 3.0f,
                                  4.0f, 5.0f, 6.0f,
                                  7.0f, 8.0f, 9.0f);

            float3x3 b = float3x3(21.0f, 22.0f, 23.0f,
                                  24.0f, 25.0f, 26.0f,
                                  27.0f, 28.0f, 29.0f);

            float3x3 c = mul(a, b);
            Assert.AreEqual(c.c0.x, 150.0f);
            Assert.AreEqual(c.c1.x, 156.0f);
            Assert.AreEqual(c.c2.x, 162.0f);

            Assert.AreEqual(c.c0.y, 366.0f);
            Assert.AreEqual(c.c1.y, 381.0f);
            Assert.AreEqual(c.c2.y, 396.0f);

            Assert.AreEqual(c.c0.z, 582.0f);
            Assert.AreEqual(c.c1.z, 606.0f);
            Assert.AreEqual(c.c2.z, 630.0f);
        }

        [Test]
        public void float4x4_matrix_mul()
        {
            // https://fogbugz.unity3d.com/f/cases/1041176/
            // http://www.wolframalpha.com/input/?i=%5B%5B1,2,3,4%5D,%5B5,6,7,8%5D,%5B9,10,11,12%5D,%5B13,14,15,16%5D%5D*%5B%5B21,22,23,24%5D,%5B25,26,27,28%5D,%5B29,30,31,32%5D,%5B33,34,35,36%5D%5D
            float4x4 a = float4x4( 1.0f, 2.0f, 3.0f, 4.0f,
                                   5.0f, 6.0f, 7.0f, 8.0f,
                                   9.0f,10.0f,11.0f,12.0f,
                                  13.0f,14.0f,15.0f,16.0f);

            float4x4 b = float4x4(21.0f,22.0f,23.0f,24.0f,
                                  25.0f,26.0f,27.0f,28.0f,
                                  29.0f,30.0f,31.0f,32.0f,
                                  33.0f,34.0f,35.0f,36.0f);

            float4x4 c = mul(a, b);
            Assert.AreEqual(c.c0.x, 290.0f);
            Assert.AreEqual(c.c1.x, 300.0f);
            Assert.AreEqual(c.c2.x, 310.0f);
            Assert.AreEqual(c.c3.x, 320.0f);

            Assert.AreEqual(c.c0.y, 722.0f);
            Assert.AreEqual(c.c1.y, 748.0f);
            Assert.AreEqual(c.c2.y, 774.0f);
            Assert.AreEqual(c.c3.y, 800.0f);

            Assert.AreEqual(c.c0.z, 1154.0f);
            Assert.AreEqual(c.c1.z, 1196.0f);
            Assert.AreEqual(c.c2.z, 1238.0f);
            Assert.AreEqual(c.c3.z, 1280.0f);

            Assert.AreEqual(c.c0.w, 1586.0f);
            Assert.AreEqual(c.c1.w, 1644.0f);
            Assert.AreEqual(c.c2.w, 1702.0f);
            Assert.AreEqual(c.c3.w, 1760.0f);
        }

        [Test]
        public void float2x2_transpose()
        {
            float2x2 a = float2x2(1.0f, 2.0f,
                                  3.0f, 4.0f);

            float2x2 b = transpose(a);

            Assert.AreEqual(b.c0.x, 1.0f);
            Assert.AreEqual(b.c1.x, 3.0f);
            Assert.AreEqual(b.c0.y, 2.0f);
            Assert.AreEqual(b.c1.y, 4.0f);
        }

        [Test]
        public void float3x3_transpose()
        {
            float3x3 a = float3x3(1.0f, 2.0f, 3.0f,
                                  4.0f, 5.0f, 6.0f,
                                  7.0f, 8.0f, 9.0f);

            float3x3 b = transpose(a);

            Assert.AreEqual(b.c0.x, 1.0f);
            Assert.AreEqual(b.c1.x, 4.0f);
            Assert.AreEqual(b.c2.x, 7.0f);
            Assert.AreEqual(b.c0.y, 2.0f);
            Assert.AreEqual(b.c1.y, 5.0f);
            Assert.AreEqual(b.c2.y, 8.0f);
            Assert.AreEqual(b.c0.z, 3.0f);
            Assert.AreEqual(b.c1.z, 6.0f);
            Assert.AreEqual(b.c2.z, 9.0f);
        }

        [Test]
        public void float4x4_transpose()
        {
            float4x4 a = float4x4( 1.0f,  2.0f,  3.0f,  4.0f,
                                   5.0f,  6.0f,  7.0f,  8.0f,
                                   9.0f, 10.0f, 11.0f, 12.0f,
                                  13.0f, 14.0f, 15.0f, 16.0f);

            float4x4 b = transpose(a);

            Assert.AreEqual(b.c0.x, 1.0f);
            Assert.AreEqual(b.c1.x, 5.0f);
            Assert.AreEqual(b.c2.x, 9.0f);
            Assert.AreEqual(b.c3.x, 13.0f);
            Assert.AreEqual(b.c0.y, 2.0f);
            Assert.AreEqual(b.c1.y, 6.0f);
            Assert.AreEqual(b.c2.y, 10.0f);
            Assert.AreEqual(b.c3.y, 14.0f);
            Assert.AreEqual(b.c0.z, 3.0f);
            Assert.AreEqual(b.c1.z, 7.0f);
            Assert.AreEqual(b.c2.z, 11.0f);
            Assert.AreEqual(b.c3.z, 15.0f);
            Assert.AreEqual(b.c0.w, 4.0f);
            Assert.AreEqual(b.c1.w, 8.0f);
            Assert.AreEqual(b.c2.w, 12.0f);
            Assert.AreEqual(b.c3.w, 16.0f);
        }

        [Test]
        public void float2x2_inverse()
        {
            float2x2 a = float2x2( 0.542968f,  0.867379f,
                                  -0.270153f, -0.912324f);

            float2x2 invA = float2x2( 3.49499f,  3.32281f,
                                     -1.03492f, -2.08004f);

            float2x2 r = inverse(a);

            float epsilon = 0.0001f;
            Assert.AreEqual(invA.c0.x, r.c0.x, epsilon);
            Assert.AreEqual(invA.c1.x, r.c1.x, epsilon);

            Assert.AreEqual(invA.c0.y, r.c0.y, epsilon);
            Assert.AreEqual(invA.c1.y, r.c1.y, epsilon);
        }

        [Test]
        public void float3x3_inverse()
        {
            float3x3 a = float3x3( 0.542968f, 0.867379f, 0.526616f,
                                  -0.270153f,-0.912324f, 0.148933f,
                                   0.816727f, 0.905933f, 0.902392f);

            float3x3 invA = float3x3(-15.91790f,-5.077350f,10.1273f,
                                       6.07051f, 0.994556f,-3.70676f,
                                       8.31247f, 3.596890f,-4.33645f);

            float3x3 r = inverse(a);

            float epsilon = 0.0001f;
            Assert.AreEqual(invA.c0.x, r.c0.x, epsilon);
            Assert.AreEqual(invA.c1.x, r.c1.x, epsilon);
            Assert.AreEqual(invA.c2.x, r.c2.x, epsilon);

            Assert.AreEqual(invA.c0.y, r.c0.y, epsilon);
            Assert.AreEqual(invA.c1.y, r.c1.y, epsilon);
            Assert.AreEqual(invA.c2.y, r.c2.y, epsilon);

            Assert.AreEqual(invA.c0.z, r.c0.z, epsilon);
            Assert.AreEqual(invA.c1.z, r.c1.z, epsilon);
            Assert.AreEqual(invA.c2.z, r.c2.z, epsilon);
        }

        [Test]
        public void float4x4_inverse()
        {
            float4x4 a = float4x4( 0.542968f, 0.867379f, 0.526616f,-0.943083f,
                                  -0.270153f,-0.912324f, 0.148933f, 0.299995f,
                                   0.816727f, 0.905933f, 0.902392f,-0.060931f,
                                  -0.254780f, 0.604543f, 0.563340f,-0.383911f);

            float4x4 invA = float4x4( 0.548951f, 0.126367f, 0.487260f,-1.327100f,
                                     -0.582901f,-1.108000f, 0.188292f, 0.536211f,
                                      0.001968f, 0.970678f, 0.528701f, 0.669759f,
                                     -1.279310f,-0.404277f, 0.748937f, 0.103102f);

            float4x4 r = inverse(a);

            float epsilon = 0.0001f;
            Assert.AreEqual(invA.c0.x, r.c0.x, epsilon);
            Assert.AreEqual(invA.c1.x, r.c1.x, epsilon);
            Assert.AreEqual(invA.c2.x, r.c2.x, epsilon);
            Assert.AreEqual(invA.c3.x, r.c3.x, epsilon);

            Assert.AreEqual(invA.c0.y, r.c0.y, epsilon);
            Assert.AreEqual(invA.c1.y, r.c1.y, epsilon);
            Assert.AreEqual(invA.c2.y, r.c2.y, epsilon);
            Assert.AreEqual(invA.c3.y, r.c3.y, epsilon);

            Assert.AreEqual(invA.c0.z, r.c0.z, epsilon);
            Assert.AreEqual(invA.c1.z, r.c1.z, epsilon);
            Assert.AreEqual(invA.c2.z, r.c2.z, epsilon);
            Assert.AreEqual(invA.c3.z, r.c3.z, epsilon);

            Assert.AreEqual(invA.c0.w, r.c0.w, epsilon);
            Assert.AreEqual(invA.c1.w, r.c1.w, epsilon);
            Assert.AreEqual(invA.c2.w, r.c2.w, epsilon);
            Assert.AreEqual(invA.c3.w, r.c3.w, epsilon);
        }

        [Test]
        public void float2x2_determinant()
        {
            float2x2 a = float2x2(0.542968f, 0.867379f,
                                  -0.270153f, -0.912324f);

            float det = determinant(a);
            Assert.AreEqual(det, -0.2610378f, 0.0001f);
        }

        [Test]
        public void float3x3_determinant()
        {
            float3x3 a = float3x3( 0.542968f,  0.867379f, 0.526616f,
                                  -0.270153f, -0.912324f, 0.148933f,
                                   0.816727f,  0.905933f, 0.902392f);

            float det = determinant(a);
            Assert.AreEqual(det, 0.06019618f, 0.0001f);
        }

        [Test]
        public void float4x4_determinant()
        {
            float4x4 a = float4x4( 0.542968f,  0.867379f, 0.526616f, -0.943083f,
                                  -0.270153f, -0.912324f, 0.148933f,  0.299995f,
                                   0.816727f,  0.905933f, 0.902392f, -0.060931f,
                                  -0.254780f,  0.604543f, 0.563340f, -0.383911f);

            float det = determinant(a);
            Assert.AreEqual(det, 0.5838502f, 0.0001f);
        }
    }
}
