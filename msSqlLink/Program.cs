using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace msSqlLink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ConectionString = "Data Source=LAPTOP-0HSC4H8O;Initial Catalog=workDB;Integrated Security=True";
            List< Employees > listOfEmployees=new List<Employees>();
            try
            {
                using (SqlConnection connection = new SqlConnection(ConectionString))
                {
                    connection.Open();
                    string query = @"SELECT * FROM Employees";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader DataFromDB = command.ExecuteReader();
                    if (DataFromDB.HasRows)
                    {
                        while (DataFromDB.Read())
                        {
                            listOfEmployees.Add(new Employees(DataFromDB.GetString(0), DataFromDB.GetString(1), DataFromDB.GetInt32(2), DataFromDB.GetString(3), DataFromDB.GetString(4)));
                            Console.WriteLine(DataFromDB.GetString(0) + DataFromDB.GetString(1));
                        }
                    }
                    else
                    {
                        Console.WriteLine("no rows in table");
                    }
                    connection.Close();
                }
                Console.ReadLine();
            }

            catch (SqlException)
            {
                Console.WriteLine("not work");
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }

    }
}
