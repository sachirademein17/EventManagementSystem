using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class Event
    {
        /*
            The purpose to create an Event class is becuase, in an event there are properties such as
                    Event ID
                    Organizer ID
                    Event Name
                    Description
                    Start Date
                    End Date
                    Max Participant
                    Current Participant

            If there wasn't a class created for this, we need to pass these properties one by one which is hard to do.
            So by creating an object as class we can store all the details related to an event in one place and it is 
            super easy to tranfer the values through methods.
      
         */


        private int eventID;
        private int organizerID;
        private string eventName;
        private string description;
        private DateTime startDate;
        private DateTime endDate;
        private string location;
        private int maxParticipants;
        private int currentParticipants;

        
        public Event(int eventID, int organizerID, string eventName, string description, DateTime startDate, DateTime endDate, string location, int maxParticipants, int currentParticipants)
        {
            this.eventID = eventID;
            this.organizerID = organizerID;
            this.eventName = eventName;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.location = location;
            this.maxParticipants = maxParticipants;
            this.currentParticipants = currentParticipants;

        }

        public int EventID
        {
            get { return eventID; }
            set { organizerID = value; }
        }

        public int OrganizerID
        {
            get { return organizerID; }
            set { organizerID = value; }
        }

        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public int MaxParticipants
        {
            get { return maxParticipants; }
            set { maxParticipants = value; }
        }

        public int CurrentParticipants
        {
            get { return currentParticipants; }
            set { currentParticipants = value; }
        }



    }
}
