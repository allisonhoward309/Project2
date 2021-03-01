using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebApplication2.Areas.Identity.Pages.Data
{
    public class ApplicationUser : IdentityUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public bool Admin { get; set; }


        public ApplicationUser()
        {

        }
        public ApplicationUser(string firtName, string lastName, string phone, string username, bool admin)
        {
            FirstName = FirstName;
            LastName = lastName;
            Phone = phone;
            Username = username;
            Admin = admin;
        }

    }
}
