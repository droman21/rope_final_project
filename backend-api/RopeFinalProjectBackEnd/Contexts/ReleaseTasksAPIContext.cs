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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=ReleaseTasks_Database;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

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
                new Priority { ID = 1, Name = "New", Value = 1 },
                new Priority { ID = 2, Name = "In Progress", Value = 2 },
                new Priority { ID = 3, Name = "Done", Value = 3 },
                new Priority { ID = 4, Name = "Cancelled", Value = 4 }
                );

            modelbuilder.Entity<ReleaseTask>().HasData(
                new ReleaseTask { ID = 1, Name="Release Task 1", Description = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", CurrentStatusID = 1, CurrentPriorityID = 1, AssignedEmployeeID = 1, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-18-2020"), CreatedDate =  DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 2, Name = "Release Task 2", Description = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", CurrentStatusID = 2, CurrentPriorityID = 2, AssignedEmployeeID = 2, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-19-2020"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 3, Name = "Release Task 3", Description = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", CurrentStatusID = 3, CurrentPriorityID = 3, AssignedEmployeeID = 3, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-20-2020"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now },
                new ReleaseTask { ID = 4, Name = "Release Task 4", Description = "Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attributed to an unknown typesetter in the 15th century who is thought to have scrambled parts of Cicero's De Finibus Bonorum et Malorum for use in a type specimen book.", CurrentStatusID = 4, CurrentPriorityID = 4, AssignedEmployeeID = 4, IsVisisble = true, CurrentDueTime = Convert.ToDateTime("08-21-2020"), CreatedDate = DateTime.Now, LastModifiedDate = DateTime.Now }
                );



        }

    }
}
