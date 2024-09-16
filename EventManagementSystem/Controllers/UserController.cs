using EventManagementSystem.Database;
using EventManagementSystem.Interfaces;
using EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Controllers
{
    internal class UserController : IUserManagement
    {

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


        public (bool, string) UserTextBoxValidation(string username, string password, string confirmPassword, string email, string phoneNumber, string role)
        {
            return UserCrudManager.UserTextBoxValidation(username, password, confirmPassword, email, phoneNumber, role);
        }

    }
}
