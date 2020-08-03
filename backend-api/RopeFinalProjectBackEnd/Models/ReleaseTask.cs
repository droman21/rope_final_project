using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RopeFinalProjectBackEnd.Models
{
    public class ReleaseTask
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CurrentDueTime { get; set; }
        public bool IsVisisble { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        [ForeignKey("Status")]
        public int CurrentStatusID { get; set; }
        public Status Status { get; set; }

        [ForeignKey("Priority")]
        public int CurrentPriorityID { get; set; }
        public Priority Priority { get; set; }

        [ForeignKey("Employee")]
        public int AssignedEmployeeID { get; set; }
        public Employee Employee { get; set; }

        public IEnumerable<Comment> Comments { get; set; }

    }
}
