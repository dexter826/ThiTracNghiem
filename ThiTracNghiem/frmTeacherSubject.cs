using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    public partial class frmTeacherSubject : UserControl
    {
        public frmTeacherSubject()
        {
            InitializeComponent();
        }

        private void frmTeacherSubject_Load(object sender, EventArgs e)
        {
            LoadTeachers();
            LoadSubjects();
            LoadTeacherSubjects();
        }

        private void LoadTeachers()
        {
            try
            {
                // Lấy danh sách giáo viên (UserRole = Teacher)
                var users = BUserAccount.GetAll();

                // Kiểm tra xem có dữ liệu không
                if (users == null || users.Rows.Count == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không có giáo viên nào trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Lọc ra các giáo viên
                DataTable teachers;
                try
                {
                    teachers = users.AsEnumerable()
                        .Where(row => row["RoleID"].ToString() == "Teacher")
                        .CopyToDataTable();
                }
                catch (InvalidOperationException)
                {
                    // Không có giáo viên nào
                    DevExpress.XtraEditors.XtraMessageBox.Show("Không có giáo viên nào trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Gán dữ liệu cho ComboBox
                cbb_Teacher.DataSource = null;
                cbb_Teacher.DataSource = teachers;
                cbb_Teacher.DisplayMember = "Fullname";
                cbb_Teacher.ValueMember = "UserID";
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi tải danh sách giáo viên: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjects()
        {
            try
            {
                // Lấy danh sách môn học
                var subjects = BSubject.GetAll();

                cbb_Subject.DataSource = subjects;
                cbb_Subject.DisplayMember = "SubjectName";
                cbb_Subject.ValueMember = "SubjectID";
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi tải danh sách môn học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeacherSubjects()
        {
            try
            {
                if (cbb_Teacher.SelectedValue != null)
                {
                    int teacherId;

                    // Xử lý trường hợp SelectedValue là DataRowView
                    if (cbb_Teacher.SelectedItem is DataRowView)
                    {
                        DataRowView drv = (DataRowView)cbb_Teacher.SelectedItem;
                        teacherId = Convert.ToInt32(drv["UserID"]);
                    }
                    else
                    {
                        teacherId = Convert.ToInt32(cbb_Teacher.SelectedValue);
                    }

                    var teacherSubjects = BTeacherSubject.GetByTeacher(teacherId);

                    // Thêm cột STT và Fullname
                    if (teacherSubjects.Rows.Count > 0)
                    {
                        // Thêm cột STT
                        DataColumn sttColumn = new DataColumn("STT", typeof(int));
                        teacherSubjects.Columns.Add(sttColumn);

                        // Thêm cột Fullname
                        if (!teacherSubjects.Columns.Contains("Fullname"))
                        {
                            DataColumn fullnameColumn = new DataColumn("Fullname", typeof(string));
                            teacherSubjects.Columns.Add(fullnameColumn);
                        }

                        // Lấy thông tin giáo viên
                        var teachers = BUserAccount.GetAll();
                        var teacherRow = teachers.AsEnumerable()
                            .FirstOrDefault(row => Convert.ToInt32(row["UserID"]) == teacherId);

                        string teacherName = teacherRow != null ? teacherRow["Fullname"].ToString() : "Unknown";

                        for (int i = 0; i < teacherSubjects.Rows.Count; i++)
                        {
                            teacherSubjects.Rows[i]["STT"] = i + 1;
                            teacherSubjects.Rows[i]["Fullname"] = teacherName;
                        }

                        // Sắp xếp lại thứ tự cột
                        teacherSubjects.Columns["STT"].SetOrdinal(0);
                    }

                    // Thiết lập không tự động tạo cột
                    grv_TeacherSubject.AutoGenerateColumns = false;

                    // Ánh xạ các cột trong DataGridView với các cột trong DataTable
                    grv_TeacherSubject.Columns["Column1"].DataPropertyName = "STT";
                    grv_TeacherSubject.Columns["Column2"].DataPropertyName = "ID";

                    // Cột tên giáo viên - đã thêm vào DataTable
                    grv_TeacherSubject.Columns["Column3"].DataPropertyName = "Fullname";

                    grv_TeacherSubject.Columns["Column4"].DataPropertyName = "SubjectID";
                    grv_TeacherSubject.Columns["Column5"].DataPropertyName = "SubjectName";
                    grv_TeacherSubject.Columns["Column6"].DataPropertyName = "CreatedAt";
                    grv_TeacherSubject.Columns["Column7"].DataPropertyName = "CreatedBy";

                    // Gán DataSource
                    grv_TeacherSubject.DataSource = teacherSubjects;

                    // Ẩn cột ID
                    grv_TeacherSubject.Columns["Column2"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi tải danh sách phân công: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_Teacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTeacherSubjects();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_Teacher.SelectedValue == null || cbb_Subject.SelectedValue == null)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn giáo viên và môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int teacherId;
                if (cbb_Teacher.SelectedItem is DataRowView)
                {
                    DataRowView drv = (DataRowView)cbb_Teacher.SelectedItem;
                    teacherId = Convert.ToInt32(drv["UserID"]);
                }
                else
                {
                    teacherId = Convert.ToInt32(cbb_Teacher.SelectedValue);
                }

                string subjectId;
                if (cbb_Subject.SelectedItem is DataRowView)
                {
                    DataRowView drv = (DataRowView)cbb_Subject.SelectedItem;
                    subjectId = drv["SubjectID"].ToString();
                }
                else
                {
                    subjectId = cbb_Subject.SelectedValue.ToString();
                }

                // Kiểm tra xem giáo viên đã được phân công môn học này chưa
                if (BTeacherSubject.IsTeacherAssigned(teacherId, subjectId))
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Giáo viên đã được phân công môn học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm phân công mới
                TeacherSubject teacherSubject = new TeacherSubject
                {
                    UserID = teacherId,
                    SubjectID = subjectId,
                    CreatedBy = Session.LogonUser.Username,
                    ModifiedBy = Session.LogonUser.Username
                };

                BTeacherSubject.AddTeacherSubject(teacherSubject);
                DevExpress.XtraEditors.XtraMessageBox.Show("Phân công môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách phân công
                LoadTeacherSubjects();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi phân công môn học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_TeacherSubject.SelectedRows.Count == 0)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng chọn phân công cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (DevExpress.XtraEditors.XtraMessageBox.Show("Bạn có chắc chắn muốn xóa phân công này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                int id = Convert.ToInt32(grv_TeacherSubject.SelectedRows[0].Cells["ID"].Value);
                BTeacherSubject.DeleteTeacherSubject(id);
                DevExpress.XtraEditors.XtraMessageBox.Show("Xóa phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách phân công
                LoadTeacherSubjects();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("Lỗi khi xóa phân công: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
