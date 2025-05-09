using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DUserAccount
    {
        public static bool IsExistsAccount(UserAccount user)
        {
            bool isExist = false;

            SqlConnection sqlConnection = new SqlConnection(TestCore.ConnectionString.strCon);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("UserAccount_CheckExist", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Username", user.Username);
                sqlCommand.Parameters.AddWithValue("@Password", user.Password);

                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())
                    isExist = true;
                dataReader.Close();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
            return isExist;
        }

        //cập nhật mật khẩu
        public static void UpdatePassword(UserAccount user)
        {
            SqlConnection sqlConnection = new SqlConnection(TestCore.ConnectionString.strCon);
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("UserAccount_ChangePassword", sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@username", user.Username);
                sqlCommand.Parameters.AddWithValue("@newPassword", user.NewPassword);
                sqlCommand.ExecuteNonQuery();
                sqlCommand.Dispose();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void AddNewUser(UserAccount newUser)
        {
            try
            {
                SqlHelper.ExecuteNonQuery(TestCore.ConnectionString.strCon, "UserAccount_Insert", newUser.RoleID, newUser.Username,
                    newUser.Password, newUser.Fullname, newUser.Email, newUser.PhoneNumber, newUser.Address,
                    newUser.Birthday, newUser.Note, newUser.Image, newUser.CreatedBy, newUser.ModifiedBy);
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
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserAccount_SelectAll");
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
                                                    editUser.Image,
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

        public static DataTable Search(string keyword, string roleFilter)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(TestCore.ConnectionString.strCon, CommandType.StoredProcedure,
                                                            "UserAccount_Search",
                                                            new SqlParameter("@Keyword", keyword),
                                                            new SqlParameter("@RoleID", roleFilter));
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static UserAccount GetInforUser(string username)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "UserAccount_GetInforUser",
                                                           new SqlParameter("@Username", username));
                UserAccount userAccount = new UserAccount();
                if (reader.Read())
                {
                    userAccount.Username = reader["Username"].ToString();
                    userAccount.Fullname = reader["Fullname"].ToString();
                    userAccount.Birthday = DateTime.Parse(reader["Birthday"].ToString());
                    userAccount.UserID = int.Parse(reader["UserID"].ToString());
                    userAccount.Address = reader["Address"].ToString();
                    userAccount.RoleID = reader["RoleID"].ToString();
                    userAccount.Image = reader["Image"] as byte[];
                }
                reader.Close();
                return userAccount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static UserAccount GetPasswordByEmail(string email)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "GetPasswordByEmail",
                                                               new SqlParameter("@Email", email));

                UserAccount userAccount = null;

                if (reader.Read())
                {
                    userAccount = new UserAccount
                    {
                        Password = reader["Password"].ToString()
                    };
                }

                reader.Close();
                return userAccount;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool IsEmailExists(string email)
        {
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(TestCore.ConnectionString.strCon, CommandType.StoredProcedure, "CheckEmailExists",
                                                               new SqlParameter("@Email", email));
                bool exists = false;
                if (reader.Read())
                {
                    exists = Convert.ToBoolean(reader["Exist"]);
                }
                reader.Close();
                return exists;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable GetByRole(string roleId)
        {
            try
            {
                DataTable dtData = SqlHelper.ExecuteData(
                    TestCore.ConnectionString.strCon,
                    CommandType.StoredProcedure,
                    "UserAccount_GetByRole",
                    new SqlParameter("@RoleID", roleId)
                );
                return dtData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
