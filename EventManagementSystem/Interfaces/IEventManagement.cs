using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Models;

namespace EventManagementSystem.Interfaces
{
    internal interface IEventManagement
    {
        bool CreateEvent(Event eventDetails);
        bool UpdateEvent(Event eventDetails);
        bool DeleteEvent(int eventID);
        List<Event> ViewEventParticipants(int eventID);
    }
}
