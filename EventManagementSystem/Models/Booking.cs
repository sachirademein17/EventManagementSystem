using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    internal class Booking
    {
        private int bookingID;
        private int eventID;
        private int participantID;
        private DateTime bookingDate;

        public Booking(int bookingID, int eventID, int participantID, DateTime bookingDate)
        {
            this.bookingID = bookingID;
            this.eventID = eventID;
            this.participantID = participantID;
            this.bookingDate = bookingDate;
        }

        public int BookingID 
        { 
            get { return bookingID; } 
            set { bookingID = value; }
        }

        public int EventID
        {
            get { return eventID; }
            set { eventID = value; }
        }

        public int ParticipantID
        {
            get { return participantID; }
            set { participantID = value; }
        }

        public DateTime BookingDate
        {
            get { return bookingDate; }
            set { bookingDate = value; }
        }

       
        public void ConfirmBooking()
        {

        }

        public void CancelBooking()
        {

        }

    }
}
