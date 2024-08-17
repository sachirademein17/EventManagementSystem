using EventManagementSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    internal class Admin : User, IUserManagement
    {
        public Admin(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        public void AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUsers(int userID)
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

        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(int userID)
        {
            throw new NotImplementedException();
        }

    }
}
