//using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace RopeFinalProjectBackEnd.Repositories
{
    public class ReleaseTaskRepository : Repository<ReleaseTask>, IRepository<ReleaseTask>
    {
        ReleaseTasksAPIContext db;

        public ReleaseTaskRepository(ReleaseTasksAPIContext context) : base(context)
        {
            db = context;
        }

        public override void UpdateFields(ReleaseTask entity)
        {
            using (var db = new ReleaseTasksAPIContext())
            {
                db.ReleaseTasks.Attach(entity);
                db.Entry(entity).Property(e => e.IsVisisble).IsModified = true;
                db.SaveChanges();
            }
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

        public override IEnumerable<ReleaseTask> GetAll()
        {
            var releaseTasks = db.ReleaseTasks
            .Include(rt => rt.Status).Where(s => s.CurrentStatusID == s.Status.ID)
            .Include(rt => rt.Priority).Where(p => p.CurrentPriorityID == p.Priority.ID)
            .Include(rt => rt.Employee).Where(e => e.AssignedEmployeeID == e.Employee.ID)
            .Include(rt => rt.Comments)
            .ToList();

            return releaseTasks;
        }
    }
}
