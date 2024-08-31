using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Interfaces;
using EventManagementSystem.View;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;

namespace EventManagementSystem.Models
{
    internal class Organizer : User, IEventManagement
    {
        public Organizer(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }


        


        public (bool, string) CreateEvent(Event eventDetails)
        {
            try
            {

               /* (bool validation, string errormsg) = TextBoxValidation(eventDetails);

                if (validation)
                {
                    return (validation, errormsg);
                }*/


                

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




        public (bool, string) UpdateEvent(Event eventDetails)
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

        public DataTable ViewAllBookings(int organizerID)
        {
            try
            {
                string query = $"SELECT b.BookingID, b.EventID, b.ParticipantID, b.BookingDate " +
                    $"FROM Bookings b " +
                    $"JOIN Events e ON b.EventID = e.EventID " +
                    $"JOIN Users u ON e.OrganizerID = u.UserID " +
                    $"WHERE u.UserID = @OrganizerUserID;";

                MySqlParameter[] parameter = new MySqlParameter[]
                {
                    new MySqlParameter("@OrganizerUserID", organizerID)
                };

                DataTable allEvents = DBConnection.ExcecuteQuery(query, parameter);
                return allEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }

        }

        public (bool, string) DeleteBooking(int bookingID)
        {
            try
            {
                string query = "DELETE FROM bookings WHERE BookingID = @BookingID;";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@BookingID",bookingID)
                };

                int result = DBConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    return (true, "Booking Deleted Successfully");
                }
                else
                {
                    return (false, "Booking Not Deleted");
                }

            }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }
        }



        public (bool, string) TextBoxValidation(string eventName, string location, DateTime startDate, DateTime endDate, string maxParticipants, string description)
        {
            int temp;

            if (string.IsNullOrEmpty(eventName))
            {
                return (false, "Please Enter the Event Name");
            }

            if (string.IsNullOrEmpty(location))
            {
                return (false, "Please Enter the Event Venue");
            }

            if (startDate == default(DateTime))
            {
                return (false, "Please Enter the Starting Date & Time");
            }

            if (endDate == default(DateTime))
            {
                return (false, "Please Enter the Ending Date & Time");
            }

            if (endDate <= startDate)
            {
                return (false, "End Date must be after the start date.");
            }

            if (!int.TryParse(maxParticipants, out temp))
            {
                return (false, "Please Enter a Number for Max Participants");
            }

            if (temp <= 0)
            {
                return (false, "Please Enter a valid Maximum Number of Participants");
            }

            if (string.IsNullOrEmpty(description))
            {
                return (false, "Please Enter the Description");
            }

            return (true, "Good To Go");
        }



    }
}
