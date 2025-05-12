namespace ThiTracNghiem
{
    partial class NewFrmReportExamSession
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbb_ExamSession = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_ViewReport = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_ExportPDF = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Print = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.pnl_Report = new System.Windows.Forms.Panel();
            this.grv_Users = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.lbl_SessionName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Users)).BeginInit();
            this.SuspendLayout();
            // 
            // cbb_ExamSession
            // 
            this.cbb_ExamSession.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_ExamSession.BackColor = System.Drawing.Color.Transparent;
            this.cbb_ExamSession.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_ExamSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ExamSession.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_ExamSession.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_ExamSession.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_ExamSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_ExamSession.ItemHeight = 30;
            this.cbb_ExamSession.Location = new System.Drawing.Point(124, 20);
            this.cbb_ExamSession.Name = "cbb_ExamSession";
            this.cbb_ExamSession.Size = new System.Drawing.Size(300, 36);
            this.cbb_ExamSession.TabIndex = 0;
            // 
            // btn_ViewReport
            // 
            this.btn_ViewReport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ViewReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ViewReport.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ViewReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ViewReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ViewReport.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ViewReport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ViewReport.ForeColor = System.Drawing.Color.White;
            this.btn_ViewReport.Location = new System.Drawing.Point(450, 20);
            this.btn_ViewReport.Name = "btn_ViewReport";
            this.btn_ViewReport.Size = new System.Drawing.Size(180, 36);
            this.btn_ViewReport.TabIndex = 1;
            this.btn_ViewReport.Text = "Xem báo cáo";
            this.btn_ViewReport.Click += new System.EventHandler(this.btn_ViewReport_Click);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(20, 20);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(98, 36);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "Chọn kỳ thi:";
            // 
            // btn_ExportPDF
            // 
            this.btn_ExportPDF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ExportPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ExportPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ExportPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ExportPDF.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ExportPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ExportPDF.Enabled = false;
            this.btn_ExportPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ExportPDF.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_ExportPDF.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ExportPDF.ForeColor = System.Drawing.Color.White;
            this.btn_ExportPDF.Location = new System.Drawing.Point(850, 20);
            this.btn_ExportPDF.Name = "btn_ExportPDF";
            this.btn_ExportPDF.Size = new System.Drawing.Size(180, 36);
            this.btn_ExportPDF.TabIndex = 3;
            this.btn_ExportPDF.Text = "Xuất PDF";
            this.btn_ExportPDF.Click += new System.EventHandler(this.btn_ExportPDF_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Print.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Print.Enabled = false;
            this.btn_Print.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Print.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Print.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.Location = new System.Drawing.Point(650, 20);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(180, 36);
            this.btn_Print.TabIndex = 4;
            this.btn_Print.Text = "In báo cáo";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // pnl_Report
            // 
            this.pnl_Report.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Report.Controls.Add(this.grv_Users);
            this.pnl_Report.Controls.Add(this.lbl_Status);
            this.pnl_Report.Controls.Add(this.lbl_EndTime);
            this.pnl_Report.Controls.Add(this.lbl_StartTime);
            this.pnl_Report.Controls.Add(this.lbl_SessionName);
            this.pnl_Report.Controls.Add(this.label4);
            this.pnl_Report.Controls.Add(this.label3);
            this.pnl_Report.Controls.Add(this.label2);
            this.pnl_Report.Controls.Add(this.label1);
            this.pnl_Report.Location = new System.Drawing.Point(20, 70);
            this.pnl_Report.Name = "pnl_Report";
            this.pnl_Report.Size = new System.Drawing.Size(1010, 600);
            this.pnl_Report.TabIndex = 5;
            this.pnl_Report.Visible = false;
            // 
            // grv_Users
            // 
            this.grv_Users.AllowUserToAddRows = false;
            this.grv_Users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_Users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_Users.ColumnHeadersHeight = 20;
            this.grv_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Users.DefaultCellStyle = dataGridViewCellStyle3;
            this.grv_Users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Users.Location = new System.Drawing.Point(20, 159);
            this.grv_Users.Name = "grv_Users";
            this.grv_Users.ReadOnly = true;
            this.grv_Users.RowHeadersVisible = false;
            this.grv_Users.RowHeadersWidth = 51;
            this.grv_Users.RowTemplate.Height = 24;
            this.grv_Users.Size = new System.Drawing.Size(970, 421);
            this.grv_Users.TabIndex = 9;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_Users.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Users.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Users.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Users.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_Users.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_Users.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Users.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Users.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Users.ThemeStyle.HeaderStyle.Height = 20;
            this.grv_Users.ThemeStyle.ReadOnly = true;
            this.grv_Users.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Users.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Users.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Users.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_Users.ThemeStyle.RowsStyle.Height = 24;
            this.grv_Users.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Users.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(150, 140);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(44, 16);
            this.lbl_Status.TabIndex = 7;
            this.lbl_Status.Text = "label8";
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.Location = new System.Drawing.Point(150, 100);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(44, 16);
            this.lbl_EndTime.TabIndex = 6;
            this.lbl_EndTime.Text = "label7";
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.Location = new System.Drawing.Point(150, 60);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(44, 16);
            this.lbl_StartTime.TabIndex = 5;
            this.lbl_StartTime.Text = "label6";
            // 
            // lbl_SessionName
            // 
            this.lbl_SessionName.AutoSize = true;
            this.lbl_SessionName.Location = new System.Drawing.Point(150, 20);
            this.lbl_SessionName.Name = "lbl_SessionName";
            this.lbl_SessionName.Size = new System.Drawing.Size(44, 16);
            this.lbl_SessionName.TabIndex = 4;
            this.lbl_SessionName.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Thời gian kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian bắt đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên kỳ thi:";
            // 
            // NewFrmReportExamSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnl_Report);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_ExportPDF);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btn_ViewReport);
            this.Controls.Add(this.cbb_ExamSession);
            this.Name = "NewFrmReportExamSession";
            this.Size = new System.Drawing.Size(1050, 700);
            this.Load += new System.EventHandler(this.NewFrmReportExamSession_Load);
            this.pnl_Report.ResumeLayout(false);
            this.pnl_Report.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbb_ExamSession;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_ViewReport;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_ExportPDF;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Print;
        private System.Windows.Forms.Panel pnl_Report;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_EndTime;
        private System.Windows.Forms.Label lbl_StartTime;
        private System.Windows.Forms.Label lbl_SessionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        private Guna.UI2.WinForms.Guna2DataGridView grv_Users;
    }
}
