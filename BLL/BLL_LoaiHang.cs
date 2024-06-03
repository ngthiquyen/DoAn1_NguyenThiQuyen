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
    public class BLL_LoaiHang
    {
        DAL_LoaiHang dalLoaiHang=new DAL_LoaiHang();
        public DataTable getData()
        {
            return dalLoaiHang.getData();
        }
        public bool ThemLH(LoaiHang lh)
        {
            return dalLoaiHang.ThemLH(lh);
        }
        public bool SuaLH(LoaiHang lh)
        {
            return dalLoaiHang.SuaLH(lh);
        }
        public bool XoaLH(string ma)
        {
            return dalLoaiHang.XoaLH(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dalLoaiHang.kiemtramatrung(ma);
        }
       
    }
}
