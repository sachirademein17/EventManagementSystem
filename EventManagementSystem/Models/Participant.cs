using EventManagementSystem.Database;
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
    internal class Participant : User
    {

        Participant user = (Participant)CurrentUser.UserDetails;


        public Participant(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        public override (bool, string) LogOut( )
        {
            return base.LogOut();
        }


    }
}
