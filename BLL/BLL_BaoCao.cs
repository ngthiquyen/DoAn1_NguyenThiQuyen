using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class BLL_BaoCao
    {
        private readonly DAL_BaoCao DoanhThu;

        public BLL_BaoCao()
        {
            DoanhThu = new DAL_BaoCao();
        }

        public DataTable BaoCaoDoanhThu(DateTime fromDate, DateTime toDate)
        {
            return DoanhThu.BaoCaoDoanhThu(fromDate, toDate);// Bus báo cáo doanh thu trong khoảng thời gian nhập từ bàn phím
        }
    }
}
