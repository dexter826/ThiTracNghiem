using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class BTestHistory
    {
        public static void SaveResult(TestHistory testHistory)
        {
            DTestHistory.SaveResult(testHistory);
        }
        public static DataTable GetLeaderBoard(TestHistory testHistory)
        {
            return DTestHistory.GetLeaderBoard(testHistory);
        }

        public static DataTable GetReportBySubject(string subjectId)
        {
            return DTestHistory.GetReportBySubject(subjectId);
        }

        public static DataTable GetReportByTime(DateTime startDate, DateTime endDate)
        {
            return DTestHistory.GetReportByTime(startDate, endDate);
        }
    }
}
