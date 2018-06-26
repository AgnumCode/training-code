using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Dog : IAnimal
    {


        //private string name;

        //public string getName()
        //{
        //    return name;
        //}

        //public void setName(string newName)
        //{
        //    name = newName; 
        //}

        public string Name { get; set; }

        private string ownerName;

        public string OwnerName
        {
            get { return ownerName; }
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
    }
}
