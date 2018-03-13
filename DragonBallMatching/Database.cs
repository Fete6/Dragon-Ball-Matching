using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallMatching
{
    public static class Database
    {
        public static string DataSource = "(local)";
        //        public static string DataSource = ".\\SQLEXPRESS";

        public static void SQLkommandoSet(string sqltext)
        {
            string ConnectionString = $@"Data Source = {DataSource}; Initial Catalog = Dragon_Ball_Matching; Integrated Security = True";
            var connection = new SqlConnection(ConnectionString);
            SqlCommand cmd;
            connection.Open();

            try
            {
                cmd = connection.CreateCommand();
                cmd.CommandText = sqltext;
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static List<object> SQLkommandoGet(string sqltext)
        {
            string ConnectionString = $@"Data Source = {DataSource}; Initial Catalog = Dragon_Ball_Matching; Integrated Security = True";
            var connection = new SqlConnection(ConnectionString);
            List<object> SQLList = new List<object>();

            connection.Open();
            using (SqlCommand command = new SqlCommand(sqltext, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            SQLList.Add(reader.GetValue(i));
                        }
                    }
                }
            }
            connection.Close();
            return SQLList;
        }
    }
}