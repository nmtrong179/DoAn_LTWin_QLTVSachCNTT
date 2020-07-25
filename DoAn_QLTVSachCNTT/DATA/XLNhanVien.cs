using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_QLTVSachCNTT.DATA
{
    class XLNhanVien : XLBang
    {
        public XLNhanVien() : base("NHANVIEN") { }
        public XLNhanVien(string pQuery) : base("NHANVIEN", pQuery) { }
    }
}
