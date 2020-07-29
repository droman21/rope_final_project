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


    public class PriorityController : ControllerBase
    {
        private IRepository<Priority> priorityRepo;

        public PriorityController(IRepository<Priority> otherRepo)
        {
            this.priorityRepo = otherRepo;
        }
        // GET: api/Priority
        [HttpGet]
        public IEnumerable<Priority> Get()
        {
            return this.priorityRepo.GetAll();
        }

        // GET: api/Priority/5
        [HttpGet("{id}", Name = "GetPriority")]
        public Priority Get(int id)
        {
            return priorityRepo.GetById(id);
        }

        // POST: api/Priority
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Priority/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
