using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            string connString = "Server=mysql.cvcltc1gep42.us-east-2.rds.amazonaws.com;Port=3306;Database=mysqldbname;Uid=aaaa1111;password=aaaa1111;";
            MySqlConnection conn = new MySqlConnection(connString);
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "select name from testTable where id=1";
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader["name"].ToString());
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
