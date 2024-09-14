using Google.Protobuf.WellKnownTypes;
using K4os.Compression.LZ4.Streams.Adapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem.Models
{
    internal class CurrentUser
    {
        private static User currentUser;
        private static User userDetails;

        public CurrentUser(User user)
        {
            UserDetails = user;
        }

        public static User UserDetails
        {
            get { return userDetails; }
            private set { userDetails = value; }
        }

        public static void ClearUserDetails()
        {
            userDetails = null;
        }
    }
}