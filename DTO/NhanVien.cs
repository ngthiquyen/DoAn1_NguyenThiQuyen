using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public NhanVien()
        {

        }
        public NhanVien(string MaNV,string TenNV, string GTinh, DateTime Ngaysinh, string Diachi,string Email,string SDT,float Luong )
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.GTinh = GTinh;
            this.Ngaysinh = Ngaysinh;
            this.Diachi = Diachi;
            this.Email = Email;
            this.SDT = SDT;
            this.Luong= Luong;
            
        }
        public string MaNV { get; set; }
        public string TenNV { get; set; } 
        public string GTinh { get; set; }
        public DateTime Ngaysinh { get;set;}
        public string Diachi { get; set;}
        public string Email { get; set;}
        public string SDT { get; set;}
        public float Luong { get; set;}
    }
}
