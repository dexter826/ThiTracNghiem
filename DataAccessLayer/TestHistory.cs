using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{

    public class DTestHistory
    {
        public static void SaveResult(TestHistory testHistory)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "TestHistory_Insert",
                                                    testHistory.UserId,
                                                    testHistory.SubjectID,
                                                    testHistory.TestDate,
                                                    testHistory.CorrectAnswer,
                                                    testHistory.TotalQuestion,
                                                    testHistory.Mark,
                                                    testHistory.CreatedBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetLeaderBoard(TestHistory testHistory)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "TestHistory_LeaderBoard",
                                                                           new SqlParameter("@SubjectID", testHistory.SubjectID));
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetReportBySubject(string subjectId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "TestHistory_ReportBySubject",
                                                                           new SqlParameter("@SubjectID", subjectId));
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetReportByTime(DateTime startDate, DateTime endDate)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "TestHistory_ReportByTime",
                                                                           new SqlParameter("@StartDate", startDate),
                                                                           new SqlParameter("@EndDate", endDate));
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
