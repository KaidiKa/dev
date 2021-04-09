using System;

namespace EmployeeManagement.Web.Models
{
    internal class EmailDomainValidatorAttribute : Attribute
    {
        public string AllowedDomain { get; set; }
        public string ErrorMessage { get; set; }
    }
}