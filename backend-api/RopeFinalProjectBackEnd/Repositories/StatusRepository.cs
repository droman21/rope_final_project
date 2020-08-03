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
    public class StatusRepository : Repository<Status>, IRepository<Status>
    {
        ReleaseTasksAPIContext db;

        public StatusRepository(ReleaseTasksAPIContext context) : base(context)
        {
            db = context;
        }

        public override Status GetById(int id)
        {
            return db.Statuses.Where(o => o.ID == id).FirstOrDefault();
        }

        //public override IEnumerable<Status> GetAll()
        //{
        //    return db.Statuses.Include("ReleaseTask").ToList();
        //}
    }
}
