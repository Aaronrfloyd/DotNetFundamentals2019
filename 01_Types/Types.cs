using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Types
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void ValueTypes ()
        {
            float firstVariable; //This is a declaration
            firstVariable = 7f; //This is initialization


            //int number = 1234;
            //bool on = true;
            //bool off = true;

            char character = '?';

            //decimal hello = 12234556.00m;
            //float anotherDecimal = 123.5f;
            //double anotheranotherDecimal = 1234.55d;

            //int,double,decimal,long,short, float
            byte byteExample = 255; //0-255
            sbyte abyteExample = -128;
            short shortexample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExqample = 9223372036854775807;
            long longMin = -9223372036854775;

            float floatExample = 1.04523f;
            double doubleExample = 1.72342342124d;
            decimal decimalExample = 1.443433423423444m;

        }

        [TestMethod]
        public void Operators()
        {
            // + - / % *

            int numberOne = 3;
            int numberTwo = 5;

            int sum = numberOne + numberTwo;
            int subtraction = numberOne - numberTwo;
            int division = numberOne / numberTwo;
            int mod = numberOne % numberTwo;
            int multiply = numberOne * numberTwo;
            Console.WriteLine(sum);
            Console.WriteLine(subtraction);
            Console.WriteLine(division);
            Console.WriteLine(mod);
            Console.WriteLine(multiply);

        }

        [TestMethod]
        public void ReferenceTypes()
        {
            string firstName = "Aaron";
            string lastName = "Floyd";

            //Concatanation
            string concatanation = firstName + " " + lastName;
            Console.WriteLine(concatanation);

            //Composite Formatting 
            string composite = string.Format($"Hello my name is {0} {1}, firstName, lastName");
            Console.WriteLine(composite);

            //String Interpolation
            string interpolation = $"{firstName} {lastName}";
            Console.WriteLine(interpolation);

            //Classes


            //Structs


            //Collections
            List<string> myList = new List<string>();
            myList.Add("Hello World");

            List<int> myNumberList = new List<int>();
            myNumberList.Add(2);

            Queue<string> myQueue = new Queue<string>();
            myQueue.Enqueue("Hello World");

            Dictionary<int, string> myDictionary = new Dictionary<int, string>();

            Stack<int> newStack = new Stack<int>();

            string banana = "fruit";
            string[] stringArray = { "hello", "character", "food", "water" };

        }

    }
}
