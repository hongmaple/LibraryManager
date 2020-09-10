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
    public class BookType_DAL
    {
        public List<BookType> selectBookType()
        {
            string sql = "select *  from BookType";
            List<BookType> list = new List<BookType>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql);
            while (reader.Read())
            {
                BookType b = new BookType();
                b.BookTypeId = reader.GetInt32(0);
                b.BookTypeName = reader.GetString(1);
                list.Add(b);
            }
            reader.Close();
            return list;
        }

        public DataSet selectBookType1()
        {
            string sql = "select BookTypeId,BookTypeName from BookType";
            return DBhelp.Create().ExecuteAdater(sql);
        }

        public int AddBookTypeInfo(BookType type)
        {
            string sql = "proc_AddBookTypeInfo";
            SqlParameter[] sp ={
                                   new SqlParameter("@BookTypeId",SqlDbType.Int),
                                   new SqlParameter("@BookTypeName",type.BookTypeName),
                                   new SqlParameter("@ReturnValue",SqlDbType.Int)
                               };
            sp[0].Direction = ParameterDirection.Output;
            sp[2].Direction = ParameterDirection.ReturnValue;
            DBhelp.Create().ExecuteNonQuery(sql,CommandType.StoredProcedure, sp);

            type.BookTypeId = (int)sp[0].Value;
            return (int)sp[2].Value;
        }

        //删除图书类型
        public int deleteBookType(int BookTypeId)
        {
            string sql = @"delete from BorrowReturn where BookId in(select BookId from BookInfo where BookTypeId=@BookTypeId)
                            delete from BookInfo where BookTypeId=@BookTypeId
                            delete from BookType where BookTypeId=@BookTypeId";
            SqlParameter[] sp ={
                                   new SqlParameter("@BookTypeId",BookTypeId)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp:sp);
        }

        //修改图书类型
        public int updateBookType(BookType type)
        {
            string sql = "update BookType set BookTypeName=@BookTypeName where BookTypeId=@BookTypeId";
            SqlParameter[] sp ={
                                   new SqlParameter("@BookTypeId",type.BookTypeId),
                                   new SqlParameter("@BookTypeName",type.BookTypeName)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }
    }
}
