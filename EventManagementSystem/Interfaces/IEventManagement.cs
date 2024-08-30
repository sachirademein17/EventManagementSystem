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
        (bool,string) CreateEvent(Event eventDetails);
        (bool, string) UpdateEvent(Event eventDetails);
        (bool, string) DeleteEvent(int eventID);
        List<Event> ViewEventParticipants(int eventID);
    }
}
