using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestBool3
    {
        [Test]
        public void bool3_ConstructorOneArgument_CreateNewObject_CheckAgainstOriginalValues(
            [Values(false, true)] bool originalValue)
        {
            bool3 testValue = new bool3(originalValue);
            Assert.AreEqual(testValue.x, (bool1)originalValue);
            Assert.AreEqual(testValue.y, (bool1)originalValue);
            Assert.AreEqual(testValue.z, (bool1)originalValue);
        }

        [Test]
        public void bool3_ConstructorTwoArguments_CreateNewObject_CheckAgainstOriginalValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool2 xy = new bool2(firstArgument, secondArgument);
            bool3 testValue = new bool3(xy, thirdArgument);
            Assert.AreEqual(testValue.x, (bool1)firstArgument);
            Assert.AreEqual(testValue.y, (bool1)secondArgument);
            Assert.AreEqual(testValue.z, (bool1)thirdArgument);
        }

        [Test]
        public void bool3_ConstructorThreeArguments_CreateNewObject_CheckAgainstOriginalValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool3 testValue = new bool3(firstArgument, secondArgument, thirdArgument);
            Assert.AreEqual(testValue.x, (bool1)firstArgument);
            Assert.AreEqual(testValue.y, (bool1)secondArgument);
            Assert.AreEqual(testValue.z, (bool1)thirdArgument);
        }

        [Test]
        public void bool3_OperatorBool3_CompareCastBoolWithObject_ReturnSameValue(
            [Values(false, true)] bool originalValue)
        {
            bool3 testValue = new bool3(originalValue);
            Assert.AreEqual((bool3)originalValue, testValue);
        }

        [Test]
        public void bool3_ToString_PrintAll_ReturnExpectedFormat(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            string expectedString = "bool3(" + firstArgument + ", " + secondArgument + ", " + thirdArgument + ")";
            bool3 testValue = new bool3(firstArgument, secondArgument, thirdArgument);
            Assert.AreEqual(testValue.ToString(), expectedString);
        }

        [Test]
        public void bool3_OperatorEqual_CompareTwoBool3_AreSame(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(firstArgument, secondArgument, thirdArgument);

            Assert.AreEqual(new bool3(true), firstValue == secondValue);
        }

        [Test]
        public void bool3_OperatorEqual_CompareTwoBool3_XIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(!firstArgument, secondArgument, thirdArgument);

            Assert.AreEqual(new bool3(false, true, true), firstValue == secondValue);
        }

        [Test]
        public void bool3_OperatorEqual_CompareTwoBool3_YIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(firstArgument, !secondArgument, thirdArgument);

            Assert.AreEqual(new bool3(true, false, true), firstValue == secondValue);
        }

        [Test]
        public void bool3_OperatorEqual_CompareTwoBool3_ZIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(firstArgument, secondArgument, !thirdArgument);

            Assert.AreEqual(new bool3(true, true, false), firstValue == secondValue);
        }

        [Test]
        public void bool3_OperatorEqual_CompareTwoBool3_XYAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(!firstArgument, !secondArgument, thirdArgument);

            Assert.AreEqual(new bool3(false, false, true), firstValue == secondValue);
        }

        [Test]
        public void bool3_OperatorEqual_CompareTwoBool3_XZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(!firstArgument, secondArgument, !thirdArgument);

            Assert.AreEqual(new bool3(false, true, false), firstValue == secondValue);
        }

        [Test]
        public void bool3_OperatorEqual_CompareTwoBool3_YZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(firstArgument, !secondArgument, !thirdArgument);

            Assert.AreEqual(new bool3(true, false, false), firstValue == secondValue);
        }

        [Test]
        public void bool3_OperatorEqual_CompareTwoBool3_XYZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(!firstArgument, !secondArgument, !thirdArgument);

            Assert.AreEqual(new bool3(false, false, false), firstValue == secondValue);
        }

        [Test]
        public void bool3_OperatorEqual_CompareBoolWithBool3_AreSame(
            [Values(false, true)] bool firstArgument)
        {
            bool3 firstValue = new bool3(firstArgument);

            Assert.AreEqual(new bool3(true), firstValue == firstArgument);
            Assert.AreEqual(new bool3(true), firstArgument == firstValue);
        }

        [Test]
        public void bool3_OperatorEqual_CompareBoolWithBool3_AreDifferent(
            [Values(false, true)] bool firstArgument)
        {
            bool3 firstValue = new bool3(!firstArgument);

            Assert.AreEqual(new bool3(false), firstValue == firstArgument);
            Assert.AreEqual(new bool3(false), firstArgument == firstValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareTwoBool3_AreSame(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(firstArgument, secondArgument, thirdArgument);

            Assert.AreEqual(new bool3(false), firstValue != secondValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareTwoBool3_XIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(!firstArgument, secondArgument, thirdArgument);

            Assert.AreEqual(new bool3(true, false, false), firstValue != secondValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareTwoBool3_YIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(firstArgument, !secondArgument, thirdArgument);

            Assert.AreEqual(new bool3(false, true, false), firstValue != secondValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareTwoBool3_ZIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(firstArgument, secondArgument, !thirdArgument);

            Assert.AreEqual(new bool3(false, false, true), firstValue != secondValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareTwoBool3_XYAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(!firstArgument, !secondArgument, thirdArgument);

            Assert.AreEqual(new bool3(true, true, false), firstValue != secondValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareTwoBool3_XZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(!firstArgument, secondArgument, !thirdArgument);

            Assert.AreEqual(new bool3(true, false, true), firstValue != secondValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareTwoBool3_YZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(firstArgument, !secondArgument, !thirdArgument);

            Assert.AreEqual(new bool3(false, true, true), firstValue != secondValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareTwoBool3_XYZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument)
        {
            bool3 firstValue = new bool3(firstArgument, secondArgument, thirdArgument);
            bool3 secondValue = new bool3(!firstArgument, !secondArgument, !thirdArgument);

            Assert.AreEqual(new bool3(true, true, true), firstValue != secondValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareBoolWithBool3_AreSame(
            [Values(false, true)] bool firstArgument)
        {
            bool3 firstValue = new bool3(firstArgument);

            Assert.AreEqual(new bool3(false), firstValue != firstArgument);
            Assert.AreEqual(new bool3(false), firstArgument != firstValue);
        }

        [Test]
        public void bool3_OperatorNotEqual_CompareBoolWithBool3_AreDifferent(
            [Values(false, true)] bool firstArgument)
        {
            bool3 firstValue = new bool3(!firstArgument);

            Assert.AreEqual(new bool3(true), firstValue != firstArgument);
            Assert.AreEqual(new bool3(true), firstArgument != firstValue);
        }

        [Test]
        public void bool3_OperatorAND_BothBool3_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool3 firstValue = new bool3(argument);
            bool3 zeroValue = new bool3(false);

            Assert.AreEqual(new bool3(false), firstValue & zeroValue);
        }

        [Test]
        public void bool3_OperatorAND_BothBool3_ReturnTrue()
        {
            bool3 firstValue = new bool3(true);
            bool3 secondValue = new bool3(true);

            Assert.AreEqual(new bool3(true), firstValue & secondValue);
        }

        [Test]
        public void bool3_OperatorAND_BoolANDBool3_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool3 firstValue = new bool3(argument);

            Assert.AreEqual(new bool3(false), firstValue & false);
            Assert.AreEqual(new bool3(false), false & firstValue);
        }

        [Test]
        public void bool3_OperatorAND_BoolANDBool3_ReturnTrue()
        {
            bool3 firstValue = new bool3(true);

            Assert.AreEqual(new bool3(true), firstValue & true);
            Assert.AreEqual(new bool3(true), true & firstValue);
        }

        [Test]
        public void bool3_OperatorOR_BothBool3_ReturnFalse()
        {
            bool3 firstValue = new bool3(false);
            bool3 secondValue = new bool3(false);

            Assert.AreEqual(new bool3(false), firstValue | secondValue);
        }

        [Test]
        public void bool3_OperatorOR_BothBool3_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool3 firstValue = new bool3(argument);
            bool3 secondValue = new bool3(true);

            Assert.AreEqual(new bool3(true), firstValue | secondValue);
        }

        [Test]
        public void bool3_OperatorOR_BoolORBool3_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool3 firstValue = new bool3(argument);

            Assert.AreEqual(new bool3(true), firstValue | true);
            Assert.AreEqual(new bool3(true), true | firstValue);
        }

        [Test]
        public void bool3_OperatorOR_BoolORBool3_ReturnFalse()
        {
            bool3 firstValue = new bool3(false);

            Assert.AreEqual(new bool3(false), firstValue | false);
            Assert.AreEqual(new bool3(false), false | firstValue);
        }

        [Test]
        public void bool3_OperatorXOR_BothBool3_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool3 firstValue = new bool3(argument);
            bool3 secondValue = new bool3(!argument);

            Assert.AreEqual(new bool3(true), firstValue ^ secondValue);
        }

        [Test]
        public void bool3_OperatorXOR_BothBool3_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool3 firstValue = new bool3(argument);
            bool3 secondValue = new bool3(argument);

            Assert.AreEqual(new bool3(false), firstValue ^ secondValue);
        }

        [Test]
        public void bool3_OperatorXOR_BoolORBool3_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool3 firstValue = new bool3(argument);
            bool notArgument = !argument;

            Assert.AreEqual(new bool3(true), firstValue ^ notArgument);
            Assert.AreEqual(new bool3(true), notArgument ^ firstValue);
        }

        [Test]
        public void bool3_OperatorXOR_BoolORBool3_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool3 firstValue = new bool3(argument);

            Assert.AreEqual(new bool3(false), firstValue ^ argument);
            Assert.AreEqual(new bool3(false), argument ^ firstValue);
        }

[Test]
public void bool3_Swizzle_xx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool2(firstArgument,firstArgument), value.xx);
}

[Test]
public void bool3_Swizzle_xy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool2(firstArgument,secondArgument), value.xy);
}

