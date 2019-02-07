using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DITemplate.Serivces.Interfaces;

namespace DITemplate.Controllers
{
    [RoutePrefix("api/employee")]
    public class EmployeeController : ApiController
    {
        private IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        [HttpGet]
        public IHttpActionResult GetAllEmployees()
        {
            return this.Ok(employeeService.GetAllEmployee());
        }
    }
}
