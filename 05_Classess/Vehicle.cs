using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classess
{
   
     public class Vehicle
    {
        public Vehicle()
        {

        }
    public Vehicle(string make,string model,double mileage,string color,string vIN,int year,int coolnessFactor, bool isRunning)
    {
        Make = make;
        Model = model;
        Color = color;
        VIN = vIN;
        Year = year;
        CoolnessFactor = coolnessFactor;
        IsRunning = isRunning;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public double Milage { get; set; }
        public string Color { get; set; }
        public string VIN { get; set; }
        public int Year { get; set; }
        public int CoolnessFactor { get; set; }
        public bool IsRunning { get; set; }


    }
}
    
