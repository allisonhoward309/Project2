using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Data;
using WebApplication2.Models;
using WebApplication2.ViewModels;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private UserDbContext context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, UserDbContext dbContext)
        {
            _logger = logger;
            context = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tag(string login, string keyword)
        {
            ViewBag.user = context.Dogs.ToList();

            foreach(User u in ViewBag.user) {
                if(login == u.Username) {
                    return RedirectToAction("Index", "DogProfile");
                }
            }
            return View();
        }
        public IActionResult Add()
        {
            AddUserViewModel addUserViewModel = new AddUserViewModel();

            return View(addUserViewModel);
        }
        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {
                User newUSer = new User
                {
                    FirstName = addUserViewModel.FirstName,
                    LastName = addUserViewModel.LastName,
                    Email = addUserViewModel.Email,
                    Phone = addUserViewModel.Phone,
                    Password = addUserViewModel.Password,
                    ConfirmPassword = addUserViewModel.ConfirmPassword,
                    Admin = addUserViewModel.Admin
                };
                context.Users.Add(newUSer);
                context.SaveChanges();

                return Redirect("/Home");
            }
            return View(addUserViewModel);
        }
    }
}
