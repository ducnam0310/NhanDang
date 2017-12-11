using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XuLyAnh
{
    class LuatMau
    {
        public String Ten { get; set; }
        public float DoLon { get; set; }
        public float DoChay { get;set;}
        public int Lop { get; set; }
        public LuatMau()
        {

        }

        public LuatMau(string ten, float doLon, float doChay, int lop)
        {
            Ten = ten;
            DoLon = doLon;
            DoChay = doChay;
            Lop = lop;
        }
    }
}
