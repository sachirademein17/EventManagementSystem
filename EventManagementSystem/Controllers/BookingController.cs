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

        // Fuctionality to View all upcoming Bookings
        public DataTable ViewAllUpcomingBookings(int organizerID)
        {
            return BookingCrudManager.ViewAllOrganizedUpcomingBookings(organizerID);
        }

        // Functionality to view all past bookings
        public DataTable ViewAllPastBookings(int organizerID)
        {
            return BookingCrudManager.ViewAllOrganizedPastBookings(organizerID);
        }


        // Fuctionality to get the registered Up Coming events
        public DataTable RegisteredUpcomingEvents(int userID)
        {
            return BookingCrudManager.RegisteredUpcomingEvents(userID);
        }

        // Fuctionality to get the registered Past events
        public DataTable RegisteredPastEvents(int userID)
        {
            return BookingCrudManager.RegisteredPastEvents(userID);
        }

   

    }
}
