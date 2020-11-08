using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_8.Models;

namespace Project_8.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILogger<HomeController> _logger;

      public HomeController(ILogger<HomeController> logger)
      {
         _logger = logger;
      }

      public IActionResult index()
      {
         return View("SignIn");
      }
      [HttpGet]
      public IActionResult SignUp()
      {
         return View("SignUp");
      }
      [HttpPost]
      public IActionResult SignUp(User i)
      {
         if (ModelState.IsValid)
         {
            return View("UserDetails", i);
         }
         else
         {
            return View(i);
         }
        }
      [HttpGet]
      public IActionResult EditUser()
      {
         User p = new User();
         p.Fname = "Paul";
         p.Lname = "Musili";
         p.Uname = "Musilip";
         p.Tname = "Mr";

         return View(p); 
      }


      [HttpPost]
      public IActionResult EditUser(User Info)
      {
         if (ModelState.IsValid)
         {
            return View("UserDetails", Info);
         }
         else
         {
            return View(Info);
         }

      }



      public IActionResult Privacy()
      {
         return View();
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
      }
   }
}
