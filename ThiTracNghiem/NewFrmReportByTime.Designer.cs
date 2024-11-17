namespace ThiTracNghiem
{
    partial class NewFrmReportByTime
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
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btn_XemBaoCao = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btn_ExportPDF = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btn_Print = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.dpk_StartDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dpk_EndDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.documentViewer1 = new DevExpress.XtraPrinting.Preview.DocumentViewer();
            this.SuspendLayout();
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(344, 13);
            this.labelX2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(79, 24);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Đến ngày";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_XemBaoCao
            // 
            this.btn_XemBaoCao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_XemBaoCao.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_XemBaoCao.BackColor = System.Drawing.Color.Transparent;
            this.btn_XemBaoCao.BorderColor = System.Drawing.Color.Transparent;
            this.btn_XemBaoCao.BorderRadius = 5;
            this.btn_XemBaoCao.BorderThickness = 2;
            this.btn_XemBaoCao.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.btn_XemBaoCao.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btn_XemBaoCao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_XemBaoCao.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_XemBaoCao.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_XemBaoCao.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_XemBaoCao.Location = new System.Drawing.Point(612, 7);
            this.btn_XemBaoCao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_XemBaoCao.Name = "btn_XemBaoCao";
            this.btn_XemBaoCao.ShadowDecoration.BorderRadius = 5;
            this.btn_XemBaoCao.ShadowDecoration.Depth = 10;
            this.btn_XemBaoCao.ShadowDecoration.Enabled = true;
            this.btn_XemBaoCao.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_XemBaoCao.Size = new System.Drawing.Size(130, 36);
            this.btn_XemBaoCao.TabIndex = 4;
            this.btn_XemBaoCao.Text = "Xem báo cáo";
            this.btn_XemBaoCao.Click += new System.EventHandler(this.btn_XemBaoCao_Click);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(97, 13);
            this.labelX1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(88, 24);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Từ ngày";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btn_ExportPDF
            // 
            this.btn_ExportPDF.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ExportPDF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ExportPDF.BackColor = System.Drawing.Color.Transparent;
            this.btn_ExportPDF.BorderColor = System.Drawing.Color.Transparent;
            this.btn_ExportPDF.BorderRadius = 5;
            this.btn_ExportPDF.BorderThickness = 2;
            this.btn_ExportPDF.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.btn_ExportPDF.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportPDF.ForeColor = System.Drawing.Color.White;
            this.btn_ExportPDF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_ExportPDF.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_ExportPDF.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_ExportPDF.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_ExportPDF.Location = new System.Drawing.Point(911, 7);
            this.btn_ExportPDF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ExportPDF.Name = "btn_ExportPDF";
            this.btn_ExportPDF.ShadowDecoration.BorderRadius = 5;
            this.btn_ExportPDF.ShadowDecoration.Depth = 10;
            this.btn_ExportPDF.ShadowDecoration.Enabled = true;
            this.btn_ExportPDF.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_ExportPDF.Size = new System.Drawing.Size(147, 36);
            this.btn_ExportPDF.TabIndex = 6;
            this.btn_ExportPDF.Text = "Xuất file .PDF";
            this.btn_ExportPDF.Click += new System.EventHandler(this.btn_ExportPDF_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Print.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Print.BackColor = System.Drawing.Color.Transparent;
            this.btn_Print.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Print.BorderRadius = 5;
            this.btn_Print.BorderThickness = 2;
            this.btn_Print.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(50)))), ((int)(((byte)(255)))));
            this.btn_Print.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.White;
            this.btn_Print.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Print.HoverState.FillColor = System.Drawing.Color.White;
            this.btn_Print.HoverState.FillColor2 = System.Drawing.Color.White;
            this.btn_Print.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_Print.Location = new System.Drawing.Point(756, 7);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.ShadowDecoration.BorderRadius = 5;
            this.btn_Print.ShadowDecoration.Depth = 10;
            this.btn_Print.ShadowDecoration.Enabled = true;
            this.btn_Print.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.btn_Print.Size = new System.Drawing.Size(141, 36);
            this.btn_Print.TabIndex = 5;
            this.btn_Print.Text = "Xem chi tiết";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // dpk_StartDate
            // 
            this.dpk_StartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpk_StartDate.BorderRadius = 5;
            this.dpk_StartDate.Checked = true;
            this.dpk_StartDate.CustomFormat = "dd/MM/yyy";
            this.dpk_StartDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dpk_StartDate.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dpk_StartDate.ForeColor = System.Drawing.Color.White;
            this.dpk_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_StartDate.Location = new System.Drawing.Point(191, 7);
            this.dpk_StartDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpk_StartDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpk_StartDate.Name = "dpk_StartDate";
            this.dpk_StartDate.Size = new System.Drawing.Size(147, 36);
            this.dpk_StartDate.TabIndex = 8;
            this.dpk_StartDate.Value = new System.DateTime(2024, 10, 1, 19, 33, 51, 837);
            this.dpk_StartDate.Click += new System.EventHandler(this.dpk_StartDate_Click);
            // 
            // dpk_EndDate
            // 
            this.dpk_EndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpk_EndDate.BorderRadius = 5;
            this.dpk_EndDate.Checked = true;
            this.dpk_EndDate.CustomFormat = "dd/MM/yyy";
            this.dpk_EndDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dpk_EndDate.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.dpk_EndDate.ForeColor = System.Drawing.Color.White;
            this.dpk_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpk_EndDate.Location = new System.Drawing.Point(429, 7);
            this.dpk_EndDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dpk_EndDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dpk_EndDate.Name = "dpk_EndDate";
            this.dpk_EndDate.Size = new System.Drawing.Size(147, 36);
            this.dpk_EndDate.TabIndex = 9;
            this.dpk_EndDate.Value = new System.DateTime(2024, 10, 1, 19, 33, 51, 837);
            this.dpk_EndDate.Click += new System.EventHandler(this.dpk_EndDate_Click);
            // 
            // documentViewer1
            // 
            this.documentViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.documentViewer1.DocumentSource = typeof(ThiTracNghiem.XtraReportByTime);
            this.documentViewer1.IsMetric = true;
            this.documentViewer1.Location = new System.Drawing.Point(12, 50);
            this.documentViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.documentViewer1.Name = "documentViewer1";
            this.documentViewer1.Size = new System.Drawing.Size(1138, 669);
            this.documentViewer1.TabIndex = 7;
            // 
            // NewFrmReportByTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dpk_EndDate);
            this.Controls.Add(this.dpk_StartDate);
            this.Controls.Add(this.btn_ExportPDF);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.documentViewer1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.btn_XemBaoCao);
            this.Controls.Add(this.labelX1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(1154, 708);
            this.Name = "NewFrmReportByTime";
            this.Size = new System.Drawing.Size(1155, 708);
            this.Load += new System.EventHandler(this.NewFrmReportByTime_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_XemBaoCao;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevExpress.XtraPrinting.Preview.DocumentViewer documentViewer1;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_ExportPDF;
        private Guna.UI2.WinForms.Guna2GradientTileButton btn_Print;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpk_StartDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dpk_EndDate;
    }
}