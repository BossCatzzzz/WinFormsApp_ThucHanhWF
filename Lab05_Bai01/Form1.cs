using Lab05_Bai01.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Bai01
{
    public partial class Form1 : Form
    {
        SanPhamModel db = new SanPhamModel();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            radioButtonXemGia.Checked = true;
            comboBox1.Enabled = false;
            this.reportViewer1.RefreshReport();


            
        }

        private void buttonXuat_Click(object sender, EventArgs e)
        {
            if(radioButtonXemGia.Checked==true)
            {
                reportViewer1.Visible = true;
                List<PRODUCT> list = db.PRODUCTs.ToList();
                List<SanPhamDTO> listrp = new List<SanPhamDTO>();
                foreach (PRODUCT item in list)
                {
                    SanPhamDTO tmp = new SanPhamDTO();
                    tmp.ma = item.ProductId;
                    tmp.ten = item.ProductName;
                    tmp.dvt = item.Unit;
                    tmp.gia = item.SellPrice;
                    listrp.Add(tmp);
                }
                reportViewer1.LocalReport.ReportPath = "Report9.rdlc";
                var reportdatasource = new ReportDataSource("SanPhamDataSet", listrp);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportdatasource);
                reportViewer1.RefreshReport();
            }
            else
            {
                reportViewer1.Visible = true;
                List<ORDER> list = db.ORDERs.Where(i=>i.InvoiceNo==comboBox1.Text).ToList();
                List<SanPhamDTO> listrp = new List<SanPhamDTO>();
                foreach (ORDER item in list)
                {
                    SanPhamDTO tmp = new SanPhamDTO();
                    tmp.ma = item.ProductId;
                    tmp.ten = item.ProductName;
                    tmp.dvt = item.Unit;
                    tmp.gia = item.Price;
                    tmp.soluong = item.Quantity;
                    tmp.thanhtien = (double?)(item.Quantity * item.Price);
                    listrp.Add(tmp);
                }
                reportViewer1.LocalReport.ReportPath = "Report10.rdlc";
                var reportdatasource = new ReportDataSource("DataSet1", listrp);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportdatasource);
                reportViewer1.RefreshReport();
            }
        }

        private void radioButtonXemPhieuGiao_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonXemPhieuGiao.Checked)
            {
                comboBox1.DataSource = db.Invoices.ToList();
                comboBox1.DisplayMember = "InvoiceNo";
                comboBox1.ValueMember = "InvoiceNo";
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }

        }
    }
}
