using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class DAL_NhanVien:DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from NhanVien";
            return connect.getData(sql);//chứa dữ liệu bảng NhanVien
        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from NhanVien where MaNV='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        /// <summary>
        /// Thêm nhân viên
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public bool ThemNV(NhanVien nv)
        {
            //xử lý ngày
            //string Ngaysinh = string.Format("{0}/{1}/{2}", Ngaysinh.Now.Year, datetime.Now.Month, datetime.Now.Day);

            string sql = string.Format("Insert into NhanVien values('" + nv.MaNV + "',N'" + nv.TenNV + "',N'" + nv.GTinh + "','" + nv.Ngaysinh + "',N'" + nv.Diachi + "',N'" + nv.Email + "','" + nv.SDT + "', '" + nv.Luong + "')");
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Sửa nhân viên
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public bool SuaNV(NhanVien nv)
        {
            string sql = string.Format("Update NhanVien set Hoten=N'{0}',gioitinh=N'{1}', ngaysinh= '{2}', Diachinv=N'{3}',  email='{4}',Sdt='{5}', Luong ='{6}' where MaNV= '{7}' ", nv.TenNV, nv.GTinh, nv.Ngaysinh, nv.Diachi, nv.Email, nv.SDT,nv.Luong,nv.MaNV);
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Xóa nhân viên 
        /// </summary>
        /// <param name="nv"></param>
        /// <returns></returns>
        public bool XoaNV(string ma)
        {
            string sql = string.Format("Delete from NhanVien where MaNV='" + ma + "'");
            thucthisql(sql);
            return true;
        }
    }
}
