using EventManagementSystem.CrudManagers;
using EventManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Controllers
{

    /*
        
        The purpose of creating a user controller is that bookings are done by all the users(mostly Admin, Organizer and Participant have privilages to change their profiles).
        So if we add booking methods in all the user classes there is going to be a repeating of the same code at multiple places.
        So by creating a user controller class we can aligned all the methods that are related to user in one class where
        any user can access by createing a instance of that object and by calling the relavant method.
      
     */

    internal class UserController
    {

        // Calling he login fuctionality
        public User LogIn(string username, string password)
        {
            return UserCrudManager.LogIn(username, password);   
        }

        // Calling the Add user fuctionality
        public (bool, string) AddUser(User user)
        {
            return UserCrudManager.AddUser(user);
        }

        // calling the remove user fuctionality
        public (bool, string) RemoveUser(int userID)
        {

            return UserCrudManager.RemoveUser(userID);

        }

        // calling the update user functionality
        public (bool, string) UpdateUser(User userDetails, string userName)
        {
            return UserCrudManager.UpdateUser(userDetails, userName);

        }

        // calling the view all users fuctionality
        public DataTable ViewAllUsers()
        {
            return UserCrudManager.ViewAllUsers();
        }

        // calling the texbox validation fuctionality
        public (bool, string) UserTextBoxValidation(string username, string password, string confirmPassword, string email, string phoneNumber, string role)
        {
            return UserCrudManager.UserTextBoxValidation(username, password, confirmPassword, email, phoneNumber, role);
        }

    }
}
