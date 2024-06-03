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
    public partial class GUI_MenuNV : Form
    {
        public GUI_MenuNV()
        {
            InitializeComponent();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            GUI_DangNhap f = new GUI_DangNhap();
            f.Show();
        }

        private void loạiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_LoaiHang f = new GUI_LoaiHang();
            f.Show();
        }

        private void mặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_MatHang f = new GUI_MatHang();
            f.Show();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaCC f = new GUI_NhaCC();
            f.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không có quyền quản lý chức năng này");
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_KhachHang f= new GUI_KhachHang();
            f.Show();
        }

        private void đơnHàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_DonHangNhap f= new GUI_DonHangNhap();
            f.Show();
        }

        private void đơnHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_DonHangBan f= new GUI_DonHangBan();
            f.Show();
        }

        private void chiTiếtĐơnHàngBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ChiTietDHB f= new GUI_ChiTietDHB();
            f.Show();
        }

        private void chiTiếtĐơnHàngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_ChiTietDHN f= new GUI_ChiTietDHN();
            f.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không có quyền quản lý chức năng này");
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn không có quyền quản lý chức năng này");
        }
    }
}
