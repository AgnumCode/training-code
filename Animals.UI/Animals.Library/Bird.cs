using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird : AAnimal
    {
        public Bird(double wingSpan = 2)
        {
            WingSpan = wingSpan;
            Console.WriteLine($"Wing span is {wingSpan}");
            Name = Name;
        }

        public Bird() : this(2)
        {

        }

        public double WingSpan { get; set; }

        public override string Name { get; set; }

        public override object GoAction { get; set; } = "Flying!";

        public new void GoToLocation(string location)
        {
            Console.WriteLine($"Fly to {location.ToUpper()}");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Cawww!!");
        }

    }
}
