using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Conditionals
{
    [TestClass]
    public class ConditionalExamples
    {
        [TestMethod]
        public void IfElseStatments()
        {
            // if, else if, else
            int age = 18;

            if (age >=21) 
            {
                Console.WriteLine("you can drink");
            }
            else if (age <21)
            {
                Console.WriteLine("Sorry");
                age += 4;  
            }
            else
            {
                Console.WriteLine("This is default");
            }

            if (age == 18)
            {
                 Console.WriteLine("You wrote me out. YaY");
            }

            decimal bankAccount = 100m;

            if(bankAccount < 5)
            {
                Console.WriteLine("Movong up in the world.");
            }
            else if(bankAccount == 100 || bankAccount == 4)
            {
                Console.WriteLine("woah");
            }
            else
            {
                Console.WriteLine("cool");
            }

            // && AND || == OR > < >= <= !=
        }


        [TestMethod]
        public void SwithCases()
        {
            int age = 4;
            switch (age)
            {
                case 1:
                    //The code we want to execute
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    Console.WriteLine("Happy Birthday");
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("To Bad. It will be soon.");
                    break;


            }
        }

        [TestMethod]
        public void Ternaries()
        {
            int age = 55;

            // 1 condition  //2 if true    //3 if false 
            // 1   //2    //3
            //() ? true : false;

            bool isAdult = age > 18 ? true : false;

        }
    }
}
