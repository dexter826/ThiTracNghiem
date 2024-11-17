namespace ThiTracNghiem
{
    partial class frmBackUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBackUp));
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_file = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Backup = new Guna.UI2.WinForms.Guna2TileButton();
            this.btn_Browse = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(51, 35);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(152, 24);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Đường dẫn lưu file";
            // 
            // txt_file
            // 
            this.txt_file.BorderRadius = 5;
            this.txt_file.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_file.DefaultText = "";
            this.txt_file.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_file.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_file.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_file.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_file.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_file.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_file.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_file.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_file.Location = new System.Drawing.Point(210, 29);
            this.txt_file.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txt_file.Name = "txt_file";
            this.txt_file.PasswordChar = '\0';
            this.txt_file.PlaceholderText = "";
            this.txt_file.SelectedText = "";
            this.txt_file.Size = new System.Drawing.Size(497, 37);
            this.txt_file.TabIndex = 1;
            // 
            // btn_Backup
            // 
            this.btn_Backup.BackColor = System.Drawing.Color.Transparent;
            this.btn_Backup.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Backup.BorderRadius = 10;
            this.btn_Backup.BorderThickness = 2;
            this.btn_Backup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Backup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Backup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Backup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Backup.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backup.ForeColor = System.Drawing.Color.White;
            this.btn_Backup.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Backup.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Backup.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Backup.Image = global::ThiTracNghiem.Properties.Resources.cloud_backup;
            this.btn_Backup.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Backup.ImageOffset = new System.Drawing.Point(0, 18);
            this.btn_Backup.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Backup.Location = new System.Drawing.Point(367, 87);
            this.btn_Backup.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.ShadowDecoration.BorderRadius = 8;
            this.btn_Backup.ShadowDecoration.Depth = 7;
            this.btn_Backup.ShadowDecoration.Enabled = true;
            this.btn_Backup.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Backup.Size = new System.Drawing.Size(156, 52);
            this.btn_Backup.TabIndex = 3;
            this.btn_Backup.Text = "Backup";
            this.btn_Backup.TextOffset = new System.Drawing.Point(18, -20);
            this.btn_Backup.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.BorderRadius = 5;
            this.btn_Browse.BorderThickness = 2;
            this.btn_Browse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Browse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Browse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Browse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Browse.FillColor = System.Drawing.Color.White;
            this.btn_Browse.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Browse.Image = global::ThiTracNghiem.Properties.Resources.Search;
            this.btn_Browse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Browse.ImageOffset = new System.Drawing.Point(0, 13);
            this.btn_Browse.Location = new System.Drawing.Point(732, 29);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(107, 37);
            this.btn_Browse.TabIndex = 2;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_Browse.TextOffset = new System.Drawing.Point(0, -13);
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // frmBackUp
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 169);
            this.Controls.Add(this.btn_Backup);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_Browse);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmBackUp.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(892, 209);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(892, 201);
            this.Name = "frmBackUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sao lưu dữ liệu";
            this.Load += new System.EventHandler(this.frmBackUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton btn_Browse;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_file;
        private Guna.UI2.WinForms.Guna2TileButton btn_Backup;
    }
}