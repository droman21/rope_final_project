using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RopeFinalProjectBackEnd.Models
{
    public class Status
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        //public IEnumerable<ReleaseTask> ReleaseTasks { get; set; }
    }
}
