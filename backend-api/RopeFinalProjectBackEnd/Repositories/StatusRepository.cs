using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Contexts;

namespace RopeFinalProjectBackEnd.Repositories
{
    public class StatusRepository : Repository<Status>, IRepository<Status>
    {
        public StatusRepository(ReleaseTasksAPIContext context) : base(context)
        {

        }
    }
}
