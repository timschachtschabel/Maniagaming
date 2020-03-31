using System;
using System.Collections.Generic;
using System.Text;

namespace Mania.Core.Models
{
    class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
