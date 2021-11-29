using EmployeeManagement.models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsBase : ComponentBase
    {
        public Employee employee = new Employee();
        [Inject]
        private IEmployees Iemployees { get; set; }
        [Parameter]
        public string Id { get; set; }
        protected string coordinates { get; set; }
        protected override async Task OnInitializedAsync()
        {
           employee=await Iemployees.GetEmployee(int.Parse(Id));
        }
        protected void Mouse_Move(MouseEventArgs e)
        {
            coordinates = $"X = {e.ClientX} Y = {e.ClientY}";
        }

    }
}
