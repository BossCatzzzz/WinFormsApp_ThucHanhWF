
namespace Lab05_Bai01
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButtonXemPhieuGiao = new System.Windows.Forms.RadioButton();
            this.radioButtonXemGia = new System.Windows.Forms.RadioButton();
            this.buttonXuat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.radioButtonXemPhieuGiao);
            this.panel1.Controls.Add(this.radioButtonXemGia);
            this.panel1.Location = new System.Drawing.Point(165, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 108);
            this.panel1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(298, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // radioButtonXemPhieuGiao
            // 
            this.radioButtonXemPhieuGiao.AutoSize = true;
            this.radioButtonXemPhieuGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXemPhieuGiao.Location = new System.Drawing.Point(59, 63);
            this.radioButtonXemPhieuGiao.Name = "radioButtonXemPhieuGiao";
            this.radioButtonXemPhieuGiao.Size = new System.Drawing.Size(177, 24);
            this.radioButtonXemPhieuGiao.TabIndex = 0;
            this.radioButtonXemPhieuGiao.TabStop = true;
            this.radioButtonXemPhieuGiao.Text = "Xem phiếu giao hàng";
            this.radioButtonXemPhieuGiao.UseVisualStyleBackColor = true;
            this.radioButtonXemPhieuGiao.CheckedChanged += new System.EventHandler(this.radioButtonXemPhieuGiao_CheckedChanged);
            // 
            // radioButtonXemGia
            // 
            this.radioButtonXemGia.AutoSize = true;
            this.radioButtonXemGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonXemGia.Location = new System.Drawing.Point(59, 19);
            this.radioButtonXemGia.Name = "radioButtonXemGia";
            this.radioButtonXemGia.Size = new System.Drawing.Size(199, 24);
            this.radioButtonXemGia.TabIndex = 0;
            this.radioButtonXemGia.TabStop = true;
            this.radioButtonXemGia.Text = "Xem bảng giá sản phẩm";
            this.radioButtonXemGia.UseVisualStyleBackColor = true;
            // 
            // buttonXuat
            // 
            this.buttonXuat.Location = new System.Drawing.Point(588, 126);
            this.buttonXuat.Name = "buttonXuat";
            this.buttonXuat.Size = new System.Drawing.Size(75, 23);
            this.buttonXuat.TabIndex = 1;
            this.buttonXuat.Text = "Xuất Report";
            this.buttonXuat.UseVisualStyleBackColor = true;
            this.buttonXuat.Click += new System.EventHandler(this.buttonXuat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(12, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 438);
            this.panel2.TabIndex = 2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Lab05_Bai01.Reporting.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 438);
            this.reportViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 623);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonXuat);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Xuất thông tin Report";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButtonXemPhieuGiao;
        private System.Windows.Forms.RadioButton radioButtonXemGia;
        private System.Windows.Forms.Button buttonXuat;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}

