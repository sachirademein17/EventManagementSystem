using LiveChartsCore.Themes;
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


        const string AlreadyRegisteredQuery = "SELECT COUNT(*) FROM Bookings WHERE EventID = @EventID AND ParticipantID = @ParticipantID";
        const string AddBookingQuery = "INSERT INTO Bookings (EventID, ParticipantID, BookingDate) VALUES (@EventID, @ParticipantID, NOW());";
        const string IncreseCurrentParticipantsQuery = "UPDATE Events SET CurrentParticipants = CurrentParticipants + 1 WHERE EventID = @EventID;";

        const string ViewAllEventsQuery =
                    "SELECT e.EventID, u.Username AS OrganizerName, e.EventName, e.Description, e.StartDate, e.EndDate, e.Location, e.MaxParticipants, e.CurrentParticipants " +
                    "FROM events e " +
                    "JOIN users u ON e.OrganizerID = u.UserID " +
                    "WHERE e.StartDate > NOW()" +
                    "AND e.CurrentParticipants < e.MaxParticipants;";

        const string GetParticipantIdQuery = "SELECT ParticipantID FROM participants WHERE UserID = @UserID";

        const string MaxParticipantsQuery = "SELECT MaxParticipants FROM events WHERE EventID = @EventID";
        const string CurrentParticipantsQuery = "SELECT CurrentParticipants FROM events WHERE EventID = @EventID";

        const string GetRegisteredEventsQuery = "SELECT e.EventID, e.EventName, e.Description, e.StartDate, e.EndDate, e.Location FROM Events e INNER JOIN Bookings b ON e.EventID = b.EventID WHERE b.ParticipantID = @ParticipantID;";

        const string DeleteBookingQuery = "DELETE FROM Bookings WHERE EventID = @EventID AND ParticipantID = @ParticipantID;";

        const string UpdateParticipantsQuery = "UPDATE Events SET CurrentParticipants = CurrentParticipants - 1 WHERE EventID = @EventID;";



        public Participant(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        // Fuctionality to view all the events
        public DataTable ViewAllEvents()
        {
            try
            {
                // Execute view all events query
                DataTable allEvents = DBConnection.ExcecuteQuery(ViewAllEventsQuery);
                return allEvents;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // Functionality to book an event
        public (bool, string) BookEvent(int eventID, int userID)
        {
            try
            {
                // Getting the participantID
                int participantID = GetParticipantId(userID);

                // Validating the participantID
                if (participantID == -1)
                {
                    return (false, "Can't find the Participant ID");
                }

                // Checking events current participant No has exceeded the maximum participant 
                if (!CheckCanRegister(eventID))
                {
                    return (false, "Participant limit for the event has exceeded");
                }

                // Parameter for the Already Registered query
                MySqlParameter[] alreadyRegisteredParameter = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID", eventID),
                    new MySqlParameter("@ParticipantID", participantID)
                };

                // Execute already registered query
                int alreadyRegisteredResult = Convert.ToInt32(DBConnection.ExecuteScalar(AlreadyRegisteredQuery, alreadyRegisteredParameter));

                // Check whether participant is already registered
                if (alreadyRegisteredResult > 0)
                {
                    return (false, "You have already Booked this event");
                }

                // Parameter for the Add Booking query
                MySqlParameter[] addBookingParameter = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID", eventID),
                    new MySqlParameter("@ParticipantID", participantID)
                };

                // Execute Add Booking query
                int addBookingResult = DBConnection.ExecuteNonQuery(AddBookingQuery, addBookingParameter);

                // Parameter for the Increase Current Participants query 
                MySqlParameter[] increaseCurrentParticipantsParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID", eventID)
                };

                // Execute Increase Current Participants query
                int increaseParticipants = DBConnection.ExecuteNonQuery(IncreseCurrentParticipantsQuery, increaseCurrentParticipantsParameters);

                // Giving user feedback if all operations are successful
                if (addBookingResult > 0)
                {
                    if (increaseParticipants > 0) { 
                    return (true, "Booking add successfully");
                    }
                }
                
                // If operation is unsuccessful
                return (false, "Unable to add a booking");
                
               }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }
        }

        // Fuctionality to get the registered events
        public DataTable GetRegisteredEvents(int userID)
        {
            try
            {
                // Get the participant ID
                int participantID = GetParticipantId(userID);

                
                
                // Parameters for the Get Registered Events Query
                MySqlParameter[] getRegisteredEventsParameter = new MySqlParameter[]
                {
                    new MySqlParameter ("@ParticipantID", participantID)
                };

                //Execute the Get Registered Event Query
                DataTable dt = DBConnection.ExcecuteQuery(GetRegisteredEventsQuery, getRegisteredEventsParameter);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        // Functionality to cancel booking
        public (bool, string) CancelBooking(int eventID, int userID)
        {
            try
            {
                //Getting the partcipant ID
                int participantID = GetParticipantId(userID);


                
                // Parameter for the delete booking query
                MySqlParameter[] deleteBookingParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID", eventID),
                    new MySqlParameter("@ParticipantID", participantID)
                };

                // Execute Delete Booking query
                int deleteBookingResult = DBConnection.ExecuteNonQuery(DeleteBookingQuery, deleteBookingParameters);

                
                // Parameters for the Update Current Participants query
                MySqlParameter[] updateParticipantsParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID", eventID)
                };

                // Excecute Update Curren Participants query
                int updateParticipantsResult = DBConnection.ExecuteNonQuery(UpdateParticipantsQuery, updateParticipantsParameters);

                if (deleteBookingResult > 0)
                {
                    if (updateParticipantsResult > 0)
                    {
                        return (true, "Booking Cancelled Successfully");
                    }
                }

                return (false, "BookingNot Not Cancelled");

            }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }
        }


        // Functionality to get the ParticipantID
        public int GetParticipantId(int userID)
        {


            // Parameter for the Get ParticipantID query
            MySqlParameter[] getParticipantIdParameters = new MySqlParameter[]
            {
                new MySqlParameter("@UserID", userID)
            };

            // Execute Get ParticipnatId query
            object result = DBConnection.ExecuteScalar(GetParticipantIdQuery, getParticipantIdParameters);

            // validating the result
            if (result != null)
            {
                return Convert.ToInt32(result); 
            }
            else
            {
                return -1; 
            }
        }

        // Checking events current participant No has exceeded the maximum participant 
        private bool CheckCanRegister(int eventID)
        {

            try
            {
                
                int maxParticipants = 0;
                int currentParticipants = 0;

                // Parameters for the MaxParticipants & CurrentParticipants Queries
                MySqlParameter[] ParticipantsParameter = new MySqlParameter[]
                {
                    new MySqlParameter("EventID", eventID)
                };

                // Executing both MaxParticipants & CurrentParticipants Queries
                object max = DBConnection.ExecuteScalar(MaxParticipantsQuery, ParticipantsParameter);
                object current = DBConnection.ExecuteScalar(CurrentParticipantsQuery, ParticipantsParameter);

                // Validating the values
                if (max != null && current != null)
                {
                    maxParticipants = int.Parse(max.ToString());
                    currentParticipants = int.Parse(current.ToString());
                }


                // Return whether space available for the event or not
                return maxParticipants == 0 || currentParticipants < maxParticipants;

            }
            catch (Exception ex) 
            {
                return false;
            }
            

        }


    }
}
