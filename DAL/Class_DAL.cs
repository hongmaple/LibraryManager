using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Class_DAL
    {
        public List<Class> selectClass()
        {
            string sql = "select * from Class";
            List<Class> list = new List<Class>();
            SqlDataReader reader = DBhelp.Create().ExecuteReader(sql);
            while (reader.Read())
            {
                Class c = new Class();
                c.ClassId = reader.GetInt32(0);
                c.ClassName = reader.GetString(1);
                list.Add(c);
            }
            reader.Close();
            return list;
        }

        public DataSet selectClass1()
        {
            string sql = "select * from Class";
            return DBhelp.Create().ExecuteAdater(sql);
        }

        public int AddClass(Class c)
        {
            string sql = "proc_addClass";
            SqlParameter[] sp ={
                                   new SqlParameter("@ClassId",DbType.Int32),
                                   new SqlParameter("@ClassName",c.ClassName),
                                   new SqlParameter("@ReturnValue",DbType.Int32)
                              };
            sp[0].Direction = ParameterDirection.Output;
            sp[2].Direction = ParameterDirection.ReturnValue;
            DBhelp.Create().ExecuteNonQuery(sql, CommandType.StoredProcedure, sp);
            c.ClassId = (int)sp[0].Value;
            return (int)sp[2].Value;
        }

        //删除班级
        public int deleteClass(int ClassId)
        {
            string sql = @"delete from Reader where ClassId=@ClassId
                            delete from Class where ClassId=@ClassId";
            SqlParameter[] sp ={
                                   new SqlParameter("@ClassId",ClassId)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);

        }

        //修改班级
        public int updateClass(Class c)
        {
            string sql = "update Class set ClassName=@ClassName where ClassId=@ClassId";
            SqlParameter[] sp ={
                                   new SqlParameter("@ClassId",c.ClassId),
                                   new SqlParameter("@ClassName",c.ClassName)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);

        }
    }
}
