﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBallMatching
{
    public static class Database
    {

        /// deprecated -- Database script from old project.

        //public static string DataSource = "(local)";
        ////        public static string DataSource = ".\\SQLEXPRESS";

        //public static void SQLkommandoSet(string sqltext)
        //{
        //    string ConnectionString = $@"Data Source = {DataSource}; Initial Catalog = Dragon_Ball_Matching; Integrated Security = True";
        //    var connection = new SqlConnection(ConnectionString);
        //    SqlCommand cmd;
        //    connection.Open();

        //    try
        //    {
        //        cmd = connection.CreateCommand();
        //        cmd.CommandText = sqltext;
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //        throw;
        //    }
        //    finally
        //    {
        //        if (connection.State == System.Data.ConnectionState.Open)
        //        {
        //            connection.Close();
        //        }
        //    }
        //}

        //public static List<object> SQLkommandoGet(string sqltext)
        //{
        //    string ConnectionString = $@"Data Source = {DataSource}; Initial Catalog = Dragon_Ball_Matching; Integrated Security = True";
        //    var connection = new SqlConnection(ConnectionString);
        //    List<object> SQLList = new List<object>();

        //    connection.Open();
        //    using (SqlCommand command = new SqlCommand(sqltext, connection))
        //    {
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                for (int i = 0; i < reader.FieldCount; i++)
        //                {
        //                    SQLList.Add(reader.GetValue(i));
        //                }
        //            }
        //        }
        //    }
        //    connection.Close();
        //    return SQLList;
        //}


        /// New functions
       
        //private static string dataSource = "(local)";
        ////private static string dataSource = ".\\SQLEXPRESS";
        //private static string connectionString = $@"Data Source = {dataSource}; Initial Catalog = Dragon_Ball_Matching; Integrated Security = True";

        //public static DataSet SQLCommandGet(string query) {
        //    SqlConnection con = new SqlConnection(connectionString);
        //    SqlDataAdapter da = new SqlDataAdapter(query, con);
        //    DataSet ds = new DataSet();
        //    da.Fill(ds);
        //    con.Close();
        //    return ds;
        //}

        //public static void SQLCommandSet(string query) {

        //}
    }
}