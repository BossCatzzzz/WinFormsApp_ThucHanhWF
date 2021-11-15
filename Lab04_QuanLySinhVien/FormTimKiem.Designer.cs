
namespace Lab04_QuanLySinhVien
{
    partial class FormTimKiem
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
            this.gbTTSV = new System.Windows.Forms.GroupBox();
            this.cbbKhoa = new System.Windows.Forms.ComboBox();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnTableDSSV = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btTim = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btTroVe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbKetQuaTimKiem = new System.Windows.Forms.TextBox();
            this.gbTTSV.SuspendLayout();
            this.pnTableDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTTSV
            // 
            this.gbTTSV.Controls.Add(this.cbbKhoa);
            this.gbTTSV.Controls.Add(this.tbHoten);
            this.gbTTSV.Controls.Add(this.label4);
            this.gbTTSV.Controls.Add(this.label3);
            this.gbTTSV.Controls.Add(this.tbMSSV);
            this.gbTTSV.Controls.Add(this.label2);
            this.gbTTSV.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbTTSV.Location = new System.Drawing.Point(209, 17);
            this.gbTTSV.Name = "gbTTSV";
            this.gbTTSV.Size = new System.Drawing.Size(344, 221);
            this.gbTTSV.TabIndex = 4;
            this.gbTTSV.TabStop = false;
            this.gbTTSV.Text = "Thông tin sinh viên";
            // 
            // cbbKhoa
            // 
            this.cbbKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbKhoa.ForeColor = System.Drawing.Color.Black;
            this.cbbKhoa.FormattingEnabled = true;
            this.cbbKhoa.Location = new System.Drawing.Point(132, 164);
            this.cbbKhoa.Name = "cbbKhoa";
            this.cbbKhoa.Size = new System.Drawing.Size(181, 32);
            this.cbbKhoa.TabIndex = 2;
            // 
            // tbHoten
            // 
            this.tbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoten.ForeColor = System.Drawing.Color.Black;
            this.tbHoten.Location = new System.Drawing.Point(132, 106);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(181, 29);
            this.tbHoten.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(29, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên";
            // 
            // tbMSSV
            // 
            this.tbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMSSV.ForeColor = System.Drawing.Color.Black;
            this.tbMSSV.Location = new System.Drawing.Point(132, 48);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(181, 29);
            this.tbMSSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã SV";
            // 
            // pnTableDSSV
            // 
            this.pnTableDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTableDSSV.Controls.Add(this.dataGridView1);
            this.pnTableDSSV.Location = new System.Drawing.Point(8, 319);
            this.pnTableDSSV.Name = "pnTableDSSV";
            this.pnTableDSSV.Size = new System.Drawing.Size(758, 288);
            this.pnTableDSSV.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(758, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(395, 261);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 33);
            this.btTim.TabIndex = 6;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(476, 261);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 33);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btTroVe
            // 
            this.btTroVe.Location = new System.Drawing.Point(685, 261);
            this.btTroVe.Name = "btTroVe";
            this.btTroVe.Size = new System.Drawing.Size(75, 33);
            this.btTroVe.TabIndex = 6;
            this.btTroVe.Text = "Trở về";
            this.btTroVe.UseVisualStyleBackColor = true;
            this.btTroVe.Click += new System.EventHandler(this.btTroVe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(533, 622);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kết quả tìm kiếm:";
            // 
            // tbKetQuaTimKiem
            // 
            this.tbKetQuaTimKiem.Enabled = false;
            this.tbKetQuaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKetQuaTimKiem.Location = new System.Drawing.Point(647, 619);
            this.tbKetQuaTimKiem.Name = "tbKetQuaTimKiem";
            this.tbKetQuaTimKiem.ReadOnly = true;
            this.tbKetQuaTimKiem.Size = new System.Drawing.Size(100, 22);
            this.tbKetQuaTimKiem.TabIndex = 8;
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 647);
            this.Controls.Add(this.tbKetQuaTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btTroVe);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.pnTableDSSV);
            this.Controls.Add(this.gbTTSV);
            this.Name = "FormTimKiem";
            this.Text = "Tìm kiếm";
            this.gbTTSV.ResumeLayout(false);
            this.gbTTSV.PerformLayout();
            this.pnTableDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTTSV;
        private System.Windows.Forms.ComboBox cbbKhoa;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnTableDSSV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btTroVe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKetQuaTimKiem;
    }
}