[Test]
public void bool3_Swizzle_xz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool2(firstArgument,thirdArgument), value.xz);
}

[Test]
public void bool3_Swizzle_yx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool2(secondArgument,firstArgument), value.yx);
}

[Test]
public void bool3_Swizzle_yy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool2(secondArgument,secondArgument), value.yy);
}

[Test]
public void bool3_Swizzle_yz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool2(secondArgument,thirdArgument), value.yz);
}

[Test]
public void bool3_Swizzle_zx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool2(thirdArgument,firstArgument), value.zx);
}

[Test]
public void bool3_Swizzle_zy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool2(thirdArgument,secondArgument), value.zy);
}

[Test]
public void bool3_Swizzle_zz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool2(thirdArgument,thirdArgument), value.zz);
}

[Test]
public void bool3_Swizzle_xxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(firstArgument,firstArgument,firstArgument), value.xxx);
}

[Test]
public void bool3_Swizzle_xxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(firstArgument,firstArgument,secondArgument), value.xxy);
}

[Test]
public void bool3_Swizzle_xxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(firstArgument,firstArgument,thirdArgument), value.xxz);
}

[Test]
public void bool3_Swizzle_xyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(firstArgument,secondArgument,firstArgument), value.xyx);
}

[Test]
public void bool3_Swizzle_xyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(firstArgument,secondArgument,secondArgument), value.xyy);
}

