using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Models;
using EventManagementSystem.View;

namespace EventManagementSystem.Interfaces
{
    internal interface IEventManagement
    {
        (bool,string) CreateEvent(Event eventDetails);
        (bool, string) UpdateEvent(Event eventDetails);
        (bool, string) DeleteEvent(int eventID);
        List<Event> ViewEventParticipants(int eventID);

        (bool, string) TextBoxValidation(string eventName, string location, DateTime startDate, DateTime endDate, string maxParticipants, string description)
        {
            int temp;

            if (string.IsNullOrEmpty(eventName))
            {
                return (false, "Please Enter the Event Name");
            }

            if (string.IsNullOrEmpty(location))
            {
                return (false, "Please Enter the Event Venue");
            }

            if (startDate == default(DateTime))
            {
                return (false, "Please Enter the Starting Date & Time");
            }

            if (endDate == default(DateTime))
            {
                return (false, "Please Enter the Ending Date & Time");
            }

            if (endDate <= startDate)
            {
                return (false, "End Date must be after the start date.");
            }

            if (!int.TryParse(maxParticipants, out temp))
            {
                return (false, "Please Enter a Number for Max Participants");
            }

            if (temp <= 0)
            {
                return (false, "Please Enter a valid Maximum Number of Participants");
            }

            if (string.IsNullOrEmpty(description))
            {
                return (false, "Please Enter the Description");
            }

            return (true, "Good To Go");
        }

    }
}
