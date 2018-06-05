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
    }
}
