using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Loops
{
    [TestClass]
    public class Loops
    {
        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 13;

            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine(i);
                //studentCount--;
            }

            for(int i = studentCount; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            //Declaration  //Condition        //incrementer
            for(int i = 0; i < studentCount--; i++)
            {
                Console.WriteLine(i);
            }
                
        }

        [TestMethod]
        public void WhileLoops()
        {
            int number = 5;
            while (number != 10)
            {
                Console.WriteLine(number);
                number++;
            }
        }

        [TestMethod]
        public void ForEachLoops()
        {
           // List<string> students = new List<string>();

            //students.Add("Regan");
            //students.Add("Aaron");
            //students.Add("Paul");
            //students.Add("Trevor");
            //students.Add("Andrew");
            //foreach(string studentName in students)
            {
               // Console.WriteLine(studentName);

            }

            string mountianName = "Mauna Kea";
            foreach (char letter in mountianName)
            {
                if (letter == 'a')
                {
                    Console.WriteLine(letter);
                }
                    
               


            }
        }

    }
}
