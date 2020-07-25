using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_QLTVSachCNTT.DATA
{
    class XLSach : XLBang
    {
        public XLSach() : base("SACH") { }
        public XLSach(string pQuery) : base("SACH", pQuery) { }
    }
}

