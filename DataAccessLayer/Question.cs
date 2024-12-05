using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DQuestion
    {
        public static void AddNewQuestion(Question newQuestion)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Question_Insert",
                                                    newQuestion.SubjectID,
                                                    newQuestion.QContent,
                                                    newQuestion.OptionA,
                                                    newQuestion.OptionB,
                                                    newQuestion.OptionC,
                                                    newQuestion.OptionD,
                                                    newQuestion.Answer,
                                                    newQuestion.CreatedBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetAll()
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Question_SelectAll");
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateQuestion (Question editQuestion)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Question_Update",
                                                    editQuestion.QuestionID,
                                                    editQuestion.SubjectID,
                                                    editQuestion.QContent,
                                                    editQuestion.OptionA,
                                                    editQuestion.OptionB,
                                                    editQuestion.OptionC,
                                                    editQuestion.OptionD,
                                                    editQuestion.Answer,
                                                    editQuestion.ModifiedBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteQuestion(int questionId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Question_Delete", questionId);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable Search(string keyword)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Question_Search", new SqlParameter("@Keyword", keyword));
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetQuesTionForTest(string subjectId, int numberQuestion)
        {
            try
            {
                DataTable dtDate = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure,
                                                            "Question_GetQuestionForTest",
                                                            new SqlParameter("@SubjectID", subjectId),
                                                            new SqlParameter("@NumberOfQuestion", numberQuestion));
                return dtDate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Question GetOne(int questionId)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(TestCore.ConnectionString.strCon, CommandType.StoredProcedure,
                                                                "Question_GetById",
                                                                new SqlParameter("@QuestionID", questionId));
                Question question = new Question();
                if (reader.Read())
                {
                    question.QuestionID = questionId;
                    question.QContent = reader["QContent"].ToString();
                    question.OptionA = reader["OptionA"].ToString();
                    question.OptionB = reader["OptionB"].ToString();
                    question.OptionC = reader["OptionC"].ToString();
                    question.OptionD = reader["OptionD"].ToString();
                    question.Answer = reader["Answer"].ToString();
                }
                reader.Close();
                return question;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetTotalQuestion(string subjectId)
        {
            try
            {
                // Tạo tham số đầu ra
                SqlParameter outputParam = new SqlParameter
                {
                    ParameterName = "@TotalQuestions",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };

                // Thực thi stored procedure
                SqlHelper.ExecuteNonQuery(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "Question_GetTotalQuestionsBySubject",
                    new SqlParameter("@SubjectID", subjectId), // Tham số đầu vào
                    outputParam // Tham số đầu ra
                );

                // Lấy giá trị từ tham số đầu ra
                return Convert.ToInt32(outputParam.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
