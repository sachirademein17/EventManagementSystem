﻿using MySql.Data.MySqlClient;
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

        public DataTable ViewAllEvents()
        {
            try
            {
                string query = $"SELECT * FROM events ;";
                DataTable allEvents = DBConnection.ExcecuteQuery(query);
                return allEvents;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public bool BookEvent(int eventDetails, int userID)
        {
            try
            {

                int participantID = GetParticipantId(userID);

                if (participantID == -1)
                {
                    return false;
                }



                string insertQuery = "INSERT INTO Bookings (EventID, ParticipantID, BookingDate) VALUES (@EventID, @ParticipantID, NOW());";
                string updateQuery = "UPDATE Events SET CurrentParticipants = CurrentParticipants + 1 WHERE EventID = @EventID;";

                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID", eventDetails),
                    new MySqlParameter("@ParticipantID", participantID)
                };

                int result1 = DBConnection.ExecuteNonQuery(insertQuery, parameters);

                MySqlParameter[] parameters1 = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID", eventDetails)
                };

                int result2 = DBConnection.ExecuteNonQuery(updateQuery, parameters1);



                if (result1 > 0)
                {
                    if (result2 > 0) { 
                    return true;
                    }
                }
                
                    
                return false;
                
               }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Try Catch seen ekak bn");
                MessageBox.Show(userID.ToString());

                return false;
            }
        }

        public int GetParticipantId(int userID)
        {

            string query = "SELECT ParticipantID FROM participants WHERE UserID = @UserID";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
        new MySqlParameter("@UserID", userID)
            };

            Object result = new object();

            result = DBConnection.ExecuteScalar(query, parameters);

            if (result != null)
            {
                return Convert.ToInt32(result); // Ensure this conversion is safe by checking for null first
            }
            else
            {
                return -1; // Return a default value if no result is found
            }
        }

    }
}
