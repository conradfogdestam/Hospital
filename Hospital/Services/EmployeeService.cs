using Hospital.Models;
using System.Collections.Generic;
using System.Linq;
namespace Hospital.Services
{
    public class EmployeeService : IEmployeeService
    {
        private static List<Employee> EmployeeList = new List<Employee>()
        {
            new Employee() { EmployeeId = 1, Name = "sss", Age = 112, positionOfEmployee = EmployeePosition.Doctor},
            new Employee() { EmployeeId = 2, Name = "ddd", Age = 69, positionOfEmployee = EmployeePosition.Nurse}
        };

        public List<Employee> GetEmployeeList()
        {
            return EmployeeList;
        }
        public List<Employee> AddEmployee(Employee newEmployee)
        {
            EmployeeList.Add(newEmployee);
            return EmployeeList;
        }
        public List<Employee> UpdateEmployee(Employee updateEmployee)
        {
            var foundEmployee = EmployeeList.FirstOrDefault(Employee => Employee.EmployeeId == updateEmployee.EmployeeId );

            if (foundEmployee != null)
            {
                foundEmployee.Name = updateEmployee.Name;
                foundEmployee.Age = updateEmployee.Age;
            }
            return EmployeeList;
        }

        public List<Employee> DeleteEmployee(Employee employeeToDelete)
        {
            var foundStudent = EmployeeList.FirstOrDefault(Employee => Employee.EmployeeId == employeeToDelete.EmployeeId);
            if (foundStudent != null)
            {
                EmployeeList.Remove(foundStudent);
            }
            return EmployeeList;
        }

    }
}
