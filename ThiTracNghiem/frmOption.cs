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

            try
            {
                Session.SubjectName = cbb_Subject.Text;
                Session.SubjectID = cbb_Subject.SelectedValue.ToString();
                int.TryParse(txt_NumberQuestion.Text, out int numberOfQuestion);
                Session.NumberOfQuestion = numberOfQuestion;
                int.TryParse(txt_Time.Text, out int time);
                Session.TestTime = time;

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
                var subjects = BSubject.GetAll();
                var filteredSubjects = subjects.AsEnumerable()
                    .Where(row => BQuestion.GetTotalQuestion(row["SubjectID"].ToString()) >= Convert.ToInt32(row["QuesQuantity"]))
                    .CopyToDataTable();

                cbb_Subject.DataSource = filteredSubjects;
                cbb_Subject.DisplayMember = "SubjectName";
                cbb_Subject.ValueMember = "SubjectID";

                if (filteredSubjects != null && filteredSubjects.Rows.Count > 0)
                {
                    var selectedSubject = filteredSubjects.Rows[0];
                    txt_NumberQuestion.Text = selectedSubject["QuesQuantity"].ToString();
                    txt_Time.Text = selectedSubject["TimeLimit"].ToString();
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
            if (!Session.LogonUser.RoldId.Equals("User"))
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
                var subjects = BSubject.GetAll();
                var selectedSubject = subjects.AsEnumerable()
                    .FirstOrDefault(row => row["SubjectID"].ToString() == selectedSubjectID);

                if (selectedSubject != null)
                {
                    txt_NumberQuestion.Text = selectedSubject["QuesQuantity"].ToString();
                    txt_Time.Text = selectedSubject["TimeLimit"].ToString();
                }
            }
        }
    }
}
