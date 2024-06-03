using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_KhachHang : Form
    {
        public GUI_KhachHang()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnmoi_Click(object sender, EventArgs e)
        {
            txtmakh.Enabled = true;
            txtmakh.Text = "";
            txttenkh.Text = "";
            txtdiachikh.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            dtngaysinh.Text = "";
            cbgtinh.Text = "";
            txttimkiem.Text = "";
            loaddg();

        }
        BLL_KhachHang busKhachHang = new BLL_KhachHang();
        KhachHang kh = new KhachHang();
        void loaddg()
        {
            dgkhachhang.DataSource = busKhachHang.getData();
            dgkhachhang.Columns[0].HeaderText = "Mã khách hàng";
            dgkhachhang.Columns[1].HeaderText = "Tên khách hàng";
            dgkhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgkhachhang.Columns[3].HeaderText = "Email";
            dgkhachhang.Columns[4].HeaderText = "Số điện thoại";
            dgkhachhang.Columns[5].HeaderText = "Giơi tính";
            dgkhachhang.Columns[6].HeaderText = "Ngày sinh";

        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            DateTime Ngaysinh = DateTime.Parse(dtngaysinh.Value.ToShortDateString());

            //DateTime Ngaysinh = dtngaysinh.Value;
            //string Ngaysinh = dt.ToString("yyyy-MM-dd");
            KhachHang kh = new KhachHang(txtmakh.Text, txttenkh.Text, txtdiachikh.Text, txtemail.Text, txtsdt.Text, cbgtinh.Text, Ngaysinh);
            if (txtmakh.Text == "" || txttenkh.Text == "" || txtdiachikh.Text == "" || txtsdt.Text == "" || txtemail.Text == "" || cbgtinh.Text == "" || dtngaysinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (busKhachHang.kiemtramatrung(txtmakh.Text) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try 
                    {
                        busKhachHang.ThemKH(kh);
                        MessageBox.Show("Thêm mới thành công");
                        loaddg();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công! Lỗi: " + ex.Message);
                    }
                }
            }
        }

        private void GUI_KhachHang_Load(object sender, EventArgs e)
        {
            loaddg();
        }

        private void dgkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmakh.Text = dgkhachhang[0, i].Value.ToString();
            txttenkh.Text = dgkhachhang[1, i].Value.ToString();
            txtdiachikh.Text = dgkhachhang[2, i].Value.ToString();
            txtemail.Text = dgkhachhang[3, i].Value.ToString();
            txtsdt.Text = dgkhachhang[4, i].Value.ToString();
            cbgtinh.Text = dgkhachhang[5, i].Value.ToString();
            dtngaysinh.Text = dgkhachhang[6, i].Value.ToString();
            
            txtmakh.Enabled = false;
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DateTime Ngaysinh = DateTime.Parse(dtngaysinh.Value.ToShortDateString());
            //string Ngaysinh = dt.ToString("yyyy-MM-dd");
            KhachHang kh = new KhachHang(txtmakh.Text, txttenkh.Text, txtdiachikh.Text, txtemail.Text, txtsdt.Text, cbgtinh.Text, Ngaysinh);
            if (txttenkh.Text == "" || txtdiachikh.Text == "" || txtsdt.Text == "" || txtemail.Text == "" || cbgtinh.Text == "" || dtngaysinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try 
                {
                    busKhachHang.SuaKH(kh);
                    MessageBox.Show("Sửa thông tin khách hàng thành công");
                    loaddg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công! Lỗi: " + ex.Message);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaKH = txtmakh.Text;
            // Xóa
            try 
            {
                busKhachHang.XoaKH(MaKH);
                MessageBox.Show("Xóa nhà khách hàng thành công");
                loaddg(); // refresh datagridview

            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa không thành công ! Lỗi: " + ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgkhachhang.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgkhachhang[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgkhachhang[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgkhachhang[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue3 = dgkhachhang[3, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue4 = dgkhachhang[4, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue5 = dgkhachhang[5, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue6 = dgkhachhang[6, i].Value?.ToString().Trim().ToUpperInvariant();
                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue3) && cellValue3.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue4) && cellValue4.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue5) && cellValue5.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue6) && cellValue6.Contains(searchText));


                if (!containsSearchText)
                {
                    dgkhachhang.Rows.RemoveAt(i);
                }
            }
        }
    }
}
