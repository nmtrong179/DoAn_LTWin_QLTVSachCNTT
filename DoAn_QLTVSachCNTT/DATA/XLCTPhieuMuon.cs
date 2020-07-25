using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_QLTVSachCNTT.DATA
{
    class XLCTPhieuMuon : XLBang
    {
        public XLCTPhieuMuon() : base("CTPHIEUMUON") { }
        public XLCTPhieuMuon(string pQuery) : base("CTPHIEUMUON", pQuery) { }
    }
}

