namespace ThiTracNghiem
{
    partial class frmManageQuestion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_QuestionId = new Guna.UI2.WinForms.Guna2TextBox();
            this.grv_DataUser = new Guna.UI2.WinForms.Guna2DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OptionD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chapter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CorrectAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_OptionB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_OptionA = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_QContent = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_OptionD = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_OptionC = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Delete = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Edit = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Search = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.grb_Infor = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbb_Subject = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_Cancel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Save = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_ImportExcel = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Add = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.txt_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Chapter = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grv_DataUser)).BeginInit();
            this.grb_Infor.SuspendLayout();
            this.SuspendLayout();
            //
            // txt_QuestionId
            //
            this.txt_QuestionId.BorderRadius = 5;
            this.txt_QuestionId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QuestionId.DefaultText = "";
            this.txt_QuestionId.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuestionId.Location = new System.Drawing.Point(120, 48);
            this.txt_QuestionId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_QuestionId.Name = "txt_QuestionId";
            this.txt_QuestionId.PasswordChar = '\0';
            this.txt_QuestionId.PlaceholderText = "";
            this.txt_QuestionId.SelectedText = "";
            this.txt_QuestionId.Size = new System.Drawing.Size(219, 36);
            this.txt_QuestionId.TabIndex = 1;
            //
            // grv_DataUser
            //
            this.grv_DataUser.AllowUserToAddRows = false;
            this.grv_DataUser.AllowUserToDeleteRows = false;
            this.grv_DataUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            this.grv_DataUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grv_DataUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_DataUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(131)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grv_DataUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grv_DataUser.ColumnHeadersHeight = 40;
            this.grv_DataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_DataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.QuestionID,
            this.SubjectID,
            this.QContent,
            this.OptionA,
            this.OptionB,
            this.OptionC,
            this.OptionD,
            this.Answer});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grv_DataUser.DefaultCellStyle = dataGridViewCellStyle5;
            this.grv_DataUser.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_DataUser.Location = new System.Drawing.Point(4, 362);
            this.grv_DataUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grv_DataUser.Name = "grv_DataUser";
            this.grv_DataUser.ReadOnly = true;
            this.grv_DataUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_DataUser.RowHeadersVisible = false;
            this.grv_DataUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grv_DataUser.RowTemplate.Height = 40;
            this.grv_DataUser.Size = new System.Drawing.Size(1207, 295);
            this.grv_DataUser.TabIndex = 7;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.grv_DataUser.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.grv_DataUser.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.grv_DataUser.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.grv_DataUser.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grv_DataUser.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_DataUser.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.grv_DataUser.ThemeStyle.HeaderStyle.Height = 40;
            this.grv_DataUser.ThemeStyle.ReadOnly = true;
            this.grv_DataUser.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.grv_DataUser.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grv_DataUser.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grv_DataUser.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DataUser.ThemeStyle.RowsStyle.Height = 40;
            this.grv_DataUser.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.grv_DataUser.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.grv_DataUser.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_DataUser_RowEnter);
            this.grv_DataUser.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.grv_DataUser_RowPrePaint);
            //
            // STT
            //
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle3;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            //
            // QuestionID
            //
            this.QuestionID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QuestionID.DataPropertyName = "QuestionID";
            this.QuestionID.HeaderText = "Mã câu hỏi";
            this.QuestionID.MinimumWidth = 6;
            this.QuestionID.Name = "QuestionID";
            this.QuestionID.ReadOnly = true;
            this.QuestionID.Width = 120;
            //
            // SubjectID
            //
            this.SubjectID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "Môn thi";
            this.SubjectID.MinimumWidth = 6;
            this.SubjectID.Name = "SubjectID";
            this.SubjectID.ReadOnly = true;
            this.SubjectID.Width = 110;
            //
            // QContent
            //
            this.QContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QContent.DataPropertyName = "QContent";
            this.QContent.HeaderText = "Nội dung câu hỏi";
            this.QContent.MinimumWidth = 6;
            this.QContent.Name = "QContent";
            this.QContent.ReadOnly = true;
            this.QContent.Width = 300;
            //
            // OptionA
            //
            this.OptionA.DataPropertyName = "OptionA";
            this.OptionA.HeaderText = "Lựa chọn A";
            this.OptionA.MinimumWidth = 6;
            this.OptionA.Name = "OptionA";
            this.OptionA.ReadOnly = true;
            //
            // OptionB
            //
            this.OptionB.DataPropertyName = "OptionB";
            this.OptionB.HeaderText = "Lựa chọn B";
            this.OptionB.MinimumWidth = 6;
            this.OptionB.Name = "OptionB";
            this.OptionB.ReadOnly = true;
            //
            // OptionC
            //
            this.OptionC.DataPropertyName = "OptionC";
            this.OptionC.HeaderText = "Lựa chọn C";
            this.OptionC.MinimumWidth = 6;
            this.OptionC.Name = "OptionC";
            this.OptionC.ReadOnly = true;
            //
            // OptionD
            //
            this.OptionD.DataPropertyName = "OptionD";
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = "dd/MM/yyyy";
            this.OptionD.DefaultCellStyle = dataGridViewCellStyle4;
            this.OptionD.HeaderText = "Lựa chọn D";
            this.OptionD.MinimumWidth = 6;
            this.OptionD.Name = "OptionD";
            this.OptionD.ReadOnly = true;
            //
            // Answer
            //
            this.Answer.DataPropertyName = "Answer";
            this.Answer.HeaderText = "Đáp án đúng";
            this.Answer.MinimumWidth = 6;
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            //
            // Chapter
            //
            this.Chapter.DataPropertyName = "Chapter";
            this.Chapter.HeaderText = "Chương";
            this.Chapter.MinimumWidth = 6;
            this.Chapter.Name = "Chapter";
            this.Chapter.ReadOnly = true;
            //
            // label2
            //
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã câu hỏi";
            //
            // label3
            //
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Môn thi";
            //
            // label4
            //
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đáp án đúng";
            //
            // txt_CorrectAnswer
            //
            this.txt_CorrectAnswer.BorderRadius = 5;
            this.txt_CorrectAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CorrectAnswer.DefaultText = "";
            this.txt_CorrectAnswer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CorrectAnswer.Location = new System.Drawing.Point(120, 194);
            this.txt_CorrectAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_CorrectAnswer.Name = "txt_CorrectAnswer";
            this.txt_CorrectAnswer.PasswordChar = '\0';
            this.txt_CorrectAnswer.PlaceholderText = "";
            this.txt_CorrectAnswer.SelectedText = "";
            this.txt_CorrectAnswer.Size = new System.Drawing.Size(219, 36);
            this.txt_CorrectAnswer.TabIndex = 11;
            //
            // txt_OptionB
            //
            this.txt_OptionB.BorderRadius = 5;
            this.txt_OptionB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OptionB.DefaultText = "";
            this.txt_OptionB.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OptionB.Location = new System.Drawing.Point(490, 194);
            this.txt_OptionB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OptionB.Name = "txt_OptionB";
            this.txt_OptionB.PasswordChar = '\0';
            this.txt_OptionB.PlaceholderText = "";
            this.txt_OptionB.SelectedText = "";
            this.txt_OptionB.Size = new System.Drawing.Size(282, 36);
            this.txt_OptionB.TabIndex = 13;
            //
            // txt_OptionA
            //
            this.txt_OptionA.BorderRadius = 5;
            this.txt_OptionA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OptionA.DefaultText = "";
            this.txt_OptionA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OptionA.Location = new System.Drawing.Point(490, 141);
            this.txt_OptionA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OptionA.Name = "txt_OptionA";
            this.txt_OptionA.PasswordChar = '\0';
            this.txt_OptionA.PlaceholderText = "";
            this.txt_OptionA.SelectedText = "";
            this.txt_OptionA.Size = new System.Drawing.Size(282, 36);
            this.txt_OptionA.TabIndex = 7;
            //
            // label5
            //
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(395, 197);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Lựa chọn B";
            //
            // label6
            //
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(396, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lựa chọn A";
            //
            // label7
            //
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(361, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nội dung câu hỏi";
            //
            // txt_QContent
            //
            this.txt_QContent.BorderRadius = 5;
            this.txt_QContent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_QContent.DefaultText = "";
            this.txt_QContent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QContent.Location = new System.Drawing.Point(490, 44);
            this.txt_QContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_QContent.Multiline = true;
            this.txt_QContent.Name = "txt_QContent";
            this.txt_QContent.PasswordChar = '\0';
            this.txt_QContent.PlaceholderText = "";
            this.txt_QContent.SelectedText = "";
            this.txt_QContent.Size = new System.Drawing.Size(691, 82);
            this.txt_QContent.TabIndex = 3;
            //
            // txt_OptionD
            //
            this.txt_OptionD.BorderRadius = 5;
            this.txt_OptionD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OptionD.DefaultText = "";
            this.txt_OptionD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OptionD.Location = new System.Drawing.Point(897, 194);
            this.txt_OptionD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OptionD.Name = "txt_OptionD";
            this.txt_OptionD.PasswordChar = '\0';
            this.txt_OptionD.PlaceholderText = "";
            this.txt_OptionD.SelectedText = "";
            this.txt_OptionD.Size = new System.Drawing.Size(282, 36);
            this.txt_OptionD.TabIndex = 15;
            //
            // label8
            //
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(800, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Lựa chọn D";
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(798, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Lựa chọn C";
            //
            // txt_OptionC
            //
            this.txt_OptionC.BorderRadius = 5;
            this.txt_OptionC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_OptionC.DefaultText = "";
            this.txt_OptionC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OptionC.Location = new System.Drawing.Point(897, 141);
            this.txt_OptionC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_OptionC.Name = "txt_OptionC";
            this.txt_OptionC.PasswordChar = '\0';
            this.txt_OptionC.PlaceholderText = "";
            this.txt_OptionC.SelectedText = "";
            this.txt_OptionC.Size = new System.Drawing.Size(282, 36);
            this.txt_OptionC.TabIndex = 9;
            //
            // btn_Delete
            //
            this.btn_Delete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.BorderRadius = 8;
            this.btn_Delete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(701, 257);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.ShadowDecoration.BorderRadius = 20;
            this.btn_Delete.ShadowDecoration.Depth = 10;
            this.btn_Delete.ShadowDecoration.Enabled = true;
            this.btn_Delete.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Delete.Size = new System.Drawing.Size(140, 46);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            //
            // btn_Edit
            //
            this.btn_Edit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Edit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Edit.BorderRadius = 8;
            this.btn_Edit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.Location = new System.Drawing.Point(531, 257);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.ShadowDecoration.BorderRadius = 20;
            this.btn_Edit.ShadowDecoration.Depth = 10;
            this.btn_Edit.ShadowDecoration.Enabled = true;
            this.btn_Edit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Edit.Size = new System.Drawing.Size(140, 46);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Sửa";
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            //
            // btn_Search
            //
            this.btn_Search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.BorderRadius = 8;
            this.btn_Search.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(375, 315);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.ShadowDecoration.BorderRadius = 20;
            this.btn_Search.ShadowDecoration.Depth = 10;
            this.btn_Search.ShadowDecoration.Enabled = true;
            this.btn_Search.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Search.Size = new System.Drawing.Size(140, 37);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            //
            // grb_Infor
            //
            this.grb_Infor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grb_Infor.BackColor = System.Drawing.Color.Transparent;
            this.grb_Infor.BorderRadius = 10;
            this.grb_Infor.Controls.Add(this.label1);
            this.grb_Infor.Controls.Add(this.txt_Chapter);
            this.grb_Infor.Controls.Add(this.cbb_Subject);
            this.grb_Infor.Controls.Add(this.txt_OptionD);
            this.grb_Infor.Controls.Add(this.label8);
            this.grb_Infor.Controls.Add(this.label9);
            this.grb_Infor.Controls.Add(this.txt_OptionC);
            this.grb_Infor.Controls.Add(this.txt_OptionB);
            this.grb_Infor.Controls.Add(this.txt_OptionA);
            this.grb_Infor.Controls.Add(this.label5);
            this.grb_Infor.Controls.Add(this.label6);
            this.grb_Infor.Controls.Add(this.label7);
            this.grb_Infor.Controls.Add(this.txt_QContent);
            this.grb_Infor.Controls.Add(this.txt_CorrectAnswer);
            this.grb_Infor.Controls.Add(this.label4);
            this.grb_Infor.Controls.Add(this.label3);
            this.grb_Infor.Controls.Add(this.label2);
            this.grb_Infor.Controls.Add(this.txt_QuestionId);
            this.grb_Infor.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_Infor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grb_Infor.Location = new System.Drawing.Point(4, 5);
            this.grb_Infor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grb_Infor.Name = "grb_Infor";
            this.grb_Infor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grb_Infor.Size = new System.Drawing.Size(1207, 240);
            this.grb_Infor.TabIndex = 1;
            this.grb_Infor.TabStop = false;
            this.grb_Infor.Text = "Thông tin câu hỏi";
            //
            // cbb_Subject
            //
            this.cbb_Subject.BackColor = System.Drawing.Color.Transparent;
            this.cbb_Subject.BorderRadius = 5;
            this.cbb_Subject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Subject.FocusedColor = System.Drawing.Color.Empty;
            this.cbb_Subject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbb_Subject.FormattingEnabled = true;
            this.cbb_Subject.ItemHeight = 30;
            this.cbb_Subject.Location = new System.Drawing.Point(120, 140);
            this.cbb_Subject.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Subject.Name = "cbb_Subject";
            this.cbb_Subject.Size = new System.Drawing.Size(218, 36);
            this.cbb_Subject.TabIndex = 5;
            //
            // btn_Cancel
            //
            this.btn_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancel.BorderRadius = 8;
            this.btn_Cancel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(612, 258);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.ShadowDecoration.BorderRadius = 20;
            this.btn_Cancel.ShadowDecoration.Depth = 10;
            this.btn_Cancel.ShadowDecoration.Enabled = true;
            this.btn_Cancel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Cancel.Size = new System.Drawing.Size(140, 46);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            //
            // btn_Save
            //
            this.btn_Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.BackColor = System.Drawing.Color.Transparent;
            this.btn_Save.BorderRadius = 8;
            this.btn_Save.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(451, 258);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.ShadowDecoration.BorderRadius = 20;
            this.btn_Save.ShadowDecoration.Depth = 10;
            this.btn_Save.ShadowDecoration.Enabled = true;
            this.btn_Save.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Save.Size = new System.Drawing.Size(140, 46);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Lưu";
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            //
            // btn_ImportExcel
            //
            this.btn_ImportExcel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ImportExcel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_ImportExcel.BackColor = System.Drawing.Color.Transparent;
            this.btn_ImportExcel.BorderRadius = 8;
            this.btn_ImportExcel.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_ImportExcel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportExcel.ForeColor = System.Drawing.Color.White;
            this.btn_ImportExcel.Location = new System.Drawing.Point(1040, 315);
            this.btn_ImportExcel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ImportExcel.Name = "btn_ImportExcel";
            this.btn_ImportExcel.ShadowDecoration.BorderRadius = 20;
            this.btn_ImportExcel.ShadowDecoration.Depth = 10;
            this.btn_ImportExcel.ShadowDecoration.Enabled = true;
            this.btn_ImportExcel.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_ImportExcel.Size = new System.Drawing.Size(173, 37);
            this.btn_ImportExcel.TabIndex = 10;
            this.btn_ImportExcel.Text = "Nhập từ file excel";
            this.btn_ImportExcel.Visible = false;
            this.btn_ImportExcel.Click += new System.EventHandler(this.btn_ImportExcel_Click);
            //
            // btn_Add
            //
            this.btn_Add.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add.BorderRadius = 8;
            this.btn_Add.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(138)))), ((int)(((byte)(236)))));
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Add.ImageOffset = new System.Drawing.Point(22, 11);
            this.btn_Add.ImageSize = new System.Drawing.Size(15, 15);
            this.btn_Add.Location = new System.Drawing.Point(361, 257);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.ShadowDecoration.BorderRadius = 20;
            this.btn_Add.ShadowDecoration.Depth = 10;
            this.btn_Add.ShadowDecoration.Enabled = true;
            this.btn_Add.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Add.Size = new System.Drawing.Size(140, 46);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            //
            // txt_Search
            //
            this.txt_Search.BorderRadius = 8;
            this.txt_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Search.DefaultText = "";
            this.txt_Search.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txt_Search.IconLeft = global::ThiTracNghiem.Properties.Resources.search_grey;
            this.txt_Search.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txt_Search.Location = new System.Drawing.Point(17, 315);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Search.Multiline = true;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PlaceholderText = "Nhập nội dung cần tìm...";
            this.txt_Search.SelectedText = "";
            this.txt_Search.Size = new System.Drawing.Size(348, 37);
            this.txt_Search.TabIndex = 5;
            this.txt_Search.Enter += new System.EventHandler(this.txt_Search_Enter);
            this.txt_Search.Leave += new System.EventHandler(this.txt_Search_Leave);
            this.txt_Search.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txt_Search_MouseDoubleClick);
            //
            // txt_Chapter
            //
            this.txt_Chapter.BorderRadius = 5;
            this.txt_Chapter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Chapter.DefaultText = "";
            this.txt_Chapter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Chapter.Location = new System.Drawing.Point(120, 94);
            this.txt_Chapter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Chapter.Name = "txt_Chapter";
            this.txt_Chapter.PasswordChar = '\0';
            this.txt_Chapter.PlaceholderText = "";
            this.txt_Chapter.SelectedText = "";
            this.txt_Chapter.Size = new System.Drawing.Size(219, 36);
            this.txt_Chapter.TabIndex = 16;
            //
            // label1
            //
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chương";
            //
            // frmManageQuestion
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_ImportExcel);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.grb_Infor);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.grv_DataUser);
            this.Controls.Add(this.btn_Add);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManageQuestion";
            this.Size = new System.Drawing.Size(1217, 662);
            this.Load += new System.EventHandler(this.frmManageQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_DataUser)).EndInit();
            this.grb_Infor.ResumeLayout(false);
            this.grb_Infor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_QuestionId;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Add;
        private Guna.UI2.WinForms.Guna2DataGridView grv_DataUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_CorrectAnswer;
        private Guna.UI2.WinForms.Guna2TextBox txt_OptionB;
        private Guna.UI2.WinForms.Guna2TextBox txt_OptionA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_QContent;
        private Guna.UI2.WinForms.Guna2TextBox txt_OptionD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txt_OptionC;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Delete;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Edit;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Search;
        private Guna.UI2.WinForms.Guna2GroupBox grb_Infor;
        private Guna.UI2.WinForms.Guna2TextBox txt_Search;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Cancel;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Save;
        private Guna.UI2.WinForms.Guna2ComboBox cbb_Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuestionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionB;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chapter;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_ImportExcel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_Chapter;
    }
}