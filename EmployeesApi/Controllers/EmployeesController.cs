using EmployeesApi.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApi.Controllers
{
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeesDataContext _context;

        public EmployeesController(EmployeesDataContext context)
        {
            _context = context;
        }

        [HttpGet("employees")]
        public ActionResult GetAllEmployees()
        {
            var employees = _context.Employees
                .Where(e => e.IsActive)
                .ToList();
            return Ok(employees);
        }
    }
}
