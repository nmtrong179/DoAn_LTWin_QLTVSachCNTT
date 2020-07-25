using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_QLTVSachCNTT.DATA
{
    class XLNhaCungCap : XLBang
    {
        public XLNhaCungCap() : base("NHACUNGCAP") { }
        public XLNhaCungCap(string pQuery) : base("NHACUNGCAP", pQuery) { }
    }
}

