using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MatHang
    { 
        public MatHang(string ma, string maLH, string tenMH, string donVi, int soLuong, string mau, float gia, string mota, string size)
        {
            this.ma = ma;
            MaLH = maLH;
            TenMH = tenMH;
            DonVi = donVi;
            SoLuong = soLuong;
            Mau = mau;
            Gia = gia;
            Mota = mota;
            Size = size;
        }

        public string ma { get; set; }
        public string TenMH { get; set; }
        public string MaLH { get; set; }
        public string Mota { get; set; }
        public float Gia { get; set; }
        public int SoLuong { get; set; }
        public string Size { get; set; }
        public string DonVi { get; set; }
        public string Mau { get; set; }
    }
    
}
