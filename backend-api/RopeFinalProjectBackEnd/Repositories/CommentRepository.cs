using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RopeFinalProjectBackEnd.Contexts;
using RopeFinalProjectBackEnd.Models;

namespace RopeFinalProjectBackEnd.Repositories
{
    public class CommentRepository : Repository<Comment>, IRepository<Comment>
    {
        public CommentRepository(ReleaseTasksAPIContext context) : base(context)
        {
        }
    }
}
