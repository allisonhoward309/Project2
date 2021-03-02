using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Areas.Identity.Pages.Data;

namespace WebApplication2.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly RoleManager<ApplicationUser> roleManager;
        public AdministrationController(RoleManager<ApplicationUser> roleManager)
        {
            this.roleManager = roleManager;
        }
        public IActionResult CreateRole()
        {
            return View();
        }

    }
}
