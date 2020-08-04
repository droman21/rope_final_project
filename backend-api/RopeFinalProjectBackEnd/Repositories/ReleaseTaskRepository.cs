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
            .Include(rt => rt.Employee).Where(e => e.AssignedEmployeeID == e.Employee.ID).ToList();

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