[Test]
public void bool3_Swizzle_xyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(firstArgument,secondArgument,thirdArgument), value.xyz);
}

[Test]
public void bool3_Swizzle_xzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(firstArgument,thirdArgument,firstArgument), value.xzx);
}

[Test]
public void bool3_Swizzle_xzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(firstArgument,thirdArgument,secondArgument), value.xzy);
}

[Test]
public void bool3_Swizzle_xzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(firstArgument,thirdArgument,thirdArgument), value.xzz);
}

[Test]
public void bool3_Swizzle_yxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(secondArgument,firstArgument,firstArgument), value.yxx);
}

[Test]
public void bool3_Swizzle_yxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(secondArgument,firstArgument,secondArgument), value.yxy);
}

[Test]
public void bool3_Swizzle_yxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(secondArgument,firstArgument,thirdArgument), value.yxz);
}

[Test]
public void bool3_Swizzle_yyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(secondArgument,secondArgument,firstArgument), value.yyx);
}

[Test]
public void bool3_Swizzle_yyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(secondArgument,secondArgument,secondArgument), value.yyy);
}

[Test]
public void bool3_Swizzle_yyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(secondArgument,secondArgument,thirdArgument), value.yyz);
}

[Test]
public void bool3_Swizzle_yzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(secondArgument,thirdArgument,firstArgument), value.yzx);
}

