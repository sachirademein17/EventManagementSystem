using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Interfaces
{
    internal interface IBookingManagement 
    {
        (bool, string) CancelBooking(int bookingID);
        DataTable ViewAllBookings(int organizerID);
        (bool, string) BookEvent(int eventID, int userID);
        DataTable ViewAllAvailableEvents();
        DataTable GetRegisteredEvents(int userID);
    }
}
