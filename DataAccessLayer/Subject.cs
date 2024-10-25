using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DSubject
    {
        public static void AddNewSubject(Subject newSubject)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Subject_Insert",
                                                    newSubject.SubjectId,
                                                    newSubject.SubjectName,
                                                    newSubject.Description,
                                                    newSubject.CreatedBy,
                                                    newSubject.ModifiedBy);
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
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Subject_SelectAll");
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void UpdateSubject (Subject editSubject)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Subject_Update",
                                                    editSubject.SubjectId,
                                                    editSubject.SubjectName,
                                                    editSubject.Description,
                                                    editSubject.ModifiedBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DeleteSubject(string subjectId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "Subject_Delete", subjectId);
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
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "Subject_Search", new SqlParameter("@Keyword", keyword));
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
