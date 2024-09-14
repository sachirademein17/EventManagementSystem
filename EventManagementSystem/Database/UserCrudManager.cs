using EventManagementSystem.Models;
using EventManagementSystem.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Database
{
    internal class UserCrudManager
    {

        const string CheckUsername = "SELECT COUNT(*) FROM Users WHERE Username = @Username;";
        
        
        const string AddUserQuery = "INSERT INTO Users (Username, PasswordHash, Role, Email, PhoneNumber, DateCreated) VALUES (@Username, @PasswordHash, @Role, @Email, @PhoneNumber, NOW());";
        const string GetUserIdQuery = "SELECT UserID FROM Users WHERE Username = @Username;";
        const string ParticipantQuery = "INSERT INTO Participants (UserID, Name, Email, PhoneNumber) VALUES (@UserID, @Name, @Email, @PhoneNumber);";



        const string RemoveUserQuery = "DELETE FROM Users WHERE UserID = @UserID;";


        const string UpdateUserQuery = "UPDATE Users SET Username = @Username, PasswordHash = @PasswordHash, Email = @Email, PhoneNumber = @PhoneNumber, Role = @Role WHERE UserID = @UserID;";

        const string ViewAllUsersQuery = "SELECT * FROM users;";





        public static (bool, string) AddUser(User user)
        {
            try
            {


                MySqlParameter[] checkUsernameParameter = new MySqlParameter[]
                {
                    new MySqlParameter("@Username", user.UserName)
                };

                int count = Convert.ToInt32(DBConnection.ExecuteScalar(CheckUsername, checkUsernameParameter));

                if (count > 0)
                {
                    return (false, "This User Exists.");
                }



                MySqlParameter[] addUserParameters = new MySqlParameter[] {
                    new MySqlParameter("@Username", user.UserName),
                    new MySqlParameter("@PasswordHash", user.PasswordHash),
                    new MySqlParameter("@Role", user.Role),
                    new MySqlParameter("@Email", user.Email),
                    new MySqlParameter("@PhoneNumber", user.PhoneNumber),
                };
                int result = DBConnection.ExecuteNonQuery(AddUserQuery, addUserParameters);

                if (!(result > 0))
                {
                    return (false, "Unable to Create User");
                }

                if (user.Role.Equals("Participant"))
                {


                    MySqlParameter[] getUserIdParameter = new MySqlParameter[]
                    {
                        new MySqlParameter ("@Username", user.UserName)
                    };

                    int newUserID = Convert.ToInt32(DBConnection.ExecuteScalar(GetUserIdQuery, getUserIdParameter));



                    MySqlParameter[] participantParameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@UserID", newUserID),
                        new MySqlParameter("@Name", user.UserName),
                        new MySqlParameter("@Email", user.Email),
                        new MySqlParameter("@PhoneNumber", user.PhoneNumber)
                    };
                    MessageBox.Show("It Works Till here");
                    int participantCreated = DBConnection.ExecuteNonQuery(ParticipantQuery, participantParameters);

                    if (participantCreated > 0)
                    {
                        return (true, "Participant Created Successfully");
                    }
                    else
                    {
                        return (false, "Participant Not created");
                    }

                }

                else
                {
                    return (true, "Organizer Created Successfully");
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return (false, "Database or Query Issue");
            }
        }





        public static (bool, string) RemoveUser(int userID)
        {

            try
            {

                MySqlParameter[] removeUserParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@UserID", userID)
                };

                int result = DBConnection.ExecuteNonQuery(RemoveUserQuery, removeUserParameters);

                if (result > 0)
                {
                    return (true, "User Deleted Successfully");
                }
                else
                {
                    return (false, "User Not Deleted");
                }

            }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }

        }






        public static (bool, string) UpdateUser(User userDetails, string userName)
        {

            try
            {

                MySqlParameter[] checkUsernameParameter = new MySqlParameter[]
                {
                    new MySqlParameter("@Username", userDetails.UserName)
                };

                int count = Convert.ToInt32(DBConnection.ExecuteScalar(CheckUsername, checkUsernameParameter));

                if (!userDetails.UserName.Equals(userName))
                {
                    if (count > 0)
                    {
                        return (false, "This User Exists.");
                    }
                }




                MySqlParameter[] updateUserParameter = new MySqlParameter[] {
                    new MySqlParameter("@Username", userDetails.UserName),
                    new MySqlParameter("@PasswordHash", userDetails.PasswordHash),
                    new MySqlParameter("@Role", userDetails.Role),
                    new MySqlParameter("@Email", userDetails.Email),
                    new MySqlParameter("@PhoneNumber", userDetails.PhoneNumber),
                    new MySqlParameter("@UserID", userDetails.UserID)
                };
                int result = DBConnection.ExecuteNonQuery(UpdateUserQuery, updateUserParameter);

                if (!(result > 0))
                {
                    return (false, "Unable to Update User");
                }

                return (true, "User is Updated");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return (false, "We are screwed");
            }

        }




        public static DataTable ViewAllUsers()
        {
            try
            {
                DataTable allEvents = DBConnection.ExcecuteQuery(ViewAllUsersQuery);
                return allEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }
        }




        public static (bool, string) UserTextBoxValidation(string username, string password, string confirmPassword, string email, string phoneNumber, string role)
        {
            int temp;

            if (string.IsNullOrEmpty(username))
            {
                return (false, "Please Enter the Username");
            }

            if (string.IsNullOrEmpty(password))
            {
                return (false, "Please Enter the Password");
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                return (false, "Please Confirm the Password");
            }

            if (!password.Equals(confirmPassword))
            {
                return (false, "Please Confirm Your Password");
            }

            if (string.IsNullOrEmpty(email))
            {
                return (false, "Please Enter the Email");
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                return (false, "Please Enter the Phone Number");
            }

            bool isNumber = int.TryParse(phoneNumber, out temp);

            if (!isNumber)
            {
                return (false, "Please Enter a Number as the Phone Number");
            }

            if (string.IsNullOrEmpty(role))
            {
                return (false, "Please Select a Role");
            }

            return (true, "Good To Go");
        }

    }
}
