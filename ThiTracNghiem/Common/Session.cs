using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiTracNghiem.Common
{
    public class Session
    {
        public static UserAccount LogonUser = null;
        public static string SubjectName = string.Empty;
        public static string SubjectID = string.Empty;
        public static int TestTime = 10;
        public static int NumberOfQuestion = 10;
    }
}
