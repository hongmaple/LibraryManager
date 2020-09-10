using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BorrowReturn_BLL
    {
        BorrowReturn_DAL borrowReturn_dal = new BorrowReturn_DAL();

        //查询BorrowReturn表
        public DataSet selectHostory(BorrowReturn b, string radioName, String cboBorrowTimeType, Boolean checkTime)
        {
            return borrowReturn_dal.selectHostory(b, radioName, cboBorrowTimeType, checkTime);
        }

        //查询BorrowReturn表全部信息
        public DataSet AllBorrowReturn()
        {
            return borrowReturn_dal.AllBorrowReturn();
        }

        //查询图书BorrowReturn表
        public DataSet selectBorrowReturn(string BookId)
        {
            return borrowReturn_dal.selectBorrowReturn(BookId);
        }

        //用户借阅记录
        public DataSet ReaderBorrowReturn(string UserId)
        {
            return borrowReturn_dal.ReaderBorrowReturn(UserId);
        }

        //用户历史借阅记录
        public DataSet ReaderBorrowReturn1(string UserId)
        {
            return borrowReturn_dal.ReaderBorrowReturn1(UserId);
        }

        //还书
        public int ReturnBook(int BorrowReturnId)
        {
            return borrowReturn_dal.ReturnBook(BorrowReturnId);
        }

        //借书
        public int BorrowBook(BorrowReturn b)
        {
            return borrowReturn_dal.BorrowBook(b);
        }

        //续借
        public int RenewBook(BorrowReturn b)
        {
            return borrowReturn_dal.RenewBook(b);
        }
    }
}
