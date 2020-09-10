using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data;


namespace BLL
{
    public class User_BLL
    {
        User_DAL user_dal = new User_DAL();

        //查询用户信息
        public DataSet selectUser()
        {
            return user_dal.selectUser();
        }

        //根据ID查询全部的用户信息
        public DataSet selectUser(int UserTypeId)
        {
            return user_dal.selectUser(UserTypeId);
        }

        //根据查询内容和条件查询的用户信息
        public DataSet selectUser(string A, string B)
        {
            return user_dal.selectUser(A, B);
        }

        //根据查询条件查询的用户信息
        public DataSet selectUser(List<string> list, string B)
        {
            return user_dal.selectUser(list, B);
        }

        //删除用户信息
        public int deleteUser(string UserId)
        {
            return user_dal.deleteUser(UserId);
        }

        //根据ID查询的用户信息
        public List<User> selectUser1(string UserId)
        {
            return user_dal.selectUser1(UserId);
        }

        //修改用户信息
        public int updateUser(User User)
        {
            return user_dal.updateUser(User);
        }

        //添加用户信息
        public int addUser(User r)
        {
            return user_dal.addUser(r);
        }

        //返回用户编号，用户姓名
        public List<User> selectUserId(string UserId)
        {
            return user_dal.selectUserId(UserId);
        }
    }
}
