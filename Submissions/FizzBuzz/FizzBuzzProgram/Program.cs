using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Program Made by Hernando Rivera
//This program made a count from 1 to 1000 and depending the validation will bee the result output. 


namespace FizzBuzzProgram //define the name of the Program 
{ 
    public class Program //define the name of the program 
    {
        static void Main(string[] args)// main of the program that call all the classes of the program
        {
            //The first part that call the calculation funcion of the class.
            FizzBuzzCalculation.Cal(); 
         


            //The second part of the main that call the function of display the total count.

            FizzBuzzCalculation.Result();
     
         }
    }
}
