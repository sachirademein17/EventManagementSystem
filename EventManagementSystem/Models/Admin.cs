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
    public class Admin : User
    {

        public Admin(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }


        public override (bool, string) LogOut( )
        {
            return base.LogOut();
        }

        public override void UpdateProfile(User user, Form dashboard )
        {
            base.UpdateProfile(user, dashboard);
        }




    }
}
