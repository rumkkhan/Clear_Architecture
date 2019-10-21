using ClearArch.Domain;
using Microsoft.EntityFrameworkCore;
using System;

namespace ClearArch.Infra.Data
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>()
                   .HasData(
                       new Employee { Id = 1, FirstName = "Ramzan", LastName = "Khan", Designation = "Software" },
                       new Employee { Id = 2, FirstName = "Tariq", LastName = "Khan", Designation = "Doctor" },
                       new Employee { Id = 3, FirstName = "javid", LastName = "Khan", Designation = "Teacher" },
                       new Employee { Id = 4, FirstName = "Anaytullah", LastName = "Khan", Designation = "Driver" }


                   );
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
