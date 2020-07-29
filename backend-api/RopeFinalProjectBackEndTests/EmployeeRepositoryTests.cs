using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Repositories;
using RopeFinalProjectBackEnd.Contexts;
using System.Linq;

namespace RopeFinalProjectBackEndTests
{
    public class EmployeeRepositoryTests : IDisposable
    {
        private ReleaseTasksAPIContext db;
        private EmployeeRepository underTest;

        public EmployeeRepositoryTests()
        {
            db = new ReleaseTasksAPIContext();
            db.Database.BeginTransaction();
            underTest = new EmployeeRepository(db);
        }
        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }
        [Fact]
        public void Create_Increases_Count()
        {
            var currentCount = db.Employees.Count();
            underTest.Create(new Employee()
            {
                Name = "Release Name",
                Role = "Developer"
            });
            Assert.Equal(currentCount + 1, db.Employees.Count());
        }
        [Fact]
        public void Delete_Decreases_Count()
        {
            var currentCount = db.Employees.Count();
            underTest.Delete(underTest.GetById(1));
            Assert.Equal(currentCount - 1, db.Employees.Count());
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

