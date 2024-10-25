using BusinessLogicLayer;
using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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

            //if (cbb_NumberOfQuestion.StartIndex == -1)
            //{
            //    XtraMessageBox.Show("Vui lòng chọn số lượng câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            try
            {
                Session.SubjectName = cbb_Subject.Text;
                Session.SubjectID = cbb_Subject.SelectedValue.ToString();
                int.TryParse(cbb_NumberOfQuestion.Text, out int numberOfQuestion);
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
        private void LoadData()
        {
            try
            {
                cbb_Subject.DataSource = BSubject.GetAll();
                cbb_Subject.DisplayMember = "SubjectName";
                cbb_Subject.ValueMember = "SubjectID";
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
                cbb_NumberOfQuestion.Enabled = true;
                txt_Time.Enabled = true;
                txt_Time.ReadOnly = false;
            }
        }

        private void cbb_NumberOfQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numberOfQuestions;
            bool isValid = int.TryParse(cbb_NumberOfQuestion.Text, out numberOfQuestions);

            txt_Time.Text = isValid ? (numberOfQuestions + 10).ToString() : string.Empty;
        }

        private void txt_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
