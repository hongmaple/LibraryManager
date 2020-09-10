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
    public class BookType_BLL
    {
        BookType_DAL bookType_dal = new BookType_DAL();
       
        public List<BookType> selectBookType()
        {
            return bookType_dal.selectBookType();
        }

        public DataSet selectBookType1()
        {
            return bookType_dal.selectBookType1();
        }

        public int AddBookTypeInfo(BookType type)
        {
            return bookType_dal.AddBookTypeInfo(type);
        }

        //删除图书类型
        public int deleteBookType(int BookTypeId)
        {
            return bookType_dal.deleteBookType(BookTypeId);
        }

        //修改图书类型
        public int updateBookType(BookType type)
        {
            return bookType_dal.updateBookType(type);
        }
    }
}
