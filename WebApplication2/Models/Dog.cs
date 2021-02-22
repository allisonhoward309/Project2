using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Dog
    {
        /*will need to be able to store and image as a variable */
        public int Id { get; set; }
        public string DogName { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string ColorLevel { get; set; }
        public bool CheckedOut { get; set; }

        public string Activity { get; set; }
        public DateTime TimeCheckOut { get; set; }
        public DateTime TimeCheckIn { get; set; }

        public Dog()
        {

        }
        public Dog(string dogName, string location, string description, string colorLevel, bool checkedOut, string activity, DateTime timeCheckOut, DateTime timeCheckIn)
        {
            DogName = dogName;
            Location = location;
            Description = description;
            ColorLevel = colorLevel;
            CheckedOut = checkedOut;
            Activity = activity;
            TimeCheckOut = timeCheckOut;
            TimeCheckIn = timeCheckIn;
        }

    }
}
