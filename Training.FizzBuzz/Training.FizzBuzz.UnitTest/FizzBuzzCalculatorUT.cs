using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.FizzBuzz.Business;

namespace Training.FizzBuzz.UnitTest
{
    [TestClass]
    public class FizzBuzzCalculatorUT
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberGreaterThanMaxLimit()
        {
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();
            calculator.CalculateNumber(0, 101);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberLowerThanMinLimit()
        {
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();
            calculator.CalculateNumber(-1, 100);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void NumberLowerThanMinLimitAndGreaterThanMaxLimit()
        {
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();
            calculator.CalculateNumber(-1, 101);
        }


        [TestMethod]
        public void ExpectedResultArrayLength101()
        {
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();
            string[] sArray = calculator.CalculateNumber(0, 100);           
            Assert.AreEqual(sArray.Length, 101);
        }

        [TestMethod]
        public void ExpectedResultThirtyFourFizz()
        {
           
            //Number divisible by 3
            //0, 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36, 39, 42, 45, 48, 51, 54, 57, 60, 63, 66, 69, 72, 
            //75, 78, 81, 84, 87, 90, 93, 96, and 99.
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();
            string[] sArray = calculator.CalculateNumber(0, 100);
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (sArray[i] == "Fizz" || sArray[i] == "FizzBuzz") count += 1;
            }
            Assert.AreEqual(count, 34);
        }

        [TestMethod]
        public void ExpectedResultTwentyOneBuzz()
        {
            //Number divisible by 5
            //0, 5, 10,15,20,25,30,35,40,45,50,55,60,65,70,75,80,85,90,95,100
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();
            string[] sArray = calculator.CalculateNumber(0, 100);
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (sArray[i] == "Buzz" || sArray[i] == "FizzBuzz") count += 1;
            }
            Assert.AreEqual(count, 21);
        }

        [TestMethod]
        public void ExpectedResultSevenFizzBuzz()
        {
            //Number div by 3 and 5
            //0, 15, 30, 45, 60, 75, 90,
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();
            string[] sArray = calculator.CalculateNumber(0, 100);
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (sArray[i] == "FizzBuzz") count += 1;
            }
            Assert.AreEqual(count, 7);
        }


        [TestMethod]
        public void EightExpectedResultFiftyThreeEquivalentNumber()
        {
            FizzBuzzCalculator calculator = new FizzBuzzCalculator();
            string[] sArray = calculator.CalculateNumber(0, 100);
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (sArray[i] == i.ToString()) count += 1;
            }
            Assert.AreEqual(count, 53);
        }

    }
}
