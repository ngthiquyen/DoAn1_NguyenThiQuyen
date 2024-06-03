using BLL;
using DTO;
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
    public partial class GUI_NhanVien : Form
    {
        public GUI_NhanVien()
        {
            InitializeComponent();
        }
        BLL_NhanVien busNhanVien = new BLL_NhanVien();
        NhanVien nv = new NhanVien();
        void loaddg()
        {
            dgnhanvien.DataSource = busNhanVien.getData();
            dgnhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgnhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgnhanvien.Columns[2].HeaderText = "Giơi tính";
            dgnhanvien.Columns[3].HeaderText = "Ngày sinh";
            dgnhanvien.Columns[4].HeaderText = "Địa chỉ";
            dgnhanvien.Columns[5].HeaderText = "Email";
            dgnhanvien.Columns[6].HeaderText = "Số điện thoại";
            dgnhanvien.Columns[7].HeaderText = "Lương";


        }
        private void GUI_NhanVien_Load(object sender, EventArgs e)
        {
            loaddg();
        }

        private void dgnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmanv.Text = dgnhanvien[0, i].Value.ToString();
            txttennv.Text = dgnhanvien[1, i].Value.ToString();
            cbgtinh.Text = dgnhanvien[2, i].Value.ToString();
            dtngaysinh.Text = dgnhanvien[3, i].Value.ToString();
            txtdiachi.Text = dgnhanvien[4, i].Value.ToString();
            txtemail.Text = dgnhanvien[5, i].Value.ToString();
            txtsdt.Text = dgnhanvien[6, i].Value.ToString();
            txtluong.Text = dgnhanvien[7, i].Value.ToString();

            txtmanv.Enabled = false;
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmoi_Click(object sender, EventArgs e)
        {
            txtmanv.Text = "";
            txttennv.Text = "";
            cbgtinh.Text = "";
            dtngaysinh.Text = "";
            txtdiachi.Text = "";
            txtemail.Text = "";
            txtsdt.Text = "";
            txtluong.Text = "";
            txtmanv.Enabled = true;
            txttimkiem.Text = "";
            loaddg();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            DateTime Ngaysinh = DateTime.Parse(dtngaysinh.Value.ToShortDateString());
            float luong = float.Parse(txtluong.Text.ToString());
            NhanVien nv = new NhanVien(txtmanv.Text, txttennv.Text, cbgtinh.Text, Ngaysinh, txtdiachi.Text, txtemail.Text, txtsdt.Text, luong);
            if (txtmanv.Text == "" || txttennv.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" || txtemail.Text == "" || cbgtinh.Text == "" || dtngaysinh.Text == "" || txtluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (busNhanVien.kiemtramatrung(txtmanv.Text) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try 
                    {
                        busNhanVien.ThemNV(nv);
                        MessageBox.Show("Thêm mới nhân viên thành công");
                        loaddg();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công! Lỗi: " +ex.Message);
                    }
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DateTime Ngaysinh = DateTime.Parse(dtngaysinh.Value.ToShortDateString());
            float luong = float.Parse(txtluong.Text.ToString());
            NhanVien nv = new NhanVien(txtmanv.Text, txttennv.Text, cbgtinh.Text, Ngaysinh, txtdiachi.Text, txtemail.Text, txtsdt.Text, luong);
            if (txttennv.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" || txtemail.Text == "" || cbgtinh.Text == "" || dtngaysinh.Text == "" || txtluong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try
                {
                    busNhanVien.SuaNV(nv);
                    MessageBox.Show("Sửa thông tin nhân viên thành công");
                    loaddg();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sửa không thành công! Lỗi: " + ex.Message);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string MaNV = txtmanv.Text;
            // Xóa
            try
            {
                busNhanVien.XoaNV(MaNV);
                MessageBox.Show("Xóa nhà nhân viên thành công");
                loaddg(); // refresh datagridview

            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa không thành công ! Lỗi: " +ex.Message);
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgnhanvien.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgnhanvien[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgnhanvien[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgnhanvien[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue3 = dgnhanvien[3, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue4 = dgnhanvien[4, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue5 = dgnhanvien[5, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue6 = dgnhanvien[6, i].Value?.ToString().Trim().ToUpperInvariant();
                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue3) && cellValue3.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue4) && cellValue4.Contains(searchText))||
                                          (!string.IsNullOrEmpty(cellValue5) && cellValue5.Contains(searchText))||
                                          (!string.IsNullOrEmpty(cellValue6) && cellValue6.Contains(searchText));


                if (!containsSearchText)
                {
                    dgnhanvien.Rows.RemoveAt(i);
                }
            }
        }
    }
}
