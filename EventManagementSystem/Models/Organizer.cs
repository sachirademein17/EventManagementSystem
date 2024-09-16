﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManagementSystem.Database;
using EventManagementSystem.Interfaces;
using EventManagementSystem.View;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.X509.Store;

namespace EventManagementSystem.Models
{
    internal class Organizer : User
    {

        
        public Organizer(int userID, string username, string passwordHash, string email, string phoneNumber, string role) : base(userID, username, passwordHash, email, phoneNumber, role)
        {
        }



        public (bool, string) UserTextBoxValidation(string username, string password, string confirmPassword, string email, string phoneNumber, string role)
        {
            return UserCrudManager.UserTextBoxValidation(username, password, confirmPassword, email, phoneNumber, role);
        }

        public (bool, string) UpdateUser(User userDetails, string userName)
        {
            return UserCrudManager.UpdateUser(userDetails, userName);

        }

        

    }
}
