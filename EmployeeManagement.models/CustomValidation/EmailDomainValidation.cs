using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.models.CustomValidation
{
    public class EmailDomainValidation :ValidationAttribute
    {
        public string domainName { get; set; }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] email = value.ToString().Split('@');
            if(email[1]==domainName)
            {
                return null;
            }
            return new ValidationResult($"Domain must be {domainName}", new[] { validationContext.MemberName });
        }
    }
}
