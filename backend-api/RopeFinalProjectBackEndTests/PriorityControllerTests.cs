using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Controllers;
using RopeFinalProjectBackEnd.Repositories;

namespace RopeFinalProjectBackEndTests
{
    public class PriorityControllerTests
    {
        PriorityController underTest;
        IRepository<Priority> priorityRepo;

        public PriorityControllerTests()
        {
            priorityRepo = Substitute.For<IRepository<Priority>>();
            underTest = new PriorityController(priorityRepo);
        }
        [Fact]
        public void Get_By_Id_Returns_Valid_Release_Task()
        {
            var newRelease = new Priority();
            priorityRepo.GetById(1).Returns(newRelease);
            var result = underTest.Get(1);
            Assert.Equal(newRelease, result);
        }
    }
}
