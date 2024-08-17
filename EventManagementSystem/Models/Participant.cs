using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    internal class Participant : User
    {
        public Participant(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }

        public override bool LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }

        public override void LogOut()
        {
            throw new NotImplementedException();
        }
    }
}
