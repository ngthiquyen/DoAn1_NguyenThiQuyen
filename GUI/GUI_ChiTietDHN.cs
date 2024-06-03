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
    public partial class GUI_ChiTietDHN : Form
    {
        public GUI_ChiTietDHN()
        {
            InitializeComponent();
        }
        BLL_DonHangNhap busDonHangNhap = new BLL_DonHangNhap();
        BLL_ChiTietDHN busChiTietDHN = new BLL_ChiTietDHN();
        BLL_MatHang busMatHang = new BLL_MatHang();
        ChiTietDHN ctdhn = new ChiTietDHN();
        void loaddg()
        {
            dgctdhn.DataSource = busChiTietDHN.getData();
            dgctdhn.Columns[0].HeaderText = "Mã đơn hàng nhập";
            dgctdhn.Columns[1].HeaderText = "Mã mặt hàng";
            dgctdhn.Columns[2].HeaderText = "Số lượng";
            dgctdhn.Columns[3].HeaderText = "Giá nhập";
            dgctdhn.Columns[4].HeaderText = "Thành tiền:";
            cbtenmh.DataSource = busMatHang.getData();
            cbtenmh.DisplayMember = "TenMH";
            cbtenmh.ValueMember = "MaMH";
            cbmadhn.DataSource = busDonHangNhap.getData();
            cbmadhn.DisplayMember = "MaDHN";
            //cbmadhn.ValueMember = "MaDHN";
            
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            ChiTietDHN ctdhn = new ChiTietDHN(cbmadhn.Text, txtmamh.Text, int.Parse(txtslnhap.Text), float.Parse(txtgianhap.Text));
            if (cbmadhn.Text == "" || txtmamh.Text == "" || txtslnhap.Text == "" || txtgianhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
               
                    try 
                    {                    
                        busMatHang.TangSoLuong(txtmamh.Text, int.Parse(txtslnhap.Text));
                        busChiTietDHN.ThemCTDHN(ctdhn);
                        MessageBox.Show("Thêm mới thành công");
                        loaddg();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công! Lỗi: " +ex.Message );
                    }
                
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ChiTietDHN ctdhn = new ChiTietDHN(cbmadhn.Text, txtmamh.Text, int.Parse(txtslnhap.Text), float.Parse(txtgianhap.Text));
            if (cbmadhn.Text == "" || txtmamh.Text == "" || txtslnhap.Text == "" || txtgianhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try 
                {
                    busChiTietDHN.SuaCTDHN(ctdhn);
                    MessageBox.Show("Sửa thông tin  chi tiết đơn hàng nhập thành công");
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
            try  
            {
                busMatHang.GiamSoLuong(txtmamh.Text, int.Parse(txtslnhap.Text));
                busChiTietDHN.XoaCTDHN(cbmadhn.Text,txtmamh.Text);
                MessageBox.Show("Xóa chi tiết đơn hàng nhập thành công");
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

        private void dgctdhn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                cbmadhn.Text = dgctdhn[0, i].Value.ToString();
                string maMH = dgctdhn[1, i].Value.ToString();
                cbtenmh.SelectedValue = maMH;
                txtmamh.Text = maMH;
                txtslnhap.Text = dgctdhn[2, i].Value.ToString();
                txtgianhap.Text = dgctdhn[3, i].Value.ToString();
                txttongtien.Text = dgctdhn[4, i].Value.ToString();
                cbmadhn.Enabled = false;
                cbtenmh.Enabled = false;
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void GUI_ChiTietDHN_Load(object sender, EventArgs e)
        {
            loaddg();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnmoi_Click_1(object sender, EventArgs e)
        {
            cbmadhn.Text = "";
            cbtenmh.Text = "";
            txtmamh.Text = "";
            txtslnhap.Text = "";
            txtgianhap.Text = "";
            cbmadhn.Enabled = true;
            cbtenmh.Enabled = true;
            txttimkiem.Text = "";
            loaddg();
        }

        private void btntkdhn_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgctdhn.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgctdhn[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgctdhn[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgctdhn[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue3 = dgctdhn[3, i].Value?.ToString().Trim().ToUpperInvariant();
                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue3) && cellValue3.Contains(searchText));


                if (!containsSearchText)
                {
                    dgctdhn.Rows.RemoveAt(i);
                }
            }
        }

     
        private void cbtenmh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtenmh.SelectedItem != null)
            {
                string selectedMaNCC = cbtenmh.SelectedValue.ToString();
                txtmamh.Text = selectedMaNCC;

            }
        }
    }
}
