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
    public class UserType_BLL
    {
        UserType_DAL User_dal = new UserType_DAL();

        //查询全部的用户类型
        public List<UserType> selectUserType()
        {
            return User_dal.selectUserType();
        }

        //查询全部的用户类型
        public DataSet selectUserType1()
        {
            return User_dal.selectUserType1();
        }

        //添加用户类型
        public int addUserType(UserType r)
        {
            return User_dal.addUserType(r);
        }

        //删除用户类型
        public int deleteUser(int UserTypeId)
        {
            return User_dal.deleteUser(UserTypeId);
        }

        //修改用户类型
        public int updateUserType(UserType r)
        {
            return User_dal.updateUserType(r);
        }
    }
}
