using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library2
{
    public class Bird : AAnimal
    {
        
        public override string Name { get; set; }

        public override string GoAction { get; set; } = "Flying";
        {
            Console.WriteLine($"Flying to {location}");
        }

        public void MakeSound();
       
    }
}
