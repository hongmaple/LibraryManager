using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UserType_DAL
    {
        //查询全部的用户类型
        public List<UserType> selectUserType()
        {
            List<UserType> list = new List<UserType>();
            string sql = @"select * from ReaderType";
            SqlDataReader User = DBhelp.Create().ExecuteReader(sql);
            while (User.Read())
            {
                UserType type = new UserType();
                type.UserTypeId = User.GetInt32(0);
                type.UserTypeName = User.GetString(1);
                list.Add(type);
            }
            User.Close();
            return list;
        }

        //查询全部的用户类型
        public DataSet selectUserType1()
        {
            string sql = @"select * from ReaderType";
            return DBhelp.Create().ExecuteAdater(sql);
        }

        //添加用户类型
        public int addUserType(UserType r)
        {
            string sql = "proc_addUserType";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserTypeId",DbType.Int32),
                                   new SqlParameter("@UserTypeName",r.UserTypeName),
                                   new SqlParameter("@ReturnValue",DbType.Int32)
                              };
            sp[0].Direction = ParameterDirection.Output;
            sp[2].Direction = ParameterDirection.ReturnValue;
            DBhelp.Create().ExecuteNonQuery(sql, CommandType.StoredProcedure, sp);
            r.UserTypeId = (int)sp[0].Value;
            return (int)sp[2].Value;
        }

        //删除用户类型
        public int deleteUser(int UserTypeId)
        {
            string sql = @"delete from BorrowReturn where UserId in(select UserId from User where UserTypeId=@UserTypeId)
                            delete from User where UserTypeId=@UserTypeId
                            delete from UserType where UserTypeId=@UserTypeId";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserTypeId",UserTypeId)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        //修改用户类型
        public int updateUserType(UserType r)
        {
            string sql = "update ReaderType set UserTypeName=@UserTypeName where UserTypeId=@UserTypeId";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserTypeId",r.UserTypeId),
                                   new SqlParameter("@UserTypeName",r.UserTypeName)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }
    }
}
