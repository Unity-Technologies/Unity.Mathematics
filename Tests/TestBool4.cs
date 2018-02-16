using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestBool4
    {
        [Test]
        public void bool4_ConstructorOneArgument_CreateNewObject_CheckAgainstOriginalValues(
            [Values(false, true)] bool originalValue)
        {
            bool4 testValue = new bool4(originalValue);
            Assert.AreEqual(testValue.x, (bool1)originalValue);
            Assert.AreEqual(testValue.y, (bool1)originalValue);
            Assert.AreEqual(testValue.z, (bool1)originalValue);
            Assert.AreEqual(testValue.w, (bool1)originalValue);
        }

        [Test]
        public void bool4_ConstructorTwoArguments_CreateNewObject_CheckAgainstOriginalValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool3 xyz = new bool3(firstArgument, secondArgument, thirdArgument);
            bool4 testValue = new bool4(xyz, fourthArgument);
            Assert.AreEqual(testValue.x, (bool1)firstArgument);
            Assert.AreEqual(testValue.y, (bool1)secondArgument);
            Assert.AreEqual(testValue.z, (bool1)thirdArgument);
            Assert.AreEqual(testValue.w, (bool1)fourthArgument);
        }

        [Test]
        public void bool4_ConstructorFourArguments_CreateNewObject_CheckAgainstOriginalValues(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 testValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(testValue.x, (bool1)firstArgument);
            Assert.AreEqual(testValue.y, (bool1)secondArgument);
            Assert.AreEqual(testValue.z, (bool1)thirdArgument);
            Assert.AreEqual(testValue.w, (bool1)fourthArgument);
        }

        [Test]
        public void bool4_OperatorBool4_CompareCastBoolWithObject_ReturnSameValue(
            [Values(false, true)] bool originalValue)
        {
            bool4 testValue = new bool4(originalValue);
            Assert.AreEqual((bool4)originalValue, testValue);
        }

        [Test]
        public void bool4_ToString_PrintAll_ReturnExpectedFormat(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            string expectedString = "bool4(" + firstArgument + ", " + secondArgument + ", " + thirdArgument + ", " + fourthArgument + ")";
            bool4 testValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(testValue.ToString(), expectedString);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_AreSame(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(true), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_XIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, secondArgument, thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(false, true, true, true), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_YIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, !secondArgument, thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(true, false, true, true), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_ZIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, secondArgument, !thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(true, true, false, true), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_WIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, secondArgument, thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(true, true, true, false), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_XYAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, !secondArgument, thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(false, false, true, true), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_XZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, secondArgument, !thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(false, true, false, true), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_XWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, secondArgument, thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(false, true, true, false), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_YZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, !secondArgument, !thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(true, false, false, true), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_YWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, !secondArgument, thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(true, false, true, false), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_ZWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, secondArgument, !thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(true, true, false, false), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_XYZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, !secondArgument, !thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(false, false, false, true), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_XYWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, !secondArgument, thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(false, false, true, false), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_YZWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, !secondArgument, !thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(true, false, false, false), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareTwoBool4_XYZWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
            [Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, !secondArgument, !thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(false, false, false, false), firstValue == secondValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareBoolWithBool4_AreSame(
            [Values(false, true)] bool firstArgument)
        {
            bool4 firstValue = new bool4(firstArgument);

            Assert.AreEqual(new bool4(true), firstValue == firstArgument);
            Assert.AreEqual(new bool4(true), firstArgument == firstValue);
        }

        [Test]
        public void bool4_OperatorEqual_CompareBoolWithBool4_AreDifferent(
            [Values(false, true)] bool firstArgument)
        {
            bool4 firstValue = new bool4(!firstArgument);

            Assert.AreEqual(new bool4(false), firstValue == firstArgument);
            Assert.AreEqual(new bool4(false), firstArgument == firstValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_AreSame(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(false), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_XIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, secondArgument, thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(true, false, false, false), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_YIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, !secondArgument, thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(false, true, false, false), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_ZIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, secondArgument, !thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(false, false, true, false), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_WIsDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, secondArgument, thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(false, false, false, true), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_XYAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, !secondArgument, thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(true, true, false, false), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_XZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, secondArgument, !thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(true, false, true, false), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_XWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, secondArgument, thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(true, false, false, true), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_YZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, !secondArgument, !thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(false, true, true, false), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_YWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, !secondArgument, thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(false, true, false, true), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_ZWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, secondArgument, !thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(false, false, true, true), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_XYZAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, !secondArgument, !thirdArgument, fourthArgument);

            Assert.AreEqual(new bool4(true, true, true, false), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_XYWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, !secondArgument, thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(true, true, false, true), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_YZWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(firstArgument, !secondArgument, !thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(false, true, true, true), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareTwoBool4_XYZWAreDifferent(
            [Values(false, true)] bool firstArgument,
            [Values(false, true)] bool secondArgument,
			[Values(false, true)] bool thirdArgument,
			[Values(false, true)] bool fourthArgument)
        {
            bool4 firstValue = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            bool4 secondValue = new bool4(!firstArgument, !secondArgument, !thirdArgument, !fourthArgument);

            Assert.AreEqual(new bool4(true, true, true, true), firstValue != secondValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareBoolWithBool4_AreSame(
            [Values(false, true)] bool firstArgument)
        {
            bool4 firstValue = new bool4(firstArgument);

            Assert.AreEqual(new bool4(false), firstValue != firstArgument);
            Assert.AreEqual(new bool4(false), firstArgument != firstValue);
        }

        [Test]
        public void bool4_OperatorNotEqual_CompareBoolWithBool4_AreDifferent(
            [Values(false, true)] bool firstArgument)
        {
            bool4 firstValue = new bool4(!firstArgument);

            Assert.AreEqual(new bool4(true), firstValue != firstArgument);
            Assert.AreEqual(new bool4(true), firstArgument != firstValue);
        }

        [Test]
        public void bool4_OperatorAND_BothBool4_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool4 firstValue = new bool4(argument);
            bool4 zeroValue = new bool4(false);

            Assert.AreEqual(new bool4(false), firstValue & zeroValue);
        }

        [Test]
        public void bool4_OperatorAND_BothBool4_ReturnTrue()
        {
            bool4 firstValue = new bool4(true);
            bool4 secondValue = new bool4(true);

            Assert.AreEqual(new bool4(true), firstValue & secondValue);
        }

        [Test]
        public void bool4_OperatorAND_BoolANDBool4_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool4 firstValue = new bool4(argument);

            Assert.AreEqual(new bool4(false), firstValue & false);
            Assert.AreEqual(new bool4(false), false & firstValue);
        }

        [Test]
        public void bool4_OperatorAND_BoolANDBool4_ReturnTrue()
        {
            bool4 firstValue = new bool4(true);

            Assert.AreEqual(new bool4(true), firstValue & true);
            Assert.AreEqual(new bool4(true), true & firstValue);
        }

        [Test]
        public void bool4_OperatorOR_BothBool4_ReturnFalse()
        {
            bool4 firstValue = new bool4(false);
            bool4 secondValue = new bool4(false);

            Assert.AreEqual(new bool4(false), firstValue | secondValue);
        }

        [Test]
        public void bool4_OperatorOR_BothBool4_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool4 firstValue = new bool4(argument);
            bool4 secondValue = new bool4(true);

            Assert.AreEqual(new bool4(true), firstValue | secondValue);
        }

        [Test]
        public void bool4_OperatorOR_BoolORBool4_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool4 firstValue = new bool4(argument);

            Assert.AreEqual(new bool4(true), firstValue | true);
            Assert.AreEqual(new bool4(true), true | firstValue);
        }

        [Test]
        public void bool4_OperatorOR_BoolORBool4_ReturnFalse()
        {
            bool4 firstValue = new bool4(false);

            Assert.AreEqual(new bool4(false), firstValue | false);
            Assert.AreEqual(new bool4(false), false | firstValue);
        }

        [Test]
        public void bool4_OperatorXOR_BothBool4_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool4 firstValue = new bool4(argument);
            bool4 secondValue = new bool4(!argument);

            Assert.AreEqual(new bool4(true), firstValue ^ secondValue);
        }

        [Test]
        public void bool4_OperatorXOR_BothBool4_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool4 firstValue = new bool4(argument);
            bool4 secondValue = new bool4(argument);

            Assert.AreEqual(new bool4(false), firstValue ^ secondValue);
        }

        [Test]
        public void bool4_OperatorXOR_BoolORBool4_ReturnTrue(
            [Values(false, true)] bool argument)
        {
            bool4 firstValue = new bool4(argument);
            bool notArgument = !argument;

            Assert.AreEqual(new bool4(true), firstValue ^ notArgument);
            Assert.AreEqual(new bool4(true), notArgument ^ firstValue);
        }

        [Test]
        public void bool4_OperatorXOR_BoolORBool4_ReturnFalse(
            [Values(false, true)] bool argument)
        {
            bool4 firstValue = new bool4(argument);

            Assert.AreEqual(new bool4(false), firstValue ^ argument);
            Assert.AreEqual(new bool4(false), argument ^ firstValue);
        }
        [Test]
        public void Swizzle_xx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(firstArgument,firstArgument), value.xx);
        }

        [Test]
        public void Swizzle_xy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(firstArgument,secondArgument), value.xy);
        }

        [Test]
        public void Swizzle_xz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(firstArgument,thirdArgument), value.xz);
        }

        [Test]
        public void Swizzle_xw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(firstArgument,fourthArgument), value.xw);
        }

        [Test]
        public void Swizzle_yx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(secondArgument,firstArgument), value.yx);
        }

        [Test]
        public void Swizzle_yy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(secondArgument,secondArgument), value.yy);
        }

        [Test]
        public void Swizzle_yz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(secondArgument,thirdArgument), value.yz);
        }

        [Test]
        public void Swizzle_yw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(secondArgument,fourthArgument), value.yw);
        }

        [Test]
        public void Swizzle_zx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(thirdArgument,firstArgument), value.zx);
        }

        [Test]
        public void Swizzle_zy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(thirdArgument,secondArgument), value.zy);
        }

        [Test]
        public void Swizzle_zz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(thirdArgument,thirdArgument), value.zz);
        }

        [Test]
        public void Swizzle_zw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(thirdArgument,fourthArgument), value.zw);
        }

        [Test]
        public void Swizzle_wx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(fourthArgument,firstArgument), value.wx);
        }

        [Test]
        public void Swizzle_wy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(fourthArgument,secondArgument), value.wy);
        }

        [Test]
        public void Swizzle_wz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(fourthArgument,thirdArgument), value.wz);
        }

        [Test]
        public void Swizzle_ww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool2(fourthArgument,fourthArgument), value.ww);
        }

        [Test]
        public void Swizzle_xxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,firstArgument,firstArgument), value.xxx);
        }

        [Test]
        public void Swizzle_xxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,firstArgument,secondArgument), value.xxy);
        }

        [Test]
        public void Swizzle_xxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,firstArgument,thirdArgument), value.xxz);
        }

        [Test]
        public void Swizzle_xxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,firstArgument,fourthArgument), value.xxw);
        }

        [Test]
        public void Swizzle_xyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,secondArgument,firstArgument), value.xyx);
        }

        [Test]
        public void Swizzle_xyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,secondArgument,secondArgument), value.xyy);
        }

        [Test]
        public void Swizzle_xyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,secondArgument,thirdArgument), value.xyz);
        }

        [Test]
        public void Swizzle_xyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,secondArgument,fourthArgument), value.xyw);
        }

        [Test]
        public void Swizzle_xzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,thirdArgument,firstArgument), value.xzx);
        }

        [Test]
        public void Swizzle_xzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,thirdArgument,secondArgument), value.xzy);
        }

        [Test]
        public void Swizzle_xzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,thirdArgument,thirdArgument), value.xzz);
        }

        [Test]
        public void Swizzle_xzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,thirdArgument,fourthArgument), value.xzw);
        }

        [Test]
        public void Swizzle_xwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,fourthArgument,firstArgument), value.xwx);
        }

        [Test]
        public void Swizzle_xwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,fourthArgument,secondArgument), value.xwy);
        }

        [Test]
        public void Swizzle_xwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,fourthArgument,thirdArgument), value.xwz);
        }

        [Test]
        public void Swizzle_xww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(firstArgument,fourthArgument,fourthArgument), value.xww);
        }

        [Test]
        public void Swizzle_yxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,firstArgument,firstArgument), value.yxx);
        }

        [Test]
        public void Swizzle_yxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,firstArgument,secondArgument), value.yxy);
        }

        [Test]
        public void Swizzle_yxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,firstArgument,thirdArgument), value.yxz);
        }

        [Test]
        public void Swizzle_yxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,firstArgument,fourthArgument), value.yxw);
        }

        [Test]
        public void Swizzle_yyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,secondArgument,firstArgument), value.yyx);
        }

        [Test]
        public void Swizzle_yyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,secondArgument,secondArgument), value.yyy);
        }

        [Test]
        public void Swizzle_yyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,secondArgument,thirdArgument), value.yyz);
        }

        [Test]
        public void Swizzle_yyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,secondArgument,fourthArgument), value.yyw);
        }

        [Test]
        public void Swizzle_yzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,thirdArgument,firstArgument), value.yzx);
        }

        [Test]
        public void Swizzle_yzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,thirdArgument,secondArgument), value.yzy);
        }

        [Test]
        public void Swizzle_yzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,thirdArgument,thirdArgument), value.yzz);
        }

        [Test]
        public void Swizzle_yzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,thirdArgument,fourthArgument), value.yzw);
        }

        [Test]
        public void Swizzle_ywx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,fourthArgument,firstArgument), value.ywx);
        }

        [Test]
        public void Swizzle_ywy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,fourthArgument,secondArgument), value.ywy);
        }

        [Test]
        public void Swizzle_ywz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,fourthArgument,thirdArgument), value.ywz);
        }

        [Test]
        public void Swizzle_yww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(secondArgument,fourthArgument,fourthArgument), value.yww);
        }

        [Test]
        public void Swizzle_zxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,firstArgument,firstArgument), value.zxx);
        }

        [Test]
        public void Swizzle_zxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,firstArgument,secondArgument), value.zxy);
        }

        [Test]
        public void Swizzle_zxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,firstArgument,thirdArgument), value.zxz);
        }

        [Test]
        public void Swizzle_zxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,firstArgument,fourthArgument), value.zxw);
        }

        [Test]
        public void Swizzle_zyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,secondArgument,firstArgument), value.zyx);
        }

        [Test]
        public void Swizzle_zyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,secondArgument,secondArgument), value.zyy);
        }

        [Test]
        public void Swizzle_zyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,secondArgument,thirdArgument), value.zyz);
        }

        [Test]
        public void Swizzle_zyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,secondArgument,fourthArgument), value.zyw);
        }

        [Test]
        public void Swizzle_zzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,thirdArgument,firstArgument), value.zzx);
        }

        [Test]
        public void Swizzle_zzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,thirdArgument,secondArgument), value.zzy);
        }

        [Test]
        public void Swizzle_zzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,thirdArgument,thirdArgument), value.zzz);
        }

        [Test]
        public void Swizzle_zzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,thirdArgument,fourthArgument), value.zzw);
        }

        [Test]
        public void Swizzle_zwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,fourthArgument,firstArgument), value.zwx);
        }

        [Test]
        public void Swizzle_zwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,fourthArgument,secondArgument), value.zwy);
        }

        [Test]
        public void Swizzle_zwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,fourthArgument,thirdArgument), value.zwz);
        }

        [Test]
        public void Swizzle_zww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(thirdArgument,fourthArgument,fourthArgument), value.zww);
        }

        [Test]
        public void Swizzle_wxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,firstArgument,firstArgument), value.wxx);
        }

        [Test]
        public void Swizzle_wxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,firstArgument,secondArgument), value.wxy);
        }

        [Test]
        public void Swizzle_wxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,firstArgument,thirdArgument), value.wxz);
        }

        [Test]
        public void Swizzle_wxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,firstArgument,fourthArgument), value.wxw);
        }

        [Test]
        public void Swizzle_wyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,secondArgument,firstArgument), value.wyx);
        }

        [Test]
        public void Swizzle_wyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,secondArgument,secondArgument), value.wyy);
        }

        [Test]
        public void Swizzle_wyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,secondArgument,thirdArgument), value.wyz);
        }

        [Test]
        public void Swizzle_wyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,secondArgument,fourthArgument), value.wyw);
        }

        [Test]
        public void Swizzle_wzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,thirdArgument,firstArgument), value.wzx);
        }

        [Test]
        public void Swizzle_wzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,thirdArgument,secondArgument), value.wzy);
        }

        [Test]
        public void Swizzle_wzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,thirdArgument,thirdArgument), value.wzz);
        }

        [Test]
        public void Swizzle_wzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,thirdArgument,fourthArgument), value.wzw);
        }

        [Test]
        public void Swizzle_wwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,fourthArgument,firstArgument), value.wwx);
        }

        [Test]
        public void Swizzle_wwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,fourthArgument,secondArgument), value.wwy);
        }

        [Test]
        public void Swizzle_wwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,fourthArgument,thirdArgument), value.wwz);
        }

        [Test]
        public void Swizzle_www_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool3(fourthArgument,fourthArgument,fourthArgument), value.www);
        }

        [Test]
        public void Swizzle_xxxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,firstArgument,firstArgument), value.xxxx);
        }

        [Test]
        public void Swizzle_xxxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,firstArgument,secondArgument), value.xxxy);
        }

        [Test]
        public void Swizzle_xxxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,firstArgument,thirdArgument), value.xxxz);
        }

        [Test]
        public void Swizzle_xxxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,firstArgument,fourthArgument), value.xxxw);
        }

        [Test]
        public void Swizzle_xxyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,secondArgument,firstArgument), value.xxyx);
        }

        [Test]
        public void Swizzle_xxyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,secondArgument,secondArgument), value.xxyy);
        }

        [Test]
        public void Swizzle_xxyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,secondArgument,thirdArgument), value.xxyz);
        }

        [Test]
        public void Swizzle_xxyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,secondArgument,fourthArgument), value.xxyw);
        }

        [Test]
        public void Swizzle_xxzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,thirdArgument,firstArgument), value.xxzx);
        }

        [Test]
        public void Swizzle_xxzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,thirdArgument,secondArgument), value.xxzy);
        }

        [Test]
        public void Swizzle_xxzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,thirdArgument,thirdArgument), value.xxzz);
        }

        [Test]
        public void Swizzle_xxzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,thirdArgument,fourthArgument), value.xxzw);
        }

        [Test]
        public void Swizzle_xxwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,fourthArgument,firstArgument), value.xxwx);
        }

        [Test]
        public void Swizzle_xxwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,fourthArgument,secondArgument), value.xxwy);
        }

        [Test]
        public void Swizzle_xxwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,fourthArgument,thirdArgument), value.xxwz);
        }

        [Test]
        public void Swizzle_xxww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,firstArgument,fourthArgument,fourthArgument), value.xxww);
        }

        [Test]
        public void Swizzle_xyxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,firstArgument,firstArgument), value.xyxx);
        }

        [Test]
        public void Swizzle_xyxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,firstArgument,secondArgument), value.xyxy);
        }

        [Test]
        public void Swizzle_xyxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,firstArgument,thirdArgument), value.xyxz);
        }

        [Test]
        public void Swizzle_xyxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,firstArgument,fourthArgument), value.xyxw);
        }

        [Test]
        public void Swizzle_xyyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,secondArgument,firstArgument), value.xyyx);
        }

        [Test]
        public void Swizzle_xyyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,secondArgument,secondArgument), value.xyyy);
        }

        [Test]
        public void Swizzle_xyyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,secondArgument,thirdArgument), value.xyyz);
        }

        [Test]
        public void Swizzle_xyyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,secondArgument,fourthArgument), value.xyyw);
        }

        [Test]
        public void Swizzle_xyzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,thirdArgument,firstArgument), value.xyzx);
        }

        [Test]
        public void Swizzle_xyzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,thirdArgument,secondArgument), value.xyzy);
        }

        [Test]
        public void Swizzle_xyzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,thirdArgument,thirdArgument), value.xyzz);
        }

        [Test]
        public void Swizzle_xyzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,thirdArgument,fourthArgument), value.xyzw);
        }

        [Test]
        public void Swizzle_xywx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,fourthArgument,firstArgument), value.xywx);
        }

        [Test]
        public void Swizzle_xywy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,fourthArgument,secondArgument), value.xywy);
        }

        [Test]
        public void Swizzle_xywz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,fourthArgument,thirdArgument), value.xywz);
        }

        [Test]
        public void Swizzle_xyww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,secondArgument,fourthArgument,fourthArgument), value.xyww);
        }

        [Test]
        public void Swizzle_xzxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,firstArgument,firstArgument), value.xzxx);
        }

        [Test]
        public void Swizzle_xzxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,firstArgument,secondArgument), value.xzxy);
        }

        [Test]
        public void Swizzle_xzxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,firstArgument,thirdArgument), value.xzxz);
        }

        [Test]
        public void Swizzle_xzxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,firstArgument,fourthArgument), value.xzxw);
        }

        [Test]
        public void Swizzle_xzyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,secondArgument,firstArgument), value.xzyx);
        }

        [Test]
        public void Swizzle_xzyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,secondArgument,secondArgument), value.xzyy);
        }

        [Test]
        public void Swizzle_xzyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,secondArgument,thirdArgument), value.xzyz);
        }

        [Test]
        public void Swizzle_xzyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,secondArgument,fourthArgument), value.xzyw);
        }

        [Test]
        public void Swizzle_xzzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,thirdArgument,firstArgument), value.xzzx);
        }

        [Test]
        public void Swizzle_xzzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,thirdArgument,secondArgument), value.xzzy);
        }

        [Test]
        public void Swizzle_xzzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,thirdArgument,thirdArgument), value.xzzz);
        }

        [Test]
        public void Swizzle_xzzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,thirdArgument,fourthArgument), value.xzzw);
        }

        [Test]
        public void Swizzle_xzwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,fourthArgument,firstArgument), value.xzwx);
        }

        [Test]
        public void Swizzle_xzwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,fourthArgument,secondArgument), value.xzwy);
        }

        [Test]
        public void Swizzle_xzwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,fourthArgument,thirdArgument), value.xzwz);
        }

        [Test]
        public void Swizzle_xzww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,thirdArgument,fourthArgument,fourthArgument), value.xzww);
        }

        [Test]
        public void Swizzle_xwxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,firstArgument,firstArgument), value.xwxx);
        }

        [Test]
        public void Swizzle_xwxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,firstArgument,secondArgument), value.xwxy);
        }

        [Test]
        public void Swizzle_xwxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,firstArgument,thirdArgument), value.xwxz);
        }

        [Test]
        public void Swizzle_xwxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,firstArgument,fourthArgument), value.xwxw);
        }

        [Test]
        public void Swizzle_xwyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,secondArgument,firstArgument), value.xwyx);
        }

        [Test]
        public void Swizzle_xwyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,secondArgument,secondArgument), value.xwyy);
        }

        [Test]
        public void Swizzle_xwyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,secondArgument,thirdArgument), value.xwyz);
        }

        [Test]
        public void Swizzle_xwyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,secondArgument,fourthArgument), value.xwyw);
        }

        [Test]
        public void Swizzle_xwzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,thirdArgument,firstArgument), value.xwzx);
        }

        [Test]
        public void Swizzle_xwzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,thirdArgument,secondArgument), value.xwzy);
        }

        [Test]
        public void Swizzle_xwzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,thirdArgument,thirdArgument), value.xwzz);
        }

        [Test]
        public void Swizzle_xwzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,thirdArgument,fourthArgument), value.xwzw);
        }

        [Test]
        public void Swizzle_xwwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,fourthArgument,firstArgument), value.xwwx);
        }

        [Test]
        public void Swizzle_xwwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,fourthArgument,secondArgument), value.xwwy);
        }

        [Test]
        public void Swizzle_xwwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,fourthArgument,thirdArgument), value.xwwz);
        }

        [Test]
        public void Swizzle_xwww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(firstArgument,fourthArgument,fourthArgument,fourthArgument), value.xwww);
        }

        [Test]
        public void Swizzle_yxxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,firstArgument,firstArgument), value.yxxx);
        }

        [Test]
        public void Swizzle_yxxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,firstArgument,secondArgument), value.yxxy);
        }

        [Test]
        public void Swizzle_yxxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,firstArgument,thirdArgument), value.yxxz);
        }

        [Test]
        public void Swizzle_yxxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,firstArgument,fourthArgument), value.yxxw);
        }

        [Test]
        public void Swizzle_yxyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,secondArgument,firstArgument), value.yxyx);
        }

        [Test]
        public void Swizzle_yxyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,secondArgument,secondArgument), value.yxyy);
        }

        [Test]
        public void Swizzle_yxyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,secondArgument,thirdArgument), value.yxyz);
        }

        [Test]
        public void Swizzle_yxyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,secondArgument,fourthArgument), value.yxyw);
        }

        [Test]
        public void Swizzle_yxzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,thirdArgument,firstArgument), value.yxzx);
        }

        [Test]
        public void Swizzle_yxzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,thirdArgument,secondArgument), value.yxzy);
        }

        [Test]
        public void Swizzle_yxzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,thirdArgument,thirdArgument), value.yxzz);
        }

        [Test]
        public void Swizzle_yxzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,thirdArgument,fourthArgument), value.yxzw);
        }

        [Test]
        public void Swizzle_yxwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,fourthArgument,firstArgument), value.yxwx);
        }

        [Test]
        public void Swizzle_yxwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,fourthArgument,secondArgument), value.yxwy);
        }

        [Test]
        public void Swizzle_yxwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,fourthArgument,thirdArgument), value.yxwz);
        }

        [Test]
        public void Swizzle_yxww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,firstArgument,fourthArgument,fourthArgument), value.yxww);
        }

        [Test]
        public void Swizzle_yyxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,firstArgument,firstArgument), value.yyxx);
        }

        [Test]
        public void Swizzle_yyxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,firstArgument,secondArgument), value.yyxy);
        }

        [Test]
        public void Swizzle_yyxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,firstArgument,thirdArgument), value.yyxz);
        }

        [Test]
        public void Swizzle_yyxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,firstArgument,fourthArgument), value.yyxw);
        }

        [Test]
        public void Swizzle_yyyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,secondArgument,firstArgument), value.yyyx);
        }

        [Test]
        public void Swizzle_yyyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,secondArgument,secondArgument), value.yyyy);
        }

        [Test]
        public void Swizzle_yyyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,secondArgument,thirdArgument), value.yyyz);
        }

        [Test]
        public void Swizzle_yyyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,secondArgument,fourthArgument), value.yyyw);
        }

        [Test]
        public void Swizzle_yyzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,thirdArgument,firstArgument), value.yyzx);
        }

        [Test]
        public void Swizzle_yyzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,thirdArgument,secondArgument), value.yyzy);
        }

        [Test]
        public void Swizzle_yyzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,thirdArgument,thirdArgument), value.yyzz);
        }

        [Test]
        public void Swizzle_yyzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,thirdArgument,fourthArgument), value.yyzw);
        }

        [Test]
        public void Swizzle_yywx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,fourthArgument,firstArgument), value.yywx);
        }

        [Test]
        public void Swizzle_yywy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,fourthArgument,secondArgument), value.yywy);
        }

        [Test]
        public void Swizzle_yywz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,fourthArgument,thirdArgument), value.yywz);
        }

        [Test]
        public void Swizzle_yyww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,secondArgument,fourthArgument,fourthArgument), value.yyww);
        }

        [Test]
        public void Swizzle_yzxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,firstArgument,firstArgument), value.yzxx);
        }

        [Test]
        public void Swizzle_yzxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,firstArgument,secondArgument), value.yzxy);
        }

        [Test]
        public void Swizzle_yzxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,firstArgument,thirdArgument), value.yzxz);
        }

        [Test]
        public void Swizzle_yzxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,firstArgument,fourthArgument), value.yzxw);
        }

        [Test]
        public void Swizzle_yzyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,secondArgument,firstArgument), value.yzyx);
        }

        [Test]
        public void Swizzle_yzyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,secondArgument,secondArgument), value.yzyy);
        }

        [Test]
        public void Swizzle_yzyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,secondArgument,thirdArgument), value.yzyz);
        }

        [Test]
        public void Swizzle_yzyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,secondArgument,fourthArgument), value.yzyw);
        }

        [Test]
        public void Swizzle_yzzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,thirdArgument,firstArgument), value.yzzx);
        }

        [Test]
        public void Swizzle_yzzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,thirdArgument,secondArgument), value.yzzy);
        }

        [Test]
        public void Swizzle_yzzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,thirdArgument,thirdArgument), value.yzzz);
        }

        [Test]
        public void Swizzle_yzzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,thirdArgument,fourthArgument), value.yzzw);
        }

        [Test]
        public void Swizzle_yzwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,fourthArgument,firstArgument), value.yzwx);
        }

        [Test]
        public void Swizzle_yzwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,fourthArgument,secondArgument), value.yzwy);
        }

        [Test]
        public void Swizzle_yzwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,fourthArgument,thirdArgument), value.yzwz);
        }

        [Test]
        public void Swizzle_yzww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,thirdArgument,fourthArgument,fourthArgument), value.yzww);
        }

        [Test]
        public void Swizzle_ywxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,firstArgument,firstArgument), value.ywxx);
        }

        [Test]
        public void Swizzle_ywxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,firstArgument,secondArgument), value.ywxy);
        }

        [Test]
        public void Swizzle_ywxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,firstArgument,thirdArgument), value.ywxz);
        }

        [Test]
        public void Swizzle_ywxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,firstArgument,fourthArgument), value.ywxw);
        }

        [Test]
        public void Swizzle_ywyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,secondArgument,firstArgument), value.ywyx);
        }

        [Test]
        public void Swizzle_ywyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,secondArgument,secondArgument), value.ywyy);
        }

        [Test]
        public void Swizzle_ywyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,secondArgument,thirdArgument), value.ywyz);
        }

        [Test]
        public void Swizzle_ywyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,secondArgument,fourthArgument), value.ywyw);
        }

        [Test]
        public void Swizzle_ywzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,thirdArgument,firstArgument), value.ywzx);
        }

        [Test]
        public void Swizzle_ywzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,thirdArgument,secondArgument), value.ywzy);
        }

        [Test]
        public void Swizzle_ywzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,thirdArgument,thirdArgument), value.ywzz);
        }

        [Test]
        public void Swizzle_ywzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,thirdArgument,fourthArgument), value.ywzw);
        }

        [Test]
        public void Swizzle_ywwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,fourthArgument,firstArgument), value.ywwx);
        }

        [Test]
        public void Swizzle_ywwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,fourthArgument,secondArgument), value.ywwy);
        }

        [Test]
        public void Swizzle_ywwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,fourthArgument,thirdArgument), value.ywwz);
        }

        [Test]
        public void Swizzle_ywww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(secondArgument,fourthArgument,fourthArgument,fourthArgument), value.ywww);
        }

        [Test]
        public void Swizzle_zxxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,firstArgument,firstArgument), value.zxxx);
        }

        [Test]
        public void Swizzle_zxxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,firstArgument,secondArgument), value.zxxy);
        }

        [Test]
        public void Swizzle_zxxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,firstArgument,thirdArgument), value.zxxz);
        }

        [Test]
        public void Swizzle_zxxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,firstArgument,fourthArgument), value.zxxw);
        }

        [Test]
        public void Swizzle_zxyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,secondArgument,firstArgument), value.zxyx);
        }

        [Test]
        public void Swizzle_zxyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,secondArgument,secondArgument), value.zxyy);
        }

        [Test]
        public void Swizzle_zxyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,secondArgument,thirdArgument), value.zxyz);
        }

        [Test]
        public void Swizzle_zxyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,secondArgument,fourthArgument), value.zxyw);
        }

        [Test]
        public void Swizzle_zxzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,thirdArgument,firstArgument), value.zxzx);
        }

        [Test]
        public void Swizzle_zxzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,thirdArgument,secondArgument), value.zxzy);
        }

        [Test]
        public void Swizzle_zxzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,thirdArgument,thirdArgument), value.zxzz);
        }

        [Test]
        public void Swizzle_zxzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,thirdArgument,fourthArgument), value.zxzw);
        }

        [Test]
        public void Swizzle_zxwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,fourthArgument,firstArgument), value.zxwx);
        }

        [Test]
        public void Swizzle_zxwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,fourthArgument,secondArgument), value.zxwy);
        }

        [Test]
        public void Swizzle_zxwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,fourthArgument,thirdArgument), value.zxwz);
        }

        [Test]
        public void Swizzle_zxww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,firstArgument,fourthArgument,fourthArgument), value.zxww);
        }

        [Test]
        public void Swizzle_zyxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,firstArgument,firstArgument), value.zyxx);
        }

        [Test]
        public void Swizzle_zyxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,firstArgument,secondArgument), value.zyxy);
        }

        [Test]
        public void Swizzle_zyxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,firstArgument,thirdArgument), value.zyxz);
        }

        [Test]
        public void Swizzle_zyxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,firstArgument,fourthArgument), value.zyxw);
        }

        [Test]
        public void Swizzle_zyyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,secondArgument,firstArgument), value.zyyx);
        }

        [Test]
        public void Swizzle_zyyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,secondArgument,secondArgument), value.zyyy);
        }

        [Test]
        public void Swizzle_zyyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,secondArgument,thirdArgument), value.zyyz);
        }

        [Test]
        public void Swizzle_zyyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,secondArgument,fourthArgument), value.zyyw);
        }

        [Test]
        public void Swizzle_zyzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,thirdArgument,firstArgument), value.zyzx);
        }

        [Test]
        public void Swizzle_zyzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,thirdArgument,secondArgument), value.zyzy);
        }

        [Test]
        public void Swizzle_zyzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,thirdArgument,thirdArgument), value.zyzz);
        }

        [Test]
        public void Swizzle_zyzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,thirdArgument,fourthArgument), value.zyzw);
        }

        [Test]
        public void Swizzle_zywx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,fourthArgument,firstArgument), value.zywx);
        }

        [Test]
        public void Swizzle_zywy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,fourthArgument,secondArgument), value.zywy);
        }

        [Test]
        public void Swizzle_zywz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,fourthArgument,thirdArgument), value.zywz);
        }

        [Test]
        public void Swizzle_zyww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,secondArgument,fourthArgument,fourthArgument), value.zyww);
        }

        [Test]
        public void Swizzle_zzxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,firstArgument,firstArgument), value.zzxx);
        }

        [Test]
        public void Swizzle_zzxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,firstArgument,secondArgument), value.zzxy);
        }

        [Test]
        public void Swizzle_zzxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,firstArgument,thirdArgument), value.zzxz);
        }

        [Test]
        public void Swizzle_zzxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,firstArgument,fourthArgument), value.zzxw);
        }

        [Test]
        public void Swizzle_zzyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,secondArgument,firstArgument), value.zzyx);
        }

        [Test]
        public void Swizzle_zzyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,secondArgument,secondArgument), value.zzyy);
        }

        [Test]
        public void Swizzle_zzyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,secondArgument,thirdArgument), value.zzyz);
        }

        [Test]
        public void Swizzle_zzyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,secondArgument,fourthArgument), value.zzyw);
        }

        [Test]
        public void Swizzle_zzzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,thirdArgument,firstArgument), value.zzzx);
        }

        [Test]
        public void Swizzle_zzzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,thirdArgument,secondArgument), value.zzzy);
        }

        [Test]
        public void Swizzle_zzzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,thirdArgument,thirdArgument), value.zzzz);
        }

        [Test]
        public void Swizzle_zzzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,thirdArgument,fourthArgument), value.zzzw);
        }

        [Test]
        public void Swizzle_zzwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,fourthArgument,firstArgument), value.zzwx);
        }

        [Test]
        public void Swizzle_zzwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,fourthArgument,secondArgument), value.zzwy);
        }

        [Test]
        public void Swizzle_zzwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,fourthArgument,thirdArgument), value.zzwz);
        }

        [Test]
        public void Swizzle_zzww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,thirdArgument,fourthArgument,fourthArgument), value.zzww);
        }

        [Test]
        public void Swizzle_zwxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,firstArgument,firstArgument), value.zwxx);
        }

        [Test]
        public void Swizzle_zwxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,firstArgument,secondArgument), value.zwxy);
        }

        [Test]
        public void Swizzle_zwxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,firstArgument,thirdArgument), value.zwxz);
        }

        [Test]
        public void Swizzle_zwxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,firstArgument,fourthArgument), value.zwxw);
        }

        [Test]
        public void Swizzle_zwyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,secondArgument,firstArgument), value.zwyx);
        }

        [Test]
        public void Swizzle_zwyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,secondArgument,secondArgument), value.zwyy);
        }

        [Test]
        public void Swizzle_zwyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,secondArgument,thirdArgument), value.zwyz);
        }

        [Test]
        public void Swizzle_zwyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,secondArgument,fourthArgument), value.zwyw);
        }

        [Test]
        public void Swizzle_zwzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,thirdArgument,firstArgument), value.zwzx);
        }

        [Test]
        public void Swizzle_zwzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,thirdArgument,secondArgument), value.zwzy);
        }

        [Test]
        public void Swizzle_zwzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,thirdArgument,thirdArgument), value.zwzz);
        }

        [Test]
        public void Swizzle_zwzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,thirdArgument,fourthArgument), value.zwzw);
        }

        [Test]
        public void Swizzle_zwwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,fourthArgument,firstArgument), value.zwwx);
        }

        [Test]
        public void Swizzle_zwwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,fourthArgument,secondArgument), value.zwwy);
        }

        [Test]
        public void Swizzle_zwwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,fourthArgument,thirdArgument), value.zwwz);
        }

        [Test]
        public void Swizzle_zwww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(thirdArgument,fourthArgument,fourthArgument,fourthArgument), value.zwww);
        }

        [Test]
        public void Swizzle_wxxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,firstArgument,firstArgument), value.wxxx);
        }

        [Test]
        public void Swizzle_wxxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,firstArgument,secondArgument), value.wxxy);
        }

        [Test]
        public void Swizzle_wxxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,firstArgument,thirdArgument), value.wxxz);
        }

        [Test]
        public void Swizzle_wxxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,firstArgument,fourthArgument), value.wxxw);
        }

        [Test]
        public void Swizzle_wxyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,secondArgument,firstArgument), value.wxyx);
        }

        [Test]
        public void Swizzle_wxyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,secondArgument,secondArgument), value.wxyy);
        }

        [Test]
        public void Swizzle_wxyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,secondArgument,thirdArgument), value.wxyz);
        }

        [Test]
        public void Swizzle_wxyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,secondArgument,fourthArgument), value.wxyw);
        }

        [Test]
        public void Swizzle_wxzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,thirdArgument,firstArgument), value.wxzx);
        }

        [Test]
        public void Swizzle_wxzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,thirdArgument,secondArgument), value.wxzy);
        }

        [Test]
        public void Swizzle_wxzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,thirdArgument,thirdArgument), value.wxzz);
        }

        [Test]
        public void Swizzle_wxzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,thirdArgument,fourthArgument), value.wxzw);
        }

        [Test]
        public void Swizzle_wxwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,fourthArgument,firstArgument), value.wxwx);
        }

        [Test]
        public void Swizzle_wxwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,fourthArgument,secondArgument), value.wxwy);
        }

        [Test]
        public void Swizzle_wxwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,fourthArgument,thirdArgument), value.wxwz);
        }

        [Test]
        public void Swizzle_wxww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,firstArgument,fourthArgument,fourthArgument), value.wxww);
        }

        [Test]
        public void Swizzle_wyxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,firstArgument,firstArgument), value.wyxx);
        }

        [Test]
        public void Swizzle_wyxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,firstArgument,secondArgument), value.wyxy);
        }

        [Test]
        public void Swizzle_wyxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,firstArgument,thirdArgument), value.wyxz);
        }

        [Test]
        public void Swizzle_wyxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,firstArgument,fourthArgument), value.wyxw);
        }

        [Test]
        public void Swizzle_wyyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,secondArgument,firstArgument), value.wyyx);
        }

        [Test]
        public void Swizzle_wyyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,secondArgument,secondArgument), value.wyyy);
        }

        [Test]
        public void Swizzle_wyyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,secondArgument,thirdArgument), value.wyyz);
        }

        [Test]
        public void Swizzle_wyyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,secondArgument,fourthArgument), value.wyyw);
        }

        [Test]
        public void Swizzle_wyzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,thirdArgument,firstArgument), value.wyzx);
        }

        [Test]
        public void Swizzle_wyzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,thirdArgument,secondArgument), value.wyzy);
        }

        [Test]
        public void Swizzle_wyzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,thirdArgument,thirdArgument), value.wyzz);
        }

        [Test]
        public void Swizzle_wyzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,thirdArgument,fourthArgument), value.wyzw);
        }

        [Test]
        public void Swizzle_wywx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,fourthArgument,firstArgument), value.wywx);
        }

        [Test]
        public void Swizzle_wywy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,fourthArgument,secondArgument), value.wywy);
        }

        [Test]
        public void Swizzle_wywz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,fourthArgument,thirdArgument), value.wywz);
        }

        [Test]
        public void Swizzle_wyww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,secondArgument,fourthArgument,fourthArgument), value.wyww);
        }

        [Test]
        public void Swizzle_wzxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,firstArgument,firstArgument), value.wzxx);
        }

        [Test]
        public void Swizzle_wzxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,firstArgument,secondArgument), value.wzxy);
        }

        [Test]
        public void Swizzle_wzxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,firstArgument,thirdArgument), value.wzxz);
        }

        [Test]
        public void Swizzle_wzxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,firstArgument,fourthArgument), value.wzxw);
        }

        [Test]
        public void Swizzle_wzyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,secondArgument,firstArgument), value.wzyx);
        }

        [Test]
        public void Swizzle_wzyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,secondArgument,secondArgument), value.wzyy);
        }

        [Test]
        public void Swizzle_wzyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,secondArgument,thirdArgument), value.wzyz);
        }

        [Test]
        public void Swizzle_wzyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,secondArgument,fourthArgument), value.wzyw);
        }

        [Test]
        public void Swizzle_wzzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,thirdArgument,firstArgument), value.wzzx);
        }

        [Test]
        public void Swizzle_wzzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,thirdArgument,secondArgument), value.wzzy);
        }

        [Test]
        public void Swizzle_wzzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,thirdArgument,thirdArgument), value.wzzz);
        }

        [Test]
        public void Swizzle_wzzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,thirdArgument,fourthArgument), value.wzzw);
        }

        [Test]
        public void Swizzle_wzwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,fourthArgument,firstArgument), value.wzwx);
        }

        [Test]
        public void Swizzle_wzwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,fourthArgument,secondArgument), value.wzwy);
        }

        [Test]
        public void Swizzle_wzwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,fourthArgument,thirdArgument), value.wzwz);
        }

        [Test]
        public void Swizzle_wzww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,thirdArgument,fourthArgument,fourthArgument), value.wzww);
        }

        [Test]
        public void Swizzle_wwxx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,firstArgument,firstArgument), value.wwxx);
        }

        [Test]
        public void Swizzle_wwxy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,firstArgument,secondArgument), value.wwxy);
        }

        [Test]
        public void Swizzle_wwxz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,firstArgument,thirdArgument), value.wwxz);
        }

        [Test]
        public void Swizzle_wwxw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,firstArgument,fourthArgument), value.wwxw);
        }

        [Test]
        public void Swizzle_wwyx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,secondArgument,firstArgument), value.wwyx);
        }

        [Test]
        public void Swizzle_wwyy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,secondArgument,secondArgument), value.wwyy);
        }

        [Test]
        public void Swizzle_wwyz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,secondArgument,thirdArgument), value.wwyz);
        }

        [Test]
        public void Swizzle_wwyw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,secondArgument,fourthArgument), value.wwyw);
        }

        [Test]
        public void Swizzle_wwzx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,thirdArgument,firstArgument), value.wwzx);
        }

        [Test]
        public void Swizzle_wwzy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,thirdArgument,secondArgument), value.wwzy);
        }

        [Test]
        public void Swizzle_wwzz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,thirdArgument,thirdArgument), value.wwzz);
        }

        [Test]
        public void Swizzle_wwzw_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,thirdArgument,fourthArgument), value.wwzw);
        }

        [Test]
        public void Swizzle_wwwx_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,fourthArgument,firstArgument), value.wwwx);
        }

        [Test]
        public void Swizzle_wwwy_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,fourthArgument,secondArgument), value.wwwy);
        }

        [Test]
        public void Swizzle_wwwz_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,fourthArgument,thirdArgument), value.wwwz);
        }

        [Test]
        public void Swizzle_wwww_SameValues(
            [Values(false,true)] bool firstArgument,
            [Values(false,true)] bool secondArgument,
            [Values(false,true)] bool thirdArgument,
            [Values(false,true)] bool fourthArgument)
        {
            bool4 value = new bool4(firstArgument, secondArgument, thirdArgument, fourthArgument);
            Assert.AreEqual(new bool4(fourthArgument,fourthArgument,fourthArgument,fourthArgument), value.wwww);
        }
    }
}
