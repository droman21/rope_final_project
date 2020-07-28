using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RopeFinalProjectBackEnd.Models;


namespace RopeFinalProjectBackEnd.Contexts
{
    public class ReleaseTasksAPIContext : DbContext
    {
        public DbSet<ReleaseTask> ReleaseTasks { get; set; }
        public DbSet<Employee> Peoples { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Priority> Priorities { get; set; }
    }
}
