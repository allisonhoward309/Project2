using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModels
{
    public class AddDogViewModel
    {
        [Required(ErrorMessage = "The dog's name is required")]
        public string DogName { get; set; }
        [Required(ErrorMessage = "The dog's location is required")]
        public string Location { get; set; }
        public string Description { get; set; }
        public string ColorLevel { get; set; }
        public bool Status { get; set; }
    }
}
