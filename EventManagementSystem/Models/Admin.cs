using EventManagementSystem.CrudManagers;
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
    public class Admin : User
    {

        /*
         The purpose to create a class called admin is becuase there is a type of user as admin
         
         */

        public Admin(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        // Method to logout from the Admin dashboard
        public override (bool, string) LogOut( )
        {
            return base.LogOut();
        }

        // Method to update the admin profile
        public override void UpdateProfile(User user, Form dashboard )
        {
            base.UpdateProfile(user, dashboard);
        }




    }
}
