using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestCore;

namespace ThiTracNghiem
{
    public partial class frmBackUp : DevExpress.XtraEditors.XtraForm
    {
        public frmBackUp()
        {
            InitializeComponent();
        }

        private void frmBackUp_Load(object sender, EventArgs e)
        {
            txt_file.Enabled = false;
            btn_Backup.Enabled = false;
        }

        private void txt_file_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                txt_file.Text = dialog.SelectedPath;
                btn_Backup.Enabled = true;
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            try
            {
                // Hiển thị SplashScreen trước khi hiển thị form đăng nhập
                SplashScreenManager.ShowForm(typeof(frmLoad));

                // Mô phỏng thời gian xử lý với Thread.Sleep (để test hiển thị SplashScreen)
                System.Threading.Thread.Sleep(3000); // Tạm dừng 3 giây

                string sourceConnectionString = ConnectionString.strCon;
                SqlConnection connection = new SqlConnection(sourceConnectionString);
                string data = connection.Database.ToString();
                if (string.IsNullOrEmpty(txt_file.Text))
                {
                    XtraMessageBox.Show("Vui lòng chọn đường dẫn lưu file!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string sql = "BACKUP DATABASE [" + data + "] TO DISK ='" + txt_file.Text + "\\" + data + "-" + DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss") + ".bak'";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sql, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    // Đóng SplashScreen
                    SplashScreenManager.CloseForm();

                    XtraMessageBox.Show("Sao lưu dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_Backup.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                // Đóng SplashScreen
                SplashScreenManager.CloseForm();
                btn_Backup.Enabled = false;
                XtraMessageBox.Show($"Sao lưu dữ liệu không thành công!\nLỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}