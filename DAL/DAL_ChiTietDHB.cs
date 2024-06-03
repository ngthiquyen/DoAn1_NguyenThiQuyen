using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ChiTietDHB:DBConnect
    {
        //chứa mọi xử lý liên quan đến CSDL
        //xử lý lấy dữ liệu để đưa ra dgv
        //khởi tạo đối tượng thuộc lớp DBConnect
        DBConnect connect = new DBConnect();
        public DataTable getData()
        {
            string sql = "Select * from ChiTietDHB";
            return connect.getData(sql);//chứa dữ liệu bảng ChiTietDHB
        }

        public int kiemtramatrung(string ma)
        {
            string sql = "Select count(*) from ChiTietDHB where MaDHB='" + ma.Trim() + "'";
            return connect.kiemtramatrung(ma, sql);
        }
        /// <summary>
        /// Thêm Chi tiết đơn hàng bán
        /// </summary>
        /// <param name="ctdhb"></param>
        /// <returns></returns>
        public bool ThemCTDHB(ChiTietDHB ctdhb)
        {
            //xử lý ngày 
            //string date=string.Format("{0}/{1}/{2}", datetimePicker1.Now.Year,datetimePicker1.Now.Month,datetimePicker1.Now.Day);  

            string sql = string.Format("Insert into ChiTietDHB values('" + ctdhb.MaDHB + "',N'" + ctdhb.MaMH + "','" + ctdhb.SLBan + "','" + ctdhb.GiaBan + "','"+ctdhb.TongTien()+"')");
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Sửa chi tiết đơn hàng bán
        /// </summary>
        /// <param name="ctdhn"></param>
        /// <returns></returns>
        public bool SuaCTDHB(ChiTietDHB ctdhb)
        {
            string sql = string.Format("Update ChiTietDHB set  slban=N'{0}', Dongiaban='{1}', Tongtien='{2}' where MaDHB= '{3}' and MaMH=N'{4}' ", ctdhb.SLBan, ctdhb.GiaBan, ctdhb.TongTien(),ctdhb.MaDHB, ctdhb.MaMH);
            thucthisql(sql);
            return true;
        }
        /// <summary>
        /// Xóa chi tiết đơn hàng bán
        /// </summary>
        /// <param name="">ctdhb</param>
        /// <returns></returns>
        public bool XoaCTDHB(string madhb,string mamh)
        {
            string sql = string.Format("Delete from ChiTietDHB where MaDHB='" + madhb + "' and MaMH='"+ mamh +"'");
            thucthisql(sql);
            return true;
        }
        public float TongTien(string maDHB)
        {
            float tongTien = 0;
            try
            {
                ketnoi(); // Kiểm tra và mở kết nối nếu cần
                using (SqlCommand cmd = new SqlCommand("dbo.TongThanhToanHDB", con)) //using kết nối đến SQL
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maDHB", maDHB);

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
