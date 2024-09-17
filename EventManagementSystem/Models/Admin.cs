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
    internal class Admin : User
    {

        public Admin(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }


        public override (bool, string) DeleteProfile(int userID)
        {
            return base.DeleteProfile(userID);
        }


        public override void LogOut()
        {
            base.LogOut();
        }



    }
}
