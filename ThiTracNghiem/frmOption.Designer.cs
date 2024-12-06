namespace ThiTracNghiem
{
    partial class frmOption
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOption));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_Subject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Time = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Start = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Exit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txt_NumberQuestion = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(118, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lựa chọn thi trắc nghiệm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(38, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Môn thi";
            // 
            // cbb_Subject
            // 
            this.cbb_Subject.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Subject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Subject.BorderRadius = 5;
            this.cbb_Subject.BorderThickness = 2;
            this.cbb_Subject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Subject.FocusedColor = System.Drawing.Color.Empty;
            this.cbb_Subject.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.cbb_Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Subject.FormattingEnabled = true;
            this.cbb_Subject.ItemHeight = 30;
            this.cbb_Subject.Location = new System.Drawing.Point(195, 189);
            this.cbb_Subject.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbb_Subject.Name = "cbb_Subject";
            this.cbb_Subject.Size = new System.Drawing.Size(315, 36);
            this.cbb_Subject.TabIndex = 2;
            this.cbb_Subject.SelectedIndexChanged += new System.EventHandler(this.cbb_Subject_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(38, 250);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng câu hỏi";
            // 
            // txt_Time
            // 
            this.txt_Time.BackColor = System.Drawing.Color.Transparent;
            this.txt_Time.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Time.BorderRadius = 5;
            this.txt_Time.BorderThickness = 2;
            this.txt_Time.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Time.DefaultText = "";
            this.txt_Time.Enabled = false;
            this.txt_Time.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txt_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Time.Location = new System.Drawing.Point(195, 293);
            this.txt_Time.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_Time.Name = "txt_Time";
            this.txt_Time.PasswordChar = '\0';
            this.txt_Time.PlaceholderText = "";
            this.txt_Time.ReadOnly = true;
            this.txt_Time.SelectedText = "";
            this.txt_Time.Size = new System.Drawing.Size(315, 35);
            this.txt_Time.TabIndex = 6;
            this.txt_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Time_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(38, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thời gian thi(phút)";
            // 
            // btn_Start
            // 
            this.btn_Start.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Start.BackColor = System.Drawing.Color.Transparent;
            this.btn_Start.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Start.BorderRadius = 20;
            this.btn_Start.BorderThickness = 2;
            this.btn_Start.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.btn_Start.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Start.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Start.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_Start.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Start.Location = new System.Drawing.Point(105, 346);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.ShadowDecoration.BorderRadius = 20;
            this.btn_Start.ShadowDecoration.Depth = 10;
            this.btn_Start.ShadowDecoration.Enabled = true;
            this.btn_Start.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Start.Size = new System.Drawing.Size(161, 44);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "Bắt đầu thi";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BorderRadius = 20;
            this.btn_Exit.BorderThickness = 2;
            this.btn_Exit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.btn_Exit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Exit.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Exit.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_Exit.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Exit.Location = new System.Drawing.Point(283, 346);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ShadowDecoration.BorderRadius = 20;
            this.btn_Exit.ShadowDecoration.Depth = 10;
            this.btn_Exit.ShadowDecoration.Enabled = true;
            this.btn_Exit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Exit.Size = new System.Drawing.Size(161, 44);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::ThiTracNghiem.Properties.Resources.option;
            this.pictureEdit1.Location = new System.Drawing.Point(105, -16);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(325, 174);
            this.pictureEdit1.TabIndex = 9;
            // 
            // txt_NumberQuestion
            // 
            this.txt_NumberQuestion.BackColor = System.Drawing.Color.Transparent;
            this.txt_NumberQuestion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NumberQuestion.BorderRadius = 5;
            this.txt_NumberQuestion.BorderThickness = 2;
            this.txt_NumberQuestion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NumberQuestion.DefaultText = "";
            this.txt_NumberQuestion.Enabled = false;
            this.txt_NumberQuestion.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txt_NumberQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_NumberQuestion.Location = new System.Drawing.Point(195, 242);
            this.txt_NumberQuestion.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txt_NumberQuestion.Name = "txt_NumberQuestion";
            this.txt_NumberQuestion.PasswordChar = '\0';
            this.txt_NumberQuestion.PlaceholderText = "";
            this.txt_NumberQuestion.ReadOnly = true;
            this.txt_NumberQuestion.SelectedText = "";
            this.txt_NumberQuestion.Size = new System.Drawing.Size(315, 35);
            this.txt_NumberQuestion.TabIndex = 10;
            // 
            // frmOption
            // 
            this.AcceptButton = this.btn_Start;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 416);
            this.Controls.Add(this.txt_NumberQuestion);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbb_Subject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureEdit1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmOption.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(565, 455);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(551, 448);
            this.Name = "frmOption";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thi trắc nghiệm";
            this.Load += new System.EventHandler(this.frmOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Subject;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_Time;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Start;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Exit;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private Guna.UI2.WinForms.Guna2TextBox txt_NumberQuestion;
    }
}