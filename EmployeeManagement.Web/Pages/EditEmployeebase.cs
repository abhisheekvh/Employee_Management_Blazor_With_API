using EmployeeManagement.models;
using EmployeeManagement.Web.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Validation.Component;



namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeebase :ComponentBase
    {
        [Inject]
        public IEmployees emp { get; set; }
        public Employee employee = new Employee();

        public EditEmployeeModel editEmployeeModel { get; set; } = new EditEmployeeModel(); 



        [Parameter]
        public string id { get; set; }

        [Inject]
        public IDepartment Department { get; set; }

        public List<Department> lstDepartment { get; set; } = new List<Department>();
        
        public string departmentId { get; set; }
        protected async override Task OnInitializedAsync()
        {
            employee = await emp.GetEmployee(int.Parse(id));
            lstDepartment = (await Department.GetDepartments()).ToList();
            departmentId = employee.DepartmentId.ToString();

            editEmployeeModel.FirstName = employee.FirstName;
            editEmployeeModel.LastName = employee.LastName;
            editEmployeeModel.Email = employee.Email;
            editEmployeeModel.ConfirmEmail = employee.Email;
            editEmployeeModel.DateOfBirth = employee.DateOfBirth;
            editEmployeeModel.Gender = employee.Gender;
            editEmployeeModel.PhotoPath = employee.PhotoPath;
        }

        protected  void HandleValidSubmit()
        {

        }

    }
}
