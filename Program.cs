using System;
using System.Data.SqlClient;
using System.Diagnostics;

class Program
{
    static void Main()
    {


        string input = Console.ReadLine();
        Process.Start("cmd.exe", "/c " + input); // 🚨 Command Injection
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        string username1 = "adminrf";
        string password = "P@ssw0rd123rdgd";   // ❌ Hardcoded password

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
         

        
        }
    }
}
