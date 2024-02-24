using buildMultipleModelsWithSingleView.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace buildMultipleModelsWithSingleView.Controllers
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
            List<Student> students = new List<Student>
            {
                new Student {Id=1,Name="Ammad",Gender="male",Standard=10},
                new Student {Id=1,Name="hashir",Gender="male",Standard=10},
                new Student {Id=1,Name="farhan",Gender="male",Standard=10}
            };

            return View(students);
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
