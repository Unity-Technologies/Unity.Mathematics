using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Unity.Mathematics.Tests
{
    [TestFixture]
    class TestBool1
    {
        [Test]
        public void bool1_Constructor_CreateEqualObjects_ReturnSameValue(
            [Values(false, true)] bool value)
        {
            bool1 firstValue = new bool1(value);
            bool1 secondValue = new bool1(value);
            Assert.AreEqual(firstValue, secondValue);
            Assert.AreNotSame(firstValue, secondValue);
        }

        [Test]
        public void bool1_Constructor_CreateDifferentObjects_ReturnDifferentValue(
            [Values(false, true)] bool value)
        {
            bool1 firstValue = new bool1(value);
            bool1 secondValue = new bool1(!value);
            Assert.AreNotEqual(firstValue, secondValue);
            Assert.AreNotSame(firstValue, secondValue);
        }

        [Test]
        public void bool1_OperatorBool_CompareWithOriginalValue_ReturnOriginalValue(
            [Values(false, true)] bool value)
        {
            bool1 testValue = new bool1(value);
            Assert.AreEqual(value, (bool)testValue);
        }

        [Test]
        public void bool1_OperatorBool1_CompareCastBoolWithObject_ReturnSameValue(
            [Values(false, true)] bool value)
        {
            bool1 testValue = new bool1(value);
            Assert.AreEqual((bool1)value, testValue);
        }

        [Test]
        public void bool1_ToString_PrintValue_SameStringAsNativeType(
            [Values(false, true)] bool value)
        {
            bool1 testValue = new bool1(value);
            Assert.AreEqual(testValue.ToString(), value.ToString());
        }
    }
}
