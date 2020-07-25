using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_QLTVSachCNTT.DATA
{
    class XLTaiKhoan : XLBang
    {
        public XLTaiKhoan() : base("TAIKHOAN") { }
        public XLTaiKhoan(string pQuery) : base("TAIKHOAN", pQuery) { }
    }
}

