using EventManagementSystem.Controllers;
using EventManagementSystem.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem.Models
{
    public abstract class User
    {

        /*
         
        The purpose of creating a User class is becuase there are 3 types of users: 
            Admin
            Organizer
            Participant

        All these 3 types of users have common types of properties. such as 
            User ID
            Username
            Password
            Email
            Phone Number
            Role ( Type of user(eg:- Admin, Organizer, Participant )

        And they hv the common methods such as
            Logout
            Update Profile
          
        So rather than creating the same set of properties and methods over and over again it is easy to create a class.
        And make sure that the other classes (Admin, Organizer, Participant) inherite the properties and the methods from it.
 
         
         */

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

         


      

        // Method to Logout 
        public virtual (bool, string) LogOut()
        {
            
            return (true, "Logged Out Successfully.");
        }

        // Method to update the profile
        public virtual void UpdateProfile(User user, Form dashboard)
        {
            new UpdateProfile(user, dashboard).ShowDialog();
        }
        
        

        }
}
