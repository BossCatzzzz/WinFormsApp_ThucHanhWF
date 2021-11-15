using Lab04_QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_QuanLySinhVien
{
    public partial class FormFaculty : Form
    {
        QLSVModel db;
        Handle xl;
        FormQLSV main;

        public FormFaculty(FormQLSV f)
        {
            InitializeComponent();
            xl = new Handle();
            db = new QLSVModel();
            main = f;
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormFaculty_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        private void FormLoad()
        {
            try
            {
                dataGridViewKhoa.Rows.Clear();
                int row;
                foreach (FACULTY item in db.FACULTies.ToList())
                {
                    row = dataGridViewKhoa.Rows.Add();
                    dataGridViewKhoa.Rows[row].Cells[0].Value = item.FacultyID;
                    dataGridViewKhoa.Rows[row].Cells[1].Value = item.FacultyName;
                    dataGridViewKhoa.Rows[row].Cells[2].Value = item.TotalProfessor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu!\n" + ex.Message);
            }

        }

        int ROWSELECTED = -1;
        private void dataGridViewKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ROWSELECTED = e.RowIndex;
            if (ROWSELECTED < 0)
                return;
            tbMaKhoa.Text = dataGridViewKhoa.Rows[ROWSELECTED].Cells[0].Value.ToString();
            tbTenKhoa.Text = dataGridViewKhoa.Rows[ROWSELECTED].Cells[1].Value.ToString();
            tbTongSoGS.Text = (dataGridViewKhoa.Rows[ROWSELECTED].Cells[2].Value == null) ? "0" : dataGridViewKhoa.Rows[ROWSELECTED].Cells[2].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (tbTenKhoa.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin!");
                return;
            }

            FACULTY fac = db.FACULTies.FirstOrDefault(i => i.FacultyID.ToString() == tbMaKhoa.Text);
            if (fac == null)
            {
                fac = new FACULTY();
            }
            fac.FacultyName = tbTenKhoa.Text;
            int x = 0;
            if (!int.TryParse(tbTongSoGS.Text, out x))
            {
                MessageBox.Show("Số lượng GS phải là một số!!");
                return;
            }
            fac.TotalProfessor = x;
            try
            {
                db.FACULTies.AddOrUpdate(fac);
                db.SaveChanges();
                MessageBox.Show("Đã lưu thông tin!!");
                FormLoad();
                xl.ClearTextBox(gbTTKhoa);
                main.FormLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật khoa!!" + ex.Message);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            FACULTY fac = db.FACULTies.FirstOrDefault(i => i.FacultyID.ToString() == tbMaKhoa.Text);
            if (fac == null)
            {
                MessageBox.Show("Không có khoa với mã là " + tbMaKhoa.Text);
                return;
            }
            if (MessageBox.Show("Chắc chắn xóa Khoa này", "Chú ý!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (db.STUDENTs.Any(i => i.FACULTY.FacultyID.ToString() == tbMaKhoa.Text))
                {
                    MessageBox.Show("Khoa này đã có Sinh viên.\nKhông thể xóa!!");
                    return;
                }

                try
                {
                    db.FACULTies.Remove(fac);
                    db.SaveChanges();
                    MessageBox.Show("Đã xóa!!");
                    FormLoad();
                    xl.ClearTextBox(gbTTKhoa);
                    main.FormLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa Khoa!!" + ex.Message);
                }
            }
        }
    }
}
