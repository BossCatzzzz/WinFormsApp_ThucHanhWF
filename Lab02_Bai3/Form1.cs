using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeSeat();
        }

        void InitializeSeat()
        {
            for (int i = 0; i < 15; i++)
            {
                Button bt = new Button();
                if(i<5)
                {
                    bt.Tag = 5000;
                }
                else if(i<10)
                {
                    bt.Tag = 6500;
                }
                else
                {
                    bt.Tag = 8000;
                }
                bt.Width = bt.Height = 80;
                bt.Click += new EventHandler(bt1_Click);
                bt.BackColor = Color.White;
                bt.Text = (i + 1).ToString();
                flowLayoutPanel1.Controls.Add(bt);
            }
        }

        void TinhTien()
        {
            int sum = 0;
            foreach (Button btnGhe in flowLayoutPanel1.Controls.OfType<Button>().Where(x => x.BackColor == Color.DodgerBlue))
            {
                
                sum += int.Parse(btnGhe.Tag.ToString());
                btnGhe.BackColor = Color.Yellow;
            }
            tbThanhTien.Text = sum.ToString();

        }


        private void bt1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if(bt.BackColor==Color.White)
            {
                bt.BackColor = Color.DodgerBlue;
            }
            else if (bt.BackColor == Color.DodgerBlue)
            {
                bt.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Ghế đã được chọn");
            }
        }

        private void btChon_Click(object sender, EventArgs e)
        {
            TinhTien();
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            foreach (Button btnGhe in flowLayoutPanel1.Controls.OfType<Button>().Where(x => x.BackColor == Color.DodgerBlue))
            {
                btnGhe.BackColor = Color.White;
            }
            tbThanhTien.Text = "0";
        }
    }
}
