using CharacterSorterSite.Data;
using CharacterSorterSite.Models;
using CharacterSorterSite.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CharacterSorterSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly CharacterContext _context;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CharacterContext context)
        {
            _logger = logger;
            _context = context;
        }

        public  IActionResult Index()
        {
            return View();
        }

        



        public IActionResult MyAction()
        {
            string message = "Hello, World!"; // Set view data

            // Set the value of a session variable named "Message"
            HttpContext.Session.SetString("Message", message);

            // Redirect to the "Home" action method
            return View();
        }

        public IActionResult Home()
        {
            string message = HttpContext.Session.GetString("Message"); // Get view data from the session variable

            Franchise franchise = new Franchise();
            string json = JsonConvert.SerializeObject(franchise);

            HttpContext.Session.SetString("franchise", json);

            ViewData["Message"] = message;



            // Remove the session variable to prevent it from being used again
            HttpContext.Session.Remove("Message");

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
    }
}