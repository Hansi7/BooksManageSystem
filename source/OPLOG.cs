using System;
using System.Collections.Generic;
using System.Text;

namespace BooksManageSystem
{
    public class OPLOG
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public EnumOP op { get; set; }
        public DateTime OPdatetime { get; set; }
        public int OPCount { get; set; }
        public int AfterOPCount { get; set; }
        public string oper { get; set; }
        public int OPID { get; set; }
    }
}
