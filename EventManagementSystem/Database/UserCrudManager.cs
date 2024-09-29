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

        // Query to check how many timews the username as repeated
        const string CheckUsername = "SELECT COUNT(*) FROM Users WHERE Username = @Username;";
        
        // Queries to add user 
        const string AddUserQuery = "INSERT INTO Users (Username, PasswordHash, Role, Email, PhoneNumber, DateCreated) VALUES (@Username, @PasswordHash, @Role, @Email, @PhoneNumber, NOW());";
        const string GetUserIdQuery = "SELECT UserID FROM Users WHERE Username = @Username;";
        const string ParticipantQuery = "INSERT INTO Participants (UserID, Name, Email, PhoneNumber) VALUES (@UserID, @Name, @Email, @PhoneNumber);";


        // Query to remove user
        const string RemoveUserQuery = "DELETE FROM Users WHERE UserID = @UserID;";

        // Query to update user
        const string UpdateUserQuery = "UPDATE Users SET Username = @Username, PasswordHash = @PasswordHash, Email = @Email, PhoneNumber = @PhoneNumber, Role = @Role WHERE UserID = @UserID;";

        // Query to view all users
        const string ViewAllUsersQuery = "SELECT * FROM users;";

        const string LogInQuery = "SELECT * FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash";



        public static User LogIn(string username, string password)
        {
            try
            {

                MySqlParameter[] LogInParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@Username", username),
                    new MySqlParameter("@PasswordHash", password)
                };

                DataTable result = DBConnection.ExcecuteQuery(LogInQuery, LogInParameters);

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





        // Fuctionality to add user
        public static (bool, string) AddUser(User user)
        {
            try
            {


                MySqlParameter[] checkUsernameParameter = new MySqlParameter[]
                {
                    new MySqlParameter("@Username", user.UserName)
                };

                // Getting how much times that username has repeated
                int count = Convert.ToInt32(DBConnection.ExecuteScalar(CheckUsername, checkUsernameParameter));

                // If the count is > 0 that username is used
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

                // Add the user
                int result = DBConnection.ExecuteNonQuery(AddUserQuery, addUserParameters);

                // Checking whether the user is createed successfully
                if (!(result > 0))
                {
                    return (false, "Unable to Create User");
                }

                // If the user role is participant, user needs to be added to the participants table
                if (user.Role.Equals("Participant"))
                {


                    MySqlParameter[] getUserIdParameter = new MySqlParameter[]
                    {
                        new MySqlParameter ("@Username", user.UserName)
                    };

                    // Get the new user's ID
                    int newUserID = Convert.ToInt32(DBConnection.ExecuteScalar(GetUserIdQuery, getUserIdParameter));



                    MySqlParameter[] participantParameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@UserID", newUserID),
                        new MySqlParameter("@Name", user.UserName),
                        new MySqlParameter("@Email", user.Email),
                        new MySqlParameter("@PhoneNumber", user.PhoneNumber)
                    };

                    // Adds the user to the participants table
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
                // if the user role is organizer show user feedback
                else if (user.Role.Equals("Organizer"))
                {
                    return (true, "Organizer Created Successfully");
                }
                // if the user role is admin show user feedback
                else
                {
                    return (true, "Admin Created Successfully");
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return (false, "Database or Query Issue");
            }
        }




        // Functionality to remove user
        public static (bool, string) RemoveUser(int userID)
        {

            try
            {

                MySqlParameter[] removeUserParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@UserID", userID)
                };

                // Executing the remove user query
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





        // Functionality to update user
        public static (bool, string) UpdateUser(User userDetails, string userName)
        {

            try
            {

                MySqlParameter[] checkUsernameParameter = new MySqlParameter[]
                {
                    new MySqlParameter("@Username", userDetails.UserName)
                };

                // Check how many time does the username has repeated
                int count = Convert.ToInt32(DBConnection.ExecuteScalar(CheckUsername, checkUsernameParameter));

                // If it is the previous username allow it
                if (!userDetails.UserName.Equals(userName))
                {
                    // if the username is reaped give error
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

                //  Execute the update user query
                int result = DBConnection.ExecuteNonQuery(UpdateUserQuery, updateUserParameter);

                if (!(result > 0))
                {
                    return (false, $"Unable to Update User {userDetails.UserName}");
                }

                return (true, $"User {userDetails.UserName} is Updated");

            }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }

        }



        // Functionality to view all the users
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



        // Functionality to validation all the user UI inputs
        public static (bool, string) UserTextBoxValidation(string username, string password, string confirmPassword, string email, string phoneNumber, string role)
        {
            int temp;

            // Checking whether the username is entered
            if (string.IsNullOrEmpty(username))
            {
                return (false, "Please Enter the Username");
            }

            // Checking whether the password is entered
            if (string.IsNullOrEmpty(password))
            {
                return (false, "Please Enter the Password");
            }

            // Checking whether the confirm password is entered
            if (string.IsNullOrEmpty(confirmPassword))
            {
                return (false, "Please Confirm the Password");
            }

            // Checking whether the password is equal to the confirm password
            if (!password.Equals(confirmPassword))
            {
                return (false, "Please Confirm Your Password");
            }

            // Checking whether the email is entered
            if (string.IsNullOrEmpty(email))
            {
                return (false, "Please Enter the Email");
            }

            // Checking whether the phonenumber is entered
            if (string.IsNullOrEmpty(phoneNumber))
            {
                return (false, "Please Enter the Phone Number");
            }
                        
            bool isNumber = int.TryParse(phoneNumber, out temp);

            // Checking whether the phone number is a number
            if (!isNumber)
            {
                return (false, "Please Enter a Number as the Phone Number");
            }
           
            // Checking whether the role is entered
            if (string.IsNullOrEmpty(role))
            {
                return (false, "Please Select a Role");
            }

            return (true, "Good To Go");
        }

    }
}
