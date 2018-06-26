using System;

namespace RBFizzBuzz.VSConsole
{
    class Program
    {
        static int countf = 0;
        static int countb = 0;
        static int countfb = 0;
        static int count = 0;

        static void PrintFizz()
        {
            Console.WriteLine("Fizz! ");
        }

        static void PrintBuzz()
        {
            Console.WriteLine("Buzz! ");
        }

        static void PrintFizzBuzz()
        {
            Console.WriteLine("FizzBuzz! ");
        }

        public static void Calculate()
        {
            for(int i = 1; i <= 1000; i++)
            {
                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    countfb++;
                    PrintFizzBuzz();

                }
                else if ((i % 3) == 0)
                {
                    countf++;
                    PrintFizz();

                }
                else if ((i % 5) == 0)
                {
                    countb++;
                    PrintBuzz();

                }
                else if (((i % 3) != 0) && ((i % 3) != 0))
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
            PrinttheNumbers(countf, countb, countfb, count);
        }

        static void PrinttheNumbers(int fizz, int buzz, int fb, int num)
        {

            Console.WriteLine($"The total number of Fizz: {fizz}");
            Console.WriteLine($"The total number of Buzz: {buzz}");
            Console.WriteLine($"The total number of FizzBuzz: {fb}");
            Console.WriteLine($"The total number of no match: {num}");
            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            Calculate();
        }
    }
}
