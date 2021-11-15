using De02.Model;
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

namespace De02
{
    public partial class frmThongKe : Form
    {
        QLSanPhamModel db = new QLSanPhamModel();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {

            var list = db.Sanphams.ToList(); 
            reportViewer1.LocalReport.ReportPath = "R_DSSanPham.rdlc";
            var reportdatasource = new ReportDataSource("DataSet1", list);
            reportViewer1.LocalReport.DataSources.Add(reportdatasource);
            this.reportViewer1.RefreshReport();
        }
    }
}
