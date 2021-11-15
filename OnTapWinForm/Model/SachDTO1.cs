using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapWinForm.Model
{
   public class SachDTO1
    {
        public string MaSach { get; set; }

        public string TenSach { get; set; }

        public int NamXB { get; set; }

        public string TenLoai { get; set; }

        public SachDTO1()
        {
        }

        public SachDTO1(string maSach, string tenSach, int namXB, string tenLoai)
        {
            MaSach = maSach;
            TenSach = tenSach;
            NamXB = namXB;
            TenLoai = tenLoai;
        }
    }
}
