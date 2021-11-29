using EmployeeManagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public interface IEmployeRepository
    {
        Task<List<Employee>> GetEmployees();
        Task<IEnumerable<Employee>> Search(string name, Gender? gender);
        Task<Employee> GetEmployee(int id);
        //Task<Employee> GetEmployeeByEmail(string email);
        Task<Employee> AddEmployee(Employee employee);
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> DeleteEmployee(int id);

    }
}
