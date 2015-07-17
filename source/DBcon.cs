using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.OleDb;

namespace BooksManageSystem
{
    internal class DBcon
    {

        #region 书籍列表
        private DataTable _dal_getBookList()
        {
            using (OleDbCommand comm = new OleDbCommand(@"select * from books"))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }
        private DataTable _dal_getBookListByName(string name)
        {
            using (OleDbCommand comm = new OleDbCommand(@"select * from books where bookname like '%" + name + "%'"))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }
        private DataTable _dal_getOneBookByID(int id)
        {
            using (OleDbCommand comm = new OleDbCommand(@"select * from books where ID =" + id ))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }

        private List<Book> _ToModuleBookList(DataTable dt)
        {
            List<Book> list = new List<Book>();
            foreach (DataRow item in dt.Rows)
            {
                int id = int.Parse(item[0].ToString());//id
                string name = item[1].ToString();//name
                double price = double.Parse(item[2].ToString());//price
                double order_Price = double.Parse(item[3].ToString());//order_Price
                int cout = int.Parse(item[4].ToString());//count
                bool isStu = bool.Parse(item[5].ToString());
                Book b = new Book(id, name, price, order_Price, cout, isStu);
                list.Add(b);
            }
            return list;
        }
        public List<Book> GetBookList()
        {
            return _ToModuleBookList(_dal_getBookList());
        }
        public List<Book> GetBookListByName(string bkname)
        {
            return _ToModuleBookList(_dal_getBookListByName(bkname));
        }
        public Book GetOneBookByID(int id)
        {
            var list = _ToModuleBookList(_dal_getOneBookByID(id));
            if (list.Count==1)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }


        private int _dal_addNewBook(string bkname,double price,double orderprice, int count,bool studentBook )
        {
            using (OleDbCommand comm = new OleDbCommand(@"insert into books(bookname,price,order_price,books_count,IS_STUDENTBOOK)values('" + bkname + "'," + price + "," + orderprice + "," + count + "," + studentBook +")"))
            {
                return DBHelper.ExecuteNonQuery(comm);
            }
        }
        private int _dal_ModifyBook(int id, string bookname, double price, double orderprice, int count, bool studentBook)
        {
            using (OleDbCommand comm = new OleDbCommand(@"update books set bookname='" + bookname + "',price="+ price +",order_price=" + orderprice+ ",books_count=" + count +",IS_STUDENTBOOK=" + studentBook + " where id=" +  id))
            {
                return DBHelper.ExecuteNonQuery(comm);
            }
        }
        public int AddNewBook(string bookname,double price,double orderprice,int count,bool studentBook)
        {
            return _dal_addNewBook(bookname, price, orderprice, count,studentBook);
        }
        public int ModifyBook(int id, string bookname, double price, double orderprice, int count, bool studentBook)
        {
           return  _dal_ModifyBook(id, bookname, price, orderprice, count, studentBook);
        }


        #endregion
        
