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
    public class StatusController : ControllerBase
    {
        private IRepository<Status> statusRepo;

        public StatusController(IRepository<Status> otherRepo)
        {
            this.statusRepo = otherRepo;
        }

        // GET: api/Status
        [HttpGet]
        public IEnumerable<Status> Get()
        {
            return this.statusRepo.GetAll();
        }

        // GET: api/Status/5
        [HttpGet("{id}", Name = "GetStatus")]
        public Status Get(int id)
        {
            return statusRepo.GetById(id);
        }

        // POST: api/Status
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Status/5
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
