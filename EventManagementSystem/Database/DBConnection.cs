using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EventManagementSystem
{

    /*
        
        The purpose of creating the DBConnection class is to execute all the queries in one place.
        If we didn't use this class we would hve to call the ExcecuteQuery, ExecuteNonQuery, ExecuteScalar methods for each query that we
        are executing. So rather than that we just create the body of those methods in a seperate class and pass the query and the parameters 
        as follows. Finally we would return the values.
     
     */
    internal static class DBConnection
    {
        private static string connectionString = "datasource=localhost;port=3307;username=sachira;password=sachira@123;database=event_management_system;";

        private static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        // Used for select * from tables
        public static DataTable ExcecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection connection = GetConnection())
            {
                using (var command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        DataTable result = new DataTable();
                        adapter.Fill(result);
                        return result;
                    }
                }
            }
        }

        // Used to Update, Create, and Delete
        public static int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            using (MySqlConnection connection = GetConnection())
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    if (parameters != null)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    return command.ExecuteNonQuery();
                }
            }
        }

        // Used to Get a single value
        public static object ExecuteScalar(string query, MySqlParameter[] parameters)
        {
            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();
                    return cmd.ExecuteScalar();
                }
            }
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <param</param>
        /// <param name="parameters"></param>
        /// <returns></returns>

        



    }
}
