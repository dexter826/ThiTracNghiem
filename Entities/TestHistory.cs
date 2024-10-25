using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class TestHistory
    {
        public int TestId {  get; set; }
        public int UserId { get; set; }
        public string SubjectID { get; set; }
        public DateTime TestDate { get; set; }
        public int CorrectAnswer { get; set; }
        public int TotalQuestion { get; set; }
        public int Mark { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
