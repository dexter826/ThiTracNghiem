using DataAccessLayer;
using Entities;
using System;
using System.Data;

namespace BusinessLogicLayer
{
    public class BExam
    {
        public static int AddExam(Exam exam)
        {
            return DExam.AddExam(exam);
        }

        public static void UpdateExam(Exam exam)
        {
            DExam.UpdateExam(exam);
        }

        public static void DeleteExam(int examId)
        {
            DExam.DeleteExam(examId);
        }

        public static DataTable GetAll()
        {
            return DExam.GetAll();
        }

        public static DataTable GetByTeacher(int userId)
        {
            return DExam.GetByTeacher(userId);
        }

        public static DataTable GetByStatus(string status)
        {
            return DExam.GetByStatus(status);
        }

        public static void UpdateStatus(int examId, string status, string approvedBy)
        {
            DExam.UpdateStatus(examId, status, approvedBy);
        }

        public static Exam GetById(int examId)
        {
            return DExam.GetById(examId);
        }

        public static void SetActive(int examId, bool isActive, string modifiedBy)
        {
            DExam.SetActive(examId, isActive, modifiedBy);
        }

        public static DataTable GetActiveBySubject(string subjectId)
        {
            return DExam.GetActiveBySubject(subjectId);
        }

        public static Exam GetActiveExam(string subjectId)
        {
            DataTable dt = DExam.GetActiveBySubject(subjectId);
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Exam exam = new Exam
                {
                    ExamID = Convert.ToInt32(row["ExamID"]),
                    ExamName = row["ExamName"].ToString(),
                    SubjectID = row["SubjectID"].ToString(),
                    SubjectName = row["SubjectName"].ToString(),
                    TimeLimit = Convert.ToInt32(row["TimeLimit"]),
                    TotalQuestion = Convert.ToInt32(row["TotalQuestion"]),
                    Status = row["Status"].ToString(),
                    CreatedBy = row["CreatedBy"].ToString(),
                    CreatedAt = Convert.ToDateTime(row["CreatedAt"]),
                    ModifiedBy = row["ModifiedBy"].ToString(),
                    ModifiedAt = Convert.ToDateTime(row["ModifiedAt"]),
                    ApprovedBy = row["ApprovedBy"] != DBNull.Value ? row["ApprovedBy"].ToString() : null,
                    ApprovedAt = row["ApprovedAt"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(row["ApprovedAt"]) : null,
                    IsActive = Convert.ToBoolean(row["IsActive"])
                };
                return exam;
            }
            return null;
        }
    }
}
