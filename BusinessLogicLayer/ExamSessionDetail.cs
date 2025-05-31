using DataAccessLayer;
using Entities;
using System;
using System.Data;

namespace BusinessLogicLayer
{
    public class BExamSessionDetail
    {
        public static void AddExamSessionDetail(ExamSessionDetail examSessionDetail)
        {
            DExamSessionDetail.AddExamSessionDetail(examSessionDetail);
        }

        public static DataTable GetBySession(int sessionId)
        {
            return DExamSessionDetail.GetBySession(sessionId);
        }

        public static void UpdateExamSessionDetail(int sessionId, int examId, string modifiedBy)
        {
            DExamSessionDetail.UpdateExamSessionDetail(sessionId, examId, modifiedBy);
        }

        public static void DeleteBySession(int sessionId)
        {
            DExamSessionDetail.DeleteBySession(sessionId);
        }
    }
}
