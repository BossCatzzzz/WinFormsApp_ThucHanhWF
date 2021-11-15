using De02.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De02
{
    public partial class frmSanpham : Form
    {
        QLSanPhamModel db = new QLSanPhamModel();
        public frmSanpham()
        {
            InitializeComponent();
        }

        private void frmSanpham_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void Reload()
        {
            db = new QLSanPhamModel();
        }

        private void FormLoad()
        {
            
            foreach (TextBox item in pnThongTinSP.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
            List<Sanpham> list = db.Sanphams.ToList();
            dataGridView1.Rows.Clear();
            int row;
            foreach (Sanpham item in list)
            {
                row = dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = item.MaSP;
                dataGridView1.Rows[row].Cells[1].Value = item.TenSP;
                dataGridView1.Rows[row].Cells[2].Value = item.Ngaynhap;
                dataGridView1.Rows[row].Cells[3].Value = item.LoaiSP.TenLoai;
            }
            comboBoxLoaiSP.DataSource = db.LoaiSPs.ToList();
            comboBoxLoaiSP.DisplayMember = "TenLoai";
            comboBoxLoaiSP.ValueMember = "MaLoai";
            comboBoxLoaiSP.SelectedItem = null;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyy";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ROW = e.RowIndex;
            if (ROW < 0)
                return;
            textBoxMaSP.Text = dataGridView1.Rows[ROW].Cells[0].Value.ToString();
            textBoxTenSP.Text = dataGridView1.Rows[ROW].Cells[1].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.Rows[ROW].Cells[2].Value;
            comboBoxLoaiSP.Text = dataGridView1.Rows[ROW].Cells[3].Value.ToString();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in pnThongTinSP.Controls.OfType<TextBox>())
            {
                if (item.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!!");
                    return;
                }
            }
            Sanpham tmp = db.Sanphams.FirstOrDefault(i => i.MaSP == textBoxMaSP.Text.Trim());
            if (tmp != null)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return;
            }


            Sanpham s = new Sanpham();
            s.MaSP = textBoxMaSP.Text;
            s.TenSP = textBoxTenSP.Text;
            s.Ngaynhap = dateTimePicker1.Value;
            s.MaLoai = comboBoxLoaiSP.SelectedValue.ToString();
            db.Sanphams.Add(s);
            db.SaveChanges();
            FormLoad();
            MessageBox.Show("Đã Thêm!!");

        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            foreach (TextBox item in pnThongTinSP.Controls.OfType<TextBox>())
            {
                if (item.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!!");
                    return;
                }
            }
            Sanpham s = db.Sanphams.FirstOrDefault(i => i.MaSP == textBoxMaSP.Text.Trim());
            if (s == null)
            {
                MessageBox.Show("Sản phẩm không tồn tại");
                return;
            }

            s.MaSP = textBoxMaSP.Text;
            s.TenSP = textBoxTenSP.Text;
            s.Ngaynhap = dateTimePicker1.Value;
            s.MaLoai = comboBoxLoaiSP.SelectedValue.ToString();

            db.SaveChanges();
            FormLoad();
            MessageBox.Show("Đã cập nhật!!");
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            Sanpham s = db.Sanphams.FirstOrDefault(i => i.MaSP == textBoxMaSP.Text);
            if (s == null)
            {
                MessageBox.Show("Không có sản phẩm với mã " + textBoxMaSP.Text);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa sách với mã " + textBoxMaSP.Text, "Chú ý!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Sanphams.Remove(s);
                db.SaveChanges();
                MessageBox.Show("Đã xóa!!");
                FormLoad();

            }
        }

        private void frmSanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
  
                Application.Exit();
          
        }

        frmThongKe f;
        private void buttonReport_Click(object sender, EventArgs e)
        {
            if (f != null)
                f.Dispose();
            f = new frmThongKe();
            f.Show();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            //db.SaveChanges();
            //FormLoad();
        }

        private void buttonKhongLuu_Click(object sender, EventArgs e)
        {
            //Reload();
            //FormLoad();

        }
    }
}
