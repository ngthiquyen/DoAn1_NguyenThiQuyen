using BLL;
using DTO;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_ThongKe : Form
    {
        public GUI_ThongKe()
        {
            InitializeComponent();
        }
        BLL_ThongKe busThongKe  = new BLL_ThongKe();
        //NhanVien nv = new NhanVien();
        //private void GUI_ThongKe_Load(object sender, EventArgs e)
        //{
        //    loaddgmax();
        //    loaddgmin();
        //}
        //void loaddgmax()
        //{           
        //        dgthongke.DataSource = busThongKe.getDatamax();
        //        dgthongke.Columns[0].HeaderText = "Mã nhân viên";
        //        dgthongke.Columns[1].HeaderText = "Tên nhân viên";
        //        dgthongke.Columns[2].HeaderText = "Lương";          
        //}
        //void loaddgmin()
        //{
        //    dgnvmin.DataSource = busThongKe.getDatamin();
        //    dgnvmin.Columns[0].HeaderText = "Mã nhân viên";
        //    dgnvmin.Columns[1].HeaderText = "Tên nhân viên";
        //    dgnvmin.Columns[2].HeaderText = "Lương";
        //}

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cbtieuchi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //// Lấy giá trị đã chọn từ ComboBox
            //string selectedOption = cbtieuchi.SelectedItem.ToString();
            //DateTime fromDate = FromDate.Value; // Lấy giá trị ngày bắt đầu muốn thống kê
            //DateTime toDate = ToDate.Value; // Lấy ra ngày kết thúc thống kê

            //// lựa chọn trong ComboBox
            //switch (selectedOption)
            //{
            //    case "Mặt hàng bán chạy nhất":
            //        {
            //            DataTable dt = busThongKe.HangBanChay(fromDate, toDate); // Truyền ngày tháng năm vào phương thức HangBanChay
            //            dgthongke.DataSource = dt;
            //            break;
            //        }
            //    case "Số lượng hàng tồn kho":
            //        {
            //            DataTable dr = busThongKe.HangTonKho(fromDate, toDate); // Truyền ngày tháng năm vào phương thức HangTonKho
            //            dgthongke.DataSource = dr;
            //            break;
            //        }
            //    default:
            //        break;}
            

        }

        private void btthongke_Click(object sender, EventArgs e)
        {
            DateTime fromDate = FromDate.Value; // Lấy giá trị ngày bắt đầu muốn thống kê
            DateTime toDate = ToDate.Value; // Lấy ra ngày kết thúc thống kê
            string selectedOption = cbtieuchi.SelectedItem.ToString(); // Lấy giá trị đã chọn từ ComboBox

            switch (selectedOption)
            {
                case "Mặt hàng bán chạy nhất":
                    {
                        DataTable dt = busThongKe.HangBanChay(fromDate, toDate); // Truyền ngày tháng năm vào phương thức HangBanChay
                        dgthongke.DataSource = dt;
                        dgthongke.Columns[0].HeaderText = "Mã mặt hàng";
                        dgthongke.Columns[1].HeaderText = "Tên mặt hàng";
                        dgthongke.Columns[2].HeaderText = "Số lượng bán";
                        break;
                    }
                case "Số lượng hàng tồn kho":
                    {
                        DataTable dr = busThongKe.HangTonKho(fromDate, toDate); // Truyền ngày tháng năm vào phương thức HangTonKho
                        dgthongke.DataSource = dr;
                        dgthongke.Columns[0].HeaderText = "Mã mặt hàng";
                        dgthongke.Columns[1].HeaderText = "Tên mặt hàng";
                        dgthongke.Columns[2].HeaderText = "Số lượng tồn kho";
                        break;
                    }
                default:
                    MessageBox.Show("Vui lòng chọn tiêu chí hợp lệ");
                    break;
            }
        }
    }    
}
