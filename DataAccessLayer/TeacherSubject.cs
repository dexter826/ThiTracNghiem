using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DTeacherSubject
    {
        public static void AddTeacherSubject(TeacherSubject teacherSubject)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "TeacherSubject_Insert",
                                                    teacherSubject.UserID,
                                                    teacherSubject.SubjectID,
                                                    teacherSubject.CreatedBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetByTeacher(int userId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, 
                                                        "TeacherSubject_GetByTeacher",
                                                        new SqlParameter("@UserID", userId));
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteTeacherSubject(int id)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "TeacherSubject_Delete", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool IsTeacherAssigned(int userId, string subjectId)
        {
            try
            {
                // Tạo tham số đầu ra
                SqlParameter outputParam = new SqlParameter
                {
                    ParameterName = "@IsAssigned",
                    SqlDbType = SqlDbType.Bit,
                    Direction = ParameterDirection.Output
                };

                // Thực thi stored procedure
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "TeacherSubject_IsAssigned",
                    new SqlParameter("@UserID", userId),
                    new SqlParameter("@SubjectID", subjectId),
                    outputParam
                );

                // Lấy giá trị từ tham số đầu ra
                return Convert.ToBoolean(outputParam.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
