using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Models;
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

        /*public static Event ExecuteReader(string query, MySqlParameter[] parameters)
        {

            using (MySqlConnection conn = GetConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int eventId = reader.GetInt32("EventID");
                                string eventName = reader.GetString("EventName");
                                string description = reader.GetString("Description");
                                DateTime startDate = reader.GetDateTime("StartDate");
                                DateTime endDate = reader.GetDateTime("EndDate");
                                string location = reader.GetString("Location");
                                int maxParticipants = reader.GetInt32("MaxParticipants");
                                int currentParticipants = reader.GetInt32("CurrentParticipants");
                                string organizerName = reader.GetString("OrganizerName");

                                object() eventDetails = new object() {eventId, eventName, description, startDate, endDate, maxParticipants, currentParticipants};
                                
                            }
                        }
                    }
                }
            }

            return result;
        }*/



    }
}
