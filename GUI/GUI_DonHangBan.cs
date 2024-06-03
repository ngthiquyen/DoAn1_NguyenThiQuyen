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
    public partial class GUI_DonHangBan : Form
    {
        public GUI_DonHangBan()
        {
            InitializeComponent();
        }
        BLL_DonHangBan busDonHangBan = new BLL_DonHangBan();
        DonHangBan dhb = new DonHangBan();
        BLL_NhanVien busNhanVien = new BLL_NhanVien();
        BLL_KhachHang busKhachHang=new BLL_KhachHang();
        NhanVien nv=new NhanVien();
        void loaddg()
        {
            dgdhb.DataSource = busDonHangBan.getData();
            dgdhb.Columns[0].HeaderText = "Mã đơn hàng bán";
            dgdhb.Columns[1].HeaderText = "Mã nhân viên";
            dgdhb.Columns[2].HeaderText = "Mã khách hàng";
            dgdhb.Columns[3].HeaderText = "Ngày bán";
            dgdhb.Columns[4].HeaderText = "Tổng thanh toán";
            
            cbtennv.DataSource = busNhanVien.getData();
            cbtennv.DisplayMember = "Hoten";
            cbtennv.ValueMember = "MaNV";

          
            cbtenkh.DataSource = busKhachHang.getData();
            cbtenkh.DisplayMember = "TenKH";
            cbtenkh.ValueMember = "MaKH";
        }
       
        private void GUI_DonHangBan_Load(object sender, EventArgs e)
        {
            loaddg();
            cbtennv.SelectedIndexChanged += cbtennv_SelectedIndexChanged;
        }

        private void dgdhb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                CapNhatTongTien();
                int i = e.RowIndex;
                txtmadhb.Text = dgdhb[0, i].Value.ToString();
                string maNV = dgdhb[1, i].Value.ToString();
                cbtennv.SelectedValue = maNV; // Đặt giá trị mã nhân viên cho ComboBox
                txtmanv.Text = maNV;
                string maKH = dgdhb[2, i].Value.ToString();
                cbtenkh.SelectedValue = maKH; // Đặt giá trị mã khách hàng cho ComboBox
                txtmakh.Text = maKH;
                dtngayban.Text = dgdhb[3, i].Value.ToString();
                txttongtt.Text = dgdhb[4, i].Value.ToString();
                txtmadhb.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            txttongtt.Text = "0";
            DateTime Ngayban = DateTime.Parse(dtngayban.Value.ToShortDateString());
            DonHangBan dhb = new DonHangBan(txtmadhb.Text, txtmanv.Text, txtmakh.Text, Ngayban,float.Parse(txttongtt.Text));
            if (txtmadhb.Text == "" || cbtennv.Text == "" || cbtenkh.Text == "" || dtngayban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (busDonHangBan.kiemtramatrung(txtmadhb.Text) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        busDonHangBan.ThemDHB(dhb);
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            DateTime Ngayban = DateTime.Parse(dtngayban.Value.ToShortDateString());
            DonHangBan dhb = new DonHangBan(txtmadhb.Text, txtmanv.Text, txtmakh.Text, Ngayban, float.Parse(txttongtt.Text));
            if (txtmadhb.Text == "" || txtmanv.Text == "" || cbtenkh.Text == "" || dtngayban.Text == "" ||cbtennv.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try  
                {
                    busDonHangBan.SuaDHB(dhb);
                    MessageBox.Show("Sửa thông tin đơn hàng bán thành công");
                    loaddg();
                }
                 catch(Exception ex)
                {
                    MessageBox.Show("Sửa không thành công! Lỗi: " +ex.Message);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try 
            {
                busDonHangBan.XoaDHB(txtmadhb.Text);
                MessageBox.Show("Xóa đơn hàng bán thành công");
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

        private void btnmoi_Click_1(object sender, EventArgs e)
        {
            CapNhatTongTien();
            txtmadhb.Text = "";
            cbtennv.Text = "";
            txtmanv.Text = "";
            cbtenkh.Text = "";
            dtngayban.Text = "";
            txttongtt.Text = "";
            txttimkiem.Text = "";           
            loaddg();
            txtmadhb.Enabled = true;
        }

        private void btntkdhn_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgdhb.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgdhb[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgdhb[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgdhb[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue3 = dgdhb[3, i].Value?.ToString().Trim().ToUpperInvariant();
                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue3) && cellValue3.Contains(searchText));


                if (!containsSearchText)
                {
                    dgdhb.Rows.RemoveAt(i);
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

        private void cbtenkh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbtenkh.SelectedItem != null)
            {
                string slectedMaKH=cbtenkh.SelectedValue.ToString();
                txtmakh.Text = slectedMaKH;
            }
        }
        private void CapNhatTongTien()
        {
            string maDHB = txtmadhb.Text;
            float tongTien = busDonHangBan.TongTien(maDHB);
            txttongtt.Text = tongTien.ToString();
        }
    }
}
