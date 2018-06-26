using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird : AAnimal
    {
        public override string Name { get; set; }

        public override object GoAction { get; set; }

        public new void GoToLocation(string location)
        {
            Console.WriteLine($"Fly to {location.ToUpper()}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("SING!!");
        }

    }
}
