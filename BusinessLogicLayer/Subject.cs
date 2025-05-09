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
    public static class BSubject
    {
        public static void AddNewSubject(Subject newSubject)
        {
            DSubject.AddNewSubject(newSubject);
        }
        public static DataTable GetAll()
        {
            return DSubject.GetAll();
        }
        public static void UpdateSubject(Subject editSubject)
        {
            DSubject.UpdateSubject(editSubject);
        }
        public static void DeleteSubject(string subjectId)
        {
            DSubject.DeleteSubject(subjectId);
        }
        public static DataTable Search(string keyword)
        {
            return DSubject.Search(keyword);
        }

        public static bool IsSubjectExist(string subjectId)
        {
            return DSubject.IsSubjectExist(subjectId);
        }


    }
}
