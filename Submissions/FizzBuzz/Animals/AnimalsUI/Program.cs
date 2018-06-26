using System;
using Animals.Library2;

namespace AnimalsUI
{
    class Program
    {

        static void InteractWithAnimal(IAnimal animal)
        {

            // get and set through property
            animal.Name = "Fido";
            var hisName = animal.Name;
            Console.WriteLine(hisName);

            animal.MakeSound();

            // error: cant accces what isnt defined on IAnimal
            //  animal.OwnerName = "Fred";

        }
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();        // upcasting (implicitly)

            InteractWithAnimal(new Dog());
            InteractWithAnimal(new Bird());


        }
    }
}
