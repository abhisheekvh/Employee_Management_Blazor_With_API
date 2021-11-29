using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Api.Models;
using EmployeeManagement.models;

namespace EmployeeManagement.Api.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeRepository employeRepository;
        public EmployeeController(IEmployeRepository employeRepository)
        {
            this.employeRepository = employeRepository;

        }

        [HttpGet("{search}/{name}/{gender}")]
        public async Task<ActionResult<Employee>> Search(string name, Gender? gender)
        {
            try
            {
               var result= await employeRepository.Search(name, gender);
               if(result.Any())
               {
                    return Ok(result);
               }
                return NotFound();

            }catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetEmployees()
        {
           // List<Employee> lstEmployee = new List<Employee>();
            return Ok(await employeRepository.GetEmployees());
            
        }
        [HttpGet("{id:int}")]
       
        public async Task<ActionResult> GetEmployee(int id)
        {
            
           var employee = await employeRepository.GetEmployee(id);
            if (employee != null)
                return Ok(employee);
            return StatusCode(StatusCodes.Status404NotFound, "Not Found");
        }
        [HttpPost]
        public async Task<ActionResult<Employee>> CreateEmployee(Employee employee)
        {
            try
            {
                if(employee==null)
                {
                    return BadRequest();
                }
                //var emp = employeRepository.GetEmployeeByEmail(employee.Email);
                //if (emp != null)
                //{
                //    ModelState.AddModelError("email", "Employee email already in use");
                //    return BadRequest(ModelState);
                    
                //}
                var createEmployee = await employeRepository.AddEmployee(employee);
                return CreatedAtAction(nameof(GetEmployee), new { id = createEmployee.EmployeeId }, createEmployee);

            }
            catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id,Employee employee)
        {
            try
            {
                if(id!=employee.EmployeeId)
                {
                    return BadRequest("Employee Id mismatch");
                }
                var emp = await employeRepository.GetEmployee(id);
                if(emp!=null)
                {
                    return await employeRepository.UpdateEmployee(employee);
                }
                return NotFound("Employee not found");

            }catch(Exception ex)
            {
                return BadRequest();
            }

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            try
            {
                var empdlt = await employeRepository.GetEmployee(id);
                if(empdlt==null)
                {
                    return NotFound("Employee Not found");
                }
                return await employeRepository.DeleteEmployee(id);
                
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        
    }
}
