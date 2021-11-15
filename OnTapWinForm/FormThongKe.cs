using Microsoft.Reporting.WinForms;
using OnTapWinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTapWinForm
{
    public partial class FormThongKe : Form
    {
        QLSACHModel db = new QLSACHModel();
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            //List<SACH> list = db.SACHes.ToList();
            var list = from i in db.SACHes select new SachDTO1() { MaSach = i.MaSach, TenSach = i.TenSach, NamXB = i.NamXB, TenLoai = i.LOAISACH.TenLoai };
            reportViewer1.LocalReport.ReportPath = "Report99.rdlc";
            var reportdatasource = new ReportDataSource("DataSet1", list);
            reportViewer1.LocalReport.DataSources.Add(reportdatasource);
            this.reportViewer1.RefreshReport();
        }


    }
}
