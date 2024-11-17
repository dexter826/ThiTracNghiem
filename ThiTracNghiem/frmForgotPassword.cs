using BusinessLogicLayer;
using DevExpress.XtraEditors;
using Entities;
using System;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiTracNghiem
{
    public partial class frmForgotPassword : XtraForm
    {
        private string _otp = string.Empty;
        private int _remainingTime = 60;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Kiểm tra regex Email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private bool IsValidEmail(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    return false;

                // Sử dụng biểu thức chính quy để kiểm tra định dạng email
                var emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return System.Text.RegularExpressions.Regex.IsMatch(email, emailRegex);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Tạo mã otp
        /// </summary>
        /// <returns></returns>
        private string GenerateOtp()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        /// <summary>
        /// Gửi email xác nhận
        /// </summary>
        /// <param name="email"></param>
        /// <param name="otp"></param>
        /// <returns></returns>
        private bool SendEmail(string email, string otp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com"); // Cập nhật với SMTP server của bạn
                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("leductrung0907@gmail.com", "maed qojq aphc phau");
                smtpServer.EnableSsl = true;

                mail.From = new MailAddress("leductrung0907@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Mã xác nhận quên mật khẩu";
                mail.Body = $"Mã xác nhận của bạn là: {otp}";

                smtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show($"Lỗi khi gửi email: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private async void btn_SendOtp_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text.Trim();

            // Kiểm tra kiểu email
            if (!IsValidEmail(email))
            {
                XtraMessageBox.Show("Email không hợp lệ! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra email tồn tại trong hệ thống
            if (!BUserAccount.IsEmailExists(email))
            {
                XtraMessageBox.Show("Email không tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _otp = GenerateOtp();

            if (SendEmail(email, _otp))
            {
                XtraMessageBox.Show("Mã xác nhận đã được gửi đến email của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Vô hiệu hóa nút gửi OTP trong 60 giây
                btn_SendOtp.Enabled = false;

                // Hiển thị thời gian đếm ngược
                lbl_Timer.Visible = true;
                lbl_Timer.Text = $"{_remainingTime}";

                // Sử dụng Timer để cập nhật thời gian
                Timer countdownTimer = new Timer();
                countdownTimer.Interval = 1000; // Mỗi giây
                countdownTimer.Tick += (s, args) =>
                {
                    if (_remainingTime > 0)
                    {
                        _remainingTime--;
                        lbl_Timer.Text = $"{_remainingTime}";
                    }
                    else
                    {
                        countdownTimer.Stop();
                        btn_SendOtp.Enabled = true; // Kích hoạt lại nút gửi OTP
                        lbl_Timer.Visible = false; // Ẩn thời gian đếm ngược
                    }
                };

                countdownTimer.Start();
            }
        }

        private void btn_VerifyOtp_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text.Trim();
            string enteredOtp = txt_Otp.Text.Trim(); // Lấy mã OTP người dùng nhập

            if (string.IsNullOrEmpty(txt_Otp.Text))
            {
                XtraMessageBox.Show("Vui lòng nhập mã xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra OTP
            if (_otp != enteredOtp)
            {
                XtraMessageBox.Show("Mã xác nhận không chính xác. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserAccount userAccount = BUserAccount.GetPasswordByEmail(email);

                if (userAccount != null && !string.IsNullOrEmpty(userAccount.Password))
                {
                    XtraMessageBox.Show($"Mật khẩu của bạn là: {userAccount.Password}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Không tìm thấy tài khoản với email này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}