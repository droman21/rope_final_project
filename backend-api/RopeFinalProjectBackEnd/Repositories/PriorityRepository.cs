//using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Contexts;

namespace RopeFinalProjectBackEnd.Repositories
{
    public class PriorityRepository : Repository<Priority>, IRepository<Priority>
    {
        public PriorityRepository(ReleaseTasksAPIContext context) : base(context)
        {
        }
    }
}
