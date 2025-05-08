namespace ThiTracNghiem
{
    partial class frmApproveExam
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
            this.cbb_Status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.grv_Exams = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuestion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ViewDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Approve = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Reject = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Exams)).BeginInit();
            this.SuspendLayout();
            //
            // cbb_Status
            //
            this.cbb_Status.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbb_Status.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Status.ItemHeight = 30;
            this.cbb_Status.Location = new System.Drawing.Point(256, 22);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(200, 36);
            this.cbb_Status.TabIndex = 0;
            this.cbb_Status.SelectedIndexChanged += new System.EventHandler(this.cbb_Status_SelectedIndexChanged);
            //
            // guna2HtmlLabel1
            //
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(182, 30);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(68, 20);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Trạng thái";
            //
            // grv_Exams
            //
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_Exams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_Exams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Exams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_Exams.ColumnHeadersHeight = 40;
            this.grv_Exams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Exams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ExamID,
            this.ExamName,
            this.SubjectName,
            this.TimeLimit,
            this.TotalQuestion,
            this.CreatedBy,
            this.CreatedAt,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Exams.DefaultCellStyle = dataGridViewCellStyle3;
            this.grv_Exams.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_Exams.Location = new System.Drawing.Point(3, 80);
            this.grv_Exams.Name = "grv_Exams";
            this.grv_Exams.ReadOnly = true;
            this.grv_Exams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_Exams.RowHeadersVisible = false;
            this.grv_Exams.RowTemplate.Height = 40;
            this.grv_Exams.Size = new System.Drawing.Size(1089, 542);
            this.grv_Exams.TabIndex = 2;
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Exams.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Exams.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_Exams.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_Exams.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_Exams.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Exams.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Exams.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_Exams.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_Exams.ThemeStyle.ReadOnly = true;
            this.grv_Exams.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Exams.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Exams.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Exams.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_Exams.ThemeStyle.RowsStyle.Height = 40;
            this.grv_Exams.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.grv_Exams.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            this.grv_Exams.SelectionChanged += new System.EventHandler(this.grv_Exams_SelectionChanged);
            //
            // Column1
            //
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            //
            // ExamID
            //
            this.ExamID.DataPropertyName = "ExamID";
            this.ExamID.HeaderText = "Mã đề thi";
            this.ExamID.Name = "ExamID";
            this.ExamID.Visible = false;
            //
            // ExamName
            //
            this.ExamName.DataPropertyName = "ExamName";
            this.ExamName.HeaderText = "Tên đề thi";
            this.ExamName.Name = "ExamName";
            //
            // SubjectName
            //
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Môn học";
            this.SubjectName.Name = "SubjectName";
            //
            // TimeLimit
            //
            this.TimeLimit.DataPropertyName = "TimeLimit";
            this.TimeLimit.HeaderText = "Thời gian làm bài";
            this.TimeLimit.Name = "TimeLimit";
            //
            // TotalQuestion
            //
            this.TotalQuestion.DataPropertyName = "TotalQuestion";
            this.TotalQuestion.HeaderText = "Số lượng câu hỏi";
            this.TotalQuestion.Name = "TotalQuestion";
            //
            // CreatedBy
            //
            this.CreatedBy.DataPropertyName = "CreatedBy";
            this.CreatedBy.HeaderText = "Người tạo";
            this.CreatedBy.Name = "CreatedBy";
            //
            // CreatedAt
            //
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Ngày tạo";
            this.CreatedAt.Name = "CreatedAt";
            //
            // Status
            //
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.Name = "Status";
            //
            // btn_ViewDetail
            //
            this.btn_ViewDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ViewDetail.BackColor = System.Drawing.Color.Transparent;
            this.btn_ViewDetail.BorderRadius = 8;
            this.btn_ViewDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ViewDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ViewDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewDetail.ForeColor = System.Drawing.Color.White;
            this.btn_ViewDetail.Location = new System.Drawing.Point(469, 22);
            this.btn_ViewDetail.Name = "btn_ViewDetail";
            this.btn_ViewDetail.ShadowDecoration.BorderRadius = 20;
            this.btn_ViewDetail.ShadowDecoration.Depth = 10;
            this.btn_ViewDetail.ShadowDecoration.Enabled = true;
            this.btn_ViewDetail.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_ViewDetail.Size = new System.Drawing.Size(139, 36);
            this.btn_ViewDetail.TabIndex = 3;
            this.btn_ViewDetail.Text = "Xem chi tiết";
            this.btn_ViewDetail.Click += new System.EventHandler(this.btn_ViewDetail_Click);
            //
            // btn_Approve
            //
            this.btn_Approve.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Approve.BackColor = System.Drawing.Color.Transparent;
            this.btn_Approve.BorderRadius = 8;
            this.btn_Approve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Approve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Approve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Approve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Approve.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Approve.ForeColor = System.Drawing.Color.White;
            this.btn_Approve.Location = new System.Drawing.Point(636, 22);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.ShadowDecoration.BorderRadius = 20;
            this.btn_Approve.ShadowDecoration.Depth = 10;
            this.btn_Approve.ShadowDecoration.Enabled = true;
            this.btn_Approve.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Approve.Size = new System.Drawing.Size(119, 36);
            this.btn_Approve.TabIndex = 4;
            this.btn_Approve.Text = "Duyệt";
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            //
            // btn_Reject
            //
            this.btn_Reject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Reject.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reject.BorderRadius = 8;
            this.btn_Reject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Reject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reject.ForeColor = System.Drawing.Color.White;
            this.btn_Reject.Location = new System.Drawing.Point(783, 22);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.ShadowDecoration.BorderRadius = 20;
            this.btn_Reject.ShadowDecoration.Depth = 10;
            this.btn_Reject.ShadowDecoration.Enabled = true;
            this.btn_Reject.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Reject.Size = new System.Drawing.Size(119, 36);
            this.btn_Reject.TabIndex = 5;
            this.btn_Reject.Text = "Từ chối";
            this.btn_Reject.Click += new System.EventHandler(this.btn_Reject_Click);
            //
            // frmApproveExam
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Reject);
            this.Controls.Add(this.btn_Approve);
            this.Controls.Add(this.btn_ViewDetail);
            this.Controls.Add(this.grv_Exams);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.cbb_Status);
            this.Name = "frmApproveExam";
            this.Size = new System.Drawing.Size(1095, 625);
            this.Load += new System.EventHandler(this.frmApproveExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Exams)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbb_Status;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView grv_Exams;
        private Guna.UI2.WinForms.Guna2Button btn_ViewDetail;
        private Guna.UI2.WinForms.Guna2Button btn_Approve;
        private Guna.UI2.WinForms.Guna2Button btn_Reject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuestion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}
