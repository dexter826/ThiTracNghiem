using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DExamQuestion
    {
        public static void AddExamQuestion(int examId, int questionId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "ExamQuestion_Insert",
                                                    examId,
                                                    questionId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteExamQuestion(int examId, int questionId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "ExamQuestion_Delete",
                                                    examId,
                                                    questionId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetByExam(int examId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, 
                                                        "ExamQuestion_GetByExam",
                                                        new SqlParameter("@ExamID", examId));
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteAllQuestions(int examId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "ExamQuestion_DeleteAll",
                                                    examId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
