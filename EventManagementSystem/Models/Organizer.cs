using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.CrudManagers;
using EventManagementSystem.View;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.X509.Store;

namespace EventManagementSystem.Models
{
    public class Organizer : User
    {

        /*
         The purpose to create a class called organizer is becuase there is a type of user as organizer 
         
         */
        
        public Organizer(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        // Method to logout from the organizer dashboard
        public override (bool, string) LogOut( )  
        {
            return base.LogOut();
        }

        // Method to update the oragnizer profile
        public override void UpdateProfile(User user, Form dashboard)
        {
            base.UpdateProfile(user, dashboard);
        }


    }
}
