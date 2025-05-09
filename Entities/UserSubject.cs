using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserSubject
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string SubjectID { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string SubjectName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
