using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        string connectionString = "Server=myServer;Database=myDB;User Id=sa;Password=password;";
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            // 🚨 SQL Injection Vulnerability
            string query = "SELECT * FROM Users WHERE Username = '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            var abc;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("User found");
            }
        }
    }
}
