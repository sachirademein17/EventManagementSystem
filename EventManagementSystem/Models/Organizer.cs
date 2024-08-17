using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Interfaces;

namespace EventManagementSystem.Models
{
    internal class Organizer : User, IEventManagement
    {
        public Organizer(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        public void CreateEvent(Event eventDetails)
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent(int eventID)
        {
            throw new NotImplementedException();
        }

        public override bool LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public override void LogOut()
        {
            throw new NotImplementedException();
        }

        public void UpdateEvent(Event eventDetails)
        {
            throw new NotImplementedException();
        }

        public List<Event> ViewEventParticipants(int eventID)
        {
            throw new NotImplementedException();
        }
    }
}
