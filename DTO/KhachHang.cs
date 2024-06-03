using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public KhachHang()
        {
        }
        public KhachHang(string MaKH, string TenKH, string Diachi, string Email, string SDT, string GTinh, DateTime Ngaysinh)
        {
            this.MaKH = MaKH;
            this.TenKH = TenKH;
            this.Diachi = Diachi;
            this.Email = Email;
            this.SDT = SDT;
            this.GTinh = GTinh;
            this.Ngaysinh = Ngaysinh;
        }

        public string MaKH { get; set; }
        public string TenKH { get; set; }
        public string Diachi { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string GTinh { get; set; }
        public DateTime Ngaysinh { get; set; }

    }

}
