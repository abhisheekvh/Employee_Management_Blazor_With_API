using EmployeeManagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public interface IEmployees
    {
        Task<List<Employee>> GetEmployees();
        List<Employee> lstEmployees { get; set; }
        Task<Employee> GetEmployee(int id);
        Task<Employee> UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        Task<List<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
    }
}
