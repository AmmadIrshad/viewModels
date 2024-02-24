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
                new Student {Id=2,Name="hashir",Gender="malee",Standard=11},
                new Student {Id=3,Name="farhan",Gender="malee",Standard=12}
            };
            List<Teacher> teacher = new List<Teacher>
            {
                new Teacher {Id=1,Name="sir Ammad",Qualification="masters",salary=100},
                new Teacher {Id=3,Name="sir hashir",Qualification="masterss",salary=1000},
                new Teacher {Id=3,Name="sir farhan",Qualification="masterssss",salary=10000}
            };

            SchoolViewModel svm = new SchoolViewModel()
            { 
                MyStudents = students,
                MyTeachers = teacher,
            };
            return View(svm);
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
