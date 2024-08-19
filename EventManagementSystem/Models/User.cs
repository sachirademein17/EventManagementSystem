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


        public static User LogIn(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Username", username),
                    new MySqlParameter("@PasswordHash", password)
                };

                DataTable result = DBConnection.ExcecuteQuery(query, parameters);

                if (result.Rows.Count > 0)
                {
                    int userID = Convert.ToInt32(result.Rows[0]["UserID"]);
                    string userName = result.Rows[0]["Username"].ToString();
                    string passwordHash = result.Rows[0]["PasswordHash"].ToString();
                    string email = result.Rows[0]["Email"].ToString();
                    string phoneNumber = result.Rows[0]["PhoneNumber"].ToString();
                    string role = result.Rows[0]["Role"].ToString();


                    
                    switch (role)
                    {
                        case "Admin":
                            return new Admin(userID, userName, passwordHash, email, phoneNumber, role);
                        case "Organizer":
                            return new Organizer(userID, userName, passwordHash, email, phoneNumber, role);
                        case "Participant":
                            return new Participant(userID, userName, passwordHash, email, phoneNumber, role);
                        default:
                            throw new Exception("Unknown role found.");
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            
            }

        


    }
}
