using AspNet_PassingData.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_PassingData.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
            {
             new User() { FirstName = "Uğur", LastName = "Şeşen" },
             new User() { FirstName = "Ahmet", LastName = "Çalışkan" },
             new User() { FirstName = "Vedat", LastName = "Kıvrak" },
             new User() { FirstName = "Betül", LastName = "Orhan" }
            };

        public IActionResult UserViewBag()
        {
            ViewBag.UserName = "Uğur Şeşen";

            User user = new User();

            user.FirstName = "Uğur";
            user.LastName = "Şeşen";
            ViewBag.User = user;

         
            ViewBag.Users = users;
            return View(ViewBag);
        }

        public IActionResult UserViewData()
        {
            ViewData["Name"] = "Uğur";

            User user = new User();
            user.FirstName = "Uğur";
            user.LastName = "Şeşen";

            ViewData["User"] = user;
            ViewData["Users"] = users;
            return View(ViewData);
        }

        public IActionResult UseTempData()
        {
            TempData["name"] = "Uğur";
            //return View();
            return RedirectToAction("TempDataTest");
        }

        public IActionResult TempDataTest()
        {
            TempData.Keep("name");
            string userName = TempData["name"].ToString();
            return View();
        }
    }
}