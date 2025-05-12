using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DExamSessionDetail
    {
        public static void AddExamSessionDetail(ExamSessionDetail examSessionDetail)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSessionDetail_Insert",
                    new SqlParameter("@SessionID", examSessionDetail.SessionID),
                    new SqlParameter("@ExamID", examSessionDetail.ExamID),
                    new SqlParameter("@CreatedBy", examSessionDetail.CreatedBy)
                );
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetBySession(int sessionId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSessionDetail_GetBySession",
                    new SqlParameter("@SessionID", sessionId)
                );
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
