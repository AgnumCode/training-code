using System;
using Animals.Library;

namespace Animals.UI
{
    class Program
    {
        static void InteractwithAnimal(IAnimal animal)
        {
            animal.Name = "Fido";
            var hisName = animal.Name;
            Console.WriteLine(hisName);

            animal.MakeSound();
        }

        static void Main(string[] args)
        {
            IAnimal Animal = new Dog(); //upcasting

            InteractwithAnimal(new Dog());
            InteractwithAnimal(new Bird());
        }
    }
}
