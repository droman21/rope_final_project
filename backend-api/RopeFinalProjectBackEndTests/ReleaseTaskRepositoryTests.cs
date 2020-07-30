using System;
using Xunit;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Repositories;
using RopeFinalProjectBackEnd.Contexts;
using System.Linq;

namespace RopeFinalProjectBackEndTests
{
    public class ReleaseTaskRepositoryTests: IDisposable
    {
        private ReleaseTasksAPIContext db;
        private ReleaseTaskRepository underTest;

        public ReleaseTaskRepositoryTests()
        {
            db = new ReleaseTasksAPIContext();
            db.Database.BeginTransaction();
            underTest = new ReleaseTaskRepository(db);
        }
        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }
        [Fact]
        public void Create_Increases_Count()
        {
            var currentCount = db.ReleaseTasks.Count();
            underTest.Create(new ReleaseTask()
            {
                Name = "Release Name",
                Description = "Text",
                CurrentStatusID = 1,
                CurrentPriorityID = 1,
                CurrentDueTime = Convert.ToDateTime("08-18-2020"),
                CreatedDate = Convert.ToDateTime("08-18-2020"),
                LastModifiedDate = Convert.ToDateTime("08-18-2020"),
                IsVisisble = true,
                AssignedEmployeeID = 1
            });
            Assert.Equal(currentCount + 1, db.ReleaseTasks.Count());
        }
        [Fact]
        public void Delete_Decreases_Count()
        {
            var currentCount = db.ReleaseTasks.Count();
            underTest.Delete(underTest.GetById(1));
            Assert.Equal(currentCount - 1, db.ReleaseTasks.Count());
        }
        [Fact]
        public void Update_Changes_Name()
        {
            var currentObject = underTest.GetById(1);
            var currentName = currentObject.Name;
            char[] myArray = currentName.ToCharArray();
            Array.Reverse(myArray);
            var newName = myArray.ToString();

            currentObject.Name = newName;
            Assert.NotEqual(newName, currentName);
        }
    }
}
