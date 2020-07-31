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
            var StatusName = db.ReleaseTasks.Where(o => o.ID == id).Include("Status").FirstOrDefault();
            var PriorityName = db.ReleaseTasks.Where(o => o.ID == id).Include("Priority").FirstOrDefault();
            var EmployeeName = db.ReleaseTasks.Where(o => o.ID == id).Include("Employee").FirstOrDefault();
            return StatusName;
        }

    }
}
