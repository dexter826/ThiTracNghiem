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
            this.btn_ViewDetail = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Approve = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Reject = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Exams)).BeginInit();
            this.SuspendLayout();
            //
            // cbb_Status
            //
            this.cbb_Status.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbb_Status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbb_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Status.ItemHeight = 30;
            this.cbb_Status.Location = new System.Drawing.Point(137, 38);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(140, 36);
            this.cbb_Status.TabIndex = 0;
            this.cbb_Status.SelectedIndexChanged += new System.EventHandler(this.cbb_Status_SelectedIndexChanged);
            //
            // guna2HtmlLabel1
            //
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(80, 50);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(51, 15);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Trạng thái";
            //
            // grv_Exams
            //
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.grv_Exams.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_Exams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_Exams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Exams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_Exams.DefaultCellStyle = dataGridViewCellStyle3;
            this.grv_Exams.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Exams.Location = new System.Drawing.Point(37, 159);
            this.grv_Exams.Name = "grv_Exams";
            this.grv_Exams.RowHeadersVisible = false;
            this.grv_Exams.Size = new System.Drawing.Size(1029, 434);
            this.grv_Exams.TabIndex = 2;
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_Exams.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_Exams.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_Exams.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Exams.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_Exams.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grv_Exams.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Exams.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_Exams.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Exams.ThemeStyle.HeaderStyle.Height = 15;
            this.grv_Exams.ThemeStyle.ReadOnly = false;
            this.grv_Exams.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_Exams.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_Exams.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_Exams.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_Exams.ThemeStyle.RowsStyle.Height = 22;
            this.grv_Exams.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_Exams.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_Exams.SelectionChanged += new System.EventHandler(this.grv_Exams_SelectionChanged);
            //
            // btn_ViewDetail
            //
            this.btn_ViewDetail.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewDetail.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_ViewDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_ViewDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_ViewDetail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_ViewDetail.ForeColor = System.Drawing.Color.White;
            this.btn_ViewDetail.Location = new System.Drawing.Point(492, 38);
            this.btn_ViewDetail.Name = "btn_ViewDetail";
            this.btn_ViewDetail.Size = new System.Drawing.Size(121, 27);
            this.btn_ViewDetail.TabIndex = 3;
            this.btn_ViewDetail.Click += new System.EventHandler(this.btn_ViewDetail_Click);
            this.btn_ViewDetail.Text = "Xem chi tiết";
            //
            // btn_Approve
            //
            this.btn_Approve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Approve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Approve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Approve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Approve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Approve.ForeColor = System.Drawing.Color.White;
            this.btn_Approve.Location = new System.Drawing.Point(649, 38);
            this.btn_Approve.Name = "btn_Approve";
            this.btn_Approve.Size = new System.Drawing.Size(119, 27);
            this.btn_Approve.TabIndex = 4;
            this.btn_Approve.Click += new System.EventHandler(this.btn_Approve_Click);
            this.btn_Approve.Text = "Duyệt";
            //
            // btn_Reject
            //
            this.btn_Reject.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reject.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Reject.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Reject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Reject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Reject.ForeColor = System.Drawing.Color.White;
            this.btn_Reject.Location = new System.Drawing.Point(783, 38);
            this.btn_Reject.Name = "btn_Reject";
            this.btn_Reject.Size = new System.Drawing.Size(119, 27);
            this.btn_Reject.TabIndex = 5;
            this.btn_Reject.Click += new System.EventHandler(this.btn_Reject_Click);
            this.btn_Reject.Text = "Từ chối";
            //
            // Column1
            //
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            //
            // Column2
            //
            this.Column2.HeaderText = "ExamID";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            //
            // Column3
            //
            this.Column3.HeaderText = "Tên đề thi";
            this.Column3.Name = "Column3";
            //
            // Column4
            //
            this.Column4.HeaderText = "Môn học";
            this.Column4.Name = "Column4";
            //
            // Column5
            //
            this.Column5.HeaderText = "Thời gian làm bài";
            this.Column5.Name = "Column5";
            //
            // Column6
            //
            this.Column6.HeaderText = "Số lượng câu hỏi";
            this.Column6.Name = "Column6";
            //
            // Column7
            //
            this.Column7.HeaderText = "Người tạo";
            this.Column7.Name = "Column7";
            //
            // Column8
            //
            this.Column8.HeaderText = "Ngày tạo";
            this.Column8.Name = "Column8";
            //
            // Column9
            //
            this.Column9.HeaderText = "Trạng thái";
            this.Column9.Name = "Column9";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}
