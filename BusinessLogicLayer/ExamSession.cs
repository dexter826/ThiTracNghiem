using DataAccessLayer;
using Entities;
using System;
using System.Data;

namespace BusinessLogicLayer
{
    public class BExamSession
    {
        public static int AddExamSession(ExamSession examSession)
        {
            return DExamSession.AddExamSession(examSession);
        }

        public static void UpdateStatus(int sessionId, string status, string modifiedBy)
        {
            DExamSession.UpdateStatus(sessionId, status, modifiedBy);
        }

        public static void UpdateExamSession(ExamSession examSession)
        {
            DExamSession.UpdateExamSession(examSession);
        }

        public static DataTable GetAll()
        {
            return DExamSession.GetAll();
        }

        public static DataTable GetCurrent()
        {
            return DExamSession.GetCurrent();
        }

        public static DataTable GetByUser(int userId)
        {
            return DExamSession.GetByUser(userId);
        }

        public static ExamSession GetById(int sessionId)
        {
            return DExamSession.GetById(sessionId);
        }

        public static DataTable GetStatistics()
        {
            return DExamSession.GetStatistics();
        }
    }
}
