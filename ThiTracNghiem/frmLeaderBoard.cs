using BusinessLogicLayer;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ThiTracNghiem.Common;
using DevExpress.XtraEditors;
using System.Linq;


namespace ThiTracNghiem
{
    public partial class frmLeaderBoard : Form
    {
        public frmLeaderBoard()
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
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }
        private bool isSwitchingToMain = false;
        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (!Session.LogonUser.RoldId.Equals("User"))
            {
                // Đặt cờ để bỏ qua xác nhận đóng form
                isSwitchingToMain = true;

                // Tìm form frmTest và đặt giá trị cờ isSwitchingToMain
                frmTest frmTest = Application.OpenForms.OfType<frmTest>().FirstOrDefault();
                if (frmTest != null)
                {
                    frmTest.SetSwitchingToMainFlag(isSwitchingToMain);
                }

                // Ẩn form hiện tại (frmTestResult)
                this.Hide();

                // Mở frmMain
                newFrmMain frmMain = new newFrmMain();
                frmMain.Show();
            }
            else
            {
                Application.ExitThread(); // Thoát nếu là User
            }
        }

        private void lbll_LeaderBoard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void frmLeaderBoard_Load(object sender, EventArgs e)
        {
            try
            {
                TestHistory testHistory = new TestHistory();
                testHistory.SubjectID = Session.SubjectID;
                grv_DataUser.AutoGenerateColumns = false;
                grv_DataUser.DataSource = BTestHistory.GetLeaderBoard(testHistory);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex.Message);
            }
        }

        private void grv_DataUser_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            grv_DataUser["STT", e.RowIndex].Value = (e.RowIndex < 10 ? "0" : string.Empty) + (e.RowIndex + 1);
        }
    }
}
