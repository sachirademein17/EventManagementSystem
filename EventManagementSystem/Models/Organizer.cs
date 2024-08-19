using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Interfaces;
using MySql.Data.MySqlClient;

namespace EventManagementSystem.Models
{
    internal class Organizer : User, IEventManagement
    {
        public Organizer(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        public bool CreateEvent(Event eventDetails)
        {
            try
            {
                string query = "INSERT INTO Events (OrganizerID, EventName, Description, StartDate, EndDate, Location, MaxParticipants, CurrentParticipants) VALUES (@OrganizerID, @EventName, @Description, @StartDate, @EndDate, @Location, @MaxParticipants, @CurrentParticipants);";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@OrganizerId",eventDetails.OrganizerID),
                    new MySqlParameter("@EventName", eventDetails.EventName),
                    new MySqlParameter("@Description",eventDetails.Description),
                    new MySqlParameter("@StartDate",eventDetails.StartDate),
                    new MySqlParameter("@EndDate",eventDetails.EndDate),
                    new MySqlParameter("@Location",eventDetails.Location),
                    new MySqlParameter("@MaxParticipants",eventDetails.MaxParticipants),
                    new MySqlParameter("@CurrentParticipants", eventDetails.CurrentParticipants)
                };

                int result = DBConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            { 
                return false; 
            }
        }

        public void DeleteEvent(int eventID)
        {
            throw new NotImplementedException();
        }

        
        

        public void UpdateEvent(Event eventDetails)
        {
            throw new NotImplementedException();
        }

        public DataTable ViewAllEvents(int organizerID)
        {
            try
            {
                string query = $"SELECT * FROM events WHERE OrganizerID = {organizerID};";
                DataTable allEvents = DBConnection.ExcecuteQuery(query);
                return allEvents;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public List<Event> ViewEventParticipants(int eventID)
        {
            throw new NotImplementedException();
        }
    }
}
