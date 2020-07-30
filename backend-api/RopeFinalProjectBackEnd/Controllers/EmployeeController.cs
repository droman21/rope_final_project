using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Repositories;

namespace RopeFinalProjectBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IRepository<Employee> employeeRepo;

        public EmployeeController(IRepository<Employee> otherRepo)
        {
            this.employeeRepo = otherRepo;
        }

        // GET: api/Employee
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return this.employeeRepo.GetAll();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "GetEmployee")]
        public Employee Get(int id)
        {
            return employeeRepo.GetById(id);
        }

        // POST: api/Employee
        [HttpPost]
        public IEnumerable<Employee> Post([FromBody] Employee value)
        {
           employeeRepo.Create(value);
            return employeeRepo.GetAll();
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        public IEnumerable<Employee> Put(int id, [FromBody] Employee value)
        {
            employeeRepo.Update(value);
            return employeeRepo.GetAll();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<Employee> Delete(int id)
        {
            var releaseTask = employeeRepo.GetById(id);
            employeeRepo.Delete(releaseTask);
            return employeeRepo.GetAll();
        }
    }
}
