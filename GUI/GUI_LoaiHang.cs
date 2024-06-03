using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_LoaiHang : Form
    {
        public GUI_LoaiHang()
        {
            InitializeComponent();
        }
        BLL_LoaiHang busLH = new BLL_LoaiHang();
        LoaiHang lh = new LoaiHang();
        void loaddg()
        {
            dgloaihang.DataSource = busLH.getData();
            dgloaihang.Columns[0].HeaderText = "Mã loại hàng";
            dgloaihang.Columns[1].HeaderText = "Tên loại hàng";
            //cbtklh.Enabled = false;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            string ma= txtmalh.Text;
            string TenLH = txttenlh.Text;
            LoaiHang lh = new LoaiHang(ma, TenLH);
            if (txtmalh.Text == "" || txttenlh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                if (busLH.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Mã đã tồn tại, vui lòng nhập lại mã!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try 
                    {
                        busLH.ThemLH(lh);
                        MessageBox.Show("Thêm mới thành công");
                        loaddg();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm mới không thành công! Lỗi: " + ex.Message);
                    }
                }
            }
        }


        private void GUI_LoaiHang_Load(object sender, EventArgs e)
        {
            loaddg();
        }

        private void dgloaihang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtmalh.Text = dgloaihang[0, i].Value.ToString();
                txttenlh.Text = dgloaihang[1, i].Value.ToString();
                txtmalh.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi:" + ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmoi_Click(object sender, EventArgs e)
        {
            txtmalh.Enabled=true;
            txtmalh.Text = "";
            txttenlh.Text = "";
            txttimkiem.Text = "";
            loaddg();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma =txtmalh.Text;
            string TenLH = txttenlh.Text;
            LoaiHang lh = new LoaiHang(ma, TenLH);
            if (txttenlh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin ");
            }
            else
            {
                try 
                {
                    busLH.SuaLH(lh);
                    MessageBox.Show("Sửa thông tin loại hàng thành công");
                    loaddg();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa không thành công! Lỗi: " +ex.Message);
                }
            }           
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string ma = txtmalh.Text;
            // Xóa
            try 
                {
                busLH.XoaLH(ma);
                    MessageBox.Show("Xóa loại hàng thành công");
                    loaddg(); // refresh datagridview

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xóa không thành công! Lỗi: " +ex.Message);
                }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgloaihang.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue1 = dgloaihang[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgloaihang[1, i].Value?.ToString().Trim().ToUpperInvariant();
                

                bool containsSearchText = (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText));
                

                if (!containsSearchText)
                {
                    dgloaihang.Rows.RemoveAt(i);
                }
            }

        }

        private void btntimkiem_TextChanged(object sender, EventArgs e)
        {
            GUI_LoaiHang_Load(sender, e);
           btntimkiem_Click(sender, e);
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
