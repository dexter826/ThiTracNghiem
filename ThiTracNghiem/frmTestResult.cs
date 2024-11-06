using BusinessLogicLayer;
using Entities;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ThiTracNghiem.Common;
using DevExpress.XtraEditors;

namespace ThiTracNghiem
{
    public partial class frmTestResult : Form
    {
        private bool isSwitchingToMain = false;
        public frmTestResult(int correctAnswer, float mark)
        {
            InitializeComponent();
            txt_Name.Text = Session.LogonUser.Fullname;
            txt_Birthday.Text = Session.LogonUser.Birthday.ToString("dd/MM/yyyy");
            txt_SubjectName.Text = Session.SubjectName;

            txt_NumberOfQuestion.Text = Session.NumberOfQuestion.ToString();
            txt_CorrectAnswer.Text = correctAnswer.ToString();
            txt_Mark.Text = mark.ToString("0.00");
            if (mark >= 9)
                txt_Rate.Text = "Bạn đã làm bài thi xuất sắc";
            else if (mark >= 7)
                txt_Rate.Text = "Bạn đã làm bài thi khá tốt";
            else if (mark >= 5)
                txt_Rate.Text = "Chúc mừng bạn đã qua môn";
            else
                txt_Rate.Text = "Chúc bạn may mắn lần sau :D";

            SetStyle(ControlStyles.ResizeRedraw, true);

            //lưu điểm vào dtbase
            TestHistory testHistory = new TestHistory()
            {
                UserId = Session.LogonUser.UsertId,
                SubjectID = Session.SubjectID,
                TestDate = DateTime.Now,
                CorrectAnswer = correctAnswer,
                Mark = (int)mark,
                TotalQuestion = Session.NumberOfQuestion,
                CreatedBy = Session.LogonUser.Username
            };

            try
            {
                BTestHistory.SaveResult(testHistory); // Lưu kết quả thi vào cơ sở dữ liệu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            frmLeaderBoard fmLeaderBoard = new frmLeaderBoard();
            fmLeaderBoard.ShowDialog();
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            frmLeaderBoard fmLeaderBoard = new frmLeaderBoard();
            fmLeaderBoard.ShowDialog();
        }
    }
}
