using EmployeeManagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class Employees : IEmployees
    {
        private readonly HttpClient _httpclient;
        public Employees(HttpClient httpClient)
        {
            _httpclient = httpClient;
        }
        public List<Employee> lstEmployees { get; set; } = new List<Employee>();
        public void DeleteEmployee(int id)
        {
           
        }

        public Task<Department> GetDepartment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Department>> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public async  Task<Employee> GetEmployee(int id)
        {
          return await _httpclient.GetFromJsonAsync<Employee>("api/Employee/"+id);
        }

        public async Task<List<Employee>> GetEmployees()
        {
            lstEmployees = await _httpclient.GetFromJsonAsync<List<Employee>>("api/Employee");
            return lstEmployees;
        }

        public Task<Employee> UpdateEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
