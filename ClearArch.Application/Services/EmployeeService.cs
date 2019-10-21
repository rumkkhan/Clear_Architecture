using ClearArch.Application.Interfaces;
using ClearArch.Application.ViewModals;
using ClearArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeService (IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;              
        }
        public EmployeeViewModal GetEmployees()
        {
            return new EmployeeViewModal()
            {
                Employees = _employeeRepository.GetEmployees()
            };
        }
    }
}