[Test]
public void bool3_Swizzle_yzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(secondArgument,thirdArgument,secondArgument), value.yzy);
}

[Test]
public void bool3_Swizzle_yzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(secondArgument,thirdArgument,thirdArgument), value.yzz);
}

[Test]
public void bool3_Swizzle_zxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(thirdArgument,firstArgument,firstArgument), value.zxx);
}

[Test]
public void bool3_Swizzle_zxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(thirdArgument,firstArgument,secondArgument), value.zxy);
}

[Test]
public void bool3_Swizzle_zxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(thirdArgument,firstArgument,thirdArgument), value.zxz);
}

[Test]
public void bool3_Swizzle_zyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(thirdArgument,secondArgument,firstArgument), value.zyx);
}

[Test]
public void bool3_Swizzle_zyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(thirdArgument,secondArgument,secondArgument), value.zyy);
}

[Test]
public void bool3_Swizzle_zyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(thirdArgument,secondArgument,thirdArgument), value.zyz);
}

[Test]
public void bool3_Swizzle_zzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(thirdArgument,thirdArgument,firstArgument), value.zzx);
}

[Test]
public void bool3_Swizzle_zzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(thirdArgument,thirdArgument,secondArgument), value.zzy);
}

[Test]
public void bool3_Swizzle_zzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool3(thirdArgument,thirdArgument,thirdArgument), value.zzz);
}

[Test]
public void bool3_Swizzle_xxxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,firstArgument,firstArgument,firstArgument), value.xxxx);
}

[Test]
public void bool3_Swizzle_xxxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,firstArgument,firstArgument,secondArgument), value.xxxy);
}

[Test]
public void bool3_Swizzle_xxxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,firstArgument,firstArgument,thirdArgument), value.xxxz);
}

[Test]
public void bool3_Swizzle_xxyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,firstArgument,secondArgument,firstArgument), value.xxyx);
}

[Test]
public void bool3_Swizzle_xxyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,firstArgument,secondArgument,secondArgument), value.xxyy);
}

[Test]
public void bool3_Swizzle_xxyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,firstArgument,secondArgument,thirdArgument), value.xxyz);
}

[Test]
public void bool3_Swizzle_xxzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,firstArgument,thirdArgument,firstArgument), value.xxzx);
}

[Test]
public void bool3_Swizzle_xxzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,firstArgument,thirdArgument,secondArgument), value.xxzy);
}

[Test]
public void bool3_Swizzle_xxzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,firstArgument,thirdArgument,thirdArgument), value.xxzz);
}

[Test]
public void bool3_Swizzle_xyxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,secondArgument,firstArgument,firstArgument), value.xyxx);
}

[Test]
public void bool3_Swizzle_xyxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,secondArgument,firstArgument,secondArgument), value.xyxy);
}

[Test]
public void bool3_Swizzle_xyxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,secondArgument,firstArgument,thirdArgument), value.xyxz);
}

[Test]
public void bool3_Swizzle_xyyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,secondArgument,secondArgument,firstArgument), value.xyyx);
}

[Test]
public void bool3_Swizzle_xyyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,secondArgument,secondArgument,secondArgument), value.xyyy);
}

[Test]
public void bool3_Swizzle_xyyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,secondArgument,secondArgument,thirdArgument), value.xyyz);
}

[Test]
public void bool3_Swizzle_xyzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,secondArgument,thirdArgument,firstArgument), value.xyzx);
}

[Test]
public void bool3_Swizzle_xyzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,secondArgument,thirdArgument,secondArgument), value.xyzy);
}

[Test]
public void bool3_Swizzle_xyzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,secondArgument,thirdArgument,thirdArgument), value.xyzz);
}

[Test]
public void bool3_Swizzle_xzxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,thirdArgument,firstArgument,firstArgument), value.xzxx);
}

