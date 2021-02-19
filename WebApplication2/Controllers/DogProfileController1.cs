using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class DogProfileController : Controller
    {
        private UserDbContext context;

        public DogProfileController(UserDbContext dbContext)
        {
            context = dbContext;
        }
        public IActionResult Index()
        {
            List<Dog> dogs = context.Dogs.ToList();
            return View(dogs);
        }
        public IActionResult Add()
        {
            AddDogViewModel addDogViewModel = new AddDogViewModel();

            return View(addDogViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddDogViewModel addDogViewModel)
        {
            if (ModelState.IsValid)
            {
                Dog newDog = new Dog
                {
                    DogName = addDogViewModel.DogName,
                    Location = addDogViewModel.Location,
                    Description = addDogViewModel.Description,
                    ColorLevel = addDogViewModel.ColorLevel,
                    Status = addDogViewModel.Status,
                };
                context.Dogs.Add(newDog);
                context.SaveChanges();

                return Redirect("/DogProfile");
            }
            return View(addDogViewModel);
        }
        public IActionResult Delete()
        {
            ViewBag.dogs = context.Dogs.ToList();

            return View();
        }
        [HttpPost]
        public IActionResult Delete(int[] dogIds)
        {
            foreach (int eventId in dogIds)
            {
                Dog dogById = context.Dogs.Find(eventId);
                context.Dogs.Remove(dogById);
            }

            context.SaveChanges();

            return Redirect("/DogProfile");
        }
        public IActionResult Profile(int id)
        {
            Dog dog = context.Dogs.Find(id);
            return View(dog);
        }


    }
}
