using AzureAz204ExamAzureWebApp.Model;
using AzureAz204ExamAzureWebApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace AzureAz204ExamAzureWebApp.Controller
{
    public class EmployeeController : ControllerBase
    {
        public readonly EmployeeService _employeeService;
       public EmployeeController(EmployeeService _employeeService) { 
        this._employeeService = _employeeService;
        }

        public IActionResult Index()
        {
            //IEnumerable<Employee> employee = _employeeService.GetEmployee();

            // return View(employee);
            return null;
        }
    }
}
