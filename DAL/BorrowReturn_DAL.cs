using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BorrowReturn_DAL
    {
        //查询BorrowReturn表信息
        public DataSet selectHostory(BorrowReturn b, string radioName, String cboBorrowTimeType, Boolean checkTime)
        {
            string sql = string.Format(@"select BookInfo.BookId as 'BookId',Reader.UserId as 'UserId',BookName,UserName,BookTypeName,UserTypeName,Gender,IdentityCard,BorrowTime,ReturnTime,FactReturnTime,Fine,RenewCount from BorrowReturn
                            inner join BookInfo on BookInfo.BookId=BorrowReturn.BookId
                            inner join Reader on Reader.UserId=BorrowReturn.UserId
                            inner join BookType on BookType.BookTypeId=BookInfo.BookTypeId
                            inner join ReaderType on ReaderType.UserTypeId=Reader.UserTypeId
                            where BookInfo.BookId like '%{0}%' and 
                            Reader.UserId like '%{1}%' ", b.BookId, b.UserId);
            if (radioName == "全部")
            {

            }
            else if (radioName == "已借")
            {
                sql += " and FactReturnTime	is  null ";
            }
            else if (radioName == "已还")
            {
                sql += " and FactReturnTime	is not null ";
            }

            return DBhelp.Create().ExecuteAdater(sql);
        }

        //查询BorrowReturn表全部信息
        public DataSet AllBorrowReturn()
        {
            string sql = @"select BookInfo.BookId as 'BookId',Reader.UserId as 'UserId',BookName,UserName,BookTypeName,UserTypeName,Gender,IdentityCard,BorrowTime,ReturnTime,FactReturnTime,Fine,RenewCount from BorrowReturn
                            inner join BookInfo on BookInfo.BookId=BorrowReturn.BookId
                            inner join Reader on Reader.UserId=BorrowReturn.UserId
                            inner join BookType on BookType.BookTypeId=BookInfo.BookTypeId
                            inner join ReaderType on ReaderType.UserTypeId=Reader.UserTypeId";
            return DBhelp.Create().ExecuteAdater(sql);
        }

        //查询图书BorrowReturn表（表连接）
        public DataSet selectBorrowReturn(string BookId)
        {
            string sql = @"select BookInfo.BookId,BookName,Reader.UserId,UserName,BorrowTime,ReturnTime,FactReturnTime,Fine,RenewCount,BorrowRemark from BookInfo
                    inner join BorrowReturn on BorrowReturn.BookId=BookInfo.BookId
                    inner join Reader on Reader.UserId=BorrowReturn.UserId 
                    where BookInfo.BookId=@BookId ";
            SqlParameter[] sp ={
                                   new SqlParameter("@BookId",BookId)
                               };

            return DBhelp.Create().ExecuteAdater(sql, sp);
        }


        //用户借阅记录
        public DataSet ReaderBorrowReturn(string UserId)
        {
            string sql = @"select BorrowId,Reader.UserId as 'UserId',UserName,BookInfo.BookId as 'BookId',BookName,BorrowTime,ReturnTime,FactReturnTime,Fine,RenewCount,BorrowRemark from Reader
                            inner join BorrowReturn on BorrowReturn.UserId=Reader.UserId
                            inner join BookInfo on BookInfo.BookId=BorrowReturn.BookId
                            where Reader.UserId=@UserId and FactReturnTime is null ";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserId",UserId)
                               };
            return DBhelp.Create().ExecuteAdater(sql, sp);
        }

        //用户历史借阅记录
        public DataSet ReaderBorrowReturn1(string UserId)
        {
            string sql = @"select BorrowId,Reader.UserId as 'UserId',UserName,BookInfo.BookId as 'BookId',BookName,BorrowTime,ReturnTime,FactReturnTime,Fine,RenewCount,BorrowRemark from Reader
                            inner join BorrowReturn on BorrowReturn.UserId=Reader.UserId
                            inner join BookInfo on BookInfo.BookId=BorrowReturn.BookId
                            where Reader.UserId=@UserId and FactReturnTime is not null ";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserId",UserId)
                               };
            return DBhelp.Create().ExecuteAdater(sql, sp);
        }

        //还书
        public int ReturnBook(int BorrowReturnId)
        {
            string sql = @"update BorrowReturn set FactReturnTime=@FactReturnTime,RenewCount=0 where BorrowId=@BorrowId";
            SqlParameter[] sp ={
                                   new SqlParameter("@FactReturnTime",DateTime.Now),
                                   new SqlParameter("@BorrowId",BorrowReturnId)
                               };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        //借书
        public int BorrowBook(BorrowReturn b)
        {
            string sql = "proc_BorrowBook";
            Console.WriteLine(b.BookId);
            SqlParameter[] sp ={
                                   new SqlParameter("@BorrowId",DbType.Int32),
                                   new SqlParameter("@BookId",b.BookId),
                                   new SqlParameter("@UserId",b.UserId),
                                   new SqlParameter("@BorrowTime",b.BorrowTime),
                                   new SqlParameter("@ReturnTime",b.ReturnTime),
                                   new SqlParameter("@Fine",b.Fine),
                                   new SqlParameter("@RenewCount",b.RenewCount),
                                   new SqlParameter("@BorrowRemark",b.BorrowRemark),
                                   new SqlParameter("@ReturnValue",DbType.Int32)
                              };
            sp[0].Direction = ParameterDirection.Output;
            sp[sp.Length - 1].Direction = ParameterDirection.ReturnValue;
            DBhelp.Create().ExecuteNonQuery(sql, CommandType.StoredProcedure, sp);
            b.BorrowId = (int)sp[0].Value;
            return (int)sp[sp.Length - 1].Value;
        }

        //续借
        public int RenewBook(BorrowReturn b)
        {
            string sql = @"update BorrowReturn set ReturnTime=dateadd(month,3,ReturnTime),RenewCount=RenewCount+1 where BorrowId=@BorrowId";
            SqlParameter[] sp ={
                                   new SqlParameter("@BorrowId",b.BorrowId)
                               };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }
    }
}
