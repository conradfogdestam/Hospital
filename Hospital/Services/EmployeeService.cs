using Hospital.Models;
using System.Collections.Generic;
using System.Linq;
namespace Hospital.Services
{
    public class EmployeeService : IEmployeeService
    {
        public readonly DataContext ConmanDb;
        public EmployeeService(DataContext connysaurusdb) 
        { 
            ConmanDb = connysaurusdb;
        }
        public List<Employee> GetEmployeeList()
        {
            return ConmanDb.Employees.ToList();
        }
        public List<Employee> AddEmployee(Employee newEmployee)
        {
            ConmanDb.Employees.Add(newEmployee);
            ConmanDb.SaveChanges();
            return ConmanDb.Employees.ToList();
        }
        public List<Employee> UpdateEmployee(Employee updateEmployee)
        {
            var foundEmployee = ConmanDb.Employees.FirstOrDefault(x => x.EmployeeId == updateEmployee.EmployeeId);

            if (foundEmployee is not null)
            {
                foundEmployee.Name = updateEmployee.Name;
                foundEmployee.Age = updateEmployee.Age;
                ConmanDb.SaveChanges();
            }
            return ConmanDb.Employees.ToList();
        }

        public List<Employee> DeleteEmployee(int Id)
        {
            var foundStudent = ConmanDb.Employees.FirstOrDefault(x => x.EmployeeId == Id);
            if (foundStudent is not null)
            {
                ConmanDb.Employees.Remove(foundStudent);
                ConmanDb.SaveChanges();
            }
            return ConmanDb.Employees.ToList();
        }

    }
}
