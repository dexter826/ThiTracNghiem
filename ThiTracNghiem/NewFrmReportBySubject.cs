using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ThiTracNghiem.Common;
using DevExpress.XtraEditors;
using Entities;
using Microsoft.Reporting.WinForms;


namespace ThiTracNghiem
{
    public partial class NewFrmReportBySubject : UserControl
    {
        public NewFrmReportBySubject()
        {
            InitializeComponent();
        }

        private void NewFrmReportBySubject_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                // Kiểm tra quyền của người dùng
                if (Session.LogonUser.RoleID.Equals("Teacher"))
                {
                    // Nếu là giáo viên, chỉ load môn học được phân công
                    var teacherSubjects = BTeacherSubject.GetByTeacher(Session.LogonUser.UserID);

                    if (teacherSubjects != null && teacherSubjects.Rows.Count > 0)
                    {
                        cbb_MonThi.DataSource = teacherSubjects;
                        cbb_MonThi.DisplayMember = "SubjectName";
                        cbb_MonThi.ValueMember = "SubjectID";
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa được phân công môn học nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        cbb_MonThi.DataSource = null;
                    }
                }
                else
                {
                    // Nếu là Admin, load tất cả môn học
                    cbb_MonThi.DataSource = BSubject.GetAll();
                    cbb_MonThi.DisplayMember = "SubjectName";
                    cbb_MonThi.ValueMember = "SubjectID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!");
            }
        }

        // Hàm lấy dữ liệu báo cáo
        private DataTable GetReportData()
        {
            string subjectId = cbb_MonThi.SelectedValue.ToString();
            return BTestHistory.GetReportBySubject(subjectId);
        }

        private void btn_XemBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtData = GetReportData();
                if (dtData == null || dtData.Rows.Count == 0)
                {
                    XtraMessageBox.Show("Không có dữ liệu để hiển thị báo cáo.", "Thông báo");
                    return;
                }

                // Lấy tên môn học
                string subjectName = cbb_MonThi.Text;

                // Hiển thị báo cáo sử dụng ReportHelper
                ReportHelper.ShowSubjectReport(subjectName, dtData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
