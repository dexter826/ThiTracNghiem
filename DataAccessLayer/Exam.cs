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
                    new SqlParameter("@Status", exam.Status),
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

                    // Kiểm tra xem đề thi có trong kỳ thi đang diễn ra không
                    // Nếu có, đánh dấu IsActive = true
                    exam.IsActive = IsExamInActiveSession(examId);
                }
                reader.Close();
                return exam;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Phương thức kiểm tra xem đề thi có trong kỳ thi đang diễn ra không
        private static bool IsExamInActiveSession(int examId)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(
                    TestCore.ConnectionString.strCon,
                    CommandType.Text,
                    @"SELECT COUNT(*) AS Count
                    FROM [dbo].[ExamSessionDetail] esd
                    INNER JOIN [dbo].[ExamSession] es ON esd.[SessionID] = es.[SessionID]
                    WHERE esd.[ExamID] = @ExamID
                    AND es.[Status] IN ('Scheduled', 'InProgress')
                    AND GETDATE() BETWEEN es.[StartTime] AND es.[EndTime]",
                    new SqlParameter("@ExamID", examId)
                );

                int count = 0;
                if (reader.Read())
                {
                    count = Convert.ToInt32(reader["Count"]);
                }
                reader.Close();

                return count > 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Phương thức SetActive đã được cập nhật để chỉ đánh dấu đề thi là active/inactive
        public static void SetActive(int examId, bool isActive, string modifiedBy)
        {
            try
            {
                // Cập nhật trạng thái active của đề thi
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.Text,
                    @"UPDATE [dbo].[Exam]
                    SET [IsActive] = @IsActive,
                        [ModifiedBy] = @ModifiedBy,
                        [ModifiedAt] = GETDATE()
                    WHERE [ExamID] = @ExamID",
                    new SqlParameter("@ExamID", examId),
                    new SqlParameter("@IsActive", isActive),
                    new SqlParameter("@ModifiedBy", modifiedBy)
                );

                // Nếu hủy kích hoạt đề thi, hủy tất cả các kỳ thi đang diễn ra có chứa đề thi này
                if (!isActive)
                {
                    SqlHelper.ExecuteNonQuery(
                        TestCore.ConnectionString.strCon,
                        CommandType.Text,
                        @"UPDATE es
                        SET es.[Status] = 'Cancelled',
                            es.[ModifiedBy] = @ModifiedBy,
                            es.[ModifiedAt] = GETDATE()
                        FROM [dbo].[ExamSession] es
                        INNER JOIN [dbo].[ExamSessionDetail] esd ON es.[SessionID] = esd.[SessionID]
                        WHERE esd.[ExamID] = @ExamID
                        AND es.[Status] IN ('Scheduled', 'InProgress')",
                        new SqlParameter("@ExamID", examId),
                        new SqlParameter("@ModifiedBy", modifiedBy)
                    );
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        // Phương thức GetActiveBySubject đã được cập nhật để sử dụng trường IsActive
        public static DataTable GetActiveBySubject(string subjectId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(
                    TestCore.ConnectionString.strCon,
                    CommandType.Text,
                    @"SELECT e.[ExamID]
                          ,e.[ExamName]
                          ,e.[SubjectID]
                          ,s.[SubjectName]
                          ,e.[TimeLimit]
                          ,e.[TotalQuestion]
                          ,e.[Status]
                          ,e.[CreatedBy]
                          ,e.[CreatedAt]
                          ,e.[ModifiedBy]
                          ,e.[ModifiedAt]
                          ,e.[ApprovedBy]
                          ,e.[ApprovedAt]
                          ,e.[IsActive]
                      FROM [dbo].[Exam] e
                      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
                      WHERE e.[SubjectID] = @SubjectID
                        AND e.[Status] = 'Approved'
                        AND e.[IsActive] = 1",
                    new SqlParameter("@SubjectID", subjectId)
                );
                return dtData;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static DataTable GetAllActive()
        {
            try
            {
                // Cập nhật để sử dụng trường IsActive
                DataTable dtData = SqlHelper.ExecuteData(
                    TestCore.ConnectionString.strCon,
                    CommandType.Text,
                    @"SELECT e.[ExamID]
                          ,e.[ExamName]
                          ,e.[SubjectID]
                          ,s.[SubjectName]
                          ,e.[TimeLimit]
                          ,e.[TotalQuestion]
                          ,e.[Status]
                          ,e.[CreatedBy]
                          ,e.[CreatedAt]
                          ,e.[ModifiedBy]
                          ,e.[ModifiedAt]
                          ,e.[ApprovedBy]
                          ,e.[ApprovedAt]
                          ,e.[IsActive]
                      FROM [dbo].[Exam] e
                      INNER JOIN [dbo].[Subject] s ON e.[SubjectID] = s.[SubjectID]
                      WHERE e.[Status] = 'Approved'
                        AND e.[IsActive] = 1
                      ORDER BY e.[ExamID] DESC"
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
