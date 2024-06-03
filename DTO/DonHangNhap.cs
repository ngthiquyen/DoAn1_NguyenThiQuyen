using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class DonHangNhap
    {
        public DonHangNhap()
        { }
        public DonHangNhap(string MaDHN,string MaNV,string MaNCC,DateTime Ngaynhap, float TongThanhToan)
        {
            this.MaDHN=MaDHN;
            this.MaNV=MaNV;
            this.MaNCC=MaNCC;
            this.Ngaynhap=Ngaynhap;
            this.TongThanhToan=TongThanhToan;
        }
        public string MaDHN { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set;}
        public DateTime Ngaynhap { get; set; }
        public float TongThanhToan { get; set; }
    }
}
