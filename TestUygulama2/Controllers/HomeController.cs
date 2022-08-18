using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using TestUygulama2.DataDB;
using TestUygulama2.Models;

namespace TestUygulama2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Volkan()
        {
            return View();
        }

        public IActionResult Index()
        {
            testContext context = new testContext();
            var users = context.Users.ToList();
            //List<User> userList = new List<User>();
            //User k1 = new User();
            //k1.Name = "Volkan";
            //k1.Surname = "Taşkın";
            //k1.Age = 39;
            //userList.Add(k1);
            //userList.Add(new DataDB.User { Age = 31, Name = "Gökhan", Surname = "Taşkın" });
            return View(users);
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