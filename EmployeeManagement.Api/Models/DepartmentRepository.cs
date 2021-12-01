using EmployeeManagement.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Department> GetDepartment(int id)
        {
            return await _appDbContext.departments.FirstOrDefaultAsync(x => x.DepartmentId == id);
            
        }

        public async Task<List<Department>> GetDepartments()
        {
            var deps= await _appDbContext.departments.ToListAsync();
            return deps;
        }

    }
}
