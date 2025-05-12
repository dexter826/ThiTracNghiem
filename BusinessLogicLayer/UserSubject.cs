using DataAccessLayer;
using Entities;
using System;
using System.Data;

namespace BusinessLogicLayer
{
    public class BUserSubject
    {
        public static void Insert(int userId, string subjectId, string createdBy)
        {
            DUserSubject.Insert(userId, subjectId, createdBy);
        }

        public static void Delete(int userId, string subjectId)
        {
            DUserSubject.Delete(userId, subjectId);
        }

        public static DataTable GetByUser(int userId)
        {
            return DUserSubject.GetByUser(userId);
        }

        public static DataTable GetBySubject(string subjectId)
        {
            return DUserSubject.GetBySubject(subjectId);
        }

        public static DataTable GetAll()
        {
            return DUserSubject.GetAll();
        }
    }
}
