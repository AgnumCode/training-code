using System;
using System.Collections.Generic;
using System.Text;

/*
 * Author: Luis A. Ortiz Rosario 
 * Date: June 26, 2018 
 * Description of the Program: For each number from 1 to 1000 in order,
 *     - Print "Fizz" for the ones divisible by 3 (& not 5)
 *     - Print "Buzz" for the ones divisible by 5 (& not 3)
 *     - Print "Fizzbuzz" for the ones divisible by both 3 and 5
 *     - Print the number itself, for all the rest of the numbers
 *     - Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.
 * WorkSite: Revature
 */

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz() { }

        static private int FizzBuzzCounter; //Counts the quantity of the numbers divisible between 3 and 5.
        static private int BuzzCounter; //Counts the quantity of the numbers divisible by 5 and not by 3.
        static private int FizzCounter; //Counts the quantity of the numbers divisible between 5 and 3.
        static private int NumberCounter; //Counts the quantity of the numbers none of them. 

        static public void Calculation() //This method contains the calculation of the numbers 
        {
            for (int number = 1; number < 1001; number++) //Loop counts 1 to 1000
            {
                if ((number % 3) == 0 && (number % 5) == 0) //Condition for numbers divisible between 3 and 5
                {
                    Console.WriteLine(" FizzBuzz " + number);  //Identifier and the divisible number 
                    FizzBuzzCounter++;  //Counter for FizzBuzz
                }
                else if ((number % 3) == 0) //Condition for numbers divisible with 3. 
                {
                    Console.WriteLine(" Fizz " + number); //Identifier and the divisible number.  
                    FizzCounter++; //Counter for Fizz
                }
                else if ((number % 5) == 0) //Condition for numbers divisible with 5.
                {
                    Console.WriteLine(" Buzz " + number); //Identifier and the divisible number 
                    BuzzCounter++; //Counter for Buzz
                }
                else //Condition that none of the numbers is divisible
                {
                    Console.WriteLine("Numbers not divisible: " + number);
                    NumberCounter++; //Counter for numbers 

                }

            }
        }

        /*
         * This method this messages of the counters 
         */
        static public void Display()
        {
            Console.WriteLine("\n");
            Console.WriteLine("-------------------Counter--------------------------------");
            Console.WriteLine(" FizzBuzz: " + FizzBuzzCounter);
            Console.WriteLine(" Fizz: " + FizzCounter);
            Console.WriteLine(" Buzz:  " + BuzzCounter);
            Console.WriteLine(" Numbers: " + NumberCounter);
            Console.WriteLine("-----------------------------------------------------------");

        }
    }
}

