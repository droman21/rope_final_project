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

        //public override void UpdateFields(ReleaseTask entity, params Expression<func<t, object="">>[] includeProperties)
        //{
        //    //base.Patch(entity);
        //    using (var context = new ReleaseTasksAPIContext())
        //    {
        //        var dbEntry = context.Entry(entity);
        //        foreach (var includeProperty in includeProperties)
        //        {
        //            dbEntry.Property(includeProperty).IsModified = true;
        //        }
        //        context.SaveChanges();
        //    }
        //}
        //</func<t,>

        public override void UpdateFields(ReleaseTask entity)
        {
            //base.UpdateFields(entity);
            //var temp = new ReleaseTask();
            var t2 = entity;
            using (var db = new ReleaseTasksAPIContext())
            {
                db.ReleaseTasks.Attach(t2);
                db.Entry(t2).Property(x => x.IsVisisble).IsModified = true;
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
            //this line gives a lambda error
            //.Include(rt => rt.Status.Name).Where(rt => rt.CurrentStatusID == rt.Status.ID).FirstOrDefault();

            //this line works but returns incorrect data
            //.Include(rt => rt.Status).Where(s => s.CurrentStatusID == 1).ToList();

            //this line works but returns all other tasks with StatusIDs that match the current StatusID
            .Include(rt => rt.Status).Where(s => s.CurrentStatusID == s.Status.ID)
            .Include(rt => rt.Priority).Where(p => p.CurrentPriorityID == p.Priority.ID)
            .Include(rt => rt.Employee).Where(e => e.AssignedEmployeeID == e.Employee.ID)
            .Include(rt => rt.Comments)
            .ToList();

            //return db.ReleaseTasks.Include("ReleaseTask").ToList();
            return releaseTasks;
        }

        //public override IEnumerable<ReleaseTask> GetAll()
        //{
        //    var releaseTasks = db.ReleaseTasks
        //        .Include(s => s.Status)
        //        //.ThenInclude(s => s.Name)
        //        .Where(s => s.CurrentStatusID == s.Status.ID)
        //        .ToList();
        //    return releaseTasks;
        //}

    }
}
