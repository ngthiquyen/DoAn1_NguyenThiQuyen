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
    public partial class GUI_ChiTietDHB : Form
    {
        public GUI_ChiTietDHB()
        {
            InitializeComponent();
        }
        BLL_DonHangBan busDonHangBan = new BLL_DonHangBan();
        BLL_ChiTietDHB busChiTietDHB = new BLL_ChiTietDHB();
        BLL_MatHang busMatHang=new BLL_MatHang();
        ChiTietDHB ctdhb = new ChiTietDHB();
        ChiTietDHN ctdhn = new ChiTietDHN();
        void loaddg()
        {
            dgctdhb.DataSource = busChiTietDHB.getData();
            dgctdhb.Columns[0].HeaderText = "Mã đơn hàng bán";
            dgctdhb.Columns[1].HeaderText = "Mã mặt hàng";
            dgctdhb.Columns[2].HeaderText = "Số lượng";
            dgctdhb.Columns[3].HeaderText = "Giá bán";
            dgctdhb.Columns[4].HeaderText = " Tổng tiền";
            cbtenmh.DataSource = busMatHang.getData();
            cbtenmh.DisplayMember = "TenMH";
            cbtenmh.ValueMember = "MaMH";
            cbmadhb.DataSource = busDonHangBan.getData();
            cbmadhb.DisplayMember = "MaDHB";
            cbmadhb.ValueMember = "MaDHB";
            
        }

        private void GUI_ChiTietDHB_Load(object sender, EventArgs e)
        {
            loaddg();
        }

        private void dgctdhb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            cbmadhb.Text = dgctdhb[0, i].Value.ToString();            
            string maMH = dgctdhb[1, i].Value.ToString();
            cbtenmh.SelectedValue = maMH;
            txtmamh.Text = maMH;
            txtslban.Text = dgctdhb[2, i].Value.ToString();
            txtgiaban.Text = dgctdhb[3, i].Value.ToString();
            txttongtien.Text= dgctdhb[4, i].Value.ToString();
            cbmadhb.Enabled = false;
            cbtenmh.Enabled = false;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ChiTietDHB ctdhb = new ChiTietDHB(cbmadhb.Text, txtmamh.Text, int.Parse(txtslban.Text), float.Parse(txtgiaban.Text));
            if (cbmadhb.Text == "" || txtmamh.Text == "" || txtslban.Text == "" || txtgiaban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            
                    try
                    {
                    busMatHang.TangSoLuong(txtmamh.Text, int.Parse(txtslban.Text));
                    busChiTietDHB.ThemCTDHB(ctdhb);
                        MessageBox.Show("Thêm mới thành công");
                        loaddg();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công! Lỗi: " + ex.Message);
                    }
              
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            ChiTietDHB ctdhb = new ChiTietDHB(cbmadhb.Text, txtmamh.Text, int.Parse(txtslban.Text), float.Parse(txtgiaban.Text));
            if (cbmadhb.Text == "" || txtmamh.Text == "" || txtslban.Text == "" || txtgiaban.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                try 
                {
                    busChiTietDHB.SuaCTDHB(ctdhb);
                    MessageBox.Show("Sửa thông tin  chi tiết đơn hàng bán thành công");
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
                busMatHang.GiamSoLuong(txtmamh.Text, int.Parse(txtslban.Text));
                busChiTietDHB.XoaCTDHB(cbmadhb.Text,txtmamh.Text);
                MessageBox.Show("Xóa chi tiết đơn hàng bán thành công");
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

        private void btnmoi_Click_1(object sender, EventArgs e)
        {
            cbmadhb.Text = "";
            cbtenmh.Text = "";
            txtslban.Text = "";
            txtgiaban.Text = "";
            cbmadhb.Enabled = true;
            cbtenmh.Enabled = true;
            txttimkiem.Text = "";
            loaddg();

        }

        private void btntkdhn_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgctdhb.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgctdhb[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgctdhb[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgctdhb[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue3 = dgctdhb[3, i].Value?.ToString().Trim().ToUpperInvariant();
                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue3) && cellValue3.Contains(searchText));


                if (!containsSearchText)
                {
                    dgctdhb.Rows.RemoveAt(i);
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
