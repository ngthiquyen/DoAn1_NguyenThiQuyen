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
    public partial class GUI_DonHangNhap : Form
    {
        public GUI_DonHangNhap()
        {
            InitializeComponent();
        }
        BLL_DonHangNhap busDonHangNhap = new BLL_DonHangNhap();
        DonHangNhap dhn = new DonHangNhap();
        BLL_NhanVien busNhanVien = new BLL_NhanVien();
        BLL_NhaCC busNhaCC= new BLL_NhaCC();
        void loaddg()
        {
            dgdhn.DataSource = busDonHangNhap.getData();
            dgdhn.Columns[0].HeaderText = "Mã đơn hàng nhập";
            dgdhn.Columns[1].HeaderText = "Mã nhân viên";
            dgdhn.Columns[2].HeaderText = "Mã nhà cung cấp";
            dgdhn.Columns[3].HeaderText = "Ngày nhập";
            dgdhn.Columns[4].HeaderText = "Tổng thanh toán";
            cbtennv.DataSource = busNhanVien.getData();
            cbtennv.DisplayMember = "Hoten";
            cbtennv.ValueMember = "MaNV";
            cbtenncc.DataSource= busNhaCC.getData();
            cbtenncc.DisplayMember = "TenNCC";
            cbtenncc.ValueMember = "MaNCC";
        }

        private void GUI_DonHangNhap_Load(object sender, EventArgs e)
        {
            loaddg();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            DateTime Ngaynhap = DateTime.Parse(dtngaynhap.Value.ToShortDateString());
            DonHangNhap dhn = new DonHangNhap(txtmadhn.Text, txtmanv.Text, txtmancc.Text, Ngaynhap,float.Parse(txttongtt.Text) );
            if (txtmadhn.Text == "" || txtmanv.Text == "" || txtmancc.Text == "" || dtngaynhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else            
                {
                try  
                {                    
                    busDonHangNhap.SuaDHN(dhn);
                    MessageBox.Show("Sửa thông tin đơn hàng nhập thành công");
                    loaddg();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sửa không thành công! Lỗi: " + ex.Message);
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txttongtt.Text = "0";
            DateTime Ngaynhap = DateTime.Parse(dtngaynhap.Value.ToShortDateString());
            DonHangNhap dhn = new DonHangNhap(txtmadhn.Text, txtmanv.Text, txtmancc.Text, Ngaynhap, float.Parse(txttongtt.Text));
            if (txtmadhn.Text == "" || txtmanv.Text == "" || txtmancc.Text == "" || dtngaynhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (busDonHangNhap.kiemtramatrung(txtmadhn.Text) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try 
                    {                        
                        busDonHangNhap.ThemDHN(dhn);
                        MessageBox.Show("Thêm mới thành công");
                        loaddg();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công! Lỗi: " +ex.Message);
                    }
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                busDonHangNhap.XoaDHN(txtmadhn.Text);
                MessageBox.Show("Xóa đơn hàng nhập thành công");
                loaddg(); // refresh datagridview

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa không thành công ! Lỗi: " + ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgdhn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CapNhatTongTien();
            int i = e.RowIndex;
            txtmadhn.Text = dgdhn[0, i].Value.ToString();

            string maNV = dgdhn[1, i].Value.ToString();
            cbtennv.SelectedValue = maNV; // Đặt giá trị mã nhân viên cho ComboBox
            txtmanv.Text = maNV;
            
            string maNCC = dgdhn[2, i].Value.ToString();
            cbtenncc.SelectedValue = maNCC;//đặt giá trị mã nhà cung cấp cho combobox
            txtmancc.Text = maNCC;

            dtngaynhap.Text = dgdhn[3, i].Value.ToString();
            txttongtt.Text= dgdhn[4, i].Value.ToString();
            txtmadhn.Enabled = false;
            
        }

        private void btnmoi_Click_1(object sender, EventArgs e)
        {
            txtmadhn.Enabled = true;
            cbtennv.Text = "";
            cbtenncc.Text = "";
            txtmadhn.Text = "";
            txtmanv.Text = "";
            txtmancc.Text = "";
            dtngaynhap.Text = "";
            txttongtt.Text = "";
            txttimkiem.Text = "";
            CapNhatTongTien();
            loaddg();
        }

        private void btntkdhn_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgdhn.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgdhn[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgdhn[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgdhn[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue3 = dgdhn[3, i].Value?.ToString().Trim().ToUpperInvariant();
                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue3) && cellValue3.Contains(searchText));


                if (!containsSearchText)
                {
                    dgdhn.Rows.RemoveAt(i);
                }
            }
        }

        private void cbtennv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtennv.SelectedItem != null)
            {
                string selectedMaNV = cbtennv.SelectedValue.ToString();
                txtmanv.Text = selectedMaNV;

            }
        }

        private void cbtenncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtenncc.SelectedItem != null)
            {
                string selectedMaNCC = cbtenncc.SelectedValue.ToString();
                txtmancc.Text = selectedMaNCC;

            }
        }
        private void CapNhatTongTien()
        {
            string maDHN = txtmadhn.Text;
            float tongTien = busDonHangNhap.TongTien(maDHN);
            txttongtt.Text = tongTien.ToString();
        }
    }
}
