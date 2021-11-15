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
    public partial class Form2 : Form
    {
        DataTable here;
        int stt;
        public Form2(DataTable get)
        {
            InitializeComponent();
            string[] khoa = { "Công nghệ thông tin", "Ngôn ngữ Anh", "Quản trị kinh doanh" };
            cbbKhoa.DataSource = khoa;
            cbbKhoa.DisplayMember = khoa[0];
            here = get;
            stt = here.Rows.Count;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThemMoi_Click(object sender, EventArgs e)
        {
            if(checkInput())
            {
                DataRow dt = here.NewRow();
                dt.ItemArray = new object[] { ++stt, tbMSSV.Text, tbTenSV.Text.ToLower(), cbbKhoa.SelectedItem, tbDiemTB.Text };
                here.Rows.Add(dt);
            }
        }

        #region Kiểm tra nhập
        private bool checkInput()
        {
            if(string.IsNullOrEmpty(tbDiemTB.Text)||string.IsNullOrWhiteSpace(tbDiemTB.Text) || string.IsNullOrEmpty(tbMSSV.Text) || string.IsNullOrWhiteSpace(tbMSSV.Text) || string.IsNullOrEmpty(tbTenSV.Text) || string.IsNullOrWhiteSpace(tbTenSV.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }
            float x;
            if(float.TryParse(tbDiemTB.Text,out x))
            {
                if (x < 0 || x > 10)
                {
                    tbDiemTB.Focus();
                    MessageBox.Show("Điểm trung bình phải lớn hơn 0 và nhỏ hơn 10");
                    return false;
                }
            }
            else
            {
                tbDiemTB.Focus();
                MessageBox.Show("Điểm trung bình phải là một số");
                return false;
            }
            foreach (DataRow item in here.Rows)
            {
                if(item[1].ToString()==tbMSSV.Text)
                {
                    MessageBox.Show("Mã này đã tồn tại, hãy nhập mã khác");
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}
