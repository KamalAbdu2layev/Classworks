using System;
using System.Data.SqlClient;

namespace ClassWork_04_15_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateTable();
            //GetTabel();
            GetInfoById(2);
        }
        private static void CreateTable()
        {
            string connectionString = "Data Source=LAPTOP-8O8EM6DT;Initial Catalog=Course;"
        + "Integrated Security=true;";

            string sql = "INSERT INTO Student VALUES ('Student1')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Worked");
                }
                
                command.Dispose();
            }

        }

        private static void GetTabel()
        {
            string connectionString = "Data Source=LAPTOP-8O8EM6DT;Initial Catalog=Course;"
        + "Integrated Security=true;";

            string sql = "SELECT * FROM Student";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader sqlReader = command.ExecuteReader();


                while (sqlReader.Read())
                {
                    Console.WriteLine(sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1));
                }


                command.Dispose();
            }
        }

        private static void GetInfoById(int Id)
        {
            string connectionString = "Data Source=LAPTOP-8O8EM6DT;Initial Catalog=Course;"
        + "Integrated Security=true;";

            string sql = $"EXEC USP_FilterById {Id}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader sqlReader = command.ExecuteReader();


                while (sqlReader.Read())
                {
                    Console.WriteLine(sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1));
                }


                command.Dispose();
            }

        }
    }
} 
