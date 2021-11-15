using Lab05_DanhSachSinhVien.Model;
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

namespace Lab05_DanhSachSinhVien
{
    public partial class Form1 : Form
    {
        QLSVModel db = new QLSVModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<STUDENT> list = db.STUDENTs.ToList();
            List<SVforReport> listrp = new List<SVforReport>();
            foreach (STUDENT item in list)
            {
                SVforReport tmp = new SVforReport();
                tmp.MaSv = item.StudentID;
                tmp.HoTen = item.FullName;
                tmp.DiemTB = item.AverageScore;
                tmp.TenKhoa = item.FACULTY.FacultyName;
                listrp.Add(tmp);
            }
            this.reportViewer1.LocalReport.ReportPath = "QLSV.rdlc";
            var reportdatasource = new ReportDataSource("SinhVienDataSet", listrp);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportdatasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
