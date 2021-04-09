using System;

namespace EmployeeManagement.Web.Models
{
    internal class ComparePropertyAttribute : Attribute
    {
        private string v;
        private string errorMessage;

        public ComparePropertyAttribute(string v, string ErrorMessage)
        {
            this.v = v;
            errorMessage = ErrorMessage;
        }
    }
}