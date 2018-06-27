using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProgram
{
    class FizzBuzzCalculation
    {
        static private int RestNumber_Count; //define a variable to make the count of the Rest Numbers.
        static private int FizzBuzz_Count;  //define a variable to make the count of the FizzBuzz Numbers.
        static private int Buzz_Count; //define a variable to make the count of the Buzz.
        static private int Fizz_Count; //define a variable to make the count of the Fizz. 

        static public void Cal() //define the function that will calculate the math process and return the result of it.
        {
            for (int i = 1; i <= 1000; i++) //The loop that make the count from 1 to 1,000
            {
                if (((i % 5) == 0) && ((i % 3) == 0)) //The condition of the FizzBuzz
                {
                    Console.WriteLine("Is fizzbuzz and the number is: " + i);
                    FizzBuzz_Count++;
                }
                else if ((i % 5) == 0)// The conditon of the Buzz Numbers 
                {
                    Console.WriteLine("Is buzz and the number is: " + i);
                    Buzz_Count++;
                }
                else if ((i % 3) == 0) // The condition of the Fizz Numbers
                {
                    Console.WriteLine("Is fizz and the number is:" + i);
                    Fizz_Count++;
                }
                else //The last validation of the Rest of the number of the count
                {
                    Console.WriteLine("The rest of the numbers: " + i);
                    RestNumber_Count++;
                }
            }
        }


        static public void Result() //Function that display the total count of each part of the code.
        {
            Console.WriteLine("The total count of the Rest of Number is:" + RestNumber_Count); 
            Console.WriteLine("The total count of the FizzBuzz Number are:" + FizzBuzz_Count);
            Console.WriteLine("The total count of Buzz Number is:" + Buzz_Count);
            Console.WriteLine("The total count of Fizz Number is:" + Fizz_Count);
        }
               
    }
 }
