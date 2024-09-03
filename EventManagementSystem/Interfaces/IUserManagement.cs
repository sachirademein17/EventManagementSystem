using EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Interfaces
{
    internal interface IUserManagement
    {
        (bool, string) AddUser(User user);
        (bool, string) RemoveUser(int userID);
        (bool, string) UpdateUser(User userID, string username);


        DataTable ViewAllUsers();
    }
}
