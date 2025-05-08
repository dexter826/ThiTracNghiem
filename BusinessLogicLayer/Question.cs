using DataAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BQuestion
    {
        public static DataTable GetByChapter(string subjectId, string chapter)
        {
            return DQuestion.GetByChapter(subjectId, chapter);
        }

        public static DataTable GetChaptersBySubject(string subjectId)
        {
            return DQuestion.GetChaptersBySubject(subjectId);
        }
        public static void AddNewQuestion(Question newQuestion)
        {
            DQuestion.AddNewQuestion(newQuestion);
        }
        public static DataTable GetAll()
        {
            return DQuestion.GetAll();
        }
        public static void UpdateQuestion(Question editQuestion)
        {
            DQuestion.UpdateQuestion(editQuestion);
        }
        public static void DeleteQuestion(int questionId)
        {
            DQuestion.DeleteQuestion(questionId);
        }
        public static DataTable Search(string keyword)
        {
            return DQuestion.Search(keyword);
        }
        public static DataTable GetQuesTionForTest(string subjectId, int numberQuestion, int? examId = null)
        {
            return DQuestion.GetQuesTionForTest(subjectId, numberQuestion, examId);
        }
        public static Question GetOne(int questionId)
        {
            return DQuestion.GetOne(questionId);
        }
        public static int GetTotalQuestion(string subjectId)
        {
            return DQuestion.GetTotalQuestion(subjectId);
        }
    }
}
