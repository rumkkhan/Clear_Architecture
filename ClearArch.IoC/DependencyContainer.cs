using CleanArch.Domain.Core.Bus;
using CleanArch.Infra.Bus;
using ClearArch.Application.Interfaces;
using ClearArch.Application.Services;
using ClearArch.Domain.commandHandlers;
using ClearArch.Domain.commands;
using ClearArch.Domain.Interfaces;
using ClearArch.Infra.Data;
using ClearArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

using System;

namespace ClearArch.IoC
{
    public class DependencyContainer
    {
            public static void RegisterServices(IServiceCollection services)
            {
                //Domain InMemoryBus MediatR
                services.AddScoped<IMediatorHandler, InMemoryBus>();

               //Domain Handlers

                services.AddScoped<IRequestHandler<CreateEmployeeCommand, bool>, EmployeeCommandHandler>();
                      
                //Application Layer
                services.AddScoped<IEmployeeService, EmployeeService>();

                //Infra.Data Layer
                services.AddScoped<IEmployeeRepository, EmployeeRepository>();

                services.AddScoped<EmployeeDBContext>();

            }
    }
}
