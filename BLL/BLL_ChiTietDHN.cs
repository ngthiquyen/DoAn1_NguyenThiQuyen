using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BLL
{
    public class BLL_ChiTietDHN
    {
        DAL_ChiTietDHN dalChiTietDHN = new DAL_ChiTietDHN();
        public DataTable getData()
        {
            return dalChiTietDHN.getData();
        }
        

        public bool ThemCTDHN(ChiTietDHN ctdhn)
        {
            return dalChiTietDHN.ThemCTDHN(ctdhn);
        }
        public bool SuaCTDHN(ChiTietDHN ctdhn)
        {
            return dalChiTietDHN.SuaCTDHN(ctdhn);
        }
        public bool XoaCTDHN(string madhn,string mamh)
        {
            return dalChiTietDHN.XoaCTDHN(madhn,mamh);
        }
        public int kiemtramatrung(string ma)
        {
            return dalChiTietDHN.kiemtramatrung(ma);
        }
    }
}
