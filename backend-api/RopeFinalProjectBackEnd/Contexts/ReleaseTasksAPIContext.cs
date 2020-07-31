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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReleaseTasks_Database;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString);
                          //.UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<Employee>().HasData(
                new Employee { ID = 1, Name = "Dakota", Role = "Developer"},
                new Employee { ID = 2, Name = "Bernard", Role = "Developer" },
                new Employee { ID = 3, Name = "Dan", Role = "Developer" },
                new Employee { ID = 4, Name = "Ron", Role = "Developer" },
                new Employee { ID = 5, Name = "Robert", Role = "Release Manager" }
                );

            modelbuilder.Entity<Priority>().HasData(
                new Priority { ID = 1, Name = "Critical", Value = 1},
                new Priority { ID = 2, Name = "High", Value = 2 },
                new Priority { ID = 3, Name = "Medium", Value = 3 },
                new Priority { ID = 4, Name = "Low", Value = 4 }
                );

            modelbuilder.Entity<Status>().HasData(
                new Status { ID = 1, Name = "New", Value = 1 },
                new Status { ID = 2, Name = "In Progress", Value = 2 },
                new Status { ID = 3, Name = "Done", Value = 3 },
                new Status { ID = 4, Name = "Cancelled", Value = 4 }
                );

            modelbuilder.Entity<ReleaseTask>().HasData(
                new ReleaseTask { ID = 1, Name="Validate Readiness", Description = "Validate Team Ready for Out of Service Page", CurrentStatusID = 1, CurrentPriorityID = 1, AssignedEmployeeID = 1, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-19-2020 20:00:00"), CreatedDate =  DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 2, Name = "Update User Message", Description = "Update Message To Reflect Routine Maintenance", CurrentStatusID = 2, CurrentPriorityID = 2, AssignedEmployeeID = 2, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-19-2020 20:15:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 3, Name = "Push Content Changes", Description = "Publish Content Updates/Changes, See Content Updates", CurrentStatusID = 3, CurrentPriorityID = 3, AssignedEmployeeID = 3, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-19-2020 20:35:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 4, Name = "Execute App Changes", Description = "Execute App Container Changes/Updates in Production, See App Container Tasks", CurrentStatusID = 4, CurrentPriorityID = 4, AssignedEmployeeID = 4, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-19-2020 21:15:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 5, Name = "Deploy New UI", Description = "Deploy New U/I Layer Package, See U / I Layer Code", CurrentStatusID = 2, CurrentPriorityID = 4, AssignedEmployeeID = 2, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-19-2020 22:45:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 6, Name = "Deploy Shared UI", Description = "Deploy Shared U/I Layer Package  See U / I Layer Code", CurrentStatusID = 3, CurrentPriorityID = 4, AssignedEmployeeID = 3, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-19-2020 23:00:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 7, Name = "Deploy New Services", Description = "Deploy New Services Layer Package, See Services Layer Code", CurrentStatusID = 1, CurrentPriorityID = 4, AssignedEmployeeID = 1, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-19-2020 23:15:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 8, Name = "Perform Refresh", Description = "Perform System Cache Refresh", CurrentStatusID = 3, CurrentPriorityID = 2, AssignedEmployeeID = 2, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-19-2020 23:55:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 9, Name = "Remove Service Page", Description = "Bring Down Out of Service Page", CurrentStatusID = 2, CurrentPriorityID = 2, AssignedEmployeeID = 2, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-20-2020 00:01:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 10, Name = "Update User Message", Description = "Update Message To Reflect Issues In The Event An Unplanned Outage Occurs", CurrentStatusID = 3, CurrentPriorityID = 4, AssignedEmployeeID = 4, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-21-2020 01:15:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 11, Name = "Notify Validation Group", Description = "Notify Group Validation Can Begin", CurrentStatusID = 1, CurrentPriorityID = 3, AssignedEmployeeID = 3, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-20-2020 02:00:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 12, Name = "Monitor System", Description = "System Monitoring Through Monday", CurrentStatusID = 3, CurrentPriorityID = 3, AssignedEmployeeID = 5, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-20-2020 08:00:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 13, Name = "Complete Final Checklist", Description = "Enure no steps were missed", CurrentStatusID= 1, CurrentPriorityID = 4, AssignedEmployeeID = 5, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-20-2020 08:00:00"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now}
                );

            //modelbuilder.Entity<ReleaseTask>().HasData(
            //    new Comment { ID = 1, Details = "Operations Running Smoothly.", IsVisible = true, ReleaseTaskID = 1 },
            //    new Comment { ID = 2, Details = "Having some issues.", IsVisible = true, ReleaseTaskID = 1 },
            //    new Comment { ID = 3, Details = "Runtime errors present", IsVisible = true, ReleaseTaskID = 1 },
            //    new Comment { ID = 4, Details = "No issues.", IsVisible = true, ReleaseTaskID = 2 },
            //    new Comment { ID = 5, Details = "Estimated completion in 30 minutes.", IsVisible = true, ReleaseTaskID = 2 },
            //    new Comment { ID = 6, Details = "Running about 45 minutes behind schedule.", IsVisible = true, ReleaseTaskID = 3 },
            //    new Comment { ID = 7, Details = "Looking good.", IsVisible = true, ReleaseTaskID = 3 },
            //    new Comment { ID = 8, Details = "This might be a show stopper.", IsVisible = true, ReleaseTaskID = 4 },
            //    new Comment { ID = 9, Details = "GO Decision made.", IsVisible = true, ReleaseTaskID = 5}
            //    );
        }
    }
}
