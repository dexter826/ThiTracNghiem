using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DExam
    {
        public static int AddExam(Exam exam)
        {
            try
            {
                // Tạo tham số đầu ra
                SqlParameter outputParam = new SqlParameter
                {
                    ParameterName = "@ExamID",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                // Thực thi stored procedure
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "Exam_Insert",
                    new SqlParameter("@ExamName", exam.ExamName),
                    new SqlParameter("@SubjectID", exam.SubjectID),
                    new SqlParameter("@TimeLimit", exam.TimeLimit),
                    new SqlParameter("@TotalQuestion", exam.TotalQuestion),
                    new SqlParameter("@CreatedBy", exam.CreatedBy),
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

        public static void UpdateExam(Exam exam)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Exam_Update",
                                                    exam.ExamID,
                                                    exam.ExamName,
                                                    exam.SubjectID,
                                                    exam.TimeLimit,
                                                    exam.TotalQuestion,
                                                    exam.ModifiedBy);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void DeleteExam(int examId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Exam_Delete", examId);
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
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Exam_SelectAll");
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetByTeacher(int userId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure,
                                                        "Exam_GetByTeacher",
                                                        new SqlParameter("@UserID", userId));
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetByStatus(string status)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure,
                                                        "Exam_GetByStatus",
                                                        new SqlParameter("@Status", status));
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void UpdateStatus(int examId, string status, string approvedBy)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Exam_UpdateStatus",
                                                    examId,
                                                    status,
                                                    approvedBy);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Exam GetById(int examId)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(TestCore.ConnectionString.strCon, CommandType.StoredProcedure,
                                                                "Exam_GetById",
                                                                new SqlParameter("@ExamID", examId));
                Exam exam = new Exam();
                if (reader.Read())
                {
                    exam.ExamID = examId;
                    exam.ExamName = reader["ExamName"].ToString();
                    exam.SubjectID = reader["SubjectID"].ToString();
                    exam.SubjectName = reader["SubjectName"].ToString();
                    exam.TimeLimit = Convert.ToInt32(reader["TimeLimit"]);
                    exam.TotalQuestion = Convert.ToInt32(reader["TotalQuestion"]);
                    exam.Status = reader["Status"].ToString();
                    exam.CreatedBy = reader["CreatedBy"].ToString();
                    exam.CreatedAt = Convert.ToDateTime(reader["CreatedAt"]);
                    exam.ModifiedBy = reader["ModifiedBy"].ToString();
                    exam.ModifiedAt = Convert.ToDateTime(reader["ModifiedAt"]);
                    exam.ApprovedBy = reader["ApprovedBy"] != DBNull.Value ? reader["ApprovedBy"].ToString() : null;
                    exam.ApprovedAt = reader["ApprovedAt"] != DBNull.Value ? Convert.ToDateTime(reader["ApprovedAt"]) : (DateTime?)null;
                }
                reader.Close();
                return exam;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
