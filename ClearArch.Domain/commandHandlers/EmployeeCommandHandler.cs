using ClearArch.Domain.commands;
using ClearArch.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClearArch.Domain.commandHandlers
{
   public class EmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, bool>
    {
        private readonly IEmployeeRepository _employeeRepsoitory;

        public EmployeeCommandHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepsoitory = employeeRepository;
        }
        public Task<bool> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee()
            {
                FirstName = request.FirstName,
                LastName  = request.LastName,
                Designation = request.Designation
            };

            _employeeRepsoitory.Add(employee);
            return Task.FromResult(true);
        }
    }
}
