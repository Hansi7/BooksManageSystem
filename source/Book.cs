using System;
using System.Collections.Generic;
using System.Text;

namespace BooksManageSystem
{
    public class Book
    {
        private int _bookID;
                    
        public int BookID
        {
            get { return _bookID; }
            set { _bookID = value; }
        }

        private string _bookName;

        public string BookName
        {
            get { return _bookName; }
            set { _bookName = value; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private double _orderPrice;

        public double OrderPrice
        {
            get { return _orderPrice; }
            set { _orderPrice = value; }
        }

        private int _count;

        public int Count
        {
            get { return _count; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("书籍的数量不能为负数");
                }
                else
                {
                    _count = value; 
                }
            }
        }

        private bool _isStudentBook;
        /// <summary>
        /// 是否是学生用书
        /// </summary>
        public bool IsStuBook
        {
            get { return _isStudentBook; }
            set { _isStudentBook = value; }
        }

        public Book(int id,string name,double price,double orderprice,int count,bool stuBook) 
        {
            this._bookID = id;
            this._bookName = name;
            this._price = price;
            this._orderPrice = orderprice;
            this._count = count;
            this._isStudentBook = stuBook;
        }

        public override string ToString()
        {
            return this.BookID + "\t" + this.BookName + "\t" + this.Price + "\t" + this.OrderPrice + "\t" + this.Count + "\t" + this.IsStuBook;
        }

    }
}
