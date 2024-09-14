using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EventManagementSystem
{
    internal static class DBConnection
    {
        private static string connectionString = "datasource=localhost;port=3307;username=sachira;password=sachira@123;database=event_management_system;";

        private static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

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

        // Add this method in DatabaseHelper.cs
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

        public static List<Dictionary<string, object>> ExecuteReader(string query, MySqlParameter[] parameters)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();

                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                string columnName = reader.GetName(i);
                                object columnValue = reader.GetValue(i);
                                row.Add(columnName, columnValue);
                            }

                            result.Add(row);
                        }
                    }
                }
            }

            return result;
        }



    }
}
