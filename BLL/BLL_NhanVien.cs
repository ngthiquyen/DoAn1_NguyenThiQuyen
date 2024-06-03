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
    public class BLL_NhanVien
    {
        DAL_NhanVien dalNhanVien = new DAL_NhanVien();
        public DataTable getData()
        {
            return dalNhanVien.getData();
        }
        public bool ThemNV(NhanVien nv)
        {
            return dalNhanVien.ThemNV(nv);
        }
        public bool SuaNV(NhanVien nv)
        {
            return dalNhanVien.SuaNV(nv);
        }
        public bool XoaNV(string ma)
        {
            return dalNhanVien.XoaNV(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dalNhanVien.kiemtramatrung(ma);
        }
    }
}
