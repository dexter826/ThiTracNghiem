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
    public class BUserAccount
    {
        public static bool IsExistsAccount(UserAccount user)
        {
            return DUserAccount.IsExistsAccount(user);
        }
        public static void UpdatePassword(UserAccount user)
        {
            DUserAccount.UpdatePassword(user);
        }
        public static void AddNewUser(UserAccount newUser)
        {
            DUserAccount.AddNewUser(newUser);
        }
        public static DataTable GetAll()
        {
            return DUserAccount.GetAll();
        }
        public static void UpdateUser(UserAccount editUser)
        {
            DUserAccount.UpdateUser(editUser);
        }
        public static void DeleteUser(int userId)
        {
            DUserAccount.DeleteUser(userId);
        }
        public static DataTable Search(string keyword, string roleFilter)
        {
            return DUserAccount.Search(keyword, roleFilter);
        }
        public static UserAccount GetInforUser(string username)
        {
            return DUserAccount.GetInforUser(username);
        }

        public static UserAccount GetPasswordByEmail(string email)
        {
            return DUserAccount.GetPasswordByEmail(email);
        }

        public static bool IsEmailExists(string email)
        {
            return DUserAccount.IsEmailExists(email);
        }

        public static DataTable GetByRole(string roleId)
        {
            return DUserAccount.GetByRole(roleId);
        }
    }
}
