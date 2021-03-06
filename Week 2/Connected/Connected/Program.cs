﻿using System;
using System.Data.SqlClient;

namespace Connected
{
    class Program
    {
        static void Main(string[] args)
        {
            // connected architecture with ADO.NET
            // needs nuget package System.Data.SqlClient
            var connectionString = "Server=tcp:escalona-1806.database.windows.net,1433;" +
                "Initial Catalog=MoviesDB;Persist Security Info=False;" +
                "User ID=escalona;Password={my_password};" +
                "MultipleActiveResultSets=False;Encrypt=True;" +
                "TrustServerCertificate=False;Connection Timeout=30;";

            var commandString = "SELECT * FROM Movies.Movie;";

            // example SQL injection
            var userInput = "Fred";
            var maliciousUserInput = "Fred\"); DROP DATABASE MoviesDB;";
            var commandString2 = "INSERT INTO Movies.Genre " +
                "VALUES (\"" + userInput + "\")";
            // user can execute any command

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open(); // step 1 of connected: open connection
                using (var command = new SqlCommand(commandString, connection))
                // step 2: execute query
                // (if it's a SELECT statement, we use ExecuteReader
                //  otherwise, we use ExecuteNonquery.
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // step 3: process results
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID {reader["ID"]}," +
                                $" Name {reader["Name"]}");
                        }
                    }
                }
                connection.Close(); // step 4: close connection
            }
        }
    }
}
