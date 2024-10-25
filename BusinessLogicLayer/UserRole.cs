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
    public class BUserRole
    {
        public static void AddNewUser(UserAccount newUser)
        {
            DUserAccount.AddNewUser(newUser);
        }
        public static DataTable GetAll()
        {
            return DUserRole.GetAll();
        }
        public static void UpdateUser(UserAccount editUser)
        {
            DUserAccount.UpdateUser(editUser);
        }
        public static void DeleteUser(int userId)
        {
            DUserAccount.DeleteUser(userId);
        }
    }
}
