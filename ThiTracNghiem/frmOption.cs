using BusinessLogicLayer;
using DevExpress.XtraEditors;
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
            if (string.IsNullOrEmpty(txt_Time.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập thời gian thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbb_Exam.SelectedValue == null || cbb_Exam.DataSource == null)
            {
                XtraMessageBox.Show("Vui lòng chọn đề thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Session.SubjectName = cbb_Subject.Text;
                Session.SubjectID = cbb_Subject.SelectedValue.ToString();
                int.TryParse(txt_NumberQuestion.Text, out int numberOfQuestion);
                Session.NumberOfQuestion = numberOfQuestion;
                int.TryParse(txt_Time.Text, out int time);
                Session.TestTime = time;

                // Lưu thông tin đề thi đã chọn
                int examId = Convert.ToInt32(cbb_Exam.SelectedValue);
                Session.ExamID = examId;

                frmTest fmTest = new frmTest();
                this.Hide();
                fmTest.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        ///  Phương thức này lấy danh sách các môn học từ BSubject
        /// </summary>
        private void LoadData()
        {
            try
            {
                // Lấy danh sách môn học
                var subjects = BSubject.GetAll();
                cbb_Subject.DataSource = subjects;
                cbb_Subject.DisplayMember = "SubjectName";
                cbb_Subject.ValueMember = "SubjectID";

                if (subjects != null && subjects.Rows.Count > 0)
                {
                    // Chọn môn học đầu tiên
                    cbb_Subject.SelectedIndex = 0;
                    // Tải danh sách đề thi của môn học đầu tiên
                    LoadExams(cbb_Subject.SelectedValue.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo lỗi!");
            }
        }

        private void LoadExams(string subjectId)
        {
            try
            {
                // Lấy danh sách đề thi đã được duyệt của môn học
                var exams = BExam.GetByStatus("Approved");
                var filteredExams = exams.AsEnumerable()
                    .Where(row => row["SubjectID"].ToString() == subjectId)
                    .CopyToDataTable();

                if (filteredExams != null && filteredExams.Rows.Count > 0)
                {
                    cbb_Exam.DataSource = filteredExams;
                    cbb_Exam.DisplayMember = "ExamName";
                    cbb_Exam.ValueMember = "ExamID";

                    // Chọn đề thi đầu tiên
                    cbb_Exam.SelectedIndex = 0;

                    // Hiển thị thông tin của đề thi đầu tiên
                    var selectedExam = filteredExams.Rows[0];
                    txt_NumberQuestion.Text = selectedExam["TotalQuestion"].ToString();
                    txt_Time.Text = selectedExam["TimeLimit"].ToString();
                }
                else
                {
                    // Nếu không có đề thi nào, xóa dữ liệu cũ
                    cbb_Exam.DataSource = null;
                    txt_NumberQuestion.Text = "";
                    txt_Time.Text = "";
                    MessageBox.Show("Không có đề thi nào cho môn học này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                LoadExams(selectedSubjectID);
            }
        }

        private void cbb_Exam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Exam.SelectedValue != null && cbb_Exam.DataSource != null)
            {
                try
                {
                    int examId = Convert.ToInt32(cbb_Exam.SelectedValue);
                    var exam = BExam.GetById(examId);

                    txt_NumberQuestion.Text = exam.TotalQuestion.ToString();
                    txt_Time.Text = exam.TimeLimit.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lấy thông tin đề thi: " + ex.Message, "Thông báo lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
