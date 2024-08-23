using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    internal class Participant : User
    {

        Participant user = (Participant)CurrentUser.UserDetails;

        public Participant(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        public DataTable ViewAllEvents()
        {
            try
            {
                string query = $"SELECT * FROM events ;";
                DataTable allEvents = DBConnection.ExcecuteQuery(query);
                return allEvents;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

       
    }
}
