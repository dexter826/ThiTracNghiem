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
    public class DUserRole
    {
        public static void AddNewUser(UserAccount newUser)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "UserAccount_Insert", newUser.RoleID, newUser.Username,
                    newUser.Password, newUser.Fullname, newUser.Email, newUser.PhoneNumber, newUser.Address,
                    newUser.Birthday, newUser.Note, newUser.CreatedBy, newUser.ModifiedBy);
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
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserRole_SelectAll");
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void UpdateUser(UserAccount editUser)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "UserAccount_Update",
                                                    editUser.UserID,
                                                    editUser.RoleID,
                                                    editUser.Username,
                                                    editUser.Password,
                                                    editUser.Fullname,
                                                    editUser.Email,
                                                    editUser.PhoneNumber,
                                                    editUser.Address,
                                                    editUser.Birthday,
                                                    editUser.Note,
                                                    editUser.ModifiedBy);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteUser(int userId)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "UserAccount_Delete", userId);
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
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserAccount_Search", new SqlParameter("@Keyword", keyword));
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
