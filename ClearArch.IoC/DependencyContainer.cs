using ClearArch.Application.Interfaces;
using ClearArch.Application.Services;
using ClearArch.Domain.Interfaces;
using ClearArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

using System;

namespace ClearArch.IoC
{
    public class DependencyContainer
    {
            public static void RegisterServices(IServiceCollection services)
            {
            //Application Layer
            services.AddScoped<IEmployeeService, EmployeeService>();

            //Infra.Data Layer
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            }
    }
}
