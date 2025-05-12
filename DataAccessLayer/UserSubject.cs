using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DUserSubject
    {
        public static void Insert(int userId, string subjectId, string createdBy)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "UserSubject_Insert",
                                                    userId,
                                                    subjectId,
                                                    createdBy);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Delete(int userId, string subjectId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "UserSubject_Delete",
                                                    userId,
                                                    subjectId);
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
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure,
                                                        "UserSubject_GetByUser",
                                                        new SqlParameter("@UserID", userId));
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetBySubject(string subjectId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure,
                                                        "UserSubject_GetBySubject",
                                                        new SqlParameter("@SubjectID", subjectId));
                return dtData;
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
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserSubject_GetAll");
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
