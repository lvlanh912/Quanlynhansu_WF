using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class QuaTrinhHocTap
    {
        private string _MaQTHT;
        private string _MANS;
        private string _MaHV;
        private string _Truong;
        private DateTime _NamBatDau;
        private DateTime _NamKetThuc;

        public string MaQTHT { get => _MaQTHT; set => _MaQTHT = value; }
        public string MANS { get => _MANS; set => _MANS = value; }
        public string MaHV { get => _MaHV; set => _MaHV = value; }
        public string Truong { get => _Truong; set => _Truong = value; }
        public DateTime NamBatDau { get => _NamBatDau; set => _NamBatDau = value; }
        public DateTime NamKetThuc { get => _NamKetThuc; set => _NamKetThuc = value; }
    }
}
