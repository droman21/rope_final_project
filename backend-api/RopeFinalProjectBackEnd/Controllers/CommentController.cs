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
    public class CommentController : ControllerBase
    {
        private IRepository<Comment> commentRepo;

        public CommentController(IRepository<Comment> otherRepo)
        {
            this.commentRepo = otherRepo;
        }

        // GET: api/Comment
        [HttpGet]
        public IEnumerable<Comment> Get()
        {
            return commentRepo.GetAll();
        }

        // GET: api/Comment/5
        [HttpGet("{id}", Name = "GetComment")]
        public Comment Get(int id)
        {
            return commentRepo.GetById(id);
        }

        // POST: api/Comment
        [HttpPost]
        public IEnumerable<Comment> Post([FromBody] Comment value)
        {
            commentRepo.Create(value);
            return commentRepo.GetAll();
        }

        // PUT: api/Comment/5
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
