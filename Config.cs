using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_3_W24_L3_012924
{
    internal static class Config
    {

        public static string connectionString = "Server=example-server;Database=my-database;User=my-user;Password=my-password;Port=12345;\r\n";

        static string server = "Server=example-server";
        static string Database = "Database=my-database";
        static string User = "User=my-user";
        static string Password = "Password=my-password";
        static string Port = "Port=12345";


        // static constructor
        static Config()
        {
            Console.WriteLine("The static Config constructor was just called");


            Random rand = new Random();
            Password = "Password=" + rand.Next(1000,10000);
            connectionString = $"{server};{Database};{User};{Password};{Port}";
        }

    }
}
