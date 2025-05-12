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
    }
}
