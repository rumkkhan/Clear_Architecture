using CleanArch.Domain.Core.Bus;
using ClearArch.Application.Interfaces;
using ClearArch.Application.ViewModals;
using ClearArch.Domain.commands;
using ClearArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        private readonly IMediatorHandler _bus;

        public EmployeeService (IEmployeeRepository employeeRepository, IMediatorHandler bus)
        {
            _employeeRepository = employeeRepository;
            _bus = bus;
        }

        public void Create(EmployeeViewModal employeeViewModal)
        {
            var createEmployeeCommand = new CreateEmployeeCommand(
                    employeeViewModal.FirstName,
                    employeeViewModal.LastName,
                    employeeViewModal.Designation

                ) ;
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
