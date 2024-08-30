using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Interfaces;
using EventManagementSystem.View;
using MySql.Data.MySqlClient;

namespace EventManagementSystem.Models
{
    internal class Organizer : User, IEventManagement
    {
        public Organizer(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        public (bool,string) CreateEvent(Event eventDetails)
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
                    return (true, "Event Created Successfully");
                }
                else
                {
                    return (false, "Even Not Created");
                }

            }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }
        }

        public (bool, string) DeleteEvent(int eventID)
        {
            try
            {
                string query = "DELETE FROM events WHERE EventID = @EventID;";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID",eventID)
                };

                int result = DBConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    return (true, "Event Deleted Successfully");
                }
                else
                {
                    return (false, "Event Not Deleted");
                }

            }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }
        }




        public (bool,string) UpdateEvent(Event eventDetails)
        {
            try
            {
                string query = "UPDATE Events SET EventName = @EventName, Description = @Description, StartDate = @StartDate, EndDate = @EndDate, Location = @Location, MaxParticipants = @MaxParticipants, CurrentParticipants = @CurrentParticipants WHERE EventID = @EventID;";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventName", eventDetails.EventName),
                    new MySqlParameter("@Description", eventDetails.Description),
                    new MySqlParameter("@StartDate", eventDetails.StartDate),
                    new MySqlParameter("@EndDate", eventDetails.EndDate),
                    new MySqlParameter("@Location", eventDetails.Location),
                    new MySqlParameter("@MaxParticipants", eventDetails.MaxParticipants),
                    new MySqlParameter("@CurrentParticipants", eventDetails.CurrentParticipants),
                    new MySqlParameter("@EventID", eventDetails.EventID)
                };

                int result = DBConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    return (true, "Event Updated Successfully");
                }
                else
                {
                    return (false, "Event Not Updated");
                }

            }
            catch (Exception e)
            {
                return (false, "Database or Query Issue");
            }
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
                    new DangerToaster("Database or Query Issue");
                    return null;
                }
            }

            public List<Event> ViewEventParticipants(int eventID)
            {
                throw new NotImplementedException();
            }
        }
    } 
