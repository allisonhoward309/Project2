using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class DogProfileController : Controller
    {ds
        public IActionResult Index()
        {
            return View();
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
                return Redirect("/Dog");
            }
            return View(addDogViewModel);
        }
    }
}
