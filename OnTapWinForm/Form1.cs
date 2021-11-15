using OnTapWinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QLSACHModel db = new QLSACHModel();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void FormLoad()
        {
            List<SACH> list = db.SACHes.ToList();
            dataGridView1.Rows.Clear();
            int row;
            foreach (SACH item in list)
            {
                row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = item.MaSach;
                dataGridView1.Rows[row].Cells[1].Value = item.TenSach;
                dataGridView1.Rows[row].Cells[3].Value = item.LOAISACH.TenLoai;
                dataGridView1.Rows[row].Cells[2].Value = item.NamXB;
            }
            comboBoxTheLoai.DataSource = db.LOAISACHes.ToList();
            comboBoxTheLoai.DisplayMember = "TenLoai";
            comboBoxTheLoai.ValueMember = "MaLoai";
            comboBoxTheLoai.SelectedItem = null;
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ROW = e.RowIndex;
            if (ROW < 0)
                return;
            textBoxMaSach.Text = dataGridView1.Rows[ROW].Cells[0].Value.ToString();
            textBoxTenSach.Text= dataGridView1.Rows[ROW].Cells[1].Value.ToString();
            textBoxNamXB.Text= dataGridView1.Rows[ROW].Cells[2].Value.ToString();
            comboBoxTheLoai.Text= dataGridView1.Rows[ROW].Cells[3].Value.ToString();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            SACH s = db.SACHes.FirstOrDefault(i => i.MaSach == textBoxMaSach.Text);
            if(s==null)
            {
                MessageBox.Show("Không có sách với mã "+textBoxMaSach.Text);
                return;
            }
            if(MessageBox.Show("Bạn có muốn xóa sách với mã " + textBoxMaSach.Text, "Chú ý!!",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                db.SACHes.Remove(s);
                db.SaveChanges();
                FormLoad();
                MessageBox.Show("Đã xóa!!");
            }
            foreach (TextBox item in groupBox1.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in groupBox1.Controls.OfType<TextBox>())
            {
                if(item.Text.Trim()=="")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!!");
                    return;
                }
            }
            SACH tmp = db.SACHes.FirstOrDefault(i => i.MaSach == textBoxMaSach.Text.Trim());
            if(tmp!=null)
            {
                MessageBox.Show("Mã sách đã tồn tại!");
                return;
            }

            if (textBoxMaSach.Text.Trim().Length!=6)
            {
                MessageBox.Show("Mã sách phải đủ 6 ký tự!!");
                return;
            }

            SACH s = new SACH();
            s.MaSach = textBoxMaSach.Text;
            s.TenSach = textBoxTenSach.Text;
            int nam;
            if(!int.TryParse(textBoxNamXB.Text.Trim(),out nam))
                {
                MessageBox.Show("Năm xuất bản phải là số");
                return;
            }
            s.NamXB = nam;
            s.MaLoai = int.Parse(comboBoxTheLoai.SelectedValue.ToString());
            db.SACHes.Add(s);
            db.SaveChanges();
            FormLoad();
            MessageBox.Show("Đã Thêm!!");
            foreach (TextBox item in groupBox1.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in groupBox1.Controls.OfType<TextBox>())
            {
                if (item.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!!");
                    return;
                }
            }
            SACH s = db.SACHes.FirstOrDefault(i => i.MaSach == textBoxMaSach.Text.Trim());
            if (s == null)
            {
                MessageBox.Show("Sách không tồn tại");
                return;
            }

            if (textBoxMaSach.Text.Trim().Length != 6)
            {
                MessageBox.Show("Mã sách phải đủ 6 ký tự!!");
                return;
            }

    
            s.MaSach = textBoxMaSach.Text;
            s.TenSach = textBoxTenSach.Text;
            int nam;
            if (!int.TryParse(textBoxNamXB.Text.Trim(), out nam))
            {
                MessageBox.Show("Năm xuất bản phải là số");
                return;
            }
            s.NamXB = nam;
            s.MaLoai = int.Parse(comboBoxTheLoai.SelectedValue.ToString());
            
            db.SaveChanges();
            FormLoad();
            MessageBox.Show("Đã cập nhật!!");
            foreach (TextBox item in groupBox1.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }

        private void textBoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int row;
            foreach (SACH item in db.SACHes.ToList())
            {
                if(item.MaSach.ToLower().Contains(textBoxTimKiem.Text.ToLower())|| item.TenSach.ToLower().Contains(textBoxTimKiem.Text.ToLower()) || item.NamXB.ToString().Contains(textBoxTimKiem.Text))
                {
                        row = dataGridView1.Rows.Add();
                        dataGridView1.Rows[row].Cells[0].Value = item.MaSach;
                        dataGridView1.Rows[row].Cells[1].Value = item.TenSach;
                        dataGridView1.Rows[row].Cells[3].Value = item.LOAISACH.TenLoai;
                        dataGridView1.Rows[row].Cells[2].Value = item.NamXB;
                }
            }
        }

        FormThongKe f;
        private void thốngKêTheoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(f!=null)
             f.Dispose();
            f = new FormThongKe();
            f.Show();
        }
    }
}
