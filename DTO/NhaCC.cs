using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCC
    {
        public NhaCC() { }
        public NhaCC( string MaNCC, string TenNCC,string Diachi, string Sdt, string Email) 
        { 
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.Diachi = Diachi;
            this.SDT= Sdt;
            this.Email = Email;
        }
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string Diachi { get; set; }
        public string SDT { get; set; }
        public string Email { get;set; }

    }
}
