using System;

namespace Animals.Library2
{
    public class Dog : IAnimal
    {
       // field with getter and setter 
        public string Name { get; set; }        // auto-implemented property

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
        }   // end OwnerName

        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
         
        public void GoToLocation(string location)
        {
            // string interpoloation
            Console.WriteLine($"Walk to {location.ToUpper()}");
        }
    }
}
