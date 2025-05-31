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

        public static void UpdateExamSessionDetail(int sessionId, int examId, string modifiedBy)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSessionDetail_Update",
                    new SqlParameter("@SessionID", sessionId),
                    new SqlParameter("@ExamID", examId),
                    new SqlParameter("@ModifiedBy", modifiedBy)
                );
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteBySession(int sessionId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSessionDetail_DeleteBySession",
                    new SqlParameter("@SessionID", sessionId)
                );
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
