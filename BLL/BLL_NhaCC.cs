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
    public class BLL_NhaCC
    {
        DAL_NhaCC dalNhaCC = new DAL_NhaCC();
        public DataTable getData()
        {
            return dalNhaCC.getData();
        }
        public bool ThemNCC(NhaCC ncc)
        {
            return dalNhaCC.ThemNCC(ncc);
        }
        public bool SuaNCC(NhaCC ncc)
        {
            return dalNhaCC.SuaNCC(ncc);
        }
        public bool XoaNCC(string ma)
        {
            return dalNhaCC.XoaNCC(ma);
        }
        public int kiemtramatrung(string ma)
        {
            return dalNhaCC.kiemtramatrung(ma);
        }
    }
}
