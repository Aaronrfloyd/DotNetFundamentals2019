using System;
using _05_Classes;
using _05_Classess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_ClassesTests
{
    [TestClass]
    public class ClassExamples
    {
        [TestMethod]
        public void CookieClassInstantiation()
        {
            Cookie cookie = new Cookie();

            cookie.Name = "SnickerDoodle";
            cookie.Ingredient = "Cinnamon";
            cookie.Shape = "Round";
            cookie.Size = "Big";
            cookie.BatchSize = 12;
            cookie.Direction = "Mouth";

            Cookie cookieTwo = new Cookie();

            cookie.Name = "PeanutButter";
            cookie.Ingredient = "Peanuts";
            cookie.Shape = "circle";
            cookie.Size = "Large";
            cookie.BatchSize = 24;
            cookie.Direction = "CoolingRack";

            Cookie cookieThree = new Cookie("Chocolate Chip","Butter","Square","Small",36,"Fridge");



        }
        [TestMethod]
        public void myCar()
        {
            Vehicle vehicleOne = new Vehicle();
            Vehicle vehicleTwo = new Vehicle("Honda","Civic",7865d,"red","nvb65hftr54",1981,10,true);
        }
    }
}
