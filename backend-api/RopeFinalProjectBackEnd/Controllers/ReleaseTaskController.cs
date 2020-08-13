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
        [HttpGet("{id}", Name = "GetReleaseTask")]
        public ReleaseTask Get(int id)
        {
            return releaseTasksRepo.GetById(id);
        }

        // POST: api/ReleaseTask
        [HttpPost]
        public int Post([FromBody] ReleaseTask value)
        {
            releaseTasksRepo.Create(value);
            return value.ID;
        }

        // PUT: api/ReleaseTask/5
        [HttpPut("{id}")]
        public IEnumerable<ReleaseTask> Put(int id, [FromBody] ReleaseTask value)
        {
            releaseTasksRepo.Update(value);
            return releaseTasksRepo.GetAll();
        }

        //PATCH: api/ReleaseTask/5
        [HttpPatch("{id}")]
        public IEnumerable<ReleaseTask> Patch(int id, [FromBody] ReleaseTask value)
        {
            releaseTasksRepo.UpdateFields(value);
            return releaseTasksRepo.GetAll();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IEnumerable<ReleaseTask> Delete(int id)
        {
            var releaseTask = releaseTasksRepo.GetById(id);
            releaseTasksRepo.Delete(releaseTask);
            return releaseTasksRepo.GetAll();
        }
    }
}
