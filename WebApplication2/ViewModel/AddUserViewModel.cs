using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Usernames must be between 5-25 characters long.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Sorry, but the given password is too short. Passwords must be at least 6 characters long.")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The confirmation password must match password provided!")]
        public string ConfirmPassword { get; set; }
        public bool Admin { get; set; }
    }

}
