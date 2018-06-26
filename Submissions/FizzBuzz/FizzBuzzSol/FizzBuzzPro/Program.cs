using System;

namespace FizzBuzzPro
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizz = 0;
            int buzz = 0;
            int fizzbuzz = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == i % 5 && i % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                    fizzbuzz++;
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                    fizz++;
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("buzz");
                    buzz++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Total # of Fizz : " + fizz);
            Console.WriteLine("Total # of Buzz : " + buzz);
            Console.WriteLine("Total # of FizzBuzz : " + fizzbuzz);
            Console.ReadLine();
        }
    }
}
