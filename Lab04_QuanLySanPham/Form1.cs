using Lab04_QuanLySanPham.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_QuanLySanPham
{
    public partial class Form1 : Form
    {
        QLSPModel db;
        public Form1()
        {
            InitializeComponent();
            db = new QLSPModel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void FormLoad()
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            GetDateToDate();
        }

        private void FixDataGirdView()
        {
            dataGridView1.Columns[0].HeaderText = "STT";
            dataGridView1.Columns[1].HeaderText = "Số HĐ";
            dataGridView1.Columns[2].HeaderText = "Ngày Đặt Hàng";
            dataGridView1.Columns[3].HeaderText = "Ngày Giao Hàng";
            dataGridView1.Columns[4].HeaderText = "Thành tiền";
        }

        #region tính_tổng_tiền_từng_hóa_đơn_theo_ngày
        private void GetDateToDate(bool month = false)
        {
            int stt = 1;
            List<HoaDonDTO> kq = new List<HoaDonDTO>();
            List<Invoice> list;
            if (month)
            {
                list = db.Invoices.Where(i => i.DeliveryDate.Month >= dateTimePicker1.Value.Month && i.DeliveryDate.Year >= dateTimePicker1.Value.Year && i.DeliveryDate.Month <= dateTimePicker2.Value.Month && i.DeliveryDate.Year <= dateTimePicker2.Value.Year).ToList();
            }
            else
            {
                list = db.Invoices.Where(i => i.DeliveryDate.Day >= dateTimePicker1.Value.Day && i.DeliveryDate.Month >= dateTimePicker1.Value.Month && i.DeliveryDate.Year >= dateTimePicker1.Value.Year && i.DeliveryDate.Day <= dateTimePicker2.Value.Day && i.DeliveryDate.Month <= dateTimePicker2.Value.Month && i.DeliveryDate.Year <= dateTimePicker2.Value.Year).ToList();
            }
            foreach (Invoice item in list.ToList())
            {
                HoaDonDTO hd = new HoaDonDTO();
                hd.stt = stt++;
                foreach (ORDER cthd in db.ORDERs.Where(i => i.InvoiceNo == item.InvoiceNo).ToList())
                {
                    hd.sohd = cthd.InvoiceNo;
                    hd.ngaydat = cthd.Invoice.OrderDate;
                    hd.ngaygiao = cthd.Invoice.DeliveryDate;
                    hd.thanhtien += cthd.Price * cthd.Quantity;
                }
                kq.Add(hd);
            }
            dataGridView1.DataSource = kq;
            FixDataGirdView();
            tbTongCong.Text = kq.Count.ToString();
        }
        #endregion


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dt= sender as DateTimePicker;
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                dateTimePicker2.Value = dateTimePicker1.Value = dt.Value;
            }

            GetDateToDate();
        }


        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                GetDateToDate(true);
            }
            else
            {
                FormLoad();
            }
        }
    }
}
