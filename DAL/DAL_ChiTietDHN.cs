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
    public class DAL_ChiTietDHN:DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from ChiTietHDN";
            return connect.getData(sql);//chứa dữ liệu bảng ChiTietDHN
        }
       
        

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from ChiTietHDN where MaDHN='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        /// <summary>
        /// Thêm Chi tiết đơn hàng nhập
        /// </summary>
        /// <param name="ctdhn"></param>
        /// <returns></returns>
        public bool ThemCTDHN(ChiTietDHN ctdhn)
        {
            //xử lý ngày 
            //string date=string.Format("{0}/{1}/{2}", datetimePicker1.Now.Year,datetimePicker1.Now.Month,datetimePicker1.Now.Day);  

            string sql = string.Format("Insert into ChiTietHDN values('" + ctdhn.MaDHN + "',N'" + ctdhn.MaMH + "','" + ctdhn.SLNhap + "','" + ctdhn.GiaNhap + "', '"+ ctdhn.TongTien()+"')");
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Sửa chi tiết đơn hàng nhập
        /// </summary>
        /// <param name="ctdhn"></param>
        /// <returns></returns>
        public bool SuaCTDHN(ChiTietDHN ctdhn)
        {
            string sql = string.Format("Update ChiTietHDN set slnhap=N'{0}', Dongianhap='{1}' , TongTien='{2}' where MaDHN= '{3}' and MaMH='{4}'   ", ctdhn.SLNhap, ctdhn.GiaNhap,ctdhn.TongTien(), ctdhn.MaDHN, ctdhn.MaMH);
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Xóa chi tiết đơn hàng nhập
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        public bool XoaCTDHN(string madhn,string mamh)
        {
            string sql = string.Format("Delete from ChiTietHDN where MaDHN='" + madhn + "' and MaMH='"+ mamh +"'");
            thucthisql(sql);
            return true;
        }
        public float TongTien(string maDHN)
        {
            float tongTien = 0;
            try
            {
                ketnoi(); // Kiểm tra và mở kết nối nếu cần
                using (SqlCommand cmd = new SqlCommand("dbo.TongThanhToanHDN", con)) //using kết nối đến SQL
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maDHN", maDHN);

                    var result = cmd.ExecuteScalar();// thực thi truy vấn sql và trả về kết quả là tổng tiền
                    if (result != null)
                    {
                        tongTien = Convert.ToSingle(result);// chuyển đổi kiểu dữ liệu thành float 
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ghi log hoặc hiển thị thông báo lỗi)
                Console.WriteLine(ex.Message);
            }
            finally
            {
                dongketnoi(); // Đảm bảo ngắt kết nối sau khi sử dụng
            }
            return tongTien;
        }
    }
}
