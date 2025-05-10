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

        public static DataTable GetApprovedBySubject(string subjectId)
        {
            return DExam.GetApprovedBySubject(subjectId);
        }

        public static DataTable GetAllApproved()
        {
            return DExam.GetAllApproved();
        }
    }
}
