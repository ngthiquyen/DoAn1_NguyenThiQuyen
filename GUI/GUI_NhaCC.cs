using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class GUI_NhaCC : Form
    {
        public GUI_NhaCC()
        {
            InitializeComponent();
        }
        BLL_NhaCC busNhaCC = new BLL_NhaCC();
        NhaCC ncc = new NhaCC();
        void loaddg()
        {
            dgnhacc.DataSource = busNhaCC.getData();
            dgnhacc.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgnhacc.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgnhacc.Columns[2].HeaderText = "Địa chỉ";
            dgnhacc.Columns[3].HeaderText = "Số điện thoại";
            dgnhacc.Columns[4].HeaderText = "Email";
        }
        private void GUI_NhaCC_Load(object sender, EventArgs e)
        {
            loaddg();
        }

        private void dgnhacc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtmancc.Text = dgnhacc[0, i].Value.ToString();
            txttenncc.Text = dgnhacc[1, i].Value.ToString();
            txtdiachi.Text = dgnhacc[2, i].Value.ToString();
            txtsdt.Text = dgnhacc[3, i].Value.ToString();
            txtemail.Text = dgnhacc[4, i].Value.ToString();
            txtmancc.Enabled= false;
        }

        private void btnmoi_Click(object sender, EventArgs e)
        {           
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtmancc.Enabled = true;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string MaNCC = txtmancc.Text;
            //string TenNCC = txttenncc.Text;
            //string Diachi= txtdiachi.Text;
            //string Sdt= txtsdt.Text;
            //string Email= txtemail.Text;
            NhaCC ncc = new NhaCC(txtmancc.Text, txttenncc.Text,txtdiachi.Text, txtsdt.Text, txtemail.Text);
            if (txtmancc.Text == "" || txttenncc.Text == "" || txtdiachi.Text==""||txtsdt.Text==""||txtemail.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (busNhaCC.kiemtramatrung(MaNCC) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try 
                    {
                        busNhaCC.ThemNCC(ncc);
                        MessageBox.Show("Thêm mới thành công");
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
            string MaNCC = txtmancc.Text;
            string TenNCC = txttenncc.Text;
            string Diachi = txtdiachi.Text;
            string Sdt = txtsdt.Text;
            string Email = txtemail.Text;
            NhaCC ncc = new NhaCC(MaNCC, TenNCC, Diachi, Sdt, Email);
            if (txttenncc.Text == "" || txtdiachi.Text == "" || txtsdt.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                    try 
                    {
                        busNhaCC.SuaNCC(ncc);
                        MessageBox.Show("Sửa thông tin nhà cung cấp thành công");
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
            string MaNCC = txtmancc.Text;
            // Xóa
            try 
            {
                busNhaCC.XoaNCC(MaNCC);
                MessageBox.Show("Xóa nhà cung cấp thành công");
                loaddg(); // refresh datagridview

            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa không thành công! Lỗi: " +ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmoi_Click_1(object sender, EventArgs e)
        {
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdiachi.Text = "";
            txtsdt.Text = "";
            txtemail.Text = "";
            txtmancc.Enabled = true;
            txttimkiem.Text = "";
            loaddg();
        }

        private void btntkncc_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgnhacc.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgnhacc[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgnhacc[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgnhacc[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue3 = dgnhacc[3, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue4 = dgnhacc[4, i].Value?.ToString().Trim().ToUpperInvariant();
                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue3) && cellValue3.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue4) && cellValue4.Contains(searchText));
                                          

                if (!containsSearchText)
                {
                    dgnhacc.Rows.RemoveAt(i);
                }
            }
        }
    }
}
