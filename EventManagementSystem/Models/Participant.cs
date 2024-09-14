using EventManagementSystem.Database;
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

        const string ViewAllAvailableEventsQuery =
                    "SELECT e.EventID, u.Username AS OrganizerName, e.EventName, e.Description, e.StartDate, e.EndDate, e.Location, e.MaxParticipants, e.CurrentParticipants " +
                    "FROM events e " +
                    "JOIN users u ON e.OrganizerID = u.UserID " +
                    "WHERE e.StartDate > NOW()" +
                    "AND e.CurrentParticipants < e.MaxParticipants;";

        const string GetParticipantIdQuery = "SELECT ParticipantID FROM participants WHERE UserID = @UserID";

        const string MaxParticipantsQuery = "SELECT MaxParticipants FROM events WHERE EventID = @EventID";
        const string CurrentParticipantsQuery = "SELECT CurrentParticipants FROM events WHERE EventID = @EventID";

        const string GetRegisteredEventsQuery =
            "SELECT b.BookingID, e.EventName, e.Description, e.StartDate, e.EndDate, e.Location " +
            "FROM Events e " +
            "INNER JOIN Bookings b ON e.EventID = b.EventID " +
            "WHERE b.ParticipantID = @ParticipantID;";


        const string UpdateParticipantsQuery = "UPDATE Events SET CurrentParticipants = CurrentParticipants - 1 WHERE EventID = @EventID;";



        public Participant(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        
        // Fuctionality to view all the events
        public DataTable ViewAllAvailableEvents()
        {
            return BookingCrudManager.ViewAllAvailableEvents();
        }

        // Functionality to book an event
        public (bool, string) BookEvent(int eventID, int userID)
        {
            return BookingCrudManager.BookEvent(eventID, userID);
        }

        // Fuctionality to get the registered events
        public DataTable GetRegisteredEvents(int userID)
        {
            return BookingCrudManager.GetRegisteredEvents(userID);

        }

        // Functionality to cancel booking
        public (bool, string) CancelBooking(int bookingID)
        {
            return BookingCrudManager.CancelBooking(bookingID);
        }

        
    }
}
