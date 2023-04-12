using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HocVan
    {
        private string _MaHV;
        private string _TenHV;
        public string MaHV { get => _MaHV; set => _MaHV = value; }
        public string TenHV { get => _TenHV; set => _TenHV = value; }
    }
}
