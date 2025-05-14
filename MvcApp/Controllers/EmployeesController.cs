using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
using MvcApp.Bl;




namespace MvcApp.Controllers
{
    public class EmployeesController : Controller
    {
        ClsEmployee employeeService = new ClsEmployee();
        public IActionResult Create()
        {
            return View();
        }


       
        public IActionResult List()
        {

            var employees= employeeService.GetData();
            return View(employees);
        }
        public IActionResult Details(int id,string name)
        {
          var employees= employeeService.GetData();
            ViewBag.id = id;
            var myEmployee = employees.Where(a => a.Id == id).FirstOrDefault();
            return View(myEmployee);
        }


    }
}
