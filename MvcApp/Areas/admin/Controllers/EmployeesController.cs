using Microsoft.AspNetCore.Mvc;
using MvcApp.Bl;
using MvcApp.Models;

namespace MvcApp.Areas.admin.Controllers
{
    [Area("admin")]
    public class EmployeesController : Controller
    {
      
        

        public IActionResult List()
        {
            ClsEmployee employeeService = new ClsEmployee();
            
            return View(employeeService.GetData());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save(EmployeeModel employee)
        {
            return View("Add",employee);
        }
    }
}
