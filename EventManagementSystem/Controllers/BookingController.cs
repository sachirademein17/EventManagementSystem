using EventManagementSystem.Database;
using EventManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Controllers
{
    internal class BookingController : IBookingManagement
    {
        // Functionality to book an event
        public (bool, string) BookEvent(int eventID, int userID)
        {
            return BookingCrudManager.BookEvent(eventID, userID);
        }

        // Functionality to cancel booking
        public (bool, string) CancelBooking(int bookingID)
        {
            return BookingCrudManager.CancelBooking(bookingID);
        }

        // Fuctionality to view all the events
        public DataTable ViewAllAvailableEvents()
        {
            return BookingCrudManager.ViewAllAvailableEvents();
        }

        // Fuctionality to View all Bookings
        public DataTable ViewAllBookings(int organizerID)
        {
            return BookingCrudManager.ViewAllOrganizedBookings(organizerID);
        }

        // Fuctionality to get the registered events
        public DataTable GetRegisteredEvents(int userID)
        {
            return BookingCrudManager.GetRegisteredEvents(userID);

        }
    }
}
