using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDHN
    {
        public ChiTietDHN()
        {

        }
        public ChiTietDHN(string MaDHN,string MaMH, int SLNhap, float GiaNhap)
        {
            this.MaDHN=MaDHN;
            this.MaMH=MaMH;
            this.SLNhap=SLNhap;
            this.GiaNhap=GiaNhap;
           
        }
        public string MaDHN { get; set;}
        public string MaMH { get; set;}
        public int SLNhap { get; set;}
        public float GiaNhap { get;set;}
        public string TenMH { get; set;}
        public double TongTien()
        {
            return SLNhap * GiaNhap;
        }
    }
}
