using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiHang
    {
        public LoaiHang()
        {
        }

        public LoaiHang(string ma, string tenLH)
        {
            this.ma = ma;
            this.TenLH = tenLH;
        }

        public string ma { get; set; }
        public string TenLH { get; set; }
       
    }
        
}
