using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class DangNhap
    {
        public DangNhap()
        { }
        public DangNhap(string TenDN,string MatKhau, string Quyen)
        {
            this.TenDN=TenDN;
            this.MatKhau=MatKhau;
            this.Quyen=Quyen;
        }
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; }
    }
}
