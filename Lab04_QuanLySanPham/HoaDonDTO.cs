using Lab04_QuanLySanPham.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_QuanLySanPham
{
    
    public class HoaDonDTO
    {
        QLSPModel db=new QLSPModel();
        public int stt { get; set; }
        public string sohd { get; set; }
        public DateTime ngaydat { get; set; }
        public DateTime ngaygiao { get; set; }
        public decimal thanhtien { get; set; }

        public HoaDonDTO()
        {
            thanhtien = 0;
        }

       
    }
}
