using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_MatHang : Form
    {
        public GUI_MatHang()
        {
            InitializeComponent();
            
        }
        
        BLL_LoaiHang busLH=new BLL_LoaiHang();
        BLL_MatHang busMH = new BLL_MatHang();
        //MatHang mh = new MatHang();
        private void btnthem_Click(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string ma=txtmamh.Text;
            string MaLH=txtmalh.Text;
            string TenMH=txttensp.Text;
            string DonVi = txtdonvi.Text;
            int SoLuong = int.Parse(txtsoluong.Text);
            float Gia=float.Parse(txtgiahang.Text);
            string Mau = cbmau.Text;
            string Mota=txtmota.Text;
            string Size=txtsize.Text;
            MatHang mh = new MatHang(ma, MaLH, TenMH, DonVi, SoLuong, Mau, Gia,  Mota, Size );
            if (txtmamh.Text == "" || cbtenlh.Text == "" || txttensp.Text == "" || txtdonvi.Text == "" || txtsoluong.Text == "" || cbmau.Text == "" ||  txtgiahang.Text == "" || txtmota.Text == "" || txtsize.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống!");
            }
            else
            {
                if (busMH.kiemtramatrung(ma) == 1)
                {
                    MessageBox.Show("Trùng mã! Vui lòng nhập mã khác");
                }
                else
                {
                    try 
                    {
                        busMH.ThemMH(mh);
                        MessageBox.Show("Thêm mới mặt hàng  thành công ");
                        loaddg();
                    }
                     catch(Exception ex)
                    {
                        MessageBox.Show("Thêm mới mặt hàng không thành công! Lỗi: " +ex.Message);
                    }
                }
            }

        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            loaddg();
        }

        private void dgMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                txtmamh.Text = dgMatHang[0, i].Value.ToString();
                string maLH = dgMatHang[1, i].Value.ToString();
                cbtenlh.SelectedValue = maLH; // Đặt giá trị mã loại hàng cho ComboBox
                txtmalh.Text = maLH;               
                txttensp.Text = dgMatHang[2, i].Value.ToString();
                txtdonvi.Text = dgMatHang[3, i].Value.ToString();
                txtsoluong.Text = dgMatHang[4, i].Value.ToString();
                cbmau.Text = dgMatHang[5, i].Value.ToString();
                txtgiahang.Text = dgMatHang[6, i].Value.ToString();
                txtmota.Text = dgMatHang[7, i].Value.ToString();
                txtsize.Text = dgMatHang[8, i].Value.ToString();
                txtmamh.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnmoi_Click(object sender, EventArgs e)
        {
            txtmamh.Enabled = true;
            txtmamh.Text = "";
            cbtenlh.Text = "";
            txttensp.Text = "";
            txtdonvi.Text = "";
            txtsoluong.Text = "";
            cbmau.Text = "";
            txtgiahang.Text = "";
            txtmota.Text = "";
            txtsize.Text = "";
            txttimkiem.Text = "";
            loaddg();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string ma = txtmamh.Text;
            string MaLH = txtmalh.Text;
            string TenMH = txttensp.Text;
            string DonVi = txtdonvi.Text;
            int SoLuong = int.Parse(txtsoluong.Text);
            float Gia = float.Parse(txtgiahang.Text);
            string Mau = cbmau.Text;
            string Mota = txtmota.Text;
            string Size = txtsize.Text;
            MatHang mh = new MatHang(ma, MaLH, TenMH, DonVi, SoLuong, Mau, Gia, Mota, Size);
            if (cbtenlh.Text == "" || txttensp.Text == "" || txtdonvi.Text == "" || txtsoluong.Text == "" || cbmau.Text == "" || txtgiahang.Text == "" || txtmota.Text == "" || txtsize.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống!");
            }
            else
            {
                try
                {
                    busMH.SuaMH(mh);
                    MessageBox.Show("Sửa thông tin mặt hàng thành công");
                    loaddg();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Sửa thông tin không thành công! Lỗi: " +ex.Message );
                }
            }
        }   
            
        private void btnxoa_Click(object sender, EventArgs e)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string ma = txtmamh.Text;
            try 
            {
                busMH.XoaMH(ma);
                MessageBox.Show("Xóa mặt hàng thành công ");
                loaddg();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Xóa không thành công! Lỗi: " + ex.Message);
            }
        }
        void loaddg()
        {    
            cbtenlh.DataSource = busLH.getData();
            cbtenlh.DisplayMember = "TenLH";
            cbtenlh.ValueMember = "MaLH";
            dgMatHang.DataSource = busMH.getData();
            dgMatHang.Columns[0].HeaderText = "Mã mặt hàng";
            dgMatHang.Columns[1].HeaderText = "Mã loại hàng";
            dgMatHang.Columns[2].HeaderText = "Tên mặt hàng";
            dgMatHang.Columns[3].HeaderText = "Đơn vị";
            dgMatHang.Columns[4].HeaderText = "Số lượng";
            dgMatHang.Columns[5].HeaderText = "Màu";
            dgMatHang.Columns[6].HeaderText = "Giá ";
            dgMatHang.Columns[7].HeaderText = "Mô tả ";
            dgMatHang.Columns[8].HeaderText = "Size";


        }

        
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string searchText = txttimkiem.Text.Trim().ToUpperInvariant();

            for (int i = dgMatHang.Rows.Count - 2; i >= 0; i--)
            {
                string cellValue0 = dgMatHang[0, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue1 = dgMatHang[1, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue2 = dgMatHang[2, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue3 = dgMatHang[3, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue5 = dgMatHang[5, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue7 = dgMatHang[7, i].Value?.ToString().Trim().ToUpperInvariant();
                string cellValue8 = dgMatHang[8, i].Value?.ToString().Trim().ToUpperInvariant();


                bool containsSearchText = (!string.IsNullOrEmpty(cellValue0) && cellValue0.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue1) && cellValue1.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue2) && cellValue2.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue3) && cellValue3.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue5) && cellValue5.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue7) && cellValue7.Contains(searchText)) ||
                                          (!string.IsNullOrEmpty(cellValue8) && cellValue8.Contains(searchText));
                if (!containsSearchText)
                {
                    dgMatHang.Rows.RemoveAt(i);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cbtenlh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtenlh.SelectedItem != null)
            {
                string selectedMaLH= cbtenlh.SelectedValue.ToString();
                txtmalh.Text = selectedMaLH;

            }
        }
    }
}
