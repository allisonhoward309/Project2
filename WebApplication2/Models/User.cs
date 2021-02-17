using System;

namespace WebApplication2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool Admin { get; set; }


        public User()
        {

        }
        public User(string firtName, string lastName, string email, string phone, string username, string password, string confirmPassword, bool admin)
        {
            FirstName = FirstName;
            LastName = lastName;
            Email = email;
            Phone = phone;
            Username = username;
            Password = password;
            ConfirmPassword = confirmPassword;
            Admin = admin;
        }



    }
}
