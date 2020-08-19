//using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RopeFinalProjectBackEnd.Models;
using RopeFinalProjectBackEnd.Contexts;

namespace RopeFinalProjectBackEnd.Repositories
{
    public class EmployeeRepository : Repository<Employee>, IRepository<Employee>
    {
        public EmployeeRepository(ReleaseTasksAPIContext context) : base(context)
        {
        }
    }
}
