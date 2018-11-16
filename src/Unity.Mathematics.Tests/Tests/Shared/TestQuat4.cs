using Unity.Mathematics.SOA;
using NUnit.Framework;
using static Unity.Mathematics.math;
using Burst.Compiler.IL.Tests;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class Quaternion4Tests
    {
        [TestCompiler]
        public unsafe void TestSlerp()
        {
            quaternion* a_s = stackalloc quaternion[4];
            quaternion* b_s = stackalloc quaternion[4];
            quaternion* c_s = stackalloc quaternion[4];

            for (int i = 0; i < 4; ++i)
            {
                a_s[i] = quaternion.AxisAngle(new float3(1.0f, 0.0f, 0.0f), i * 0.25f);
                b_s[i] = quaternion.AxisAngle(new float3(0.0f, 1.0f, 0.0f), i * 0.25f);
                c_s[i] = math.slerp(a_s[i], b_s[i], 0.5f);
            }

            float4 ax = new float4(a_s[0].value.x, a_s[1].value.x, a_s[2].value.x, a_s[3].value.x);
            float4 ay = new float4(a_s[0].value.y, a_s[1].value.y, a_s[2].value.y, a_s[3].value.y);
            float4 az = new float4(a_s[0].value.z, a_s[1].value.z, a_s[2].value.z, a_s[3].value.z);
            float4 aw = new float4(a_s[0].value.w, a_s[1].value.w, a_s[2].value.w, a_s[3].value.w);
            float4 bx = new float4(b_s[0].value.x, b_s[1].value.x, b_s[2].value.x, b_s[3].value.x);
            float4 by = new float4(b_s[0].value.y, b_s[1].value.y, b_s[2].value.y, b_s[3].value.y);
            float4 bz = new float4(b_s[0].value.z, b_s[1].value.z, b_s[2].value.z, b_s[3].value.z);
            float4 bw = new float4(b_s[0].value.w, b_s[1].value.w, b_s[2].value.w, b_s[3].value.w);

            float4 cx, cy, cz, cw;

            quaternion4.slerp4(
                ax, ay, az, aw,
                bx, by, bz, bw,
                new float4(0.5f),
                out cx, out cy, out cz, out cw);

            TestUtils.AreEqual(c_s[0].value.x, cx.x, 0.0001);
            TestUtils.AreEqual(c_s[1].value.x, cx.y, 0.0001);
            TestUtils.AreEqual(c_s[2].value.x, cx.z, 0.0001);
            TestUtils.AreEqual(c_s[3].value.x, cx.w, 0.0001);

            TestUtils.AreEqual(c_s[0].value.y, cy.x, 0.0001);
            TestUtils.AreEqual(c_s[1].value.y, cy.y, 0.0001);
            TestUtils.AreEqual(c_s[2].value.y, cy.z, 0.0001);
            TestUtils.AreEqual(c_s[3].value.y, cy.w, 0.0001);

            TestUtils.AreEqual(c_s[0].value.z, cz.x, 0.0001);
            TestUtils.AreEqual(c_s[1].value.z, cz.y, 0.0001);
            TestUtils.AreEqual(c_s[2].value.z, cz.z, 0.0001);
            TestUtils.AreEqual(c_s[3].value.z, cz.w, 0.0001);

            TestUtils.AreEqual(c_s[0].value.w, cw.x, 0.0001);
            TestUtils.AreEqual(c_s[1].value.w, cw.y, 0.0001);
            TestUtils.AreEqual(c_s[2].value.w, cw.z, 0.0001);
            TestUtils.AreEqual(c_s[3].value.w, cw.w, 0.0001);
        }

        [TestCompiler]
        public unsafe void TestNlerp()
        {
            quaternion* a_s = stackalloc quaternion[4];
            quaternion* b_s = stackalloc quaternion[4];
            quaternion* c_s = stackalloc quaternion[4];

            for (int i = 0; i < 4; ++i)
            {
                a_s[i] = quaternion.AxisAngle(new float3(1.0f, 0.0f, 0.0f), i * 0.25f);
                b_s[i] = quaternion.AxisAngle(new float3(0.0f, 0.72f, 0.72f), i * 0.25f);
                c_s[i] = math.nlerp(a_s[i], b_s[i], 0.5f);
            }

            float4 ax = new float4(a_s[0].value.x, a_s[1].value.x, a_s[2].value.x, a_s[3].value.x);
            float4 ay = new float4(a_s[0].value.y, a_s[1].value.y, a_s[2].value.y, a_s[3].value.y);
            float4 az = new float4(a_s[0].value.z, a_s[1].value.z, a_s[2].value.z, a_s[3].value.z);
            float4 aw = new float4(a_s[0].value.w, a_s[1].value.w, a_s[2].value.w, a_s[3].value.w);
            float4 bx = new float4(b_s[0].value.x, b_s[1].value.x, b_s[2].value.x, b_s[3].value.x);
            float4 by = new float4(b_s[0].value.y, b_s[1].value.y, b_s[2].value.y, b_s[3].value.y);
            float4 bz = new float4(b_s[0].value.z, b_s[1].value.z, b_s[2].value.z, b_s[3].value.z);
            float4 bw = new float4(b_s[0].value.w, b_s[1].value.w, b_s[2].value.w, b_s[3].value.w);

            float4 cx, cy, cz, cw;

            quaternion4.nlerp4(
                ax, ay, az, aw,
                bx, by, bz, bw,
                new float4(0.5f),
                out cx, out cy, out cz, out cw);

            TestUtils.AreEqual(c_s[0].value.x, cx.x, 0.0001);
            TestUtils.AreEqual(c_s[1].value.x, cx.y, 0.0001);
            TestUtils.AreEqual(c_s[2].value.x, cx.z, 0.0001);
            TestUtils.AreEqual(c_s[3].value.x, cx.w, 0.0001);

            TestUtils.AreEqual(c_s[0].value.y, cy.x, 0.0001);
            TestUtils.AreEqual(c_s[1].value.y, cy.y, 0.0001);
            TestUtils.AreEqual(c_s[2].value.y, cy.z, 0.0001);
            TestUtils.AreEqual(c_s[3].value.y, cy.w, 0.0001);

            TestUtils.AreEqual(c_s[0].value.z, cz.x, 0.0001);
            TestUtils.AreEqual(c_s[1].value.z, cz.y, 0.0001);
            TestUtils.AreEqual(c_s[2].value.z, cz.z, 0.0001);
            TestUtils.AreEqual(c_s[3].value.z, cz.w, 0.0001);

            TestUtils.AreEqual(c_s[0].value.w, cw.x, 0.0001);
            TestUtils.AreEqual(c_s[1].value.w, cw.y, 0.0001);
            TestUtils.AreEqual(c_s[2].value.w, cw.z, 0.0001);
            TestUtils.AreEqual(c_s[3].value.w, cw.w, 0.0001);
        }
    }
}