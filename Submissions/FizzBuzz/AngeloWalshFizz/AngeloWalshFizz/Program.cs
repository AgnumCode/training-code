using System;

namespace AngeloWalshFizz
{
    class Program
    {
        static int fizzbuzz = 0;
        static int fizz = 0;
        static int buzz = 0;

        static void ShowFizzBuzz()
        {
            Console.WriteLine("FizzBuzz");
            fizzbuzz++;
            
        }

        static void ShowBuzz()
        {
            Console.WriteLine("Buzz");
            buzz++;
        }

        static void ShowFizz()
        {
            Console.WriteLine("Fizz");
            fizz++;
        }

        static void DoFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) { ShowFizzBuzz(); }

            else if (number % 3 == 0) { ShowFizz(); }

            else if (number % 5 == 0) { ShowBuzz(); }

            else
                Console.WriteLine(number);
        }

        static void DisplayCount()
        {
            Console.WriteLine("Fizz:" + fizz + " Buzz:" + buzz + " FizzBuzz:" + fizzbuzz);
        }

        static void Main(string[] args)
        {
            
            /* start FizzBuzz from 1 to 1000. 
                Display Fizz if % 3
                Display Buzz if % 5
                Display FizzBuzz if % 15
                Display number otherwise 
            */    
            for (int i = 1; i <= 1000; i++)
                DoFizzBuzz(i);

            // display counts of fizz, buzz, and fizzbuzz 
            DisplayCount();

            
            
        }   // end Main 
    }   // end class 
}   // end namespace
