using EventManagementSystem.Database;
using EventManagementSystem.Interfaces;
using EventManagementSystem.View;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    internal class Admin : User, IUserManagement, IEventManagement
    {

        public Admin(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

       

        public (bool, string) CreateEvent(Event eventDetails)
        {
            return EventCrudManager.CreateEvent(eventDetails);
        }


        public (bool, string) DeleteEvent(int eventID)
        {
            return EventCrudManager.DeleteEvent(eventID);
        }
        

        public (bool, string) UpdateEvent(Event eventDetails)
        {
            return EventCrudManager.UpdateEvent(eventDetails);
        }


        public DataTable ViewAllEvents()
        {
            return EventCrudManager.ViewAllEvents();
        }

        // Create Event & Update Event Input field validation
        public (bool, string) TextBoxValidation(string eventName, string location, DateTime startDateTime, DateTime endDateTime, string maxParticipants, string description)
        {
            return EventCrudManager.TextBoxValidation(eventName, location, startDateTime, endDateTime, maxParticipants, description);
        }



        public (bool, string) AddUser(User user)
        {
            return UserCrudManager.AddUser(user);
        }

        public (bool, string) RemoveUser(int userID)
        {

            return UserCrudManager.RemoveUser(userID);

        }

        public (bool, string) UpdateUser(User userDetails, string userName)
        {
            return UserCrudManager.UpdateUser(userDetails, userName);

        }

        public DataTable ViewAllUsers()
        {
            return UserCrudManager.ViewAllUsers();
        }




        public (bool, string) UserTextBoxValidation(string username, string password, string confirmPassword, string email, string phoneNumber, string role  )
        {
            return UserCrudManager.UserTextBoxValidation(username, password, confirmPassword, email, phoneNumber, role);
        }

        public DataTable ViewAllEvents(int eventID)
        {
            throw new NotImplementedException();
        }
    }
}
