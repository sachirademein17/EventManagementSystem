using System;
using System.Collections.Generic;
using System.Data;
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
        DataTable ViewAllEvents(int eventID);


    }
}
