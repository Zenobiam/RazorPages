using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorPages.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace RazorPages.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
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

        //[Route("/login")]
        //[HttpPost]
        //public IActionResult Login([FromForm] Credentials credential)
        //{
        //
        //    if (credential != null)
        //    {
        //        User user = new User
        //        {
        //            login = credential.login,
        //            password = credential.password
        //        };
        //        return Ok();
        //    }
        //    return Unauthorized();
        //}
    }
}
