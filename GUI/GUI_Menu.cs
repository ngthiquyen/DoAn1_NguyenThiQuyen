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
    public partial class GUI_Menu : Form
    {
        public GUI_Menu()
        {
            InitializeComponent();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đơnHàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_DonHangNhap f = new GUI_DonHangNhap();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUI_DangNhap f=new GUI_DangNhap();
            f.ShowDialog();

        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_LoaiHang f=new GUI_LoaiHang();
            f.ShowDialog();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_MatHang f=new GUI_MatHang();
            f.ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaCC f=new GUI_NhaCC();
            f.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhanVien f=new GUI_NhanVien();
            f.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_KhachHang f=new GUI_KhachHang();
            f.ShowDialog();
        }

        private void chiTiếtĐơnHàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ChiTietDHN f=new GUI_ChiTietDHN();
            f.ShowDialog();
        }

        private void đơnHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_DonHangBan f=new GUI_DonHangBan();
            f.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ThongKe f=new GUI_ThongKe();
            f.ShowDialog();
        }

        private void chiTiếtĐơnHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ChiTietDHB f=new GUI_ChiTietDHB();
            f.ShowDialog();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_BaoCao f=new GUI_BaoCao();
            f.ShowDialog();
        }
    }
}
