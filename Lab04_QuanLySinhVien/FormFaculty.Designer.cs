
namespace Lab04_QuanLySinhVien
{
    partial class FormFaculty
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
            this.gbTTKhoa = new System.Windows.Forms.GroupBox();
            this.tbTongSoGS = new System.Windows.Forms.TextBox();
            this.tbTenKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.pnTableDSSV = new System.Windows.Forms.Panel();
            this.dataGridViewKhoa = new System.Windows.Forms.DataGridView();
            this.btDong = new System.Windows.Forms.Button();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOngSoGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTTKhoa.SuspendLayout();
            this.pnTableDSSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTTKhoa
            // 
            this.gbTTKhoa.Controls.Add(this.tbTongSoGS);
            this.gbTTKhoa.Controls.Add(this.tbTenKhoa);
            this.gbTTKhoa.Controls.Add(this.label5);
            this.gbTTKhoa.Controls.Add(this.label3);
            this.gbTTKhoa.Controls.Add(this.tbMaKhoa);
            this.gbTTKhoa.Controls.Add(this.label2);
            this.gbTTKhoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.gbTTKhoa.Location = new System.Drawing.Point(17, 17);
            this.gbTTKhoa.Name = "gbTTKhoa";
            this.gbTTKhoa.Size = new System.Drawing.Size(350, 252);
            this.gbTTKhoa.TabIndex = 9;
            this.gbTTKhoa.TabStop = false;
            this.gbTTKhoa.Text = "Thông tin khoa";
            // 
            // tbTongSoGS
            // 
            this.tbTongSoGS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongSoGS.ForeColor = System.Drawing.Color.Black;
            this.tbTongSoGS.Location = new System.Drawing.Point(149, 195);
            this.tbTongSoGS.Name = "tbTongSoGS";
            this.tbTongSoGS.Size = new System.Drawing.Size(181, 29);
            this.tbTongSoGS.TabIndex = 1;
            // 
            // tbTenKhoa
            // 
            this.tbTenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenKhoa.ForeColor = System.Drawing.Color.Black;
            this.tbTenKhoa.Location = new System.Drawing.Point(149, 124);
            this.tbTenKhoa.Name = "tbTenKhoa";
            this.tbTenKhoa.Size = new System.Drawing.Size(181, 29);
            this.tbTenKhoa.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng số GS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên khoa";
            // 
            // tbMaKhoa
            // 
            this.tbMaKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKhoa.ForeColor = System.Drawing.Color.Black;
            this.tbMaKhoa.Location = new System.Drawing.Point(149, 53);
            this.tbMaKhoa.Name = "tbMaKhoa";
            this.tbMaKhoa.ReadOnly = true;
            this.tbMaKhoa.Size = new System.Drawing.Size(181, 29);
            this.tbMaKhoa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khoa";
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Location = new System.Drawing.Point(1079, 378);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btXoa.Location = new System.Drawing.Point(235, 304);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 6;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btThem.Location = new System.Drawing.Point(110, 304);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(114, 23);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm / Sửa";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // pnTableDSSV
            // 
            this.pnTableDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnTableDSSV.Controls.Add(this.dataGridViewKhoa);
            this.pnTableDSSV.Location = new System.Drawing.Point(373, 23);
            this.pnTableDSSV.Name = "pnTableDSSV";
            this.pnTableDSSV.Size = new System.Drawing.Size(660, 357);
            this.pnTableDSSV.TabIndex = 4;
            // 
            // dataGridViewKhoa
            // 
            this.dataGridViewKhoa.AllowUserToAddRows = false;
            this.dataGridViewKhoa.AllowUserToDeleteRows = false;
            this.dataGridViewKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.TOngSoGS});
            this.dataGridViewKhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKhoa.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKhoa.Name = "dataGridViewKhoa";
            this.dataGridViewKhoa.ReadOnly = true;
            this.dataGridViewKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewKhoa.Size = new System.Drawing.Size(660, 357);
            this.dataGridViewKhoa.TabIndex = 0;
            this.dataGridViewKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKhoa_CellClick);
            // 
            // btDong
            // 
            this.btDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDong.Location = new System.Drawing.Point(958, 400);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(75, 23);
            this.btDong.TabIndex = 10;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // MaKhoa
            // 
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            // 
            // TenKhoa
            // 
            this.TenKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenKhoa.HeaderText = "Tên khoa";
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            // 
            // TOngSoGS
            // 
            this.TOngSoGS.HeaderText = "Tổng số GS";
            this.TOngSoGS.Name = "TOngSoGS";
            this.TOngSoGS.ReadOnly = true;
            this.TOngSoGS.Width = 120;
            // 
            // FormFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 448);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.gbTTKhoa);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.pnTableDSSV);
            this.Name = "FormFaculty";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.FormFaculty_Load);
            this.gbTTKhoa.ResumeLayout(false);
            this.gbTTKhoa.PerformLayout();
            this.pnTableDSSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTTKhoa;
        private System.Windows.Forms.TextBox tbTongSoGS;
        private System.Windows.Forms.TextBox tbTenKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Panel pnTableDSSV;
        private System.Windows.Forms.DataGridView dataGridViewKhoa;
        private System.Windows.Forms.Button btDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOngSoGS;
    }
}