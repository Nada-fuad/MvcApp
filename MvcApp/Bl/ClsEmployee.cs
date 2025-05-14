
using MvcApp.Models;
namespace MvcApp.Bl
{
    public class ClsEmployee
    {

        public List<EmployeeModel> GetData()
        {

            var employees = new List<EmployeeModel>();
            EmployeeModel employee = new EmployeeModel();
            employee.Id = 1;
            employee.Name = "Fuad";
            employee.Email = "aaa@gmail.com";
            employee.Title = "IT";
            employee.Department = "1";
            employee.Description = "my work is very hard";
            employee.ImageUrl = "mm";
            employees.Add(employee);
            employee = new EmployeeModel();
            employee.Id = 2;
            employee.Name = "Alex";
            employee.Email = "aaa@gmail.com";

            employee.Title = "Doctor";
            employee.Description = "my work is very hard";
            employee.Department = "1";

            employee.ImageUrl = "mm";
            employees.Add(employee);

            employee = new EmployeeModel();
            employee.Id = 3;
            employee.Name = "Ali";
            employee.Email = "aaa@gmail.com";
            employee.Department = "1";

            employee.Title = "Nerse";
            employee.Description = "my work is very hard";
            employee.ImageUrl = "mm";
            employees.Add(employee);
            return employees;
       
    }

        public EmployeeModel Find(int id)
        {
            return new EmployeeModel();
        }

    }
   
}
