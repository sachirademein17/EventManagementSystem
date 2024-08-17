using EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Interfaces
{
    internal interface IUserManagement
    {
        void AddUser(User user);
        void RemoveUser(User user);
        void UpdateUser(int userID);
        List<User> GetAllUsers(int userID);
    }
}
