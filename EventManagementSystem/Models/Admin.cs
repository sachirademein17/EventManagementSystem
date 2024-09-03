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
    internal class Admin : User, IUserManagement, IEventManagement
    {
        public Admin(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }


        public (bool, string) CreateEvent(Event eventDetails)
        {
            try
            {
                string query = "INSERT INTO Events (OrganizerID, EventName, Description, StartDate, EndDate, Location, MaxParticipants, CurrentParticipants) VALUES (@OrganizerID, @EventName, @Description, @StartDate, @EndDate, @Location, @MaxParticipants, @CurrentParticipants);";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@OrganizerId",eventDetails.OrganizerID),
                    new MySqlParameter("@EventName", eventDetails.EventName),
                    new MySqlParameter("@Description",eventDetails.Description),
                    new MySqlParameter("@StartDate",eventDetails.StartDate),
                    new MySqlParameter("@EndDate",eventDetails.EndDate),
                    new MySqlParameter("@Location",eventDetails.Location),
                    new MySqlParameter("@MaxParticipants",eventDetails.MaxParticipants),
                    new MySqlParameter("@CurrentParticipants", eventDetails.CurrentParticipants)
                };

                int result = DBConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    return (true, "Event Created Successfully");
                }
                else
                {
                    return (false, "Even Not Created");
                }

            }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }
        }


        public (bool, string) DeleteEvent(int eventID)
        {
            try
            {
                string query = "DELETE FROM events WHERE EventID = @EventID;";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID",eventID)
                };

                int result = DBConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    return (true, "Event Deleted Successfully");
                }
                else
                {
                    return (false, "Event Not Deleted");
                }

            }
            catch (Exception ex)
            {
                return (false, "Database or Query Issue");
            }
        }
        

        public (bool, string) UpdateEvent(Event eventDetails)
        {
            try
            {
                string query = "UPDATE Events SET EventName = @EventName, Description = @Description, StartDate = @StartDate, EndDate = @EndDate, Location = @Location, MaxParticipants = @MaxParticipants, CurrentParticipants = @CurrentParticipants WHERE EventID = @EventID;";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventName", eventDetails.EventName),
                    new MySqlParameter("@Description", eventDetails.Description),
                    new MySqlParameter("@StartDate", eventDetails.StartDate),
                    new MySqlParameter("@EndDate", eventDetails.EndDate),
                    new MySqlParameter("@Location", eventDetails.Location),
                    new MySqlParameter("@MaxParticipants", eventDetails.MaxParticipants),
                    new MySqlParameter("@CurrentParticipants", eventDetails.CurrentParticipants),
                    new MySqlParameter("@EventID", eventDetails.EventID)
                };

                int result = DBConnection.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    return (true, "Event Updated Successfully");
                }
                else
                {
                    return (false, "Event Not Updated");
                }

            }
            catch (Exception e)
            {
                return (false, "Database or Query Issue");
            }
        }

       
        public List<Event> ViewEventParticipants(int eventID)
        {
            throw new NotImplementedException();
        }

        public DataTable ViewAllEvents()
        {
            try
            {
                string query = $"SELECT * FROM events;";
                DataTable allEvents = DBConnection.ExcecuteQuery(query);
                return allEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }
        }

        public (bool, string) AddUser(User user)
        {
            try
            {

                string checkUsername = "SELECT COUNT(*) FROM Users WHERE Username = @Username;";

                MySqlParameter[] check = new MySqlParameter[]
                {
                    new MySqlParameter("@Username", user.UserName)
                };

                int count = Convert.ToInt32(DBConnection.ExecuteScalar(checkUsername,check));

                if (count > 0) 
                { 
                    return (false, "This User Exists.");
                }


                string query = "INSERT INTO Users (Username, PasswordHash, Role, Email, PhoneNumber, DateCreated) VALUES (@Username, @PasswordHash, @Role, @Email, @PhoneNumber, NOW());";

                MySqlParameter[] parameters = new MySqlParameter[] {
                    new MySqlParameter("@Username", user.UserName),
                    new MySqlParameter("@PasswordHash", user.PasswordHash),
                    new MySqlParameter("@Role", user.Role),
                    new MySqlParameter("@Email", user.Email),
                    new MySqlParameter("@PhoneNumber", user.PhoneNumber),
                };
                int result = DBConnection.ExecuteNonQuery(query, parameters);

                if (!(result > 0))
                {
                    return (false, "Unable to Create User");
                }

                if (user.Role.Equals("Participant"))
                {

                    string getUserID = "SELECT UserID FROM Users WHERE Username = @Username;";

                    MySqlParameter[] getID = new MySqlParameter[]
                    {
                        new MySqlParameter ("@Username", user.UserName)
                    };

                    int newUserID = Convert.ToInt32(DBConnection.ExecuteScalar(getUserID, getID));


                    string participantQuery = "INSERT INTO Participants (UserID, Name, Email, PhoneNumber) VALUES (@UserID, @Name, @Email, @PhoneNumber);";

                    MySqlParameter[] participantParameters = new MySqlParameter[]
                    {
                        new MySqlParameter("@UserID", newUserID),
                        new MySqlParameter("@Name", user.UserName),
                        new MySqlParameter("@Email", user.Email),
                        new MySqlParameter("@PhoneNumber", user.PhoneNumber)
                    };
                    MessageBox.Show("It Works Till here");
                    int participantCreated = DBConnection.ExecuteNonQuery(participantQuery, participantParameters);

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

        public (bool, string) RemoveUser(int userID)
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

        public (bool, string) UpdateUser(User userDetails, string userName)
        {

            try
            {
                string checkUsername = "SELECT COUNT(*) FROM Users WHERE Username = @Username;";

                MySqlParameter[] check = new MySqlParameter[]
                {
                    new MySqlParameter("@Username", userDetails.UserName)
                };

                int count = Convert.ToInt32(DBConnection.ExecuteScalar(checkUsername, check));

                if (!userDetails.UserName.Equals(userName))
                {
                    if (count > 0)
                    {
                        return (false, "This User Exists.");
                    }
                }



                string query = "UPDATE Users SET Username = @Username, PasswordHash = @PasswordHash, Email = @Email, PhoneNumber = @PhoneNumber, Role = @Role WHERE UserID = @UserID;";

                MySqlParameter[] parameters = new MySqlParameter[] {
                    new MySqlParameter("@Username", userDetails.UserName),
                    new MySqlParameter("@PasswordHash", userDetails.PasswordHash),
                    new MySqlParameter("@Role", userDetails.Role),
                    new MySqlParameter("@Email", userDetails.Email),
                    new MySqlParameter("@PhoneNumber", userDetails.PhoneNumber),
                    new MySqlParameter("@UserID", userDetails.UserID)
                };
                int result = DBConnection.ExecuteNonQuery(query, parameters);

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

        public DataTable ViewAllUsers()
        {
            try
            {
                string query = $"SELECT * FROM users;";
                DataTable allEvents = DBConnection.ExcecuteQuery(query);
                return allEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }
        }




        public (bool, string) UserTextBoxValidation(string username, string password, string confirmPassword, string email, string phoneNumber, string role  )
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
