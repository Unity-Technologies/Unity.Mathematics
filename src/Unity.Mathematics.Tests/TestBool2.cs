using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestBool2
    {
        [Test]
        public void bool2_ConstructorOneArgument_CreateNewObject_CheckAgainstOriginalValues(
            [Values(false, true)] bool originalValue)
        {
            bool2 testValue = new bool2(originalValue);
            Assert.AreEqual(testValue.x, originalValue);
            Assert.AreEqual(testValue.y, originalValue);
        }

        [Test]
        public void bool2_ConstructorTwoArguments_CreateNewObject_CheckAgainstOriginalValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 testValue = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(testValue.x, firstArgument);
            Assert.AreEqual(testValue.y, secondArgument);
        }

        [Test]
        public void bool2_OperatorBool2_CompareCastBoolWithObject_ReturnSameValue(
            [Values(false, true)] bool originalValue)
        {
            bool2 testValue = new bool2(originalValue);
            Assert.AreEqual((bool2)originalValue, testValue);
        }

        [Test]
        public void bool2_ToString_PrintPair_ReturnExpectedFormat(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            string expectedString = "bool2(" + firstArgument + ", " + secondArgument + ")";
            bool2 testValue = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(testValue.ToString(), expectedString);
        }

        [Test]
        public void bool2_OperatorEqual_CompareTwoBool2_AreSame(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 firstValue = new bool2(firstArgument, secondArgument);
            bool2 secondValue = new bool2(firstArgument, secondArgument);

            Assert.AreEqual(new bool2(true), firstValue == secondValue);
        }

        [Test]
        public void bool2_OperatorEqual_CompareTwoBool2_XIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 firstValue = new bool2(firstArgument, secondArgument);
            bool2 secondValue = new bool2(!firstArgument, secondArgument);

            Assert.AreEqual(new bool2(false, true), firstValue == secondValue);
        }

        [Test]
        public void bool2_OperatorEqual_CompareTwoBool2_YIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 firstValue = new bool2(firstArgument, secondArgument);
            bool2 secondValue = new bool2(firstArgument, !secondArgument);

            Assert.AreEqual(new bool2(true, false), firstValue == secondValue);
        }

        [Test]
        public void bool2_OperatorEqual_CompareTwoBool2_XYAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 firstValue = new bool2(firstArgument, secondArgument);
            bool2 secondValue = new bool2(!firstArgument, !secondArgument);

            Assert.AreEqual(new bool2(false), firstValue == secondValue);
        }

        [Test]
        public void bool2_OperatorEqual_CompareBoolWithBool2_AreSame(
            [Values(false, true)] bool firstArgument)
        {
            bool2 firstValue = new bool2(firstArgument);

            Assert.AreEqual(new bool2(true), firstValue == firstArgument);
            Assert.AreEqual(new bool2(true), firstArgument == firstValue);
        }

        [Test]
        public void bool2_OperatorEqual_CompareBoolWithBool2_AreDifferent(
            [Values(false, true)] bool firstArgument)
        {
            bool2 firstValue = new bool2(!firstArgument);

            Assert.AreEqual(new bool2(false), firstValue == firstArgument);
            Assert.AreEqual(new bool2(false), firstArgument == firstValue);
        }

        [Test]
        public void bool2_OperatorNotEqual_CompareTwoBool2_AreSame(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 firstValue = new bool2(firstArgument, secondArgument);
            bool2 secondValue = new bool2(firstArgument, secondArgument);

            Assert.AreEqual(new bool2(false), firstValue != secondValue);
        }

        [Test]
        public void bool2_OperatorNotEqual_CompareTwoBool2_XIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 firstValue = new bool2(firstArgument, secondArgument);
            bool2 secondValue = new bool2(!firstArgument, secondArgument);

            Assert.AreEqual(new bool2(true, false), firstValue != secondValue);
        }

        [Test]
        public void bool2_OperatorNotEqual_CompareTwoBool2_YIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 firstValue = new bool2(firstArgument, secondArgument);
            bool2 secondValue = new bool2(firstArgument, !secondArgument);

            Assert.AreEqual(new bool2(false, true), firstValue != secondValue);
        }

        [Test]
        public void bool2_OperatorNotEqual_CompareTwoBool2_XYAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 firstValue = new bool2(firstArgument, secondArgument);
            bool2 secondValue = new bool2(!firstArgument, !secondArgument);

            Assert.AreEqual(new bool2(true), firstValue != secondValue);
        }

        [Test]
        public void bool2_OperatorNotEqual_CompareBoolWithBool2_AreSame(
            [Values(false, true)] bool firstArgument)
        {
            bool2 firstValue = new bool2(firstArgument);

            Assert.AreEqual(new bool2(false), firstValue != firstArgument);
            Assert.AreEqual(new bool2(false), firstArgument != firstValue);
        }

        [Test]
        public void bool2_OperatorNotEqual_CompareBoolWithBool2_AreDifferent(
            [Values(false, true)] bool firstArgument)
        {
            bool2 firstValue = new bool2(!firstArgument);

            Assert.AreEqual(new bool2(true), firstValue != firstArgument);
            Assert.AreEqual(new bool2(true), firstArgument != firstValue);
        }

        [Test]
        public void bool2_OperatorAND_BothBool2_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool2 firstValue = new bool2(argument);
            bool2 zeroValue = new bool2(false);

            Assert.AreEqual(new bool2(false), firstValue & zeroValue);
        }

        [Test]
        public void bool2_OperatorAND_BothBool2_ReturnTrue()
        {
            bool2 firstValue = new bool2(true);
            bool2 secondValue = new bool2(true);

            Assert.AreEqual(new bool2(true), firstValue & secondValue);
        }

        [Test]
        public void bool2_OperatorAND_BoolANDBool2_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool2 firstValue = new bool2(argument);

            Assert.AreEqual(new bool2(false), firstValue & false);
            Assert.AreEqual(new bool2(false), false & firstValue);
        }

        [Test]
        public void bool2_OperatorAND_BoolANDBool2_ReturnTrue()
        {
            bool2 firstValue = new bool2(true);

            Assert.AreEqual(new bool2(true), firstValue & true);
            Assert.AreEqual(new bool2(true), true & firstValue);
        }

        [Test]
        public void bool2_OperatorOR_BothBool2_ReturnFalse()
        {
            bool2 firstValue = new bool2(false);
            bool2 secondValue = new bool2(false);

            Assert.AreEqual(new bool2(false), firstValue | secondValue);
        }

        [Test]
        public void bool2_OperatorOR_BothBool2_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool2 firstValue = new bool2(argument);
            bool2 secondValue = new bool2(true);

            Assert.AreEqual(new bool2(true), firstValue | secondValue);
        }

        [Test]
        public void bool2_OperatorOR_BoolORBool2_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool2 firstValue = new bool2(argument);

            Assert.AreEqual(new bool2(true), firstValue | true);
            Assert.AreEqual(new bool2(true), true | firstValue);
        }

        [Test]
        public void bool2_OperatorOR_BoolORBool2_ReturnFalse()
        {
            bool2 firstValue = new bool2(false);

            Assert.AreEqual(new bool2(false), firstValue | false);
            Assert.AreEqual(new bool2(false), false | firstValue);
        }

        [Test]
        public void bool2_OperatorXOR_BothBool2_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool2 firstValue = new bool2(argument);
            bool2 secondValue = new bool2(!argument);

            Assert.AreEqual(new bool2(true), firstValue ^ secondValue);
        }

        [Test]
        public void bool2_OperatorXOR_BothBool2_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool2 firstValue = new bool2(argument);
            bool2 secondValue = new bool2(argument);

            Assert.AreEqual(new bool2(false), firstValue ^ secondValue);
        }

        [Test]
        public void bool2_OperatorXOR_BoolORBool2_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool2 firstValue = new bool2(argument);
            bool notArgument = !argument;

            Assert.AreEqual(new bool2(true), firstValue ^ notArgument);
            Assert.AreEqual(new bool2(true), notArgument ^ firstValue);
        }

        [Test]
        public void bool2_OperatorXOR_BoolORBool2_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool2 firstValue = new bool2(argument);

            Assert.AreEqual(new bool2(false), firstValue ^ argument);
            Assert.AreEqual(new bool2(false), argument ^ firstValue);
        }

        [Test]
        public void bool2_Swizzle_xx_SameValuesButNotSameReference(
            [Values(false, true)] bool argument)
        {
            bool2 value = new bool2(argument);

            Assert.IsFalse(ReferenceEquals(value, value.xx));
            Assert.AreEqual(new bool2(argument), value.xx);
        }

        [Test]
        public void bool2_Swizzle_yy_SameValuesButNotSameReference(
            [Values(false, true)] bool argument)
        {
            bool2 value = new bool2(argument);

            Assert.IsFalse(ReferenceEquals(value, value.yy));
            Assert.AreEqual(new bool2(argument), value.yy);
        }

        [Test]
        public void bool2_Swizzle_xy_SameValuesButNotSameReference(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool2(firstArgument, secondArgument), value.xy);
        }

        [Test]
        public void bool2_Swizzle_yx_SameValuesButNotSameReference(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool2(secondArgument, firstArgument), value.yx);
        }

        [Test]
        public void bool2_Swizzle_xxx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool3(firstArgument, firstArgument, firstArgument), value.xxx);
        }

        [Test]
        public void bool2_Swizzle_xxy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool3(firstArgument, firstArgument, secondArgument), value.xxy);
        }

        [Test]
        public void bool2_Swizzle_xyx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool3(firstArgument, secondArgument, firstArgument), value.xyx);
        }

        [Test]
        public void bool2_Swizzle_xyy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool3(firstArgument, secondArgument, secondArgument), value.xyy);
        }

        [Test]
        public void bool2_Swizzle_yxx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool3(secondArgument, firstArgument, firstArgument), value.yxx);
        }

        [Test]
        public void bool2_Swizzle_yxy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool3(secondArgument, firstArgument, secondArgument), value.yxy);
        }

        [Test]
        public void bool2_Swizzle_yyx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool3(secondArgument, secondArgument, firstArgument), value.yyx);
        }

        [Test]
        public void bool2_Swizzle_yyy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool3(secondArgument, secondArgument, secondArgument), value.yyy);
        }

        [Test]
        public void bool2_Swizzle_xxxx_SameValues(
    [Values(false, true)] bool firstArgument,
    [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(firstArgument, firstArgument, firstArgument, firstArgument), value.xxxx);
        }

        [Test]
        public void bool2_Swizzle_xxxy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(firstArgument, firstArgument, firstArgument, secondArgument), value.xxxy);
        }

        [Test]
        public void bool2_Swizzle_xxyx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(firstArgument, firstArgument, secondArgument, firstArgument), value.xxyx);
        }

        [Test]
        public void bool2_Swizzle_xxyy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(firstArgument, firstArgument, secondArgument, secondArgument), value.xxyy);
        }

        [Test]
        public void bool2_Swizzle_xyxx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(firstArgument, secondArgument, firstArgument, firstArgument), value.xyxx);
        }

        [Test]
        public void bool2_Swizzle_xyxy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(firstArgument, secondArgument, firstArgument, secondArgument), value.xyxy);
        }

        [Test]
        public void bool2_Swizzle_xyyx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(firstArgument, secondArgument, secondArgument, firstArgument), value.xyyx);
        }

        [Test]
        public void bool2_Swizzle_xyyy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(firstArgument, secondArgument, secondArgument, secondArgument), value.xyyy);
        }

        [Test]
        public void bool2_Swizzle_yxxx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(secondArgument, firstArgument, firstArgument, firstArgument), value.yxxx);
        }

        [Test]
        public void bool2_Swizzle_yxxy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(secondArgument, firstArgument, firstArgument, secondArgument), value.yxxy);
        }

        [Test]
        public void bool2_Swizzle_yxyx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(secondArgument, firstArgument, secondArgument, firstArgument), value.yxyx);
        }

        [Test]
        public void bool2_Swizzle_yxyy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(secondArgument, firstArgument, secondArgument, secondArgument), value.yxyy);
        }

        [Test]
        public void bool2_Swizzle_yyxx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(secondArgument, secondArgument, firstArgument, firstArgument), value.yyxx);
        }

        [Test]
        public void bool2_Swizzle_yyxy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(secondArgument, secondArgument, firstArgument, secondArgument), value.yyxy);
        }

        [Test]
        public void bool2_Swizzle_yyyx_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(secondArgument, secondArgument, secondArgument, firstArgument), value.yyyx);
        }

        [Test]
        public void bool2_Swizzle_yyyy_SameValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument)
        {
            bool2 value = new bool2(firstArgument, secondArgument);
            Assert.AreEqual(new bool4(secondArgument, secondArgument, secondArgument, secondArgument), value.yyyy);
        }
    }
}
