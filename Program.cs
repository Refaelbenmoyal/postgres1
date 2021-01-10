using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progres1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myconfig = ConfigurationManager.AppSettings[" postgres "];
            private static void PrintAllworkers(string conn_string)
            {
                
                using (var conn = new NpgsqlConnection(conn_string))
                {
                    conn.Open();
                    string query = "SELECT * FROM workers";

                    NpgsqlCommand command = new NpgsqlCommand(query, conn);
                    command.CommandType = System.Data.CommandType.Text;

                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        long id = (long)reader["id"];
                        string name = (string)reader["name"];
                        
                        Console.WriteLine($"{id} {name}");
                        
                    }
                }
            }

        }
    }
}
