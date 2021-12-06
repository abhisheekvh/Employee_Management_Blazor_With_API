using EmployeeManagement.models;
using EmployeeManagement.models.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Models
{
    public class EditEmployeeModel
    {
        public int EmployeeId { get; set; }
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailDomainValidation(domainName = "vh.com")]
        public string Email { get; set; }

        [CompareProperty("Email",ErrorMessage ="Email and Confirm Email should be same")]
        public string ConfirmEmail { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int DepartmentId { get; set; }
        public Gender Gender { get; set; }
        public string PhotoPath { get; set; }

        [ValidateComplexType]
        public Department Department { get; set; } = new Department();
    }
}
