using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Domain.commands
{
    public class CreateEmployeeCommand : EmployeeCommand
    {
        public CreateEmployeeCommand(string fn, string ln, string d)
        {
            FirstName = fn;
            LastName = ln;
            Designation = d;
        }
    }
}
