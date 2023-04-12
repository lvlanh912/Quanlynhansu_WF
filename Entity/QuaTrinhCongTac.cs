using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class QuaTrinhCongTac
    {
        private string _MaCT;
        private string _MANS;
        private string _MaKhoa;
        private string _MaCV;
        private DateTime _NamBatDau;
        private DateTime _NamKetThuc;
        public string MaCT { get => _MaCT; set => _MaCT = value; }
        public string MANS { get => _MANS; set => _MANS = value; }
        public string MaKhoa { get => _MaKhoa; set => _MaKhoa = value; }
        public string MaCV { get => _MaCV; set => _MaCV = value; }
        public DateTime NamBatDau { get => _NamBatDau; set => _NamBatDau = value; }
        public DateTime NamKetThuc { get => _NamKetThuc; set => _NamKetThuc = value; }
    }
}
