using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Library2
{
    public abstract class AAnimal : IAnimal
    {
        public string Name { get; set; }

        public object GoAction { get; private set; }

        public void GoToLocation(string location)
        {
            Console.WriteLine($"{GoAction} to {location}");
        }

        public abstract void MakeSound();
       
    }
}
