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
        public static DataTable GetQuesTionForTest(string subjectId, int numberQuestion)
        {
            return DQuestion.GetQuesTionForTest(subjectId, numberQuestion); 
        }
        public static Question GetOne(int questionId)
        {
            return DQuestion.GetOne(questionId);
        }
    }
}
