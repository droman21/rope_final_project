using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RopeFinalProjectBackEnd.Models
{
    public class ReleaseTask
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentStatusID { get; set; }
        public int CurrentPriorityID { get; set; }
        public DateTime CurrentDueTime { get; set; }
        public bool IsVisisble { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int AssignedEmployeeID { get; set; }
    }
}
