using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class DAL_NhaCC:DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from NhaCC";
            return connect.getData(sql);//chứa dữ liệu bảng NhaCC
        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from NhaCC  where MaNCC='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        /// <summary>
        /// Thêm nhà cung cấp
        /// </summary>
        /// <param name="ncc"></param>
        /// <returns></returns>
        public bool ThemNCC(NhaCC ncc)
        {
            //xử lý ngày 
            //string date=string.Format("{0}/{1}/{2}", datetimePicker1.Now.Year,datetimePicker1.Now.Month,datetimePicker1.Now.Day);  

            string sql = string.Format("Insert into NhaCC values('" + ncc.MaNCC + "',N'" + ncc.TenNCC + "',N'"+ ncc.Diachi +"','"+ ncc.SDT +"',N'"+ ncc.Email +"')");
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Sửa nhà cung cấp
        /// </summary>
        /// <param name="ncc"></param>
        /// <returns></returns>
        public bool SuaNCC(NhaCC ncc)
        {
            string sql = string.Format("Update NhaCC set Tenncc=N'{0}', Diachi=N'{1}', Sdt='{2}', email='{3}' where Mancc= '{4}' ", ncc.TenNCC, ncc.Diachi, ncc.SDT,ncc.Email,ncc.MaNCC);
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Xóa nhà cung cấp
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool XoaNCC(string ma)
        {
            string sql = string.Format("Delete from NhaCC where MaNCC='" + ma + "'");
            thucthisql(sql);
            return true;
        }
    }
}

