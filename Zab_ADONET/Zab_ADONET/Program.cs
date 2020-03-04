using System;
using System.Data.SqlClient;

namespace Zab_ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var db = new DB();
            using var connection = new SqlConnection(connectionString);
            connection.Open();
            db.Select(connection);
            //db.Insert(connection, 5, "Bielsko");
            db.Delete(connection);
            connection.Close();
            Console.ReadKey();
        }
    }
}
