using Microsoft.AspNetCore.Mvc;
using MyChat.Models;
using System.Diagnostics;
using BLL.Interfaces;

namespace MyChat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IUserService _user;

        public HomeController(ILogger<HomeController> logger, IUserService user)
        {
            _logger = logger;
            _user = user;
        }

        public IActionResult Index()
        {
            var test = _user.GetAll().ToList();
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