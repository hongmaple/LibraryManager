using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;

namespace BLL
{
    public class BookInfo_BLL
    {
        BookInfo_DAL b = new BookInfo_DAL();

        //查询BookInfo表
        public List<BookInfo> selectBookInfo()
        {
            return b.selectBookInfo();
        }

        //查询BookInfo表
        public List<BookInfo> selectBookInfo(string BookId)
        {
            return b.selectBookInfo(BookId);
        }

        //查询BookInfo表
        public DataSet selectBookInfo1()
        {
            return b.selectBookInfo1();
        }

        //查询BookInfo表带条件
        public DataSet selectBookInfo1(int index)
        {
            return b.selectBookInfo1(index);
        }

        //查询BookInfo表带2条件
        public DataSet selectBookInfo1(string A, string B)
        {
            return b.selectBookInfo1(A, B);
        }

        //查询BookInfo表带全部条件 
        public DataSet selectBookInfo1(List<string> list, string B)
        {
            return b.selectBookInfo1(list, B);
        }

        //查询BookInfo表，目前可以借阅的图书
        public DataSet selectBookInfo2(string BookId)
        {
            return b.selectBookInfo2(BookId);
        }

        //修改图书信息
        public int ExitBookInfo(BookInfo book)
        {
            return b.ExitBookInfo(book);
        }

        //添加图书信息
        public int AddBookInfo(BookInfo book)
        {
            return b.AddBookInfo(book);
        }

        //删除图书信息
        public int DeleteBookInfo(string BookId)
        {
            return b.DeleteBookInfo(BookId);
        }
    }
}
