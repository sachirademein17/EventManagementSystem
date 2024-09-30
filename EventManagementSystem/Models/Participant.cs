using EventManagementSystem.CrudManagers;
using LiveChartsCore.Themes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    public class Participant : User
    {

        /*
         The purpose to create a class called participant is becuase there is a type of user as participant 
         
         */

        public Participant(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        // Method to logout from the participant dashboard
        public override (bool, string) LogOut( )
        {
            return base.LogOut();
        }

        // Method to update the participant profile
        public override void UpdateProfile(User user, Form dashboard)
        {
            base.UpdateProfile(user, dashboard);
        }

    }
}