[Test]
public void bool3_Swizzle_xzxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,thirdArgument,firstArgument,secondArgument), value.xzxy);
}

[Test]
public void bool3_Swizzle_xzxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,thirdArgument,firstArgument,thirdArgument), value.xzxz);
}

[Test]
public void bool3_Swizzle_xzyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,thirdArgument,secondArgument,firstArgument), value.xzyx);
}

[Test]
public void bool3_Swizzle_xzyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,thirdArgument,secondArgument,secondArgument), value.xzyy);
}

[Test]
public void bool3_Swizzle_xzyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,thirdArgument,secondArgument,thirdArgument), value.xzyz);
}

[Test]
public void bool3_Swizzle_xzzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,thirdArgument,thirdArgument,firstArgument), value.xzzx);
}

[Test]
public void bool3_Swizzle_xzzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,thirdArgument,thirdArgument,secondArgument), value.xzzy);
}

[Test]
public void bool3_Swizzle_xzzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(firstArgument,thirdArgument,thirdArgument,thirdArgument), value.xzzz);
}

[Test]
public void bool3_Swizzle_yxxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,firstArgument,firstArgument,firstArgument), value.yxxx);
}

[Test]
public void bool3_Swizzle_yxxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,firstArgument,firstArgument,secondArgument), value.yxxy);
}

[Test]
public void bool3_Swizzle_yxxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,firstArgument,firstArgument,thirdArgument), value.yxxz);
}

[Test]
public void bool3_Swizzle_yxyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,firstArgument,secondArgument,firstArgument), value.yxyx);
}

[Test]
public void bool3_Swizzle_yxyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,firstArgument,secondArgument,secondArgument), value.yxyy);
}

[Test]
public void bool3_Swizzle_yxyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,firstArgument,secondArgument,thirdArgument), value.yxyz);
}

[Test]
public void bool3_Swizzle_yxzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,firstArgument,thirdArgument,firstArgument), value.yxzx);
}

[Test]
public void bool3_Swizzle_yxzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,firstArgument,thirdArgument,secondArgument), value.yxzy);
}

[Test]
public void bool3_Swizzle_yxzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,firstArgument,thirdArgument,thirdArgument), value.yxzz);
}

[Test]
public void bool3_Swizzle_yyxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,secondArgument,firstArgument,firstArgument), value.yyxx);
}

[Test]
public void bool3_Swizzle_yyxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,secondArgument,firstArgument,secondArgument), value.yyxy);
}

[Test]
public void bool3_Swizzle_yyxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,secondArgument,firstArgument,thirdArgument), value.yyxz);
}

[Test]
public void bool3_Swizzle_yyyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,secondArgument,secondArgument,firstArgument), value.yyyx);
}

[Test]
public void bool3_Swizzle_yyyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,secondArgument,secondArgument,secondArgument), value.yyyy);
}

[Test]
public void bool3_Swizzle_yyyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,secondArgument,secondArgument,thirdArgument), value.yyyz);
}

[Test]
public void bool3_Swizzle_yyzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,secondArgument,thirdArgument,firstArgument), value.yyzx);
}

[Test]
public void bool3_Swizzle_yyzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,secondArgument,thirdArgument,secondArgument), value.yyzy);
}

[Test]
public void bool3_Swizzle_yyzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,secondArgument,thirdArgument,thirdArgument), value.yyzz);
}

[Test]
public void bool3_Swizzle_yzxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,thirdArgument,firstArgument,firstArgument), value.yzxx);
}

[Test]
public void bool3_Swizzle_yzxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,thirdArgument,firstArgument,secondArgument), value.yzxy);
}

[Test]
public void bool3_Swizzle_yzxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,thirdArgument,firstArgument,thirdArgument), value.yzxz);
}

[Test]
public void bool3_Swizzle_yzyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,thirdArgument,secondArgument,firstArgument), value.yzyx);
}

[Test]
public void bool3_Swizzle_yzyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,thirdArgument,secondArgument,secondArgument), value.yzyy);
}

[Test]
public void bool3_Swizzle_yzyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,thirdArgument,secondArgument,thirdArgument), value.yzyz);
}

