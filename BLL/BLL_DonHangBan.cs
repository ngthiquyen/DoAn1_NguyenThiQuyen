using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using DAL;
namespace BLL
{
    public class BLL_DonHangBan
    {
        DAL_DonHangBan dalDonHangBan = new DAL_DonHangBan();
        DAL_ChiTietDHB dalChitietDHB= new DAL_ChiTietDHB();
        public DataTable getData()
        {
            return dalDonHangBan.getData();
        }
        public DataTable getCombo1()
        {
            return dalDonHangBan.getCombo1();
        }
        public DataTable getCombo2()
        {
            return dalDonHangBan.getCombo2();
        }
        public bool ThemDHB(DonHangBan dhb)
        {
            return dalDonHangBan.ThemDHB(dhb);
        }
        public bool SuaDHB(DonHangBan dhb)
        {
            return dalDonHangBan.SuaDHB(dhb);
        }
        public bool XoaDHB(string ma)
        {
            return dalDonHangBan.XoaDHB(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dalDonHangBan.kiemtramatrung(ma);
        }
        public float TongTien(string maDHB)
        {
            return dalChitietDHB.TongTien(maDHB);// tính tổng tiền ở bảng chi tiết bans và cập nhật lên tổng tiền ở bảng đơn hàng bán
        }
    }
}
