using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.models;
using EmployeeManagement.Web.Services;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeList : ComponentBase
    {
        public List<Employee> employees= new List<Employee>();

        [Inject]
        private IEmployees emp { get; set; }

        public bool ShowFooter { get; set; } = true;
        public int count { get; set; } = 0;

      
        protected override async Task OnInitializedAsync()
        {
            try
            {
                employees= (await emp.GetEmployees()).ToList();
            }
            catch (Exception ex)
            {

            }

        }
       protected void OnEmployeeSelection(bool isSelected)
        {
            if(isSelected)
            {
                count++;
            }
            else
            {
                count--;
            }
        }



}
}
