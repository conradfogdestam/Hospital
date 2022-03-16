using Hospital.Models;
using Hospital.Services;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {

            return Ok(_employeeService.GetEmployeeList());
        }
        [HttpPost]
        public ActionResult<List<Employee>> AddEmployee(Employee newEmployee)
        {

            return Ok(_employeeService.AddEmployee(newEmployee));
        }
        [HttpPut]
        public ActionResult<List<Employee>> UpdateEmployee(Employee updateEmployee)
        {
            return Ok (_employeeService.UpdateEmployee(updateEmployee));
        }
        [HttpDelete]
        public ActionResult<List<Employee>> DeleteEmployee(Employee EmployeeToDelete)
        {
            return Ok(_employeeService.DeleteEmployee(EmployeeToDelete));
        }
    };
}