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
                var teachers = users.AsEnumerable()
                    .Where(row => row["RoleID"].ToString() == "Teacher")
                    .CopyToDataTable();

                cbb_Teacher.DataSource = teachers;
                cbb_Teacher.DisplayMember = "Fullname";
                cbb_Teacher.ValueMember = "UserID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách giáo viên: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSubjects()
        {
            try
            {
                // Lấy danh sách môn học
                var subjects = BSubject.GetAll();

                guna2ComboBox1.DataSource = subjects;
                guna2ComboBox1.DisplayMember = "SubjectName";
                guna2ComboBox1.ValueMember = "SubjectID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách môn học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTeacherSubjects()
        {
            try
            {
                if (cbb_Teacher.SelectedValue != null)
                {
                    int teacherId = Convert.ToInt32(cbb_Teacher.SelectedValue);
                    var teacherSubjects = BTeacherSubject.GetByTeacher(teacherId);

                    // Thêm cột STT
                    if (teacherSubjects.Rows.Count > 0)
                    {
                        DataColumn sttColumn = new DataColumn("STT", typeof(int));
                        teacherSubjects.Columns.Add(sttColumn);

                        for (int i = 0; i < teacherSubjects.Rows.Count; i++)
                        {
                            teacherSubjects.Rows[i]["STT"] = i + 1;
                        }

                        // Sắp xếp lại thứ tự cột
                        teacherSubjects.Columns["STT"].SetOrdinal(0);
                    }

                    grv_TeacherSubject.DataSource = teacherSubjects;

                    // Ẩn cột ID
                    if (grv_TeacherSubject.Columns["ID"] != null)
                        grv_TeacherSubject.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phân công: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (cbb_Teacher.SelectedValue == null || guna2ComboBox1.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn giáo viên và môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int teacherId = Convert.ToInt32(cbb_Teacher.SelectedValue);
                string subjectId = guna2ComboBox1.SelectedValue.ToString();

                // Kiểm tra xem giáo viên đã được phân công môn học này chưa
                if (BTeacherSubject.IsTeacherAssigned(teacherId, subjectId))
                {
                    MessageBox.Show("Giáo viên đã được phân công môn học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Phân công môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách phân công
                LoadTeacherSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi phân công môn học: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (grv_TeacherSubject.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn phân công cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phân công này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                int id = Convert.ToInt32(grv_TeacherSubject.SelectedRows[0].Cells["ID"].Value);
                BTeacherSubject.DeleteTeacherSubject(id);
                MessageBox.Show("Xóa phân công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách phân công
                LoadTeacherSubjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phân công: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
