using CodeFirstCore6.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFirstCore6.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly EmployeeDBContext _employeeDB;
        public HomeController(EmployeeDBContext employeeDB)
        {
            this._employeeDB = employeeDB;
        }
        public IActionResult Index()
        {
            var empData = _employeeDB.Employees.ToList();
            return View(empData);
        }
        public IActionResult Details(int id)
        {
            var empData = _employeeDB.Employees.Where(a => a.Id == id).FirstOrDefault();
            return View(empData);
        }
        public IActionResult Edit(int id)
        {
            var empData = _employeeDB.Employees.Where(a => a.Id == id).FirstOrDefault();
            return View(empData);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeDB.Employees.Update(employee);
                _employeeDB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _employeeDB.Employees.Add(employee);
                _employeeDB.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            var empData = _employeeDB.Employees.Where(a => a.Id == id).FirstOrDefault();
            if (empData != null)
            {
                _employeeDB.Employees.Remove(empData);
                _employeeDB.SaveChanges();  
            }
            return RedirectToAction("Index");
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
