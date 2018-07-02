using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library
{
    public class Bird : AAnimal
    {
        public Bird(double wingSpan, string name = "Bob", int value = 4)
        {
            WingSpan = wingSpan;
            Console.WriteLine($"Wing span is {wingSpan}");
            Name = Name;
        }

        /// one constructor call another
        //public Bird() : this(2)
        //{

        //}

        public double WingSpan { get; set; }

        public override string Name { get; set; }

        public override object GoAction { get; set; } = "Flying!";

        public override void MakeSound()
        {
            Console.WriteLine("Cawww!!");
        }

    }
}
