using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace MainProject.Beans
{
    // Create your POCO class
    public class ProjectInfo
    {
        public int id { get; set; }
        //public int CurrentId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectId { get; set; }
        public string ProjectId { get; set; }
        public string Engineer { get; set; }
        public string Review { get; set; }
        public string Process { get; set; }
        public string Standard { get; set; }
        public string Approval { get; set; }
        public bool IsCurrent { get; set; }
    }

    // Open database (or create if doesn't exist)
    
}
