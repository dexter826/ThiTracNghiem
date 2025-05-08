using DataAccessLayer;
using Entities;
using System;
using System.Data;

namespace BusinessLogicLayer
{
    public class BExamQuestion
    {
        public static void AddExamQuestion(int examId, int questionId)
        {
            DExamQuestion.AddExamQuestion(examId, questionId);
        }

        public static void DeleteExamQuestion(int examId, int questionId)
        {
            DExamQuestion.DeleteExamQuestion(examId, questionId);
        }

        public static DataTable GetByExam(int examId)
        {
            return DExamQuestion.GetByExam(examId);
        }

        public static void DeleteAllQuestions(int examId)
        {
            DExamQuestion.DeleteAllQuestions(examId);
        }
    }
}
