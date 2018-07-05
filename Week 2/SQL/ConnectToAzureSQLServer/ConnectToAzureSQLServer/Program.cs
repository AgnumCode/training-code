using System;
using System.Data.SqlClient;

namespace ConnectToAzureSQLServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Server=tcp:ohara-1806.database.windows.net,1433;Initial Catalog=MoviesDB;Persist Security Info=False;User ID=kohara2794;Password=Eddioman122!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            var commandString = "SELECT * FROM Movies.Genre;";

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(commandString, connection))
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID {reader["ID"]}," +
                                $" Name {reader["Name"]}");
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
