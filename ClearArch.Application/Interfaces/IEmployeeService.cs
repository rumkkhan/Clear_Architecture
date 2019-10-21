using ClearArch.Application.ViewModals;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Application.Interfaces
{
    public interface IEmployeeService
    {
        EmployeeViewModal GetEmployees();

        void Create(EmployeeViewModal employeeViewModal);
    }
}
