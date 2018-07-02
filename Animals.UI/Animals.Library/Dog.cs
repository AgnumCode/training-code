using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Dog : IAnimal
    {
        //field with getter and setter

        //private string name;

        //public string getName()
        //{
        //    return name;
        //}

        //public void setName(string newName)
        //{
        //    name = newName; 
        //}

        public  string Name { get; set; }

        private string ownerName; // bscking field

        public string OwnerName
        {
            get
            {
                return "Nick";
            }
            set 
            {
                if (value != null)
                {
                    ownerName = value;
                }
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("BARK!!");
        }

        public void GoToLocation(string location)
        {
            //string interpolation
            //Console.WriteLine("walk to " + location);
            Console.WriteLine($"Walk to {location.ToUpper()}");
        }

        public  string GoAction { get; set; } = "Walking";
    }
}
