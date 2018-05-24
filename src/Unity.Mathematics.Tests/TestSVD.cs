using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using  Unity.Mathematics;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestSVD
    {
        const float svdTolerance = 1e-4f;

        private static void CHECK_CLOSE(float a, float b, float tol)
        {
            Assert.Less(math.abs(a - b), tol);
        }

        private static void CHECK_SINGULAR(float3x3 x)
        {
            var d = math.det(x);
            CHECK_CLOSE(0, d, svdTolerance);
        }

        private static void CHECK_PERNOSE_12(float3x3 A, float3x3 G) // AGA=A
        {
            var testA = math.mul(math.mul(A, G), A);

            CHECK_CLOSE(A.m0.x, testA.m0.x, svdTolerance);
            CHECK_CLOSE(A.m0.y, testA.m0.y, svdTolerance);
            CHECK_CLOSE(A.m0.z, testA.m0.z, svdTolerance);
            CHECK_CLOSE(A.m1.x, testA.m1.x, svdTolerance);
            CHECK_CLOSE(A.m1.y, testA.m1.y, svdTolerance);
            CHECK_CLOSE(A.m1.z, testA.m1.z, svdTolerance);
            CHECK_CLOSE(A.m2.x, testA.m2.x, svdTolerance);
            CHECK_CLOSE(A.m2.y, testA.m2.y, svdTolerance);
            CHECK_CLOSE(A.m2.z, testA.m2.z, svdTolerance);
        }

        private static void CHECK_PERNOSE_34(float3x3 A, float3x3 G) // TRANSPOSE(AG) = AG
        {
            var AG = math.mul(A, G);
            var testAG = math.transpose(AG);

            CHECK_CLOSE(AG.m0.x, testAG.m0.x, svdTolerance);
            CHECK_CLOSE(AG.m0.y, testAG.m0.y, svdTolerance);
            CHECK_CLOSE(AG.m0.z, testAG.m0.z, svdTolerance);
            CHECK_CLOSE(AG.m1.x, testAG.m1.x, svdTolerance);
            CHECK_CLOSE(AG.m1.y, testAG.m1.y, svdTolerance);
            CHECK_CLOSE(AG.m1.z, testAG.m1.z, svdTolerance);
            CHECK_CLOSE(AG.m2.x, testAG.m2.x, svdTolerance);
            CHECK_CLOSE(AG.m2.y, testAG.m2.y, svdTolerance);
            CHECK_CLOSE(AG.m2.z, testAG.m2.z, svdTolerance);
        }

        [Test]
        public void svdInverse_WorksFor_Non_Singular_float3x3()
        {
            float3x3 matrix;
            matrix.m0 = new float3(9, 1, 2);
            matrix.m1 = new float3(3, 8, 4);
            matrix.m2 = new float3(5, 6, 7);

            var inv = math.svdInverse(matrix);
            var testI = math.mul(matrix, inv);

            CHECK_CLOSE(1, (float) testI.m0.x, svdTolerance);
            CHECK_CLOSE(0, (float) testI.m0.y, svdTolerance);
            CHECK_CLOSE(0, (float) testI.m0.z, svdTolerance);
            CHECK_CLOSE(0, (float) testI.m1.x, svdTolerance);
            CHECK_CLOSE(1, (float) testI.m1.y, svdTolerance);
            CHECK_CLOSE(0, (float) testI.m1.z, svdTolerance);
            CHECK_CLOSE(0, (float) testI.m2.x, svdTolerance);
            CHECK_CLOSE(0, (float) testI.m2.y, svdTolerance);
            CHECK_CLOSE(1, (float) testI.m2.z, svdTolerance);
        }

        [Test]
        public void svdInverse_WorksFor_Null_Column_float3x3()
        {
            float3x3 matrix;
            matrix.m0 = new float3(9, 1, 0);
            matrix.m1 = new float3(3, 8, 0);
            matrix.m2 = new float3(5, 6, 0);

            CHECK_SINGULAR(matrix);

            var inv = math.svdInverse(matrix);

            CHECK_PERNOSE_12(matrix, inv);
            CHECK_PERNOSE_12(inv, matrix);
            CHECK_PERNOSE_34(matrix, inv);
            CHECK_PERNOSE_34(inv, matrix);
        }

        [Test]
        public void svdInverse_WorksFor_Null_Row_float3x3()
        {
            float3x3 matrix;
            matrix.m0 = new float3(9, 1, 2);
            matrix.m1 = new float3(0, 0, 0);
            matrix.m2 = new float3(5, 6, 7);

            CHECK_SINGULAR(matrix);

            var inv = math.svdInverse(matrix);

            CHECK_PERNOSE_12(matrix, inv);
            CHECK_PERNOSE_12(inv, matrix);
            CHECK_PERNOSE_34(matrix, inv);
            CHECK_PERNOSE_34(inv, matrix);
        }

        [Test]
        public void svdInverse_WorksFor_Linear_Dependent_Column_float3x3()
        {
            float3x3 matrix;
            matrix.m0 = new float3(9, 4, 2);
            matrix.m1 = new float3(3, 8, 4);
            matrix.m2 = new float3(5, 14, 7);

            CHECK_SINGULAR(matrix);

            var inv = math.svdInverse(matrix);

            CHECK_PERNOSE_12(matrix, inv);
            CHECK_PERNOSE_12(inv, matrix);
            CHECK_PERNOSE_34(matrix, inv);
            CHECK_PERNOSE_34(inv, matrix);
        }

        [Test]
        public void svdInverse_WorksFor_Linear_Dependent_Row_float3x3()
        {
            float3x3 matrix;
            matrix.m0 = new float3(9, 1, 2);
            matrix.m1 = new float3(10, 12, 14);
            matrix.m2 = new float3(5, 6, 7);

            CHECK_SINGULAR(matrix);

            var inv = math.svdInverse(matrix);

            CHECK_PERNOSE_12(matrix, inv);
            CHECK_PERNOSE_12(inv, matrix);
            CHECK_PERNOSE_34(matrix, inv);
            CHECK_PERNOSE_34(inv, matrix);
        }

        [Test]
        public void svdInverse_WorksFor_Rotated_Zero_Scale_float3x3()
        {
            var q102030 = math.eulerToQuat(math.radians(new float3(10, 20, 30)));
            var rm102030 = math.quatToMatrix(q102030);

            var parent = math.mulScale(rm102030, new float3(1, 1, 0));
            var matrix = math.mul(parent, rm102030);

            CHECK_SINGULAR(matrix);

            var inv = math.svdInverse(matrix);

            CHECK_PERNOSE_12(matrix, inv);
            CHECK_PERNOSE_12(inv, matrix);
            CHECK_PERNOSE_34(matrix, inv);
            CHECK_PERNOSE_34(inv, matrix);
        }

        // Case 928598: The errors appear, when GameObject has a child with ParticleSystem which is rotated along the y-axis to -180 and is moved
        [Test]
        public void svdRotation_WorksFor_X180Y0Z181_float3x3()
        {
            var qi = math.eulerToQuat(math.radians(new float3(180.0f, 0, 181.0f)));
            var  rm = math.quatToMatrix(qi);
            var qo = math.svdRotation(rm);
   
            qi = math.normalize(qi);
            qo = math.align(qo, qi);                  
            
             // assert produced quat and original quat match
            Assert.Less(math.distance(qo.value, qi.value), svdTolerance);
        }

        // Case 938548: Assertion failed on expression: 'CompareApproximately(det, 1.0F, .005f)' when scaling system to 0 on at least 2 axes
        [Test]
        public void svdRotation_WorksFor_0_Scale_YZ_float3x3()
        {
            var qi = math.eulerToQuat(math.radians(new float3(10, 20, 30)));
            var rm = math.quatToMatrix(qi);
            var rmScaled = math.mulScale(rm, new float3(1, 0, 0));
            var qo = math.svdRotation(rmScaled);

            var rmi = math.quatToMatrix(qi);
            var rmo = math.quatToMatrix(qo);

            var d = math.length(rmi.m0 - rmo.m0);
            CHECK_CLOSE(0, d, svdTolerance);
        }
    }
}