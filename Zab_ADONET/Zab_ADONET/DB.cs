using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Zab_ADONET
{
    public class DB
    {
        public void Select(SqlConnection connection)
        {
            var query = "SELECT * FROM Customers";
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0} {1}", reader["CustomerID"], reader["CompanyName"]);
            }
            reader.Close();
        }
        public void Insert(SqlConnection connection, int id, string description)
        {
            var query = "INSERT INTO Region (RegionID,RegionDescription)" +
                       "VALUES(@id,@description)";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@description", description);
            Console.WriteLine("{0} rows affected", command.ExecuteNonQuery());
        }
        public void Delete(SqlConnection connection)
        {
            var query = "DELETE FROM Region WHERE RegionDescription='Bielsko'";
            var command = new SqlCommand(query, connection);
            Console.WriteLine("{0} rows affected", command.ExecuteNonQuery());
        }
    }
}
