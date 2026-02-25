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
            var abc=0;
            var b=1;
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("User found");
            }
            string username = "admin";
        string password = "P@ssw0rd123";   // ❌ Hardcoded password

        Console.WriteLine($"User: {username}");
        Console.WriteLine($"Password: {password}");
        }
    }
}
