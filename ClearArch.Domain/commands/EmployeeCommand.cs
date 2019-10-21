using CleanArch.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Domain.commands
{
    public class EmployeeCommand : Command
    {
        public string FirstName { get; protected set; }
        public string LastName { get; protected set; }
        public string Designation { get; protected set; }


    }
}
