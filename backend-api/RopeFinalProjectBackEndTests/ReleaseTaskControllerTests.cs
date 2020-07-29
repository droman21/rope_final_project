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
    public class ReleaseTaskControllerTests
    {
        ReleaseTaskController underTest;
        IRepository<ReleaseTask> releaseTaskRepo;

        public ReleaseTaskControllerTests()
        {
            releaseTaskRepo = Substitute.For<IRepository<ReleaseTask>>();
            underTest = new ReleaseTaskController(releaseTaskRepo);
        }
        [Fact]
        public void Get_By_Id_Returns_Valid_Release_Task()
        {
            var newRelease = new ReleaseTask();
            releaseTaskRepo.GetById(1).Returns(newRelease);
            var result = underTest.Get(1);
            Assert.Equal(newRelease, result);
        }
    }
}
