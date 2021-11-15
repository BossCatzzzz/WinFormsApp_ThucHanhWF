using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Bai1
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }
        //bla bla bla....
        private void Calculator(object bt, EventArgs e)
        {
            tbKetQua.Text = "";
            Button pheptinh = bt as Button;
            double a, b=0,kq=0;
            if (!Double.TryParse(tbSoA.Text,out a)|| !Double.TryParse(tbSoB.Text, out b))
            {
                tbKetQua.Text = "Nhập sai, vui lòng nhập lại!!";
                MessageBox.Show("Bạn phải nhập một số!!");
                return;
            }
            switch (pheptinh.Text)
            {
                case "+":
                    {
                        kq = a + b;
                        break;
                    }
                case "-":
                    {
                        kq = a - b;
                        break;
                    }
                case "x":
                    {
                        kq = a * b;
                        break;
                    }
                case "/":
                    {
                        if(b==0)
                        {
                            MessageBox.Show("Không thể thực hiện phép chia cho 0");
                            return;
                        }
                        kq = a / b;
                        break;
                    }
            }
            tbKetQua.Text = kq.ToString();
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            tbKetQua.Text = "";
        }
    }
}
