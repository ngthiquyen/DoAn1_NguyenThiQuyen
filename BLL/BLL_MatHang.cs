using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using DTO;
using System.Data.SqlClient;

namespace BLL
{
    public class BLL_MatHang
    {
        //khởi tạo đối tượng thuộc lớp DAL_MatHang
        DAL_MatHang dal_mh = new DAL_MatHang();
        public DataTable getData()
        {
            return dal_mh.getData();//dữ liệu từ dal đã đc chuyển vào Bus
        }
        public int kiemtramatrung(string ma)
        {
            return dal_mh.kiemtramatrung(ma);
        }
        public bool ThemMH(MatHang mh)
        {
            return dal_mh.ThemMH(mh);
        }
        public bool SuaMH(MatHang mh)
        {
            return dal_mh.SuaMH(mh);
        }
        public bool XoaMH(string ma)
        {
            return dal_mh.XoaMH(ma);
        }
        public bool TangSoLuong(string ma, int soLuong)
        {
            return dal_mh.TangSoLuong(ma, soLuong);//phương thức Tăng số lượng khi nhập hàng hoặc khi huỷ đơn hàng bán
        }
        public bool GiamSoLuong(string ma, int soLuong)
        {
            return dal_mh.GiamSoLuong(ma, soLuong);//phương thức giảm số lượng khi huỷ nhập hàng hoặc khi thêm đơn hàng bán
        }
    }
}
