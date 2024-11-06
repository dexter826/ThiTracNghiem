using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using TestCore;

namespace ThiTracNghiem
{
    public partial class frmRestore : DevExpress.XtraEditors.XtraForm
    {
        public frmRestore()
        {
            InitializeComponent();
        }

        private void frmRestore_Load(object sender, EventArgs e)
        {
            txt_file.Enabled = false;
            btn_Restore.Enabled = false;
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Backup file (.bak)|*.bak";
            openFile.Title = "Phục hồi dữ liệu";
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                txt_file.Text = openFile.FileName;
                btn_Restore.Enabled = true;
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            // Hiển thị SplashScreen trước khi hiển thị form đăng nhập
            SplashScreenManager.ShowForm(typeof(frmLoad));

            // Mô phỏng thời gian xử lý với Thread.Sleep (để test hiển thị SplashScreen)
            System.Threading.Thread.Sleep(3000); // Tạm dừng 3 giây

            string sourceConnectionString = ConnectionString.strCon;
            SqlConnection connection = new SqlConnection(sourceConnectionString);
            string data = connection.Database.ToString();
            connection.Open();
            try
            {

                string sql1 = "ALTER DATABASE [" + data + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                SqlCommand cmd1 = new SqlCommand(sql1, connection);
                cmd1.ExecuteNonQuery();

                string sql2 = "USE MASTER RESTORE DATABASE [" + data + "] FROM DISK ='" + txt_file.Text + "' WITH REPLACE";
                SqlCommand cmd2 = new SqlCommand(sql2, connection);
                cmd2.ExecuteNonQuery();

                string sql3 = "ALTER DATABASE [" + data + "] SET MULTI_USER";
                SqlCommand cmd3 = new SqlCommand(sql3, connection);
                cmd3.ExecuteNonQuery();

                connection.Close();

                // Đóng SplashScreen
                SplashScreenManager.CloseForm();

                XtraMessageBox.Show("Khôi phục dữ liệu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Restore.Enabled = false;
            }
            catch (Exception ex)
            {
                // Đóng SplashScreen
                SplashScreenManager.CloseForm();

                btn_Restore.Enabled = false;
                XtraMessageBox.Show($"Khôi phục dữ liệu không thành công!\nLỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}