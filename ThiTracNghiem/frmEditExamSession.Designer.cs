namespace ThiTracNghiem
{
    partial class frmEditExamSession
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
            this.groupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbl_ExamInfo = new System.Windows.Forms.Label();
            this.dtp_EndTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_StartTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_SessionName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.cbb_Exam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BorderRadius = 5;
            this.groupBox1.Controls.Add(this.cbb_Exam);
            this.groupBox1.Controls.Add(this.lbl_ExamInfo);
            this.groupBox1.Controls.Add(this.dtp_EndTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_StartTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_SessionName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Text = "Thông tin kỳ thi";
            // 
            // lbl_ExamInfo
            //
            this.lbl_ExamInfo.AutoSize = true;
            this.lbl_ExamInfo.Location = new System.Drawing.Point(12, 204);
            this.lbl_ExamInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ExamInfo.Name = "lbl_ExamInfo";
            this.lbl_ExamInfo.Size = new System.Drawing.Size(41, 15);
            this.lbl_ExamInfo.TabIndex = 6;
            this.lbl_ExamInfo.Text = "Đề thi:";
            // 
            // dtp_EndTime
            // 
            this.dtp_EndTime.BorderRadius = 5;
            this.dtp_EndTime.Checked = true;
            this.dtp_EndTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_EndTime.FillColor = System.Drawing.Color.White;
            this.dtp_EndTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_EndTime.Location = new System.Drawing.Point(133, 148);
            this.dtp_EndTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_EndTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_EndTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_EndTime.Name = "dtp_EndTime";
            this.dtp_EndTime.Size = new System.Drawing.Size(314, 36);
            this.dtp_EndTime.TabIndex = 5;
            this.dtp_EndTime.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thời gian kết thúc:";
            // 
            // dtp_StartTime
            // 
            this.dtp_StartTime.BorderRadius = 5;
            this.dtp_StartTime.Checked = true;
            this.dtp_StartTime.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_StartTime.FillColor = System.Drawing.Color.White;
            this.dtp_StartTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_StartTime.Location = new System.Drawing.Point(133, 103);
            this.dtp_StartTime.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_StartTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_StartTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_StartTime.Name = "dtp_StartTime";
            this.dtp_StartTime.Size = new System.Drawing.Size(314, 36);
            this.dtp_StartTime.TabIndex = 3;
            this.dtp_StartTime.Value = new System.DateTime(2023, 7, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thời gian bắt đầu:";
            // 
            // txt_SessionName
            // 
            this.txt_SessionName.BorderRadius = 5;
            this.txt_SessionName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SessionName.DefaultText = "";
            this.txt_SessionName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SessionName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SessionName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SessionName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SessionName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SessionName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SessionName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SessionName.Location = new System.Drawing.Point(133, 58);
            this.txt_SessionName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_SessionName.Name = "txt_SessionName";
            this.txt_SessionName.PasswordChar = '\0';
            this.txt_SessionName.PlaceholderText = "";
            this.txt_SessionName.SelectedText = "";
            this.txt_SessionName.Size = new System.Drawing.Size(314, 36);
            this.txt_SessionName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kỳ thi:";
            // 
            // btn_Save
            // 
            this.btn_Save.BorderRadius = 5;
            this.btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Save.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(165, 258);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 32);
            this.btn_Save.TabIndex = 1;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BorderRadius = 5;
            this.btn_Cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_Cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(244, 258);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 32);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // cbb_Exam
            // 
            this.cbb_Exam.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Exam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Exam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Exam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Exam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Exam.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Exam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Exam.ItemHeight = 30;
            this.cbb_Exam.Location = new System.Drawing.Point(133, 193);
            this.cbb_Exam.Name = "cbb_Exam";
            this.cbb_Exam.Size = new System.Drawing.Size(314, 36);
            this.cbb_Exam.TabIndex = 7;
            // 
            // frmEditExamSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 301);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditExamSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chỉnh sửa kỳ thi";
            this.Load += new System.EventHandler(this.frmEditExamSession_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_ExamInfo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_EndTime;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_StartTime;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_SessionName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Save;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Cancel;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Exam;
    }
}
