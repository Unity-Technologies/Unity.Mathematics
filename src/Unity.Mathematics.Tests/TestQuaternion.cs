using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using  Unity.Mathematics;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestQuaternion
    {           
        [Test]
        public void quatToMatrix_and_matrixToQuat_works(
            [Values(3, 0)] float qx,
            [Values(2, -1)] float qy,
            [Values(1, -2)] float qz,
            [Values(0, -3)] float qw)
        {
            var q = new quaternion(qx,qy,qz,qw);
            var x = math.quatToMatrix(q);
            var qo = math.matrixToQuat(x);
            q = math.normalize(q);
            qo = math.align(qo, q);                  
            
            // assert produced matrix is a rotation
            Assert.Less(math.abs(1.0f-math.det(x)), 1e-6f);
            // assert produced quat and original quat match
            Assert.Less(math.distance(qo.value, q.value), 1e-6f);
        }
    }
}