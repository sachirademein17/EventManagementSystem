using EventManagementSystem.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Database
{
    internal class BookingCrudManager
    {

        // Query to View all Bookings
        const string ViewAllOrganizedBookingsQuery = "SELECT b.BookingID, e.EventName, p.Name AS ParticipantName, p.Email AS ParticipantEmail, p.PhoneNumber AS ParticipantPhoneNumber " +
                                            "FROM Bookings b" +
                                            " JOIN Events e ON b.EventID = e.EventID " +
                                            "JOIN Participants p ON b.ParticipantID = p.ParticipantID " +
                                            "JOIN Users u ON e.OrganizerID = u.UserID " +
                                            "WHERE u.UserID = @OrganizerUserID;";

        // Query to Cancel Bookings
        const string CancelBookingQuery = "DELETE FROM bookings WHERE BookingID = @BookingID;";
        const string GetEventIDQuery = "SELECT EventID FROM bookings WHERE BookingID = @BookingID;";
        const string DecrementCurrentEventParticipantsQuery = "UPDATE events SET CurrentParticipants = CurrentParticipants - 1 WHERE EventID = @EventID;";



        const string AlreadyRegisteredQuery = "SELECT COUNT(*) FROM Bookings WHERE EventID = @EventID AND ParticipantID = @ParticipantID";
        const string AddBookingQuery = "INSERT INTO Bookings (EventID, ParticipantID, BookingDate) VALUES (@EventID, @ParticipantID, NOW());";
        const string IncreseCurrentParticipantsQuery = "UPDATE Events SET CurrentParticipants = CurrentParticipants + 1 WHERE EventID = @EventID;";
        
        
        const string GetParticipantIdQuery = "SELECT ParticipantID FROM participants WHERE UserID = @UserID";


        const string MaxParticipantsQuery = "SELECT MaxParticipants FROM events WHERE EventID = @EventID";
        const string CurrentParticipantsQuery = "SELECT CurrentParticipants FROM events WHERE EventID = @EventID";



        const string GetRegisteredEventsQuery =
            "SELECT b.BookingID, e.EventName, e.Description, e.StartDate, e.EndDate, e.Location " +
            "FROM Events e " +
            "INNER JOIN Bookings b ON e.EventID = b.EventID " +
            "WHERE b.ParticipantID = @ParticipantID;";



        const string ViewAllAvailableEventsQuery =
                    "SELECT e.EventID, u.Username AS OrganizerName, e.EventName, e.Description, e.StartDate, e.EndDate, e.Location, e.MaxParticipants, e.CurrentParticipants " +
                    "FROM events e " +
                    "JOIN users u ON e.OrganizerID = u.UserID " +
                    "WHERE e.StartDate > NOW()" +
                    "AND e.CurrentParticipants < e.MaxParticipants;";




        public static DataTable ViewAllOrganizedBookings(int organizerID)
        {
            try
            {

                // Parameters for the ViewAllBookingsQuery
                MySqlParameter[] viewAllOrganizedBookingsParameter = new MySqlParameter[]
                {
                    new MySqlParameter("@OrganizerUserID", organizerID)
                };

                // Executing the ViewAllBookingsQuery
                DataTable allEvents = DBConnection.ExcecuteQuery(ViewAllOrganizedBookingsQuery, viewAllOrganizedBookingsParameter);

                // Returning DataTable for the DataGridView
                return allEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }

        }




        public static (bool, string) CancelBooking(int bookingID)
        {
            try
            {

                // Parameters for the CancelBookingQuery & GetEventIDQuery
                MySqlParameter[] cancelBookingParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@BookingID",bookingID)
                };


                // Retrieve the EventID associated with the booking
                object result = DBConnection.ExecuteScalar(GetEventIDQuery, cancelBookingParameters);

                if (result == null || result == DBNull.Value)
                {
                    return (false, "Could not retrieve EventID for the given BookingID");
                }

                int eventID = Convert.ToInt32(result);

                // Parameters for the DecrementCurrentEventParticipants
                MySqlParameter[] decrementParticipantParameters = new MySqlParameter[]
                {
                    new MySqlParameter ("@EventID", eventID)
                };

                int decrementResult = DBConnection.ExecuteNonQuery(DecrementCurrentEventParticipantsQuery, decrementParticipantParameters);

                // Returning User feedback message after decreasing the event CurrentParticipant value by 1
                if (!(decrementResult > 0))
                {
                    return (false, "Booking Not Cancelled");
                }


                // Executing the CancelBookingQuery
                int cancelResult = DBConnection.ExecuteNonQuery(CancelBookingQuery, cancelBookingParameters);

                // Returning User feedback message after deleting the booking
                if (cancelResult > 0)
                {
                    return (true, "Booking Cancelled Successfully");
                }
                else
                {
                    return (false, "Booking Not Cancelled");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return (false, "Database or Query Issue");
            }
        }



        public static (bool, string) BookEvent(int eventID, int userID)
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
                    if (increaseParticipants > 0)
                    {
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



        // Functionality to get the ParticipantID
        private static int GetParticipantId(int userID)
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
        private static bool CheckCanRegister(int eventID)
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




        public static DataTable GetRegisteredEvents(int userID)
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



        public static DataTable ViewAllAvailableEvents()
        {
            try
            {
                // Execute view all events query
                DataTable allEvents = DBConnection.ExcecuteQuery(ViewAllAvailableEventsQuery);
                return allEvents;
            }
            catch (Exception ex)
            {
                return null;
            }
        }




    }
}
