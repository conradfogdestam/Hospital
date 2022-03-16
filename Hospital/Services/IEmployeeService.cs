using Hospital.Models;
namespace Hospital.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployeeList();

        List<Employee> AddEmployee(Employee newEmployee);

        List<Employee> UpdateEmployee(Employee updateEmployee);

        List<Employee> DeleteEmployee(Employee employeeToDelete);
    }
}
