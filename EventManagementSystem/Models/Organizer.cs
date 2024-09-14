using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Database;
using EventManagementSystem.Interfaces;
using EventManagementSystem.View;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.X509.Store;

namespace EventManagementSystem.Models
{
    internal class Organizer : User
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
            return EventCrudManager.CreateEvent(eventDetails);
        }


        // Functionality to Delete an Event
        public (bool, string) DeleteEvent(int eventID)
        {
            return EventCrudManager.DeleteEvent(eventID);
        }



        // Functionality to Update an Event
        public (bool, string) UpdateEvent(Event eventDetails)
        {
            return EventCrudManager.UpdateEvent(eventDetails);
        }

        // Fuctionality to View Created Events
        public DataTable ViewAllUpComingEvents(int organizerID)
        {
            return EventCrudManager.ViewAllOraganizedUpComingEvents(organizerID);
        }

        public DataTable ViewAllPastEvent(int organizerID)
        {
            return EventCrudManager.ViewAllOraganizedPastEvents(organizerID);
        }
       
        // Fuctionality to View all Bookings
        public DataTable ViewAllBookings(int organizerID)
        {
            return BookingCrudManager.ViewAllOrganizedBookings(organizerID);

        }

        // Fuctionality to Delete/Cancel Bookings
        public (bool, string) CancelBooking(int bookingID)
        {
            return BookingCrudManager.CancelBooking(bookingID);
        }


        // Create Event & Update Event Input field validation
        public (bool, string) TextBoxValidation(string eventName, string location, DateTime startDateTime, DateTime endDateTime, string maxParticipants, string description)
        {
            return EventCrudManager.TextBoxValidation(eventName, location, startDateTime, endDateTime, maxParticipants, description);
        }


        public (bool, string) UserTextBoxValidation(string username, string password, string confirmPassword, string email, string phoneNumber, string role)
        {
            return UserCrudManager.UserTextBoxValidation(username, password, confirmPassword, email, phoneNumber, role);
        }

        public (bool, string) UpdateUser(User userDetails, string userName)
        {
            return UserCrudManager.UpdateUser(userDetails, userName);

        }

        

    }
}
