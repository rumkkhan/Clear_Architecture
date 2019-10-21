using ClearArch.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Application.ViewModals
{
    public class EmployeeViewModal
    {
        public IEnumerable<Employee> Employees { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
    }
}
