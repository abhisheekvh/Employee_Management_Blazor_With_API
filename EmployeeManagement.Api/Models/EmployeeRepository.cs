using EmployeeManagement.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Models
{
    public class EmployeeRepository : IEmployeRepository
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await _appDbContext.employees.AddAsync(employee);
            await _appDbContext.SaveChangesAsync();
            return result.Entity;

        }

        public async Task<Employee> DeleteEmployee(int id)
        {
            var result = await _appDbContext.employees.FirstOrDefaultAsync(x => x.EmployeeId == id);
            if(result!=null)
            {
                _appDbContext.employees.Remove(result);
                 await _appDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await _appDbContext.employees
                .Include(e=>e.Department)
                .FirstOrDefaultAsync(x=>x.EmployeeId==id);
            return employee;
        }

        //public async Task<Employee> GetEmployeeByEmail(string email)
        //{
        //    try
        //    {
        //        return await _appDbContext.employees.FirstOrDefaultAsync(e => e.Email == email);
        //    }catch (Exception ex)
        //    {
        //        return null;
        //    }
           

        //}

        public async Task<List<Employee>> GetEmployees()
        {
            return await _appDbContext.employees.ToListAsync();
        }

        public async Task<IEnumerable<Employee>> Search(string name, Gender? gender)
        {
            IQueryable<Employee> query = _appDbContext.employees;
            if(!string.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.FirstName.Contains(name) || e.LastName.Contains(name));
            }
            if(gender!=null)
            {
                query = query.Where(e => e.Gender == gender);
            }
            return await query.ToListAsync();
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var employeeUpdate = await _appDbContext.employees.FirstOrDefaultAsync(x => x.EmployeeId == employee.EmployeeId);
            if(employeeUpdate!=null)
            {
                employeeUpdate.FirstName = employee.FirstName;
                employeeUpdate.LastName = employee.LastName;
                employeeUpdate.Email = employee.Email;
                employeeUpdate.DateOfBirth = employee.DateOfBirth;
                employeeUpdate.Gender = employee.Gender;
                employeeUpdate.DepartmentId = employee.DepartmentId;
                employeeUpdate.PhotoPath = employee.PhotoPath;
                await _appDbContext.SaveChangesAsync();
                return employeeUpdate;
            }
            return null;
        }
        
    }
}
