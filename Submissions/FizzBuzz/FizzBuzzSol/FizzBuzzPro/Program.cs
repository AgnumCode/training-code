using System;

namespace FizzBuzzPro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Counter Variables for tracking number of Fizz, Buzz and FizzBuzz
            int fizz = 0;
            int buzz = 0;
            int fizzbuzz = 0;

            //Increment from 1 to 1000 and check for Fizz and Buzz at each iteration
            for (int i = 1; i <= 1000; i++)
            {
                //if the output of i modulo 3 and 5 are equal then 'fizzbuzz' will be returned and counter updated
                if (i % 3 == i % 5 && i % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                    fizzbuzz++;
                }
                //if i modulo 3 does not return a remainder, print 'fizz' and increment fizz counter
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                    fizz++;
                }
                //if i modulo 5 does not return a remainder, print 'buzz' and increment buzz counter
                else if (i % 5 == 0)
                { 
                    Console.WriteLine("buzz");
                    buzz++;
                }
                //if none of the above are applicable, return the number of the iteration
                else
                {
                    Console.WriteLine(i);
                }
            }

            //print statements for the total of each string and a read statement to keep the console window open
            Console.WriteLine("Total # of Fizz : " + fizz);
            Console.WriteLine("Total # of Buzz : " + buzz);
            Console.WriteLine("Total # of FizzBuzz : " + fizzbuzz);
            Console.ReadLine();
        }
    }
}
