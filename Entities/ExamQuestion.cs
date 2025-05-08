using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ExamQuestion
    {
        public int ID { get; set; }
        public int ExamID { get; set; }
        public int QuestionID { get; set; }
    }
}
