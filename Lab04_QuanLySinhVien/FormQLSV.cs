using Lab04_QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_QuanLySinhVien
{
    public partial class FormQLSV : Form
    {
        Handle xl;
        QLSVModel db;
        public FormQLSV()
        {
            InitializeComponent();
            xl = new Handle();
            db = new QLSVModel();
        }
        private void FormQLSV_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        public void FormLoad()
        {
            db = new QLSVModel();
            try
            {
                GetDataToCBBKhoa(db.FACULTies.ToList());
                GetDataToTableStudent(db.STUDENTs.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy dữ liệu!\n" + ex.Message);
            }
        }


        private void GetDataToCBBKhoa(List<FACULTY> list)
        {
            cbbKhoa.DataSource = list;
            cbbKhoa.DisplayMember = "FacultyName";
            cbbKhoa.ValueMember = "FacultyID";
        }
        private void GetDataToTableStudent(List<STUDENT> list)
        {
            dataGridView1.Rows.Clear();
            int row;
            foreach (STUDENT item in list)
            {
                row= dataGridView1.Rows.Add();
                dataGridView1.Rows[row].Cells[0].Value = item.StudentID;
                dataGridView1.Rows[row].Cells[1].Value = item.FullName;
                dataGridView1.Rows[row].Cells[2].Value = item.FACULTY.FacultyName;
                dataGridView1.Rows[row].Cells[3].Value = item.AverageScore;
            }
        }


        private void btThem_Click(object sender, EventArgs e)
        {
            if (!xl.CheckInput(gbTTSV))
            {
                return;
            }
            if (!xl.CheckInputID(tbMSSV))
            {
                return;
            }
            float dtb;
            if (!float.TryParse(tbDiemTB.Text, out dtb))
            {
                MessageBox.Show("Nhập sai!!\nĐiểm trung bình phải là một số!!");
                tbDiemTB.Clear();
                return;
            }

            STUDENT st = new STUDENT();
            st.AverageScore = dtb;
            st.StudentID = tbMSSV.Text;
            st.FullName = tbHoten.Text;
            st.FacultyID = int.Parse(cbbKhoa.SelectedValue.ToString());
            try
            {
                db.STUDENTs.Add(st);
                db.SaveChanges();
                MessageBox.Show("Đã thêm!!");
                FormLoad();
                xl.ClearTextBox(gbTTSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm một Sinh viên!!"+ex.Message);
            }

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (!xl.CheckInput(gbTTSV))
            {
                return;
            }
            if (!xl.CheckInputID(tbMSSV))
            {
                return;
            }
            STUDENT st = db.STUDENTs.FirstOrDefault(i => i.StudentID == tbMSSV.Text);
            if (st == null)
            {
                MessageBox.Show("Không tìm thấy Sinh viên với mã là " + tbMSSV.Text);
                return;
            }
            float dtb;
            if (!float.TryParse(tbDiemTB.Text, out dtb))
            {
                MessageBox.Show("Nhập sai!!\nĐiểm trung bình phải là một số!!");
                tbDiemTB.Clear();
                return;
            }

  
            st.AverageScore = dtb;
            st.FullName = tbHoten.Text;
            st.FacultyID = int.Parse(cbbKhoa.SelectedValue.ToString());
            try
            {
                db.SaveChanges();
                MessageBox.Show("Đã lưu thông tin!!");
                FormLoad();
                xl.ClearTextBox(gbTTSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa thông tin Sinh viên!!" + ex.Message);
            }
 
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (tbMSSV.Text.Trim() == "")
            {
                MessageBox.Show("Chưa chọn SV nào!!");
                return;
            }
            STUDENT st = db.STUDENTs.FirstOrDefault(i => i.StudentID == tbMSSV.Text);
            if (st == null)
            {
                MessageBox.Show("Không tìm thấy Sinh viên với mã là " + tbMSSV.Text);
                return;
            }
            if(MessageBox.Show("Chắc chắn xóa Sinh viên này", "Chú ý!", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                try
                {
                    db.STUDENTs.Remove(st);
                    db.SaveChanges();
                    MessageBox.Show("Đã xóa!!");
                    FormLoad();
                    xl.ClearTextBox(gbTTSV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa Sinh viên!!" + ex.Message);
                }
            }
        }


        int ROWSELECTED = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ROWSELECTED = e.RowIndex;
            if (ROWSELECTED < 0)
                return;
            tbMSSV.Text = dataGridView1.Rows[ROWSELECTED].Cells[0].Value.ToString();
            tbHoten.Text = dataGridView1.Rows[ROWSELECTED].Cells[1].Value.ToString();
 
            cbbKhoa.Text = dataGridView1.Rows[ROWSELECTED].Cells[2].Value.ToString();
            tbDiemTB.Text = dataGridView1.Rows[ROWSELECTED].Cells[3].Value.ToString();
        }

        FormFaculty fFac;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (fFac == null)
            {
                fFac = new FormFaculty(this);
            }
            fFac.Show();
        }

        FormTimKiem ftk;
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (ftk == null)
            {
                ftk = new FormTimKiem();
            }
            ftk.Show();
        }
    }
}
