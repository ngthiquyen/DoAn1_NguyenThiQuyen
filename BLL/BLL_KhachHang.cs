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
    public class BLL_KhachHang
    {
        DAL_KhachHang dalKhachHang = new DAL_KhachHang();
        public DataTable getData()
        {
            return dalKhachHang.getData();
        }
        public bool ThemKH(KhachHang kh)
        {
            return dalKhachHang.ThemKH(kh);
        }
        public bool SuaKH(KhachHang kh)
        {
            return dalKhachHang.SuaKH(kh);
        }
        public bool XoaKH(string ma)
        {
            return dalKhachHang.XoaKH(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dalKhachHang.kiemtramatrung(ma);
        }
    }
}
