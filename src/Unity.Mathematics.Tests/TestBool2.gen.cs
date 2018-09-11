// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestBool2
    {
        [Test]
        public void bool2_constructor()
        {
            bool2 a = new bool2(false, true);
            Assert.AreEqual(a.x, false);
            Assert.AreEqual(a.y, true);
        }

        [Test]
        public void bool2_scalar_constructor()
        {
            bool2 a = new bool2(true);
            Assert.AreEqual(a.x, true);
            Assert.AreEqual(a.y, true);
        }

        [Test]
        public void bool2_static_constructor()
        {
            bool2 a = bool2(false, true);
            Assert.AreEqual(a.x, false);
            Assert.AreEqual(a.y, true);
        }

        [Test]
        public void bool2_static_scalar_constructor()
        {
            bool2 a = bool2(true);
            Assert.AreEqual(a.x, true);
            Assert.AreEqual(a.y, true);
        }

        [Test]
        public void bool2_operator_equal_wide_wide()
        {
            bool2 a0 = bool2(true, false);
            bool2 b0 = bool2(true, false);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 == b0, r0);

            bool2 a1 = bool2(true, false);
            bool2 b1 = bool2(false, false);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 == b1, r1);

            bool2 a2 = bool2(false, true);
            bool2 b2 = bool2(true, false);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            bool2 a3 = bool2(false, false);
            bool2 b3 = bool2(false, true);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void bool2_operator_equal_wide_scalar()
        {
            bool2 a0 = bool2(false, true);
            bool b0 = (true);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 == b0, r0);

            bool2 a1 = bool2(false, false);
            bool b1 = (false);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 == b1, r1);

            bool2 a2 = bool2(false, false);
            bool b2 = (true);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            bool2 a3 = bool2(false, true);
            bool b3 = (false);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void bool2_operator_equal_scalar_wide()
        {
            bool a0 = (false);
            bool2 b0 = bool2(true, false);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 == b0, r0);

            bool a1 = (true);
            bool2 b1 = bool2(false, false);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            bool a2 = (true);
            bool2 b2 = bool2(false, false);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            bool a3 = (true);
            bool2 b3 = bool2(false, true);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void bool2_operator_not_equal_wide_wide()
        {
            bool2 a0 = bool2(true, true);
            bool2 b0 = bool2(true, false);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 != b0, r0);

            bool2 a1 = bool2(true, false);
            bool2 b1 = bool2(false, false);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 != b1, r1);

            bool2 a2 = bool2(false, true);
            bool2 b2 = bool2(true, false);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            bool2 a3 = bool2(false, false);
            bool2 b3 = bool2(false, false);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void bool2_operator_not_equal_wide_scalar()
        {
            bool2 a0 = bool2(false, true);
            bool b0 = (false);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 != b0, r0);

            bool2 a1 = bool2(false, true);
            bool b1 = (true);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 != b1, r1);

            bool2 a2 = bool2(false, false);
            bool b2 = (false);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 != b2, r2);

            bool2 a3 = bool2(false, false);
            bool b3 = (false);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void bool2_operator_not_equal_scalar_wide()
        {
            bool a0 = (true);
            bool2 b0 = bool2(false, false);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            bool a1 = (true);
            bool2 b1 = bool2(false, false);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            bool a2 = (false);
            bool2 b2 = bool2(true, true);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            bool a3 = (true);
            bool2 b3 = bool2(false, false);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void bool2_operator_bitwise_and_wide_wide()
        {
            bool2 a0 = bool2(false, false);
            bool2 b0 = bool2(false, false);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 & b0, r0);

            bool2 a1 = bool2(true, true);
            bool2 b1 = bool2(true, false);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 & b1, r1);

            bool2 a2 = bool2(false, false);
            bool2 b2 = bool2(true, true);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 & b2, r2);

            bool2 a3 = bool2(true, true);
            bool2 b3 = bool2(false, false);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void bool2_operator_bitwise_and_wide_scalar()
        {
            bool2 a0 = bool2(true, false);
            bool b0 = (true);
            bool2 r0 = bool2(true, false);
            TestUtils.AreEqual(a0 & b0, r0);

            bool2 a1 = bool2(false, true);
            bool b1 = (true);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 & b1, r1);

            bool2 a2 = bool2(false, false);
            bool b2 = (false);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 & b2, r2);

            bool2 a3 = bool2(false, true);
            bool b3 = (false);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void bool2_operator_bitwise_and_scalar_wide()
        {
            bool a0 = (false);
            bool2 b0 = bool2(false, false);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 & b0, r0);

            bool a1 = (true);
            bool2 b1 = bool2(true, true);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 & b1, r1);

            bool a2 = (false);
            bool2 b2 = bool2(true, false);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 & b2, r2);

            bool a3 = (false);
            bool2 b3 = bool2(false, true);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void bool2_operator_bitwise_or_wide_wide()
        {
            bool2 a0 = bool2(true, true);
            bool2 b0 = bool2(false, false);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 | b0, r0);

            bool2 a1 = bool2(true, false);
            bool2 b1 = bool2(false, false);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(a1 | b1, r1);

            bool2 a2 = bool2(true, false);
            bool2 b2 = bool2(true, true);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 | b2, r2);

            bool2 a3 = bool2(true, true);
            bool2 b3 = bool2(true, false);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void bool2_operator_bitwise_or_wide_scalar()
        {
            bool2 a0 = bool2(true, true);
            bool b0 = (true);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 | b0, r0);

            bool2 a1 = bool2(false, true);
            bool b1 = (true);
            bool2 r1 = bool2(true, true);
            TestUtils.AreEqual(a1 | b1, r1);

            bool2 a2 = bool2(true, false);
            bool b2 = (true);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 | b2, r2);

            bool2 a3 = bool2(true, false);
            bool b3 = (false);
            bool2 r3 = bool2(true, false);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void bool2_operator_bitwise_or_scalar_wide()
        {
            bool a0 = (true);
            bool2 b0 = bool2(true, true);
            bool2 r0 = bool2(true, true);
            TestUtils.AreEqual(a0 | b0, r0);

            bool a1 = (false);
            bool2 b1 = bool2(false, true);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 | b1, r1);

            bool a2 = (true);
            bool2 b2 = bool2(true, false);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(a2 | b2, r2);

            bool a3 = (false);
            bool2 b3 = bool2(true, true);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void bool2_operator_bitwise_xor_wide_wide()
        {
            bool2 a0 = bool2(true, false);
            bool2 b0 = bool2(true, true);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 ^ b0, r0);

            bool2 a1 = bool2(false, true);
            bool2 b1 = bool2(false, true);
            bool2 r1 = bool2(false, false);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool2 a2 = bool2(false, false);
            bool2 b2 = bool2(false, true);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool2 a3 = bool2(false, true);
            bool2 b3 = bool2(false, true);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void bool2_operator_bitwise_xor_wide_scalar()
        {
            bool2 a0 = bool2(false, false);
            bool b0 = (false);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(a0 ^ b0, r0);

            bool2 a1 = bool2(true, false);
            bool b1 = (true);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool2 a2 = bool2(false, false);
            bool b2 = (false);
            bool2 r2 = bool2(false, false);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool2 a3 = bool2(false, false);
            bool b3 = (false);
            bool2 r3 = bool2(false, false);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void bool2_operator_bitwise_xor_scalar_wide()
        {
            bool a0 = (true);
            bool2 b0 = bool2(true, false);
            bool2 r0 = bool2(false, true);
            TestUtils.AreEqual(a0 ^ b0, r0);

            bool a1 = (true);
            bool2 b1 = bool2(true, false);
            bool2 r1 = bool2(false, true);
            TestUtils.AreEqual(a1 ^ b1, r1);

            bool a2 = (true);
            bool2 b2 = bool2(true, false);
            bool2 r2 = bool2(false, true);
            TestUtils.AreEqual(a2 ^ b2, r2);

            bool a3 = (false);
            bool2 b3 = bool2(true, true);
            bool2 r3 = bool2(true, true);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void bool2_operator_logical_not()
        {
            bool2 a0 = bool2(true, true);
            bool2 r0 = bool2(false, false);
            TestUtils.AreEqual(!a0, r0);

            bool2 a1 = bool2(false, true);
            bool2 r1 = bool2(true, false);
            TestUtils.AreEqual(!a1, r1);

            bool2 a2 = bool2(false, false);
            bool2 r2 = bool2(true, true);
            TestUtils.AreEqual(!a2, r2);

            bool2 a3 = bool2(true, false);
            bool2 r3 = bool2(false, true);
            TestUtils.AreEqual(!a3, r3);
        }


    }
}
