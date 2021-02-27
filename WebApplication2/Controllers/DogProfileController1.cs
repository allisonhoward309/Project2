using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
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
                        CheckedOut = false,
                        TimeCheckIn = DateTime.Now,
                        ImageSource = "/image/" + addDogViewModel.DogName + ".jpg"

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
            foreach (int dogId in dogIds)
            {
                Dog dogById = context.Dogs.Find(dogId);
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
        [HttpPost]
        public IActionResult CheckOut(string activity, int dogID, string page)
        {
            var status = context.Dogs.Find(dogID);
            status.CheckedOut = true;
            status.Activity = activity;
            status.TimeCheckOut = DateTime.Now;
            context.SaveChanges();
            if (page == "DogProfile")
            {
                return Redirect("/" + page);
            }
            else
            {
                return Redirect("/dogprofile/" + page + "/" + dogID);
            }
        }
        public IActionResult CheckIn(int dogID, string page)
        {
            var status = context.Dogs.Find(dogID);
            status.CheckedOut = false;
            status.TimeCheckIn = DateTime.Now;
            context.SaveChanges();
            if (page == "DogProfile")
            {
                return Redirect("/" + page);
            }
            else
            {
                return Redirect("/dogprofile/" + page + "/" + dogID);
            }
        }
    }
}