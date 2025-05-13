using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;


namespace MvcApp.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        List<EmployeeModel> employees;

        public IActionResult List()
        {
            employees = new List<EmployeeModel>();
            EmployeeModel employee = new EmployeeModel();
            employee.Id = 1;
            employee.Name = "Fuad";
            employee.Title = "IT";
            employee.Description = "my work is very hard";
            employee.ImageUrl = "mm";
            employees.Add(employee);
            employee = new EmployeeModel();
            employee.Id = 2;
            employee.Name = "Alex";
            employee.Title = "Doctor";
            employee.Description = "my work is very hard";
            employee.ImageUrl = "mm";
            employees.Add(employee);

            employee = new EmployeeModel();
            employee.Id = 2;
            employee.Name = "Ali";
            employee.Title = "Nerse";
            employee.Description = "my work is very hard";
            employee.ImageUrl = "mm";
            employees.Add(employee);

            return View(employees);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
