using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Exam
    {
        public int ExamID { get; set; }
        public string ExamName { get; set; }
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
        public int TimeLimit { get; set; }
        public int TotalQuestion { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? ApprovedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
