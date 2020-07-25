using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_QLTVSachCNTT.DATA
{
    class XLDocGia : XLBang
    {
        public XLDocGia() : base("DOCGIA") { }
        public XLDocGia(string pQuery) : base("DOCGIA", pQuery) { }
    }
}

