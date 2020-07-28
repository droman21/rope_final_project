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
    public class ReleaseTaskController : ControllerBase
    {
        private IRepository<ReleaseTask> releaseTasksRepo;

        public ReleaseTaskController(IRepository<ReleaseTask> otherRepo)
        {
            this.releaseTasksRepo = otherRepo;
        }

        // GET: api/ReleaseTask
        [HttpGet]
        public IEnumerable<ReleaseTask> Get()
        {
            return this.releaseTasksRepo.GetAll();
        }

        // GET: api/ReleaseTask/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ReleaseTask
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ReleaseTask/5
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
