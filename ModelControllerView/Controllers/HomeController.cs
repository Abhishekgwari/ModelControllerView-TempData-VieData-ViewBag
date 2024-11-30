using Microsoft.AspNetCore.Mvc;
using ModelControllerView.Models;
using System.Diagnostics;

namespace ModelControllerView.Controllers
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

            //Employee emp = new Employee()             // constructor or we can say object
            //{
            //    EmpId = 101,
            //    EmpName = "Abhishek",
            //    Designation = "Manager",
            //    Salary = 25000

            //};

            //   ViewData["myEmployee"] = emp;
            //  ViewBag.myEmployee = emp;
            //TempData["myEmployee"] = emp;

            var myEmployees = new List<Employee>       // List
            {
                new Employee { EmpId = 101, EmpName= "Abhishek", Designation= "Developer", Salary= 45000 },
                new Employee { EmpId = 101, EmpName= "Aman", Designation= "Manager", Salary= 55000 },
                new Employee { EmpId = 101, EmpName= "Lokesh", Designation= "Team Lead", Salary= 65000 },
                new Employee { EmpId = 101, EmpName= "Neha", Designation= "Accontant", Salary= 75000 },

            };

            //  ViewData["myEmployee"] = myEmployees;
            //  ViewBag.myEmployee = myEmployees;
            TempData["myEmployee"] = myEmployees;


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
