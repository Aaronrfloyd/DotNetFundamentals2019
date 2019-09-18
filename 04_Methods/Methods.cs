using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class Methods
    {
        [TestMethod]
        public void MethodExample()
        {
            // + = - / * %

            int sum = 2 + 2;
            int subtraction = 2 - 2;
            int multiply = 2 * 2;
            int divide = 2 / 2;
            int remainder = 2 % 2;

            int expected = 8;

            int actual = AddTwoNumbers(sum, multiply);
            Assert.AreEqual(expected, actual);

            int expectedTwo = 2;
            int actualTwo = substractTwoNumbers(4, 2);
            Assert.AreEqual(expectedTwo, actualTwo);

            int expectedThree = 2;
            int actualThree = divideTwoNumbers(4, 2);
            Assert.AreEqual(expectedThree, actualThree);

            int expectedFour = 4;
            int actualFour = multiplyTwoNumbers(2, 2);
            Assert.AreEqual(expectedFour, actualFour);

            int expectedFive = 0;
            int actualFive = remainderTwoNumbers(30, 5);
            Assert.AreEqual(expectedFive, actualFive);

        }

        // 1=access modifer 2=return type 3=method name  4=parentheses(parameters)
        //1    //2             //4
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public int substractTwoNumbers(int numOne, int numTwo)
        {
            int subtractTwoNumbers = numOne - numTwo;
            return subtractTwoNumbers;

        }

        public int divideTwoNumbers( int numOne, int numTwo)
        {
            int divideTwoNumbers = numOne / numTwo;
            return divideTwoNumbers;
        }

        public int multiplyTwoNumbers( int numOne, int numTwo)
        {
            int multiplyTwoNumbers = numOne * numTwo;
            return multiplyTwoNumbers;
        }

        public int remainderTwoNumbers( int numOne, int numTwo)
        {
            int remainderTwoNumbers = numOne % numTwo;
            return remainderTwoNumbers;
        }
    }



}
