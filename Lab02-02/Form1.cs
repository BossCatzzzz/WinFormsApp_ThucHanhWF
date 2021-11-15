using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbChuyenNganh.DataSource = new List<String> { "QTKD", "CNTT", "NNA" };
        }

        private XuLy XULY = new XuLy();
        private void Form1_Load(object sender, EventArgs e)
        {
            ReLoad();
        }
        void ReLoad()
        {
            int SLNAM = 0, SLNU = 0;
            for (int i = 0; i < dgvDSSV.RowCount; i++)
            {
                if (dgvDSSV.Rows[i].Cells[2].Value.Equals("Nam"))
                {
                    SLNAM++;
                }
                else
                {
                    SLNU++;
                }
            }
            cbbChuyenNganh.DisplayMember = "QTKD";
            tbSLNam.Text = SLNAM.ToString();
            tbSLNu.Text = SLNU.ToString();
            rdNu.Checked = true;

        }
        private void Them_Sua(int row)
        {
            if (!XULY.checkTextBox(groupBox1))
            {
                MessageBox.Show("Chưa nhập đầy đủ thông tin !", "CHÚ Ý !!!");
                return;
            }
            float dtb;
            if (!float.TryParse(tbDiemTB.Text, out dtb))
            {
                MessageBox.Show("Điểm trung bình phải là số !!!");
                tbDiemTB.Text = "";
                return;
            }
            dgvDSSV.Rows[row].Cells[3].Value = dtb;
            dgvDSSV.Rows[row].Cells[0].Value = tbMaSV.Text;
            dgvDSSV.Rows[row].Cells[1].Value = tbTenSV.Text;
            dgvDSSV.Rows[row].Cells[2].Value = (rdNam.Checked) ? "Nam" : "Nữ";
            dgvDSSV.Rows[row].Cells[4].Value = cbbChuyenNganh.SelectedItem.ToString();
            MessageBox.Show("Đã cập nhật!");
        }


        private void btThem_Sua_Click(object sender, EventArgs e)
        {
            int row = XULY.FindKey(dgvDSSV, tbMaSV.Text);
            if (row != -1)
            {
                Them_Sua(row);
            }
            else
            {
                row = dgvDSSV.Rows.Add();
                Them_Sua(row);
            }
            ReLoad();
            XULY.ClearTextBox(groupBox1);
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int row = XULY.FindKey(dgvDSSV, tbMaSV.Text);
            if (row == -1)
            {
                MessageBox.Show("Không tìm thấy sinh viên với mã " + tbMaSV.Text);
            }
            else
            {
                DialogResult dia = MessageBox.Show("bạn có muốn xóa sinh viên " + tbMaSV.Text, "", MessageBoxButtons.YesNo);
                if (dia == DialogResult.Yes)
                {
                    dgvDSSV.Rows.RemoveAt(row);
                    MessageBox.Show("Đã xóa !!");
                }
            }
            ReLoad();
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int row = e.RowIndex;
            if (row < 0)
                return;

            tbMaSV.Text = dgvDSSV.Rows[row].Cells[0].Value.ToString();
            tbTenSV.Text = dgvDSSV.Rows[row].Cells[1].Value.ToString();
            tbDiemTB.Text = dgvDSSV.Rows[row].Cells[3].Value.ToString();
            cbbChuyenNganh.SelectedItem = dgvDSSV.Rows[row].Cells[4].Value.ToString();
            if (dgvDSSV.Rows[row].Cells[2].Value.ToString().Equals("Nam"))
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }

        }
    }
}
