using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongKe
    {
        public ThongKe()
        {

        }
        public ThongKe(string MaNV,string TenNV, float Luong)
        {
            this.MaNV=MaNV;
            this.TenNV=TenNV;
            this.Luong=Luong;
        }
        public string MaNV { get; set; } 
        public string TenNV { get; set; }
        public float Luong { get; set;}
    }
}
