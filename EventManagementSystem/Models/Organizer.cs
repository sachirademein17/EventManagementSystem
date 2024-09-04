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
using Org.BouncyCastle.X509.Store;

namespace EventManagementSystem.Models
{
    internal class Organizer : User, IEventManagement
    {

        // Query to Create an Event
        const string CreateEventQuery = "INSERT INTO Events (OrganizerID, EventName, Description, StartDate, EndDate, Location, MaxParticipants, CurrentParticipants) " +
                                        "VALUES (@OrganizerID, @EventName, @Description, @StartDate, @EndDate, @Location, @MaxParticipants, @CurrentParticipants);";
        
        // Query to Delete an Event
        const string DeleteEventQuery = "DELETE FROM events WHERE EventID = @EventID;";
        
        // Query to Update an Event
        const string UpdateEventQuery = "UPDATE Events" +
                                        " SET EventName = @EventName, Description = @Description, StartDate = @StartDate, EndDate = @EndDate, Location = @Location, MaxParticipants = @MaxParticipants" +
                                        " WHERE EventID = @EventID;";
        
        // Query to View all Events
        const string ViewAllEventsQuery =   "SELECT EventID, EventName, Description, StartDate, EndDate, Location, MaxParticipants, CurrentParticipants " +
                                            "FROM Events " +
                                            "WHERE OrganizerID = @OrganizerID;";

        // Query to View all Bookings
        const string ViewAllBookingsQuery = "SELECT b.BookingID, e.EventName, p.Name AS ParticipantName, p.Email AS ParticipantEmail, p.PhoneNumber AS ParticipantPhoneNumber " +
                                            "FROM Bookings b" +
                                            " JOIN Events e ON b.EventID = e.EventID " +
                                            "JOIN Participants p ON b.ParticipantID = p.ParticipantID " +
                                            "JOIN Users u ON e.OrganizerID = u.UserID " +
                                            "WHERE u.UserID = @OrganizerUserID;";

        // Query to Cancel Bookings
        const string CancelBookingQuery = "DELETE FROM bookings WHERE BookingID = @BookingID;";
        const string GetEventIDQuery = "SELECT EventID FROM bookings WHERE BookingID = @BookingID;";
        const string DecrementCurrentEventParticipantsQuery = "UPDATE events SET CurrentParticipants = CurrentParticipants - 1 WHERE EventID = @EventID;";


        public Organizer(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }


        // Functinality to Create an Event
        public (bool, string) CreateEvent(Event eventDetails)
        {
            try
            {
                                
                // Parameters for the CreateEventQuery
                MySqlParameter[] createEventParameters = new MySqlParameter[]
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

                // Execute CreateEventQuery
                int result = DBConnection.ExecuteNonQuery(CreateEventQuery, createEventParameters);

                // Returning user feedback message
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


        // Functionality to Delete an Event
        public (bool, string) DeleteEvent(int eventID)
        {
            try
            {
                // Parameters for the DeleteEventQuery
                MySqlParameter[] deleteEventParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID",eventID)
                };

                // Executing DeleteEventQuery
                int result = DBConnection.ExecuteNonQuery(DeleteEventQuery, deleteEventParameters);

                // Returning user feedback message
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



        // Functionality to Update an Event
        public (bool, string) UpdateEvent(Event eventDetails)
        {
            try
            {
                // Parameters for the UpdateEventQuery
                MySqlParameter[] updateEventParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventName", eventDetails.EventName),
                    new MySqlParameter("@Description", eventDetails.Description),
                    new MySqlParameter("@StartDate", eventDetails.StartDate),
                    new MySqlParameter("@EndDate", eventDetails.EndDate),
                    new MySqlParameter("@Location", eventDetails.Location),
                    new MySqlParameter("@MaxParticipants", eventDetails.MaxParticipants),
                    new MySqlParameter("@EventID", eventDetails.EventID)
                };

                // Executing the UpdateEventQuery
                int result = DBConnection.ExecuteNonQuery(UpdateEventQuery, updateEventParameters);

                // Returning User Feedback message
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

        // Fuctionality to View Created Events
        public DataTable ViewAllEvents(int organizerID)
        {
            try
            {
                // Parameter for the ViewAllEventsQuery
                MySqlParameter[] viewAllEventsParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@OrganizerID" , organizerID)
                };
                
                // Executing the ViewAllEventsQuery
                DataTable allEvents = DBConnection.ExcecuteQuery(ViewAllEventsQuery, viewAllEventsParameters );

                // Returning DataTable for the DataGridView
                return allEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }
        }

       
        // Fuctionality to View all Bookings
        public DataTable ViewAllBookings(int organizerID)
        {
            try
            {
                
                // Parameters for the ViewAllBookingsQuery
                MySqlParameter[] viewAllBookingsParameter = new MySqlParameter[]
                {
                    new MySqlParameter("@OrganizerUserID", organizerID)
                };

                // Executing the ViewAllBookingsQuery
                DataTable allEvents = DBConnection.ExcecuteQuery(ViewAllBookingsQuery, viewAllBookingsParameter);

                // Returning DataTable for the DataGridView
                return allEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }

        }

        // Fuctionality to Delete/Cancel Bookings
        public (bool, string) CancelBooking(int bookingID)
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


        // Create Event & Update Event Input field validation
        public (bool, string) TextBoxValidation(string eventName, string location, DateTime startDateTime, DateTime endDateTime, string maxParticipants, string description)
        {
            int temp;

            // Checking whether event name is entered
            if (string.IsNullOrEmpty(eventName))
            {
                return (false, "Please Enter the Event Name");
            }

            // Checking whether location/venue is entered
            if (string.IsNullOrEmpty(location))
            {
                return (false, "Please Enter the Event Venue");
            }

            // Checking whether the default values are entered
            if (startDateTime == default(DateTime))
            {
                return (false, "Please Enter the Starting Date & Time");
            }

            // Checking whether the default values are entered
            if (endDateTime == default(DateTime))
            {
                return (false, "Please Enter the Ending Date & Time");
            }

            // Checking whether the startDateTime is 1 hour from the current time
            if (startDateTime <= DateTime.Now.AddHours(1))
            {
                return (false, "Must add an Event atlease 1 hour from Now");
            }

            // Checking whether the endDateTime is after the startDateTime
            if (endDateTime <= startDateTime)
            {
                return (false, "End Date must be after the start date.");
            }

            // Checking whether valid number is entered for the maxParticipants
            if (!int.TryParse(maxParticipants, out temp))
            {
                return (false, "Please Enter a Number for Max Participants");
            }

            // Checking whether the maxParticipant is greater than 0
            if (temp <= 0)
            {
                return (false, "Please Enter a valid Maximum Number of Participants");
            }

            // Checking whether the description field is entered
            if (string.IsNullOrEmpty(description))
            {
                return (false, "Please Enter the Description");
            }

            return (true, "Good To Go");
        }



    }
}
