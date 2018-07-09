using EntityFrameworkFirstDemo.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;



// I'll need to use Entity Framework methods...
//  SaveChanges() --> to push changes to the db and "track" them
//  Include(),
//  ThenInclude() 
namespace EntityFrameworkFirstDemo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Entity Framework is an ORM(Object Relational Mapper) for .NET
            //
            // We will be using the database-first approach (which means that the constraints are defined via queries when creating Tables)
            //
            // There is also the Code-first approach (the C# code defines the truth about the SQL Data Model)
            Console.WriteLine("Hello World!");
            PrintMovies();

            
        }


        static void PrintMovies()
        {
            using (var db = new MoviesDBContext())
            {
                foreach (var item in db.Movie.Include(m => m.Genre))
                {
                    Console.WriteLine($"Name {item.Name}, " +
                     $" genre {item.Genre.Name}");
                }
            }
        }
    }
}
