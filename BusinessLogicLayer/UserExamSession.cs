using DataAccessLayer;
using Entities;
using System;
using System.Data;

namespace BusinessLogicLayer
{
    public class BUserExamSession
    {
        public static void AddUserExamSession(UserExamSession userExamSession)
        {
            DUserExamSession.AddUserExamSession(userExamSession);
        }

        public static void UpdateStatus(int userId, int sessionId, string status, DateTime? startTime, DateTime? endTime, string modifiedBy)
        {
            DUserExamSession.UpdateStatus(userId, sessionId, status, startTime, endTime, modifiedBy);
        }

        public static DataTable GetBySession(int sessionId)
        {
            return DUserExamSession.GetBySession(sessionId);
        }

        public static UserExamSession GetByUserAndSession(int userId, int sessionId)
        {
            return DUserExamSession.GetByUserAndSession(userId, sessionId);
        }

        public static DataTable GetStatistics(int sessionId)
        {
            return DUserExamSession.GetStatistics(sessionId);
        }
    }
}
