using EventManagementSystem.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    internal class Admin : User, IUserManagement, IEventManagement
    {
        public Admin(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
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

        public bool DeleteEvent(int eventID)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers(int userID)
        {
            throw new NotImplementedException();
        }

        

        
        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEvent(Event eventDetails)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int userID)
        {
            throw new NotImplementedException();
        }

        public List<Event> ViewEventParticipants(int eventID)
        {
            throw new NotImplementedException();
        }
    }
}
