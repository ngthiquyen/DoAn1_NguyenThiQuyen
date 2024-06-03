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
    public class DAL_MatHang : DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from MatHang";
            return connect.getData(sql);//chứa dữ liệu bảng MatHang
        }
        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from MatHang  where MaMH='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        /// <summary>
        /// Thêm mặt hàng
        /// </summary>
        /// <param name="mh"></param>
        /// <returns></returns>
        public bool ThemMH(MatHang mh)
        {
            //xử lý ngày 
            //string date=string.Format("{0}/{1}/{2}", datetimePicker1.Now.Year,datetimePicker1.Now.Month,datetimePicker1.Now.Day);  
            string sql = string.Format("Insert into MatHang values('"+ mh.ma +"','"+ mh.MaLH + "',N'"+ mh.TenMH + "',N'"+ mh.DonVi + "','"+ mh.SoLuong + "',N'"+ mh.Mau + "','"+ mh.Gia + "',N'"+ mh.Mota + "',N'"+ mh.Size + "')");
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Sửa mặt hàng
        /// </summary>
        /// <param name="mh"></param>
        /// <returns></returns>
        public bool SuaMH(MatHang mh)
        {
            string sql = string.Format("Update MatHang set  MaLH= '"+ mh.MaLH + "', TenMH=N'"+ mh.TenMH + "', DonVi=N'"+ mh.DonVi + "', Soluong='"+ mh.SoLuong + "', Mau=N'" + mh.Mau + "' , Gia= '"+ mh.Gia + "', Mota=N'" + mh.Mota + "', Size='"+ mh.Size + "'  where MaMH= N'"+ mh.ma + "' " );
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Xóa mặt hàng
        /// </summary>
        /// <param name="mh"></param>
        /// <returns></returns>
        public bool XoaMH(string ma)
        {
            string sql = string.Format("Delete from MatHang where MaMH='"+ ma + "'" );
            thucthisql(sql);
            return true;
        }
        // phương thức tăng số lượng mặt hàng bằng truy vấn đề thủ tục tăng số lượng ở SQL
        public bool TangSoLuong(string ma, int soLuong)
        {
            try
            {               
                string strTang = "EXEC SoLuongTang @MaMH  = " + ma + ", @soLuong = " + soLuong + "";// câu lệnh thực thi thủ tục tăng                
                thucthisql(strTang);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return false;
        }
        // phương thức giảm số lượng mặt hàng bằng truy vấn đề thủ tục giảm số lượng ở SQL
        public bool GiamSoLuong(string ma, int soLuong)
        {
            try
            {              
                string strTang = "EXEC SoLuongGiam @MaMH  = " + ma + ", @soLuong = " + soLuong + "";// câu lệnh thực thi thủ tục giảm
                thucthisql(strTang);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
            return false;
        }
    }
}
