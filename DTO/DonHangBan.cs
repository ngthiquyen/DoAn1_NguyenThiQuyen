using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHangBan
    {
        public DonHangBan() { }
        public DonHangBan(string MaDHB,string MaNV, string MaKH,DateTime Ngayban, float TongThanhToan)
        {
            this.MaDHB=MaDHB;
            this.MaNV=MaNV;
            this.MaKH=MaKH;
            this.Ngayban=Ngayban;
            this.TongThanhToan=TongThanhToan;
        }
        public string MaDHB { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set;}
        public string TenNV { get; set; }
        public DateTime Ngayban { get; set; } 
        public float TongThanhToan { get; set; }
    }
}
