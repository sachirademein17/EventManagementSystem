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
        private static MySqlConnection connection = new MySqlConnection();

        private static void Connection()
        {
            connection = new MySqlConnection("datasource=localhost;port=3307;username=sachira;password=sachira@123;database=event_management_system;");
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }

        public static string Authentication(string username, string password)
        {
            Connection();
            string query = "SELECT COUNT(*) FROM username_password WHERE username = @username AND password = @password";
            bool isValid = false;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    // Prevent SQL Injection by using parameters
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    // Execute the query and check if any rows are returned
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    isValid = userCount > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (isValid)
            {
                return GetUserRole(username);
            }
            else
            {
                MessageBox.Show("There seems to be an issue !!! ");
                return "issue";
            }
            
        }

        public static string GetUserRole(string username)
        {
            Connection();
            string query = "SELECT role FROM username_password WHERE username = @username";
            string role = "";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                // Prevent SQL Injection by using parameters
                cmd.Parameters.AddWithValue("@username", username);

                // Execute the query and retrieve the role
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    role = result.ToString();
                }
            }
            return role;

        }

        public static DataTable GetDataToTable(string query)
        {
            Connection();
            DataTable dt = new DataTable();
            try
            {
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                dataAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }



    }
}
