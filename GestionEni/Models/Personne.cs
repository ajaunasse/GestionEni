using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionEni.Models
{
    public class Personne
    {
        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        [Required]
        private string username;
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        [Required]
        [DataType(DataType.Password)]
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}