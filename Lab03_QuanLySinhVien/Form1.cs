using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        Form2 f;

        DataTable root = new DataTable();
        public Form1()
        {
            InitializeComponent();
            createTable();
            dataGridView1.DataSource = root;

        }

        #region tạo bảng
        void createTable()
        {
            root.Columns.Add("stt", typeof(int));
            root.Columns.Add("ma", typeof(String));
            root.Columns.Add("ten", typeof(String));
            root.Columns.Add("khoa", typeof(String));
            root.Columns.Add("dtb", typeof(Double));
        }
        #endregion

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f != null)
                f.Close();
            
            f = new Form2(root);
            f.Focus();
            f.Show();
        }

        private void tbTimKiemTheoTen_TextChanged(object sender, EventArgs e)
        {
            if (tbTimKiemTheoTen.Text.Length == 0)
            {
                root.DefaultView.RowFilter = string.Format("ten LIKE '%{0}%'", "");
                return;
            }
            root.DefaultView.RowFilter = string.Format("ten LIKE '%{0}%'", tbTimKiemTheoTen.Text.ToLower());
        }
    }
}
