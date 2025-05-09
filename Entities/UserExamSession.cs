using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserExamSession
    {
        public int UserSessionID { get; set; }
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public int SessionID { get; set; }
        public string Status { get; set; } // 'Registered', 'Started', 'Completed', 'Absent'
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
