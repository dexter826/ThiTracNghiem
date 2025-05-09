using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DUserExamSession
    {
        public static void AddUserExamSession(UserExamSession userExamSession)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "UserExamSession_Insert",
                    new SqlParameter("@UserID", userExamSession.UserID),
                    new SqlParameter("@SessionID", userExamSession.SessionID),
                    new SqlParameter("@Status", userExamSession.Status),
                    new SqlParameter("@CreatedBy", userExamSession.CreatedBy)
                );
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateStatus(int userId, int sessionId, string status, DateTime? startTime, DateTime? endTime, string modifiedBy)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "UserExamSession_UpdateStatus",
                    new SqlParameter("@UserID", userId),
                    new SqlParameter("@SessionID", sessionId),
                    new SqlParameter("@Status", status),
                    new SqlParameter("@StartTime", startTime ?? (object)DBNull.Value),
                    new SqlParameter("@EndTime", endTime ?? (object)DBNull.Value),
                    new SqlParameter("@ModifiedBy", modifiedBy)
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
                    "UserExamSession_GetBySession",
                    new SqlParameter("@SessionID", sessionId)
                );
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static UserExamSession GetByUserAndSession(int userId, int sessionId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "UserExamSession_GetByUserAndSession",
                    new SqlParameter("@UserID", userId),
                    new SqlParameter("@SessionID", sessionId)
                );

                if (dtData != null && dtData.Rows.Count > 0)
                {
                    DataRow row = dtData.Rows[0];
                    UserExamSession userExamSession = new UserExamSession
                    {
                        UserSessionID = Convert.ToInt32(row["UserSessionID"]),
                        UserID = Convert.ToInt32(row["UserID"]),
                        Username = row["Username"].ToString(),
                        Fullname = row["Fullname"].ToString(),
                        SessionID = Convert.ToInt32(row["SessionID"]),
                        Status = row["Status"].ToString(),
                        StartTime = row["StartTime"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["StartTime"]) : null,
                        EndTime = row["EndTime"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["EndTime"]) : null,
                        CreatedBy = row["CreatedBy"].ToString(),
                        CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                        ModifiedBy = row["ModifiedBy"].ToString(),
                        ModifiedAt = Convert.ToDateTime(row["ModifiedAt"])
                    };
                    return userExamSession;
                }
                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
