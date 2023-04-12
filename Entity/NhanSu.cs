using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class NhanSu
    {
        private string _MANS;
        private string _TenNS;
        private string _GioiTinh;
        private DateTime _NgaySinh;
        private string _DiaChi;
        private string _SDT;
        private string _Email;
        public string MANS { get => _MANS; set => _MANS = value; }
        public string TenNS { get => _TenNS; set => _TenNS = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string SDT { get => _SDT; set => _SDT = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
