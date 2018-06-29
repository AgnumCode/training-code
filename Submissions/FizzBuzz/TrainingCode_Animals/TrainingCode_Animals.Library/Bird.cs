using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird : AAnimal
    {
        private double WingSpan;

        public Bird(double wingSpan, string name = "Bob", int value = 4)
        {
            WingSpan = wingSpan;
            Console.WriteLine($"Wing Span is {wingSpan}");
            Name = name;

        }

        public Bird() : this(wingSpan: 2, value : 8)
        {

        }

        public override string Name { get; set; }

        public override string GoAction { get; set; } = "Flying";

        public override void MakeSound()
        {
            Console.WriteLine("Cawww");
        }
    }
}
