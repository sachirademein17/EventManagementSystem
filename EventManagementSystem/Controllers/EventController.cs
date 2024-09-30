using EventManagementSystem.CrudManagers;
using EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Controllers
{
    /*
        
        The purpose of creating a event controller is that events are managed by both Admin and organizer.
        So if we add event methods in both the user classes there is going to be a repeating of the same code at multiple places.
        So by creating a event controller class we can aligned all the methods that are related to events in one class where
        any user can access by createing a instance of that object and by calling the relavant method.
      


     */
    internal class EventController
    {

        
        
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

        // Fuctionality to View Up Coming Events
        public DataTable ViewUpcomingEvents(int organizerID)
        {
            return EventCrudManager.ViewAllOraganizedUpComingEvents(organizerID);
        }

        // Fucntionality to View Past Events
        public DataTable ViewPastEvents(int organizerID)
        {
            return EventCrudManager.ViewAllOraganizedPastEvents(organizerID);
        }

        // Calling view up coming events functionality
        public DataTable ViewUpcomingEvents()
        {
            return EventCrudManager.ViewAllUpComingEvents();
        }

        // Calling view past events functionality
        public DataTable ViewPastEvents()
        {
            return EventCrudManager.ViewAllPastEvents();
        }

        // Create Event & Update Event Input field validation
        public (bool, string) EventTextBoxValidation(string eventName, string location, DateTime startDateTime, DateTime endDateTime, string maxParticipants, int currentParticipants, string description)
        {
            return EventCrudManager.EventTextBoxValidation(eventName, location, startDateTime, endDateTime, maxParticipants, currentParticipants, description);
        }



    }
}
