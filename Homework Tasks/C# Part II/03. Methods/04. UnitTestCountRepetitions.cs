using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCountRepetitions
{
    [TestClass]
    public class UnitTestCountRepetitions
    {
        [TestMethod]
        public void ArrayOfSearchedNumber()
        {
            int number = 5;
            int[] array = { 5, 5, 5, 5, 5, 5, 5};
            int expectedResult = array.Length;
            int countMethodResult = CountNumber.CountRepetitions(array, number);
            Assert.AreEqual(expectedResult, countMethodResult);
        }

        [TestMethod]
        public void FewRepetitions()
        {
            int number = 5;
            int[] array = { 5, 0, 4, 4, 3, 5, -8, 9, 6, 7, -4, 5 };
            int expectedResult = 3;
            int countMethodResult = CountNumber.CountRepetitions(array, number);
            Assert.AreEqual(expectedResult, countMethodResult);
        }

        [TestMethod]
        public void OneRepetition()
        {
            int number = -8;
            int[] array = { 0, 5, 4, 5, 3, 5, -8, 9, 6, 7, -4, 0 };
            int expectedResult = 1;
            int countMethodResult = CountNumber.CountRepetitions(array, number);
            Assert.AreEqual(expectedResult, countMethodResult);
        }

        [TestMethod]
        public void NoRepetition()
        {
            int number = -1;
            int[] array = { 0, 5, 4, 5, 3, 5, -8, 9, 6, 7, -4, 0 };
            int expectedResult = 0;
            int countMethodResult = CountNumber.CountRepetitions(array, number);
            Assert.AreEqual(expectedResult, countMethodResult);
        }
    }
}