        #region 变更数量操作
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="opertor"></param>
        /// <param name="time"></param>
        /// <returns>返回变更后的数量</returns>
        public int SellBookByID(int id,int count,string opertor,DateTime time)
        {
            int c = queryCountByID(id);
            if (c < count)
            {
                throw new Exception("没有足够数量的书可供售出!");
            }

            using (OleDbCommand comm = new OleDbCommand(@"update books set books_count = " + (c - count).ToString() +  " where id = " + id.ToString() ))
            {
                DBHelper.ExecuteNonQuery(comm);
            }

            using (OleDbCommand comm = new OleDbCommand(@"insert into operate (op_book_no,op,op_date,op_count,operator,after_op_count) values 
(" + id + "," + ((int)EnumOP.售).ToString() + ",'" + time.ToString() + "'," + count.ToString() + ",'" + opertor + "'," + (c - count) + ")"))
            {
                //INSERT INTO table_name (列1, 列2,...) VALUES (值1, 值2,....)
                DBHelper.ExecuteNonQuery(comm);
                return c - count;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="opertor"></param>
        /// <param name="time"></param>
        /// <returns>返回变更后的数量</returns>
        public int Lingqu(int id, int count, string opertor, DateTime time)
        {
            int c = queryCountByID(id);
            if (c < count)
            {
                throw new Exception("没有足够数量的书可供领取!");
            }

            using (OleDbCommand comm = new OleDbCommand(@"update books set books_count = " + (c - count).ToString() + " where id = " + id.ToString()))
            {
                DBHelper.ExecuteNonQuery(comm);
            }

            using (OleDbCommand comm = new OleDbCommand(@"insert into operate (op_book_no,op,op_date,op_count,operator,after_op_count) values 
(" + id + "," + ((int)EnumOP.领).ToString() + ",'" + time.ToString() + "'," + count.ToString() + ",'" + opertor + "'," + (c - count) + ")"))
            {
                //INSERT INTO table_name (列1, 列2,...) VALUES (值1, 值2,....)
                DBHelper.ExecuteNonQuery(comm);
                return c - count;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="oper"></param>
        /// <param name="time"></param>
        /// <returns>返回变更后的数量</returns>
        public int PurchaseBook(int id, int count, string oper, DateTime time, int bid)
        {
            int c = queryCountByID(id);
            using (OleDbCommand comm = new OleDbCommand(@"update books set books_count = " + (c + count).ToString() + " where id = " + id.ToString()))
            {
                DBHelper.ExecuteNonQuery(comm);
            }


            if (bid==0)
            {
                using (OleDbCommand comm = new OleDbCommand(@"insert into operate (op_book_no,op,op_date,op_count,operator,after_op_count) values 
(" + id + "," + ((int)EnumOP.购).ToString() + ",'" + time.ToString() + "'," + count.ToString() + ",'" + oper + "'," + (c + count) + ")"))
                {
                    //INSERT INTO table_name (列1, 列2,...) VALUES (值1, 值2,....)
                    DBHelper.ExecuteNonQuery(comm);
                    return c + count;
                }
            }
            else
            {
                using (OleDbCommand comm = new OleDbCommand(@"insert into operate (op_book_no,op,op_date,op_count,operator,after_op_count,bid) values 
(" + id + "," + ((int)EnumOP.购).ToString() + ",'" + time.ToString() + "'," + count.ToString() + ",'" + oper + "'," + (c + count) + "," + bid + ")"))
                {
                    //INSERT INTO table_name (列1, 列2,...) VALUES (值1, 值2,....)
                    DBHelper.ExecuteNonQuery(comm);
                    return c + count;
                }
            }









        }
        /// <summary>
        /// 返回BID
        /// </summary>
        /// <param name="totalcount"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public int Blist(int totalcount, DateTime time)
        {
            using (OleDbCommand comm = new OleDbCommand(@"insert into blist (bcount,bdate) values(" + totalcount + ",'" + time.ToString() + "')"))
            {
                DBHelper.ExecuteNonQuery(comm);
            }
            using (OleDbCommand comm = new OleDbCommand(@"SELECT MAX(BID) AS id FROM BLIST"))
            {
                var o = DBHelper.ExecuteScalar(comm);
                return Convert.ToInt32(o);
            }
            
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="count"></param>
        /// <param name="oper"></param>
        /// <param name="time"></param>
        /// <returns>返回变更后的数量</returns>
        public int ReturnBookByID(int id, int count, string oper, DateTime time)
        {
            int c = queryCountByID(id);
            using (OleDbCommand comm = new OleDbCommand(@"update books set books_count = " + (c + count).ToString() + " where id = " + id.ToString()))
            {
                DBHelper.ExecuteNonQuery(comm);
            }

            using (OleDbCommand comm = new OleDbCommand(@"insert into operate (op_book_no,op,op_date,op_count,operator,after_op_count) values 
(" + id + "," + ((int)EnumOP.还).ToString() + ",'" + time.ToString() + "'," + count.ToString() + ",'" + oper + "'," + (c + count) + ")"))
            {
                //INSERT INTO table_name (列1, 列2,...) VALUES (值1, 值2,....)
                DBHelper.ExecuteNonQuery(comm);
                return c + count;
            }

        } 
        #endregion

        #region 分操作

        //查询书的数量OK
        private int queryCountByID(int id )
        {
            using (OleDbCommand comm = new OleDbCommand(@"select books_count from books where id = " + id))
            {
                return Convert.ToInt32(DBHelper.ExecuteScalar(comm));
            }
        }
        //Untest

        private int queryIDByName(string bookname)
        {
            using (OleDbCommand comm = new OleDbCommand(@"select id from books where bookname = '" + bookname + "'"))
            {
                return Convert.ToInt32(DBHelper.ExecuteScalar(comm));
            }
        }



        #endregion

        #region 操作记录
        private DataTable _dal_getOPLOGByBookID(int id)
        {
            using (OleDbCommand comm = new OleDbCommand(@"SELECT top 1000 BOOKS.ID,BOOKS.BOOKNAME, OPERATE.OP, OPERATE.OP_DATE, OPERATE.OP_COUNT,after_op_count, OPERATE.OPERATOR,OPERATE.ID
                                                            FROM   (BOOKS INNER JOIN OPERATE ON BOOKS.ID = OPERATE.OP_BOOK_NO)
                                                            WHERE   (OPERATE.OP_BOOK_NO = " + id + @")
                                                            ORDER BY OPERATE.OP_DATE DESC"))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }
        private DataTable _dal_getOPLOGByBID(int Bid)
        {
            using (OleDbCommand comm = new OleDbCommand(@"SELECT top 1000 BOOKS.ID,BOOKS.BOOKNAME, OPERATE.OP, OPERATE.OP_DATE, OPERATE.OP_COUNT,after_op_count, OPERATE.OPERATOR,OPERATE.ID
                                                            FROM   (BOOKS INNER JOIN OPERATE ON BOOKS.ID = OPERATE.OP_BOOK_NO)
                                                            WHERE   (OPERATE.BID = " + Bid + @")
                                                            ORDER BY OPERATE.OP_DATE DESC"))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }
        private DataTable _dal_getOPLOGALL()
        {
            using (OleDbCommand comm = new OleDbCommand(@"SELECT TOP 1000 BOOKS.ID,BOOKS.BOOKNAME, OPERATE.OP, OPERATE.OP_DATE, OPERATE.OP_COUNT,after_op_count, OPERATE.OPERATOR,OPERATE.ID
                                                            FROM   (BOOKS INNER JOIN OPERATE ON BOOKS.ID = OPERATE.OP_BOOK_NO)
                                                            ORDER BY OPERATE.OP_DATE DESC"))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }
        private int _dal_ModifyOPLogByOPID(int opid, DateTime dt, string oper)
        {
            using (OleDbCommand comm = new OleDbCommand(@"update operate set OP_DATE=Cdate('"+dt.ToString("yyyy-MM-dd HH:mm:ss")+"'),operator = '"+oper+"' where id = " + opid))
            {
                return DBHelper.ExecuteNonQuery(comm);
            }
        }

        private List<OPLOG> _ToModuleSellList(DataTable dt)
        {
            List<OPLOG> list = new List<OPLOG>();
            foreach (DataRow item in dt.Rows)
            {
                int bkid = int.Parse(item[0].ToString());
                string bkname = item[1].ToString();
                EnumOP op = (EnumOP)Enum.Parse(typeof(EnumOP), item[2].ToString());
                DateTime opdate = DateTime.Parse(item[3].ToString());
                int cout = int.Parse(item[4].ToString());
                int afcount = int.Parse(item[5].ToString());
                string oper = item[6].ToString();
                int opid = int.Parse(item[7].ToString());
                OPLOG oplog = new OPLOG()
                {
                    BookID = bkid,
                    BookName = bkname,
                    op = op,
                    OPdatetime = opdate,
                    OPCount = cout,
                    AfterOPCount = afcount,
                    oper = oper,
                    OPID = opid
                };
                list.Add(oplog);
            }
            return list;
        }

        public List<OPLOG> GetOPLogByID(int id)
        {
            return _ToModuleSellList(_dal_getOPLOGByBookID(id));
        }
        public List<OPLOG> GetOPLogByBID(int bid)
        {
            return _ToModuleSellList(_dal_getOPLOGByBID(bid));
        }
        public List<OPLOG> GetOPLogALL()
        {
            return _ToModuleSellList(_dal_getOPLOGALL());
        }
        /// <summary>
        /// 修改操作记录
        /// </summary>
        /// <param name="opid"></param>
        /// <param name="dt"></param>
        /// <param name="oper"></param>
        /// <returns></returns>
        public int ModifyOPLog(int opid,DateTime dt,string oper)
        {
            return _dal_ModifyOPLogByOPID(opid, dt, oper);
        }
        /// <summary>
        /// 撤销操作记录
        /// </summary>
        /// <param name="opid"></param>
        /// <returns></returns>
        public int UndoOPByOPID(int opid)
        {
            using (OleDbCommand comm = new OleDbCommand(@"SELECT   BOOKS.ID, BOOKS.BOOKNAME, OPERATE.OP, OPERATE.OP_DATE, OPERATE.OP_COUNT, OPERATE.AFTER_OP_COUNT, OPERATE.OPERATOR, OPERATE.ID AS OPID
                                                        FROM      (BOOKS INNER JOIN OPERATE ON BOOKS.ID = OPERATE.OP_BOOK_NO)
                                                        WHERE   (OPERATE.ID = " + opid + ")"))
            {
                var dt = DBHelper.ExecuteDataTable(comm);
                var oplogList = _ToModuleSellList(dt);
                if (oplogList.Count == 0)
                {
                    return 0;
                }
                var oplog = oplogList[0];
                if (oplog.op == EnumOP.购 || oplog.op == EnumOP.还)
                {
                    int c = queryCountByID(oplog.BookID);
                    using (OleDbCommand comm2 = new OleDbCommand(@"update books set books_count = " + (c - oplog.OPCount).ToString() + " where id = " + oplog.BookID))
                    {
                        DBHelper.ExecuteNonQuery("delete from operate where ID = " + opid);
                        return DBHelper.ExecuteNonQuery(comm2);
                    }
                }
                if (oplog.op == EnumOP.领 || oplog.op == EnumOP.售)
                {
                    int c = queryCountByID(oplog.BookID);
                    using (OleDbCommand comm2 = new OleDbCommand(@"update books set books_count = " + (c + oplog.OPCount).ToString() + " where id = " + oplog.BookID))
                    {
                        DBHelper.ExecuteNonQuery("delete from operate where ID = " + opid);
                        return DBHelper.ExecuteNonQuery(comm2);
                    }
                }
                return 0;
            }
        }






        #endregion

        #region 销售统计
        private int _dal_getTotalSell()
        {
            using (OleDbCommand comm= new OleDbCommand(@"SELECT   SUM(BOOKS.PRICE * OPERATE.OP_COUNT) AS Total 
                                                        FROM (BOOKS INNER JOIN OPERATE ON BOOKS.ID = OPERATE.OP_BOOK_NO)
                                                        WHERE   (OPERATE.OP = 1)"))
            {
                return Convert.ToInt32(DBHelper.ExecuteScalar(comm));
            }
        }
        private int GetTotalSell()
        {
            return _dal_getTotalSell();
        }

        private DataTable _dal_getSellList(DateTime dt_start, DateTime dt_end)
        {
            int year = DateTime.Now.Year;
            using (OleDbCommand comm = new OleDbCommand(@"SELECT   BOOKS.ID AS 编号, BOOKS.BOOKNAME AS 书名, BOOKS.PRICE AS 定价, OPERATE.OP_COUNT AS 数量, 
                                                            OPERATE.OP_DATE AS 销售时间, OPERATE.OPERATOR AS 备注信息, 
                                                            BOOKS.PRICE * OPERATE.OP_COUNT AS 小计
                                                        FROM      (BOOKS INNER JOIN
                                                            OPERATE ON BOOKS.ID = OPERATE.OP_BOOK_NO)
                                                        WHERE   (OPERATE.OP = 1) AND (OPERATE.OP_DATE > CDATE('" + dt_start.ToString("yyyy-MM-dd HH:mm:ss") + "')) and (OPERATE.OP_DATE < CDATE('" + dt_end.ToString("yyyy-MM-dd HH:mm:ss") + "'))"))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }
        public DataTable GetSellList(DateTime start,DateTime end)
        {
            return _dal_getSellList(start,end);
        }

        /// <summary>
        /// 领取导出
        /// </summary>
        /// <param name="dt_start"></param>
        /// <param name="dt_end"></param>
        /// <returns></returns>
        public DataTable GetHandOutList(DateTime dt_start, DateTime dt_end)
        {
            int year = DateTime.Now.Year;
            using (OleDbCommand comm = new OleDbCommand(@"SELECT   BOOKS.ID AS 编号, BOOKS.BOOKNAME AS 书名, BOOKS.PRICE AS 定价, OPERATE.OP_COUNT AS 数量, 
                                                            OPERATE.OP_DATE AS 领取时间, OPERATE.OPERATOR AS 备注信息, 
                                                            BOOKS.PRICE * OPERATE.OP_COUNT AS 小计
                                                        FROM      (BOOKS INNER JOIN
                                                            OPERATE ON BOOKS.ID = OPERATE.OP_BOOK_NO)
                                                        WHERE   (OPERATE.OP = 2) AND (OPERATE.OP_DATE > CDATE('" + dt_start.ToString("yyyy-MM-dd HH:mm:ss") + "')) and (OPERATE.OP_DATE < CDATE('" + dt_end.ToString("yyyy-MM-dd HH:mm:ss") + "'))"))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }

        #endregion

        #region ClearAll

        public bool ClearDataBase()
        {
            try
            {
                DBHelper.ExecuteNonQuery(@"delete * from operate");
                DBHelper.ExecuteNonQuery(@"delete * from books");
                DBHelper.ExecuteNonQuery(@"delete * from blist");
                DBHelper.ExecuteNonQuery(@"alter table operate alter column ID counter(1,1)");
                DBHelper.ExecuteNonQuery(@"alter table books alter column ID counter(1,1)");
                DBHelper.ExecuteNonQuery(@"alter table blist alter column BID counter(1,1)");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion

        #region 批量购入记录

        private DataTable _dal_getBlist()
        {
            string command = "select * from blist";
            using (OleDbCommand comm = new OleDbCommand(command))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }
        private List<BuyList> _ToModuleBuyList(DataTable dt)
        {
            List<BuyList> blist = new List<BuyList>();
            foreach (DataRow item in dt.Rows)
            {
                BuyList bl = new BuyList();
                bl.BID = int.Parse(item[0].ToString());
                bl.Count = int.Parse(item[1].ToString());
                bl.BuyDate = DateTime.Parse(item[2].ToString());
                blist.Add(bl);
            }
            return blist;
        }
        public List<BuyList>  GetAllBuyList()
        {
            return _ToModuleBuyList(_dal_getBlist());
        }

        #endregion

        #region 书列表操作 针对表Booklist

        /// <summary>
        /// 获取书的列表的列表
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> BookListALL()
        { 
            return _ToModuleBookListList(_dal_getBookListList());
        }

        private DataTable _dal_getBookListList()
        {
            using (OleDbCommand comm = new OleDbCommand("select * from booklist"))
            {
                return DBHelper.ExecuteDataTable(comm);
            }
        }

        private Dictionary<int, string> _ToModuleBookListList(DataTable dt)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            foreach (DataRow item in dt.Rows)
            {
                int i = int.Parse(item[0].ToString());
                string s = item[2].ToString();

                dic.Add(i, s);
            }
            return dic;
        }

        public List<Book> GetBookListFromBookListID(int id)
        {
            List<Book> list = new List<Book>();
            string s = DBHelper.ExecuteScalar(new OleDbCommand("select booksid from booklist where lid = " + id)).ToString();
            var ids = s.Split(',');
            for (int i = 0; i < ids.Length; i++)
            {
                var bk = this.GetOneBookByID(int.Parse(ids[i]));
                list.Add(bk);
            }
            return list;
        }

        public int SaveBookList(List<Book> bklst,string tag)
        { 
            //insert into books(bookname,price,order_price,books_count,IS_STUDENTBOOK)values('" + bkname + "'," + price + "," + orderprice + "," + count + "," + studentBook +")"))
            StringBuilder bkids = new StringBuilder();

            for (int i = 0; i < bklst.Count; i++)
            {
                if (bkids.Length==0)
                {
                    bkids.Append(bklst[i].BookID);
                }
                else
                {
                    bkids.Append("," + bklst[i].BookID);
                }
            }

            using (OleDbCommand comm = new OleDbCommand("insert into booklist(booksid,tag)values('"+ bkids.ToString() +"','" + tag + "' )"))
            {
                return DBHelper.ExecuteNonQuery(comm);
            }

        }

        public int RemoveBookListByBookListID(int id)
        {
            return DBHelper.ExecuteNonQuery(new OleDbCommand("delete from booklist where lid = " + id));
        }
        #endregion
    }
}
