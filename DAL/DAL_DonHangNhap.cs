using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DonHangNhap:DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from DonHangNhap";
            return connect.getData(sql);//chứa dữ liệu bảng DonHangNhap
            
        }
        public DataTable getCombo1()
        {
            string sql = "select MaNV from NhanVien";
            return connect.getData(sql);//chứa dữ liệu cột Mã nhân viên

        }
        public DataTable getCombo2() 
        {
            string sql = "select MaNCC from NhaCC";
            return connect.getData(sql);//chứa dữ liệu cột Mã nhà cung cấp
        }
       
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from DonHangNhap  where MaDHN='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        /// <summary>
        /// Thêm đơn hàng nhập
        /// </summary>
        /// <param name="dhn"></param>
        /// <returns></returns>
        public bool ThemDHN(DonHangNhap dhn)
        {
            //xử lý ngày 
            //string date=string.Format("{0}/{1}/{2}", datetimePicker1.Now.Year,datetimePicker1.Now.Month,datetimePicker1.Now.Day);  

            string sql = string.Format("Insert into DonHangNhap values('" + dhn.MaDHN + "',N'" + dhn.MaNV + "',N'" + dhn.MaNCC + "','" + dhn.Ngaynhap + "', '"+dhn.TongThanhToan+"')");
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Sửa đơn hàng nhập
        /// </summary>
        /// <param name="dhn"></param>
        /// <returns></returns>
        public bool SuaDHN(DonHangNhap dhn)
        {
            string sql = string.Format("Update DonHangNhap set MaNV=N'{0}', MaNCC=N'{1}', Ngaynhap='{2}', TongThanhToan='{3}' where MaDHN= '{4}' ", dhn.MaNV, dhn.MaNCC,dhn.Ngaynhap,dhn.TongThanhToan, dhn.MaDHN);
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Xóa đơn hàng nhập
        /// </summary>
        /// <param name="">dhn</param>
        /// <returns></returns>
        public bool XoaDHN(string ma)
        {
            string sql = string.Format("Delete from DonHangNhap where MaDHN='" + ma + "'");
            thucthisql(sql);
            return true;
        }

    }
}
