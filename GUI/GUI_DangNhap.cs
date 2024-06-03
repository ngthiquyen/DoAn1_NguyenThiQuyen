using BLL;
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
    public partial class GUI_DangNhap : Form
    {
        public GUI_DangNhap()
        {
            InitializeComponent();
        }
        
       
        private void Btntrove_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btndangnhap_Click(object sender, EventArgs e)
        {
           
            if (txtdangnhap.Text=="admin" && txtmatkhau.Text=="admin" && cbquyen.Text=="Admin" )
            {
                GUI_Menu f = new GUI_Menu();
                this.Visible = false;
                f.ShowDialog();
            }
            else if (txtdangnhap.Text=="user" && txtmatkhau.Text=="user" && cbquyen.Text == "Nhân viên")
            {
                GUI_MenuNV f = new GUI_MenuNV();
                this.Visible = false;
                f.ShowDialog();
             
            }
            else if (txtdangnhap.Text.Trim() == "" && txtmatkhau.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không đế trống!");
            }

            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
            }
        }
    }
}
