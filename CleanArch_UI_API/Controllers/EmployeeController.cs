using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Domain.Core.Bus;
using ClearArch.Application.Interfaces;
using ClearArch.Application.ViewModals;
using ClearArch.Domain.commands;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch_UI_API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        private IMediatorHandler _bus;
        public EmployeeController(IEmployeeService employeeService, IMediatorHandler bus)
        {
            _employeeService = employeeService;
            _bus = bus;
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            var employee = _employeeService.GetEmployees();
            return Ok(employee);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]EmployeeViewModal employeeViewModal)
        {

            _employeeService.Create(employeeViewModal);
            return Ok(employeeViewModal);
            //var createEmployeeCommand = new CreateEmployeeCommand(
            //                employeeViewModal.FirstName,
            //                employeeViewModal.LastName,
            //                employeeViewModal.Designation
            //    ) ;
            //_bus.SendCommand(createEmployeeCommand);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
