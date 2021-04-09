﻿using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        private IEnumerable<Employee> employees;

        public IEnumerable<Employee> GetEmployees()
        {
            return employees;
        }

        public void SetEmployees(IEnumerable<Employee> value)
        {
            employees = value;
        }

        protected int SelectedEmployeesCount { get; set; } = 0;

        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
            {
                SelectedEmployeesCount++;
            }
            else
            {
                SelectedEmployeesCount--;
            }
        }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Hastings",
                Email = "David@pragimtech.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                DepartmentId = 1,
                PhotoPath = "images/john.png"
            };

            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Sam",
                LastName = "Galloway",
                Email = "Sam@pragimtech.com",
                DateOfBirth = new DateTime(1981, 12, 22),
                Gender = Gender.Male,
                DepartmentId = 2, 
                PhotoPath = "images/sam.jpg"
            };

            Employee e3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Mary",
                LastName = "Smith",
                Email = "mary@pragimtech.com",
                DateOfBirth = new DateTime(1979, 11, 11),
                Gender = Gender.Female,
                DepartmentId = 1,
                PhotoPath = "images/mary.png"
            };

            Employee e4 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Sara",
                LastName = "Longway",
                Email = "sara@pragimtech.com",
                DateOfBirth = new DateTime(1982, 9, 23),
                Gender = Gender.Female,
                DepartmentId = 3,
                PhotoPath = "images/sara.png"
            };

            SetEmployees(new List<Employee> { e1, e2, e3, e4 });
        }
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }
        public bool ShowFooter { get; set; } = true;

        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        private void ToList()
        {
            throw new NotImplementedException();
        }
        protected async Task EmployeeDeleted()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }
    }
}
    

