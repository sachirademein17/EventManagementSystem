using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    internal abstract class User
    {

        private int userID;
        private string username;
        private string passwordHash;
        private string email;
        private string phoneNumber;
        private string role;

        public User(int userID, string username, string passwordHash, string email, string phoneNumber,string role)
        {
            this.userID = userID;
            this.username = username;
            this.passwordHash = passwordHash;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.role = role;


        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string UserName
        {
            get { return username; }
            set { username = value; }
        }

        public string PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }

        public abstract bool LogIn (string username, string password); 
        public abstract void LogOut ();


    }
}
