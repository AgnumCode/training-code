using System;

namespace oharaFizzBuzz
{
    class Program
    {


        public void FizzBuzz()
        {
            int Fizzes = 0;
            int Buzzes = 0;
            int fizzbuzzes = 0;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 15 == 0)
                {
                    System.Console.WriteLine("fizzbuzz");
                    fizzbuzzes++;
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                    Fizzes++;
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                    Buzzes++;
                }
                else
                {
                    System.Console.WriteLine(i);
                }

                
            }

            System.Console.WriteLine("# of Fizzes : " + Fizzes + System.Environment.NewLine + "# of Buzzes : " + Buzzes +
                                     System.Environment.NewLine + "# of fizzbuzzes : " + fizzbuzzes);


            /*
             * 
             * ADD Counters for Fizz's, Buzz's, and fizzbuzz's
             * 
             * */
            int debugInt = 0;
        }
    


        static void Main(string[] args)
        {
            Program keegansFizzBuzz = new Program();
            keegansFizzBuzz.FizzBuzz();   
        }

        
    }

}
   

