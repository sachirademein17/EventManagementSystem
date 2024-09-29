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

        //public virtual (bool, string) UpdateUser();

        


        public static (bool, string) DeleteProfile(int userID)
        {
            try
            {
                string query = "DELETE FROM Users WHERE UserID = @UserID;";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@UserID", userID)
                };

                int result = DBConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    return (true, "The Profile is Deleted Successfully");
                }

                return (false, "Unable to Delete the Profile");

            }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }

        }


        public virtual (bool, string) LogOut()
        {
            
            return (true, "Logged Out Successfully.");
        }

        public virtual void UpdateProfile(User user, Form dashboard)
        {
            new UpdateProfile(user, dashboard).ShowDialog();
        }
        
        

        }
}
