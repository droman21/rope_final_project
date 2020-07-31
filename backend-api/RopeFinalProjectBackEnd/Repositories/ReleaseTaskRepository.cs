//using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Contexts;
using Microsoft.EntityFrameworkCore;

namespace RopeFinalProjectBackEnd.Repositories
{
    public class ReleaseTaskRepository : Repository<ReleaseTask>, IRepository<ReleaseTask>
    {
        ReleaseTasksAPIContext db;

        public ReleaseTaskRepository(ReleaseTasksAPIContext context) : base(context)
        {
            db = context;
        }

        public override ReleaseTask GetById(int id)
        {
            var someReleaseTask = db.ReleaseTasks.Where(o => o.ID == id)
                .Include("Status")
                .Include("Priority")
                .Include("Comments")
                .Include("Employee").FirstOrDefault();
            return someReleaseTask;
        }

    }
}
