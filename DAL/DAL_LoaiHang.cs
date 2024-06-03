using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_LoaiHang:DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect
        DBConnect connect = new DBConnect();
        LoaiHang lh = new LoaiHang();
       
        public DataTable getData()
        {
            string sql = "Select * from LoaiHang";
            return connect.getData(sql);//chứa dữ liệu bảng LoaiHang
        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from LoaiHang  where MaLH='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        /// <summary>
        /// Thêm loại hàng
        /// </summary>
        /// <param name="lh"></param>
        /// <returns></returns>
        public bool ThemLH(LoaiHang lh)
        { 
            //xử lý ngày 
            //string date=string.Format("{0}/{1}/{2}", datetimePicker1.Now.Year,datetimePicker1.Now.Month,datetimePicker1.Now.Day);  
            
                string sql = string.Format("Insert into LoaiHang values('"+ lh.ma + "',N'"+ lh.TenLH + "')");
                thucthisql(sql);
                return true;
        }
        /// <summary>
        /// Sửa loại hàng
        /// </summary>
        /// <param name="lh"></param>
        /// <returns></returns>
        public bool SuaLH(LoaiHang lh)
        {
            string sql=string.Format("Update LoaiHang set TenLH=N'{0}' where MaLH= '{1}' ", lh.TenLH,lh.ma);
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Xóa loại hàng
        /// </summary>
        /// <param name="lh"></param>
        /// <returns></returns>
        public bool XoaLH(string ma)
        {
            string sql = string.Format("Delete from LoaiHang where MaLH='"+ma +"'");
            thucthisql(sql);
            return true;
        }
        
    }
}
