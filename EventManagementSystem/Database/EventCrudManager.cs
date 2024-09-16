using EventManagementSystem.Models;
using EventManagementSystem.View;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EventManagementSystem.Database
{
    internal class EventCrudManager
    {

        // Query to Create an Event
        const string CreateEventQuery = 
                    "INSERT INTO Events (OrganizerID, EventName, Description, StartDate, EndDate, Location, MaxParticipants, CurrentParticipants) " +
                    "VALUES (@OrganizerID, @EventName, @Description, @StartDate, @EndDate, @Location, @MaxParticipants, @CurrentParticipants);";

        // Query to Delete an Event
        const string DeleteEventQuery = "DELETE FROM events WHERE EventID = @EventID;";

        // Query to Update an Event
        const string UpdateEventQuery = 
                    "UPDATE Events" +
                    " SET EventName = @EventName, Description = @Description, StartDate = @StartDate, EndDate = @EndDate, Location = @Location, MaxParticipants = @MaxParticipants" +
                    " WHERE EventID = @EventID;";

        // Query to View all Organized Upcoming Events
        const string ViewAllOrganizedUpcomingEventsQuery =
                    "SELECT EventID, EventName, Description, StartDate, EndDate, Location, MaxParticipants, CurrentParticipants " +
                    "FROM Events " +
                    "WHERE OrganizerID = @OrganizerID AND StartDate >= NOW();";

        // Query to View all Organized Past Events
        const string ViewAllOrganizedPastEventsQuery =
                    "SELECT EventID, EventName, Description, StartDate, EndDate, Location, MaxParticipants, CurrentParticipants " +
                    "FROM Events " +
                    "WHERE OrganizerID = @OrganizerID AND StartDate < NOW();";


        // Query to View all Upcoming Events
        const string ViewAllUpcomingEventsQuery = 
                    "SELECT e.EventID, e.EventName,u.Username AS OrganizerName, e.Description, e.StartDate, e.EndDate, e.Location, e.MaxParticipants, e.CurrentParticipants " +
                    "FROM events e " +
                    "JOIN users u ON e.OrganizerID = u.UserID " +
                    "WHERE e.StartDate >= NOW();";

        // Query to view all past events
        const string ViewAllPastEventsQuery =
                    "SELECT e.EventID, e.EventName,u.Username AS OrganizerName, e.Description, e.StartDate, e.EndDate, e.Location, e.MaxParticipants, e.CurrentParticipants " +
                    "FROM events e " +
                    "JOIN users u ON e.OrganizerID = u.UserID " +
                    "WHERE e.StartDate < NOW();";


        // Functionality to create and event
        public static (bool, string) CreateEvent(Event eventDetails)
        {
            try
            {
                // Parameters for the CreateEventQuery
                MySqlParameter[] createEventParameters = new MySqlParameter[]
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

                // Execute CreateEventQuery
                int result = DBConnection.ExecuteNonQuery(CreateEventQuery, createEventParameters);

                // Returning user feedback message
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






        // Functionality to delete an event
        public static (bool, string) DeleteEvent(int eventID)
        {
            try
            {
                // Parameters for the DeleteEventQuery
                MySqlParameter[] deleteEventParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventID",eventID)
                };

                // Executing DeleteEventQuery
                int result = DBConnection.ExecuteNonQuery(DeleteEventQuery, deleteEventParameters);

                // Returning user feedback message
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






        // Functionality to update an event
        public static (bool, string) UpdateEvent(Event eventDetails)
        {
            try
            {
                // Parameters for the UpdateEventQuery
                MySqlParameter[] updateEventParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@EventName", eventDetails.EventName),
                    new MySqlParameter("@Description", eventDetails.Description),
                    new MySqlParameter("@StartDate", eventDetails.StartDate),
                    new MySqlParameter("@EndDate", eventDetails.EndDate),
                    new MySqlParameter("@Location", eventDetails.Location),
                    new MySqlParameter("@MaxParticipants", eventDetails.MaxParticipants),
                    new MySqlParameter("@EventID", eventDetails.EventID)
                };

                // Executing the UpdateEventQuery
                int result = DBConnection.ExecuteNonQuery(UpdateEventQuery, updateEventParameters);

                // Returning User Feedback message
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



        // Functionality to view all organized Up coming events 
        public static DataTable ViewAllOraganizedUpComingEvents(int organizerID)
        {
            try
            {
                // Parameter for the ViewAllEventsQuery
                MySqlParameter[] viewAllEventsUpComingParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@OrganizerID" , organizerID)
                };

                // Executing the ViewAllEventsQuery
                DataTable allEvents = DBConnection.ExcecuteQuery(ViewAllOrganizedUpcomingEventsQuery, viewAllEventsUpComingParameters);

                // Returning DataTable for the DataGridView
                return allEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }
        }



        // Functionality to view all oraganized past events
        public static DataTable ViewAllOraganizedPastEvents(int organizerID)
        {
            try
            {
                // Parameter for the ViewAllEventsQuery
                MySqlParameter[] viewAllEventsPastParameters = new MySqlParameter[]
                {
                    new MySqlParameter("@OrganizerID" , organizerID)
                };

                // Executing the ViewAllEventsQuery
                DataTable allPastEvents = DBConnection.ExcecuteQuery(ViewAllOrganizedPastEventsQuery, viewAllEventsPastParameters);

                // Returning DataTable for the DataGridView
                return allPastEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }
        }


        // Functionality to view all the up coming events
        public static DataTable ViewAllUpComingEvents()
        {
            try
            {

                DataTable allUpcomingEvents = DBConnection.ExcecuteQuery(ViewAllUpcomingEventsQuery);
                return allUpcomingEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }
        }

        // Functionality to view all the past events
        public static DataTable ViewAllPastEvents()
        {
            try
            {

                DataTable allEvents = DBConnection.ExcecuteQuery(ViewAllPastEventsQuery);
                return allEvents;
            }
            catch (Exception ex)
            {
                new DangerToaster("Database or Query Issue");
                return null;
            }
        }



        // Functionality to validation all the user UI inputs
        public static (bool, string) EventTextBoxValidation(string eventName, string location, DateTime startDateTime, DateTime endDateTime, string maxParticipants, int currentParticipants, string description)
        {
            int temp;

            // Checking whether event name is entered
            if (string.IsNullOrEmpty(eventName))
            {
                return (false, "Please Enter the Event Name");
            }

            // Checking whether location/venue is entered
            if (string.IsNullOrEmpty(location))
            {
                return (false, "Please Enter the Event Venue");
            }

            // Checking whether the default values are entered
            if (startDateTime == default(DateTime))
            {
                return (false, "Please Enter the Starting Date & Time");
            }

            // Checking whether the default values are entered
            if (endDateTime == default(DateTime))
            {
                return (false, "Please Enter the Ending Date & Time");
            }

            // Checking whether the startDateTime is 1 hour from the current time
            if (startDateTime <= DateTime.Now.AddHours(1))
            {
                return (false, "Must add an Event atlease 1 hour from Now");
            }

            // Checking whether the endDateTime is after the startDateTime
            if (endDateTime <= startDateTime)
            {
                return (false, "End Date must be after the start date.");
            }

            // Checking whether valid number is entered for the maxParticipants
            if (!int.TryParse(maxParticipants, out temp))
            {
                return (false, "Please Enter a Number for Max Participants");
            }

            // Checking whether the maxParticipant is greater than 0
            if (temp <= 0)
            {
                return (false, "Please Enter a valid Maximum Number of Participants");
            }

            if (temp < currentParticipants) {
                return (false, "Max Participant Number must be greater than the current participant number");
            }

            // Checking whether the description field is entered
            if (string.IsNullOrEmpty(description))
            {
                return (false, "Please Enter the Description");
            }

            return (true, "Good To Go");
        }





    }
}
