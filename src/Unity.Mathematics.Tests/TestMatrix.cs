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
        public void float2x2_matrix_mul()
        {
            // http://www.wolframalpha.com/input/?i=%5B%5B1,2%5D,%5B3,4%5D%5D*%5B%5B21,22%5D,%5B23,24%5D%5D
            float2x2 a = float2x2(  1.0f, 2.0f,
                                    3.0f, 4.0f);

            float2x2 b = float2x2(  21.0f, 22.0f,
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
            float3x3 a = float3x3(  1.0f, 2.0f, 3.0f,
                                    4.0f, 5.0f, 6.0f,
                                    7.0f, 8.0f, 9.0f);

            float3x3 b = float3x3(  21.0f, 22.0f, 23.0f,
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
            float4x4 a = float4x4(   1.0f, 2.0f, 3.0f, 4.0f,
                                     5.0f, 6.0f, 7.0f, 8.0f,
                                     9.0f,10.0f,11.0f,12.0f,
                                    13.0f,14.0f,15.0f,16.0f);

            float4x4 b = float4x4(  21.0f,22.0f,23.0f,24.0f,
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
    }
}
