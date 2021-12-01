using EmployeeManagement.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Services
{
    public interface IDepartment
    {
        Task<List<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
    }
}
