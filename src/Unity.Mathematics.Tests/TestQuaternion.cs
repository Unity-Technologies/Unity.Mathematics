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
    class TestQuaternion
    {
        [Test]
        public void quaternion_constructor()
        {
            quaternion q = quaternion(1.0f, 2.0f, 3.0f, 4.0f);

            Assert.AreEqual(q.value.x, 1.0f);
            Assert.AreEqual(q.value.y, 2.0f);
            Assert.AreEqual(q.value.z, 3.0f);
            Assert.AreEqual(q.value.w, 4.0f);
        }
    }
}
