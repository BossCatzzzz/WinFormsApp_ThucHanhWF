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
    public partial class FormTimKiem : Form
    {
        QLSVModel db;
        public FormTimKiem()
        {
            InitializeComponent();
            db = new QLSVModel();
            FormLoad();


        }
         private void FormLoad()
        {
            dataGridView1.DataSource = null;
            tbMSSV.Text = "";tbHoten.Text = "";
            tbKetQuaTimKiem.Text = "0";
            List<FACULTY> list = db.FACULTies.ToList();
            cbbKhoa.DataSource = list;
            cbbKhoa.DisplayMember = "FacultyName";
            cbbKhoa.ValueMember = "FacultyID";
            cbbKhoa.SelectedItem = null;
        }

        private void btTroVe_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            List<STUDENT> list=new List<STUDENT>() ;
            if (tbMSSV.Text.Trim()!=""&&tbHoten.Text.Trim()!=""&&cbbKhoa.Text != "")
            {
                list = db.STUDENTs.Where(i => i.StudentID.Contains(tbMSSV.Text) && i.FullName.ToLower().Contains(tbHoten.Text.ToLower()) && i.FacultyID.ToString() == cbbKhoa.SelectedValue.ToString()).ToList();
                dataGridView1.DataSource = list;
            }
            else if(tbMSSV.Text.Trim() != "" && tbHoten.Text.Trim() != "" && cbbKhoa.Text == "")
            {
                list = db.STUDENTs.Where(i => i.StudentID.Contains(tbMSSV.Text) && i.FullName.ToLower().Contains(tbHoten.Text.ToLower())).ToList();
                dataGridView1.DataSource = list;
            }
            else if (tbMSSV.Text.Trim() != "" && tbHoten.Text.Trim() == "" && cbbKhoa.Text != "")
            {
                list = db.STUDENTs.Where(i => i.StudentID.Contains(tbMSSV.Text) &&  i.FacultyID.ToString() == cbbKhoa.SelectedValue.ToString()).ToList();
                dataGridView1.DataSource = list;
            }
            else if (tbMSSV.Text.Trim() == "" && tbHoten.Text.Trim() != "" && cbbKhoa.Text != "")
            {
                list = db.STUDENTs.Where(i => i.FullName.ToLower().Contains(tbHoten.Text.ToLower()) && i.FacultyID.ToString() == cbbKhoa.SelectedValue.ToString()).ToList();
                dataGridView1.DataSource = list;
            }
            else if (tbMSSV.Text.Trim() == "" && tbHoten.Text.Trim() == "" && cbbKhoa.Text != "")
            {
                list = db.STUDENTs.Where(i =>  i.FacultyID.ToString() == cbbKhoa.SelectedValue.ToString()).ToList();
                dataGridView1.DataSource = list;
            }
            else if (tbMSSV.Text.Trim() != "" && tbHoten.Text.Trim() == "" && cbbKhoa.Text == "")
            {
                list = db.STUDENTs.Where(i => i.StudentID.Contains(tbMSSV.Text)).ToList();
                dataGridView1.DataSource = list;
            }
            else if (tbMSSV.Text.Trim() == "" && tbHoten.Text.Trim() != "" && cbbKhoa.Text == "")
            {
                list = db.STUDENTs.Where(i =>  i.FullName.ToLower().Contains(tbHoten.Text.ToLower())).ToList();
                dataGridView1.DataSource = list;
            }
            tbKetQuaTimKiem.Text = list.Count.ToString();
            dataGridView1.Columns[0].HeaderText = "Mã số SV";
            dataGridView1.Columns[1].HeaderText = "Họ tên";
            dataGridView1.Columns[2].HeaderText = "Điểm TB";
            dataGridView1.Columns[3].HeaderText = "Khoa";
            dataGridView1.Columns[4].Visible = false;

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            FormLoad();
        }
    }
}
