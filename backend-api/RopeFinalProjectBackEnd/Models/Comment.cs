using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RopeFinalProjectBackEnd.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Details { get; set; }
        public bool IsVisible { get; set; }

        //public ReleaseTask ReleaseTask { get; set; }
        public int ReleaseTaskID { get; set; }

    }
}
