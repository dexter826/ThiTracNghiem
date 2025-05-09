using BusinessLogicLayer;
using Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ThiTracNghiem.Common;
using DevExpress.XtraEditors;
using System.IO;


namespace ThiTracNghiem
{
    public partial class frmTest : Form
    {
        private int selectedIndex = 0;
        private int remainTime = 0;
        DataTable dtQuestion = null;
        private bool isRaiseSelectedEvent = false;
        private bool isUpdatingOption = false; // Biến cờ để ngăn việc kích hoạt sự kiện đệ quy
        private bool isSwitchingToMain = false; //Cờ cho phép chuyển về màn hình chính sau khi làm bài thi.

        /// <summary>
        /// Xử lý sự kiện phím tắt
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.A)
            {
                rdb_OptionA.Checked = true;
                SaveCurrentSelected();
                return true;
            }
            else if (keyData == Keys.B)
            {
                rdb_OptionB.Checked = true;
                SaveCurrentSelected();
                return true;
            }
            else if (keyData == Keys.C)
            {
                rdb_OptionC.Checked = true;
                SaveCurrentSelected();
                return true;
            }
            else if (keyData == Keys.D)
            {
                rdb_OptionD.Checked = true;
                SaveCurrentSelected();
                return true;
            }
            else if (keyData == Keys.Right || keyData == Keys.PageDown)
            {
                // Chuyển sang câu hỏi tiếp theo
                if (selectedIndex < Session.NumberOfQuestion - 1)
                {
                    isRaiseSelectedEvent = false;
                    lsb_Question.SelectedIndex = selectedIndex + 1;
                    isRaiseSelectedEvent = true;
                    ShowDetailQuestion();
                }
                return true;
            }
            else if (keyData == Keys.Left || keyData == Keys.PageUp)
            {
                // Quay lại câu hỏi trước đó
                if (selectedIndex > 0)
                {
                    isRaiseSelectedEvent = false;
                    lsb_Question.SelectedIndex = selectedIndex - 1;
                    isRaiseSelectedEvent = true;
                    ShowDetailQuestion();
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public frmTest()
        {
            InitializeComponent();
            this.KeyPreview = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.FromArgb(12, 52, 131), Color.FromArgb(107, 140, 206), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }

        private static Image ConvertByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            txt_Name.Text = Session.LogonUser.Fullname;
            txt_Birthday.Text = Session.LogonUser.Birthday.ToString("dd/MM/yyyy");
            txt_Subject.Text = Session.SubjectName;
            txt_CountQuestion.Text = Session.NumberOfQuestion.ToString();
            if (Session.LogonUser.Image != null)
            {
                ptb_Avatar.Image = ConvertByteArrayToImage(Session.LogonUser.Image);
                ptb_NoImage.Visible = false;
                ptb_Avatar.Visible = true;
            }
            else
            {
                ptb_Avatar.Image = null;
                ptb_Avatar.Visible = false;
                ptb_NoImage.Visible = true;
            }
            LoadData();
            remainTime = Session.TestTime * 60; //đổi sang phút
            timerTest.Enabled = true;
            isRaiseSelectedEvent = true;

            UpdateCompletedQuestionsCount();
        }

        private void LoadData()
        {
            try
            {
                // Lấy câu hỏi từ đề thi đã chọn
                dtQuestion = BQuestion.GetQuesTionForTest(Session.SubjectID, Session.ExamID);
                dtQuestion.Columns.Add("SelectedOption"); //"SelectedOption" để lưu đáp án người dùng chọn.
                lsb_Question.DataSource = dtQuestion;
                lsb_Question.DisplayMember = "QuestionIndex";
                lsb_Question.ValueMember = "QuestionID";

                selectedIndex = 0;
                lsb_Question.SelectedIndex = selectedIndex;
                ShowDetailQuestion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Lấy đáp án đã chọn
        /// </summary>
        /// <returns></returns>
        private string GetSelectOption()
        {
            string result = string.Empty;
            if (rdb_OptionA.Checked)
                result = rdb_OptionA.Text;
            else if (rdb_OptionB.Checked)
                result = rdb_OptionB.Text;
            else if (rdb_OptionC.Checked)
                result = rdb_OptionC.Text;
            else if (rdb_OptionD.Checked)
                result = rdb_OptionD.Text;
            return result;
        }

        /// <summary>
        /// Tải đáp án đã chọn trước đó
        /// </summary>
        private void LoadPrevSelectOption()
        {
            string precSelected = dtQuestion.Rows[selectedIndex]["SelectedOption"].ToString();
            if (rdb_OptionA.Text.Equals(precSelected))
                rdb_OptionA.Checked = true;
            else if (rdb_OptionB.Text.Equals(precSelected))
                rdb_OptionB.Checked = true;
            else if (rdb_OptionC.Text.Equals(precSelected))
                rdb_OptionC.Checked = true;
            else if (rdb_OptionD.Text.Equals(precSelected))
                rdb_OptionD.Checked = true;
        }

        /// <summary>
        /// Cập nhật số câu hỏi đã hoàn thành
        /// </summary>
        private void UpdateCompletedQuestionsCount()
        {
            int completedQuestions = dtQuestion.AsEnumerable().Count(row => !string.IsNullOrEmpty(row["SelectedOption"].ToString()));
            lb_socau.Text = $"Số câu đã làm: {completedQuestions}/{Session.NumberOfQuestion}";
        }

        /// <summary>
        /// Lưu đáp án đã chọn
        /// </summary>
        private void SaveCurrentSelected()
        {
            if (isUpdatingOption) // Kiểm tra nếu đang cập nhật, tránh đệ quy
                return;

            if (selectedIndex >= 0 && selectedIndex < dtQuestion.Rows.Count)
            {
                isUpdatingOption = true; // Đặt cờ trước khi cập nhật

                // Cập nhật lựa chọn hiện tại
                dtQuestion.Rows[selectedIndex]["SelectedOption"] = GetSelectOption();

                UpdateCompletedQuestionsCount(); // Cập nhật số câu đã làm

                // Yêu cầu lsb_Question vẽ lại
                lsb_Question.Invalidate();

                isUpdatingOption = false; // Hủy cờ sau khi hoàn thành
            }
        }

        /// <summary>
        /// Hiển thị chi tiết câu hỏi
        /// </summary>
        private void ShowDetailQuestion()
        {
            try
            {
                int.TryParse(lsb_Question.SelectedValue.ToString(), out int questionId);
                if (questionId < 1)
                {
                    return;
                }

                //Lưu lại phương án đã chọn
                SaveCurrentSelected();

                selectedIndex = lsb_Question.SelectedIndex;

                btn_NextQuestion.Enabled = (selectedIndex < Session.NumberOfQuestion - 1);
                btn_PreviousQuestion.Enabled = (selectedIndex > 0);

                lbl_Question.Text = lsb_Question.Text;
                Question selectQuestion = BQuestion.GetOne(questionId);
                rtxt_Question.Text = selectQuestion.QContent;
                rdb_OptionA.Text = "A. " + selectQuestion.OptionA;
                rdb_OptionB.Text = "B. " + selectQuestion.OptionB;
                rdb_OptionC.Text = "C. " + selectQuestion.OptionC;
                rdb_OptionD.Text = "D. " + selectQuestion.OptionD;

                rdb_OptionA.Checked = rdb_OptionB.Checked = rdb_OptionC.Checked = rdb_OptionD.Checked = false;

                LoadPrevSelectOption();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        /// <summary>
        /// Khi chọn câu hỏi trong lsb_Question, sẽ hiển thị chi tiết câu hỏi đó.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lsb_Question_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isRaiseSelectedEvent)
                ShowDetailQuestion();
        }

        /// <summary>
        /// Các sự kiện chuyển câu hỏi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_FirstQuestion_Click(object sender, EventArgs e)
        {
            lsb_Question.SelectedIndex = 0;
        }

        private void btn_LastQuestion_Click(object sender, EventArgs e)
        {
            lsb_Question.SelectedIndex = Session.NumberOfQuestion - 1;
        }

        private void btn_NextQuestion_Click(object sender, EventArgs e)
        {
            if (selectedIndex < Session.NumberOfQuestion - 1)
                lsb_Question.SelectedIndex = selectedIndex + 1;
        }

        private void btn_PreviousQuestion_Click(object sender, EventArgs e)
        {
            if (selectedIndex > 0)
                lsb_Question.SelectedIndex = selectedIndex - 1;
        }

        /// <summary>
        /// Đếm ngược thời gian
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTest_Tick(object sender, EventArgs e)
        {
            //giảm dần thời gian
            remainTime--;
            int remainMinute = remainTime / 60;
            string strRemainTime = (remainMinute < 10 ? "0" : string.Empty) + $"{remainMinute}:{remainTime % 60}";
            txt_Time.Text = strRemainTime;

            if (remainTime <= 0)
                FinishTest();
        }

        /// <summary>
        /// Kết thúc bài thi
        /// </summary>
        private void FinishTest()
        {
            isRaiseSelectedEvent = false;
            SaveCurrentSelected();

            int correctAnswer = 0;
            float mark = 0;
            foreach (DataRow row in dtQuestion.Rows)
            {
                string answer = row["Answer"].ToString();
                string selectedOption = row["SelectedOption"].ToString();
                selectedOption = selectedOption.Length > 0 ? selectedOption.Substring(3) : selectedOption;
                if (selectedOption.Equals(answer))
                    correctAnswer++;
            }
            mark = (float)correctAnswer * 10 / Session.NumberOfQuestion;

            // Cập nhật trạng thái người dùng trong kỳ thi
            BUserExamSession.UpdateStatus(
                Session.LogonUser.UserID,
                Session.SessionID,
                "Completed",
                null,
                DateTime.Now,
                Session.LogonUser.Username
            );

            frmTestResult fmTestResult = new frmTestResult(correctAnswer, mark);

            this.Hide();

            fmTestResult.ShowDialog();
        }

        private void btn_NopBai_Click(object sender, EventArgs e)
        {
            if (dtQuestion.AsEnumerable().Any(row => string.IsNullOrEmpty(row["SelectedOption"].ToString())))
            {
                XtraMessageBox.Show("Bạn phải làm hết các câu hỏi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (XtraMessageBox.Show("Bạn có chắc muốn nộp bài?", "Xác nhận!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            FinishTest();
        }

        public void SetSwitchingToMainFlag(bool flag)
        {
            isSwitchingToMain = flag; // Hàm để nhận giá trị cờ từ frmTestResult
        }

        private void frmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận nếu là "User"
            if (Session.LogonUser.RoleID.Equals("User"))
            {
                DialogResult result = XtraMessageBox.Show("Bạn có chắc chắn muốn dừng làm bài không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Hủy quá trình đóng form
                    return;
                }
                else
                {
                    Application.ExitThread(); // Thoát nếu là User
                }
            }
            else
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
        }

        private void rdb_OptionA_CheckedChanged(object sender, EventArgs e)
        {
            if (!isUpdatingOption && rdb_OptionA.Checked)
            {
                SaveCurrentSelected();
            }
        }

        private void rdb_OptionB_CheckedChanged(object sender, EventArgs e)
        {
            if (!isUpdatingOption && rdb_OptionB.Checked)
            {
                SaveCurrentSelected();
            }
        }

        private void rdb_OptionC_CheckedChanged(object sender, EventArgs e)
        {
            if (!isUpdatingOption && rdb_OptionC.Checked)
            {
                SaveCurrentSelected();
            }
        }

        private void rdb_OptionD_CheckedChanged(object sender, EventArgs e)
        {
            if (!isUpdatingOption && rdb_OptionD.Checked)
            {
                SaveCurrentSelected();
            }
        }

        private void lsb_Question_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0 || e.Index >= dtQuestion.Rows.Count)
                return;

            Graphics g = e.Graphics;

            // Lấy DataRow của câu hỏi hiện tại
            DataRow row = dtQuestion.Rows[e.Index];

            // Lấy text hiển thị (số thứ tự câu hỏi)
            string text = row["QuestionIndex"].ToString();

            // Kiểm tra xem câu hỏi đã được trả lời chưa
            bool isAnswered = !string.IsNullOrEmpty(row["SelectedOption"].ToString());

            // Xác định màu chữ
            Color textColor = isAnswered ? Color.Green : Color.Black;

            // Vẽ nền mục được chọn
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                g.FillRectangle(new SolidBrush(SystemColors.Highlight), e.Bounds);
            }
            else
            {
                g.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
            }

            // Vẽ text
            TextRenderer.DrawText(g, text, e.Font, e.Bounds, textColor, TextFormatFlags.Left);

            // Vẽ khung focus nếu cần
            e.DrawFocusRectangle();
        }
    }
}
