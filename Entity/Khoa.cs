using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Khoa
    {
        private string _Makhoa;
        private string _TenKhoa;

        public string Makhoa { get => _Makhoa; set => _Makhoa = value; }
        public string TenKhoa { get => _TenKhoa; set => _TenKhoa = value; }
    }
}
