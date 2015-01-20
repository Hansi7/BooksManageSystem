using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BooksManageSystem
{
    public class BuyList
    {
        public int BID { get; set; }
        public int Count { get; set; }
        public DateTime BuyDate { get; set; }
        public override string ToString()
        {
            return BuyDate.ToString("yyyy-MM-dd HH:mm:ss") + "\t" + Count.ToString() + "本"; 
        }
    }
}
