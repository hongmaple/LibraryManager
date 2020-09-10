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
    public class User_DAL
    {
        //无条件查询用户信息
        public DataSet selectUser()
        {
            string sql = @"select UserId,UserName,TimeIn,TimeOut,UserTypeName,DepartmentName,ClassName,IdentityCard,Gender,QQ,Phone,Email,Address,UserRemark from Reader 
                            inner join ReaderType on ReaderType.UserTypeId=Reader.UserTypeId
                            inner join Department on Department.DepartmentId=Reader.DepartmentId
                            inner join Class on Class.ClassId=Reader.ClassId";
            return DBhelp.Create().ExecuteAdater(sql);
        }

        //根据用户类型ID查询用户信息
        public DataSet selectUser(int UserTypeId)
        {

            string sql = @"select UserId,UserName,TimeIn,TimeOut,UserTypeName,DepartmentName,ClassName,IdentityCard,Gender,QQ,Phone,Email,Address,UserRemark from Reader 
                            inner join ReaderType on ReaderType.UserTypeId=Reader.UserTypeId
                            inner join Department on Department.DepartmentId=Reader.DepartmentId
                            inner join Class on Class.ClassId=Reader.ClassId
                            where ReaderType.UserTypeId=@UserTypeId ";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserTypeId",UserTypeId)
                              };
            return DBhelp.Create().ExecuteAdater(sql, sp);
        }

        //根据ID查询用户信息
        public List<User> selectUser1(string UserId)
        {
            string sql = @"select UserId,UserName,TimeIn,TimeOut,UserTypeId,DepartmentId,ClassId,IdentityCard,
                            Gender,QQ,Phone,Email,Address,UserRemark from Reader";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserId",UserId)
                              };
            List<User> list = new List<User>();
            SqlDataReader User = DBhelp.Create().ExecuteReader(sql, sp);
            while (User.Read())
            {
                User r = new User();
                r.UserId = User.GetString(0);
                r.UserName = User.GetString(1);
                r.TimeIn = User.GetDateTime(2);
                r.TimeOut = User.GetDateTime(3);
                r.UserTypeId = User.GetInt32(4);
                r.DepartmentId = User.GetInt32(5);
                r.ClassId = User.GetInt32(6);
                r.IdentityCard = User.GetString(7);
                r.Gender = User.GetString(8);
                r.QQ = User.GetString(9);
                r.Phone = User.GetString(10);
                r.Email = User.GetString(11);
                r.Address = User.GetString(12);
                r.UserRemark = User.GetString(13);
                list.Add(r);
            }
            User.Close();
            return list;

        }

        //根据查询内容和条件查询的用户信息
        public DataSet selectUser(string A, string B)
        {

            string sql = string.Format(@"select UserId,UserName,TimeIn,TimeOut,UserTypeName,DepartmentName,ClassName,IdentityCard,Gender,QQ,Phone,Email,Address,UserRemark from Reader 
                            inner join ReaderType on ReaderType.UserTypeId=Reader.UserTypeId
                            inner join Department on Department.DepartmentId=Reader.DepartmentId
                            inner join Class on Class.ClassId=Reader.ClassId
                            where {0} like '%{1}%'", A, B);
            return DBhelp.Create().ExecuteAdater(sql);
        }

        //根据查询条件查询用户信息
        public DataSet selectUser(List<string> list, string B)
        {
            string sql = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    sql += string.Format(@"select UserId,UserName,TimeIn,TimeOut,UserTypeName,DepartmentName,ClassName,IdentityCard,Gender,QQ,Phone,Email,Address,UserRemark from Reader 
                            inner join UserType on ReaderType.UserTypeId=Reader.UserTypeId
                            inner join Department on Department.DepartmentId=Reader.DepartmentId
                            inner join Class on Class.ClassId=Reader.ClassId
                            where {0} like '%{1}%' union  ", list[i], B);
                }
                else
                {
                    sql += string.Format(@"select UserId,UserName,TimeIn,TimeOut,UserTypeName,DepartmentName,ClassName,IdentityCard,Gender,QQ,Phone,Email,Address,UserRemark from Reader 
                            inner join ReaderType on ReaderType.UserTypeId=Reader.UserTypeId
                            inner join Department on Department.DepartmentId=Reader.DepartmentId
                            inner join Class on Class.ClassId=Reader.ClassId
                            where {0} like '%{1}%' ", list[i], B);
                }
            }
            return DBhelp.Create().ExecuteAdater(sql);
        }

        //删除用户信息
        public int deleteUser(string UserId)
        {
            string sql = @"
                            delete from BorrowReturn where UserId=@UserId
                            delete from Reader where UserId=@UserId";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserId",UserId)
                              };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        //修改用户信息
        public int updateUser(User User)
        {
            string sql = @"update Reader set UserName=@UserName,TimeIn=@TimeIn,TimeOut=@TimeOut,UserTypeId=@UserTypeId,DepartmentId=@DepartmentId,ClassId=@ClassId,IdentityCard=@IdentityCard,Gender=@Gender,QQ=@QQ,Phone=@Phone,Email=@Email,Address=@Address,UserRemark=@UserRemark where UserId=@UserId";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserName",User.UserName),
                                   new SqlParameter("@TimeIn",User.TimeIn),
                                   new SqlParameter("@TimeOut",User.TimeOut),
                                   new SqlParameter("@UserTypeId",User.UserTypeId),
                                   new SqlParameter("@DepartmentId",User.DepartmentId),
                                   new SqlParameter("@ClassId",User.ClassId),
                                   new SqlParameter("@IdentityCard",User.IdentityCard),
                                   new SqlParameter("@Gender",User.Gender),
                                   new SqlParameter("@QQ",User.QQ),
                                   new SqlParameter("@Phone",User.Phone),
                                   new SqlParameter("@Email",User.Email),
                                   new SqlParameter("@Address",User.Address),
                                   new SqlParameter("@UserRemark",User.UserRemark),
                                   new SqlParameter("@UserId",User.UserId)
                               };
            return DBhelp.Create().ExecuteNonQuery(sql, sp: sp);
        }

        //添加用户信息
        public int addUser(User r)
        {
            string sql = "proc_AddUser";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserId",r.UserId),
                                   new SqlParameter("@UserName",r.UserName),
                                   new SqlParameter("@TimeIn",r.TimeIn),
                                   new SqlParameter("@TimeOut",r.TimeOut),
                                   new SqlParameter("@UserTypeId",r.UserTypeId),
                                   new SqlParameter("@DepartmentId",r.DepartmentId),
                                   new SqlParameter("@ClassId",r.ClassId),
                                   new SqlParameter("@IdentityCard",r.IdentityCard),
                                   new SqlParameter("@Gender",r.Gender),
                                   new SqlParameter("@QQ",r.QQ),
                                   new SqlParameter("@Phone",r.Phone),
                                   new SqlParameter("@Email",r.Email),
                                   new SqlParameter("@Address",r.Address),
                                   new SqlParameter("@UserRemark",r.UserRemark),
                                   new SqlParameter("@ReturnValue",DbType.Int32)
                               };
            sp[sp.Length - 1].Direction = ParameterDirection.ReturnValue;
            DBhelp.Create().ExecuteNonQuery(sql, CommandType.StoredProcedure, sp);
            return (int)sp[sp.Length - 1].Value;
        }

        //返回用户编号，用户姓名
        public List<User> selectUserId(string UserId)
        {
            string sql = "select UserId,UserName from User where UserId like '%'+@UserId+'%' ";
            SqlParameter[] sp ={
                                   new SqlParameter("@UserId",UserId)
                               };
            SqlDataReader User = DBhelp.Create().ExecuteReader(sql, sp: sp);
            List<User> list = new List<User>();
            while (User.Read())
            {
                User r = new User();
                r.UserId = User["UserId"].ToString();
                r.UserName = User["UserName"].ToString();
                list.Add(r);
            }
            User.Close();
            return list;
        }
    }
}
