using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KhachHang :DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from KhachHang";
            return connect.getData(sql);//chứa dữ liệu bảng KhachHang
        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from KhachHang where MaKH='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        /// <summary>
        /// Thêm khách hàng
        /// </summary>
        /// <param name="kh"></param>
        /// <returns></returns>
        public bool ThemKH(KhachHang kh)
        {
            //xử lý ngày
            //string Ngaysinh = string.Format("{0}/{1}/{2}", Ngaysinh.Now.Year, datetime.Now.Month, datetime.Now.Day);

            string sql = string.Format("Insert into KhachHang values('" + kh.MaKH + "',N'" + kh.TenKH + "',N'" + kh.Diachi + "',N'" + kh.Email + "','" + kh.SDT + "',N'" + kh.GTinh + "','" + kh.Ngaysinh + "')");
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Sửa khách hàng 
        /// </summary>
        /// <param name="kh"></param>
        /// <returns></returns>
        public bool SuaKH(KhachHang kh)
        {
            string sql = string.Format("Update KhachHang set TenKH=N'{0}', Diachikh=N'{1}',  email='{2}',Sdt='{3}', gioitinh=N'{4}', ngaysinh= '{5}' where MaKH= '{6}' ", kh.TenKH, kh.Diachi,  kh.Email, kh.SDT, kh.GTinh,kh.Ngaysinh ,kh.MaKH);
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Xóa khách hàng 
        /// </summary>
        /// <param name="kh"></param>
        /// <returns></returns>
        public bool XoaKH(string ma)
        {
            string sql = string.Format("Delete from KhachHang where MaKH='" + ma + "'");
            thucthisql(sql);
            return true;
        }
    }
}
