using BusinessLogicLayer;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ThiTracNghiem.Common;

namespace ThiTracNghiem
{
    public partial class frmOption : XtraForm
    {
        public frmOption()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.FromArgb(172, 203, 238), Color.FromArgb(231, 240, 253), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Time.Text) || txt_Time.Text == "0")
            {
                XtraMessageBox.Show("Thời gian thi không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbb_Subject.SelectedValue == null)
            {
                XtraMessageBox.Show("Vui lòng chọn môn học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Thông tin môn học đã được lưu trong LoadActiveExam
                Session.SubjectName = cbb_Subject.Text;
                Session.SubjectID = cbb_Subject.SelectedValue.ToString();

                // Kiểm tra lại đề thi kích hoạt
                Exam activeExam = BExam.GetActiveExam(Session.SubjectID);
                if (activeExam == null)
                {
                    XtraMessageBox.Show("Không tìm thấy đề thi kích hoạt cho môn học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lưu thông tin đề thi kích hoạt
                Session.ExamID = activeExam.ExamID;
                Session.NumberOfQuestion = activeExam.TotalQuestion;
                Session.TestTime = activeExam.TimeLimit;

                frmTest fmTest = new frmTest();
                this.Hide();
                fmTest.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        ///  Phương thức này lấy danh sách các môn học từ BSubject
        /// </summary>
        private void LoadData()
        {
            try
            {
                // Lấy danh sách môn học có đề thi đã được kích hoạt
                var subjects = BSubject.GetSubjectsWithActiveExams();

                if (subjects != null && subjects.Rows.Count > 0)
                {
                    cbb_Subject.DataSource = subjects;
                    cbb_Subject.DisplayMember = "SubjectName";
                    cbb_Subject.ValueMember = "SubjectID";

                    // Chọn môn học đầu tiên
                    cbb_Subject.SelectedIndex = 0;
                    // Tải thông tin đề thi kích hoạt của môn học đầu tiên
                    LoadActiveExam(cbb_Subject.SelectedValue.ToString());
                }
                else
                {
                    cbb_Subject.DataSource = null;
                    txt_NumberQuestion.Text = "";
                    txt_Time.Text = "";
                    btn_Start.Enabled = false;
                    MessageBox.Show("Không có môn học nào có đề thi được kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!");
            }
        }



        private void frmOption_Load(object sender, EventArgs e)
        {
            LoadData();
            if (!Session.LogonUser.RoleID.Equals("User"))
            {
                txt_NumberQuestion.Enabled = true;
                txt_Time.Enabled = true;
                txt_Time.ReadOnly = false;
            }
        }

        private void txt_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbb_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Subject.SelectedValue != null)
            {
                var selectedSubjectID = cbb_Subject.SelectedValue.ToString();
                LoadActiveExam(selectedSubjectID);
            }
        }

        private void LoadActiveExam(string subjectId)
        {
            try
            {
                // Lấy đề thi đang kích hoạt của môn học
                Exam activeExam = BExam.GetActiveExam(subjectId);

                if (activeExam != null)
                {
                    // Hiển thị thông tin đề thi
                    txt_NumberQuestion.Text = activeExam.TotalQuestion.ToString();
                    txt_Time.Text = activeExam.TimeLimit.ToString();

                    // Lưu thông tin đề thi
                    Session.ExamID = activeExam.ExamID;
                    Session.NumberOfQuestion = activeExam.TotalQuestion;
                    Session.TestTime = activeExam.TimeLimit;

                    // Kích hoạt nút bắt đầu
                    btn_Start.Enabled = true;


                }
                else
                {
                    // Không có đề thi nào được kích hoạt
                    txt_NumberQuestion.Text = "0";
                    txt_Time.Text = "0";
                    btn_Start.Enabled = false;

                    MessageBox.Show("Môn học này chưa có đề thi được kích hoạt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải đề thi: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
