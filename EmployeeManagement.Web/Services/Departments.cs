using EmployeeManagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public class Departments : IDepartment
    {
        private readonly HttpClient client;
        public Departments(HttpClient httpClient)
        {
            client = httpClient;
        }
        public async Task<Department> GetDepartment(int id)
        {
            return await client.GetFromJsonAsync<Department>("api/Departments/"+id);
        }

        public async Task<List<Department>> GetDepartments()
        {
            return await client.GetFromJsonAsync<List<Department>>("api/Departments");
        }
    }
}
