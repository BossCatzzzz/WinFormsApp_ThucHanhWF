using Lab04_QuanLySinhVien.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_QuanLySinhVien
{
    public class Handle
    {
        public bool CheckInput(Control ct)
        {
            foreach (TextBox item in ct.Controls.OfType<TextBox>())
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                    return false;
                }
            }
            return true;
        }

        public bool CheckInputID(TextBox tb)
        {
            if (tb.Text.Trim().Length != 10)
            {
                MessageBox.Show("Mã số sinh viên phải có 10 ký tự!");
                return false;
            }
            return true;
        }

        public void ClearTextBox(Control ct)
        {
            foreach (TextBox item in ct.Controls.OfType<TextBox>())
            {
                item.Text = "";
            }
        }



    }
}
