using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EventManagementSystem
{
    internal static class DBConnection
    {
        private static MySqlConnection connection = new MySqlConnection();

        public static void Connection()
        {
            connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=event_manager;");
            try
            {
                connection.Open();
                MessageBox.Show("Ok You Are Connected !!! ");
            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
            }
        }



    }
}
