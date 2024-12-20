﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class UserModel
    {

        /// <summary>
        /// Represents player identification- to link to DB
        /// </summary>

        public int Id { get; set; }

        /// <summary>
        /// Represents the first name of the player
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Respresents the last name of the player
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents the email address of the player
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// Represents the cellphone number of the player
        /// which cannot be added as a math number
        /// </summary>
        public string PhoneNumber { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }
    }
}