[Test]
public void bool3_Swizzle_yzzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,thirdArgument,thirdArgument,firstArgument), value.yzzx);
}

[Test]
public void bool3_Swizzle_yzzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,thirdArgument,thirdArgument,secondArgument), value.yzzy);
}

[Test]
public void bool3_Swizzle_yzzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(secondArgument,thirdArgument,thirdArgument,thirdArgument), value.yzzz);
}

[Test]
public void bool3_Swizzle_zxxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,firstArgument,firstArgument,firstArgument), value.zxxx);
}

[Test]
public void bool3_Swizzle_zxxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,firstArgument,firstArgument,secondArgument), value.zxxy);
}

[Test]
public void bool3_Swizzle_zxxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,firstArgument,firstArgument,thirdArgument), value.zxxz);
}

[Test]
public void bool3_Swizzle_zxyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,firstArgument,secondArgument,firstArgument), value.zxyx);
}

[Test]
public void bool3_Swizzle_zxyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,firstArgument,secondArgument,secondArgument), value.zxyy);
}

[Test]
public void bool3_Swizzle_zxyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,firstArgument,secondArgument,thirdArgument), value.zxyz);
}

[Test]
public void bool3_Swizzle_zxzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,firstArgument,thirdArgument,firstArgument), value.zxzx);
}

[Test]
public void bool3_Swizzle_zxzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,firstArgument,thirdArgument,secondArgument), value.zxzy);
}

[Test]
public void bool3_Swizzle_zxzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,firstArgument,thirdArgument,thirdArgument), value.zxzz);
}

[Test]
public void bool3_Swizzle_zyxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,secondArgument,firstArgument,firstArgument), value.zyxx);
}

[Test]
public void bool3_Swizzle_zyxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,secondArgument,firstArgument,secondArgument), value.zyxy);
}

[Test]
public void bool3_Swizzle_zyxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,secondArgument,firstArgument,thirdArgument), value.zyxz);
}

[Test]
public void bool3_Swizzle_zyyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,secondArgument,secondArgument,firstArgument), value.zyyx);
}

[Test]
public void bool3_Swizzle_zyyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,secondArgument,secondArgument,secondArgument), value.zyyy);
}

[Test]
public void bool3_Swizzle_zyyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,secondArgument,secondArgument,thirdArgument), value.zyyz);
}

[Test]
public void bool3_Swizzle_zyzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,secondArgument,thirdArgument,firstArgument), value.zyzx);
}

[Test]
public void bool3_Swizzle_zyzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,secondArgument,thirdArgument,secondArgument), value.zyzy);
}

[Test]
public void bool3_Swizzle_zyzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,secondArgument,thirdArgument,thirdArgument), value.zyzz);
}

[Test]
public void bool3_Swizzle_zzxx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,thirdArgument,firstArgument,firstArgument), value.zzxx);
}

[Test]
public void bool3_Swizzle_zzxy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,thirdArgument,firstArgument,secondArgument), value.zzxy);
}

[Test]
public void bool3_Swizzle_zzxz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,thirdArgument,firstArgument,thirdArgument), value.zzxz);
}

[Test]
public void bool3_Swizzle_zzyx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,thirdArgument,secondArgument,firstArgument), value.zzyx);
}

[Test]
public void bool3_Swizzle_zzyy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,thirdArgument,secondArgument,secondArgument), value.zzyy);
}

[Test]
public void bool3_Swizzle_zzyz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,thirdArgument,secondArgument,thirdArgument), value.zzyz);
}

[Test]
public void bool3_Swizzle_zzzx_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,thirdArgument,thirdArgument,firstArgument), value.zzzx);
}

[Test]
public void bool3_Swizzle_zzzy_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,thirdArgument,thirdArgument,secondArgument), value.zzzy);
}

[Test]
public void bool3_Swizzle_zzzz_SameValues(
    [Values(false,true)] bool firstArgument,
    [Values(false,true)] bool secondArgument,
    [Values(false,true)] bool thirdArgument)
{
    bool3 value = new bool3(firstArgument, secondArgument, thirdArgument);
    Assert.AreEqual(new bool4(thirdArgument,thirdArgument,thirdArgument,thirdArgument), value.zzzz);
}
    }
}
