using Microsoft.AspNetCore.Mvc;
using PracticWebSIte.Models;
using System.Diagnostics;

namespace PracticWebSIte.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
    }
}
