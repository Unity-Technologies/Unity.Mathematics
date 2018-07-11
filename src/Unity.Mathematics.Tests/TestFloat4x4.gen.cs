// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestFloat4x4
    {
        [Test]
        public void float4x4_operator_equal_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4x4_operator_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4x4_operator_equal_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            bool4x4 r0 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void float4x4_operator_not_equal_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4x4_operator_not_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4x4_operator_not_equal_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            bool4x4 r0 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void float4x4_operator_less_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            bool4x4 r0 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            bool4x4 r1 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            bool4x4 r2 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            bool4x4 r3 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4x4_operator_less_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            bool4x4 r0 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            bool4x4 r2 = bool4x4(true, false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            bool4x4 r3 = bool4x4(true, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4x4_operator_less_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            bool4x4 r0 = bool4x4(true, false, false, true);
            TestUtils.AreEqual(a0 < b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            bool4x4 r1 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 < b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            bool4x4 r0 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            bool4x4 r1 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            bool4x4 r2 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            bool4x4 r3 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            bool4x4 r0 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a0 > b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            bool4x4 r2 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            bool4x4 r3 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            bool4x4 r0 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            bool4x4 r1 = bool4x4(false, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void float4x4_operator_less_equal_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            bool4x4 r0 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            bool4x4 r1 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            bool4x4 r2 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            bool4x4 r3 = bool4x4(true, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4x4_operator_less_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            bool4x4 r0 = bool4x4(true, true, true, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            bool4x4 r1 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            bool4x4 r2 = bool4x4(true, false, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            bool4x4 r3 = bool4x4(true, false, true, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4x4_operator_less_equal_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            bool4x4 r0 = bool4x4(true, false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            bool4x4 r1 = bool4x4(true, false, false, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            bool4x4 r2 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            bool4x4 r3 = bool4x4(true, true, true, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_equal_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            bool4x4 r0 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            bool4x4 r1 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            bool4x4 r2 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            bool4x4 r3 = bool4x4(false, false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_equal_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            bool4x4 r0 = bool4x4(false, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            bool4x4 r1 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            bool4x4 r2 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            bool4x4 r3 = bool4x4(false, true, false, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4x4_operator_greater_equal_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            bool4x4 r0 = bool4x4(false, true, true, false);
            TestUtils.AreEqual(a0 >= b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            bool4x4 r1 = bool4x4(false, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            bool4x4 r2 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            bool4x4 r3 = bool4x4(false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void float4x4_operator_add_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            float4x4 r0 = float4x4(726.5341f, 72.18677f, 720.582642f, 635.625244f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            float4x4 r1 = float4x4(259.443054f, -202.884644f, 640.4171f, -555.204f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            float4x4 r2 = float4x4(137.629761f, 199.146484f, -352.709747f, -280.71524f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            float4x4 r3 = float4x4(87.50296f, 410.884735f, -779.887939f, 137.7608f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4x4_operator_add_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            float4x4 r0 = float4x4(726.5341f, 248.8866f, 722.786743f, 912.2038f);
            TestUtils.AreEqual(a0 + b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            float4x4 r1 = float4x4(645.915649f, 635.625244f, 403.1845f, 631.8456f);
            TestUtils.AreEqual(a1 + b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            float4x4 r2 = float4x4(-202.884644f, 538.0173f, 248.245789f, -171.381134f);
            TestUtils.AreEqual(a2 + b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            float4x4 r3 = float4x4(-348.923157f, 137.629761f, -241.294434f, 364.3944f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4x4_operator_add_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(726.5341f, 75.93414f, 549.8343f, 739.251343f);
            TestUtils.AreEqual(a0 + b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(645.915649f, 505.953857f, 273.513123f, 502.1742f);
            TestUtils.AreEqual(a1 + b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-202.884644f, 189.286682f, -100.4848f, -520.1117f);
            TestUtils.AreEqual(a2 + b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(-348.923157f, -135.246887f, -514.1711f, 91.51776f);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void float4x4_operator_sub_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            float4x4 r0 = float4x4(-172.952454f, -473.900146f, 204.338379f, 139.961792f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            float4x4 r1 = float4x4(-228.661072f, -348.7306f, 289.771484f, 66.5957947f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            float4x4 r2 = float4x4(-213.67627f, -605.688843f, -152.81131f, 255.225861f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            float4x4 r3 = float4x4(-673.2217f, -496.708649f, 236.787567f, 745.5549f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4x4_operator_sub_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            float4x4 r0 = float4x4(-172.952454f, -650.6f, -176.699829f, 12.7172241f);
            TestUtils.AreEqual(a0 - b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            float4x4 r1 = float4x4(-129.671387f, -139.961792f, -372.402527f, -143.741455f);
            TestUtils.AreEqual(a1 - b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            float4x4 r2 = float4x4(-348.7306f, 392.171326f, 102.399841f, -317.227081f);
            TestUtils.AreEqual(a2 - b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            float4x4 r3 = float4x4(-272.876648f, 213.67627f, -165.247925f, 440.440918f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4x4_operator_sub_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(-172.952454f, 477.647522f, 3.74737549f, -185.669678f);
            TestUtils.AreEqual(a0 - b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(-129.671387f, 10.2904053f, 242.73114f, 14.0700684f);
            TestUtils.AreEqual(a1 - b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-348.7306f, -740.9019f, -451.130432f, -31.50351f);
            TestUtils.AreEqual(a2 - b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(-272.876648f, -486.552917f, -107.628723f, -713.317566f);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void float4x4_operator_mul_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            float4x4 r0 = float4x4(124484.82f, -54842.6055f, 119371.289f, 96107.54f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            float4x4 r1 = float4x4(3756.20313f, -20112.71f, 81541.64f, 75954.125f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            float4x4 r2 = float4x4(-6678.89941f, -81799.9141f, 25263.2168f, 3415.20166f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            float4x4 r3 = float4x4(-111392.656f, -19473.3047f, 138039.219f, -134218.5f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4x4_operator_mul_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            float4x4 r0 = float4x4(124484.82f, -90333.9453f, 122799.461f, 207988.516f);
            TestUtils.AreEqual(a0 * b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            float4x4 r1 = float4x4(100098.086f, 96107.54f, 5968.527f, 94641.8047f);
            TestUtils.AreEqual(a1 * b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            float4x4 r2 = float4x4(-20112.71f, 33916.06f, 12785.0605f, -17815.3828f);
            TestUtils.AreEqual(a2 * b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            float4x4 r3 = float4x4(11821.4258f, -6678.89941f, 7729.03174f, -15301.2295f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4x4_operator_mul_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(124484.82f, -55595.29f, 75575.93f, 128004.828f);
            TestUtils.AreEqual(a0 * b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(100098.086f, 63970.85f, 3972.75537f, 62995.24f);
            TestUtils.AreEqual(a1 * b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-20112.71f, -128276.547f, -48355.3672f, 67380.94f);
            TestUtils.AreEqual(a2 * b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(11821.4258f, -54610.5039f, 63196.99f, -125111.609f);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void float4x4_operator_div_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            float4x4 r0 = float4x4(0.615441859f, -0.7356217f, 1.79163444f, 1.56474531f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            float4x4 r1 = float4x4(0.063064374f, -3.78217721f, 2.65278816f, 0.785796642f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            float4x4 r2 = float4x4(-0.216467991f, -0.505124867f, 2.52888942f, 0.04756004f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            float4x4 r3 = float4x4(-0.769948363f, -0.094562076f, 0.534192443f, -1.45331407f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4x4_operator_div_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            float4x4 r0 = float4x4(0.615441859f, -0.44660297f, 0.6071096f, 1.02827668f);
            TestUtils.AreEqual(a0 / b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            float4x4 r1 = float4x4(0.665617466f, 0.639081657f, 0.0396886244f, 0.629335046f);
            TestUtils.AreEqual(a1 / b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            float4x4 r2 = float4x4(-3.78217721f, 6.37788439f, 2.40421915f, -3.35016656f);
            TestUtils.AreEqual(a2 / b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            float4x4 r3 = float4x4(8.176573f, -4.619621f, 5.34597f, -10.5834618f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4x4_operator_div_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(0.615441859f, -1.3780514f, 1.01372445f, 0.5985178f);
            TestUtils.AreEqual(a0 / b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(0.665617466f, 1.04152179f, 16.7709885f, 1.05765188f);
            TestUtils.AreEqual(a1 / b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-3.78217721f, -0.5930144f, -1.57314157f, 1.128952f);
            TestUtils.AreEqual(a2 / b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(8.176573f, -1.76996624f, 1.52948344f, -0.772580147f);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void float4x4_operator_mod_wide_wide()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 462.4605f, 387.793518f);
            float4x4 b0 = float4x4(449.7433f, 273.043457f, 258.122131f, 247.831726f);
            float4x4 r0 = float4x4(276.790833f, -200.856689f, 204.338379f, 139.961792f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x4 a1 = float4x4(15.3909912f, -275.807617f, 465.0943f, -244.304108f);
            float4x4 b1 = float4x4(244.052063f, 72.92297f, 175.322815f, -310.8999f);
            float4x4 r1 = float4x4(15.3909912f, -57.0386963f, 114.448669f, -244.304108f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x4 a2 = float4x4(-38.0232544f, -203.271179f, -252.760529f, -12.74469f);
            float4x4 b2 = float4x4(175.653015f, 402.417664f, -99.94922f, -267.970551f);
            float4x4 r2 = float4x4(-38.0232544f, -203.271179f, -52.86209f, -12.74469f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x4 a3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 441.657837f);
            float4x4 b3 = float4x4(380.3623f, 453.7967f, -508.337769f, -303.897034f);
            float4x4 r3 = float4x4(-292.859344f, -42.9119568f, -271.5502f, 137.7608f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4x4_operator_mod_wide_scalar()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float b0 = (449.7433f);
            float4x4 r0 = float4x4(276.790833f, -200.856689f, 273.043457f, 12.7172241f);
            TestUtils.AreEqual(a0 % b0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float b1 = (387.793518f);
            float4x4 r1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            TestUtils.AreEqual(a1 % b1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float b2 = (72.92297f);
            float4x4 r2 = float4x4(-57.0386963f, 27.5564575f, 29.4768677f, -25.5351868f);
            TestUtils.AreEqual(a2 % b2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float b3 = (-38.0232544f);
            float4x4 r3 = float4x4(-6.713867f, 23.5599976f, -13.1549072f, 22.18512f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4x4_operator_mod_scalar_wide()
        {
            float a0 = (276.790833f);
            float4x4 b0 = float4x4(449.7433f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(276.790833f, 75.93414f, 3.74737549f, 276.790833f);
            TestUtils.AreEqual(a0 % b0, r0);

            float a1 = (258.122131f);
            float4x4 b1 = float4x4(387.793518f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(258.122131f, 10.2904053f, 11.866272f, 14.0700684f);
            TestUtils.AreEqual(a1 % b1, r1);

            float a2 = (-275.807617f);
            float4x4 b2 = float4x4(72.92297f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-57.0386963f, -275.807617f, -100.4848f, -31.50351f);
            TestUtils.AreEqual(a2 % b2, r2);

            float a3 = (-310.8999f);
            float4x4 b3 = float4x4(-38.0232544f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(-6.713867f, -135.246887f, -107.628723f, -310.8999f);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void float4x4_operator_plus()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            TestUtils.AreEqual(+a0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            TestUtils.AreEqual(+a1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            TestUtils.AreEqual(+a2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void float4x4_operator_neg()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(-276.790833f, 200.856689f, -273.043457f, -462.4605f);
            TestUtils.AreEqual(-a0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(-258.122131f, -247.831726f, -15.3909912f, -244.052063f);
            TestUtils.AreEqual(-a1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(275.807617f, -465.0943f, -175.322815f, 244.304108f);
            TestUtils.AreEqual(-a2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(310.8999f, -175.653015f, 203.271179f, -402.417664f);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void float4x4_operator_prefix_inc()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(277.790833f, -199.856689f, 274.043457f, 463.4605f);
            TestUtils.AreEqual(++a0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(259.122131f, 248.831726f, 16.3909912f, 245.052063f);
            TestUtils.AreEqual(++a1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-274.807617f, 466.0943f, 176.322815f, -243.304108f);
            TestUtils.AreEqual(++a2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(-309.8999f, 176.653015f, -202.271179f, 403.417664f);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void float4x4_operator_postfix_inc()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            TestUtils.AreEqual(a0++, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            TestUtils.AreEqual(a1++, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            TestUtils.AreEqual(a2++, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void float4x4_operator_prefix_dec()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(275.790833f, -201.856689f, 272.043457f, 461.4605f);
            TestUtils.AreEqual(--a0, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(257.122131f, 246.831726f, 14.3909912f, 243.052063f);
            TestUtils.AreEqual(--a1, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-276.807617f, 464.0943f, 174.322815f, -245.304108f);
            TestUtils.AreEqual(--a2, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(-311.8999f, 174.653015f, -204.271179f, 401.417664f);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void float4x4_operator_postfix_dec()
        {
            float4x4 a0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            float4x4 r0 = float4x4(276.790833f, -200.856689f, 273.043457f, 462.4605f);
            TestUtils.AreEqual(a0--, r0);

            float4x4 a1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            float4x4 r1 = float4x4(258.122131f, 247.831726f, 15.3909912f, 244.052063f);
            TestUtils.AreEqual(a1--, r1);

            float4x4 a2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            float4x4 r2 = float4x4(-275.807617f, 465.0943f, 175.322815f, -244.304108f);
            TestUtils.AreEqual(a2--, r2);

            float4x4 a3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            float4x4 r3 = float4x4(-310.8999f, 175.653015f, -203.271179f, 402.417664f);
            TestUtils.AreEqual(a3--, r3);
        }


    }
}
