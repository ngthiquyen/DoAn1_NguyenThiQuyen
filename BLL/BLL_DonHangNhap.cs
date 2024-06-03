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
    public class BLL_DonHangNhap
    {
        DAL_DonHangNhap dalDonHangNhap = new DAL_DonHangNhap();
        DAL_ChiTietDHN dalChitietDHN = new DAL_ChiTietDHN();
        public DataTable getData()
        {
            return dalDonHangNhap.getData();
        }
        public DataTable getCombo1()
        {
            return dalDonHangNhap.getCombo1();
        }
        public DataTable getCombo2()
        {
            return dalDonHangNhap.getCombo2();
        }
        public bool ThemDHN(DonHangNhap dhn)
        {
            return dalDonHangNhap.ThemDHN(dhn);
        }
        public bool SuaDHN(DonHangNhap dhn)
        {
            return dalDonHangNhap.SuaDHN(dhn);
        }
        public bool XoaDHN(string ma)
        {
            return dalDonHangNhap.XoaDHN(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dalDonHangNhap.kiemtramatrung(ma);
        }
        public float TongTien(string maDHN)
        {
            return dalChitietDHN.TongTien(maDHN);// tính tổng tiền ở bảng chi tiết nhập và cập nhật lên tổng tiền ở bảng đơn hàng nhập
        }
    }
}
