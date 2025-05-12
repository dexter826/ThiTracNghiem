using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DExamSession
    {
        public static int AddExamSession(ExamSession examSession)
        {
            try
            {
                // Tạo tham số đầu ra
                SqlParameter outputParam = new SqlParameter
                {
                    ParameterName = "@SessionID",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                // Thực thi stored procedure
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSession_Insert",
                    new SqlParameter("@SessionName", examSession.SessionName),
                    new SqlParameter("@StartTime", examSession.StartTime),
                    new SqlParameter("@EndTime", examSession.EndTime),
                    new SqlParameter("@Status", examSession.Status),
                    new SqlParameter("@CreatedBy", examSession.CreatedBy),
                    outputParam
                );

                // Lấy giá trị từ tham số đầu ra
                return Convert.ToInt32(outputParam.Value);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateStatus(int sessionId, string status, string modifiedBy)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSession_UpdateStatus",
                    new SqlParameter("@SessionID", sessionId),
                    new SqlParameter("@Status", status),
                    new SqlParameter("@ModifiedBy", modifiedBy)
                );
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateExamSession(ExamSession examSession)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSession_Update",
                    new SqlParameter("@SessionID", examSession.SessionID),
                    new SqlParameter("@SessionName", examSession.SessionName),
                    new SqlParameter("@StartTime", examSession.StartTime),
                    new SqlParameter("@EndTime", examSession.EndTime),
                    new SqlParameter("@ModifiedBy", examSession.ModifiedBy)
                );
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetAll()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSession_SelectAll"
                );
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetCurrent()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSession_GetCurrent"
                );
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetStatistics()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSession_GetStatistics"
                );
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetByUser(int userId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSession_GetByUser",
                    new SqlParameter("@UserID", userId)
                );
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static ExamSession GetById(int sessionId)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "ExamSession_GetById",
                    new SqlParameter("@SessionID", sessionId)
                );

                ExamSession examSession = null;
                if (reader.Read())
                {
                    examSession = new ExamSession
                    {
                        SessionID = Convert.ToInt32(reader["SessionID"]),
                        SessionName = reader["SessionName"].ToString(),
                        StartTime = Convert.ToDateTime(reader["StartTime"]),
                        EndTime = Convert.ToDateTime(reader["EndTime"]),
                        Status = reader["Status"].ToString(),
                        CreatedBy = reader["CreatedBy"].ToString(),
                        CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                        ModifiedBy = reader["ModifiedBy"].ToString(),
                        ModifiedAt = Convert.ToDateTime(reader["ModifiedAt"])
                    };
                }
                reader.Close();
                return examSession;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
