using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_QLTVSachCNTT.DATA
{
    class XLPhieuMuon : XLBang
    {
        public XLPhieuMuon() : base("PHIEUMUON") { }
        public XLPhieuMuon(string pQuery) : base("PHIEUMUON", pQuery) { }
    }
}

