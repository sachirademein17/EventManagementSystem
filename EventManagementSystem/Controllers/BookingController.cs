using EventManagementSystem.CrudManagers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Controllers
{
    /*
        
        The purpose of creating a booking controller is that bookings are done by all the users.
        So if we add booking methods in all the user classes there is going to be a repeating of the same code at multiple places.
        So by creating a booking controller class we can aligned all the methods that are related to booking in one class where
        any user can access by createing a instance of that object and by calling the relavant method.
      
     */
    internal class BookingController
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

        // Functionality to view all booking logs
        public DataTable ViewAllBookingLog(int organizerID)
        {
            return BookingCrudManager.ViewAllOrganizedBookingLogs(organizerID);
        }

        // Fuctionality to get the registered events
        public DataTable GetRegisteredEvents(int userID)
        {
            return BookingCrudManager.GetRegisteredEvents(userID);

        }

        // Functionality to get the registered events log
        public DataTable GetRegisteredEventLogs(int userID)
        {
            return BookingCrudManager.GetRegisteredEventLogs(userID);
        }

        public DataTable RegisteredParticipants(int eventID)
        {
            return BookingCrudManager.RegisteredParticipants(eventID);
        }

    }
}
