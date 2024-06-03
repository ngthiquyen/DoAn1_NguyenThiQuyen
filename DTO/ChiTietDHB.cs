using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietDHB
    {
        public ChiTietDHB()
        {

        }
        public ChiTietDHB(string MaDHB,string MaMH,int SLBan,float GiaBan )
        {
            this.MaDHB= MaDHB;
            this.MaMH= MaMH;
            this.SLBan = SLBan;
            this.GiaBan= GiaBan;
            
        }
        public string MaDHB { get;set; }
        public string MaMH { get;set; }
        public int SLBan { get;set;}
        public float GiaBan { get;set;}
        public double TongTien()
        {
            return SLBan * GiaBan;
        }
       
    }
}
