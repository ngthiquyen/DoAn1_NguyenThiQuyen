using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DonHangBan:DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from DonHangBan";
            return connect.getData(sql);//chứa dữ liệu bảng DonHangBan
        }
        public DataTable getCombo1()
        {
            string sql = "select Hoten from NhanVien";
            return connect.getData(sql);//chứa dữ liệu cột Ten nhân viên

        }
        public DataTable getCombo2()
        {
            string sql = "select TenKH from KhachHang";
            return connect.getData(sql);//chứa dữ liệu cột Mã Khách hàng

        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from DonHangBan  where MaDHB='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        /// <summary>
        /// Thêm đơn hàng bán
        /// </summary>
        /// <param name="dhb"></param>
        /// <returns></returns>
        public bool ThemDHB(DonHangBan dhb)
        {
            //xử lý ngày 
            //string date=string.Format("{0}/{1}/{2}", datetimePicker1.Now.Year,datetimePicker1.Now.Month,datetimePicker1.Now.Day);  

            string sql = string.Format("Insert into DonHangBan values('" + dhb.MaDHB + "',N'" + dhb.MaNV + "',N'" + dhb.MaKH + "','" + dhb.Ngayban + "', '"+dhb.TongThanhToan+"')");
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Sửa đơn hàng bán
        /// </summary>
        /// <param name="dhb"></param>
        /// <returns></returns>
        public bool SuaDHB(DonHangBan dhb)
        {
            string sql = string.Format("Update DonHangBan set MaNV=N'{0}', MaKH=N'{1}', Ngayban='{2}',TongThanhToan='{3}' where MaDHB= '{4}' ", dhb.MaNV, dhb.MaKH, dhb.Ngayban, dhb.TongThanhToan, dhb.MaDHB);
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Xóa đơn hàng bán
        /// </summary>
        /// <param name="">dhb</param>
        /// <returns></returns>
        public bool XoaDHB(string ma)
        {
            string sql = string.Format("Delete from DonHangBan where MaDHB='" + ma + "'");
            thucthisql(sql);
            return true;
        }
    }
}
