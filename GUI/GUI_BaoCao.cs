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
    public partial class GUI_BaoCao : Form
    {
        public GUI_BaoCao()
        {
            InitializeComponent();
        }
        BLL_BaoCao busBaoCao= new BLL_BaoCao();
        ChiTietDHB ctdhb= new ChiTietDHB();
        
        private void btbaocao_Click(object sender, EventArgs e)
        {

            DateTime fromDate = FromDate.Value; // Ngày bắt đầu muốn thống kê
            DateTime toDate = ToDate.Value; // Ngày kết thúc thống kê
            DataTable dt = busBaoCao.BaoCaoDoanhThu(fromDate, toDate); // Truyền ngày tháng năm vào phương thức BaoCaoDoanhThu ở BUS Báo cáo
            dgbaocao.DataSource = dt;
        }

        private void dgbaocao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtban.Text = dgbaocao[2, i].Value.ToString();
            txtnhap.Text = dgbaocao[3, i].Value.ToString();
            txtlai.Text = dgbaocao[4, i].Value.ToString();
            txtslban.Text = dgbaocao[5, i].Value.ToString();
            txtslnhap.Text = dgbaocao[6, i].Value.ToString();
        }

        private void bttrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
