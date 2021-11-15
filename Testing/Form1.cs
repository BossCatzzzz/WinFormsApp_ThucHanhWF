using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button11.Focus();
            panel1.TabIndex = 5;
            button11.GotFocus += new System.EventHandler(bt11_test);
            //new System.EventHandler(this.button1_Click);
        }

        void bt11_test(object sender, EventArgs e)
        {
            MessageBox.Show("", "ok");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button11_TabStopChanged(object sender, EventArgs e)
        {
            MessageBox.Show("", "tabstop");
        }

        private void button11_TabIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("", "tabindexchange");
        }
    }
}
