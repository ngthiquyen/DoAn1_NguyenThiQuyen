using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_ChiTietDHB
    {
        DAL_ChiTietDHB dalChiTietDHB = new DAL_ChiTietDHB();
        public DataTable getData()
        {
            return dalChiTietDHB.getData();
        }

        public bool ThemCTDHB(ChiTietDHB ctdhb)
        {
            return dalChiTietDHB.ThemCTDHB(ctdhb);
        }
        public bool SuaCTDHB(ChiTietDHB ctdhb)
        {
            return dalChiTietDHB.SuaCTDHB(ctdhb);
        }
        public bool XoaCTDHB(string madhb,string mamh)
        {
            return dalChiTietDHB.XoaCTDHB(madhb,mamh);
        }
        public int kiemtramatrung(string ma)
        {
            return dalChiTietDHB.kiemtramatrung(ma);
        }
    }
}
