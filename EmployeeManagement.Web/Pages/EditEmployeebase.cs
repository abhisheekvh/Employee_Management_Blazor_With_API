using EmployeeManagement.models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EditEmployeebase :ComponentBase
    {
        [Inject]
        public IEmployees emp { get; set; }
        public Employee employee = new Employee();

        [Parameter]
        public string id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            employee = await emp.GetEmployee(int.Parse(id));
        }
    }
}
