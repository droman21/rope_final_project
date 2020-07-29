using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Repositories;
using RopeFinalProjectBackEnd.Controllers;

namespace RopeFinalProjectBackEndTests
{
    public class EmployeeControllerTests
    {
        EmployeeController underTest;
        IRepository<Employee> employeeRepo;

        public EmployeeControllerTests()
        {
            employeeRepo = Substitute.For<IRepository<Employee>>();
            underTest = new EmployeeController(employeeRepo);
        }
        [Fact]
        public void Get_By_Id_Returns_Valid_Release_Task()
        {
            var newRelease = new Employee();
            employeeRepo.GetById(1).Returns(newRelease);
            var result = underTest.Get(1);
            Assert.Equal(newRelease, result);
        }
    }
}
