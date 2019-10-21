using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClearArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch_UI_API.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
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
        public void Post([FromBody]string value)
        {
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
