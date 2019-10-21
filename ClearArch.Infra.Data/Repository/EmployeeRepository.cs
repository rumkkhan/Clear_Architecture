using ClearArch.Domain;
using ClearArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClearArch.Infra.Data.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDBContext _etx;

        public EmployeeRepository(EmployeeDBContext etx)
        {
            _etx = etx;
        }
        public IEnumerable<Employee> GetEmployees()
        {
           return  _etx.Employees;
        }
    }
}
