using DataAccessLayer;
using Entities;
using System;
using System.Data;

namespace BusinessLogicLayer
{
    public class BTeacherSubject
    {
        public static void AddTeacherSubject(TeacherSubject teacherSubject)
        {
            DTeacherSubject.AddTeacherSubject(teacherSubject);
        }

        public static DataTable GetByTeacher(int userId)
        {
            return DTeacherSubject.GetByTeacher(userId);
        }

        public static void DeleteTeacherSubject(int id)
        {
            DTeacherSubject.DeleteTeacherSubject(id);
        }

        public static bool IsTeacherAssigned(int userId, string subjectId)
        {
            return DTeacherSubject.IsTeacherAssigned(userId, subjectId);
        }
    }
}
